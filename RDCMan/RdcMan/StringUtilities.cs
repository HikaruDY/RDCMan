using System;
using System.Collections.Generic;
using System.Globalization;

namespace RdcMan
{
	public static class StringUtilities
	{
		public static string CultureFormat(this string format, params object[] args)
		{
			return string.Format(CultureInfo.CurrentUICulture, format, args);
		}

		public static string InvariantFormat(this string format, params object[] args)
		{
			return string.Format(CultureInfo.InvariantCulture, format, args);
		}

		public static IEnumerable<string> ExpandPattern(string pattern)
		{
			bool flag = false;
			int i = 0;
			while (i < pattern.Length)
			{
				char c = pattern[i];
				if (c == '{')
				{
					int num = pattern.IndexOf('}', i);
					if (num == -1)
					{
						throw new ArgumentException(string.Format("Set not closed (missing {0}): {1}", '}', pattern.Substring(i)));
					}
					string prefix = pattern.Substring(0, i);
					string suffix = pattern.Substring(num + 1);
					IEnumerable<string> enumerable = StringUtilities.ExpandSet(pattern.Substring(i + 1, num - i - 1));
					foreach (string setValue in enumerable)
					{
						foreach (string str in StringUtilities.ExpandPattern(suffix))
						{
							yield return prefix + setValue + str;
						}
						IEnumerator<string> enumerator2 = null;
						setValue = null;
					}
					IEnumerator<string> enumerator = null;
					flag = true;
					break;
				}
				else if (c == '[')
				{
					int num2 = pattern.IndexOf(']', i);
					if (num2 == -1)
					{
						throw new ArgumentException(string.Format("Range not closed (missing {0}): {1}", ']', pattern.Substring(i)));
					}
					string suffix = pattern.Substring(0, i);
					string prefix = pattern.Substring(num2 + 1);
					IEnumerable<string> enumerable2 = StringUtilities.ExpandRange(pattern.Substring(i + 1, num2 - i - 1));
					foreach (string setValue in enumerable2)
					{
						foreach (string str2 in StringUtilities.ExpandPattern(prefix))
						{
							yield return suffix + setValue + str2;
						}
						IEnumerator<string> enumerator2 = null;
						setValue = null;
					}
					IEnumerator<string> enumerator = null;
					flag = true;
					break;
				}
				else
				{
					i++;
				}
			}
			if (!flag)
			{
				yield return pattern;
			}
			yield break;
			yield break;
		}

		private static IEnumerable<string> ExpandSet(string set)
		{
			return set.Split(new char[]
			{
				','
			});
		}

		private static IEnumerable<string> ExpandRange(string range)
		{
			string[] array = range.Split(new char[]
			{
				'-'
			});
			if (array.Length != 2)
			{
				throw new ArgumentException(string.Format("Range does not contain low and high values (single {0} separator): {1}", '-', range));
			}
			string text = array[0];
			string text2 = array[1];
			if (text.Length == 0 || text2.Length == 0)
			{
				throw new ArgumentException(string.Format("Range is missing a value: {0}", range));
			}
			if (char.IsLetter(text, 0))
			{
				if (!char.IsLetter(text2, 0))
				{
					throw new ArgumentException(string.Format("Range must be homogenous (letter bounds or numeric bounds): {0}", range));
				}
				if (text.Length != 1 || text2.Length != 1)
				{
					throw new ArgumentException(string.Format("Letter range must be single character: {0}", range));
				}
				if (char.IsLower(text[0]) != char.IsLower(text2[0]))
				{
					throw new ArgumentException(string.Format("Letter range must be same case: {0}", range));
				}
				if (text.CompareTo(text2) > 0)
				{
					throw new ArgumentException(string.Format("Range low cannot be greater than high: {0}", range));
				}
				int num = (int)text[0];
				int highValue = (int)text2[0];
				int num2;
				for (int value = num; value <= highValue; value = num2 + 1)
				{
					yield return string.Format("{0}", (char)value);
					num2 = value;
				}
			}
			else
			{
				if (!char.IsDigit(text, 0))
				{
					throw new ArgumentException(string.Format("Malformed range (must have letter bounds or numeric bounds): {0}", range));
				}
				int highValue;
				int num3;
				if (!int.TryParse(text, out num3) || !int.TryParse(text2, out highValue))
				{
					throw new ArgumentException(string.Format("Range must be homogenous (letter bounds or numeric bounds): {0}", range));
				}
				if (num3 > highValue)
				{
					throw new ArgumentException(string.Format("Range low cannot be greater than high: {0}", range));
				}
				int length = text.Length;
				string format = "";
				for (int i = 0; i < length; i++)
				{
					format += "0";
				}
				int num2;
				for (int value = num3; value <= highValue; value = num2 + 1)
				{
					yield return value.ToString(format);
					num2 = value;
				}
				format = null;
			}
			yield break;
		}

		private const char SetOpenChar = '{';

		private const char SetSeparatorChar = ',';

		private const char SetCloseChar = '}';

		private const char RangeOpenChar = '[';

		private const char RangeSeparatorChar = '-';

		private const char RangeCloseChar = ']';
	}
}
