using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001FB RID: 507
	[Guid("EAB16C5D-EED1-4E95-868B-0FBA1B42C092")]
	[TypeLibType(2)]
	[ComSourceInterfaces("MSTSCLib.IRemoteDesktopClientEvents\0")]
	[ClassInterface(0)]
	[ComVisible(true)]
	[ComImport]
	public class RemoteDesktopClientClass : IRemoteDesktopClient, RemoteDesktopClient, IRemoteDesktopClientEvents_Event
	{
		// Token: 0x0600549F RID: 21663
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern RemoteDesktopClientClass();

		// Token: 0x060054A0 RID: 21664
		[DispId(701)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Connect();

		// Token: 0x060054A1 RID: 21665
		[DispId(702)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Disconnect();

		// Token: 0x060054A2 RID: 21666
		[DispId(703)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Reconnect([In] uint width, [In] uint height);

		// Token: 0x1700212D RID: 8493
		// (get) Token: 0x060054A3 RID: 21667
		[DispId(710)]
		public virtual extern IRemoteDesktopClientSettings Settings { [DispId(710)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700212E RID: 8494
		// (get) Token: 0x060054A4 RID: 21668
		[DispId(711)]
		public virtual extern IRemoteDesktopClientActions Actions { [DispId(711)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700212F RID: 8495
		// (get) Token: 0x060054A5 RID: 21669
		[DispId(712)]
		public virtual extern IRemoteDesktopClientTouchPointer TouchPointer { [DispId(712)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060054A6 RID: 21670
		[DispId(704)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void DeleteSavedCredentials([MarshalAs(UnmanagedType.BStr)] [In] string serverName);

		// Token: 0x060054A7 RID: 21671
		[DispId(705)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void UpdateSessionDisplaySettings([In] uint width, [In] uint height);

		// Token: 0x060054A8 RID: 21672
		[DispId(706)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void attachEvent([MarshalAs(UnmanagedType.BStr)] [In] string eventName, [MarshalAs(UnmanagedType.IDispatch)] [In] object callback);

		// Token: 0x060054A9 RID: 21673
		[DispId(707)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void detachEvent([MarshalAs(UnmanagedType.BStr)] [In] string eventName, [MarshalAs(UnmanagedType.IDispatch)] [In] object callback);

		// Token: 0x140006B7 RID: 1719
		// (add) Token: 0x060054AA RID: 21674
		// (remove) Token: 0x060054AB RID: 21675
		public virtual extern event IRemoteDesktopClientEvents_OnConnectingEventHandler OnConnecting;

		// Token: 0x140006B8 RID: 1720
		// (add) Token: 0x060054AC RID: 21676
		// (remove) Token: 0x060054AD RID: 21677
		public virtual extern event IRemoteDesktopClientEvents_OnConnectedEventHandler OnConnected;

		// Token: 0x140006B9 RID: 1721
		// (add) Token: 0x060054AE RID: 21678
		// (remove) Token: 0x060054AF RID: 21679
		public virtual extern event IRemoteDesktopClientEvents_OnLoginCompletedEventHandler OnLoginCompleted;

		// Token: 0x140006BA RID: 1722
		// (add) Token: 0x060054B0 RID: 21680
		// (remove) Token: 0x060054B1 RID: 21681
		public virtual extern event IRemoteDesktopClientEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x140006BB RID: 1723
		// (add) Token: 0x060054B2 RID: 21682
		// (remove) Token: 0x060054B3 RID: 21683
		public virtual extern event IRemoteDesktopClientEvents_OnStatusChangedEventHandler OnStatusChanged;

		// Token: 0x140006BC RID: 1724
		// (add) Token: 0x060054B4 RID: 21684
		// (remove) Token: 0x060054B5 RID: 21685
		public virtual extern event IRemoteDesktopClientEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x140006BD RID: 1725
		// (add) Token: 0x060054B6 RID: 21686
		// (remove) Token: 0x060054B7 RID: 21687
		public virtual extern event IRemoteDesktopClientEvents_OnAutoReconnectedEventHandler OnAutoReconnected;

		// Token: 0x140006BE RID: 1726
		// (add) Token: 0x060054B8 RID: 21688
		// (remove) Token: 0x060054B9 RID: 21689
		public virtual extern event IRemoteDesktopClientEvents_OnDialogDisplayingEventHandler OnDialogDisplaying;

		// Token: 0x140006BF RID: 1727
		// (add) Token: 0x060054BA RID: 21690
		// (remove) Token: 0x060054BB RID: 21691
		public virtual extern event IRemoteDesktopClientEvents_OnDialogDismissedEventHandler OnDialogDismissed;

		// Token: 0x140006C0 RID: 1728
		// (add) Token: 0x060054BC RID: 21692
		// (remove) Token: 0x060054BD RID: 21693
		public virtual extern event IRemoteDesktopClientEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x140006C1 RID: 1729
		// (add) Token: 0x060054BE RID: 21694
		// (remove) Token: 0x060054BF RID: 21695
		public virtual extern event IRemoteDesktopClientEvents_OnAdminMessageReceivedEventHandler OnAdminMessageReceived;

		// Token: 0x140006C2 RID: 1730
		// (add) Token: 0x060054C0 RID: 21696
		// (remove) Token: 0x060054C1 RID: 21697
		public virtual extern event IRemoteDesktopClientEvents_OnKeyCombinationPressedEventHandler OnKeyCombinationPressed;

		// Token: 0x140006C3 RID: 1731
		// (add) Token: 0x060054C2 RID: 21698
		// (remove) Token: 0x060054C3 RID: 21699
		public virtual extern event IRemoteDesktopClientEvents_OnRemoteDesktopSizeChangedEventHandler OnRemoteDesktopSizeChanged;

		// Token: 0x140006C4 RID: 1732
		// (add) Token: 0x060054C4 RID: 21700
		// (remove) Token: 0x060054C5 RID: 21701
		public virtual extern event IRemoteDesktopClientEvents_OnTouchPointerCursorMovedEventHandler OnTouchPointerCursorMoved;
	}
}
