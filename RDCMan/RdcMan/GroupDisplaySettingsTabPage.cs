using System;
using System.Drawing;

namespace RdcMan
{
	public class GroupDisplaySettingsTabPage : DisplaySettingsTabPage<GroupDisplaySettings>
	{
		public GroupDisplaySettingsTabPage(TabbedSettingsDialog dialog, GroupDisplaySettings settings) : base(dialog, settings)
		{
			int num;
			int num2;
			base.Create(out num, out num2);
			this._previewCheckBox = FormTools.AddCheckBox(this, "&Preview session in thumbnail", settings.SessionThumbnailPreview, 0, ref num, ref num2);
			this._interactionCheckBox = FormTools.AddCheckBox(this, "&Allow thumbnail session interaction", settings.AllowThumbnailSessionInteraction, 0, ref num, ref num2);
			this._interactionCheckBox.Location = new Point(this._previewCheckBox.Left + 24, this._interactionCheckBox.Top);
			this._previewCheckBox.CheckedChanged += delegate(object s, EventArgs e)
			{
				this.PreviewCheckBoxChanged();
			};
			if (base.InheritanceControl != null)
			{
				base.InheritanceControl.EnabledChanged += delegate(bool enabled)
				{
					this.PreviewCheckBoxChanged();
				};
			}
			FormTools.AddCheckBox(this, "Show &disconnected thumbnails", settings.ShowDisconnectedThumbnails, 0, ref num, ref num2);
		}

		private void PreviewCheckBoxChanged()
		{
			this._interactionCheckBox.Enabled = (this._previewCheckBox.Checked && this._previewCheckBox.Enabled);
		}

		protected override void UpdateControls()
		{
			base.UpdateControls();
			this.PreviewCheckBoxChanged();
		}

		private readonly RdcCheckBox _previewCheckBox;

		private readonly RdcCheckBox _interactionCheckBox;
	}
}
