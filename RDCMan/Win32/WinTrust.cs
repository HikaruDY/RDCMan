using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public sealed class WinTrust
	{
		[DllImport("wintrust.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
		private static extern WinVerifyTrustResult WinVerifyTrust([In] IntPtr hwnd, [MarshalAs(UnmanagedType.LPStruct)] [In] Guid pgActionID, [In] WinTrustData pWVTData);

		public static bool VerifyEmbeddedSignature(string fileName)
		{
			WinTrustData pWVTData = new WinTrustData(fileName);
			Guid pgActionID = new Guid("{00AAC56B-CD44-11d0-8CC2-00C04FC295EE}");
			WinVerifyTrustResult winVerifyTrustResult = WinTrust.WinVerifyTrust(WinTrust.INVALID_HANDLE_VALUE, pgActionID, pWVTData);
			return winVerifyTrustResult == WinVerifyTrustResult.Success;
		}

		private WinTrust()
		{
		}

		private static readonly IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);

		private const string WINTRUST_ACTION_GENERIC_VERIFY_V2 = "{00AAC56B-CD44-11d0-8CC2-00C04FC295EE}";
	}
}
