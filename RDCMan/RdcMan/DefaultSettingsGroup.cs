using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	internal class DefaultSettingsGroup : VirtualGroup
	{
		public static DefaultSettingsGroup Instance { get; private set; } = new DefaultSettingsGroup();

		private DefaultSettingsGroup()
		{
			this.EncryptionSettings = new EncryptionSettings();
			base.AllSettingsGroups.Add(this.EncryptionSettings);
			foreach (SettingsGroup settingsGroup in base.AllSettingsGroups)
			{
				settingsGroup.InheritSettingsType.Mode = InheritanceMode.Disabled;
			}
		}

		public override EncryptionSettings EncryptionSettings { get; protected set; }

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

		internal override void WriteXml(XmlTextWriter tw)
		{
			tw.WriteStartElement("defaultSettings");
			base.WriteXmlSettingsGroups(tw);
			tw.WriteEndElement();
		}

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

		public new const string Name = "Default settings group";

		private const string XmlTopNode = "defaultSettings";
	}
}
