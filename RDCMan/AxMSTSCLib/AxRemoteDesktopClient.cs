using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MSTSCLib;

namespace AxMSTSCLib
{
	[DesignTimeVisible(true)]
	[AxHost.ClsidAttribute("{eab16c5d-eed1-4e95-868b-0fba1b42c092}")]
	[ComVisible(true)]
	public class AxRemoteDesktopClient : AxHost
	{
		public AxRemoteDesktopClient() : base("eab16c5d-eed1-4e95-868b-0fba1b42c092")
		{
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		[DispId(710)]
		public virtual IRemoteDesktopClientSettings Settings
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("Settings", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.Settings;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(711)]
		[Browsable(false)]
		public virtual IRemoteDesktopClientActions Actions
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("Actions", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.Actions;
			}
		}

		[DispId(712)]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual IRemoteDesktopClientTouchPointer TouchPointer
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("TouchPointer", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.TouchPointer;
			}
		}

		public event EventHandler OnConnecting;

		public event EventHandler OnConnected;

		public event EventHandler OnLoginCompleted;

		public event IRemoteDesktopClientEvents_OnDisconnectedEventHandler OnDisconnected;

		public event IRemoteDesktopClientEvents_OnStatusChangedEventHandler OnStatusChanged;

		public event IRemoteDesktopClientEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		public event EventHandler OnAutoReconnected;

		public event EventHandler OnDialogDisplaying;

		public event EventHandler OnDialogDismissed;

		public event IRemoteDesktopClientEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		public event IRemoteDesktopClientEvents_OnAdminMessageReceivedEventHandler OnAdminMessageReceived;

		public event IRemoteDesktopClientEvents_OnKeyCombinationPressedEventHandler OnKeyCombinationPressed;

		public event IRemoteDesktopClientEvents_OnRemoteDesktopSizeChangedEventHandler OnRemoteDesktopSizeChanged;

		public event IRemoteDesktopClientEvents_OnTouchPointerCursorMovedEventHandler OnTouchPointerCursorMoved;

		public virtual void Connect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Connect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Connect();
		}

		public virtual void Disconnect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Disconnect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Disconnect();
		}

		public virtual void Reconnect(uint width, uint height)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Reconnect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Reconnect(width, height);
		}

		public virtual void DeleteSavedCredentials(string serverName)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("DeleteSavedCredentials", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.DeleteSavedCredentials(serverName);
		}

		public virtual void UpdateSessionDisplaySettings(uint width, uint height)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("UpdateSessionDisplaySettings", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.UpdateSessionDisplaySettings(width, height);
		}

		public virtual void attachEvent(string eventName, object callback)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("attachEvent", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.attachEvent(eventName, callback);
		}

		public virtual void detachEvent(string eventName, object callback)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("detachEvent", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.detachEvent(eventName, callback);
		}

		protected override void CreateSink()
		{
			try
			{
				this.eventMulticaster = new AxRemoteDesktopClientEventMulticaster(this);
				this.cookie = new AxHost.ConnectionPointCookie(this.ocx, this.eventMulticaster, typeof(IRemoteDesktopClientEvents));
			}
			catch (Exception)
			{
			}
		}

		protected override void DetachSink()
		{
			try
			{
				this.cookie.Disconnect();
			}
			catch (Exception)
			{
			}
		}

		protected override void AttachInterfaces()
		{
			try
			{
				this.ocx = (IRemoteDesktopClient)base.GetOcx();
			}
			catch (Exception)
			{
			}
		}

		internal void RaiseOnOnConnecting(object sender, EventArgs e)
		{
			if (this.OnConnecting != null)
			{
				this.OnConnecting(sender, e);
			}
		}

		internal void RaiseOnOnConnected(object sender, EventArgs e)
		{
			if (this.OnConnected != null)
			{
				this.OnConnected(sender, e);
			}
		}

		internal void RaiseOnOnLoginCompleted(object sender, EventArgs e)
		{
			if (this.OnLoginCompleted != null)
			{
				this.OnLoginCompleted(sender, e);
			}
		}

		internal void RaiseOnOnDisconnected(object sender, IRemoteDesktopClientEvents_OnDisconnectedEvent e)
		{
			if (this.OnDisconnected != null)
			{
				this.OnDisconnected(sender, e);
			}
		}

		internal void RaiseOnOnStatusChanged(object sender, IRemoteDesktopClientEvents_OnStatusChangedEvent e)
		{
			if (this.OnStatusChanged != null)
			{
				this.OnStatusChanged(sender, e);
			}
		}

		internal void RaiseOnOnAutoReconnecting(object sender, IRemoteDesktopClientEvents_OnAutoReconnectingEvent e)
		{
			if (this.OnAutoReconnecting != null)
			{
				this.OnAutoReconnecting(sender, e);
			}
		}

		internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
		{
			if (this.OnAutoReconnected != null)
			{
				this.OnAutoReconnected(sender, e);
			}
		}

		internal void RaiseOnOnDialogDisplaying(object sender, EventArgs e)
		{
			if (this.OnDialogDisplaying != null)
			{
				this.OnDialogDisplaying(sender, e);
			}
		}

		internal void RaiseOnOnDialogDismissed(object sender, EventArgs e)
		{
			if (this.OnDialogDismissed != null)
			{
				this.OnDialogDismissed(sender, e);
			}
		}

		internal void RaiseOnOnNetworkStatusChanged(object sender, IRemoteDesktopClientEvents_OnNetworkStatusChangedEvent e)
		{
			if (this.OnNetworkStatusChanged != null)
			{
				this.OnNetworkStatusChanged(sender, e);
			}
		}

		internal void RaiseOnOnAdminMessageReceived(object sender, IRemoteDesktopClientEvents_OnAdminMessageReceivedEvent e)
		{
			if (this.OnAdminMessageReceived != null)
			{
				this.OnAdminMessageReceived(sender, e);
			}
		}

		internal void RaiseOnOnKeyCombinationPressed(object sender, IRemoteDesktopClientEvents_OnKeyCombinationPressedEvent e)
		{
			if (this.OnKeyCombinationPressed != null)
			{
				this.OnKeyCombinationPressed(sender, e);
			}
		}

		internal void RaiseOnOnRemoteDesktopSizeChanged(object sender, IRemoteDesktopClientEvents_OnRemoteDesktopSizeChangedEvent e)
		{
			if (this.OnRemoteDesktopSizeChanged != null)
			{
				this.OnRemoteDesktopSizeChanged(sender, e);
			}
		}

		internal void RaiseOnOnTouchPointerCursorMoved(object sender, IRemoteDesktopClientEvents_OnTouchPointerCursorMovedEvent e)
		{
			if (this.OnTouchPointerCursorMoved != null)
			{
				this.OnTouchPointerCursorMoved(sender, e);
			}
		}

		private IRemoteDesktopClient ocx;

		private AxRemoteDesktopClientEventMulticaster eventMulticaster;

		private AxHost.ConnectionPointCookie cookie;
	}
}
