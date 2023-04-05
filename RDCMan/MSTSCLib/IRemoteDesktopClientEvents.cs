using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001FA RID: 506
	[TypeLibType(4096)]
	[InterfaceType(2)]
	[Guid("079863B7-6D47-4105-8BFE-0CDCB360E67D")]
	[ComVisible(true)]
	[ComImport]
	public interface IRemoteDesktopClientEvents
	{
		// Token: 0x06005491 RID: 21649
		[DispId(750)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnConnecting();

		// Token: 0x06005492 RID: 21650
		[DispId(751)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnConnected();

		// Token: 0x06005493 RID: 21651
		[DispId(752)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnLoginCompleted();

		// Token: 0x06005494 RID: 21652
		[DispId(753)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnDisconnected([In] int disconnectReason, [In] int ExtendedDisconnectReason, [MarshalAs(UnmanagedType.BStr)] [In] string disconnectErrorMessage);

		// Token: 0x06005495 RID: 21653
		[DispId(754)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnStatusChanged([In] int statusCode, [MarshalAs(UnmanagedType.BStr)] [In] string statusMessage);

		// Token: 0x06005496 RID: 21654
		[DispId(755)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnAutoReconnecting([In] int disconnectReason, [In] int ExtendedDisconnectReason, [MarshalAs(UnmanagedType.BStr)] [In] string disconnectErrorMessage, [In] bool networkAvailable, [In] int attemptCount, [In] int maxAttemptCount);

		// Token: 0x06005497 RID: 21655
		[DispId(756)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnAutoReconnected();

		// Token: 0x06005498 RID: 21656
		[DispId(757)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnDialogDisplaying();

		// Token: 0x06005499 RID: 21657
		[DispId(758)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnDialogDismissed();

		// Token: 0x0600549A RID: 21658
		[DispId(759)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnNetworkStatusChanged([In] uint qualityLevel, [In] int bandwidth, [In] int rtt);

		// Token: 0x0600549B RID: 21659
		[DispId(760)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnAdminMessageReceived([MarshalAs(UnmanagedType.BStr)] [In] string adminMessage);

		// Token: 0x0600549C RID: 21660
		[DispId(761)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnKeyCombinationPressed([In] int keyCombination);

		// Token: 0x0600549D RID: 21661
		[DispId(762)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnRemoteDesktopSizeChanged([In] int width, [In] int height);

		// Token: 0x0600549E RID: 21662
		[DispId(800)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnTouchPointerCursorMoved([In] int x, [In] int y);
	}
}
