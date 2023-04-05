using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x02000218 RID: 536
	[ClassInterface(ClassInterfaceType.None)]
	[TypeLibType(TypeLibTypeFlags.FHidden)]
	[ComVisible(true)]
	public sealed class IRemoteDesktopClientEvents_SinkHelper : IRemoteDesktopClientEvents
	{
		// Token: 0x0600557B RID: 21883 RVA: 0x0005B278 File Offset: 0x00059478
		public void OnConnecting()
		{
			if (this.m_OnConnectingDelegate != null)
			{
				this.m_OnConnectingDelegate();
				return;
			}
		}

		// Token: 0x0600557C RID: 21884 RVA: 0x0005B294 File Offset: 0x00059494
		public void OnConnected()
		{
			if (this.m_OnConnectedDelegate != null)
			{
				this.m_OnConnectedDelegate();
				return;
			}
		}

		// Token: 0x0600557D RID: 21885 RVA: 0x0005B2B0 File Offset: 0x000594B0
		public void OnLoginCompleted()
		{
			if (this.m_OnLoginCompletedDelegate != null)
			{
				this.m_OnLoginCompletedDelegate();
				return;
			}
		}

		// Token: 0x0600557E RID: 21886 RVA: 0x0005B2CC File Offset: 0x000594CC
		public void OnDisconnected(int A_1, int A_2, string A_3)
		{
			if (this.m_OnDisconnectedDelegate != null)
			{
				this.m_OnDisconnectedDelegate(A_1, A_2, A_3);
				return;
			}
		}

		// Token: 0x0600557F RID: 21887 RVA: 0x0005B2E8 File Offset: 0x000594E8
		public void OnStatusChanged(int A_1, string A_2)
		{
			if (this.m_OnStatusChangedDelegate != null)
			{
				this.m_OnStatusChangedDelegate(A_1, A_2);
				return;
			}
		}

		// Token: 0x06005580 RID: 21888 RVA: 0x0005B304 File Offset: 0x00059504
		public void OnAutoReconnecting(int A_1, int A_2, string A_3, bool A_4, int A_5, int A_6)
		{
			if (this.m_OnAutoReconnectingDelegate != null)
			{
				this.m_OnAutoReconnectingDelegate(A_1, A_2, A_3, A_4, A_5, A_6);
				return;
			}
		}

		// Token: 0x06005581 RID: 21889 RVA: 0x0005B328 File Offset: 0x00059528
		public void OnAutoReconnected()
		{
			if (this.m_OnAutoReconnectedDelegate != null)
			{
				this.m_OnAutoReconnectedDelegate();
				return;
			}
		}

		// Token: 0x06005582 RID: 21890 RVA: 0x0005B344 File Offset: 0x00059544
		public void OnDialogDisplaying()
		{
			if (this.m_OnDialogDisplayingDelegate != null)
			{
				this.m_OnDialogDisplayingDelegate();
				return;
			}
		}

		// Token: 0x06005583 RID: 21891 RVA: 0x0005B360 File Offset: 0x00059560
		public void OnDialogDismissed()
		{
			if (this.m_OnDialogDismissedDelegate != null)
			{
				this.m_OnDialogDismissedDelegate();
				return;
			}
		}

		// Token: 0x06005584 RID: 21892 RVA: 0x0005B37C File Offset: 0x0005957C
		public void OnNetworkStatusChanged(uint A_1, int A_2, int A_3)
		{
			if (this.m_OnNetworkStatusChangedDelegate != null)
			{
				this.m_OnNetworkStatusChangedDelegate(A_1, A_2, A_3);
				return;
			}
		}

		// Token: 0x06005585 RID: 21893 RVA: 0x0005B398 File Offset: 0x00059598
		public void OnAdminMessageReceived(string A_1)
		{
			if (this.m_OnAdminMessageReceivedDelegate != null)
			{
				this.m_OnAdminMessageReceivedDelegate(A_1);
				return;
			}
		}

		// Token: 0x06005586 RID: 21894 RVA: 0x0005B3B4 File Offset: 0x000595B4
		public void OnKeyCombinationPressed(int A_1)
		{
			if (this.m_OnKeyCombinationPressedDelegate != null)
			{
				this.m_OnKeyCombinationPressedDelegate(A_1);
				return;
			}
		}

		// Token: 0x06005587 RID: 21895 RVA: 0x0005B3D0 File Offset: 0x000595D0
		public void OnRemoteDesktopSizeChanged(int A_1, int A_2)
		{
			if (this.m_OnRemoteDesktopSizeChangedDelegate != null)
			{
				this.m_OnRemoteDesktopSizeChangedDelegate(A_1, A_2);
				return;
			}
		}

		// Token: 0x06005588 RID: 21896 RVA: 0x0005B3EC File Offset: 0x000595EC
		public void OnTouchPointerCursorMoved(int A_1, int A_2)
		{
			if (this.m_OnTouchPointerCursorMovedDelegate != null)
			{
				this.m_OnTouchPointerCursorMovedDelegate(A_1, A_2);
				return;
			}
		}

		// Token: 0x06005589 RID: 21897 RVA: 0x0005B408 File Offset: 0x00059608
		internal IRemoteDesktopClientEvents_SinkHelper()
		{
			this.m_dwCookie = 0;
			this.m_OnConnectingDelegate = null;
			this.m_OnConnectedDelegate = null;
			this.m_OnLoginCompletedDelegate = null;
			this.m_OnDisconnectedDelegate = null;
			this.m_OnStatusChangedDelegate = null;
			this.m_OnAutoReconnectingDelegate = null;
			this.m_OnAutoReconnectedDelegate = null;
			this.m_OnDialogDisplayingDelegate = null;
			this.m_OnDialogDismissedDelegate = null;
			this.m_OnNetworkStatusChangedDelegate = null;
			this.m_OnAdminMessageReceivedDelegate = null;
			this.m_OnKeyCombinationPressedDelegate = null;
			this.m_OnRemoteDesktopSizeChangedDelegate = null;
			this.m_OnTouchPointerCursorMovedDelegate = null;
		}

		// Token: 0x0400080B RID: 2059
		public IRemoteDesktopClientEvents_OnConnectingEventHandler m_OnConnectingDelegate;

		// Token: 0x0400080C RID: 2060
		public IRemoteDesktopClientEvents_OnConnectedEventHandler m_OnConnectedDelegate;

		// Token: 0x0400080D RID: 2061
		public IRemoteDesktopClientEvents_OnLoginCompletedEventHandler m_OnLoginCompletedDelegate;

		// Token: 0x0400080E RID: 2062
		public IRemoteDesktopClientEvents_OnDisconnectedEventHandler m_OnDisconnectedDelegate;

		// Token: 0x0400080F RID: 2063
		public IRemoteDesktopClientEvents_OnStatusChangedEventHandler m_OnStatusChangedDelegate;

		// Token: 0x04000810 RID: 2064
		public IRemoteDesktopClientEvents_OnAutoReconnectingEventHandler m_OnAutoReconnectingDelegate;

		// Token: 0x04000811 RID: 2065
		public IRemoteDesktopClientEvents_OnAutoReconnectedEventHandler m_OnAutoReconnectedDelegate;

		// Token: 0x04000812 RID: 2066
		public IRemoteDesktopClientEvents_OnDialogDisplayingEventHandler m_OnDialogDisplayingDelegate;

		// Token: 0x04000813 RID: 2067
		public IRemoteDesktopClientEvents_OnDialogDismissedEventHandler m_OnDialogDismissedDelegate;

		// Token: 0x04000814 RID: 2068
		public IRemoteDesktopClientEvents_OnNetworkStatusChangedEventHandler m_OnNetworkStatusChangedDelegate;

		// Token: 0x04000815 RID: 2069
		public IRemoteDesktopClientEvents_OnAdminMessageReceivedEventHandler m_OnAdminMessageReceivedDelegate;

		// Token: 0x04000816 RID: 2070
		public IRemoteDesktopClientEvents_OnKeyCombinationPressedEventHandler m_OnKeyCombinationPressedDelegate;

		// Token: 0x04000817 RID: 2071
		public IRemoteDesktopClientEvents_OnRemoteDesktopSizeChangedEventHandler m_OnRemoteDesktopSizeChangedDelegate;

		// Token: 0x04000818 RID: 2072
		public IRemoteDesktopClientEvents_OnTouchPointerCursorMovedEventHandler m_OnTouchPointerCursorMovedDelegate;

		// Token: 0x04000819 RID: 2073
		public int m_dwCookie;
	}
}
