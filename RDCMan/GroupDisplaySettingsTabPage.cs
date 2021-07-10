using System;
using System.Drawing;

namespace RdcMan
{
	// Token: 0x02000080 RID: 128
	public class GroupDisplaySettingsTabPage : DisplaySettingsTabPage<GroupDisplaySettings>
	{
		// Token: 0x06000250 RID: 592 RVA: 0x00010D00 File Offset: 0x0000EF00
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

		// Token: 0x06000251 RID: 593 RVA: 0x000034ED File Offset: 0x000016ED
		private void PreviewCheckBoxChanged()
		{
			this._interactionCheckBox.Enabled = (this._previewCheckBox.Checked && this._previewCheckBox.Enabled);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00003515 File Offset: 0x00001715
		protected override void UpdateControls()
		{
			base.UpdateControls();
			this.PreviewCheckBoxChanged();
		}

		// Token: 0x04000329 RID: 809
		private readonly RdcCheckBox _previewCheckBox;

		// Token: 0x0400032A RID: 810
		private readonly RdcCheckBox _interactionCheckBox;
	}
}
