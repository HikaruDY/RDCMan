using System;
using System.Collections.Generic;

namespace RdcMan
{
	// Token: 0x0200002E RID: 46
	public class ArgumentParser
	{
		// Token: 0x06000051 RID: 81 RVA: 0x0000224D File Offset: 0x0000044D
		public void AddSwitch(string name, bool requiresValue)
		{
			this.Switches[name] = requiresValue;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00008E14 File Offset: 0x00007014
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

		// Token: 0x06000053 RID: 83 RVA: 0x00008EC8 File Offset: 0x000070C8
		public bool HasSwitch(string name)
		{
			string text;
			return this.SwitchValues.TryGetValue(name, out text);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00008EE4 File Offset: 0x000070E4
		private bool IsSwitch(string arg)
		{
			char c = arg[0];
			return c == '/' || c == '-';
		}

		// Token: 0x04000240 RID: 576
		public Dictionary<string, bool> Switches = new Dictionary<string, bool>(StringComparer.OrdinalIgnoreCase);

		// Token: 0x04000241 RID: 577
		public Dictionary<string, string> SwitchValues = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

		// Token: 0x04000242 RID: 578
		public List<string> PlainArgs = new List<string>();
	}
}
