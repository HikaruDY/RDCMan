using System;
using System.Runtime.InteropServices;
using MSTSCLib;

namespace AxMSTSCLib
{
	// Token: 0x0200012F RID: 303
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class AxMsRdpClient5EventMulticaster : IMsTscAxEvents
	{
		// Token: 0x0600119C RID: 4508 RVA: 0x0003D054 File Offset: 0x0003B254
		public AxMsRdpClient5EventMulticaster(AxMsRdpClient5 parent)
		{
			this.parent = parent;
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x0003D064 File Offset: 0x0003B264
		public virtual void OnConnecting()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnConnecting(this.parent, e);
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x0003D090 File Offset: 0x0003B290
		public virtual void OnConnected()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnConnected(this.parent, e);
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x0003D0BC File Offset: 0x0003B2BC
		public virtual void OnLoginComplete()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnLoginComplete(this.parent, e);
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x0003D0E8 File Offset: 0x0003B2E8
		public virtual void OnDisconnected(int discReason)
		{
			IMsTscAxEvents_OnDisconnectedEvent e = new IMsTscAxEvents_OnDisconnectedEvent(discReason);
			this.parent.RaiseOnOnDisconnected(this.parent, e);
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x0003D114 File Offset: 0x0003B314
		public virtual void OnEnterFullScreenMode()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnEnterFullScreenMode(this.parent, e);
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x0003D140 File Offset: 0x0003B340
		public virtual void OnLeaveFullScreenMode()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnLeaveFullScreenMode(this.parent, e);
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x0003D16C File Offset: 0x0003B36C
		public virtual void OnChannelReceivedData(string chanName, string data)
		{
			IMsTscAxEvents_OnChannelReceivedDataEvent e = new IMsTscAxEvents_OnChannelReceivedDataEvent(chanName, data);
			this.parent.RaiseOnOnChannelReceivedData(this.parent, e);
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x0003D198 File Offset: 0x0003B398
		public virtual void OnRequestGoFullScreen()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnRequestGoFullScreen(this.parent, e);
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x0003D1C4 File Offset: 0x0003B3C4
		public virtual void OnRequestLeaveFullScreen()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnRequestLeaveFullScreen(this.parent, e);
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x0003D1F0 File Offset: 0x0003B3F0
		public virtual void OnFatalError(int errorCode)
		{
			IMsTscAxEvents_OnFatalErrorEvent e = new IMsTscAxEvents_OnFatalErrorEvent(errorCode);
			this.parent.RaiseOnOnFatalError(this.parent, e);
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x0003D21C File Offset: 0x0003B41C
		public virtual void OnWarning(int warningCode)
		{
			IMsTscAxEvents_OnWarningEvent e = new IMsTscAxEvents_OnWarningEvent(warningCode);
			this.parent.RaiseOnOnWarning(this.parent, e);
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x0003D248 File Offset: 0x0003B448
		public virtual void OnRemoteDesktopSizeChange(int width, int height)
		{
			IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e = new IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent(width, height);
			this.parent.RaiseOnOnRemoteDesktopSizeChange(this.parent, e);
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x0003D274 File Offset: 0x0003B474
		public virtual void OnIdleTimeoutNotification()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnIdleTimeoutNotification(this.parent, e);
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x0003D2A0 File Offset: 0x0003B4A0
		public virtual void OnRequestContainerMinimize()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnRequestContainerMinimize(this.parent, e);
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x0003D2CC File Offset: 0x0003B4CC
		public virtual void OnConfirmClose(out bool pfAllowClose)
		{
			IMsTscAxEvents_OnConfirmCloseEvent msTscAxEvents_OnConfirmCloseEvent = new IMsTscAxEvents_OnConfirmCloseEvent();
			this.parent.RaiseOnOnConfirmClose(this.parent, msTscAxEvents_OnConfirmCloseEvent);
			pfAllowClose = msTscAxEvents_OnConfirmCloseEvent.pfAllowClose;
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x0003D300 File Offset: 0x0003B500
		public virtual void OnReceivedTSPublicKey(string publicKey, out bool pfContinueLogon)
		{
			IMsTscAxEvents_OnReceivedTSPublicKeyEvent msTscAxEvents_OnReceivedTSPublicKeyEvent = new IMsTscAxEvents_OnReceivedTSPublicKeyEvent(publicKey);
			this.parent.RaiseOnOnReceivedTSPublicKey(this.parent, msTscAxEvents_OnReceivedTSPublicKeyEvent);
			pfContinueLogon = msTscAxEvents_OnReceivedTSPublicKeyEvent.pfContinueLogon;
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x0003D334 File Offset: 0x0003B534
		public virtual void OnAutoReconnecting(int disconnectReason, int attemptCount, out AutoReconnectContinueState pArcContinueStatus)
		{
			IMsTscAxEvents_OnAutoReconnectingEvent msTscAxEvents_OnAutoReconnectingEvent = new IMsTscAxEvents_OnAutoReconnectingEvent(disconnectReason, attemptCount);
			this.parent.RaiseOnOnAutoReconnecting(this.parent, msTscAxEvents_OnAutoReconnectingEvent);
			pArcContinueStatus = msTscAxEvents_OnAutoReconnectingEvent.pArcContinueStatus;
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x0003D368 File Offset: 0x0003B568
		public virtual void OnAuthenticationWarningDisplayed()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnAuthenticationWarningDisplayed(this.parent, e);
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x0003D394 File Offset: 0x0003B594
		public virtual void OnAuthenticationWarningDismissed()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnAuthenticationWarningDismissed(this.parent, e);
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x0003D3C0 File Offset: 0x0003B5C0
		public virtual void OnRemoteProgramResult(string bstrRemoteProgram, RemoteProgramResult lError, bool vbIsExecutable)
		{
			IMsTscAxEvents_OnRemoteProgramResultEvent e = new IMsTscAxEvents_OnRemoteProgramResultEvent(bstrRemoteProgram, lError, vbIsExecutable);
			this.parent.RaiseOnOnRemoteProgramResult(this.parent, e);
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x0003D3EC File Offset: 0x0003B5EC
		public virtual void OnRemoteProgramDisplayed(bool vbDisplayed, uint uDisplayInformation)
		{
			IMsTscAxEvents_OnRemoteProgramDisplayedEvent e = new IMsTscAxEvents_OnRemoteProgramDisplayedEvent(vbDisplayed, uDisplayInformation);
			this.parent.RaiseOnOnRemoteProgramDisplayed(this.parent, e);
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x0003D418 File Offset: 0x0003B618
		public virtual void OnRemoteWindowDisplayed(bool vbDisplayed, ref _RemotableHandle hwnd, RemoteWindowDisplayedAttribute windowAttribute)
		{
			IMsTscAxEvents_OnRemoteWindowDisplayedEvent msTscAxEvents_OnRemoteWindowDisplayedEvent = new IMsTscAxEvents_OnRemoteWindowDisplayedEvent(vbDisplayed, hwnd, windowAttribute);
			this.parent.RaiseOnOnRemoteWindowDisplayed(this.parent, msTscAxEvents_OnRemoteWindowDisplayedEvent);
			hwnd = msTscAxEvents_OnRemoteWindowDisplayedEvent.hwnd;
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x0003D458 File Offset: 0x0003B658
		public virtual void OnLogonError(int lError)
		{
			IMsTscAxEvents_OnLogonErrorEvent e = new IMsTscAxEvents_OnLogonErrorEvent(lError);
			this.parent.RaiseOnOnLogonError(this.parent, e);
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x0003D484 File Offset: 0x0003B684
		public virtual void OnFocusReleased(int iDirection)
		{
			IMsTscAxEvents_OnFocusReleasedEvent e = new IMsTscAxEvents_OnFocusReleasedEvent(iDirection);
			this.parent.RaiseOnOnFocusReleased(this.parent, e);
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x0003D4B0 File Offset: 0x0003B6B0
		public virtual void OnUserNameAcquired(string bstrUserName)
		{
			IMsTscAxEvents_OnUserNameAcquiredEvent e = new IMsTscAxEvents_OnUserNameAcquiredEvent(bstrUserName);
			this.parent.RaiseOnOnUserNameAcquired(this.parent, e);
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x0003D4DC File Offset: 0x0003B6DC
		public virtual void OnMouseInputModeChanged(bool fMouseModeRelative)
		{
			IMsTscAxEvents_OnMouseInputModeChangedEvent e = new IMsTscAxEvents_OnMouseInputModeChangedEvent(fMouseModeRelative);
			this.parent.RaiseOnOnMouseInputModeChanged(this.parent, e);
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x0003D508 File Offset: 0x0003B708
		public virtual void OnServiceMessageReceived(string serviceMessage)
		{
			IMsTscAxEvents_OnServiceMessageReceivedEvent e = new IMsTscAxEvents_OnServiceMessageReceivedEvent(serviceMessage);
			this.parent.RaiseOnOnServiceMessageReceived(this.parent, e);
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x0003D534 File Offset: 0x0003B734
		public virtual void OnConnectionBarPullDown()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnConnectionBarPullDown(this.parent, e);
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x0003D560 File Offset: 0x0003B760
		public virtual void OnNetworkStatusChanged(uint qualityLevel, int bandwidth, int rtt)
		{
			IMsTscAxEvents_OnNetworkStatusChangedEvent e = new IMsTscAxEvents_OnNetworkStatusChangedEvent(qualityLevel, bandwidth, rtt);
			this.parent.RaiseOnOnNetworkStatusChanged(this.parent, e);
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x0003D58C File Offset: 0x0003B78C
		public virtual void OnDevicesButtonPressed()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnDevicesButtonPressed(this.parent, e);
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x0003D5B8 File Offset: 0x0003B7B8
		public virtual void OnAutoReconnected()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnAutoReconnected(this.parent, e);
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x0003D5E4 File Offset: 0x0003B7E4
		public virtual void OnAutoReconnecting2(int disconnectReason, bool networkAvailable, int attemptCount, int maxAttemptCount)
		{
			IMsTscAxEvents_OnAutoReconnecting2Event e = new IMsTscAxEvents_OnAutoReconnecting2Event(disconnectReason, networkAvailable, attemptCount, maxAttemptCount);
			this.parent.RaiseOnOnAutoReconnecting2(this.parent, e);
		}

		// Token: 0x0400055E RID: 1374
		private AxMsRdpClient5 parent;
	}
}
