using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000047 RID: 71
	internal partial class SmartGroupPropertiesDialog : NodePropertiesDialog
	{
		// Token: 0x060001C8 RID: 456 RVA: 0x0000B284 File Offset: 0x00009484
		protected SmartGroupPropertiesDialog(SmartGroup group, string dialogTitle, string acceptButtonText, Form parentForm) : base(group, dialogTitle, acceptButtonText, parentForm)
		{
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000B294 File Offset: 0x00009494
		public override void CreateControls(RdcTreeNode settings)
		{
			TabPage tabPage = settings.Properties.CreateTabPage(this);
			base.PropertiesPage = (tabPage as INodePropertiesPage);
			base.AddTabPage(tabPage);
			this.InitButtons();
			this.ScaleAndLayout();
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000B2D4 File Offset: 0x000094D4
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

		// Token: 0x060001CB RID: 459 RVA: 0x0000B334 File Offset: 0x00009534
		public static SmartGroupPropertiesDialog NewPropertiesDialog(SmartGroup group, Form parentForm)
		{
			SmartGroupPropertiesDialog smartGroupPropertiesDialog = new SmartGroupPropertiesDialog(group, group.Text + " Smart Group Properties", "OK", parentForm);
			smartGroupPropertiesDialog.CreateControls(group);
			smartGroupPropertiesDialog.PropertiesPage.PopulateParentDropDown(group, group.Parent as GroupBase);
			return smartGroupPropertiesDialog;
		}
	}
}
