using System;
using System.Runtime.InteropServices;
using MSTSCLib;

namespace AxMSTSCLib
{
	// Token: 0x02000123 RID: 291
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class AxMsRdpClient3EventMulticaster : IMsTscAxEvents
	{
		// Token: 0x06000D67 RID: 3431 RVA: 0x00031008 File Offset: 0x0002F208
		public AxMsRdpClient3EventMulticaster(AxMsRdpClient3 parent)
		{
			this.parent = parent;
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x00031018 File Offset: 0x0002F218
		public virtual void OnConnecting()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnConnecting(this.parent, e);
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x00031044 File Offset: 0x0002F244
		public virtual void OnConnected()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnConnected(this.parent, e);
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x00031070 File Offset: 0x0002F270
		public virtual void OnLoginComplete()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnLoginComplete(this.parent, e);
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x0003109C File Offset: 0x0002F29C
		public virtual void OnDisconnected(int discReason)
		{
			IMsTscAxEvents_OnDisconnectedEvent e = new IMsTscAxEvents_OnDisconnectedEvent(discReason);
			this.parent.RaiseOnOnDisconnected(this.parent, e);
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x000310C8 File Offset: 0x0002F2C8
		public virtual void OnEnterFullScreenMode()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnEnterFullScreenMode(this.parent, e);
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x000310F4 File Offset: 0x0002F2F4
		public virtual void OnLeaveFullScreenMode()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnLeaveFullScreenMode(this.parent, e);
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x00031120 File Offset: 0x0002F320
		public virtual void OnChannelReceivedData(string chanName, string data)
		{
			IMsTscAxEvents_OnChannelReceivedDataEvent e = new IMsTscAxEvents_OnChannelReceivedDataEvent(chanName, data);
			this.parent.RaiseOnOnChannelReceivedData(this.parent, e);
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x0003114C File Offset: 0x0002F34C
		public virtual void OnRequestGoFullScreen()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnRequestGoFullScreen(this.parent, e);
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x00031178 File Offset: 0x0002F378
		public virtual void OnRequestLeaveFullScreen()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnRequestLeaveFullScreen(this.parent, e);
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x000311A4 File Offset: 0x0002F3A4
		public virtual void OnFatalError(int errorCode)
		{
			IMsTscAxEvents_OnFatalErrorEvent e = new IMsTscAxEvents_OnFatalErrorEvent(errorCode);
			this.parent.RaiseOnOnFatalError(this.parent, e);
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x000311D0 File Offset: 0x0002F3D0
		public virtual void OnWarning(int warningCode)
		{
			IMsTscAxEvents_OnWarningEvent e = new IMsTscAxEvents_OnWarningEvent(warningCode);
			this.parent.RaiseOnOnWarning(this.parent, e);
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x000311FC File Offset: 0x0002F3FC
		public virtual void OnRemoteDesktopSizeChange(int width, int height)
		{
			IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e = new IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent(width, height);
			this.parent.RaiseOnOnRemoteDesktopSizeChange(this.parent, e);
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x00031228 File Offset: 0x0002F428
		public virtual void OnIdleTimeoutNotification()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnIdleTimeoutNotification(this.parent, e);
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x00031254 File Offset: 0x0002F454
		public virtual void OnRequestContainerMinimize()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnRequestContainerMinimize(this.parent, e);
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x00031280 File Offset: 0x0002F480
		public virtual void OnConfirmClose(out bool pfAllowClose)
		{
			IMsTscAxEvents_OnConfirmCloseEvent msTscAxEvents_OnConfirmCloseEvent = new IMsTscAxEvents_OnConfirmCloseEvent();
			this.parent.RaiseOnOnConfirmClose(this.parent, msTscAxEvents_OnConfirmCloseEvent);
			pfAllowClose = msTscAxEvents_OnConfirmCloseEvent.pfAllowClose;
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x000312B4 File Offset: 0x0002F4B4
		public virtual void OnReceivedTSPublicKey(string publicKey, out bool pfContinueLogon)
		{
			IMsTscAxEvents_OnReceivedTSPublicKeyEvent msTscAxEvents_OnReceivedTSPublicKeyEvent = new IMsTscAxEvents_OnReceivedTSPublicKeyEvent(publicKey);
			this.parent.RaiseOnOnReceivedTSPublicKey(this.parent, msTscAxEvents_OnReceivedTSPublicKeyEvent);
			pfContinueLogon = msTscAxEvents_OnReceivedTSPublicKeyEvent.pfContinueLogon;
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x000312E8 File Offset: 0x0002F4E8
		public virtual void OnAutoReconnecting(int disconnectReason, int attemptCount, out AutoReconnectContinueState pArcContinueStatus)
		{
			IMsTscAxEvents_OnAutoReconnectingEvent msTscAxEvents_OnAutoReconnectingEvent = new IMsTscAxEvents_OnAutoReconnectingEvent(disconnectReason, attemptCount);
			this.parent.RaiseOnOnAutoReconnecting(this.parent, msTscAxEvents_OnAutoReconnectingEvent);
			pArcContinueStatus = msTscAxEvents_OnAutoReconnectingEvent.pArcContinueStatus;
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x0003131C File Offset: 0x0002F51C
		public virtual void OnAuthenticationWarningDisplayed()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnAuthenticationWarningDisplayed(this.parent, e);
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x00031348 File Offset: 0x0002F548
		public virtual void OnAuthenticationWarningDismissed()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnAuthenticationWarningDismissed(this.parent, e);
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x00031374 File Offset: 0x0002F574
		public virtual void OnRemoteProgramResult(string bstrRemoteProgram, RemoteProgramResult lError, bool vbIsExecutable)
		{
			IMsTscAxEvents_OnRemoteProgramResultEvent e = new IMsTscAxEvents_OnRemoteProgramResultEvent(bstrRemoteProgram, lError, vbIsExecutable);
			this.parent.RaiseOnOnRemoteProgramResult(this.parent, e);
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x000313A0 File Offset: 0x0002F5A0
		public virtual void OnRemoteProgramDisplayed(bool vbDisplayed, uint uDisplayInformation)
		{
			IMsTscAxEvents_OnRemoteProgramDisplayedEvent e = new IMsTscAxEvents_OnRemoteProgramDisplayedEvent(vbDisplayed, uDisplayInformation);
			this.parent.RaiseOnOnRemoteProgramDisplayed(this.parent, e);
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x000313CC File Offset: 0x0002F5CC
		public virtual void OnRemoteWindowDisplayed(bool vbDisplayed, ref _RemotableHandle hwnd, RemoteWindowDisplayedAttribute windowAttribute)
		{
			IMsTscAxEvents_OnRemoteWindowDisplayedEvent msTscAxEvents_OnRemoteWindowDisplayedEvent = new IMsTscAxEvents_OnRemoteWindowDisplayedEvent(vbDisplayed, hwnd, windowAttribute);
			this.parent.RaiseOnOnRemoteWindowDisplayed(this.parent, msTscAxEvents_OnRemoteWindowDisplayedEvent);
			hwnd = msTscAxEvents_OnRemoteWindowDisplayedEvent.hwnd;
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x0003140C File Offset: 0x0002F60C
		public virtual void OnLogonError(int lError)
		{
			IMsTscAxEvents_OnLogonErrorEvent e = new IMsTscAxEvents_OnLogonErrorEvent(lError);
			this.parent.RaiseOnOnLogonError(this.parent, e);
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x00031438 File Offset: 0x0002F638
		public virtual void OnFocusReleased(int iDirection)
		{
			IMsTscAxEvents_OnFocusReleasedEvent e = new IMsTscAxEvents_OnFocusReleasedEvent(iDirection);
			this.parent.RaiseOnOnFocusReleased(this.parent, e);
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x00031464 File Offset: 0x0002F664
		public virtual void OnUserNameAcquired(string bstrUserName)
		{
			IMsTscAxEvents_OnUserNameAcquiredEvent e = new IMsTscAxEvents_OnUserNameAcquiredEvent(bstrUserName);
			this.parent.RaiseOnOnUserNameAcquired(this.parent, e);
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x00031490 File Offset: 0x0002F690
		public virtual void OnMouseInputModeChanged(bool fMouseModeRelative)
		{
			IMsTscAxEvents_OnMouseInputModeChangedEvent e = new IMsTscAxEvents_OnMouseInputModeChangedEvent(fMouseModeRelative);
			this.parent.RaiseOnOnMouseInputModeChanged(this.parent, e);
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x000314BC File Offset: 0x0002F6BC
		public virtual void OnServiceMessageReceived(string serviceMessage)
		{
			IMsTscAxEvents_OnServiceMessageReceivedEvent e = new IMsTscAxEvents_OnServiceMessageReceivedEvent(serviceMessage);
			this.parent.RaiseOnOnServiceMessageReceived(this.parent, e);
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x000314E8 File Offset: 0x0002F6E8
		public virtual void OnConnectionBarPullDown()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnConnectionBarPullDown(this.parent, e);
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x00031514 File Offset: 0x0002F714
		public virtual void OnNetworkStatusChanged(uint qualityLevel, int bandwidth, int rtt)
		{
			IMsTscAxEvents_OnNetworkStatusChangedEvent e = new IMsTscAxEvents_OnNetworkStatusChangedEvent(qualityLevel, bandwidth, rtt);
			this.parent.RaiseOnOnNetworkStatusChanged(this.parent, e);
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x00031540 File Offset: 0x0002F740
		public virtual void OnDevicesButtonPressed()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnDevicesButtonPressed(this.parent, e);
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x0003156C File Offset: 0x0002F76C
		public virtual void OnAutoReconnected()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnAutoReconnected(this.parent, e);
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x00031598 File Offset: 0x0002F798
		public virtual void OnAutoReconnecting2(int disconnectReason, bool networkAvailable, int attemptCount, int maxAttemptCount)
		{
			IMsTscAxEvents_OnAutoReconnecting2Event e = new IMsTscAxEvents_OnAutoReconnecting2Event(disconnectReason, networkAvailable, attemptCount, maxAttemptCount);
			this.parent.RaiseOnOnAutoReconnecting2(this.parent, e);
		}

		// Token: 0x04000486 RID: 1158
		private AxMsRdpClient3 parent;
	}
}
