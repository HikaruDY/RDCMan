using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x0200006F RID: 111
	internal class ImportServersPropertiesPage : NodePropertiesPage<SettingsGroup>
	{
		// Token: 0x06000204 RID: 516 RVA: 0x0000F84C File Offset: 0x0000DA4C
		public ImportServersPropertiesPage(TabbedSettingsDialog dialog) : base(dialog, null, "Server Settings")
		{
			int num = 0;
			int num2 = 0;
			Label value = new Label
			{
				Location = FormTools.NewLocation(0, num2),
				Size = new Size(480, 48),
				Text = "Select a file with server info or enter info in the textbox below. Server names are delimited by commas and newlines. Expansions are permitted."
			};
			num2 += 2;
			base.Controls.Add(value);
			Button browseButton = new Button
			{
				TabIndex = num++,
				Text = "&Browse"
			};
			browseButton.Click += this.OnBrowseClick;
			this._fileNameTextBox = FormTools.AddLabeledTextBox(this, "&File name:", ref num2, ref num);
			this._fileNameTextBox.Enabled = true;
			this._fileNameTextBox.Width -= browseButton.Width + 8;
			browseButton.Location = new Point(this._fileNameTextBox.Right + 8, this._fileNameTextBox.Top);
			this._serversTextBox = FormTools.NewTextBox(1, num2, num++, 7);
			this._serversTextBox.AcceptsReturn = true;
			this._serversTextBox.Enabled = true;
			this._serversTextBox.ScrollBars = ScrollBars.Vertical;
			num2 += 6;
			base.Controls.Add(new Control[]
			{
				browseButton,
				this._serversTextBox
			});
			base.AddParentCombo(ref num2, ref num);
			this._fileNameTextBox.TextChanged += delegate(object s, EventArgs e)
			{
				this._serversTextBox.Enabled = string.IsNullOrEmpty(this._fileNameTextBox.Text);
			};
			this._serversTextBox.TextChanged += delegate(object s, EventArgs e)
			{
				this._fileNameTextBox.Enabled = (browseButton.Enabled = string.IsNullOrEmpty(this._serversTextBox.Text));
			};
			base.FocusControl = this._fileNameTextBox;
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000205 RID: 517 RVA: 0x000032B4 File Offset: 0x000014B4
		// (set) Token: 0x06000206 RID: 518 RVA: 0x000032BC File Offset: 0x000014BC
		public List<string> ExpandedServerNames { get; private set; }

		// Token: 0x06000207 RID: 519 RVA: 0x0000F9FC File Offset: 0x0000DBFC
		protected override bool IsValid()
		{
			Control c = this._serversTextBox;
			string text = this._serversTextBox.Text;
			base.Dialog.SetError(this._serversTextBox, null);
			base.Dialog.SetError(this._fileNameTextBox, null);
			if (!string.IsNullOrEmpty(this._fileNameTextBox.Text))
			{
				c = this._fileNameTextBox;
				try
				{
					text = File.ReadAllText(this._fileNameTextBox.Text);
				}
				catch (Exception ex)
				{
					base.Dialog.SetError(this._fileNameTextBox, ex.Message);
					return false;
				}
			}
			if (string.IsNullOrWhiteSpace(text))
			{
				base.Dialog.SetError(this._fileNameTextBox, "Please enter a file name");
				return false;
			}
			try
			{
				List<string> list = new List<string>();
				text = text.Replace(Environment.NewLine, ",");
				MatchCollection matchCollection = Regex.Matches(text, "([^,\\{\\s]*\\{[^\\}]*\\}[^,\\{,\\}\\s]*)|([^,\\{\\}\\s]+)");
				foreach (object obj in matchCollection)
				{
					Match match = (Match)obj;
					list.AddRange(StringUtilities.ExpandPattern(match.Groups[0].Value.Trim()));
				}
				this.ExpandedServerNames = list;
			}
			catch (Exception ex2)
			{
				base.Dialog.SetError(c, ex2.Message);
			}
			return true;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00003254 File Offset: 0x00001454
		protected override bool CanBeParent(GroupBase group)
		{
			return group.CanAddServers();
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000FB80 File Offset: 0x0000DD80
		private void OnBrowseClick(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Title = "Import";
				openFileDialog.DefaultExt = "txt";
				openFileDialog.AddExtension = true;
				openFileDialog.CheckFileExists = true;
				openFileDialog.RestoreDirectory = false;
				openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					this._fileNameTextBox.Text = openFileDialog.FileName;
				}
			}
		}

		// Token: 0x04000307 RID: 775
		private RdcTextBox _fileNameTextBox;

		// Token: 0x04000308 RID: 776
		private RdcTextBox _serversTextBox;
	}
}
