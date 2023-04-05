using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x0200003E RID: 62
	public abstract partial class RdcDialog : Form
	{
		// Token: 0x0600017A RID: 378 RVA: 0x0000910C File Offset: 0x0000730C
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

		// Token: 0x0600017B RID: 379 RVA: 0x000091C4 File Offset: 0x000073C4
		private void CancelButton_Click(object sender, EventArgs e)
		{
			this._errorProviders.ForEach(delegate(KeyValuePair<Control, ErrorProvider> kvp)
			{
				kvp.Value.Clear();
			});
		}

		// Token: 0x0600017C RID: 380 RVA: 0x000091F4 File Offset: 0x000073F4
		protected RdcDialog(string dialogTitle, string acceptButtonText, Form parentForm) : this(dialogTitle, acceptButtonText)
		{
			if (parentForm != null)
			{
				base.StartPosition = FormStartPosition.Manual;
				base.Location = new Point(parentForm.Location.X + 10, parentForm.Location.Y + 20);
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00009248 File Offset: 0x00007448
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

		// Token: 0x0600017E RID: 382 RVA: 0x00009298 File Offset: 0x00007498
		public virtual void InitButtons()
		{
			this._cancelButton.TabIndex = 100;
			this._cancelButton.Text = "Cancel";
			this._cancelButton.DialogResult = DialogResult.Cancel;
			this._acceptButton.TabIndex = 99;
			this._acceptButton.Click += this.AcceptIfValid;
			FormTools.AddButtonsAndSizeForm(this, this._acceptButton, this._cancelButton);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0000930C File Offset: 0x0000750C
		protected virtual void ShownCallback(object sender, EventArgs args)
		{
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00009310 File Offset: 0x00007510
		protected void Close(DialogResult dr)
		{
			base.DialogResult = dr;
			base.Close();
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00009320 File Offset: 0x00007520
		protected void OK()
		{
			this.Close(DialogResult.OK);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0000932C File Offset: 0x0000752C
		protected void Cancel()
		{
			this.Close(DialogResult.Cancel);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00009338 File Offset: 0x00007538
		protected virtual void AcceptIfValid(object sender, EventArgs e)
		{
			if (this.ValidateControls(base.Controls.FlattenControls(), true))
			{
				this.OK();
			}
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00009358 File Offset: 0x00007558
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

		// Token: 0x040000EC RID: 236
		protected Button _acceptButton;

		// Token: 0x040000ED RID: 237
		protected Button _cancelButton;

		// Token: 0x040000EE RID: 238
		private readonly Dictionary<Control, ErrorProvider> _errorProviders;
	}
}
