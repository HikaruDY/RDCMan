using System;
using System.Runtime.InteropServices;

namespace Win32
{
	// Token: 0x02000027 RID: 39
	public sealed class WinTrust
	{
		// Token: 0x06000034 RID: 52
		[DllImport("wintrust.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
		private static extern WinVerifyTrustResult WinVerifyTrust([In] IntPtr hwnd, [MarshalAs(UnmanagedType.LPStruct)] [In] Guid pgActionID, [In] WinTrustData pWVTData);

		// Token: 0x06000035 RID: 53 RVA: 0x000087BC File Offset: 0x000069BC
		public static bool VerifyEmbeddedSignature(string fileName)
		{
			WinTrustData pWVTData = new WinTrustData(fileName);
			Guid pgActionID = new Guid("{00AAC56B-CD44-11d0-8CC2-00C04FC295EE}");
			WinVerifyTrustResult winVerifyTrustResult = WinTrust.WinVerifyTrust(WinTrust.INVALID_HANDLE_VALUE, pgActionID, pWVTData);
			return winVerifyTrustResult == WinVerifyTrustResult.Success;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002084 File Offset: 0x00000284
		private WinTrust()
		{
		}

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);

		// Token: 0x04000239 RID: 569
		private const string WINTRUST_ACTION_GENERIC_VERIFY_V2 = "{00AAC56B-CD44-11d0-8CC2-00C04FC295EE}";
	}
}
