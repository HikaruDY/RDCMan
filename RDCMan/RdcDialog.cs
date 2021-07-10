using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000064 RID: 100
	public abstract partial class RdcDialog : Form
	{
		// Token: 0x060001B1 RID: 433 RVA: 0x0000E608 File Offset: 0x0000C808
		protected RdcDialog(string dialogTitle, string acceptButtonText)
		{
			this._errorProviders = new Dictionary<Control, ErrorProvider>();
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(96f, 96f);
			base.AutoScaleMode = AutoScaleMode.Dpi;
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = dialogTitle;
			this._acceptButton = new Button
			{
				Text = acceptButtonText
			};
			this._cancelButton = new Button();
			this._cancelButton.Click += this.CancelButton_Click;
			base.Shown += this.ShownCallback;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00002ECE File Offset: 0x000010CE
		private void CancelButton_Click(object sender, EventArgs e)
		{
			this._errorProviders.ForEach(delegate(KeyValuePair<Control, ErrorProvider> kvp)
			{
				kvp.Value.Clear();
			});
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000E6BC File Offset: 0x0000C8BC
		protected RdcDialog(string dialogTitle, string acceptButtonText, Form parentForm) : this(dialogTitle, acceptButtonText)
		{
			if (parentForm != null)
			{
				base.StartPosition = FormStartPosition.Manual;
				base.Location = new Point(parentForm.Location.X + 10, parentForm.Location.Y + 20);
			}
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000E708 File Offset: 0x0000C908
		public bool SetError(Control c, string text)
		{
			ErrorProvider errorProvider;
			if (!this._errorProviders.TryGetValue(c, out errorProvider))
			{
				errorProvider = new ErrorProvider();
				errorProvider.SetIconAlignment(c, ErrorIconAlignment.MiddleLeft);
				this._errorProviders[c] = errorProvider;
			}
			errorProvider.SetError(c, text);
			return !string.IsNullOrEmpty(text);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000E754 File Offset: 0x0000C954
		public virtual void InitButtons()
		{
			this._cancelButton.TabIndex = 100;
			this._cancelButton.Text = "Cancel";
			this._cancelButton.DialogResult = DialogResult.Cancel;
			this._acceptButton.TabIndex = 99;
			this._acceptButton.Click += this.AcceptIfValid;
			FormTools.AddButtonsAndSizeForm(this, this._acceptButton, this._cancelButton);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002EFA File Offset: 0x000010FA
		protected virtual void ShownCallback(object sender, EventArgs args)
		{
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002EFC File Offset: 0x000010FC
		protected void Close(DialogResult dr)
		{
			base.DialogResult = dr;
			base.Close();
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002F0B File Offset: 0x0000110B
		protected void OK()
		{
			this.Close(DialogResult.OK);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002F14 File Offset: 0x00001114
		protected void Cancel()
		{
			this.Close(DialogResult.Cancel);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002F1D File Offset: 0x0000111D
		protected virtual void AcceptIfValid(object sender, EventArgs e)
		{
			if (this.ValidateControls(base.Controls.FlattenControls(), true))
			{
				this.OK();
			}
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0000E7C4 File Offset: 0x0000C9C4
		public bool ValidateControls(IEnumerable<Control> controls, bool isValid)
		{
			foreach (Control control in controls)
			{
				ISettingControl settingControl = control as ISettingControl;
				if (settingControl != null && control.Enabled)
				{
					string text = settingControl.Validate();
					if (this.SetError(control, text) && isValid)
					{
						control.Focus();
						isValid = false;
					}
				}
			}
			return isValid;
		}

		// Token: 0x040002E2 RID: 738
		protected Button _acceptButton;

		// Token: 0x040002E3 RID: 739
		protected Button _cancelButton;

		// Token: 0x040002E4 RID: 740
		private readonly Dictionary<Control, ErrorProvider> _errorProviders;
	}
}
