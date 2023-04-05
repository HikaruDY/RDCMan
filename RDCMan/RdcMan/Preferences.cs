using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	[SettingsProvider(typeof(RdcSettingsProvider))]
	public sealed partial class Preferences : ApplicationSettingsBase
	{
		public bool NeedToSave { get; set; }

		public GlobalSettings Settings { get; private set; }

		private Preferences()
		{
			this.Settings = new GlobalSettings();
			string name = Assembly.GetExecutingAssembly().GetName().Name;
			this.SettingsDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Application.CompanyName, Application.ProductName);
			this.SettingsPath = Path.Combine(this.SettingsDirectory, name + ".settings");
		}

		public object GetTransferValue(string name)
		{
			return base[name];
		}

		public override object this[string propertyName]
		{
			get
			{
				return this.Settings.GetValue(propertyName);
			}
			set
			{
				this.Settings.SetValue(propertyName, value);
			}
		}

		private string SettingsDirectory { get; set; }

		private string SettingsPath { get; set; }

		public static Preferences Load()
		{
			Preferences preferences = new Preferences();
			if (Program.ResetPreferences)
			{
				return preferences;
			}
			List<string> list = new List<string>();
			string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Microsoft Corporation", Application.ProductName);
			string text2 = Path.Combine(text, "RDCMan.settings");
			if (File.Exists(text2))
			{
				if (!File.Exists(preferences.SettingsPath))
				{
					Directory.CreateDirectory(preferences.SettingsDirectory);
					File.Move(text2, preferences.SettingsPath);
				}
				try
				{
					Directory.Delete(text);
				}
				catch
				{
				}
			}
			bool flag = true;
			try
			{
				using (XmlTextReader xmlTextReader = new XmlTextReader(preferences.SettingsPath)
				{
					DtdProcessing = DtdProcessing.Ignore
				})
				{
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.Load(xmlTextReader);
					XmlNode lastChild = xmlDocument.LastChild;
					try
					{
						string value = lastChild.Attributes["programVersion"].Value;
						preferences.Settings.ReadXml(lastChild, null, list);
						flag = false;
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			if (flag)
			{
				preferences.Settings.TransferPreferences(preferences);
				if (preferences.DefaultGroupSettings != null)
				{
					MemoryStream input = new MemoryStream(preferences.DefaultGroupSettings);
					XmlTextReader xmlTextReader2 = new XmlTextReader(input)
					{
						WhitespaceHandling = WhitespaceHandling.None,
						DtdProcessing = DtdProcessing.Ignore
					};
					xmlTextReader2.MoveToContent();
					XmlDocument xmlDocument2 = new XmlDocument();
					XmlNode xmlNode = xmlDocument2.ReadNode(xmlTextReader2);
					xmlTextReader2.Close();
					GroupBase.SchemaVersion = 2;
					DefaultSettingsGroup.Instance.ReadXml(xmlNode, list);
				}
				if (preferences.CredentialsProfiles != null)
				{
					MemoryStream input2 = new MemoryStream(preferences.CredentialsProfiles);
					XmlTextReader xmlTextReader3 = new XmlTextReader(input2)
					{
						WhitespaceHandling = WhitespaceHandling.None,
						DtdProcessing = DtdProcessing.Ignore
					};
					xmlTextReader3.MoveToContent();
					XmlDocument xmlDocument3 = new XmlDocument();
					XmlNode xmlNode2 = xmlDocument3.ReadNode(xmlTextReader3);
					xmlTextReader3.Close();
					Program.CredentialsProfiles.ReadXml(xmlNode2, ProfileScope.Global, DefaultSettingsGroup.Instance, list);
				}
			}
			else
			{
				if (preferences.Settings.DefaultGroupSettings != null)
				{
					XmlNode firstChild = preferences.Settings.DefaultGroupSettings.Value.FirstChild;
					DefaultSettingsGroup.Instance.ReadXml(firstChild, list);
				}
				if (preferences.Settings.CredentialsProfiles != null)
				{
					XmlNode firstChild2 = preferences.Settings.CredentialsProfiles.Value.FirstChild;
					Program.CredentialsProfiles.ReadXml(firstChild2, ProfileScope.Global, DefaultSettingsGroup.Instance, list);
				}
			}
			Encryption.DecryptPasswords();
			if (list.Count > 0)
			{
				StringBuilder stringBuilder = new StringBuilder("The following errors were encountered:").AppendLine().AppendLine();
				foreach (string value2 in list)
				{
					stringBuilder.AppendLine(value2);
				}
				stringBuilder.AppendLine().Append("Your global configuration has not loaded completely. If it is saved it almost certainly means losing information. Continue?");
				DialogResult dialogResult = FormTools.ExclamationDialog(stringBuilder.ToString(), MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.No)
				{
					return null;
				}
			}
			return preferences;
		}

		public void LoadBuiltInGroups()
		{
			if (this.Settings.BuiltInGroups.Value != null)
			{
				GroupBase.SchemaVersion = 3;
				XmlNode firstChild = this.Settings.BuiltInGroups.Value.FirstChild;
				List<string> errors = new List<string>();
				using (IEnumerator enumerator = firstChild.ChildNodes.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						XmlNode childNode = (XmlNode)enumerator.Current;
						IBuiltInVirtualGroup builtInVirtualGroup = (from v in Program.BuiltInVirtualGroups
						where childNode.Name.Equals(v.XmlNodeName)
						select v).FirstOrDefault<IBuiltInVirtualGroup>();
						if (builtInVirtualGroup != null)
						{
							builtInVirtualGroup.ReadXml(childNode, null, errors);
						}
					}
				}
			}
		}

		public override void Save()
		{
			if (!this.NeedToSave)
			{
				return;
			}
			using (StringWriter stringWriter = new StringWriter())
			{
				using (XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter))
				{
					DefaultSettingsGroup.Instance.WriteXml(xmlTextWriter);
					xmlTextWriter.Flush();
					xmlTextWriter.Close();
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.LoadXml(stringWriter.ToString());
					this.Settings.DefaultGroupSettings.Value = xmlDocument.LastChild;
				}
			}
			using (StringWriter stringWriter2 = new StringWriter())
			{
				using (XmlTextWriter xmlTextWriter2 = new XmlTextWriter(stringWriter2))
				{
					Program.CredentialsProfiles.WriteXml(xmlTextWriter2, DefaultSettingsGroup.Instance);
					xmlTextWriter2.Flush();
					xmlTextWriter2.Close();
					XmlDocument xmlDocument2 = new XmlDocument();
					xmlDocument2.LoadXml(stringWriter2.ToString());
					this.Settings.CredentialsProfiles.Value = xmlDocument2.LastChild;
				}
			}
			this.CollectFilesToOpen();
			this.SerializeBuiltInGroups();
			this.SerializePluginSettings();
			string temporaryFileName = Helpers.GetTemporaryFileName(this.SettingsPath, ".new");
			using (XmlTextWriter xmlTextWriter3 = new XmlTextWriter(temporaryFileName, Encoding.UTF8))
			{
				xmlTextWriter3.Formatting = Formatting.Indented;
				xmlTextWriter3.WriteStartDocument();
				this.Settings.WriteXml(xmlTextWriter3, null);
				xmlTextWriter3.WriteEndDocument();
				xmlTextWriter3.Close();
				Helpers.MoveTemporaryToPermanent(temporaryFileName, this.SettingsPath, false);
			}
			this.NeedToSave = false;
		}

		private void SerializeBuiltInGroups()
		{
			using (StringWriter stringWriter = new StringWriter())
			{
				using (XmlTextWriter tw = new XmlTextWriter(stringWriter))
				{
					tw.WriteStartElement("groups");
					Program.BuiltInVirtualGroups.ForEach(delegate(IBuiltInVirtualGroup virtualGroup)
					{
						if (!string.IsNullOrEmpty(virtualGroup.XmlNodeName))
						{
							virtualGroup.WriteXml(tw, null);
						}
					});
					tw.WriteEndElement();
					tw.Flush();
					tw.Close();
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.LoadXml(stringWriter.ToString());
					this.Settings.BuiltInGroups.Value = xmlDocument.LastChild;
				}
			}
		}

		private void CollectFilesToOpen()
		{
			this.FilesToOpen = (from file in ServerTree.Instance.Nodes.OfType<FileGroup>()
			select file.Pathname).ToList<string>();
		}

		private void SerializePluginSettings()
		{
			using (StringWriter stringWriter = new StringWriter())
			{
				using (XmlTextWriter tw = new XmlTextWriter(stringWriter))
				{
					tw.WriteStartElement("plugins");
					Program.PluginAction(delegate(IPlugin p)
					{
						try
						{
							XmlNode xmlNode = p.SaveSettings();
							if (xmlNode != null)
							{
								tw.WriteStartElement("plugin");
								tw.WriteAttributeString("path", p.GetType().Assembly.GetName().Name);
								xmlNode.WriteTo(tw);
								tw.WriteEndElement();
							}
						}
						catch
						{
						}
					});
					tw.WriteEndElement();
					tw.Flush();
					tw.Close();
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.LoadXml(stringWriter.ToString());
					this.Settings.PluginSettings.Value = xmlDocument.LastChild;
				}
			}
		}

		internal bool GetBuiltInGroupVisibility(IBuiltInVirtualGroup builtInGroup)
		{
			string propertyName = string.Format("Show{0}Group", builtInGroup.ConfigPropertyName);
			return (bool)this[propertyName];
		}

		internal void SetBuiltInGroupVisibility(IBuiltInVirtualGroup builtInGroup, bool value)
		{
			string propertyName = string.Format("Show{0}Group", builtInGroup.ConfigPropertyName);
			this[propertyName] = value;
		}

		[UserScopedSetting]
		public List<string> FilesToOpen
		{
			get
			{
				return (List<string>)this["FilesToOpen"];
			}
			set
			{
				this["FilesToOpen"] = value;
			}
		}

		[UserScopedSetting]
		public byte[] CredentialsProfiles
		{
			get
			{
				return (byte[])base["CredentialsProfiles"];
			}
			set
			{
				base["CredentialsProfiles"] = value;
			}
		}

		[UserScopedSetting]
		public XmlDocument CredentialsProfilesXml
		{
			get
			{
				return (XmlDocument)this["CredentialsProfilesXml"];
			}
			set
			{
				this["CredentialsProfilesXml"] = value;
			}
		}

		[UserScopedSetting]
		public byte[] DefaultGroupSettings
		{
			get
			{
				return (byte[])base["DefaultGroupSettings"];
			}
			set
			{
				base["DefaultGroupSettings"] = value;
			}
		}
	}
}
