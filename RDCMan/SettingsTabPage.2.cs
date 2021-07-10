using System;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000085 RID: 133
	public abstract class SettingsTabPage<TSettingsGroup> : SettingsTabPage, ISettingsTabPage where TSettingsGroup : SettingsGroup
	{
		// Token: 0x06000275 RID: 629 RVA: 0x000035C2 File Offset: 0x000017C2
		protected SettingsTabPage(TabbedSettingsDialog dialog, TSettingsGroup settingsGroup) : this(dialog, settingsGroup, settingsGroup.Name)
		{
		}

		// Token: 0x06000276 RID: 630 RVA: 0x000035D7 File Offset: 0x000017D7
		protected SettingsTabPage(TabbedSettingsDialog dialog, TSettingsGroup settingsGroup, string name)
		{
			this.Dialog = dialog;
			this.Settings = settingsGroup;
			base.Location = FormTools.TopLeftLocation();
			base.Size = new Size(512, 334);
			this.Text = name;
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000277 RID: 631 RVA: 0x00003614 File Offset: 0x00001814
		// (set) Token: 0x06000278 RID: 632 RVA: 0x0000361C File Offset: 0x0000181C
		protected InheritanceControl InheritanceControl { protected get; private set; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000279 RID: 633 RVA: 0x00003625 File Offset: 0x00001825
		// (set) Token: 0x0600027A RID: 634 RVA: 0x0000362D File Offset: 0x0000182D
		protected TSettingsGroup Settings { protected get; private set; }

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600027B RID: 635 RVA: 0x00003636 File Offset: 0x00001836
		// (set) Token: 0x0600027C RID: 636 RVA: 0x0000363E File Offset: 0x0000183E
		protected TabbedSettingsDialog Dialog { protected get; private set; }

		// Token: 0x0600027D RID: 637 RVA: 0x00011530 File Offset: 0x0000F730
		protected void CreateInheritanceControl(ref int rowIndex, ref int tabIndex)
		{
			if (this.Settings.InheritSettingsType.Mode == InheritanceMode.Disabled)
			{
				return;
			}
			this.InheritanceControl = new InheritanceControl(this.Dialog, this.Settings.Name);
			this.InheritanceControl.Create(this, ref rowIndex, ref tabIndex);
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600027E RID: 638 RVA: 0x00003647 File Offset: 0x00001847
		InheritanceControl ISettingsTabPage.InheritanceControl
		{
			get
			{
				return this.InheritanceControl;
			}
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00003599 File Offset: 0x00001799
		void ISettingsTabPage.UpdateControls()
		{
			this.UpdateControls();
		}

		// Token: 0x06000280 RID: 640 RVA: 0x000035A1 File Offset: 0x000017A1
		void ISettingsTabPage.UpdateSettings()
		{
			this.UpdateSettings();
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00011588 File Offset: 0x0000F788
		protected override void UpdateControls()
		{
			if (this.InheritanceControl != null)
			{
				this.InheritanceControl.UpdateControlsFromSettings(this.Settings.InheritSettingsType);
			}
			else
			{
				foreach (Control control in base.Controls.FlattenControls())
				{
					control.Enabled = true;
				}
			}
			base.UpdateControls();
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000364F File Offset: 0x0000184F
		protected override void UpdateSettings()
		{
			if (this.InheritanceControl != null)
			{
				this.Settings.InheritSettingsType.Mode = this.InheritanceControl.GetInheritanceMode();
			}
			base.UpdateSettings();
		}
	}
}
