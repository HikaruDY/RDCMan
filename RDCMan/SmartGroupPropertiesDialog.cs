using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000077 RID: 119
	internal partial class SmartGroupPropertiesDialog : NodePropertiesDialog
	{
		// Token: 0x06000234 RID: 564 RVA: 0x00002CE9 File Offset: 0x00000EE9
		protected SmartGroupPropertiesDialog(SmartGroup group, string dialogTitle, string acceptButtonText, Form parentForm) : base(group, dialogTitle, acceptButtonText, parentForm)
		{
		}

		// Token: 0x06000235 RID: 565 RVA: 0x000106F4 File Offset: 0x0000E8F4
		public override void CreateControls(RdcTreeNode settings)
		{
			TabPage tabPage = settings.Properties.CreateTabPage(this);
			base.PropertiesPage = (tabPage as INodePropertiesPage);
			base.AddTabPage(tabPage);
			this.InitButtons();
			this.ScaleAndLayout();
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00010730 File Offset: 0x0000E930
		public static SmartGroupPropertiesDialog NewAddDialog(GroupBase parent)
		{
			SmartGroup smartGroup = SmartGroup.CreateForAdd();
			SmartGroupPropertiesDialog smartGroupPropertiesDialog = new SmartGroupPropertiesDialog(smartGroup, "Add Smart Group", "Add", null);
			if (parent != null && !parent.CanAddGroups())
			{
				parent = null;
			}
			smartGroupPropertiesDialog.CreateControls(smartGroup);
			if (!smartGroupPropertiesDialog.PropertiesPage.PopulateParentDropDown(null, parent))
			{
				smartGroupPropertiesDialog.Dispose();
				return null;
			}
			return smartGroupPropertiesDialog;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00010784 File Offset: 0x0000E984
		public static SmartGroupPropertiesDialog NewPropertiesDialog(SmartGroup group, Form parentForm)
		{
			SmartGroupPropertiesDialog smartGroupPropertiesDialog = new SmartGroupPropertiesDialog(group, group.Text + " Smart Group Properties", "OK", parentForm);
			smartGroupPropertiesDialog.CreateControls(group);
			smartGroupPropertiesDialog.PropertiesPage.PopulateParentDropDown(group, group.Parent as GroupBase);
			return smartGroupPropertiesDialog;
		}
	}
}
