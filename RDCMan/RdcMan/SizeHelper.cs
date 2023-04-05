using System;
using System.Drawing;

namespace RdcMan
{
	public static class SizeHelper
	{
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

		public static Size FromString(string widthStr, string heightStr)
		{
			int width = int.Parse(widthStr);
			int height = int.Parse(heightStr);
			return new Size(width, height);
		}

		public static string ToFormattedString(this Size size)
		{
			return "{0}{1}{2}".InvariantFormat(new object[]
			{
				size.Width,
				SizeHelper.Separator,
				size.Height
			});
		}

		public static Size[] StockSizes;

		public static readonly string Separator = " x ";

		public static readonly string AltSeparator = ", ";
	}
}
