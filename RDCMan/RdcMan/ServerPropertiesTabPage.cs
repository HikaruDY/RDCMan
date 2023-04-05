using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000043 RID: 67
	internal class ServerPropertiesTabPage : NodePropertiesPage<ServerSettings>
	{
		// Token: 0x060001A6 RID: 422 RVA: 0x0000A06C File Offset: 0x0000826C
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

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x0000A2B4 File Offset: 0x000084B4
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x0000A2BC File Offset: 0x000084BC
		public List<string> ExpandedServerNames { get; private set; }

		// Token: 0x060001A9 RID: 425 RVA: 0x0000A2C8 File Offset: 0x000084C8
		protected override bool CanBeParent(GroupBase group)
		{
			return group.CanAddServers();
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0000A2D0 File Offset: 0x000084D0
		protected override void UpdateControls()
		{
			base.UpdateControls();
			this._vmConsoleConnectCheckBox.Checked = (base.Settings.ConnectionType.Value == ConnectionType.VirtualMachineConsoleConnect);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000A308 File Offset: 0x00008508
		protected override void UpdateSettings()
		{
			base.UpdateSettings();
			base.Settings.ConnectionType.Value = (this._vmConsoleConnectCheckBox.Checked ? ConnectionType.VirtualMachineConsoleConnect : ConnectionType.Normal);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000A348 File Offset: 0x00008548
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

		// Token: 0x060001AD RID: 429 RVA: 0x0000A44C File Offset: 0x0000864C
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

		// Token: 0x060001AE RID: 430 RVA: 0x0000A490 File Offset: 0x00008690
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

		// Token: 0x060001AF RID: 431 RVA: 0x0000A4DC File Offset: 0x000086DC
		private void DisplayNameChanged(object sender, EventArgs e)
		{
			this._displayNameUserCreated = true;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000A4E8 File Offset: 0x000086E8
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

		// Token: 0x040000F9 RID: 249
		private RdcTextBox _serverNameTextBox;

		// Token: 0x040000FA RID: 250
		private RdcCheckBox _vmConsoleConnectCheckBox;

		// Token: 0x040000FB RID: 251
		private Label _vmIdLabel;

		// Token: 0x040000FC RID: 252
		private RdcTextBox _vmIdTextBox;

		// Token: 0x040000FD RID: 253
		private RdcTextBox _displayNameTextBox;

		// Token: 0x040000FE RID: 254
		private bool _displayNameUserCreated;
	}
}
