using System;
using System.Runtime.InteropServices;
using MSTSCLib;

namespace AxMSTSCLib
{
	// Token: 0x02000159 RID: 345
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class AxRemoteDesktopClientEventMulticaster : IRemoteDesktopClientEvents
	{
		// Token: 0x06001B35 RID: 6965 RVA: 0x00057D70 File Offset: 0x00055F70
		public AxRemoteDesktopClientEventMulticaster(AxRemoteDesktopClient parent)
		{
			this.parent = parent;
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x00057D80 File Offset: 0x00055F80
		public virtual void OnConnecting()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnConnecting(this.parent, e);
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x00057DAC File Offset: 0x00055FAC
		public virtual void OnConnected()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnConnected(this.parent, e);
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x00057DD8 File Offset: 0x00055FD8
		public virtual void OnLoginCompleted()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnLoginCompleted(this.parent, e);
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x00057E04 File Offset: 0x00056004
		public virtual void OnDisconnected(int disconnectReason, int extendedDisconnectReason, string disconnectErrorMessage)
		{
			IRemoteDesktopClientEvents_OnDisconnectedEvent e = new IRemoteDesktopClientEvents_OnDisconnectedEvent(disconnectReason, extendedDisconnectReason, disconnectErrorMessage);
			this.parent.RaiseOnOnDisconnected(this.parent, e);
		}

		// Token: 0x06001B3A RID: 6970 RVA: 0x00057E30 File Offset: 0x00056030
		public virtual void OnStatusChanged(int statusCode, string statusMessage)
		{
			IRemoteDesktopClientEvents_OnStatusChangedEvent e = new IRemoteDesktopClientEvents_OnStatusChangedEvent(statusCode, statusMessage);
			this.parent.RaiseOnOnStatusChanged(this.parent, e);
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x00057E5C File Offset: 0x0005605C
		public virtual void OnAutoReconnecting(int disconnectReason, int extendedDisconnectReason, string disconnectErrorMessage, bool networkAvailable, int attemptCount, int maxAttemptCount)
		{
			IRemoteDesktopClientEvents_OnAutoReconnectingEvent e = new IRemoteDesktopClientEvents_OnAutoReconnectingEvent(disconnectReason, extendedDisconnectReason, disconnectErrorMessage, networkAvailable, attemptCount, maxAttemptCount);
			this.parent.RaiseOnOnAutoReconnecting(this.parent, e);
		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x00057E90 File Offset: 0x00056090
		public virtual void OnAutoReconnected()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnAutoReconnected(this.parent, e);
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x00057EBC File Offset: 0x000560BC
		public virtual void OnDialogDisplaying()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnDialogDisplaying(this.parent, e);
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x00057EE8 File Offset: 0x000560E8
		public virtual void OnDialogDismissed()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnDialogDismissed(this.parent, e);
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x00057F14 File Offset: 0x00056114
		public virtual void OnNetworkStatusChanged(uint qualityLevel, int bandwidth, int rtt)
		{
			IRemoteDesktopClientEvents_OnNetworkStatusChangedEvent e = new IRemoteDesktopClientEvents_OnNetworkStatusChangedEvent(qualityLevel, bandwidth, rtt);
			this.parent.RaiseOnOnNetworkStatusChanged(this.parent, e);
		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x00057F40 File Offset: 0x00056140
		public virtual void OnAdminMessageReceived(string adminMessage)
		{
			IRemoteDesktopClientEvents_OnAdminMessageReceivedEvent e = new IRemoteDesktopClientEvents_OnAdminMessageReceivedEvent(adminMessage);
			this.parent.RaiseOnOnAdminMessageReceived(this.parent, e);
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x00057F6C File Offset: 0x0005616C
		public virtual void OnKeyCombinationPressed(int keyCombination)
		{
			IRemoteDesktopClientEvents_OnKeyCombinationPressedEvent e = new IRemoteDesktopClientEvents_OnKeyCombinationPressedEvent(keyCombination);
			this.parent.RaiseOnOnKeyCombinationPressed(this.parent, e);
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x00057F98 File Offset: 0x00056198
		public virtual void OnRemoteDesktopSizeChanged(int width, int height)
		{
			IRemoteDesktopClientEvents_OnRemoteDesktopSizeChangedEvent e = new IRemoteDesktopClientEvents_OnRemoteDesktopSizeChangedEvent(width, height);
			this.parent.RaiseOnOnRemoteDesktopSizeChanged(this.parent, e);
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x00057FC4 File Offset: 0x000561C4
		public virtual void OnTouchPointerCursorMoved(int x, int y)
		{
			IRemoteDesktopClientEvents_OnTouchPointerCursorMovedEvent e = new IRemoteDesktopClientEvents_OnTouchPointerCursorMovedEvent(x, y);
			this.parent.RaiseOnOnTouchPointerCursorMoved(this.parent, e);
		}

		// Token: 0x04000734 RID: 1844
		private AxRemoteDesktopClient parent;
	}
}
