using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	// Token: 0x020000C2 RID: 194
	public class Group : GroupBase
	{
		// Token: 0x06000462 RID: 1122 RVA: 0x00004776 File Offset: 0x00002976
		protected Group()
		{
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x0000477E File Offset: 0x0000297E
		internal static Group CreateForAddDialog()
		{
			return new Group();
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00017380 File Offset: 0x00015580
		public static Group Create(string name, GroupBase parent)
		{
			Group group = new Group();
			group.Properties.GroupName.Value = name;
			group.FinishConstruction(parent);
			return group;
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x000173AC File Offset: 0x000155AC
		internal static Group Create(GroupPropertiesDialog dlg)
		{
			Group group = dlg.AssociatedNode as Group;
			group.UpdateSettings(dlg);
			group.FinishConstruction(dlg.PropertiesPage.ParentGroup);
			return group;
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x000173E0 File Offset: 0x000155E0
		internal static Group Create(XmlNode xmlNode, GroupBase parent, ICollection<string> errors)
		{
			Group group = new Group();
			group.ReadXml(xmlNode, errors);
			group.FinishConstruction(parent);
			return group;
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00004785 File Offset: 0x00002985
		protected override void InitSettings()
		{
			base.Properties = new GroupSettings();
			base.InitSettings();
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00004798 File Offset: 0x00002998
		internal override void WriteXml(XmlTextWriter tw)
		{
			tw.WriteStartElement("group");
			base.WriteXml(tw);
			tw.WriteEndElement();
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00017404 File Offset: 0x00015604
		public override void DoPropertiesDialog(Form parentForm, string activeTabName)
		{
			using (GroupPropertiesDialog groupPropertiesDialog = GroupPropertiesDialog.NewPropertiesDialog(this, parentForm))
			{
				groupPropertiesDialog.SetActiveTab(activeTabName);
				if (groupPropertiesDialog.ShowDialog() == DialogResult.OK)
				{
					this.UpdateSettings(groupPropertiesDialog);
					ServerTree.Instance.OnNodeChanged(this, ChangeType.PropertyChanged);
				}
			}
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x000047B2 File Offset: 0x000029B2
		private void FinishConstruction(GroupBase parent)
		{
			base.Text = base.Properties.GroupName.Value;
			ServerTree.Instance.AddNode(this, parent);
			this.ChangeImageIndex(ImageConstants.Group);
		}

		// Token: 0x0400041A RID: 1050
		public const string XmlNodeName = "group";
	}
}
