using System;
using Microsoft.Win32;

namespace RdcMan
{
	public class Policies
	{
		public static void Read()
		{
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software", true).OpenSubKey("Policies", true).OpenSubKey("Microsoft", true).CreateSubKey("RDCMan", RegistryKeyPermissionCheck.ReadSubTree);
				if (registryKey != null)
				{
					Policies.DisableLogOff = ((int)registryKey.GetValue("DisableLogOff", 0) == 1);
				}
			}
			catch
			{
			}
		}

		public const string PolicyRegKey = "RDCMan";

		public static bool DisableLogOff;
	}
}
