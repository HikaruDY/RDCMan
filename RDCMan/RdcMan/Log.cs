using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using RdcMan.Configuration;

namespace RdcMan
{
	public static class Log
	{
		public static bool Enabled { get; private set; }

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

		public static void AdjustIndent(int delta)
		{
			Log.Indent += delta;
		}

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

		private static void DumpObject<T>(T o, HashSet<object> visited)
		{
			Type typeFromHandle = typeof(T);
			Log.DumpObject<T>(o, typeFromHandle, visited);
		}

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

		private static int Indent;

		private static TextWriter Writer;
	}
}
