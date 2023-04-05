using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000051 RID: 81
	public class EncryptionSettingsTabPage : SettingsTabPage<EncryptionSettings>
	{
		// Token: 0x060001E9 RID: 489 RVA: 0x0000BB10 File Offset: 0x00009D10
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

		// Token: 0x060001EA RID: 490 RVA: 0x0000BC70 File Offset: 0x00009E70
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

		// Token: 0x060001EB RID: 491 RVA: 0x0000BCE4 File Offset: 0x00009EE4
		protected override void UpdateSettings()
		{
			base.UpdateSettings();
			X509Certificate2 x509Certificate = (X509Certificate2)this._passwordEncryptionDataButton.Tag;
			base.Settings.CredentialData.Value = ((x509Certificate != null) ? x509Certificate.Thumbprint : string.Empty);
			base.Settings.CredentialName.Value = this._passwordEncryptionDataButton.Text;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0000BD50 File Offset: 0x00009F50
		private void PasswordEncryptionMethodCombo_Enter(object sender, EventArgs e)
		{
			this._passwordEncryptionMethodPrevious = this._passwordEncryptionMethodCombo.SelectedValue;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000BD64 File Offset: 0x00009F64
		private void PasswordEncryptionMethodCombo_Changed(object sender, EventArgs e)
		{
//			EncryptionMethod selectedValue = this._passwordEncryptionMethodCombo.SelectedValue;
//			if (selectedValue != EncryptionMethod.LogonCredentials)
			if (this._passwordEncryptionMethodCombo.SelectedValue == EncryptionMethod.Certificate)
			{
//				if (selectedValue != EncryptionMethod.Certificate)
//				{
//					throw new NotImplementedException("Unexpected encryption method '{0}'".InvariantFormat(new object[]
//					{
//						this._passwordEncryptionMethodCombo.SelectedValue.ToString()
//					}));
//				}
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

		// Token: 0x060001EE RID: 494 RVA: 0x0000BE88 File Offset: 0x0000A088
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

		// Token: 0x060001EF RID: 495 RVA: 0x0000BF30 File Offset: 0x0000A130
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

		// Token: 0x04000113 RID: 275
		public InheritanceControl InheritEncryptionSettings;

		// Token: 0x04000114 RID: 276
		protected ValueComboBox<EncryptionMethod> _passwordEncryptionMethodCombo;

		// Token: 0x04000115 RID: 277
		protected Label _passwordEncryptionDataLabel;

		// Token: 0x04000116 RID: 278
		protected Button _passwordEncryptionDataButton;

		// Token: 0x04000117 RID: 279
		protected Label _passwordEncryptionDataInfoLabel;

		// Token: 0x04000118 RID: 280
		private EncryptionMethod _passwordEncryptionMethodPrevious;
	}
}
