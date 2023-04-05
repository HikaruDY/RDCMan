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
	// Token: 0x0200005C RID: 92
	public static class Helpers
	{
		// Token: 0x06000257 RID: 599 RVA: 0x0000DB7C File Offset: 0x0000BD7C
		public static void Add(this Control.ControlCollection collection, params Control[] controls)
		{
			collection.AddRange(controls);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0000DB88 File Offset: 0x0000BD88
		public static string GetName(this XmlNode node)
		{
			XmlAttribute xmlAttribute = node.Attributes["name"];
			if (xmlAttribute != null)
			{
				return xmlAttribute.Value;
			}
			return node.Name;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000DBC0 File Offset: 0x0000BDC0
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

		// Token: 0x0600025A RID: 602 RVA: 0x0000DC20 File Offset: 0x0000BE20
		public static void ForEach<TObject>(this IEnumerable<TObject> objects, Action<TObject> action)
		{
			foreach (TObject obj in objects)
			{
				action(obj);
			}
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000DC74 File Offset: 0x0000BE74
		public static void ForEach(this TreeNodeCollection objects, Action<TreeNode> action)
		{
			foreach (object obj in objects)
			{
				TreeNode obj2 = (TreeNode)obj;
				action(obj2);
			}
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000DCD4 File Offset: 0x0000BED4
		public static TEnum ParseEnum<TEnum>(this string value) where TEnum : struct
		{
			return (TEnum)((object)Enum.Parse(typeof(TEnum), value));
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000DCEC File Offset: 0x0000BEEC
		public static IEnumerable<TEnum> EnumValues<TEnum>() where TEnum : struct
		{
			return Enum.GetValues(typeof(TEnum)).Cast<TEnum>();
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0000DD04 File Offset: 0x0000BF04
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

		// Token: 0x0600025F RID: 607 RVA: 0x0000DD3C File Offset: 0x0000BF3C
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

		// Token: 0x06000260 RID: 608 RVA: 0x0000DD7C File Offset: 0x0000BF7C
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

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000261 RID: 609 RVA: 0x0000DDC0 File Offset: 0x0000BFC0
		public static bool IsControlKeyPressed
		{
			get
			{
				short asyncKeyState = User.GetAsyncKeyState(17);
				return ((int)asyncKeyState & 32768) != 0;
			}
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000DDE4 File Offset: 0x0000BFE4
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

		// Token: 0x06000263 RID: 611 RVA: 0x0000DE9C File Offset: 0x0000C09C
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

		// Token: 0x06000264 RID: 612 RVA: 0x0000DEF4 File Offset: 0x0000C0F4
		public static IDisposable Timer(string format, params object[] args)
		{
			return new Helpers.OperationTimer(format.InvariantFormat(args));
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0000DF04 File Offset: 0x0000C104
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

		// Token: 0x06000266 RID: 614 RVA: 0x0000DF78 File Offset: 0x0000C178
		private static void AppendUnitValue(StringBuilder builder, int value, string unit)
		{
			builder.AppendFormat("{0} {1}{2}", value, unit, (value != 1) ? "s" : string.Empty);
		}

		// Token: 0x0200024E RID: 590
		// (Invoke) Token: 0x06005623 RID: 22051
		public delegate void ReadXmlDelegate(XmlNode childNode, RdcTreeNode node, ICollection<string> errors);

		// Token: 0x0200024F RID: 591
		private class OperationTimer : IDisposable
		{
			// Token: 0x06005626 RID: 22054 RVA: 0x0005DA68 File Offset: 0x0005BC68
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

			// Token: 0x06005627 RID: 22055 RVA: 0x0005DAB8 File Offset: 0x0005BCB8
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

			// Token: 0x04000A3E RID: 2622
			private Stopwatch _stopWatch;

			// Token: 0x04000A3F RID: 2623
			private string _text;
		}
	}
}
