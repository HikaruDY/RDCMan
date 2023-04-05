using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000052 RID: 82
	public class GatewaySettingsTabPage : CredentialsTabPage<GatewaySettings>
	{
		// Token: 0x060001F1 RID: 497 RVA: 0x0000BF7C File Offset: 0x0000A17C
		public GatewaySettingsTabPage(TabbedSettingsDialog dialog, GatewaySettings settings) : base(dialog, settings)
		{
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0000BF88 File Offset: 0x0000A188
		public void CreateControls(LogonCredentialsDialogOptions options)
		{
			int num = 0;
			int num2 = 0;
			base.CreateInheritanceControl(ref num2, ref num);
			if (base.InheritanceControl != null)
			{
				base.InheritanceControl.EnabledChanged += delegate(bool enabled)
				{
					this._useGatewayServerCheckBox.Enabled = enabled;
					this.UseGatewayServerCheckBox_CheckedChanged(null, null);
				};
			}
			this._useGatewayServerCheckBox = FormTools.AddCheckBox(this, "&Use a TS Gateway server", base.Settings.UseGatewayServer, 1, ref num2, ref num);
			this._useGatewayServerCheckBox.CheckedChanged += this.UseGatewayServerCheckBox_CheckedChanged;
			this._gatewayHostNameTextBox = FormTools.AddLabeledTextBox(this, "&Server name:", base.Settings.HostName, ref num2, ref num);
			this._gatewayHostNameTextBox.Validate = delegate()
			{
				if (this._gatewayHostNameTextBox.Enabled)
				{
					this._gatewayHostNameTextBox.Text = this._gatewayHostNameTextBox.Text.Trim();
					string text = this._gatewayHostNameTextBox.Text;
					if (text.Length == 0)
					{
						return "Please enter a server name";
					}
				}
				return null;
			};
			this._gatewayLocalBypassCheckBox = FormTools.AddCheckBox(this, "&Bypass for local addresses", base.Settings.BypassGatewayForLocalAddresses, 1, ref num2, ref num);
			this._gatewayLogonMethodCombo = FormTools.AddLabeledEnumDropDown<RdpClient.GatewayLogonMethod>(this, "&Logon method", base.Settings.LogonMethod, ref num2, ref num, new Func<RdpClient.GatewayLogonMethod, string>(RdpClient.GatewayLogonMethodToString));
			this._gatewayLogonMethodCombo.SelectedValueChanged += this.GatewayLogonMethodComboBox_SelectedValueChanged;
			if (RdpClient.SupportsGatewayCredentials)
			{
				this._gatewayCredSharingCheckBox = FormTools.AddCheckBox(this, "Share Gateway &credentials with remote computer", base.Settings.CredentialSharing, 1, ref num2, ref num);
				this._gatewayCredSharingCheckBox.CheckedChanged += this.GatewayCredSharingCheckBox_CheckedChanged;
				this._credentialsUI = new CredentialsUI(base.InheritanceControl);
				this._credentialsUI.AddControlsToParent(this, options, ref num2, ref num);
			}
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000C100 File Offset: 0x0000A300
		protected override void UpdateControls()
		{
			base.UpdateControls();
			if (base.InheritanceControl == null)
			{
				this.UseGatewayServerCheckBox_CheckedChanged(null, null);
			}
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000C11C File Offset: 0x0000A31C
		private void GatewayCredSharingCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this.GatewayLogonMethodComboBox_SelectedValueChanged(null, null);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0000C128 File Offset: 0x0000A328
		private void UseGatewayServerCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this._useGatewayServerCheckBox.Enabled && this._useGatewayServerCheckBox.Checked;
			this._gatewayHostNameTextBox.Enabled = enabled;
			this._gatewayLogonMethodCombo.Enabled = enabled;
			this._gatewayLocalBypassCheckBox.Enabled = enabled;
			if (RdpClient.SupportsGatewayCredentials)
			{
				this._gatewayCredSharingCheckBox.Enabled = enabled;
			}
			this.GatewayLogonMethodComboBox_SelectedValueChanged(null, null);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000C1A0 File Offset: 0x0000A3A0
		private void GatewayLogonMethodComboBox_SelectedValueChanged(object sender, EventArgs e)
		{
			bool enable = this._gatewayLogonMethodCombo.Enabled && this._gatewayLogonMethodCombo.SelectedValue == RdpClient.GatewayLogonMethod.NTLM;
			if (RdpClient.SupportsGatewayCredentials)
			{
				this._credentialsUI.EnableDisableControls(enable);
			}
		}

		// Token: 0x04000119 RID: 281
		private CheckBox _useGatewayServerCheckBox;

		// Token: 0x0400011A RID: 282
		private ValueComboBox<RdpClient.GatewayLogonMethod> _gatewayLogonMethodCombo;

		// Token: 0x0400011B RID: 283
		private CheckBox _gatewayLocalBypassCheckBox;

		// Token: 0x0400011C RID: 284
		private RdcTextBox _gatewayHostNameTextBox;

		// Token: 0x0400011D RID: 285
		private CheckBox _gatewayCredSharingCheckBox;
	}
}
