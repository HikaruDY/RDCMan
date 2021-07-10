using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	// Token: 0x020000BC RID: 188
	internal class DefaultSettingsGroup : VirtualGroup
	{
		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x000045AC File Offset: 0x000027AC
		// (set) Token: 0x06000434 RID: 1076 RVA: 0x000045B3 File Offset: 0x000027B3
		public static DefaultSettingsGroup Instance { get; private set; } // = new DefaultSettingsGroup();

		// Token: 0x06000436 RID: 1078 RVA: 0x00016DEC File Offset: 0x00014FEC
		private DefaultSettingsGroup()
		{
			this.EncryptionSettings = new EncryptionSettings();
			base.AllSettingsGroups.Add(this.EncryptionSettings);
			foreach (SettingsGroup settingsGroup in base.AllSettingsGroups)
			{
				settingsGroup.InheritSettingsType.Mode = InheritanceMode.Disabled;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x000045C7 File Offset: 0x000027C7
		// (set) Token: 0x06000438 RID: 1080 RVA: 0x000045CF File Offset: 0x000027CF
		public override EncryptionSettings EncryptionSettings { get; protected set; }

		// Token: 0x06000439 RID: 1081 RVA: 0x00016E68 File Offset: 0x00015068
		internal override void ReadXml(XmlNode node, ICollection<string> errors)
		{
			if (!node.Name.Equals("defaultSettings"))
			{
				errors.Add("Default settings group malformed");
				return;
			}
			foreach (object obj in node.ChildNodes)
			{
				XmlNode xmlNode = (XmlNode)obj;
				base.ReadXmlSettingsGroup(xmlNode, errors);
			}
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x000045D8 File Offset: 0x000027D8
		internal override void WriteXml(XmlTextWriter tw)
		{
			tw.WriteStartElement("defaultSettings");
			base.WriteXmlSettingsGroups(tw);
			tw.WriteEndElement();
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00016EE0 File Offset: 0x000150E0
		public override void DoPropertiesDialog(Form parentForm, string activeTabName)
		{
			using (DefaultGroupPropertiesDialog defaultGroupPropertiesDialog = DefaultGroupPropertiesDialog.NewPropertiesDialog(this, parentForm))
			{
				defaultGroupPropertiesDialog.SetActiveTab(activeTabName);
				if (defaultGroupPropertiesDialog.ShowDialog() == DialogResult.OK)
				{
					this.UpdateSettings(defaultGroupPropertiesDialog);
					ServerTree.Instance.OnGroupChanged(ServerTree.Instance.RootNode, ChangeType.PropertyChanged);
					Program.Preferences.NeedToSave = true;
				}
			}
		}

		// Token: 0x0400040B RID: 1035
		public new const string Name = "Default settings group";

		// Token: 0x0400040D RID: 1037
		private const string XmlTopNode = "defaultSettings";
	}
}
