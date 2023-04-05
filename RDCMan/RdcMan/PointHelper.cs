using System;
using System.Drawing;

namespace RdcMan
{
	// Token: 0x0200001D RID: 29
	public static class PointHelper
	{
		// Token: 0x0600008D RID: 141 RVA: 0x000048A8 File Offset: 0x00002AA8
		public static Point Parse(string s)
		{
			string[] array = s.Split(new string[]
			{
				PointHelper.Separator
			}, StringSplitOptions.None);
			if (array.Length != 2)
			{
				throw new InvalidOperationException("Bad Point string '{0}'".InvariantFormat(new object[]
				{
					s
				}));
			}
			return new Point(int.Parse(array[0]), int.Parse(array[1]));
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00004910 File Offset: 0x00002B10
		public static string ToFormattedString(this Point point)
		{
			return "{0}{1}{2}".InvariantFormat(new object[]
			{
				point.X,
				PointHelper.Separator,
				point.Y
			});
		}

		// Token: 0x04000096 RID: 150
		public static readonly string Separator = ", ";
	}
}
