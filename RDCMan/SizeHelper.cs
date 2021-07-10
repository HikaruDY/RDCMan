using System;
using System.Drawing;

namespace RdcMan
{
	// Token: 0x02000034 RID: 52
	public static class SizeHelper
	{
		// Token: 0x06000093 RID: 147 RVA: 0x0000A760 File Offset: 0x00008960
		public static Size Parse(string dim)
		{
			string[] array = dim.Split(new string[]
			{
				SizeHelper.Separator,
				SizeHelper.AltSeparator
			}, StringSplitOptions.None);
			if (array.Length != 2)
			{
				throw new InvalidOperationException("Bad Size string '{0}'".InvariantFormat(new object[]
				{
					dim
				}));
			}
			return SizeHelper.FromString(array[0], array[1]);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000A7B8 File Offset: 0x000089B8
		public static Size FromString(string widthStr, string heightStr)
		{
			int width = int.Parse(widthStr);
			int height = int.Parse(heightStr);
			return new Size(width, height);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000241D File Offset: 0x0000061D
		public static string ToFormattedString(this Size size)
		{
			return "{0}{1}{2}".InvariantFormat(new object[]
			{
				size.Width,
				SizeHelper.Separator,
				size.Height
			});
		}

		// Token: 0x04000262 RID: 610
		public static Size[] StockSizes;

		// Token: 0x04000263 RID: 611
		public static readonly string Separator = " x ";

		// Token: 0x04000264 RID: 612
		public static readonly string AltSeparator = ", ";
	}
}
