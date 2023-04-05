using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x02000216 RID: 534
	[TypeLibType(TypeLibTypeFlags.FHidden)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public sealed class IMsTscAxEvents_SinkHelper : IMsTscAxEvents
	{
		// Token: 0x06005516 RID: 21782 RVA: 0x00057FF0 File Offset: 0x000561F0
		public void OnConnecting()
		{
			if (this.m_OnConnectingDelegate != null)
			{
				this.m_OnConnectingDelegate();
				return;
			}
		}

		// Token: 0x06005517 RID: 21783 RVA: 0x0005800C File Offset: 0x0005620C
		public void OnConnected()
		{
			if (this.m_OnConnectedDelegate != null)
			{
				this.m_OnConnectedDelegate();
				return;
			}
		}

		// Token: 0x06005518 RID: 21784 RVA: 0x00058028 File Offset: 0x00056228
		public void OnLoginComplete()
		{
			if (this.m_OnLoginCompleteDelegate != null)
			{
				this.m_OnLoginCompleteDelegate();
				return;
			}
		}

		// Token: 0x06005519 RID: 21785 RVA: 0x00058044 File Offset: 0x00056244
		public void OnDisconnected(int A_1)
		{
			if (this.m_OnDisconnectedDelegate != null)
			{
				this.m_OnDisconnectedDelegate(A_1);
				return;
			}
		}

		// Token: 0x0600551A RID: 21786 RVA: 0x00058060 File Offset: 0x00056260
		public void OnEnterFullScreenMode()
		{
			if (this.m_OnEnterFullScreenModeDelegate != null)
			{
				this.m_OnEnterFullScreenModeDelegate();
				return;
			}
		}

		// Token: 0x0600551B RID: 21787 RVA: 0x0005807C File Offset: 0x0005627C
		public void OnLeaveFullScreenMode()
		{
			if (this.m_OnLeaveFullScreenModeDelegate != null)
			{
				this.m_OnLeaveFullScreenModeDelegate();
				return;
			}
		}

		// Token: 0x0600551C RID: 21788 RVA: 0x00058098 File Offset: 0x00056298
		public void OnChannelReceivedData(string A_1, string A_2)
		{
			if (this.m_OnChannelReceivedDataDelegate != null)
			{
				this.m_OnChannelReceivedDataDelegate(A_1, A_2);
				return;
			}
		}

		// Token: 0x0600551D RID: 21789 RVA: 0x000580B4 File Offset: 0x000562B4
		public void OnRequestGoFullScreen()
		{
			if (this.m_OnRequestGoFullScreenDelegate != null)
			{
				this.m_OnRequestGoFullScreenDelegate();
				return;
			}
		}

		// Token: 0x0600551E RID: 21790 RVA: 0x000580D0 File Offset: 0x000562D0
		public void OnRequestLeaveFullScreen()
		{
			if (this.m_OnRequestLeaveFullScreenDelegate != null)
			{
				this.m_OnRequestLeaveFullScreenDelegate();
				return;
			}
		}

		// Token: 0x0600551F RID: 21791 RVA: 0x000580EC File Offset: 0x000562EC
		public void OnFatalError(int A_1)
		{
			if (this.m_OnFatalErrorDelegate != null)
			{
				this.m_OnFatalErrorDelegate(A_1);
				return;
			}
		}

		// Token: 0x06005520 RID: 21792 RVA: 0x00058108 File Offset: 0x00056308
		public void OnWarning(int A_1)
		{
			if (this.m_OnWarningDelegate != null)
			{
				this.m_OnWarningDelegate(A_1);
				return;
			}
		}

		// Token: 0x06005521 RID: 21793 RVA: 0x00058124 File Offset: 0x00056324
		public void OnRemoteDesktopSizeChange(int A_1, int A_2)
		{
			if (this.m_OnRemoteDesktopSizeChangeDelegate != null)
			{
				this.m_OnRemoteDesktopSizeChangeDelegate(A_1, A_2);
				return;
			}
		}

		// Token: 0x06005522 RID: 21794 RVA: 0x00058140 File Offset: 0x00056340
		public void OnIdleTimeoutNotification()
		{
			if (this.m_OnIdleTimeoutNotificationDelegate != null)
			{
				this.m_OnIdleTimeoutNotificationDelegate();
				return;
			}
		}

		// Token: 0x06005523 RID: 21795 RVA: 0x0005815C File Offset: 0x0005635C
		public void OnRequestContainerMinimize()
		{
			if (this.m_OnRequestContainerMinimizeDelegate != null)
			{
				this.m_OnRequestContainerMinimizeDelegate();
				return;
			}
		}

		// Token: 0x06005524 RID: 21796 RVA: 0x00058178 File Offset: 0x00056378
		public void OnConfirmClose(ref bool A_1)
		{
			if (this.m_OnConfirmCloseDelegate != null)
			{
				this.m_OnConfirmCloseDelegate(out A_1);
				return;
			}
		}

		// Token: 0x06005525 RID: 21797 RVA: 0x00058194 File Offset: 0x00056394
		public void OnReceivedTSPublicKey(string A_1, ref bool A_2)
		{
			if (this.m_OnReceivedTSPublicKeyDelegate != null)
			{
				this.m_OnReceivedTSPublicKeyDelegate(A_1, out A_2);
				return;
			}
		}

		// Token: 0x06005526 RID: 21798 RVA: 0x000581B0 File Offset: 0x000563B0
		public void OnAutoReconnecting(int A_1, int A_2, ref AutoReconnectContinueState A_3)
		{
			if (this.m_OnAutoReconnectingDelegate != null)
			{
				this.m_OnAutoReconnectingDelegate(A_1, A_2, out A_3);
				return;
			}
		}

		// Token: 0x06005527 RID: 21799 RVA: 0x000581CC File Offset: 0x000563CC
		public void OnAuthenticationWarningDisplayed()
		{
			if (this.m_OnAuthenticationWarningDisplayedDelegate != null)
			{
				this.m_OnAuthenticationWarningDisplayedDelegate();
				return;
			}
		}

		// Token: 0x06005528 RID: 21800 RVA: 0x000581E8 File Offset: 0x000563E8
		public void OnAuthenticationWarningDismissed()
		{
			if (this.m_OnAuthenticationWarningDismissedDelegate != null)
			{
				this.m_OnAuthenticationWarningDismissedDelegate();
				return;
			}
		}

		// Token: 0x06005529 RID: 21801 RVA: 0x00058204 File Offset: 0x00056404
		public void OnRemoteProgramResult(string A_1, RemoteProgramResult A_2, bool A_3)
		{
			if (this.m_OnRemoteProgramResultDelegate != null)
			{
				this.m_OnRemoteProgramResultDelegate(A_1, A_2, A_3);
				return;
			}
		}

		// Token: 0x0600552A RID: 21802 RVA: 0x00058220 File Offset: 0x00056420
		public void OnRemoteProgramDisplayed(bool A_1, uint A_2)
		{
			if (this.m_OnRemoteProgramDisplayedDelegate != null)
			{
				this.m_OnRemoteProgramDisplayedDelegate(A_1, A_2);
				return;
			}
		}

		// Token: 0x0600552B RID: 21803 RVA: 0x0005823C File Offset: 0x0005643C
		public void OnRemoteWindowDisplayed(bool A_1, ref _RemotableHandle A_2, RemoteWindowDisplayedAttribute A_3)
		{
			if (this.m_OnRemoteWindowDisplayedDelegate != null)
			{
				this.m_OnRemoteWindowDisplayedDelegate(A_1, ref A_2, A_3);
				return;
			}
		}

		// Token: 0x0600552C RID: 21804 RVA: 0x00058258 File Offset: 0x00056458
		public void OnLogonError(int A_1)
		{
			if (this.m_OnLogonErrorDelegate != null)
			{
				this.m_OnLogonErrorDelegate(A_1);
				return;
			}
		}

		// Token: 0x0600552D RID: 21805 RVA: 0x00058274 File Offset: 0x00056474
		public void OnFocusReleased(int A_1)
		{
			if (this.m_OnFocusReleasedDelegate != null)
			{
				this.m_OnFocusReleasedDelegate(A_1);
				return;
			}
		}

		// Token: 0x0600552E RID: 21806 RVA: 0x00058290 File Offset: 0x00056490
		public void OnUserNameAcquired(string A_1)
		{
			if (this.m_OnUserNameAcquiredDelegate != null)
			{
				this.m_OnUserNameAcquiredDelegate(A_1);
				return;
			}
		}

		// Token: 0x0600552F RID: 21807 RVA: 0x000582AC File Offset: 0x000564AC
		public void OnMouseInputModeChanged(bool A_1)
		{
			if (this.m_OnMouseInputModeChangedDelegate != null)
			{
				this.m_OnMouseInputModeChangedDelegate(A_1);
				return;
			}
		}

		// Token: 0x06005530 RID: 21808 RVA: 0x000582C8 File Offset: 0x000564C8
		public void OnServiceMessageReceived(string A_1)
		{
			if (this.m_OnServiceMessageReceivedDelegate != null)
			{
				this.m_OnServiceMessageReceivedDelegate(A_1);
				return;
			}
		}

		// Token: 0x06005531 RID: 21809 RVA: 0x000582E4 File Offset: 0x000564E4
		public void OnConnectionBarPullDown()
		{
			if (this.m_OnConnectionBarPullDownDelegate != null)
			{
				this.m_OnConnectionBarPullDownDelegate();
				return;
			}
		}

		// Token: 0x06005532 RID: 21810 RVA: 0x00058300 File Offset: 0x00056500
		public void OnNetworkStatusChanged(uint A_1, int A_2, int A_3)
		{
			if (this.m_OnNetworkStatusChangedDelegate != null)
			{
				this.m_OnNetworkStatusChangedDelegate(A_1, A_2, A_3);
				return;
			}
		}

		// Token: 0x06005533 RID: 21811 RVA: 0x0005831C File Offset: 0x0005651C
		public void OnDevicesButtonPressed()
		{
			if (this.m_OnDevicesButtonPressedDelegate != null)
			{
				this.m_OnDevicesButtonPressedDelegate();
				return;
			}
		}

		// Token: 0x06005534 RID: 21812 RVA: 0x00058338 File Offset: 0x00056538
		public void OnAutoReconnected()
		{
			if (this.m_OnAutoReconnectedDelegate != null)
			{
				this.m_OnAutoReconnectedDelegate();
				return;
			}
		}

		// Token: 0x06005535 RID: 21813 RVA: 0x00058354 File Offset: 0x00056554
		public void OnAutoReconnecting2(int A_1, bool A_2, int A_3, int A_4)
		{
			if (this.m_OnAutoReconnecting2Delegate != null)
			{
				this.m_OnAutoReconnecting2Delegate(A_1, A_2, A_3, A_4);
				return;
			}
		}

		// Token: 0x06005536 RID: 21814 RVA: 0x00058374 File Offset: 0x00056574
		internal IMsTscAxEvents_SinkHelper()
		{
			this.m_dwCookie = 0;
			this.m_OnConnectingDelegate = null;
			this.m_OnConnectedDelegate = null;
			this.m_OnLoginCompleteDelegate = null;
			this.m_OnDisconnectedDelegate = null;
			this.m_OnEnterFullScreenModeDelegate = null;
			this.m_OnLeaveFullScreenModeDelegate = null;
			this.m_OnChannelReceivedDataDelegate = null;
			this.m_OnRequestGoFullScreenDelegate = null;
			this.m_OnRequestLeaveFullScreenDelegate = null;
			this.m_OnFatalErrorDelegate = null;
			this.m_OnWarningDelegate = null;
			this.m_OnRemoteDesktopSizeChangeDelegate = null;
			this.m_OnIdleTimeoutNotificationDelegate = null;
			this.m_OnRequestContainerMinimizeDelegate = null;
			this.m_OnConfirmCloseDelegate = null;
			this.m_OnReceivedTSPublicKeyDelegate = null;
			this.m_OnAutoReconnectingDelegate = null;
			this.m_OnAuthenticationWarningDisplayedDelegate = null;
			this.m_OnAuthenticationWarningDismissedDelegate = null;
			this.m_OnRemoteProgramResultDelegate = null;
			this.m_OnRemoteProgramDisplayedDelegate = null;
			this.m_OnRemoteWindowDisplayedDelegate = null;
			this.m_OnLogonErrorDelegate = null;
			this.m_OnFocusReleasedDelegate = null;
			this.m_OnUserNameAcquiredDelegate = null;
			this.m_OnMouseInputModeChangedDelegate = null;
			this.m_OnServiceMessageReceivedDelegate = null;
			this.m_OnConnectionBarPullDownDelegate = null;
			this.m_OnNetworkStatusChangedDelegate = null;
			this.m_OnDevicesButtonPressedDelegate = null;
			this.m_OnAutoReconnectedDelegate = null;
			this.m_OnAutoReconnecting2Delegate = null;
		}

		// Token: 0x040007E7 RID: 2023
		public IMsTscAxEvents_OnConnectingEventHandler m_OnConnectingDelegate;

		// Token: 0x040007E8 RID: 2024
		public IMsTscAxEvents_OnConnectedEventHandler m_OnConnectedDelegate;

		// Token: 0x040007E9 RID: 2025
		public IMsTscAxEvents_OnLoginCompleteEventHandler m_OnLoginCompleteDelegate;

		// Token: 0x040007EA RID: 2026
		public IMsTscAxEvents_OnDisconnectedEventHandler m_OnDisconnectedDelegate;

		// Token: 0x040007EB RID: 2027
		public IMsTscAxEvents_OnEnterFullScreenModeEventHandler m_OnEnterFullScreenModeDelegate;

		// Token: 0x040007EC RID: 2028
		public IMsTscAxEvents_OnLeaveFullScreenModeEventHandler m_OnLeaveFullScreenModeDelegate;

		// Token: 0x040007ED RID: 2029
		public IMsTscAxEvents_OnChannelReceivedDataEventHandler m_OnChannelReceivedDataDelegate;

		// Token: 0x040007EE RID: 2030
		public IMsTscAxEvents_OnRequestGoFullScreenEventHandler m_OnRequestGoFullScreenDelegate;

		// Token: 0x040007EF RID: 2031
		public IMsTscAxEvents_OnRequestLeaveFullScreenEventHandler m_OnRequestLeaveFullScreenDelegate;

		// Token: 0x040007F0 RID: 2032
		public IMsTscAxEvents_OnFatalErrorEventHandler m_OnFatalErrorDelegate;

		// Token: 0x040007F1 RID: 2033
		public IMsTscAxEvents_OnWarningEventHandler m_OnWarningDelegate;

		// Token: 0x040007F2 RID: 2034
		public IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler m_OnRemoteDesktopSizeChangeDelegate;

		// Token: 0x040007F3 RID: 2035
		public IMsTscAxEvents_OnIdleTimeoutNotificationEventHandler m_OnIdleTimeoutNotificationDelegate;

		// Token: 0x040007F4 RID: 2036
		public IMsTscAxEvents_OnRequestContainerMinimizeEventHandler m_OnRequestContainerMinimizeDelegate;

		// Token: 0x040007F5 RID: 2037
		public IMsTscAxEvents_OnConfirmCloseEventHandler m_OnConfirmCloseDelegate;

		// Token: 0x040007F6 RID: 2038
		public IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler m_OnReceivedTSPublicKeyDelegate;

		// Token: 0x040007F7 RID: 2039
		public IMsTscAxEvents_OnAutoReconnectingEventHandler m_OnAutoReconnectingDelegate;

		// Token: 0x040007F8 RID: 2040
		public IMsTscAxEvents_OnAuthenticationWarningDisplayedEventHandler m_OnAuthenticationWarningDisplayedDelegate;

		// Token: 0x040007F9 RID: 2041
		public IMsTscAxEvents_OnAuthenticationWarningDismissedEventHandler m_OnAuthenticationWarningDismissedDelegate;

		// Token: 0x040007FA RID: 2042
		public IMsTscAxEvents_OnRemoteProgramResultEventHandler m_OnRemoteProgramResultDelegate;

		// Token: 0x040007FB RID: 2043
		public IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler m_OnRemoteProgramDisplayedDelegate;

		// Token: 0x040007FC RID: 2044
		public IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler m_OnRemoteWindowDisplayedDelegate;

		// Token: 0x040007FD RID: 2045
		public IMsTscAxEvents_OnLogonErrorEventHandler m_OnLogonErrorDelegate;

		// Token: 0x040007FE RID: 2046
		public IMsTscAxEvents_OnFocusReleasedEventHandler m_OnFocusReleasedDelegate;

		// Token: 0x040007FF RID: 2047
		public IMsTscAxEvents_OnUserNameAcquiredEventHandler m_OnUserNameAcquiredDelegate;

		// Token: 0x04000800 RID: 2048
		public IMsTscAxEvents_OnMouseInputModeChangedEventHandler m_OnMouseInputModeChangedDelegate;

		// Token: 0x04000801 RID: 2049
		public IMsTscAxEvents_OnServiceMessageReceivedEventHandler m_OnServiceMessageReceivedDelegate;

		// Token: 0x04000802 RID: 2050
		public IMsTscAxEvents_OnConnectionBarPullDownEventHandler m_OnConnectionBarPullDownDelegate;

		// Token: 0x04000803 RID: 2051
		public IMsTscAxEvents_OnNetworkStatusChangedEventHandler m_OnNetworkStatusChangedDelegate;

		// Token: 0x04000804 RID: 2052
		public IMsTscAxEvents_OnDevicesButtonPressedEventHandler m_OnDevicesButtonPressedDelegate;

		// Token: 0x04000805 RID: 2053
		public IMsTscAxEvents_OnAutoReconnectedEventHandler m_OnAutoReconnectedDelegate;

		// Token: 0x04000806 RID: 2054
		public IMsTscAxEvents_OnAutoReconnecting2EventHandler m_OnAutoReconnecting2Delegate;

		// Token: 0x04000807 RID: 2055
		public int m_dwCookie;
	}
}
