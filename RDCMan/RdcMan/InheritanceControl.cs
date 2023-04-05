using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000019 RID: 25
	public class InheritanceControl
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600006B RID: 107 RVA: 0x00003E68 File Offset: 0x00002068
		// (remove) Token: 0x0600006C RID: 108 RVA: 0x00003EA4 File Offset: 0x000020A4
		public event Action<bool> EnabledChanged;

		// Token: 0x0600006D RID: 109 RVA: 0x00003EE0 File Offset: 0x000020E0
		public InheritanceControl(TabbedSettingsDialog dialog, string settingsGroupName)
		{
			this._dialog = dialog;
			this._settingsGroupName = settingsGroupName;
			this._sourceNode = DefaultSettingsGroup.Instance;
			this._enabled = true;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00003F08 File Offset: 0x00002108
		public void Create(Control parent, ref int rowIndex, ref int tabIndex)
		{
			this._disabledLabel = new Label
			{
				Enabled = true,
				Location = new Point(0, (parent.Height - 20) / 2),
				Size = new Size(parent.Width, 20),
				TextAlign = ContentAlignment.MiddleCenter,
				Visible = false
			};
			string text = "In&herit from parent";
			int colIndex = 1;
			int num = rowIndex;
			rowIndex = num + 1;
			int rowIndex2 = num;
			num = tabIndex;
			tabIndex = num + 1;
			this.FromParentCheck = FormTools.NewCheckBox(text, colIndex, rowIndex2, num);
			this.FromParentCheck.CheckedChanged += this.CheckChangedHandler;
			Button button = new Button();
			int colIndex2 = 1;
			num = rowIndex;
			rowIndex = num + 1;
			button.Location = FormTools.NewLocation(colIndex2, num);
			this._sourceButton = button;
			this._sourceButton.Size = new Size(340, this._sourceButton.Height);
			this._sourceButton.Click += this.SourceButton_Click;
			this._sourceButton.TextChanged += this.SourceButton_TextChanged;
			parent.Controls.Add(this._disabledLabel);
			parent.Controls.Add(this.FromParentCheck);
			parent.Controls.Add(this._sourceButton);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00004040 File Offset: 0x00002240
		private void SourceButton_Click(object sender, EventArgs e)
		{
			TabPage tabPage = this._sourceButton.Parent as TabPage;
			string activeTabName = (tabPage != null) ? tabPage.Text : string.Empty;
			this._sourceNode.DoPropertiesDialog(this._sourceButton.FindForm(), activeTabName);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00004090 File Offset: 0x00002290
		private void SourceButton_TextChanged(object sender, EventArgs e)
		{
			string text = this._sourceButton.Text;
			Graphics graphics = this._sourceButton.CreateGraphics();
			bool flag = false;
			SizeF sizeF = graphics.MeasureString(text, this._sourceButton.Font);
			while (Math.Round((double)sizeF.Width, 1) > (double)this._sourceButton.Width)
			{
				double num = Math.Round((double)sizeF.Width, 0) - (double)this._sourceButton.Width;
				int num2 = (int)Math.Round(num / (double)this._sourceButton.Font.Size, 0) + 4;
				text = "Source: ..." + text.Substring(num2 + "Source: ".Length);
				flag = true;
				sizeF = graphics.MeasureString(text, this._sourceButton.Font);
			}
			if (flag)
			{
				this._sourceButton.Text = text;
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00004174 File Offset: 0x00002374
		public void UpdateControlsFromSettings(InheritSettingsType settings)
		{
			bool flag = settings.Mode == InheritanceMode.FromParent;
			if (flag != this.FromParentCheck.Checked)
			{
				this.FromParentCheck.Checked = flag;
				return;
			}
			this.OnSettingChanged();
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000041B4 File Offset: 0x000023B4
		public void Enable(bool value, string reason)
		{
			this._enabled = value;
			this._disabledLabel.Text = "These settings are unavailable {0}".InvariantFormat(new object[]
			{
				reason
			});
			foreach (object obj in this.FromParentCheck.Parent.Controls)
			{
				Control control = (Control)obj;
				control.Visible = this._enabled;
			}
			this._disabledLabel.Enabled = !this._enabled;
			this._disabledLabel.Visible = !this._enabled;
			if (this._enabled)
			{
				this.OnSettingChanged();
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00004284 File Offset: 0x00002484
		private void CheckChangedHandler(object sender, EventArgs e)
		{
			this.OnSettingChanged();
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000428C File Offset: 0x0000248C
		private void OnSettingChanged()
		{
			CheckBox fromParentCheck = this.FromParentCheck;
			this.EnableDisableControls(!fromParentCheck.Checked);
			if (fromParentCheck.Checked)
			{
				GroupBase groupBase = this._dialog.TabPages.OfType<INodePropertiesPage>().First<INodePropertiesPage>().ParentGroup;
				if (groupBase != this._sourceNode)
				{
					if (groupBase == null)
					{
						this._sourceNode = DefaultSettingsGroup.Instance;
					}
					else
					{
						for (;;)
						{
							SettingsGroup settingsGroupByName = groupBase.GetSettingsGroupByName(this._settingsGroupName);
							if (settingsGroupByName.InheritSettingsType.Mode != InheritanceMode.FromParent)
							{
								break;
							}
							groupBase = settingsGroupByName.InheritSettingsType.GetInheritedSettingsNode(groupBase);
						}
						this._sourceNode = groupBase;
					}
				}
				if (this._sourceNode != DefaultSettingsGroup.Instance)
				{
					this._sourceButton.Text = "Source: " + this._sourceNode.FullPath;
				}
				else
				{
					this._sourceButton.Text = "Source: Default settings group";
				}
				this._sourceButton.Show();
				return;
			}
			this._sourceButton.Hide();
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000438C File Offset: 0x0000258C
		public void EnableDisableControls(bool enable)
		{
			foreach (object obj in this.FromParentCheck.Parent.Controls)
			{
				Control control = (Control)obj;
				if (control != this.FromParentCheck && control != this._sourceButton)
				{
					control.Enabled = enable;
				}
			}
			if (this.EnabledChanged != null)
			{
				this.EnabledChanged(enable);
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00004428 File Offset: 0x00002628
		public InheritanceMode GetInheritanceMode()
		{
			if (this.FromParentCheck.Checked)
			{
				return InheritanceMode.FromParent;
			}
			return InheritanceMode.None;
		}

		// Token: 0x04000084 RID: 132
		public CheckBox FromParentCheck;

		// Token: 0x04000085 RID: 133
		private const string SourcePrefix = "Source: ";

		// Token: 0x04000086 RID: 134
		private Button _sourceButton;

		// Token: 0x04000087 RID: 135
		private Label _disabledLabel;

		// Token: 0x04000088 RID: 136
		protected readonly TabbedSettingsDialog _dialog;

		// Token: 0x04000089 RID: 137
		private RdcTreeNode _sourceNode;

		// Token: 0x0400008A RID: 138
		private readonly string _settingsGroupName;

		// Token: 0x0400008B RID: 139
		private bool _enabled;
	}
}
