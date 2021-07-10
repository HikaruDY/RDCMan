using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x0200006E RID: 110
	internal class ServerPropertiesTabPage : NodePropertiesPage<ServerSettings>
	{
		// Token: 0x060001F9 RID: 505 RVA: 0x0000F408 File Offset: 0x0000D608
		public ServerPropertiesTabPage(TabbedSettingsDialog dialog, ServerSettings settings) : base(dialog, settings, "Server Settings")
		{
			int num = 0;
			int rowIndex = 0;
			this._serverNameTextBox = FormTools.AddLabeledTextBox(this, "&Server name:", base.Settings.ServerName, ref rowIndex, ref num);
			this._serverNameTextBox.Enabled = true;
			this._serverNameTextBox.TextChanged += this.ServerNameChanged;
			this._serverNameTextBox.Validate = new Func<string>(this.ValidateServerName);
			this._vmConsoleConnectCheckBox = FormTools.NewCheckBox("&VM console connect", 0, rowIndex, num++, 140);
			this._vmConsoleConnectCheckBox.CheckedChanged += this.VMConsoleConnectCheckBox_CheckedChanged;
			this._vmIdLabel = new Label
			{
				Location = FormTools.NewLocation(1, rowIndex++),
				Size = new Size(30, 20),
				Text = "&id:",
				TextAlign = ContentAlignment.MiddleLeft,
				Visible = false
			};
			this._vmIdTextBox = new RdcTextBox
			{
				Location = new Point(this._vmIdLabel.Right, this._vmIdLabel.Top),
				Setting = base.Settings.VirtualMachineId,
				Size = new Size(340 - this._vmIdLabel.Width, 20),
				TabIndex = num++,
				Visible = false
			};
			this._displayNameTextBox = FormTools.AddLabeledTextBox(this, "&Display name:", base.Settings.DisplayName, ref rowIndex, ref num);
			this._displayNameTextBox.Enabled = true;
			this._displayNameTextBox.TextChanged += this.DisplayNameChanged;
			this._displayNameTextBox.Validate = new Func<string>(this.ValidateDisplayName);
			this._displayNameUserCreated = !base.Settings.ServerName.Value.Equals(base.Settings.DisplayName.Value);
			base.AddParentCombo(ref rowIndex, ref num);
			base.AddComment(ref rowIndex, ref num).Setting = base.Settings.Comment;
			base.Controls.Add(new Control[]
			{
				this._vmConsoleConnectCheckBox,
				this._vmIdLabel,
				this._vmIdTextBox
			});
			base.FocusControl = this._serverNameTextBox;
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00003243 File Offset: 0x00001443
		// (set) Token: 0x060001FB RID: 507 RVA: 0x0000324B File Offset: 0x0000144B
		public List<string> ExpandedServerNames { get; private set; }

		// Token: 0x060001FC RID: 508 RVA: 0x00003254 File Offset: 0x00001454
		protected override bool CanBeParent(GroupBase group)
		{
			return group.CanAddServers();
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000325C File Offset: 0x0000145C
		protected override void UpdateControls()
		{
			base.UpdateControls();
			this._vmConsoleConnectCheckBox.Checked = (base.Settings.ConnectionType.Value == ConnectionType.VirtualMachineConsoleConnect);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00003282 File Offset: 0x00001482
		protected override void UpdateSettings()
		{
			base.UpdateSettings();
			base.Settings.ConnectionType.Value = (this._vmConsoleConnectCheckBox.Checked ? ConnectionType.VirtualMachineConsoleConnect : ConnectionType.Normal);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000F64C File Offset: 0x0000D84C
		private string ValidateServerName()
		{
			this._serverNameTextBox.Text = this._serverNameTextBox.Text.Trim();
			string text = this._serverNameTextBox.Text;
			if (text.Length == 0)
			{
				return "Please enter a server name";
			}
			if (text.IndexOf(' ') != -1)
			{
				return "Spaces are not permitted in a server name";
			}
			if (text.IndexOf('/') != -1 || text.IndexOf('\\') != -1)
			{
				return "Slashes are not permitted in a server name";
			}
			try
			{
				List<string> list = new List<string>(StringUtilities.ExpandPattern(text));
				if (list.Count > 1 && list.Count > 20 && FormTools.YesNoDialog("Expansion results in " + list.Count.ToString() + " servers. Are you sure?") == DialogResult.No)
				{
					return "Expansion too large";
				}
				this.ExpandedServerNames = list;
			}
			catch (ArgumentException ex)
			{
				return ex.Message;
			}
			return null;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000F730 File Offset: 0x0000D930
		private void ServerNameChanged(object sender, EventArgs e)
		{
			if (!this._displayNameUserCreated)
			{
				string text;
				int num;
				Server.SplitName(this._serverNameTextBox.Text, out text, out num);
				this._displayNameTextBox.Text = text;
				this._displayNameUserCreated = false;
			}
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0000F76C File Offset: 0x0000D96C
		private string ValidateDisplayName()
		{
			this._displayNameTextBox.Text = this._displayNameTextBox.Text.Trim();
			string text = this._displayNameTextBox.Text;
			if (text.Length == 0)
			{
				return "Please enter a display name";
			}
			return null;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x000032AB File Offset: 0x000014AB
		private void DisplayNameChanged(object sender, EventArgs e)
		{
			this._displayNameUserCreated = true;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000F7B0 File Offset: 0x0000D9B0
		private void VMConsoleConnectCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this._vmConsoleConnectCheckBox.Checked;
			this._vmIdLabel.Visible = @checked;
			this._vmIdTextBox.Visible = @checked;
			this._vmIdTextBox.Enabled = @checked;
			EnableTabsEventArgs args = new EnableTabsEventArgs
			{
				Enabled = !@checked,
				Reason = "for virtual machine console connect",
				TabNames = new string[]
				{
					"Local Resources",
					"Remote Desktop Settings",
					"Security Settings",
					"Connection Settings"
				}
			};
			NodePropertiesDialog nodePropertiesDialog = base.FindForm() as NodePropertiesDialog;
			nodePropertiesDialog.EnableTabs(args);
		}

		// Token: 0x04000300 RID: 768
		private RdcTextBox _serverNameTextBox;

		// Token: 0x04000301 RID: 769
		private RdcCheckBox _vmConsoleConnectCheckBox;

		// Token: 0x04000302 RID: 770
		private Label _vmIdLabel;

		// Token: 0x04000303 RID: 771
		private RdcTextBox _vmIdTextBox;

		// Token: 0x04000304 RID: 772
		private RdcTextBox _displayNameTextBox;

		// Token: 0x04000305 RID: 773
		private bool _displayNameUserCreated;
	}
}
