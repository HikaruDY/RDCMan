using System;

namespace RdcMan
{
	internal abstract class EnumMenuItem<T> : RdcMenuItem
	{
		protected EnumMenuItem(string text, T value)
		{
			this.Text = text;
			base.Tag = value;
		}

		protected override void OnClick()
		{
			this.Value = (T)((object)base.Tag);
			Program.Preferences.NeedToSave = true;
		}

		public override void Update()
		{
			base.Checked = base.Tag.Equals(this.Value);
		}

		protected abstract T Value { get; set; }
	}
}
