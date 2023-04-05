using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	// Token: 0x02000076 RID: 118
	public class Group : GroupBase
	{
		// Token: 0x0600037E RID: 894 RVA: 0x00013500 File Offset: 0x00011700
		protected Group()
		{
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00013508 File Offset: 0x00011708
		internal static Group CreateForAddDialog()
		{
			return new Group();
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00013510 File Offset: 0x00011710
		public static Group Create(string name, GroupBase parent)
		{
			Group group = new Group();
			group.Properties.GroupName.Value = name;
			group.FinishConstruction(parent);
			return group;
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00013540 File Offset: 0x00011740
		internal static Group Create(GroupPropertiesDialog dlg)
		{
			Group group = dlg.AssociatedNode as Group;
			group.UpdateSettings(dlg);
			group.FinishConstruction(dlg.PropertiesPage.ParentGroup);
			return group;
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00013578 File Offset: 0x00011778
		internal static Group Create(XmlNode xmlNode, GroupBase parent, ICollection<string> errors)
		{
			Group group = new Group();
			group.ReadXml(xmlNode, errors);
			group.FinishConstruction(parent);
			return group;
		}

		// Token: 0x06000383 RID: 899 RVA: 0x000135A0 File Offset: 0x000117A0
		protected override void InitSettings()
		{
			base.Properties = new GroupSettings();
			base.InitSettings();
		}

		// Token: 0x06000384 RID: 900 RVA: 0x000135B4 File Offset: 0x000117B4
		internal override void WriteXml(XmlTextWriter tw)
		{
			tw.WriteStartElement("group");
			base.WriteXml(tw);
			tw.WriteEndElement();
		}

		// Token: 0x06000385 RID: 901 RVA: 0x000135D0 File Offset: 0x000117D0
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

		// Token: 0x06000386 RID: 902 RVA: 0x00013634 File Offset: 0x00011834
		private void FinishConstruction(GroupBase parent)
		{
			base.Text = base.Properties.GroupName.Value;
			ServerTree.Instance.AddNode(this, parent);
			this.ChangeImageIndex(ImageConstants.Group);
		}

		// Token: 0x040001A1 RID: 417
		public const string XmlNodeName = "group";
	}
}
