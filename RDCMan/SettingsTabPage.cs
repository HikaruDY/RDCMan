using System;
using System.Linq;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000084 RID: 132
	public class SettingsTabPage : TabPage, ISettingsTabPage
	{
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600026A RID: 618 RVA: 0x0000358A File Offset: 0x0000178A
		InheritanceControl ISettingsTabPage.InheritanceControl
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600026B RID: 619 RVA: 0x00003591 File Offset: 0x00001791
		Control ISettingsTabPage.FocusControl
		{
			get
			{
				return this.FocusControl;
			}
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00003599 File Offset: 0x00001799
		void ISettingsTabPage.UpdateControls()
		{
			this.UpdateControls();
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0001140C File Offset: 0x0000F60C
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

		// Token: 0x0600026E RID: 622 RVA: 0x000035A1 File Offset: 0x000017A1
		void ISettingsTabPage.UpdateSettings()
		{
			this.UpdateSettings();
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600026F RID: 623 RVA: 0x000035A9 File Offset: 0x000017A9
		// (set) Token: 0x06000270 RID: 624 RVA: 0x000035B1 File Offset: 0x000017B1
		protected Control FocusControl { get; set; }

		// Token: 0x06000271 RID: 625 RVA: 0x00011454 File Offset: 0x0000F654
		protected virtual void UpdateControls()
		{
			foreach (ISettingControl settingControl in base.Controls.FlattenControls().OfType<ISettingControl>())
			{
				settingControl.UpdateControl();
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x000114AC File Offset: 0x0000F6AC
		protected virtual bool IsValid()
		{
			RdcDialog rdcDialog = base.FindForm() as RdcDialog;
			return rdcDialog.ValidateControls(base.Controls.FlattenControls(), true);
		}

		// Token: 0x06000273 RID: 627 RVA: 0x000114D8 File Offset: 0x0000F6D8
		protected virtual void UpdateSettings()
		{
			foreach (ISettingControl settingControl in base.Controls.FlattenControls().OfType<ISettingControl>())
			{
				settingControl.UpdateSetting();
			}
		}

		// Token: 0x04000336 RID: 822
		private const string InvalidSuffix = " (!)";
	}
}
