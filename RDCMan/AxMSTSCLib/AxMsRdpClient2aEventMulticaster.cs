using System;
using System.Runtime.InteropServices;
using MSTSCLib;

namespace AxMSTSCLib
{
	// Token: 0x0200011F RID: 287
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class AxMsRdpClient2aEventMulticaster : IMsTscAxEvents
	{
		// Token: 0x06000C05 RID: 3077 RVA: 0x0002D0B0 File Offset: 0x0002B2B0
		public AxMsRdpClient2aEventMulticaster(AxMsRdpClient2a parent)
		{
			this.parent = parent;
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x0002D0C0 File Offset: 0x0002B2C0
		public virtual void OnConnecting()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnConnecting(this.parent, e);
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x0002D0EC File Offset: 0x0002B2EC
		public virtual void OnConnected()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnConnected(this.parent, e);
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x0002D118 File Offset: 0x0002B318
		public virtual void OnLoginComplete()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnLoginComplete(this.parent, e);
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x0002D144 File Offset: 0x0002B344
		public virtual void OnDisconnected(int discReason)
		{
			IMsTscAxEvents_OnDisconnectedEvent e = new IMsTscAxEvents_OnDisconnectedEvent(discReason);
			this.parent.RaiseOnOnDisconnected(this.parent, e);
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x0002D170 File Offset: 0x0002B370
		public virtual void OnEnterFullScreenMode()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnEnterFullScreenMode(this.parent, e);
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x0002D19C File Offset: 0x0002B39C
		public virtual void OnLeaveFullScreenMode()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnLeaveFullScreenMode(this.parent, e);
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x0002D1C8 File Offset: 0x0002B3C8
		public virtual void OnChannelReceivedData(string chanName, string data)
		{
			IMsTscAxEvents_OnChannelReceivedDataEvent e = new IMsTscAxEvents_OnChannelReceivedDataEvent(chanName, data);
			this.parent.RaiseOnOnChannelReceivedData(this.parent, e);
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x0002D1F4 File Offset: 0x0002B3F4
		public virtual void OnRequestGoFullScreen()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnRequestGoFullScreen(this.parent, e);
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x0002D220 File Offset: 0x0002B420
		public virtual void OnRequestLeaveFullScreen()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnRequestLeaveFullScreen(this.parent, e);
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x0002D24C File Offset: 0x0002B44C
		public virtual void OnFatalError(int errorCode)
		{
			IMsTscAxEvents_OnFatalErrorEvent e = new IMsTscAxEvents_OnFatalErrorEvent(errorCode);
			this.parent.RaiseOnOnFatalError(this.parent, e);
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x0002D278 File Offset: 0x0002B478
		public virtual void OnWarning(int warningCode)
		{
			IMsTscAxEvents_OnWarningEvent e = new IMsTscAxEvents_OnWarningEvent(warningCode);
			this.parent.RaiseOnOnWarning(this.parent, e);
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x0002D2A4 File Offset: 0x0002B4A4
		public virtual void OnRemoteDesktopSizeChange(int width, int height)
		{
			IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e = new IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent(width, height);
			this.parent.RaiseOnOnRemoteDesktopSizeChange(this.parent, e);
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x0002D2D0 File Offset: 0x0002B4D0
		public virtual void OnIdleTimeoutNotification()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnIdleTimeoutNotification(this.parent, e);
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x0002D2FC File Offset: 0x0002B4FC
		public virtual void OnRequestContainerMinimize()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnRequestContainerMinimize(this.parent, e);
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x0002D328 File Offset: 0x0002B528
		public virtual void OnConfirmClose(out bool pfAllowClose)
		{
			IMsTscAxEvents_OnConfirmCloseEvent msTscAxEvents_OnConfirmCloseEvent = new IMsTscAxEvents_OnConfirmCloseEvent();
			this.parent.RaiseOnOnConfirmClose(this.parent, msTscAxEvents_OnConfirmCloseEvent);
			pfAllowClose = msTscAxEvents_OnConfirmCloseEvent.pfAllowClose;
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x0002D35C File Offset: 0x0002B55C
		public virtual void OnReceivedTSPublicKey(string publicKey, out bool pfContinueLogon)
		{
			IMsTscAxEvents_OnReceivedTSPublicKeyEvent msTscAxEvents_OnReceivedTSPublicKeyEvent = new IMsTscAxEvents_OnReceivedTSPublicKeyEvent(publicKey);
			this.parent.RaiseOnOnReceivedTSPublicKey(this.parent, msTscAxEvents_OnReceivedTSPublicKeyEvent);
			pfContinueLogon = msTscAxEvents_OnReceivedTSPublicKeyEvent.pfContinueLogon;
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x0002D390 File Offset: 0x0002B590
		public virtual void OnAutoReconnecting(int disconnectReason, int attemptCount, out AutoReconnectContinueState pArcContinueStatus)
		{
			IMsTscAxEvents_OnAutoReconnectingEvent msTscAxEvents_OnAutoReconnectingEvent = new IMsTscAxEvents_OnAutoReconnectingEvent(disconnectReason, attemptCount);
			this.parent.RaiseOnOnAutoReconnecting(this.parent, msTscAxEvents_OnAutoReconnectingEvent);
			pArcContinueStatus = msTscAxEvents_OnAutoReconnectingEvent.pArcContinueStatus;
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x0002D3C4 File Offset: 0x0002B5C4
		public virtual void OnAuthenticationWarningDisplayed()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnAuthenticationWarningDisplayed(this.parent, e);
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x0002D3F0 File Offset: 0x0002B5F0
		public virtual void OnAuthenticationWarningDismissed()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnAuthenticationWarningDismissed(this.parent, e);
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x0002D41C File Offset: 0x0002B61C
		public virtual void OnRemoteProgramResult(string bstrRemoteProgram, RemoteProgramResult lError, bool vbIsExecutable)
		{
			IMsTscAxEvents_OnRemoteProgramResultEvent e = new IMsTscAxEvents_OnRemoteProgramResultEvent(bstrRemoteProgram, lError, vbIsExecutable);
			this.parent.RaiseOnOnRemoteProgramResult(this.parent, e);
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x0002D448 File Offset: 0x0002B648
		public virtual void OnRemoteProgramDisplayed(bool vbDisplayed, uint uDisplayInformation)
		{
			IMsTscAxEvents_OnRemoteProgramDisplayedEvent e = new IMsTscAxEvents_OnRemoteProgramDisplayedEvent(vbDisplayed, uDisplayInformation);
			this.parent.RaiseOnOnRemoteProgramDisplayed(this.parent, e);
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x0002D474 File Offset: 0x0002B674
		public virtual void OnRemoteWindowDisplayed(bool vbDisplayed, ref _RemotableHandle hwnd, RemoteWindowDisplayedAttribute windowAttribute)
		{
			IMsTscAxEvents_OnRemoteWindowDisplayedEvent msTscAxEvents_OnRemoteWindowDisplayedEvent = new IMsTscAxEvents_OnRemoteWindowDisplayedEvent(vbDisplayed, hwnd, windowAttribute);
			this.parent.RaiseOnOnRemoteWindowDisplayed(this.parent, msTscAxEvents_OnRemoteWindowDisplayedEvent);
			hwnd = msTscAxEvents_OnRemoteWindowDisplayedEvent.hwnd;
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x0002D4B4 File Offset: 0x0002B6B4
		public virtual void OnLogonError(int lError)
		{
			IMsTscAxEvents_OnLogonErrorEvent e = new IMsTscAxEvents_OnLogonErrorEvent(lError);
			this.parent.RaiseOnOnLogonError(this.parent, e);
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x0002D4E0 File Offset: 0x0002B6E0
		public virtual void OnFocusReleased(int iDirection)
		{
			IMsTscAxEvents_OnFocusReleasedEvent e = new IMsTscAxEvents_OnFocusReleasedEvent(iDirection);
			this.parent.RaiseOnOnFocusReleased(this.parent, e);
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x0002D50C File Offset: 0x0002B70C
		public virtual void OnUserNameAcquired(string bstrUserName)
		{
			IMsTscAxEvents_OnUserNameAcquiredEvent e = new IMsTscAxEvents_OnUserNameAcquiredEvent(bstrUserName);
			this.parent.RaiseOnOnUserNameAcquired(this.parent, e);
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x0002D538 File Offset: 0x0002B738
		public virtual void OnMouseInputModeChanged(bool fMouseModeRelative)
		{
			IMsTscAxEvents_OnMouseInputModeChangedEvent e = new IMsTscAxEvents_OnMouseInputModeChangedEvent(fMouseModeRelative);
			this.parent.RaiseOnOnMouseInputModeChanged(this.parent, e);
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x0002D564 File Offset: 0x0002B764
		public virtual void OnServiceMessageReceived(string serviceMessage)
		{
			IMsTscAxEvents_OnServiceMessageReceivedEvent e = new IMsTscAxEvents_OnServiceMessageReceivedEvent(serviceMessage);
			this.parent.RaiseOnOnServiceMessageReceived(this.parent, e);
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x0002D590 File Offset: 0x0002B790
		public virtual void OnConnectionBarPullDown()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnConnectionBarPullDown(this.parent, e);
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x0002D5BC File Offset: 0x0002B7BC
		public virtual void OnNetworkStatusChanged(uint qualityLevel, int bandwidth, int rtt)
		{
			IMsTscAxEvents_OnNetworkStatusChangedEvent e = new IMsTscAxEvents_OnNetworkStatusChangedEvent(qualityLevel, bandwidth, rtt);
			this.parent.RaiseOnOnNetworkStatusChanged(this.parent, e);
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x0002D5E8 File Offset: 0x0002B7E8
		public virtual void OnDevicesButtonPressed()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnDevicesButtonPressed(this.parent, e);
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x0002D614 File Offset: 0x0002B814
		public virtual void OnAutoReconnected()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnAutoReconnected(this.parent, e);
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x0002D640 File Offset: 0x0002B840
		public virtual void OnAutoReconnecting2(int disconnectReason, bool networkAvailable, int attemptCount, int maxAttemptCount)
		{
			IMsTscAxEvents_OnAutoReconnecting2Event e = new IMsTscAxEvents_OnAutoReconnecting2Event(disconnectReason, networkAvailable, attemptCount, maxAttemptCount);
			this.parent.RaiseOnOnAutoReconnecting2(this.parent, e);
		}

		// Token: 0x0400043E RID: 1086
		private AxMsRdpClient2a parent;
	}
}
