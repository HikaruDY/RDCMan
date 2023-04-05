using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Win32;

namespace RdcMan
{
	public static class Helpers
	{
		public static void Add(this Control.ControlCollection collection, params Control[] controls)
		{
			collection.AddRange(controls);
		}

		public static string GetName(this XmlNode node)
		{
			XmlAttribute xmlAttribute = node.Attributes["name"];
			if (xmlAttribute != null)
			{
				return xmlAttribute.Value;
			}
			return node.Name;
		}

		public static string GetFullPath(this XmlNode node)
		{
			StringBuilder stringBuilder = new StringBuilder(node.GetName());
			XmlNode parentNode = node.ParentNode;
			while (parentNode != null && !(parentNode is XmlDocument))
			{
				stringBuilder.Insert(0, "/");
				stringBuilder.Insert(0, parentNode.GetName());
				parentNode = parentNode.ParentNode;
			}
			return stringBuilder.ToString();
		}

		public static void ForEach<TObject>(this IEnumerable<TObject> objects, Action<TObject> action)
		{
			foreach (TObject obj in objects)
			{
				action(obj);
			}
		}

		public static void ForEach(this TreeNodeCollection objects, Action<TreeNode> action)
		{
			foreach (object obj in objects)
			{
				TreeNode obj2 = (TreeNode)obj;
				action(obj2);
			}
		}

		public static TEnum ParseEnum<TEnum>(this string value) where TEnum : struct
		{
			return (TEnum)((object)Enum.Parse(typeof(TEnum), value));
		}

		public static IEnumerable<TEnum> EnumValues<TEnum>() where TEnum : struct
		{
			return Enum.GetValues(typeof(TEnum)).Cast<TEnum>();
		}

		public static string SortOrderToString(SortOrder sortOrder)
		{
			switch (sortOrder)
			{
			case SortOrder.ByStatus:
				return "Status.Name";
			case SortOrder.ByName:
				return "Name";
			case SortOrder.None:
				return "No sorting";
			default:
				throw new Exception("Unexpected SortOrder");
			}
		}

		public static string GetTemporaryFileName(string fileName, string suffix)
		{
			string text = fileName + suffix;
			int num = 0;
			while (File.Exists(text))
			{
				text = fileName + suffix + num++.ToString();
			}
			return text;
		}

		public static void MoveTemporaryToPermanent(string newFileName, string fileName, bool saveOld)
		{
			string temporaryFileName = Helpers.GetTemporaryFileName(fileName, ".old");
			if (File.Exists(fileName))
			{
				File.Move(fileName, temporaryFileName);
			}
			File.Move(newFileName, fileName);
			if (!saveOld)
			{
				File.Delete(temporaryFileName);
			}
		}

		public static bool IsControlKeyPressed
		{
			get
			{
				short asyncKeyState = User.GetAsyncKeyState(17);
				return ((int)asyncKeyState & 32768) != 0;
			}
		}

		public static int NaturalCompare(string x, string y)
		{
			int num = 0;
			int num2 = 0;
			while (num < x.Length && num2 < y.Length)
			{
				char c = char.ToLowerInvariant(x[num]);
				char c2 = char.ToLowerInvariant(y[num]);
				if (char.IsDigit(c) && char.IsDigit(c2))
				{
					uint num3 = Helpers.ParseNumber(x, ref num);
					uint num4 = Helpers.ParseNumber(y, ref num2);
					if (num3 != num4)
					{
						if (num3 >= num4)
						{
							return 1;
						}
						return -1;
					}
					else if (num != num2)
					{
						return num2 - num;
					}
				}
				else
				{
					if (c != c2)
					{
						return (int)(c - c2);
					}
					num++;
					num2++;
				}
			}
			return x.Length - y.Length;
		}

		private static uint ParseNumber(string s, ref int i)
		{
			uint num = (uint)(s[i] - '0');
			for (;;)
			{
				int num2 = i + 1;
				i = num2;
				if (num2 >= s.Length || !char.IsDigit(s[i]))
				{
					break;
				}
				num = num * 10U + (uint)s[i] - 48U;
			}
			return num;
		}

		public static IDisposable Timer(string format, params object[] args)
		{
			return new Helpers.OperationTimer(format.InvariantFormat(args));
		}

		public static string FormatTime(int seconds)
		{
			StringBuilder stringBuilder = new StringBuilder();
			int num = seconds / 3600;
			seconds %= 3600;
			int num2 = seconds / 60;
			seconds %= 60;
			if (num > 0)
			{
				Helpers.AppendUnitValue(stringBuilder, num, "hour");
			}
			if (num > 0 || num2 > 0)
			{
				Helpers.AppendUnitValue(stringBuilder, num2, "minute");
			}
			Helpers.AppendUnitValue(stringBuilder, seconds, "second");
			return stringBuilder.ToString();
		}

		private static void AppendUnitValue(StringBuilder builder, int value, string unit)
		{
			builder.AppendFormat("{0} {1}{2}", value, unit, (value != 1) ? "s" : string.Empty);
		}

		public delegate void ReadXmlDelegate(XmlNode childNode, RdcTreeNode node, ICollection<string> errors);

		private class OperationTimer : IDisposable
		{
			public OperationTimer(string text)
			{
				this._text = text;
				this._stopWatch = new Stopwatch();
				this._stopWatch.Start();
				Log.Write("Started {0}", new object[]
				{
					text
				});
				Log.AdjustIndent(1);
			}

			void IDisposable.Dispose()
			{
				this._stopWatch.Stop();
				Log.AdjustIndent(-1);
				Log.Write("Finished {0}: {1} ms", new object[]
				{
					this._text,
					this._stopWatch.ElapsedMilliseconds
				});
			}

			private Stopwatch _stopWatch;

			private string _text;
		}
	}
}
