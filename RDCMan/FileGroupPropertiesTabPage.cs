using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000060 RID: 96
	internal class FileGroupPropertiesTabPage : GroupBasePropertiesTabPage<FileGroupSettings>
	{
		// Token: 0x0600019A RID: 410 RVA: 0x0000E31C File Offset: 0x0000C51C
		public FileGroupPropertiesTabPage(TabbedSettingsDialog dialog, FileGroupSettings settings) : base(dialog, settings, settings.Name)
		{
			int num = 0;
			int num2 = 0;
			base.AddGroupName(ref num, ref num2);
			this._pathnameTextBox = FormTools.AddLabeledTextBox(this, "Path name:", ref num, ref num2);
			base.AddComment(ref num, ref num2).Setting = base.Settings.Comment;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00002D8C File Offset: 0x00000F8C
		protected override void UpdateControls()
		{
			base.UpdateControls();
			this._pathnameTextBox.Enabled = false;
			this._pathnameTextBox.Text = ((base.Dialog as FileGroupPropertiesDialog).AssociatedNode as FileGroup).Pathname;
		}

		// Token: 0x040002DE RID: 734
		private readonly TextBox _pathnameTextBox;
	}
}
