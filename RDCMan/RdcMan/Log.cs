using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using RdcMan.Configuration;

namespace RdcMan
{
	// Token: 0x02000064 RID: 100
	public static class Log
	{
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600028B RID: 651 RVA: 0x0000EACC File Offset: 0x0000CCCC
		// (set) Token: 0x0600028C RID: 652 RVA: 0x0000EAD4 File Offset: 0x0000CCD4
		public static bool Enabled { get; private set; }

		// Token: 0x0600028D RID: 653 RVA: 0x0000EADC File Offset: 0x0000CCDC
		public static void Init()
		{
			RdcManSection rdcManSection = Current.RdcManSection;
			LoggingElement loggingElement = (rdcManSection != null) ? rdcManSection.Logging : null;
			Log.Enabled = (loggingElement != null && loggingElement.Enabled);
			if (Log.Enabled)
			{
				string text = Environment.ExpandEnvironmentVariables(loggingElement.Path);
				string format = "RDCMan-{0}.log";
				foreach (FileInfo fileInfo in (from n in Directory.GetFiles(text, format.InvariantFormat(new object[]
				{
					"*"
				}), SearchOption.TopDirectoryOnly)
				select new FileInfo(n) into i
				orderby i.CreationTime descending
				select i).Skip(loggingElement.MaximumNumberOfFiles - 1))
				{
					try
					{
						fileInfo.Delete();
					}
					catch
					{
					}
				}
				string text2 = DateTime.Now.ToString("yyyyMMddHHmm");
				string path = Path.Combine(text, format.InvariantFormat(new object[]
				{
					text2
				}));
				Stream stream = File.Open(path, FileMode.Create, FileAccess.Write, FileShare.Read);
				Log.Writer = new StreamWriter(stream);
			}
			Log.Write("RDCMan v{0} build {1}", new object[]
			{
				Program.TheForm.VersionText,
				Program.TheForm.BuildText
			});
			Log.Write(Environment.OSVersion.ToString(), Array.Empty<object>());
			Log.Write(".NET v{0}".InvariantFormat(new object[]
			{
				Environment.Version
			}), Array.Empty<object>());
			Log.Write("mstscax.dll v{0}".InvariantFormat(new object[]
			{
				RdpClient.RdpControlVersion
			}), Array.Empty<object>());
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000ECD0 File Offset: 0x0000CED0
		public static void Write(string format, params object[] args)
		{
			string value = "{0} {1} {2}".InvariantFormat(new object[]
			{
				DateTime.Now.ToString("s"),
				new string(' ', Log.Indent * 2),
				format.InvariantFormat(args)
			});
			if (Log.Enabled)
			{
				Log.Writer.WriteLine(value);
				Log.Writer.Flush();
			}
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000ED44 File Offset: 0x0000CF44
		public static void AdjustIndent(int delta)
		{
			Log.Indent += delta;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000ED54 File Offset: 0x0000CF54
		public static void DumpObject<T>(T o)
		{
			HashSet<object> visited = new HashSet<object>();
			Type typeFromHandle = typeof(T);
			Log.Write("Fields of {0}:", new object[]
			{
				typeFromHandle
			});
			Log.DumpObject<T>(o, visited);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000ED94 File Offset: 0x0000CF94
		private static void DumpObject<T>(T o, HashSet<object> visited)
		{
			Type typeFromHandle = typeof(T);
			Log.DumpObject<T>(o, typeFromHandle, visited);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0000EDB8 File Offset: 0x0000CFB8
		private static void DumpObject<T>(T o, Type type, HashSet<object> visited)
		{
			Log.AdjustIndent(1);
			foreach (PropertyInfo propertyInfo in type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
			{
				if (propertyInfo.GetGetMethod() != null && propertyInfo.Name.IndexOf("password", StringComparison.OrdinalIgnoreCase) == -1)
				{
					try
					{
						object value = propertyInfo.GetValue(o, null);
						Log.DumpValue(propertyInfo, value, visited);
					}
					catch (Exception ex)
					{
						Log.Write("{0} exception when processing: {1}", new object[]
						{
							propertyInfo.Name,
							ex.Message
						});
					}
				}
			}
			Log.AdjustIndent(-1);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000EE74 File Offset: 0x0000D074
		private static void DumpValue(PropertyInfo prop, object value, HashSet<object> visited)
		{
			Type propertyType = prop.PropertyType;
			if (value == null || propertyType.IsPrimitive || propertyType.IsEnum)
			{
				Log.Write("{0} {1} = {2}", new object[]
				{
					propertyType.Name,
					prop.Name,
					value ?? "{null}"
				});
				return;
			}
			if (propertyType.FullName.Equals("System.String"))
			{
				Log.Write("{0} {1} = '{2}'", new object[]
				{
					propertyType.Name,
					prop.Name,
					value
				});
				return;
			}
			if (propertyType.IsArray)
			{
				Log.Write("{0} {1}", new object[]
				{
					propertyType.Name,
					prop.Name
				});
				return;
			}
			if (visited.Add(value))
			{
				Log.Write("{0} {1}", new object[]
				{
					propertyType.Name,
					prop.Name
				});
				Log.DumpObject<object>(value, propertyType, visited);
				return;
			}
			Log.Write("{0} is a recursive reference", new object[]
			{
				prop.Name
			});
		}

		// Token: 0x04000152 RID: 338
		private static int Indent;

		// Token: 0x04000153 RID: 339
		private static TextWriter Writer;
	}
}
