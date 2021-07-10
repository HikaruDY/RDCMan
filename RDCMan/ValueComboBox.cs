using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000036 RID: 54
	public class ValueComboBox<TValue> : ComboBox, ISettingControl
	{
		// Token: 0x0600009A RID: 154 RVA: 0x000024AF File Offset: 0x000006AF
		public ValueComboBox(Setting<TValue> setting, IEnumerable<TValue> values, Func<TValue, string> toString) : this(values, toString)
		{
			this.Setting = setting;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000024C0 File Offset: 0x000006C0
		public ValueComboBox(IEnumerable<TValue> values, Func<TValue, string> toString)
		{
			base.DropDownStyle = ComboBoxStyle.DropDownList;
			if (values != null)
			{
				this.AddItems(values, toString);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600009C RID: 156 RVA: 0x0000A834 File Offset: 0x00008A34
		// (set) Token: 0x0600009D RID: 157 RVA: 0x0000A864 File Offset: 0x00008A64
		public new TValue SelectedValue
		{
			get
			{
				if (base.SelectedItem == null)
				{
					return default(TValue);
				}
				return (base.SelectedItem as ValueComboBox<TValue>.ComboBoxItem<TValue>).Value;
			}
			set
			{
				int num = this.FindItem(value);
				if (num != -1)
				{
					this.SelectedIndex = num;
				}
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000A884 File Offset: 0x00008A84
		public void AddItems(IEnumerable<TValue> values, Func<TValue, string> toString)
		{
			values.ForEach(delegate(TValue v)
			{
				this.AddItem(toString(v), v);
			});
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000024DA File Offset: 0x000006DA
		public void AddItem(string name, TValue value)
		{
			base.Items.Add(new ValueComboBox<TValue>.ComboBoxItem<TValue>
			{
				Name = name,
				Value = value
			});
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000024FB File Offset: 0x000006FB
		public void ClearItems()
		{
			base.Items.Clear();
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000A8B8 File Offset: 0x00008AB8
		public void ReplaceItem(string name, TValue newValue)
		{
			int num = this.FindItem(name);
			if (num != -1)
			{
				ValueComboBox<TValue>.ComboBoxItem<TValue> comboBoxItem = base.Items[num] as ValueComboBox<TValue>.ComboBoxItem<TValue>;
				comboBoxItem.Value = newValue;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00002508 File Offset: 0x00000708
		public int ItemCount
		{
			get
			{
				return base.Items.Count;
			}
		}

		// Token: 0x1700000C RID: 12
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x00002515 File Offset: 0x00000715
		public new ComboBox.ObjectCollection Items
		{
			set
			{
				throw new InvalidOperationException();
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00002515 File Offset: 0x00000715
		public new string Text
		{
			get
			{
				throw new InvalidOperationException();
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000A8EC File Offset: 0x00008AEC
		public int FindItem(TValue value)
		{
			for (int i = 0; i < base.Items.Count; i++)
			{
				ValueComboBox<TValue>.ComboBoxItem<TValue> comboBoxItem = base.Items[i] as ValueComboBox<TValue>.ComboBoxItem<TValue>;
				if (object.Equals(comboBoxItem.Value, value))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000A93C File Offset: 0x00008B3C
		public int FindItem(string name)
		{
			for (int i = 0; i < base.Items.Count; i++)
			{
				ValueComboBox<TValue>.ComboBoxItem<TValue> comboBoxItem = base.Items[i] as ValueComboBox<TValue>.ComboBoxItem<TValue>;
				if (comboBoxItem.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000251C File Offset: 0x0000071C
		void ISettingControl.UpdateControl()
		{
			if (this.Setting != null)
			{
				this.SelectedValue = this.Setting.Value;
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002537 File Offset: 0x00000737
		void ISettingControl.UpdateSetting()
		{
			if (this.Setting != null)
			{
				this.Setting.Value = this.SelectedValue;
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000241A File Offset: 0x0000061A
		string ISettingControl.Validate()
		{
			return null;
		}

		// Token: 0x04000266 RID: 614
		public Setting<TValue> Setting;

		// Token: 0x02000037 RID: 55
		private class ComboBoxItem<T>
		{
			// Token: 0x060000AA RID: 170 RVA: 0x00002552 File Offset: 0x00000752
			public override string ToString()
			{
				return this.Name;
			}

			// Token: 0x04000267 RID: 615
			public string Name;

			// Token: 0x04000268 RID: 616
			public T Value;
		}
	}
}
