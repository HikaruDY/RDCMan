using System;
using System.Collections.Generic;

namespace RdcMan
{
	// Token: 0x02000016 RID: 22
	public class ArgumentParser
	{
		// Token: 0x06000045 RID: 69 RVA: 0x00002964 File Offset: 0x00000B64
		public void AddSwitch(string name, bool requiresValue)
		{
			this.Switches[name] = requiresValue;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002974 File Offset: 0x00000B74
		public void Parse()
		{
			string[] commandLineArgs = Environment.GetCommandLineArgs();
			for (int i = 1; i < commandLineArgs.Length; i++)
			{
				if (this.IsSwitch(commandLineArgs[i]))
				{
					string key = commandLineArgs[i].Substring(1);
					bool flag;
					if (!this.Switches.TryGetValue(key, out flag))
					{
						throw new ArgumentException("Unexpected switch: " + commandLineArgs[i]);
					}
					string value = string.Empty;
					if (flag)
					{
						if (i >= commandLineArgs.Length - 1)
						{
							throw new ArgumentException("Switch " + commandLineArgs[i] + " requires an argument");
						}
						value = commandLineArgs[++i];
					}
					this.SwitchValues[key] = value;
				}
				else
				{
					this.PlainArgs.Add(commandLineArgs[i]);
				}
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002A50 File Offset: 0x00000C50
		public bool HasSwitch(string name)
		{
			string text;
			return this.SwitchValues.TryGetValue(name, out text);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002A70 File Offset: 0x00000C70
		private bool IsSwitch(string arg)
		{
			char c = arg[0];
			return c == '/' || c == '-';
		}

		// Token: 0x0400006F RID: 111
		public Dictionary<string, bool> Switches = new Dictionary<string, bool>(StringComparer.OrdinalIgnoreCase);

		// Token: 0x04000070 RID: 112
		public Dictionary<string, string> SwitchValues = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

		// Token: 0x04000071 RID: 113
		public List<string> PlainArgs = new List<string>();
	}
}
