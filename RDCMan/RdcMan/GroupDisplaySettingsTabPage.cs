using System;
using System.Drawing;

namespace RdcMan
{
	// Token: 0x02000050 RID: 80
	public class GroupDisplaySettingsTabPage : DisplaySettingsTabPage<GroupDisplaySettings>
	{
		// Token: 0x060001E4 RID: 484 RVA: 0x0000B9EC File Offset: 0x00009BEC
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

		// Token: 0x060001E5 RID: 485 RVA: 0x0000BAC0 File Offset: 0x00009CC0
		private void PreviewCheckBoxChanged()
		{
			this._interactionCheckBox.Enabled = (this._previewCheckBox.Checked && this._previewCheckBox.Enabled);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000BAF0 File Offset: 0x00009CF0
		protected override void UpdateControls()
		{
			base.UpdateControls();
			this.PreviewCheckBoxChanged();
		}

		// Token: 0x04000111 RID: 273
		private readonly RdcCheckBox _previewCheckBox;

		// Token: 0x04000112 RID: 274
		private readonly RdcCheckBox _interactionCheckBox;
	}
}
