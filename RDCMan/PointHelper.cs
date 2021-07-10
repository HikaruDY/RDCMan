using System;
using System.Drawing;

namespace RdcMan
{
	// Token: 0x02000035 RID: 53
	public static class PointHelper
	{
		// Token: 0x06000097 RID: 151 RVA: 0x0000A7DC File Offset: 0x000089DC
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

		// Token: 0x06000098 RID: 152 RVA: 0x0000246B File Offset: 0x0000066B
		public static string ToFormattedString(this Point point)
		{
			return "{0}{1}{2}".InvariantFormat(new object[]
			{
				point.X,
				PointHelper.Separator,
				point.Y
			});
		}

		// Token: 0x04000265 RID: 613
		public static readonly string Separator = ", ";
	}
}
