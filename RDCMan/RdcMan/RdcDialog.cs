using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	public abstract partial class RdcDialog : Form
	{
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

		private void CancelButton_Click(object sender, EventArgs e)
		{
			this._errorProviders.ForEach(delegate(KeyValuePair<Control, ErrorProvider> kvp)
			{
				kvp.Value.Clear();
			});
		}

		protected RdcDialog(string dialogTitle, string acceptButtonText, Form parentForm) : this(dialogTitle, acceptButtonText)
		{
			if (parentForm != null)
			{
				base.StartPosition = FormStartPosition.Manual;
				base.Location = new Point(parentForm.Location.X + 10, parentForm.Location.Y + 20);
			}
		}

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

		public virtual void InitButtons()
		{
			this._cancelButton.TabIndex = 100;
			this._cancelButton.Text = "Cancel";
			this._cancelButton.DialogResult = DialogResult.Cancel;
			this._acceptButton.TabIndex = 99;
			this._acceptButton.Click += this.AcceptIfValid;
			FormTools.AddButtonsAndSizeForm(this, this._acceptButton, this._cancelButton);
		}

		protected virtual void ShownCallback(object sender, EventArgs args)
		{
		}

		protected void Close(DialogResult dr)
		{
			base.DialogResult = dr;
			base.Close();
		}

		protected void OK()
		{
			this.Close(DialogResult.OK);
		}

		protected void Cancel()
		{
			this.Close(DialogResult.Cancel);
		}

		protected virtual void AcceptIfValid(object sender, EventArgs e)
		{
			if (this.ValidateControls(base.Controls.FlattenControls(), true))
			{
				this.OK();
			}
		}

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

		protected Button _acceptButton;

		protected Button _cancelButton;

		private readonly Dictionary<Control, ErrorProvider> _errorProviders;
	}
}
