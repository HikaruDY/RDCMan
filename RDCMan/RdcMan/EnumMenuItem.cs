using System;

namespace RdcMan
{
	// Token: 0x020000A0 RID: 160
	internal abstract class EnumMenuItem<T> : RdcMenuItem
	{
		// Token: 0x06000599 RID: 1433 RVA: 0x0001AB78 File Offset: 0x00018D78
		protected EnumMenuItem(string text, T value)
		{
			this.Text = text;
			base.Tag = value;
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x0001AB94 File Offset: 0x00018D94
		protected override void OnClick()
		{
			this.Value = (T)((object)base.Tag);
			Program.Preferences.NeedToSave = true;
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x0001ABB4 File Offset: 0x00018DB4
		public override void Update()
		{
			base.Checked = base.Tag.Equals(this.Value);
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x0600059C RID: 1436
		// (set) Token: 0x0600059D RID: 1437
		protected abstract T Value { get; set; }
	}
}
