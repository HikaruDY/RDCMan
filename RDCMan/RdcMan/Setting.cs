using System;

namespace RdcMan
{
	public abstract class Setting<T> : BaseSetting<T>
	{
		protected Setting(object o) : base(o)
		{
		}

		public new T Value
		{
			get
			{
				return this.Value;
			}
			set
			{
				this.Value = value;
			}
		}
	}
}
