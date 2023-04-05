using System;
using System.Drawing;

namespace RdcMan
{
	public static class PointHelper
	{
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

		public static string ToFormattedString(this Point point)
		{
			return "{0}{1}{2}".InvariantFormat(new object[]
			{
				point.X,
				PointHelper.Separator,
				point.Y
			});
		}

		public static readonly string Separator = ", ";
	}
}
