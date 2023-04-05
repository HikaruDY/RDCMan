using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[TypeLibType(TypeLibTypeFlags.FHidden)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public sealed class IMsTscAxEvents_SinkHelper : IMsTscAxEvents
	{
		public void OnConnecting()
		{
			if (this.m_OnConnectingDelegate != null)
			{
				this.m_OnConnectingDelegate();
				return;
			}
		}

		public void OnConnected()
		{
			if (this.m_OnConnectedDelegate != null)
			{
				this.m_OnConnectedDelegate();
				return;
			}
		}

		public void OnLoginComplete()
		{
			if (this.m_OnLoginCompleteDelegate != null)
			{
				this.m_OnLoginCompleteDelegate();
				return;
			}
		}

		public void OnDisconnected(int A_1)
		{
			if (this.m_OnDisconnectedDelegate != null)
			{
				this.m_OnDisconnectedDelegate(A_1);
				return;
			}
		}

		public void OnEnterFullScreenMode()
		{
			if (this.m_OnEnterFullScreenModeDelegate != null)
			{
				this.m_OnEnterFullScreenModeDelegate();
				return;
			}
		}

		public void OnLeaveFullScreenMode()
		{
			if (this.m_OnLeaveFullScreenModeDelegate != null)
			{
				this.m_OnLeaveFullScreenModeDelegate();
				return;
			}
		}

		public void OnChannelReceivedData(string A_1, string A_2)
		{
			if (this.m_OnChannelReceivedDataDelegate != null)
			{
				this.m_OnChannelReceivedDataDelegate(A_1, A_2);
				return;
			}
		}

		public void OnRequestGoFullScreen()
		{
			if (this.m_OnRequestGoFullScreenDelegate != null)
			{
				this.m_OnRequestGoFullScreenDelegate();
				return;
			}
		}

		public void OnRequestLeaveFullScreen()
		{
			if (this.m_OnRequestLeaveFullScreenDelegate != null)
			{
				this.m_OnRequestLeaveFullScreenDelegate();
				return;
			}
		}

		public void OnFatalError(int A_1)
		{
			if (this.m_OnFatalErrorDelegate != null)
			{
				this.m_OnFatalErrorDelegate(A_1);
				return;
			}
		}

		public void OnWarning(int A_1)
		{
			if (this.m_OnWarningDelegate != null)
			{
				this.m_OnWarningDelegate(A_1);
				return;
			}
		}

		public void OnRemoteDesktopSizeChange(int A_1, int A_2)
		{
			if (this.m_OnRemoteDesktopSizeChangeDelegate != null)
			{
				this.m_OnRemoteDesktopSizeChangeDelegate(A_1, A_2);
				return;
			}
		}

		public void OnIdleTimeoutNotification()
		{
			if (this.m_OnIdleTimeoutNotificationDelegate != null)
			{
				this.m_OnIdleTimeoutNotificationDelegate();
				return;
			}
		}

		public void OnRequestContainerMinimize()
		{
			if (this.m_OnRequestContainerMinimizeDelegate != null)
			{
				this.m_OnRequestContainerMinimizeDelegate();
				return;
			}
		}

		public void OnConfirmClose(ref bool A_1)
		{
			if (this.m_OnConfirmCloseDelegate != null)
			{
				this.m_OnConfirmCloseDelegate(out A_1);
				return;
			}
		}

		public void OnReceivedTSPublicKey(string A_1, ref bool A_2)
		{
			if (this.m_OnReceivedTSPublicKeyDelegate != null)
			{
				this.m_OnReceivedTSPublicKeyDelegate(A_1, out A_2);
				return;
			}
		}

		public void OnAutoReconnecting(int A_1, int A_2, ref AutoReconnectContinueState A_3)
		{
			if (this.m_OnAutoReconnectingDelegate != null)
			{
				this.m_OnAutoReconnectingDelegate(A_1, A_2, out A_3);
				return;
			}
		}

		public void OnAuthenticationWarningDisplayed()
		{
			if (this.m_OnAuthenticationWarningDisplayedDelegate != null)
			{
				this.m_OnAuthenticationWarningDisplayedDelegate();
				return;
			}
		}

		public void OnAuthenticationWarningDismissed()
		{
			if (this.m_OnAuthenticationWarningDismissedDelegate != null)
			{
				this.m_OnAuthenticationWarningDismissedDelegate();
				return;
			}
		}

		public void OnRemoteProgramResult(string A_1, RemoteProgramResult A_2, bool A_3)
		{
			if (this.m_OnRemoteProgramResultDelegate != null)
			{
				this.m_OnRemoteProgramResultDelegate(A_1, A_2, A_3);
				return;
			}
		}

		public void OnRemoteProgramDisplayed(bool A_1, uint A_2)
		{
			if (this.m_OnRemoteProgramDisplayedDelegate != null)
			{
				this.m_OnRemoteProgramDisplayedDelegate(A_1, A_2);
				return;
			}
		}

		public void OnRemoteWindowDisplayed(bool A_1, ref _RemotableHandle A_2, RemoteWindowDisplayedAttribute A_3)
		{
			if (this.m_OnRemoteWindowDisplayedDelegate != null)
			{
				this.m_OnRemoteWindowDisplayedDelegate(A_1, ref A_2, A_3);
				return;
			}
		}

		public void OnLogonError(int A_1)
		{
			if (this.m_OnLogonErrorDelegate != null)
			{
				this.m_OnLogonErrorDelegate(A_1);
				return;
			}
		}

		public void OnFocusReleased(int A_1)
		{
			if (this.m_OnFocusReleasedDelegate != null)
			{
				this.m_OnFocusReleasedDelegate(A_1);
				return;
			}
		}

		public void OnUserNameAcquired(string A_1)
		{
			if (this.m_OnUserNameAcquiredDelegate != null)
			{
				this.m_OnUserNameAcquiredDelegate(A_1);
				return;
			}
		}

		public void OnMouseInputModeChanged(bool A_1)
		{
			if (this.m_OnMouseInputModeChangedDelegate != null)
			{
				this.m_OnMouseInputModeChangedDelegate(A_1);
				return;
			}
		}

		public void OnServiceMessageReceived(string A_1)
		{
			if (this.m_OnServiceMessageReceivedDelegate != null)
			{
				this.m_OnServiceMessageReceivedDelegate(A_1);
				return;
			}
		}

		public void OnConnectionBarPullDown()
		{
			if (this.m_OnConnectionBarPullDownDelegate != null)
			{
				this.m_OnConnectionBarPullDownDelegate();
				return;
			}
		}

		public void OnNetworkStatusChanged(uint A_1, int A_2, int A_3)
		{
			if (this.m_OnNetworkStatusChangedDelegate != null)
			{
				this.m_OnNetworkStatusChangedDelegate(A_1, A_2, A_3);
				return;
			}
		}

		public void OnDevicesButtonPressed()
		{
			if (this.m_OnDevicesButtonPressedDelegate != null)
			{
				this.m_OnDevicesButtonPressedDelegate();
				return;
			}
		}

		public void OnAutoReconnected()
		{
			if (this.m_OnAutoReconnectedDelegate != null)
			{
				this.m_OnAutoReconnectedDelegate();
				return;
			}
		}

		public void OnAutoReconnecting2(int A_1, bool A_2, int A_3, int A_4)
		{
			if (this.m_OnAutoReconnecting2Delegate != null)
			{
				this.m_OnAutoReconnecting2Delegate(A_1, A_2, A_3, A_4);
				return;
			}
		}

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

		public IMsTscAxEvents_OnConnectingEventHandler m_OnConnectingDelegate;

		public IMsTscAxEvents_OnConnectedEventHandler m_OnConnectedDelegate;

		public IMsTscAxEvents_OnLoginCompleteEventHandler m_OnLoginCompleteDelegate;

		public IMsTscAxEvents_OnDisconnectedEventHandler m_OnDisconnectedDelegate;

		public IMsTscAxEvents_OnEnterFullScreenModeEventHandler m_OnEnterFullScreenModeDelegate;

		public IMsTscAxEvents_OnLeaveFullScreenModeEventHandler m_OnLeaveFullScreenModeDelegate;

		public IMsTscAxEvents_OnChannelReceivedDataEventHandler m_OnChannelReceivedDataDelegate;

		public IMsTscAxEvents_OnRequestGoFullScreenEventHandler m_OnRequestGoFullScreenDelegate;

		public IMsTscAxEvents_OnRequestLeaveFullScreenEventHandler m_OnRequestLeaveFullScreenDelegate;

		public IMsTscAxEvents_OnFatalErrorEventHandler m_OnFatalErrorDelegate;

		public IMsTscAxEvents_OnWarningEventHandler m_OnWarningDelegate;

		public IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler m_OnRemoteDesktopSizeChangeDelegate;

		public IMsTscAxEvents_OnIdleTimeoutNotificationEventHandler m_OnIdleTimeoutNotificationDelegate;

		public IMsTscAxEvents_OnRequestContainerMinimizeEventHandler m_OnRequestContainerMinimizeDelegate;

		public IMsTscAxEvents_OnConfirmCloseEventHandler m_OnConfirmCloseDelegate;

		public IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler m_OnReceivedTSPublicKeyDelegate;

		public IMsTscAxEvents_OnAutoReconnectingEventHandler m_OnAutoReconnectingDelegate;

		public IMsTscAxEvents_OnAuthenticationWarningDisplayedEventHandler m_OnAuthenticationWarningDisplayedDelegate;

		public IMsTscAxEvents_OnAuthenticationWarningDismissedEventHandler m_OnAuthenticationWarningDismissedDelegate;

		public IMsTscAxEvents_OnRemoteProgramResultEventHandler m_OnRemoteProgramResultDelegate;

		public IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler m_OnRemoteProgramDisplayedDelegate;

		public IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler m_OnRemoteWindowDisplayedDelegate;

		public IMsTscAxEvents_OnLogonErrorEventHandler m_OnLogonErrorDelegate;

		public IMsTscAxEvents_OnFocusReleasedEventHandler m_OnFocusReleasedDelegate;

		public IMsTscAxEvents_OnUserNameAcquiredEventHandler m_OnUserNameAcquiredDelegate;

		public IMsTscAxEvents_OnMouseInputModeChangedEventHandler m_OnMouseInputModeChangedDelegate;

		public IMsTscAxEvents_OnServiceMessageReceivedEventHandler m_OnServiceMessageReceivedDelegate;

		public IMsTscAxEvents_OnConnectionBarPullDownEventHandler m_OnConnectionBarPullDownDelegate;

		public IMsTscAxEvents_OnNetworkStatusChangedEventHandler m_OnNetworkStatusChangedDelegate;

		public IMsTscAxEvents_OnDevicesButtonPressedEventHandler m_OnDevicesButtonPressedDelegate;

		public IMsTscAxEvents_OnAutoReconnectedEventHandler m_OnAutoReconnectedDelegate;

		public IMsTscAxEvents_OnAutoReconnecting2EventHandler m_OnAutoReconnecting2Delegate;

		public int m_dwCookie;
	}
}
