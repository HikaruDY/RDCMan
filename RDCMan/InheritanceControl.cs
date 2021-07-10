using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000031 RID: 49
	public class InheritanceControl
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000075 RID: 117 RVA: 0x00009FDC File Offset: 0x000081DC
		// (remove) Token: 0x06000076 RID: 118 RVA: 0x0000A014 File Offset: 0x00008214
		public event Action<bool> EnabledChanged;

		// Token: 0x06000077 RID: 119 RVA: 0x0000233F File Offset: 0x0000053F
		public InheritanceControl(TabbedSettingsDialog dialog, string settingsGroupName)
		{
			this._dialog = dialog;
			this._settingsGroupName = settingsGroupName;
			this._sourceNode = DefaultSettingsGroup.Instance;
			this._enabled = true;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000A04C File Offset: 0x0000824C
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

		// Token: 0x06000079 RID: 121 RVA: 0x0000A180 File Offset: 0x00008380
		private void SourceButton_Click(object sender, EventArgs e)
		{
			TabPage tabPage = this._sourceButton.Parent as TabPage;
			string activeTabName = (tabPage != null) ? tabPage.Text : string.Empty;
			this._sourceNode.DoPropertiesDialog(this._sourceButton.FindForm(), activeTabName);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000A1C8 File Offset: 0x000083C8
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

		// Token: 0x0600007B RID: 123 RVA: 0x0000A2A4 File Offset: 0x000084A4
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

		// Token: 0x0600007C RID: 124 RVA: 0x0000A2DC File Offset: 0x000084DC
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

		// Token: 0x0600007D RID: 125 RVA: 0x00002367 File Offset: 0x00000567
		private void CheckChangedHandler(object sender, EventArgs e)
		{
			this.OnSettingChanged();
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000A3A0 File Offset: 0x000085A0
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

		// Token: 0x0600007F RID: 127 RVA: 0x0000A488 File Offset: 0x00008688
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

		// Token: 0x06000080 RID: 128 RVA: 0x0000236F File Offset: 0x0000056F
		public InheritanceMode GetInheritanceMode()
		{
			if (this.FromParentCheck.Checked)
			{
				return InheritanceMode.FromParent;
			}
			return InheritanceMode.None;
		}

		// Token: 0x04000253 RID: 595
		public CheckBox FromParentCheck;

		// Token: 0x04000254 RID: 596
		private const string SourcePrefix = "Source: ";

		// Token: 0x04000255 RID: 597
		private Button _sourceButton;

		// Token: 0x04000256 RID: 598
		private Label _disabledLabel;

		// Token: 0x04000257 RID: 599
		protected readonly TabbedSettingsDialog _dialog;

		// Token: 0x04000258 RID: 600
		private RdcTreeNode _sourceNode;

		// Token: 0x04000259 RID: 601
		private readonly string _settingsGroupName;

		// Token: 0x0400025A RID: 602
		private bool _enabled;
	}
}
