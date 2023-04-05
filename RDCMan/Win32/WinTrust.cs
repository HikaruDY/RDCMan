using System;
using System.Runtime.InteropServices;

namespace Win32
{
	// Token: 0x02000013 RID: 19
	public sealed class WinTrust
	{
		// Token: 0x06000031 RID: 49
		[DllImport("wintrust.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
		private static extern WinVerifyTrustResult WinVerifyTrust([In] IntPtr hwnd, [MarshalAs(UnmanagedType.LPStruct)] [In] Guid pgActionID, [In] WinTrustData pWVTData);

		// Token: 0x06000032 RID: 50 RVA: 0x000022C4 File Offset: 0x000004C4
		public static bool VerifyEmbeddedSignature(string fileName)
		{
			WinTrustData pWVTData = new WinTrustData(fileName);
			Guid pgActionID = new Guid("{00AAC56B-CD44-11d0-8CC2-00C04FC295EE}");
			WinVerifyTrustResult winVerifyTrustResult = WinTrust.WinVerifyTrust(WinTrust.INVALID_HANDLE_VALUE, pgActionID, pWVTData);
			return winVerifyTrustResult == WinVerifyTrustResult.Success;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000022FC File Offset: 0x000004FC
		private WinTrust()
		{
		}

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);

		// Token: 0x0400006E RID: 110
		private const string WINTRUST_ACTION_GENERIC_VERIFY_V2 = "{00AAC56B-CD44-11d0-8CC2-00C04FC295EE}";
	}
}
