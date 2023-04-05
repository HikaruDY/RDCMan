using System;
using System.Drawing;

namespace RdcMan
{
	// Token: 0x0200001C RID: 28
	public static class SizeHelper
	{
		// Token: 0x06000089 RID: 137 RVA: 0x000047B8 File Offset: 0x000029B8
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

		// Token: 0x0600008A RID: 138 RVA: 0x00004820 File Offset: 0x00002A20
		public static Size FromString(string widthStr, string heightStr)
		{
			int width = int.Parse(widthStr);
			int height = int.Parse(heightStr);
			return new Size(width, height);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00004848 File Offset: 0x00002A48
		public static string ToFormattedString(this Size size)
		{
			return "{0}{1}{2}".InvariantFormat(new object[]
			{
				size.Width,
				SizeHelper.Separator,
				size.Height
			});
		}

		// Token: 0x04000093 RID: 147
		public static Size[] StockSizes;

		// Token: 0x04000094 RID: 148
		public static readonly string Separator = " x ";

		// Token: 0x04000095 RID: 149
		public static readonly string AltSeparator = ", ";
	}
}
