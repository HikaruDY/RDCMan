using System;
using System.Runtime.InteropServices;
using MSTSCLib;

namespace AxMSTSCLib
{
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class AxRemoteDesktopClientEventMulticaster : IRemoteDesktopClientEvents
	{
		public AxRemoteDesktopClientEventMulticaster(AxRemoteDesktopClient parent)
		{
			this.parent = parent;
		}

		public virtual void OnConnecting()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnConnecting(this.parent, e);
		}

		public virtual void OnConnected()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnConnected(this.parent, e);
		}

		public virtual void OnLoginCompleted()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnLoginCompleted(this.parent, e);
		}

		public virtual void OnDisconnected(int disconnectReason, int extendedDisconnectReason, string disconnectErrorMessage)
		{
			IRemoteDesktopClientEvents_OnDisconnectedEvent e = new IRemoteDesktopClientEvents_OnDisconnectedEvent(disconnectReason, extendedDisconnectReason, disconnectErrorMessage);
			this.parent.RaiseOnOnDisconnected(this.parent, e);
		}

		public virtual void OnStatusChanged(int statusCode, string statusMessage)
		{
			IRemoteDesktopClientEvents_OnStatusChangedEvent e = new IRemoteDesktopClientEvents_OnStatusChangedEvent(statusCode, statusMessage);
			this.parent.RaiseOnOnStatusChanged(this.parent, e);
		}

		public virtual void OnAutoReconnecting(int disconnectReason, int extendedDisconnectReason, string disconnectErrorMessage, bool networkAvailable, int attemptCount, int maxAttemptCount)
		{
			IRemoteDesktopClientEvents_OnAutoReconnectingEvent e = new IRemoteDesktopClientEvents_OnAutoReconnectingEvent(disconnectReason, extendedDisconnectReason, disconnectErrorMessage, networkAvailable, attemptCount, maxAttemptCount);
			this.parent.RaiseOnOnAutoReconnecting(this.parent, e);
		}

		public virtual void OnAutoReconnected()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnAutoReconnected(this.parent, e);
		}

		public virtual void OnDialogDisplaying()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnDialogDisplaying(this.parent, e);
		}

		public virtual void OnDialogDismissed()
		{
			EventArgs e = new EventArgs();
			this.parent.RaiseOnOnDialogDismissed(this.parent, e);
		}

		public virtual void OnNetworkStatusChanged(uint qualityLevel, int bandwidth, int rtt)
		{
			IRemoteDesktopClientEvents_OnNetworkStatusChangedEvent e = new IRemoteDesktopClientEvents_OnNetworkStatusChangedEvent(qualityLevel, bandwidth, rtt);
			this.parent.RaiseOnOnNetworkStatusChanged(this.parent, e);
		}

		public virtual void OnAdminMessageReceived(string adminMessage)
		{
			IRemoteDesktopClientEvents_OnAdminMessageReceivedEvent e = new IRemoteDesktopClientEvents_OnAdminMessageReceivedEvent(adminMessage);
			this.parent.RaiseOnOnAdminMessageReceived(this.parent, e);
		}

		public virtual void OnKeyCombinationPressed(int keyCombination)
		{
			IRemoteDesktopClientEvents_OnKeyCombinationPressedEvent e = new IRemoteDesktopClientEvents_OnKeyCombinationPressedEvent(keyCombination);
			this.parent.RaiseOnOnKeyCombinationPressed(this.parent, e);
		}

		public virtual void OnRemoteDesktopSizeChanged(int width, int height)
		{
			IRemoteDesktopClientEvents_OnRemoteDesktopSizeChangedEvent e = new IRemoteDesktopClientEvents_OnRemoteDesktopSizeChangedEvent(width, height);
			this.parent.RaiseOnOnRemoteDesktopSizeChanged(this.parent, e);
		}

		public virtual void OnTouchPointerCursorMoved(int x, int y)
		{
			IRemoteDesktopClientEvents_OnTouchPointerCursorMovedEvent e = new IRemoteDesktopClientEvents_OnTouchPointerCursorMovedEvent(x, y);
			this.parent.RaiseOnOnTouchPointerCursorMoved(this.parent, e);
		}

		private AxRemoteDesktopClient parent;
	}
}
