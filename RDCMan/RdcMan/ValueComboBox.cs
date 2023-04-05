using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x0200001E RID: 30
	public class ValueComboBox<TValue> : ComboBox, ISettingControl
	{
		// Token: 0x06000090 RID: 144 RVA: 0x00004964 File Offset: 0x00002B64
		public ValueComboBox(Setting<TValue> setting, IEnumerable<TValue> values, Func<TValue, string> toString) : this(values, toString)
		{
			this.Setting = setting;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00004978 File Offset: 0x00002B78
		public ValueComboBox(IEnumerable<TValue> values, Func<TValue, string> toString)
		{
			base.DropDownStyle = ComboBoxStyle.DropDownList;
			if (values != null)
			{
				this.AddItems(values, toString);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00004998 File Offset: 0x00002B98
		// (set) Token: 0x06000093 RID: 147 RVA: 0x000049D0 File Offset: 0x00002BD0
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

		// Token: 0x06000094 RID: 148 RVA: 0x000049F8 File Offset: 0x00002BF8
		public void AddItems(IEnumerable<TValue> values, Func<TValue, string> toString)
		{
			values.ForEach(delegate(TValue v)
			{
				this.AddItem(toString(v), v);
			});
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00004A30 File Offset: 0x00002C30
		public void AddItem(string name, TValue value)
		{
			base.Items.Add(new ValueComboBox<TValue>.ComboBoxItem<TValue>
			{
				Name = name,
				Value = value
			});
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00004A54 File Offset: 0x00002C54
		public void ClearItems()
		{
			base.Items.Clear();
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00004A64 File Offset: 0x00002C64
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
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00004AA0 File Offset: 0x00002CA0
		public int ItemCount
		{
			get
			{
				return base.Items.Count;
			}
		}

		// Token: 0x1700000C RID: 12
		// (set) Token: 0x06000099 RID: 153 RVA: 0x00004AB0 File Offset: 0x00002CB0
		public new ComboBox.ObjectCollection Items
		{
			set
			{
				throw new InvalidOperationException();
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00004AB8 File Offset: 0x00002CB8
		public new string Text
		{
			get
			{
				throw new InvalidOperationException();
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00004AC0 File Offset: 0x00002CC0
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

		// Token: 0x0600009C RID: 156 RVA: 0x00004B1C File Offset: 0x00002D1C
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

		// Token: 0x0600009D RID: 157 RVA: 0x00004B70 File Offset: 0x00002D70
		void ISettingControl.UpdateControl()
		{
			if (this.Setting != null)
			{
				this.SelectedValue = this.Setting.Value;
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00004B90 File Offset: 0x00002D90
		void ISettingControl.UpdateSetting()
		{
			if (this.Setting != null)
			{
				this.Setting.Value = this.SelectedValue;
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00004BB0 File Offset: 0x00002DB0
		string ISettingControl.Validate()
		{
			return null;
		}

		// Token: 0x04000097 RID: 151
		public Setting<TValue> Setting;

		// Token: 0x02000232 RID: 562
		private class ComboBoxItem<T>
		{
			// Token: 0x060055B6 RID: 21942 RVA: 0x0005CB78 File Offset: 0x0005AD78
			public override string ToString()
			{
				return this.Name;
			}

			// Token: 0x040009EE RID: 2542
			public string Name;

			// Token: 0x040009EF RID: 2543
			public T Value;
		}
	}
}
