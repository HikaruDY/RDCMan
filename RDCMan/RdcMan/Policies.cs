using System;
using Microsoft.Win32;

namespace RdcMan
{
	// Token: 0x0200008E RID: 142
	public class Policies
	{
		// Token: 0x060004D0 RID: 1232 RVA: 0x000180DC File Offset: 0x000162DC
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

		// Token: 0x040001E7 RID: 487
		public const string PolicyRegKey = "RDCMan";

		// Token: 0x040001E8 RID: 488
		public static bool DisableLogOff;
	}
}
