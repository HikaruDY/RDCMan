using System;
using System.Runtime.InteropServices;
using MSTSCLib;

namespace AxMSTSCLib
{
	// Token: 0x02000141 RID: 321
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class AxMsRdpClient10NotSafeForScriptingEventMulticaster : IMsTscAxEvents
	{
		// Token: 0x0600185F RID: 6239 RVA: 0x000502EC File Offset: 0x0004E4EC
		public AxMsRdpClient10NotSafeForScriptingEventMulticaster(AxMsRdpClient10NotSafeForScripting parent)
		{
			this.parent = parent;
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x000502FC File Offset: 0x0004E4FC
		public virtual void OnConnecting()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnConnecting(this.parent, e);
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x00050328 File Offset: 0x0004E528
		public virtual void OnConnected()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnConnected(this.parent, e);
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x00050354 File Offset: 0x0004E554
		public virtual void OnLoginComplete()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnLoginComplete(this.parent, e);
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x00050380 File Offset: 0x0004E580
		public virtual void OnDisconnected(int discReason)
		{
			IMsTscAxEvents_OnDisconnectedEvent e = new IMsTscAxEvents_OnDisconnectedEvent(discReason);
			this.parent.RaiseOnOnDisconnected(this.parent, e);
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x000503AC File Offset: 0x0004E5AC
		public virtual void OnEnterFullScreenMode()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnEnterFullScreenMode(this.parent, e);
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x000503D8 File Offset: 0x0004E5D8
		public virtual void OnLeaveFullScreenMode()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnLeaveFullScreenMode(this.parent, e);
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x00050404 File Offset: 0x0004E604
		public virtual void OnChannelReceivedData(string chanName, string data)
		{
			IMsTscAxEvents_OnChannelReceivedDataEvent e = new IMsTscAxEvents_OnChannelReceivedDataEvent(chanName, data);
			this.parent.RaiseOnOnChannelReceivedData(this.parent, e);
		}

		// Token: 0x06001867 RID: 6247 RVA: 0x00050430 File Offset: 0x0004E630
		public virtual void OnRequestGoFullScreen()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnRequestGoFullScreen(this.parent, e);
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x0005045C File Offset: 0x0004E65C
		public virtual void OnRequestLeaveFullScreen()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnRequestLeaveFullScreen(this.parent, e);
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x00050488 File Offset: 0x0004E688
		public virtual void OnFatalError(int errorCode)
		{
			IMsTscAxEvents_OnFatalErrorEvent e = new IMsTscAxEvents_OnFatalErrorEvent(errorCode);
			this.parent.RaiseOnOnFatalError(this.parent, e);
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x000504B4 File Offset: 0x0004E6B4
		public virtual void OnWarning(int warningCode)
		{
			IMsTscAxEvents_OnWarningEvent e = new IMsTscAxEvents_OnWarningEvent(warningCode);
			this.parent.RaiseOnOnWarning(this.parent, e);
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x000504E0 File Offset: 0x0004E6E0
		public virtual void OnRemoteDesktopSizeChange(int width, int height)
		{
			IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e = new IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent(width, height);
			this.parent.RaiseOnOnRemoteDesktopSizeChange(this.parent, e);
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x0005050C File Offset: 0x0004E70C
		public virtual void OnIdleTimeoutNotification()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnIdleTimeoutNotification(this.parent, e);
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x00050538 File Offset: 0x0004E738
		public virtual void OnRequestContainerMinimize()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnRequestContainerMinimize(this.parent, e);
		}

		// Token: 0x0600186E RID: 6254 RVA: 0x00050564 File Offset: 0x0004E764
		public virtual void OnConfirmClose(out bool pfAllowClose)
		{
			IMsTscAxEvents_OnConfirmCloseEvent msTscAxEvents_OnConfirmCloseEvent = new IMsTscAxEvents_OnConfirmCloseEvent();
			this.parent.RaiseOnOnConfirmClose(this.parent, msTscAxEvents_OnConfirmCloseEvent);
			pfAllowClose = msTscAxEvents_OnConfirmCloseEvent.pfAllowClose;
		}

		// Token: 0x0600186F RID: 6255 RVA: 0x00050598 File Offset: 0x0004E798
		public virtual void OnReceivedTSPublicKey(string publicKey, out bool pfContinueLogon)
		{
			IMsTscAxEvents_OnReceivedTSPublicKeyEvent msTscAxEvents_OnReceivedTSPublicKeyEvent = new IMsTscAxEvents_OnReceivedTSPublicKeyEvent(publicKey);
			this.parent.RaiseOnOnReceivedTSPublicKey(this.parent, msTscAxEvents_OnReceivedTSPublicKeyEvent);
			pfContinueLogon = msTscAxEvents_OnReceivedTSPublicKeyEvent.pfContinueLogon;
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x000505CC File Offset: 0x0004E7CC
		public virtual void OnAutoReconnecting(int disconnectReason, int attemptCount, out AutoReconnectContinueState pArcContinueStatus)
		{
			IMsTscAxEvents_OnAutoReconnectingEvent msTscAxEvents_OnAutoReconnectingEvent = new IMsTscAxEvents_OnAutoReconnectingEvent(disconnectReason, attemptCount);
			this.parent.RaiseOnOnAutoReconnecting(this.parent, msTscAxEvents_OnAutoReconnectingEvent);
			pArcContinueStatus = msTscAxEvents_OnAutoReconnectingEvent.pArcContinueStatus;
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x00050600 File Offset: 0x0004E800
		public virtual void OnAuthenticationWarningDisplayed()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnAuthenticationWarningDisplayed(this.parent, e);
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x0005062C File Offset: 0x0004E82C
		public virtual void OnAuthenticationWarningDismissed()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnAuthenticationWarningDismissed(this.parent, e);
		}

		// Token: 0x06001873 RID: 6259 RVA: 0x00050658 File Offset: 0x0004E858
		public virtual void OnRemoteProgramResult(string bstrRemoteProgram, RemoteProgramResult lError, bool vbIsExecutable)
		{
			IMsTscAxEvents_OnRemoteProgramResultEvent e = new IMsTscAxEvents_OnRemoteProgramResultEvent(bstrRemoteProgram, lError, vbIsExecutable);
			this.parent.RaiseOnOnRemoteProgramResult(this.parent, e);
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x00050684 File Offset: 0x0004E884
		public virtual void OnRemoteProgramDisplayed(bool vbDisplayed, uint uDisplayInformation)
		{
			IMsTscAxEvents_OnRemoteProgramDisplayedEvent e = new IMsTscAxEvents_OnRemoteProgramDisplayedEvent(vbDisplayed, uDisplayInformation);
			this.parent.RaiseOnOnRemoteProgramDisplayed(this.parent, e);
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x000506B0 File Offset: 0x0004E8B0
		public virtual void OnRemoteWindowDisplayed(bool vbDisplayed, ref _RemotableHandle hwnd, RemoteWindowDisplayedAttribute windowAttribute)
		{
			IMsTscAxEvents_OnRemoteWindowDisplayedEvent msTscAxEvents_OnRemoteWindowDisplayedEvent = new IMsTscAxEvents_OnRemoteWindowDisplayedEvent(vbDisplayed, hwnd, windowAttribute);
			this.parent.RaiseOnOnRemoteWindowDisplayed(this.parent, msTscAxEvents_OnRemoteWindowDisplayedEvent);
			hwnd = msTscAxEvents_OnRemoteWindowDisplayedEvent.hwnd;
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x000506F0 File Offset: 0x0004E8F0
		public virtual void OnLogonError(int lError)
		{
			IMsTscAxEvents_OnLogonErrorEvent e = new IMsTscAxEvents_OnLogonErrorEvent(lError);
			this.parent.RaiseOnOnLogonError(this.parent, e);
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x0005071C File Offset: 0x0004E91C
		public virtual void OnFocusReleased(int iDirection)
		{
			IMsTscAxEvents_OnFocusReleasedEvent e = new IMsTscAxEvents_OnFocusReleasedEvent(iDirection);
			this.parent.RaiseOnOnFocusReleased(this.parent, e);
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x00050748 File Offset: 0x0004E948
		public virtual void OnUserNameAcquired(string bstrUserName)
		{
			IMsTscAxEvents_OnUserNameAcquiredEvent e = new IMsTscAxEvents_OnUserNameAcquiredEvent(bstrUserName);
			this.parent.RaiseOnOnUserNameAcquired(this.parent, e);
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x00050774 File Offset: 0x0004E974
		public virtual void OnMouseInputModeChanged(bool fMouseModeRelative)
		{
			IMsTscAxEvents_OnMouseInputModeChangedEvent e = new IMsTscAxEvents_OnMouseInputModeChangedEvent(fMouseModeRelative);
			this.parent.RaiseOnOnMouseInputModeChanged(this.parent, e);
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x000507A0 File Offset: 0x0004E9A0
		public virtual void OnServiceMessageReceived(string serviceMessage)
		{
			IMsTscAxEvents_OnServiceMessageReceivedEvent e = new IMsTscAxEvents_OnServiceMessageReceivedEvent(serviceMessage);
			this.parent.RaiseOnOnServiceMessageReceived(this.parent, e);
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x000507CC File Offset: 0x0004E9CC
		public virtual void OnConnectionBarPullDown()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnConnectionBarPullDown(this.parent, e);
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x000507F8 File Offset: 0x0004E9F8
		public virtual void OnNetworkStatusChanged(uint qualityLevel, int bandwidth, int rtt)
		{
			IMsTscAxEvents_OnNetworkStatusChangedEvent e = new IMsTscAxEvents_OnNetworkStatusChangedEvent(qualityLevel, bandwidth, rtt);
			this.parent.RaiseOnOnNetworkStatusChanged(this.parent, e);
		}

		// Token: 0x0600187D RID: 6269 RVA: 0x00050824 File Offset: 0x0004EA24
		public virtual void OnDevicesButtonPressed()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnDevicesButtonPressed(this.parent, e);
		}

		// Token: 0x0600187E RID: 6270 RVA: 0x00050850 File Offset: 0x0004EA50
		public virtual void OnAutoReconnected()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnAutoReconnected(this.parent, e);
		}

		// Token: 0x0600187F RID: 6271 RVA: 0x0005087C File Offset: 0x0004EA7C
		public virtual void OnAutoReconnecting2(int disconnectReason, bool networkAvailable, int attemptCount, int maxAttemptCount)
		{
			IMsTscAxEvents_OnAutoReconnecting2Event e = new IMsTscAxEvents_OnAutoReconnecting2Event(disconnectReason, networkAvailable, attemptCount, maxAttemptCount);
			this.parent.RaiseOnOnAutoReconnecting2(this.parent, e);
		}

		// Token: 0x040006A2 RID: 1698
		private AxMsRdpClient10NotSafeForScripting parent;
	}
}
