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
	// Token: 0x02000090 RID: 144
	public static class Helpers
	{
		// Token: 0x060002CE RID: 718 RVA: 0x000038C2 File Offset: 0x00001AC2
		public static void Add(this Control.ControlCollection collection, params Control[] controls)
		{
			collection.AddRange(controls);
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0001286C File Offset: 0x00010A6C
		public static string GetName(this XmlNode node)
		{
			XmlAttribute xmlAttribute = node.Attributes["name"];
			if (xmlAttribute != null)
			{
				return xmlAttribute.Value;
			}
			return node.Name;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0001289C File Offset: 0x00010A9C
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

		// Token: 0x060002D1 RID: 721 RVA: 0x000128F4 File Offset: 0x00010AF4
		public static void ForEach<TObject>(this IEnumerable<TObject> objects, Action<TObject> action)
		{
			foreach (TObject obj in objects)
			{
				action(obj);
			}
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0001293C File Offset: 0x00010B3C
		public static void ForEach(this TreeNodeCollection objects, Action<TreeNode> action)
		{
			foreach (object obj in objects)
			{
				TreeNode obj2 = (TreeNode)obj;
				action(obj2);
			}
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x000038CB File Offset: 0x00001ACB
		public static TEnum ParseEnum<TEnum>(this string value) where TEnum : struct
		{
			return (TEnum)((object)Enum.Parse(typeof(TEnum), value));
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x000038E2 File Offset: 0x00001AE2
		public static IEnumerable<TEnum> EnumValues<TEnum>() where TEnum : struct
		{
			return Enum.GetValues(typeof(TEnum)).Cast<TEnum>();
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x000038F8 File Offset: 0x00001AF8
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

		// Token: 0x060002D6 RID: 726 RVA: 0x00012990 File Offset: 0x00010B90
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

		// Token: 0x060002D7 RID: 727 RVA: 0x000129C8 File Offset: 0x00010BC8
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

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x00012A00 File Offset: 0x00010C00
		public static bool IsControlKeyPressed
		{
			get
			{
				short asyncKeyState = User.GetAsyncKeyState(17);
				return ((int)asyncKeyState & 32768) != 0;
			}
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00012A20 File Offset: 0x00010C20
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

		// Token: 0x060002DA RID: 730 RVA: 0x00012AB8 File Offset: 0x00010CB8
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
				num = num * 10u + (uint)s[i] - 48u;
			}
			return num;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0000392A File Offset: 0x00001B2A
		public static IDisposable Timer(string format, params object[] args)
		{
			return new Helpers.OperationTimer(format.InvariantFormat(args));
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00012B08 File Offset: 0x00010D08
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

		// Token: 0x060002DD RID: 733 RVA: 0x00003938 File Offset: 0x00001B38
		private static void AppendUnitValue(StringBuilder builder, int value, string unit)
		{
			builder.AppendFormat("{0} {1}{2}", value, unit, (value != 1) ? "s" : string.Empty);
		}

		// Token: 0x02000091 RID: 145
		// (Invoke) Token: 0x060002DF RID: 735
		public delegate void ReadXmlDelegate(XmlNode childNode, RdcTreeNode node, ICollection<string> errors);

		// Token: 0x02000092 RID: 146
		private class OperationTimer : IDisposable
		{
			// Token: 0x060002E2 RID: 738 RVA: 0x0000395D File Offset: 0x00001B5D
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

			// Token: 0x060002E3 RID: 739 RVA: 0x0000399C File Offset: 0x00001B9C
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

			// Token: 0x04000360 RID: 864
			private Stopwatch _stopWatch;

			// Token: 0x04000361 RID: 865
			private string _text;
		}
	}
}
