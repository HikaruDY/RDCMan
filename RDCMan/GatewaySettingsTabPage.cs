using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000082 RID: 130
	public class GatewaySettingsTabPage : CredentialsTabPage<GatewaySettings>
	{
		// Token: 0x0600025D RID: 605 RVA: 0x00003548 File Offset: 0x00001748
		public GatewaySettingsTabPage(TabbedSettingsDialog dialog, GatewaySettings settings) : base(dialog, settings)
		{
		}

		// Token: 0x0600025E RID: 606 RVA: 0x000111A4 File Offset: 0x0000F3A4
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

		// Token: 0x0600025F RID: 607 RVA: 0x00003552 File Offset: 0x00001752
		protected override void UpdateControls()
		{
			base.UpdateControls();
			if (base.InheritanceControl == null)
			{
				this.UseGatewayServerCheckBox_CheckedChanged(null, null);
			}
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000356A File Offset: 0x0000176A
		private void GatewayCredSharingCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this.GatewayLogonMethodComboBox_SelectedValueChanged(null, null);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00011314 File Offset: 0x0000F514
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

		// Token: 0x06000262 RID: 610 RVA: 0x0001137C File Offset: 0x0000F57C
		private void GatewayLogonMethodComboBox_SelectedValueChanged(object sender, EventArgs e)
		{
			bool enable = this._gatewayLogonMethodCombo.Enabled && this._gatewayLogonMethodCombo.SelectedValue == RdpClient.GatewayLogonMethod.NTLM;
			if (RdpClient.SupportsGatewayCredentials)
			{
				this._credentialsUI.EnableDisableControls(enable);
			}
		}

		// Token: 0x04000331 RID: 817
		private CheckBox _useGatewayServerCheckBox;

		// Token: 0x04000332 RID: 818
		private ValueComboBox<RdpClient.GatewayLogonMethod> _gatewayLogonMethodCombo;

		// Token: 0x04000333 RID: 819
		private CheckBox _gatewayLocalBypassCheckBox;

		// Token: 0x04000334 RID: 820
		private RdcTextBox _gatewayHostNameTextBox;

		// Token: 0x04000335 RID: 821
		private CheckBox _gatewayCredSharingCheckBox;
	}
}
