using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x0200003A RID: 58
	internal class FileGroupPropertiesTabPage : GroupBasePropertiesTabPage<FileGroupSettings>
	{
		// Token: 0x06000163 RID: 355 RVA: 0x00008C68 File Offset: 0x00006E68
		public FileGroupPropertiesTabPage(TabbedSettingsDialog dialog, FileGroupSettings settings) : base(dialog, settings, settings.Name)
		{
			int num = 0;
			int num2 = 0;
			base.AddGroupName(ref num, ref num2);
			this._pathnameTextBox = FormTools.AddLabeledTextBox(this, "Path name:", ref num, ref num2);
			base.AddComment(ref num, ref num2).Setting = base.Settings.Comment;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00008CC4 File Offset: 0x00006EC4
		protected override void UpdateControls()
		{
			base.UpdateControls();
			this._pathnameTextBox.Enabled = false;
			this._pathnameTextBox.Text = ((base.Dialog as FileGroupPropertiesDialog).AssociatedNode as FileGroup).Pathname;
		}

		// Token: 0x040000E8 RID: 232
		private readonly TextBox _pathnameTextBox;
	}
}
