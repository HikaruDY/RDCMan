using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[ClassInterface(ClassInterfaceType.None)]
	[TypeLibType(TypeLibTypeFlags.FHidden)]
	[ComVisible(true)]
	public sealed class IRemoteDesktopClientEvents_SinkHelper : IRemoteDesktopClientEvents
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

		public void OnLoginCompleted()
		{
			if (this.m_OnLoginCompletedDelegate != null)
			{
				this.m_OnLoginCompletedDelegate();
				return;
			}
		}

		public void OnDisconnected(int A_1, int A_2, string A_3)
		{
			if (this.m_OnDisconnectedDelegate != null)
			{
				this.m_OnDisconnectedDelegate(A_1, A_2, A_3);
				return;
			}
		}

		public void OnStatusChanged(int A_1, string A_2)
		{
			if (this.m_OnStatusChangedDelegate != null)
			{
				this.m_OnStatusChangedDelegate(A_1, A_2);
				return;
			}
		}

		public void OnAutoReconnecting(int A_1, int A_2, string A_3, bool A_4, int A_5, int A_6)
		{
			if (this.m_OnAutoReconnectingDelegate != null)
			{
				this.m_OnAutoReconnectingDelegate(A_1, A_2, A_3, A_4, A_5, A_6);
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

		public void OnDialogDisplaying()
		{
			if (this.m_OnDialogDisplayingDelegate != null)
			{
				this.m_OnDialogDisplayingDelegate();
				return;
			}
		}

		public void OnDialogDismissed()
		{
			if (this.m_OnDialogDismissedDelegate != null)
			{
				this.m_OnDialogDismissedDelegate();
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

		public void OnAdminMessageReceived(string A_1)
		{
			if (this.m_OnAdminMessageReceivedDelegate != null)
			{
				this.m_OnAdminMessageReceivedDelegate(A_1);
				return;
			}
		}

		public void OnKeyCombinationPressed(int A_1)
		{
			if (this.m_OnKeyCombinationPressedDelegate != null)
			{
				this.m_OnKeyCombinationPressedDelegate(A_1);
				return;
			}
		}

		public void OnRemoteDesktopSizeChanged(int A_1, int A_2)
		{
			if (this.m_OnRemoteDesktopSizeChangedDelegate != null)
			{
				this.m_OnRemoteDesktopSizeChangedDelegate(A_1, A_2);
				return;
			}
		}

		public void OnTouchPointerCursorMoved(int A_1, int A_2)
		{
			if (this.m_OnTouchPointerCursorMovedDelegate != null)
			{
				this.m_OnTouchPointerCursorMovedDelegate(A_1, A_2);
				return;
			}
		}

		internal IRemoteDesktopClientEvents_SinkHelper()
		{
			this.m_dwCookie = 0;
			this.m_OnConnectingDelegate = null;
			this.m_OnConnectedDelegate = null;
			this.m_OnLoginCompletedDelegate = null;
			this.m_OnDisconnectedDelegate = null;
			this.m_OnStatusChangedDelegate = null;
			this.m_OnAutoReconnectingDelegate = null;
			this.m_OnAutoReconnectedDelegate = null;
			this.m_OnDialogDisplayingDelegate = null;
			this.m_OnDialogDismissedDelegate = null;
			this.m_OnNetworkStatusChangedDelegate = null;
			this.m_OnAdminMessageReceivedDelegate = null;
			this.m_OnKeyCombinationPressedDelegate = null;
			this.m_OnRemoteDesktopSizeChangedDelegate = null;
			this.m_OnTouchPointerCursorMovedDelegate = null;
		}

		public IRemoteDesktopClientEvents_OnConnectingEventHandler m_OnConnectingDelegate;

		public IRemoteDesktopClientEvents_OnConnectedEventHandler m_OnConnectedDelegate;

		public IRemoteDesktopClientEvents_OnLoginCompletedEventHandler m_OnLoginCompletedDelegate;

		public IRemoteDesktopClientEvents_OnDisconnectedEventHandler m_OnDisconnectedDelegate;

		public IRemoteDesktopClientEvents_OnStatusChangedEventHandler m_OnStatusChangedDelegate;

		public IRemoteDesktopClientEvents_OnAutoReconnectingEventHandler m_OnAutoReconnectingDelegate;

		public IRemoteDesktopClientEvents_OnAutoReconnectedEventHandler m_OnAutoReconnectedDelegate;

		public IRemoteDesktopClientEvents_OnDialogDisplayingEventHandler m_OnDialogDisplayingDelegate;

		public IRemoteDesktopClientEvents_OnDialogDismissedEventHandler m_OnDialogDismissedDelegate;

		public IRemoteDesktopClientEvents_OnNetworkStatusChangedEventHandler m_OnNetworkStatusChangedDelegate;

		public IRemoteDesktopClientEvents_OnAdminMessageReceivedEventHandler m_OnAdminMessageReceivedDelegate;

		public IRemoteDesktopClientEvents_OnKeyCombinationPressedEventHandler m_OnKeyCombinationPressedDelegate;

		public IRemoteDesktopClientEvents_OnRemoteDesktopSizeChangedEventHandler m_OnRemoteDesktopSizeChangedDelegate;

		public IRemoteDesktopClientEvents_OnTouchPointerCursorMovedEventHandler m_OnTouchPointerCursorMovedDelegate;

		public int m_dwCookie;
	}
}
