using System;
using System.Linq;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000054 RID: 84
	public class SettingsTabPage : TabPage, ISettingsTabPage
	{
		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060001FE RID: 510 RVA: 0x0000C260 File Offset: 0x0000A460
		InheritanceControl ISettingsTabPage.InheritanceControl
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060001FF RID: 511 RVA: 0x0000C268 File Offset: 0x0000A468
		Control ISettingsTabPage.FocusControl
		{
			get
			{
				return this.FocusControl;
			}
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000C270 File Offset: 0x0000A470
		void ISettingsTabPage.UpdateControls()
		{
			this.UpdateControls();
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0000C278 File Offset: 0x0000A478
		bool ISettingsTabPage.Validate()
		{
			string text = this.Text.Replace(" (!)", string.Empty);
			if (this.IsValid())
			{
				this.Text = text;
				return true;
			}
			this.Text = text + " (!)";
			return false;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0000C2C8 File Offset: 0x0000A4C8
		void ISettingsTabPage.UpdateSettings()
		{
			this.UpdateSettings();
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000203 RID: 515 RVA: 0x0000C2D0 File Offset: 0x0000A4D0
		// (set) Token: 0x06000204 RID: 516 RVA: 0x0000C2D8 File Offset: 0x0000A4D8
		protected Control FocusControl { get; set; }

		// Token: 0x06000205 RID: 517 RVA: 0x0000C2E4 File Offset: 0x0000A4E4
		protected virtual void UpdateControls()
		{
			foreach (ISettingControl settingControl in base.Controls.FlattenControls().OfType<ISettingControl>())
			{
				settingControl.UpdateControl();
			}
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0000C344 File Offset: 0x0000A544
		protected virtual bool IsValid()
		{
			RdcDialog rdcDialog = base.FindForm() as RdcDialog;
			return rdcDialog.ValidateControls(base.Controls.FlattenControls(), true);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0000C374 File Offset: 0x0000A574
		protected virtual void UpdateSettings()
		{
			foreach (ISettingControl settingControl in base.Controls.FlattenControls().OfType<ISettingControl>())
			{
				settingControl.UpdateSetting();
			}
		}

		// Token: 0x0400011E RID: 286
		private const string InvalidSuffix = " (!)";
	}
}
