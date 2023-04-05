﻿using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[ComVisible(false)]
	[TypeLibType(16)]
	[ComEventInterface(typeof(IMsTscAxEvents), typeof(IMsTscAxEvents_EventProvider))]
	public interface IMsTscAxEvents_Event
	{
		event IMsTscAxEvents_OnConnectingEventHandler OnConnecting;

		event IMsTscAxEvents_OnConnectedEventHandler OnConnected;

		event IMsTscAxEvents_OnLoginCompleteEventHandler OnLoginComplete;

		event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		event IMsTscAxEvents_OnEnterFullScreenModeEventHandler OnEnterFullScreenMode;

		event IMsTscAxEvents_OnLeaveFullScreenModeEventHandler OnLeaveFullScreenMode;

		event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		event IMsTscAxEvents_OnRequestGoFullScreenEventHandler OnRequestGoFullScreen;

		event IMsTscAxEvents_OnRequestLeaveFullScreenEventHandler OnRequestLeaveFullScreen;

		event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		event IMsTscAxEvents_OnIdleTimeoutNotificationEventHandler OnIdleTimeoutNotification;

		event IMsTscAxEvents_OnRequestContainerMinimizeEventHandler OnRequestContainerMinimize;

		event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		event IMsTscAxEvents_OnAuthenticationWarningDisplayedEventHandler OnAuthenticationWarningDisplayed;

		event IMsTscAxEvents_OnAuthenticationWarningDismissedEventHandler OnAuthenticationWarningDismissed;

		event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		event IMsTscAxEvents_OnConnectionBarPullDownEventHandler OnConnectionBarPullDown;

		event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		event IMsTscAxEvents_OnDevicesButtonPressedEventHandler OnDevicesButtonPressed;

		event IMsTscAxEvents_OnAutoReconnectedEventHandler OnAutoReconnected;

		event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;
	}
}