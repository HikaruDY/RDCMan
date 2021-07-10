using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000081 RID: 129
	public class EncryptionSettingsTabPage : SettingsTabPage<EncryptionSettings>
	{
		// Token: 0x06000255 RID: 597 RVA: 0x00010DD0 File Offset: 0x0000EFD0
		public EncryptionSettingsTabPage(TabbedSettingsDialog dialog, EncryptionSettings settings) : base(dialog, settings)
		{
			int num = 0;
			int rowIndex = 0;
			base.CreateInheritanceControl(ref rowIndex, ref num);
			if (base.InheritanceControl != null)
			{
				base.InheritanceControl.EnabledChanged += delegate(bool enabled)
				{
					this.PasswordEncryptionMethodCombo_Changed(null, null);
				};
			}
			this._passwordEncryptionMethodCombo = FormTools.AddLabeledEnumDropDown<EncryptionMethod>(this, "Password encryption:", base.Settings.EncryptionMethod, ref rowIndex, ref num, new Func<EncryptionMethod, string>(Encryption.EncryptionMethodToString));
			this._passwordEncryptionMethodCombo.Enter += this.PasswordEncryptionMethodCombo_Enter;
			this._passwordEncryptionMethodCombo.SelectedIndexChanged += this.PasswordEncryptionMethodCombo_Changed;
			this._passwordEncryptionDataLabel = FormTools.NewLabel(string.Empty, 0, rowIndex);
			this._passwordEncryptionDataButton = new Button
			{
				Enabled = false,
				Location = FormTools.NewLocation(1, rowIndex++),
				Width = 340,
				TabIndex = num++,
				TextAlign = ContentAlignment.MiddleLeft
			};
			this._passwordEncryptionDataButton.Click += this.PasswordEncryptionMethodButton_Click;
			this._passwordEncryptionDataInfoLabel = FormTools.NewLabel(string.Empty, 1, rowIndex++);
			this._passwordEncryptionDataInfoLabel.Width = 340;
			base.Controls.Add(new Control[]
			{
				this._passwordEncryptionDataLabel,
				this._passwordEncryptionDataButton,
				this._passwordEncryptionDataInfoLabel
			});
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00010F28 File Offset: 0x0000F128
		protected override void UpdateControls()
		{
			if (base.Settings.EncryptionMethod.Value == EncryptionMethod.Certificate)
			{
				X509Certificate2 certificate = Encryption.GetCertificate(base.Settings.CredentialData.Value);
				this._passwordEncryptionDataButton.Tag = certificate;
			}
			this._passwordEncryptionMethodCombo.SelectedValue = base.Settings.EncryptionMethod.Value;
			base.UpdateControls();
			this.PasswordEncryptionMethodCombo_Changed(null, null);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00010F94 File Offset: 0x0000F194
		protected override void UpdateSettings()
		{
			base.UpdateSettings();
			X509Certificate2 x509Certificate = (X509Certificate2)this._passwordEncryptionDataButton.Tag;
			base.Settings.CredentialData.Value = ((x509Certificate != null) ? x509Certificate.Thumbprint : string.Empty);
			base.Settings.CredentialName.Value = this._passwordEncryptionDataButton.Text;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0000352B File Offset: 0x0000172B
		private void PasswordEncryptionMethodCombo_Enter(object sender, EventArgs e)
		{
			this._passwordEncryptionMethodPrevious = this._passwordEncryptionMethodCombo.SelectedValue;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00010FF4 File Offset: 0x0000F1F4
		private void PasswordEncryptionMethodCombo_Changed(object sender, EventArgs e)
		{
			if (this._passwordEncryptionMethodCombo.SelectedValue == EncryptionMethod.Certificate)
			{
				X509Certificate2 x509Certificate = this._passwordEncryptionDataButton.Tag as X509Certificate2;
				if (x509Certificate == null)
				{
					try
					{
						base.Enabled = false;
						x509Certificate = Encryption.SelectCertificate();
					}
					finally
					{
						base.Enabled = true;
					}
				}
				if (x509Certificate != null)
				{
					this.SetSelectedCertificate(x509Certificate);
				}
				else
				{
					this._passwordEncryptionMethodCombo.SelectedValue = this._passwordEncryptionMethodPrevious;
				}
			}
			else
			{
				this._passwordEncryptionDataLabel.Text = "User name:";
				this._passwordEncryptionDataButton.Text = CredentialsUI.GetLoggedInUser();
				this._passwordEncryptionDataButton.Tag = null;
				this._passwordEncryptionDataButton.Enabled = false;
				this._passwordEncryptionDataInfoLabel.Text = string.Empty;
			}
			this._passwordEncryptionMethodPrevious = this._passwordEncryptionMethodCombo.SelectedValue;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x000110C4 File Offset: 0x0000F2C4
		protected void SetSelectedCertificate(X509Certificate2 cert)
		{
			if (cert != null)
			{
				this._passwordEncryptionDataButton.Text = cert.SimpleName();
				this._passwordEncryptionDataButton.Tag = cert;
				this._passwordEncryptionDataButton.Enabled = this._passwordEncryptionMethodCombo.Enabled;
				this._passwordEncryptionDataLabel.Text = "Certificate:";
				this._passwordEncryptionDataInfoLabel.Text = "Valid from {0} to {1}".InvariantFormat(new object[]
				{
					cert.NotBefore.ToUniversalTime().ToShortDateString(),
					cert.NotAfter.ToUniversalTime().ToShortDateString()
				});
			}
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00011168 File Offset: 0x0000F368
		private void PasswordEncryptionMethodButton_Click(object sender, EventArgs e)
		{
			X509Certificate2 selectedCertificate;
			try
			{
				base.Enabled = false;
				selectedCertificate = Encryption.SelectCertificate();
			}
			finally
			{
				base.Enabled = true;
			}
			this.SetSelectedCertificate(selectedCertificate);
		}

		// Token: 0x0400032B RID: 811
		public InheritanceControl InheritEncryptionSettings;

		// Token: 0x0400032C RID: 812
		protected ValueComboBox<EncryptionMethod> _passwordEncryptionMethodCombo;

		// Token: 0x0400032D RID: 813
		protected Label _passwordEncryptionDataLabel;

		// Token: 0x0400032E RID: 814
		protected Button _passwordEncryptionDataButton;

		// Token: 0x0400032F RID: 815
		protected Label _passwordEncryptionDataInfoLabel;

		// Token: 0x04000330 RID: 816
		private EncryptionMethod _passwordEncryptionMethodPrevious;
	}
}
