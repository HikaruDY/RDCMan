using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	// Token: 0x02000072 RID: 114
	internal class DefaultSettingsGroup : VirtualGroup
	{
		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000354 RID: 852 RVA: 0x00012D44 File Offset: 0x00010F44
		// (set) Token: 0x06000355 RID: 853 RVA: 0x00012D4C File Offset: 0x00010F4C
		public static DefaultSettingsGroup Instance { get; private set; } = new DefaultSettingsGroup();

		// Token: 0x06000357 RID: 855 RVA: 0x00012D60 File Offset: 0x00010F60
		private DefaultSettingsGroup()
		{
			this.EncryptionSettings = new EncryptionSettings();
			base.AllSettingsGroups.Add(this.EncryptionSettings);
			foreach (SettingsGroup settingsGroup in base.AllSettingsGroups)
			{
				settingsGroup.InheritSettingsType.Mode = InheritanceMode.Disabled;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000358 RID: 856 RVA: 0x00012DE0 File Offset: 0x00010FE0
		// (set) Token: 0x06000359 RID: 857 RVA: 0x00012DE8 File Offset: 0x00010FE8
		public override EncryptionSettings EncryptionSettings { get; protected set; }

		// Token: 0x0600035A RID: 858 RVA: 0x00012DF4 File Offset: 0x00010FF4
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

		// Token: 0x0600035B RID: 859 RVA: 0x00012E78 File Offset: 0x00011078
		internal override void WriteXml(XmlTextWriter tw)
		{
			tw.WriteStartElement("defaultSettings");
			base.WriteXmlSettingsGroups(tw);
			tw.WriteEndElement();
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00012E94 File Offset: 0x00011094
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

		// Token: 0x04000195 RID: 405
		public new const string Name = "Default settings group";

		// Token: 0x04000197 RID: 407
		private const string XmlTopNode = "defaultSettings";
	}
}
