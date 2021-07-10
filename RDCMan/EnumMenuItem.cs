using System;

namespace RdcMan
{
	// Token: 0x02000113 RID: 275
	internal abstract class EnumMenuItem<T> : RdcMenuItem
	{
		// Token: 0x060006F6 RID: 1782 RVA: 0x000066D2 File Offset: 0x000048D2
		protected EnumMenuItem(string text, T value)
		{
			this.Text = text;
			base.Tag = value;
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x000066ED File Offset: 0x000048ED
		protected override void OnClick()
		{
			this.Value = (T)((object)base.Tag);
			Program.Preferences.NeedToSave = true;
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x0000670B File Offset: 0x0000490B
		public override void Update()
		{
			base.Checked = base.Tag.Equals(this.Value);
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060006F9 RID: 1785
		// (set) Token: 0x060006FA RID: 1786
		protected abstract T Value { get; set; }
	}
}
