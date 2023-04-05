using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000046 RID: 70
	internal class SmartGroupPropertiesTabPage : GroupBasePropertiesTabPage<SmartGroupSettings>
	{
		// Token: 0x060001BE RID: 446 RVA: 0x0000AB5C File Offset: 0x00008D5C
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

		// Token: 0x060001BF RID: 447 RVA: 0x0000AD90 File Offset: 0x00008F90
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

		// Token: 0x060001C0 RID: 448 RVA: 0x0000AE04 File Offset: 0x00009004
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

		// Token: 0x060001C1 RID: 449 RVA: 0x0000AEEC File Offset: 0x000090EC
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

		// Token: 0x060001C2 RID: 450 RVA: 0x0000AF80 File Offset: 0x00009180
		protected override void ParentGroupChangedHandler(object sender, EventArgs e)
		{
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000AF84 File Offset: 0x00009184
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

		// Token: 0x060001C4 RID: 452 RVA: 0x0000B030 File Offset: 0x00009230
		private void AddRuleControl(Rule rule)
		{
			SmartGroupPropertiesTabPage.SmartRuleControl value = this.CreateRuleControl(rule, this._rulePanel.Controls.Count);
			this._rulePanel.Controls.Add(value);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000B06C File Offset: 0x0000926C
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

		// Token: 0x060001C6 RID: 454 RVA: 0x0000B0E4 File Offset: 0x000092E4
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

		// Token: 0x060001C7 RID: 455 RVA: 0x0000B184 File Offset: 0x00009384
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

		// Token: 0x04000102 RID: 258
		private readonly RuleGroup _ruleGroup;

		// Token: 0x04000103 RID: 259
		private const int RuleWidth = 459;

		// Token: 0x04000104 RID: 260
		private const int RuleHeight = 21;

		// Token: 0x04000105 RID: 261
		private readonly Panel _rulePanel;

		// Token: 0x04000106 RID: 262
		private readonly ValueComboBox<RuleGroupOperator> _anyAllCombo;

		// Token: 0x04000107 RID: 263
		private int _nextRuleTabIndex;

		// Token: 0x02000246 RID: 582
		private class SmartRuleControl : Control
		{
			// Token: 0x06005601 RID: 22017 RVA: 0x0005D5AC File Offset: 0x0005B7AC
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

			// Token: 0x1700213B RID: 8507
			// (get) Token: 0x06005602 RID: 22018 RVA: 0x0005D824 File Offset: 0x0005BA24
			public ServerProperty Property
			{
				get
				{
					return this._propertyCombo.SelectedValue;
				}
			}

			// Token: 0x1700213C RID: 8508
			// (get) Token: 0x06005603 RID: 22019 RVA: 0x0005D834 File Offset: 0x0005BA34
			public RuleOperator Operator
			{
				get
				{
					return this._operatorCombo.SelectedValue;
				}
			}

			// Token: 0x1700213D RID: 8509
			// (get) Token: 0x06005604 RID: 22020 RVA: 0x0005D844 File Offset: 0x0005BA44
			public Control ValueControl
			{
				get
				{
					return this._valueTextBox;
				}
			}

			// Token: 0x1700213E RID: 8510
			// (get) Token: 0x06005605 RID: 22021 RVA: 0x0005D84C File Offset: 0x0005BA4C
			public object Value
			{
				get
				{
					return this._valueTextBox.Text;
				}
			}

			// Token: 0x1700213F RID: 8511
			// (get) Token: 0x06005606 RID: 22022 RVA: 0x0005D85C File Offset: 0x0005BA5C
			// (set) Token: 0x06005607 RID: 22023 RVA: 0x0005D864 File Offset: 0x0005BA64
			public Button AddButton { get; private set; }

			// Token: 0x17002140 RID: 8512
			// (get) Token: 0x06005608 RID: 22024 RVA: 0x0005D870 File Offset: 0x0005BA70
			// (set) Token: 0x06005609 RID: 22025 RVA: 0x0005D878 File Offset: 0x0005BA78
			public Button DeleteButton { get; private set; }

			// Token: 0x17002141 RID: 8513
			// (get) Token: 0x0600560A RID: 22026 RVA: 0x0005D884 File Offset: 0x0005BA84
			// (set) Token: 0x0600560B RID: 22027 RVA: 0x0005D88C File Offset: 0x0005BA8C
			public int Index { get; set; }

			// Token: 0x04000A2B RID: 2603
			private readonly ValueComboBox<ServerProperty> _propertyCombo;

			// Token: 0x04000A2C RID: 2604
			private readonly ValueComboBox<RuleOperator> _operatorCombo;

			// Token: 0x04000A2D RID: 2605
			private readonly TextBox _valueTextBox;
		}
	}
}
