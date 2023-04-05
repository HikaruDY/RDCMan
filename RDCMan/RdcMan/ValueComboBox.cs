using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RdcMan
{
	public class ValueComboBox<TValue> : ComboBox, ISettingControl
	{
		public ValueComboBox(Setting<TValue> setting, IEnumerable<TValue> values, Func<TValue, string> toString) : this(values, toString)
		{
			this.Setting = setting;
		}

		public ValueComboBox(IEnumerable<TValue> values, Func<TValue, string> toString)
		{
			base.DropDownStyle = ComboBoxStyle.DropDownList;
			if (values != null)
			{
				this.AddItems(values, toString);
			}
		}

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

		public void AddItems(IEnumerable<TValue> values, Func<TValue, string> toString)
		{
			values.ForEach(delegate(TValue v)
			{
				this.AddItem(toString(v), v);
			});
		}

		public void AddItem(string name, TValue value)
		{
			base.Items.Add(new ValueComboBox<TValue>.ComboBoxItem<TValue>
			{
				Name = name,
				Value = value
			});
		}

		public void ClearItems()
		{
			base.Items.Clear();
		}

		public void ReplaceItem(string name, TValue newValue)
		{
			int num = this.FindItem(name);
			if (num != -1)
			{
				ValueComboBox<TValue>.ComboBoxItem<TValue> comboBoxItem = base.Items[num] as ValueComboBox<TValue>.ComboBoxItem<TValue>;
				comboBoxItem.Value = newValue;
			}
		}

		public int ItemCount
		{
			get
			{
				return base.Items.Count;
			}
		}

		public new ComboBox.ObjectCollection Items
		{
			set
			{
				throw new InvalidOperationException();
			}
		}

		public new string Text
		{
			get
			{
				throw new InvalidOperationException();
			}
		}

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

		void ISettingControl.UpdateControl()
		{
			if (this.Setting != null)
			{
				this.SelectedValue = this.Setting.Value;
			}
		}

		void ISettingControl.UpdateSetting()
		{
			if (this.Setting != null)
			{
				this.Setting.Value = this.SelectedValue;
			}
		}

		string ISettingControl.Validate()
		{
			return null;
		}

		public Setting<TValue> Setting;

		private class ComboBoxItem<T>
		{
			public override string ToString()
			{
				return this.Name;
			}

			public string Name;

			public T Value;
		}
	}
}
