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
	// Token: 0x0200008F RID: 143
	[SettingsProvider(typeof(RdcSettingsProvider))]
	public sealed partial class Preferences : ApplicationSettingsBase
	{
		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060004D2 RID: 1234 RVA: 0x00018164 File Offset: 0x00016364
		// (set) Token: 0x060004D3 RID: 1235 RVA: 0x0001816C File Offset: 0x0001636C
		public bool NeedToSave { get; set; }

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x00018178 File Offset: 0x00016378
		// (set) Token: 0x060004D5 RID: 1237 RVA: 0x00018180 File Offset: 0x00016380
		public GlobalSettings Settings { get; private set; }

		// Token: 0x060004D6 RID: 1238 RVA: 0x0001818C File Offset: 0x0001638C
		private Preferences()
		{
			this.Settings = new GlobalSettings();
			string name = Assembly.GetExecutingAssembly().GetName().Name;
			this.SettingsDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Application.CompanyName, Application.ProductName);
			this.SettingsPath = Path.Combine(this.SettingsDirectory, name + ".settings");
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x000181F8 File Offset: 0x000163F8
		public object GetTransferValue(string name)
		{
			return base[name];
		}

		// Token: 0x170000CC RID: 204
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

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x00018224 File Offset: 0x00016424
		// (set) Token: 0x060004DB RID: 1243 RVA: 0x0001822C File Offset: 0x0001642C
		private string SettingsDirectory { get; set; }

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x00018238 File Offset: 0x00016438
		// (set) Token: 0x060004DD RID: 1245 RVA: 0x00018240 File Offset: 0x00016440
		private string SettingsPath { get; set; }

		// Token: 0x060004DE RID: 1246 RVA: 0x0001824C File Offset: 0x0001644C
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

		// Token: 0x060004DF RID: 1247 RVA: 0x00018578 File Offset: 0x00016778
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

		// Token: 0x060004E0 RID: 1248 RVA: 0x0001864C File Offset: 0x0001684C
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

		// Token: 0x060004E1 RID: 1249 RVA: 0x00018810 File Offset: 0x00016A10
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

		// Token: 0x060004E2 RID: 1250 RVA: 0x000188EC File Offset: 0x00016AEC
		private void CollectFilesToOpen()
		{
			this.FilesToOpen = (from file in ServerTree.Instance.Nodes.OfType<FileGroup>()
			select file.Pathname).ToList<string>();
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00018940 File Offset: 0x00016B40
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

		// Token: 0x060004E4 RID: 1252 RVA: 0x00018A14 File Offset: 0x00016C14
		internal bool GetBuiltInGroupVisibility(IBuiltInVirtualGroup builtInGroup)
		{
			string propertyName = string.Format("Show{0}Group", builtInGroup.ConfigPropertyName);
			return (bool)this[propertyName];
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00018A44 File Offset: 0x00016C44
		internal void SetBuiltInGroupVisibility(IBuiltInVirtualGroup builtInGroup, bool value)
		{
			string propertyName = string.Format("Show{0}Group", builtInGroup.ConfigPropertyName);
			this[propertyName] = value;
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x00018B64 File Offset: 0x00016D64
		// (set) Token: 0x060004F3 RID: 1267 RVA: 0x00018B78 File Offset: 0x00016D78
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

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060004F4 RID: 1268 RVA: 0x00018B88 File Offset: 0x00016D88
		// (set) Token: 0x060004F5 RID: 1269 RVA: 0x00018B9C File Offset: 0x00016D9C
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

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060004F6 RID: 1270 RVA: 0x00018BAC File Offset: 0x00016DAC
		// (set) Token: 0x060004F7 RID: 1271 RVA: 0x00018BC0 File Offset: 0x00016DC0
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

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x00018E00 File Offset: 0x00017000
		// (set) Token: 0x06000515 RID: 1301 RVA: 0x00018E14 File Offset: 0x00017014
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
