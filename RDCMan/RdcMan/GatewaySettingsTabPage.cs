using System;
using System.Windows.Forms;

namespace RdcMan
{
	public class GatewaySettingsTabPage : CredentialsTabPage<GatewaySettings>
	{
		public GatewaySettingsTabPage(TabbedSettingsDialog dialog, GatewaySettings settings) : base(dialog, settings)
		{
		}

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

		protected override void UpdateControls()
		{
			base.UpdateControls();
			if (base.InheritanceControl == null)
			{
				this.UseGatewayServerCheckBox_CheckedChanged(null, null);
			}
		}

		private void GatewayCredSharingCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this.GatewayLogonMethodComboBox_SelectedValueChanged(null, null);
		}

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

		private void GatewayLogonMethodComboBox_SelectedValueChanged(object sender, EventArgs e)
		{
			bool enable = this._gatewayLogonMethodCombo.Enabled && this._gatewayLogonMethodCombo.SelectedValue == RdpClient.GatewayLogonMethod.NTLM;
			if (RdpClient.SupportsGatewayCredentials)
			{
				this._credentialsUI.EnableDisableControls(enable);
			}
		}

		private CheckBox _useGatewayServerCheckBox;

		private ValueComboBox<RdpClient.GatewayLogonMethod> _gatewayLogonMethodCombo;

		private CheckBox _gatewayLocalBypassCheckBox;

		private RdcTextBox _gatewayHostNameTextBox;

		private CheckBox _gatewayCredSharingCheckBox;
	}
}
