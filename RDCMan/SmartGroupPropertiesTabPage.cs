using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000072 RID: 114
	internal class SmartGroupPropertiesTabPage : GroupBasePropertiesTabPage<SmartGroupSettings>
	{
		// Token: 0x06000213 RID: 531 RVA: 0x0000FDCC File Offset: 0x0000DFCC
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

		// Token: 0x06000214 RID: 532 RVA: 0x0000FFF8 File Offset: 0x0000E1F8
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

		// Token: 0x06000215 RID: 533 RVA: 0x00010060 File Offset: 0x0000E260
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

		// Token: 0x06000216 RID: 534 RVA: 0x0001012C File Offset: 0x0000E32C
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

		// Token: 0x06000217 RID: 535 RVA: 0x00002EFA File Offset: 0x000010FA
		protected override void ParentGroupChangedHandler(object sender, EventArgs e)
		{
		}

		// Token: 0x06000218 RID: 536 RVA: 0x000101B8 File Offset: 0x0000E3B8
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

		// Token: 0x06000219 RID: 537 RVA: 0x00010258 File Offset: 0x0000E458
		private void AddRuleControl(Rule rule)
		{
			SmartGroupPropertiesTabPage.SmartRuleControl value = this.CreateRuleControl(rule, this._rulePanel.Controls.Count);
			this._rulePanel.Controls.Add(value);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00010290 File Offset: 0x0000E490
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

		// Token: 0x0600021B RID: 539 RVA: 0x00010304 File Offset: 0x0000E504
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

		// Token: 0x0600021C RID: 540 RVA: 0x00010398 File Offset: 0x0000E598
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

		// Token: 0x0400030B RID: 779
		private readonly RuleGroup _ruleGroup;

		// Token: 0x0400030C RID: 780
		private const int RuleWidth = 459;

		// Token: 0x0400030D RID: 781
		private const int RuleHeight = 21;

		// Token: 0x0400030E RID: 782
		private readonly Panel _rulePanel;

		// Token: 0x0400030F RID: 783
		private readonly ValueComboBox<RuleGroupOperator> _anyAllCombo;

		// Token: 0x04000310 RID: 784
		private int _nextRuleTabIndex;

		// Token: 0x02000073 RID: 115
		private class SmartRuleControl : Control
		{
			// Token: 0x0600021D RID: 541 RVA: 0x0001048C File Offset: 0x0000E68C
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

			// Token: 0x17000042 RID: 66
			// (get) Token: 0x0600021E RID: 542 RVA: 0x000032E2 File Offset: 0x000014E2
			public ServerProperty Property
			{
				get
				{
					return this._propertyCombo.SelectedValue;
				}
			}

			// Token: 0x17000043 RID: 67
			// (get) Token: 0x0600021F RID: 543 RVA: 0x000032EF File Offset: 0x000014EF
			public RuleOperator Operator
			{
				get
				{
					return this._operatorCombo.SelectedValue;
				}
			}

			// Token: 0x17000044 RID: 68
			// (get) Token: 0x06000220 RID: 544 RVA: 0x000032FC File Offset: 0x000014FC
			public Control ValueControl
			{
				get
				{
					return this._valueTextBox;
				}
			}

			// Token: 0x17000045 RID: 69
			// (get) Token: 0x06000221 RID: 545 RVA: 0x00003304 File Offset: 0x00001504
			public object Value
			{
				get
				{
					return this._valueTextBox.Text;
				}
			}

			// Token: 0x17000046 RID: 70
			// (get) Token: 0x06000222 RID: 546 RVA: 0x00003311 File Offset: 0x00001511
			// (set) Token: 0x06000223 RID: 547 RVA: 0x00003319 File Offset: 0x00001519
			public Button AddButton { get; private set; }

			// Token: 0x17000047 RID: 71
			// (get) Token: 0x06000224 RID: 548 RVA: 0x00003322 File Offset: 0x00001522
			// (set) Token: 0x06000225 RID: 549 RVA: 0x0000332A File Offset: 0x0000152A
			public Button DeleteButton { get; private set; }

			// Token: 0x17000048 RID: 72
			// (get) Token: 0x06000226 RID: 550 RVA: 0x00003333 File Offset: 0x00001533
			// (set) Token: 0x06000227 RID: 551 RVA: 0x0000333B File Offset: 0x0000153B
			public int Index { get; set; }

			// Token: 0x04000314 RID: 788
			private readonly ValueComboBox<ServerProperty> _propertyCombo;

			// Token: 0x04000315 RID: 789
			private readonly ValueComboBox<RuleOperator> _operatorCombo;

			// Token: 0x04000316 RID: 790
			private readonly TextBox _valueTextBox;
		}
	}
}
