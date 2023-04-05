using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RdcMan
{
	internal class SmartGroupPropertiesTabPage : GroupBasePropertiesTabPage<SmartGroupSettings>
	{
		public SmartGroupPropertiesTabPage(TabbedSettingsDialog dialog, SmartGroupSettings settings) : base(dialog, settings, settings.Name)
		{
			this._ruleGroup = ((dialog as SmartGroupPropertiesDialog).AssociatedNode as SmartGroup).RuleGroup;
			int num = 0;
			int nextRuleTabIndex = 0;
			base.AddGroupName(ref num, ref nextRuleTabIndex);
			base.AddParentCombo(ref num, ref nextRuleTabIndex);
			num++;
			Label label = new Label
			{
				Location = FormTools.NewLocation(0, num++),
				Text = "Servers which match",
				TextAlign = ContentAlignment.MiddleLeft,
				Size = new Size(110, 20)
			};
			this._anyAllCombo = new ValueComboBox<RuleGroupOperator>(Helpers.EnumValues<RuleGroupOperator>(), (RuleGroupOperator v) => v.ToString())
			{
				Location = new Point(label.Right, label.Top),
				Size = new Size(50, 20),
				TabIndex = nextRuleTabIndex++,
				SelectedValue = RuleGroupOperator.All
			};
			Label label2 = new Label
			{
				Location = new Point(this._anyAllCombo.Right + 5, label.Top),
				Text = "of the following rules",
				TextAlign = ContentAlignment.MiddleLeft,
				Size = new Size(140, 20)
			};
			base.Controls.Add(new Control[]
			{
				label,
				this._anyAllCombo,
				label2
			});
			GroupBox groupBox = new GroupBox
			{
				Location = FormTools.NewLocation(0, num++)
			};
			this._rulePanel = new Panel
			{
				Location = FormTools.NewLocation(0, 0),
				AutoScroll = true
			};
			int num2 = 302 - groupBox.Top - 40;
			this._rulePanel.Size = new Size(480, num2);
			this._rulePanel.VerticalScroll.LargeChange = num2;
			this._rulePanel.VerticalScroll.SmallChange = num2 / 20;
			groupBox.Size = new Size(496, num2 + this._rulePanel.Top * 2);
			groupBox.Controls.Add(this._rulePanel);
			this._nextRuleTabIndex = nextRuleTabIndex;
			base.Controls.Add(groupBox);
		}

		protected override void UpdateControls()
		{
			base.UpdateControls();
			this._anyAllCombo.SelectedValue = this._ruleGroup.Operator;
			if (this._ruleGroup.Rules.Count > 0)
			{
				this._ruleGroup.Rules.ForEach(new Action<Rule>(this.AddRuleControl));
			}
			else
			{
				this.AddRuleControl(null);
			}
			this.LayoutRuleControls();
		}

		protected override bool IsValid()
		{
			bool flag = true;
			foreach (object obj in this._rulePanel.Controls)
			{
				SmartGroupPropertiesTabPage.SmartRuleControl smartRuleControl = (SmartGroupPropertiesTabPage.SmartRuleControl)obj;
				string text = null;
				try
				{
					string text2 = smartRuleControl.Value as string;
					if (text2 != null)
					{
						if (string.IsNullOrEmpty(text2))
						{
							text = "Please enter a pattern";
						}
						else
						{
							Regex.Match(string.Empty, text2);
						}
					}
				}
				catch (Exception ex)
				{
					text = ex.Message;
				}
				flag &= !base.Dialog.SetError(smartRuleControl.ValueControl, text);
			}
			return flag && base.IsValid();
		}

		protected override void UpdateSettings()
		{
			base.UpdateSettings();
			List<SmartGroupPropertiesTabPage.SmartRuleControl> source = this._rulePanel.Controls.Cast<SmartGroupPropertiesTabPage.SmartRuleControl>().ToList<SmartGroupPropertiesTabPage.SmartRuleControl>();
			IEnumerable<Rule> rules = from r in source
			orderby r.Index
			select r into c
			select new Rule(new RuleProperty(c.Property), c.Operator, c.Value);
			this._ruleGroup.Set(this._anyAllCombo.SelectedValue, rules);
		}

		protected override void ParentGroupChangedHandler(object sender, EventArgs e)
		{
		}

		private void InsertRuleControl(SmartGroupPropertiesTabPage.SmartRuleControl afterRule)
		{
			int num = afterRule.Index + 1;
			foreach (object obj in this._rulePanel.Controls)
			{
				SmartGroupPropertiesTabPage.SmartRuleControl smartRuleControl = (SmartGroupPropertiesTabPage.SmartRuleControl)obj;
				if (smartRuleControl.Index >= num)
				{
					SmartGroupPropertiesTabPage.SmartRuleControl smartRuleControl2 = smartRuleControl;
					int index = smartRuleControl2.Index;
					smartRuleControl2.Index = index + 1;
				}
			}
			SmartGroupPropertiesTabPage.SmartRuleControl value = this.CreateRuleControl(null, num);
			this._rulePanel.Controls.Add(value);
			this.LayoutRuleControls();
		}

		private void AddRuleControl(Rule rule)
		{
			SmartGroupPropertiesTabPage.SmartRuleControl value = this.CreateRuleControl(rule, this._rulePanel.Controls.Count);
			this._rulePanel.Controls.Add(value);
		}

		private SmartGroupPropertiesTabPage.SmartRuleControl CreateRuleControl(Rule rule, int index)
		{
			SmartGroupPropertiesTabPage.SmartRuleControl newRule = new SmartGroupPropertiesTabPage.SmartRuleControl(rule, ref this._nextRuleTabIndex)
			{
				Index = index
			};
			newRule.AddButton.Click += delegate(object s, EventArgs o)
			{
				this.InsertRuleControl(newRule);
			};
			newRule.DeleteButton.Click += delegate(object s, EventArgs o)
			{
				this.DeleteRuleControl(newRule);
			};
			return newRule;
		}

		private void DeleteRuleControl(SmartGroupPropertiesTabPage.SmartRuleControl rule)
		{
			int index = rule.Index;
			this._rulePanel.Controls.Remove(rule);
			foreach (object obj in this._rulePanel.Controls)
			{
				SmartGroupPropertiesTabPage.SmartRuleControl smartRuleControl = (SmartGroupPropertiesTabPage.SmartRuleControl)obj;
				if (smartRuleControl.Index > index)
				{
					SmartGroupPropertiesTabPage.SmartRuleControl smartRuleControl2 = smartRuleControl;
					int index2 = smartRuleControl2.Index;
					smartRuleControl2.Index = index2 - 1;
				}
			}
			this.LayoutRuleControls();
		}

		private void LayoutRuleControls()
		{
			int count = this._rulePanel.Controls.Count;
			int num = 0;
			this._rulePanel.SuspendLayout();
			int value = this._rulePanel.VerticalScroll.Value;
			foreach (object obj in this._rulePanel.Controls)
			{
				SmartGroupPropertiesTabPage.SmartRuleControl smartRuleControl = (SmartGroupPropertiesTabPage.SmartRuleControl)obj;
				smartRuleControl.DeleteButton.Enabled = (count > 1);
				smartRuleControl.Location = new Point(0, smartRuleControl.Index * 25 - value);
				num = Math.Max(num, smartRuleControl.Top);
			}
			this._rulePanel.VerticalScroll.Maximum = num;
			this._rulePanel.VerticalScroll.Value = Math.Min(num, value);
			this._rulePanel.ResumeLayout();
		}

		private readonly RuleGroup _ruleGroup;

		private const int RuleWidth = 459;

		private const int RuleHeight = 21;

		private readonly Panel _rulePanel;

		private readonly ValueComboBox<RuleGroupOperator> _anyAllCombo;

		private int _nextRuleTabIndex;

		private class SmartRuleControl : Control
		{
			public SmartRuleControl(Rule rule, ref int tabIndex)
			{
				ValueComboBox<ServerProperty> valueComboBox = new ValueComboBox<ServerProperty>(Helpers.EnumValues<ServerProperty>(), (ServerProperty v) => v.ToString());
				valueComboBox.Location = new Point(0, 0);
				valueComboBox.Width = 100;
				int num = tabIndex;
				tabIndex = num + 1;
				valueComboBox.TabIndex = num;
				valueComboBox.SelectedValue = ServerProperty.DisplayName;
				this._propertyCombo = valueComboBox;
				ValueComboBox<RuleOperator> valueComboBox2 = new ValueComboBox<RuleOperator>(Helpers.EnumValues<RuleOperator>(), (RuleOperator v) => v.ToString());
				valueComboBox2.Location = new Point(this._propertyCombo.Right + 4, 0);
				valueComboBox2.Width = 100;
				num = tabIndex;
				tabIndex = num + 1;
				valueComboBox2.TabIndex = num;
				valueComboBox2.SelectedValue = RuleOperator.Matches;
				this._operatorCombo = valueComboBox2;
				TextBox textBox = new TextBox();
				textBox.Enabled = true;
				textBox.Location = new Point(this._operatorCombo.Right + 4, 0);
				textBox.Width = 459 - (this._operatorCombo.Right + 4) - 48;
				num = tabIndex;
				tabIndex = num + 1;
				textBox.TabIndex = num;
				this._valueTextBox = textBox;
				Button button = new Button();
				button.Enabled = true;
				button.Location = new Point(this._valueTextBox.Right + 4, 0);
				button.Size = new Size(20, 20);
				num = tabIndex;
				tabIndex = num + 1;
				button.TabIndex = num;
				button.Text = "-";
				this.DeleteButton = button;
				Button button2 = new Button();
				button2.Enabled = true;
				button2.Location = new Point(this.DeleteButton.Right + 4, 0);
				button2.Size = new Size(20, 20);
				num = tabIndex;
				tabIndex = num + 1;
				button2.TabIndex = num;
				button2.Text = "+";
				this.AddButton = button2;
				base.Controls.Add(new Control[]
				{
					this._propertyCombo,
					this._operatorCombo,
					this._valueTextBox,
					this.DeleteButton,
					this.AddButton
				});
				base.Size = new Size(459, 21);
				base.TabStop = false;
				if (rule != null)
				{
					this._propertyCombo.SelectedValue = rule.Property.ServerProperty;
					this._operatorCombo.SelectedValue = rule.Operator;
					this._valueTextBox.Text = rule.Value.ToString();
				}
			}

			public ServerProperty Property
			{
				get
				{
					return this._propertyCombo.SelectedValue;
				}
			}

			public RuleOperator Operator
			{
				get
				{
					return this._operatorCombo.SelectedValue;
				}
			}

			public Control ValueControl
			{
				get
				{
					return this._valueTextBox;
				}
			}

			public object Value
			{
				get
				{
					return this._valueTextBox.Text;
				}
			}

			public Button AddButton { get; private set; }

			public Button DeleteButton { get; private set; }

			public int Index { get; set; }

			private readonly ValueComboBox<ServerProperty> _propertyCombo;

			private readonly ValueComboBox<RuleOperator> _operatorCombo;

			private readonly TextBox _valueTextBox;
		}
	}
}
