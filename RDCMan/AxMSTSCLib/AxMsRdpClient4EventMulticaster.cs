using System;
using System.Runtime.InteropServices;
using MSTSCLib;

namespace AxMSTSCLib
{
	// Token: 0x02000129 RID: 297
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class AxMsRdpClient4EventMulticaster : IMsTscAxEvents
	{
		// Token: 0x06000F7C RID: 3964 RVA: 0x00036F54 File Offset: 0x00035154
		public AxMsRdpClient4EventMulticaster(AxMsRdpClient4 parent)
		{
			this.parent = parent;
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x00036F64 File Offset: 0x00035164
		public virtual void OnConnecting()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnConnecting(this.parent, e);
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x00036F90 File Offset: 0x00035190
		public virtual void OnConnected()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnConnected(this.parent, e);
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x00036FBC File Offset: 0x000351BC
		public virtual void OnLoginComplete()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnLoginComplete(this.parent, e);
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x00036FE8 File Offset: 0x000351E8
		public virtual void OnDisconnected(int discReason)
		{
			IMsTscAxEvents_OnDisconnectedEvent e = new IMsTscAxEvents_OnDisconnectedEvent(discReason);
			this.parent.RaiseOnOnDisconnected(this.parent, e);
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x00037014 File Offset: 0x00035214
		public virtual void OnEnterFullScreenMode()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnEnterFullScreenMode(this.parent, e);
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x00037040 File Offset: 0x00035240
		public virtual void OnLeaveFullScreenMode()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnLeaveFullScreenMode(this.parent, e);
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x0003706C File Offset: 0x0003526C
		public virtual void OnChannelReceivedData(string chanName, string data)
		{
			IMsTscAxEvents_OnChannelReceivedDataEvent e = new IMsTscAxEvents_OnChannelReceivedDataEvent(chanName, data);
			this.parent.RaiseOnOnChannelReceivedData(this.parent, e);
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x00037098 File Offset: 0x00035298
		public virtual void OnRequestGoFullScreen()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnRequestGoFullScreen(this.parent, e);
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x000370C4 File Offset: 0x000352C4
		public virtual void OnRequestLeaveFullScreen()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnRequestLeaveFullScreen(this.parent, e);
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x000370F0 File Offset: 0x000352F0
		public virtual void OnFatalError(int errorCode)
		{
			IMsTscAxEvents_OnFatalErrorEvent e = new IMsTscAxEvents_OnFatalErrorEvent(errorCode);
			this.parent.RaiseOnOnFatalError(this.parent, e);
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x0003711C File Offset: 0x0003531C
		public virtual void OnWarning(int warningCode)
		{
			IMsTscAxEvents_OnWarningEvent e = new IMsTscAxEvents_OnWarningEvent(warningCode);
			this.parent.RaiseOnOnWarning(this.parent, e);
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x00037148 File Offset: 0x00035348
		public virtual void OnRemoteDesktopSizeChange(int width, int height)
		{
			IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e = new IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent(width, height);
			this.parent.RaiseOnOnRemoteDesktopSizeChange(this.parent, e);
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x00037174 File Offset: 0x00035374
		public virtual void OnIdleTimeoutNotification()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnIdleTimeoutNotification(this.parent, e);
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x000371A0 File Offset: 0x000353A0
		public virtual void OnRequestContainerMinimize()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnRequestContainerMinimize(this.parent, e);
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x000371CC File Offset: 0x000353CC
		public virtual void OnConfirmClose(out bool pfAllowClose)
		{
			IMsTscAxEvents_OnConfirmCloseEvent msTscAxEvents_OnConfirmCloseEvent = new IMsTscAxEvents_OnConfirmCloseEvent();
			this.parent.RaiseOnOnConfirmClose(this.parent, msTscAxEvents_OnConfirmCloseEvent);
			pfAllowClose = msTscAxEvents_OnConfirmCloseEvent.pfAllowClose;
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x00037200 File Offset: 0x00035400
		public virtual void OnReceivedTSPublicKey(string publicKey, out bool pfContinueLogon)
		{
			IMsTscAxEvents_OnReceivedTSPublicKeyEvent msTscAxEvents_OnReceivedTSPublicKeyEvent = new IMsTscAxEvents_OnReceivedTSPublicKeyEvent(publicKey);
			this.parent.RaiseOnOnReceivedTSPublicKey(this.parent, msTscAxEvents_OnReceivedTSPublicKeyEvent);
			pfContinueLogon = msTscAxEvents_OnReceivedTSPublicKeyEvent.pfContinueLogon;
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x00037234 File Offset: 0x00035434
		public virtual void OnAutoReconnecting(int disconnectReason, int attemptCount, out AutoReconnectContinueState pArcContinueStatus)
		{
			IMsTscAxEvents_OnAutoReconnectingEvent msTscAxEvents_OnAutoReconnectingEvent = new IMsTscAxEvents_OnAutoReconnectingEvent(disconnectReason, attemptCount);
			this.parent.RaiseOnOnAutoReconnecting(this.parent, msTscAxEvents_OnAutoReconnectingEvent);
			pArcContinueStatus = msTscAxEvents_OnAutoReconnectingEvent.pArcContinueStatus;
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x00037268 File Offset: 0x00035468
		public virtual void OnAuthenticationWarningDisplayed()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnAuthenticationWarningDisplayed(this.parent, e);
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x00037294 File Offset: 0x00035494
		public virtual void OnAuthenticationWarningDismissed()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnAuthenticationWarningDismissed(this.parent, e);
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x000372C0 File Offset: 0x000354C0
		public virtual void OnRemoteProgramResult(string bstrRemoteProgram, RemoteProgramResult lError, bool vbIsExecutable)
		{
			IMsTscAxEvents_OnRemoteProgramResultEvent e = new IMsTscAxEvents_OnRemoteProgramResultEvent(bstrRemoteProgram, lError, vbIsExecutable);
			this.parent.RaiseOnOnRemoteProgramResult(this.parent, e);
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x000372EC File Offset: 0x000354EC
		public virtual void OnRemoteProgramDisplayed(bool vbDisplayed, uint uDisplayInformation)
		{
			IMsTscAxEvents_OnRemoteProgramDisplayedEvent e = new IMsTscAxEvents_OnRemoteProgramDisplayedEvent(vbDisplayed, uDisplayInformation);
			this.parent.RaiseOnOnRemoteProgramDisplayed(this.parent, e);
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x00037318 File Offset: 0x00035518
		public virtual void OnRemoteWindowDisplayed(bool vbDisplayed, ref _RemotableHandle hwnd, RemoteWindowDisplayedAttribute windowAttribute)
		{
			IMsTscAxEvents_OnRemoteWindowDisplayedEvent msTscAxEvents_OnRemoteWindowDisplayedEvent = new IMsTscAxEvents_OnRemoteWindowDisplayedEvent(vbDisplayed, hwnd, windowAttribute);
			this.parent.RaiseOnOnRemoteWindowDisplayed(this.parent, msTscAxEvents_OnRemoteWindowDisplayedEvent);
			hwnd = msTscAxEvents_OnRemoteWindowDisplayedEvent.hwnd;
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x00037358 File Offset: 0x00035558
		public virtual void OnLogonError(int lError)
		{
			IMsTscAxEvents_OnLogonErrorEvent e = new IMsTscAxEvents_OnLogonErrorEvent(lError);
			this.parent.RaiseOnOnLogonError(this.parent, e);
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x00037384 File Offset: 0x00035584
		public virtual void OnFocusReleased(int iDirection)
		{
			IMsTscAxEvents_OnFocusReleasedEvent e = new IMsTscAxEvents_OnFocusReleasedEvent(iDirection);
			this.parent.RaiseOnOnFocusReleased(this.parent, e);
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x000373B0 File Offset: 0x000355B0
		public virtual void OnUserNameAcquired(string bstrUserName)
		{
			IMsTscAxEvents_OnUserNameAcquiredEvent e = new IMsTscAxEvents_OnUserNameAcquiredEvent(bstrUserName);
			this.parent.RaiseOnOnUserNameAcquired(this.parent, e);
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x000373DC File Offset: 0x000355DC
		public virtual void OnMouseInputModeChanged(bool fMouseModeRelative)
		{
			IMsTscAxEvents_OnMouseInputModeChangedEvent e = new IMsTscAxEvents_OnMouseInputModeChangedEvent(fMouseModeRelative);
			this.parent.RaiseOnOnMouseInputModeChanged(this.parent, e);
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x00037408 File Offset: 0x00035608
		public virtual void OnServiceMessageReceived(string serviceMessage)
		{
			IMsTscAxEvents_OnServiceMessageReceivedEvent e = new IMsTscAxEvents_OnServiceMessageReceivedEvent(serviceMessage);
			this.parent.RaiseOnOnServiceMessageReceived(this.parent, e);
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x00037434 File Offset: 0x00035634
		public virtual void OnConnectionBarPullDown()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnConnectionBarPullDown(this.parent, e);
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x00037460 File Offset: 0x00035660
		public virtual void OnNetworkStatusChanged(uint qualityLevel, int bandwidth, int rtt)
		{
			IMsTscAxEvents_OnNetworkStatusChangedEvent e = new IMsTscAxEvents_OnNetworkStatusChangedEvent(qualityLevel, bandwidth, rtt);
			this.parent.RaiseOnOnNetworkStatusChanged(this.parent, e);
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x0003748C File Offset: 0x0003568C
		public virtual void OnDevicesButtonPressed()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnDevicesButtonPressed(this.parent, e);
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x000374B8 File Offset: 0x000356B8
		public virtual void OnAutoReconnected()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnAutoReconnected(this.parent, e);
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x000374E4 File Offset: 0x000356E4
		public virtual void OnAutoReconnecting2(int disconnectReason, bool networkAvailable, int attemptCount, int maxAttemptCount)
		{
			IMsTscAxEvents_OnAutoReconnecting2Event e = new IMsTscAxEvents_OnAutoReconnecting2Event(disconnectReason, networkAvailable, attemptCount, maxAttemptCount);
			this.parent.RaiseOnOnAutoReconnecting2(this.parent, e);
		}

		// Token: 0x040004F2 RID: 1266
		private AxMsRdpClient4 parent;
	}
}
