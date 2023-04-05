using System;
using System.Windows.Forms;

namespace RdcMan
{
	internal class FileGroupPropertiesTabPage : GroupBasePropertiesTabPage<FileGroupSettings>
	{
		public FileGroupPropertiesTabPage(TabbedSettingsDialog dialog, FileGroupSettings settings) : base(dialog, settings, settings.Name)
		{
			int num = 0;
			int num2 = 0;
			base.AddGroupName(ref num, ref num2);
			this._pathnameTextBox = FormTools.AddLabeledTextBox(this, "Path name:", ref num, ref num2);
			base.AddComment(ref num, ref num2).Setting = base.Settings.Comment;
		}

		protected override void UpdateControls()
		{
			base.UpdateControls();
			this._pathnameTextBox.Enabled = false;
			this._pathnameTextBox.Text = ((base.Dialog as FileGroupPropertiesDialog).AssociatedNode as FileGroup).Pathname;
		}

		private readonly TextBox _pathnameTextBox;
	}
}
