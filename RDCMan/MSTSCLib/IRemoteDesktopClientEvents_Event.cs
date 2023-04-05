using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001FC RID: 508
	[TypeLibType(16)]
	[ComVisible(false)]
	[ComEventInterface(typeof(IRemoteDesktopClientEvents), typeof(IRemoteDesktopClientEvents_EventProvider))]
	public interface IRemoteDesktopClientEvents_Event
	{
		// Token: 0x140006C5 RID: 1733
		// (add) Token: 0x060054C6 RID: 21702
		// (remove) Token: 0x060054C7 RID: 21703
		event IRemoteDesktopClientEvents_OnConnectingEventHandler OnConnecting;

		// Token: 0x140006C6 RID: 1734
		// (add) Token: 0x060054C8 RID: 21704
		// (remove) Token: 0x060054C9 RID: 21705
		event IRemoteDesktopClientEvents_OnConnectedEventHandler OnConnected;

		// Token: 0x140006C7 RID: 1735
		// (add) Token: 0x060054CA RID: 21706
		// (remove) Token: 0x060054CB RID: 21707
		event IRemoteDesktopClientEvents_OnLoginCompletedEventHandler OnLoginCompleted;

		// Token: 0x140006C8 RID: 1736
		// (add) Token: 0x060054CC RID: 21708
		// (remove) Token: 0x060054CD RID: 21709
		event IRemoteDesktopClientEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x140006C9 RID: 1737
		// (add) Token: 0x060054CE RID: 21710
		// (remove) Token: 0x060054CF RID: 21711
		event IRemoteDesktopClientEvents_OnStatusChangedEventHandler OnStatusChanged;

		// Token: 0x140006CA RID: 1738
		// (add) Token: 0x060054D0 RID: 21712
		// (remove) Token: 0x060054D1 RID: 21713
		event IRemoteDesktopClientEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x140006CB RID: 1739
		// (add) Token: 0x060054D2 RID: 21714
		// (remove) Token: 0x060054D3 RID: 21715
		event IRemoteDesktopClientEvents_OnAutoReconnectedEventHandler OnAutoReconnected;

		// Token: 0x140006CC RID: 1740
		// (add) Token: 0x060054D4 RID: 21716
		// (remove) Token: 0x060054D5 RID: 21717
		event IRemoteDesktopClientEvents_OnDialogDisplayingEventHandler OnDialogDisplaying;

		// Token: 0x140006CD RID: 1741
		// (add) Token: 0x060054D6 RID: 21718
		// (remove) Token: 0x060054D7 RID: 21719
		event IRemoteDesktopClientEvents_OnDialogDismissedEventHandler OnDialogDismissed;

		// Token: 0x140006CE RID: 1742
		// (add) Token: 0x060054D8 RID: 21720
		// (remove) Token: 0x060054D9 RID: 21721
		event IRemoteDesktopClientEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x140006CF RID: 1743
		// (add) Token: 0x060054DA RID: 21722
		// (remove) Token: 0x060054DB RID: 21723
		event IRemoteDesktopClientEvents_OnAdminMessageReceivedEventHandler OnAdminMessageReceived;

		// Token: 0x140006D0 RID: 1744
		// (add) Token: 0x060054DC RID: 21724
		// (remove) Token: 0x060054DD RID: 21725
		event IRemoteDesktopClientEvents_OnKeyCombinationPressedEventHandler OnKeyCombinationPressed;

		// Token: 0x140006D1 RID: 1745
		// (add) Token: 0x060054DE RID: 21726
		// (remove) Token: 0x060054DF RID: 21727
		event IRemoteDesktopClientEvents_OnRemoteDesktopSizeChangedEventHandler OnRemoteDesktopSizeChanged;

		// Token: 0x140006D2 RID: 1746
		// (add) Token: 0x060054E0 RID: 21728
		// (remove) Token: 0x060054E1 RID: 21729
		event IRemoteDesktopClientEvents_OnTouchPointerCursorMovedEventHandler OnTouchPointerCursorMoved;
	}
}
