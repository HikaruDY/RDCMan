using System;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000055 RID: 85
	public abstract class SettingsTabPage<TSettingsGroup> : SettingsTabPage, ISettingsTabPage where TSettingsGroup : SettingsGroup
	{
		// Token: 0x06000209 RID: 521 RVA: 0x0000C3DC File Offset: 0x0000A5DC
		protected SettingsTabPage(TabbedSettingsDialog dialog, TSettingsGroup settingsGroup) : this(dialog, settingsGroup, settingsGroup.Name)
		{
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000C3F4 File Offset: 0x0000A5F4
		protected SettingsTabPage(TabbedSettingsDialog dialog, TSettingsGroup settingsGroup, string name)
		{
			this.Dialog = dialog;
			this.Settings = settingsGroup;
			base.Location = FormTools.TopLeftLocation();
			base.Size = new Size(512, 334);
			this.Text = name;
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600020B RID: 523 RVA: 0x0000C440 File Offset: 0x0000A640
		// (set) Token: 0x0600020C RID: 524 RVA: 0x0000C448 File Offset: 0x0000A648
		private protected InheritanceControl InheritanceControl { protected get; private set; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600020D RID: 525 RVA: 0x0000C454 File Offset: 0x0000A654
		// (set) Token: 0x0600020E RID: 526 RVA: 0x0000C45C File Offset: 0x0000A65C
		private protected TSettingsGroup Settings { protected get; private set; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600020F RID: 527 RVA: 0x0000C468 File Offset: 0x0000A668
		// (set) Token: 0x06000210 RID: 528 RVA: 0x0000C470 File Offset: 0x0000A670
		private protected TabbedSettingsDialog Dialog { protected get; private set; }

		// Token: 0x06000211 RID: 529 RVA: 0x0000C47C File Offset: 0x0000A67C
		protected void CreateInheritanceControl(ref int rowIndex, ref int tabIndex)
		{
			if (this.Settings.InheritSettingsType.Mode == InheritanceMode.Disabled)
			{
				return;
			}
			this.InheritanceControl = new InheritanceControl(this.Dialog, this.Settings.Name);
			this.InheritanceControl.Create(this, ref rowIndex, ref tabIndex);
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000212 RID: 530 RVA: 0x0000C4D8 File Offset: 0x0000A6D8
		InheritanceControl ISettingsTabPage.InheritanceControl
		{
			get
			{
				return this.InheritanceControl;
			}
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000C4E0 File Offset: 0x0000A6E0
		void ISettingsTabPage.UpdateControls()
		{
			this.UpdateControls();
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000C4E8 File Offset: 0x0000A6E8
		void ISettingsTabPage.UpdateSettings()
		{
			this.UpdateSettings();
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0000C4F0 File Offset: 0x0000A6F0
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

		// Token: 0x06000216 RID: 534 RVA: 0x0000C57C File Offset: 0x0000A77C
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
