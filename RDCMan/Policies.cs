using System;
using Microsoft.Win32;

namespace RdcMan
{
	// Token: 0x020000F1 RID: 241
	public class Policies
	{
		// Token: 0x060005FD RID: 1533 RVA: 0x0001AA40 File Offset: 0x00018C40
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

		// Token: 0x04000494 RID: 1172
		public const string PolicyRegKey = "RDCMan";

		// Token: 0x04000495 RID: 1173
		public static bool DisableLogOff;
	}
}
