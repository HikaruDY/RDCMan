using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RdcMan
{
	public class InheritanceControl
	{
		public event Action<bool> EnabledChanged;

		public InheritanceControl(TabbedSettingsDialog dialog, string settingsGroupName)
		{
			this._dialog = dialog;
			this._settingsGroupName = settingsGroupName;
			this._sourceNode = DefaultSettingsGroup.Instance;
			this._enabled = true;
		}

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

		private void SourceButton_Click(object sender, EventArgs e)
		{
			TabPage tabPage = this._sourceButton.Parent as TabPage;
			string activeTabName = (tabPage != null) ? tabPage.Text : string.Empty;
			this._sourceNode.DoPropertiesDialog(this._sourceButton.FindForm(), activeTabName);
		}

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

		private void CheckChangedHandler(object sender, EventArgs e)
		{
			this.OnSettingChanged();
		}

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

		public InheritanceMode GetInheritanceMode()
		{
			if (this.FromParentCheck.Checked)
			{
				return InheritanceMode.FromParent;
			}
			return InheritanceMode.None;
		}

		public CheckBox FromParentCheck;

		private const string SourcePrefix = "Source: ";

		private Button _sourceButton;

		private Label _disabledLabel;

		protected readonly TabbedSettingsDialog _dialog;

		private RdcTreeNode _sourceNode;

		private readonly string _settingsGroupName;

		private bool _enabled;
	}
}
