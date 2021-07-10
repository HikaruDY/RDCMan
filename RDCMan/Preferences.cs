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
	// Token: 0x020000F2 RID: 242
	[SettingsProvider(typeof(RdcSettingsProvider))]
	public sealed partial class Preferences : ApplicationSettingsBase
	{
		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060005FF RID: 1535 RVA: 0x00005A35 File Offset: 0x00003C35
		// (set) Token: 0x06000600 RID: 1536 RVA: 0x00005A3D File Offset: 0x00003C3D
		public bool NeedToSave { get; set; }

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x00005A46 File Offset: 0x00003C46
		// (set) Token: 0x06000602 RID: 1538 RVA: 0x00005A4E File Offset: 0x00003C4E
		public GlobalSettings Settings { get; private set; }

		// Token: 0x06000603 RID: 1539 RVA: 0x0001AAB8 File Offset: 0x00018CB8
		private Preferences()
		{
			this.Settings = new GlobalSettings();
			string name = Assembly.GetExecutingAssembly().GetName().Name;
			this.SettingsDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Application.CompanyName, Application.ProductName);
			this.SettingsPath = Path.Combine(this.SettingsDirectory, name + ".settings");
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00005A57 File Offset: 0x00003C57
		public object GetTransferValue(string name)
		{
			return base[name];
		}

		// Token: 0x170000D9 RID: 217
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

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x00005A7D File Offset: 0x00003C7D
		// (set) Token: 0x06000608 RID: 1544 RVA: 0x00005A85 File Offset: 0x00003C85
		private string SettingsDirectory { get; set; }

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x00005A8E File Offset: 0x00003C8E
		// (set) Token: 0x0600060A RID: 1546 RVA: 0x00005A96 File Offset: 0x00003C96
		private string SettingsPath { get; set; }

		// Token: 0x0600060B RID: 1547 RVA: 0x0001AB20 File Offset: 0x00018D20
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

		// Token: 0x0600060C RID: 1548 RVA: 0x0001AE14 File Offset: 0x00019014
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

		// Token: 0x0600060D RID: 1549 RVA: 0x0001AEDC File Offset: 0x000190DC
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

		// Token: 0x0600060E RID: 1550 RVA: 0x0001B088 File Offset: 0x00019288
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

		// Token: 0x0600060F RID: 1551 RVA: 0x00005A9F File Offset: 0x00003C9F
		private void CollectFilesToOpen()
		{
			this.FilesToOpen = (from file in ServerTree.Instance.Nodes.OfType<FileGroup>()
			select file.Pathname).ToList<string>();
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x0001B158 File Offset: 0x00019358
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
								tw.WriteAttributeString("path", p.GetType().AssemblyQualifiedName);
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

		// Token: 0x06000611 RID: 1553 RVA: 0x0001B224 File Offset: 0x00019424
		internal bool GetBuiltInGroupVisibility(IBuiltInVirtualGroup builtInGroup)
		{
			string propertyName = string.Format("Show{0}Group", builtInGroup.ConfigPropertyName);
			return (bool)this[propertyName];
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x0001B250 File Offset: 0x00019450
		internal void SetBuiltInGroupVisibility(IBuiltInVirtualGroup builtInGroup, bool value)
		{
			string propertyName = string.Format("Show{0}Group", builtInGroup.ConfigPropertyName);
			this[propertyName] = value;
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600061F RID: 1567 RVA: 0x00005BBD File Offset: 0x00003DBD
		// (set) Token: 0x06000620 RID: 1568 RVA: 0x00005BCF File Offset: 0x00003DCF
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

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000621 RID: 1569 RVA: 0x00005BDD File Offset: 0x00003DDD
		// (set) Token: 0x06000622 RID: 1570 RVA: 0x00005BEF File Offset: 0x00003DEF
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

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x00005BFD File Offset: 0x00003DFD
		// (set) Token: 0x06000624 RID: 1572 RVA: 0x00005C0F File Offset: 0x00003E0F
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

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000641 RID: 1601 RVA: 0x00005E23 File Offset: 0x00004023
		// (set) Token: 0x06000642 RID: 1602 RVA: 0x00005E35 File Offset: 0x00004035
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
