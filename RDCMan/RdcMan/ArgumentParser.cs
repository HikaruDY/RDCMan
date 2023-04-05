using System;
using System.Collections.Generic;

namespace RdcMan
{
	public class ArgumentParser
	{
		public void AddSwitch(string name, bool requiresValue)
		{
			this.Switches[name] = requiresValue;
		}

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

		public bool HasSwitch(string name)
		{
			string text;
			return this.SwitchValues.TryGetValue(name, out text);
		}

		private bool IsSwitch(string arg)
		{
			char c = arg[0];
			return c == '/' || c == '-';
		}

		public Dictionary<string, bool> Switches = new Dictionary<string, bool>(StringComparer.OrdinalIgnoreCase);

		public Dictionary<string, string> SwitchValues = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

		public List<string> PlainArgs = new List<string>();
	}
}
