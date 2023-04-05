using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MSTSCLib;

namespace AxMSTSCLib
{
	// Token: 0x02000148 RID: 328
	[DesignTimeVisible(true)]
	[AxHost.ClsidAttribute("{eab16c5d-eed1-4e95-868b-0fba1b42c092}")]
	[ComVisible(true)]
	public class AxRemoteDesktopClient : AxHost
	{
		// Token: 0x06001AD5 RID: 6869 RVA: 0x00057224 File Offset: 0x00055424
		public AxRemoteDesktopClient() : base("eab16c5d-eed1-4e95-868b-0fba1b42c092")
		{
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06001AD6 RID: 6870 RVA: 0x00057234 File Offset: 0x00055434
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

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06001AD7 RID: 6871 RVA: 0x00057258 File Offset: 0x00055458
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

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06001AD8 RID: 6872 RVA: 0x0005727C File Offset: 0x0005547C
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

		// Token: 0x14000329 RID: 809
		// (add) Token: 0x06001AD9 RID: 6873 RVA: 0x000572A0 File Offset: 0x000554A0
		// (remove) Token: 0x06001ADA RID: 6874 RVA: 0x000572DC File Offset: 0x000554DC
		public event EventHandler OnConnecting;

		// Token: 0x1400032A RID: 810
		// (add) Token: 0x06001ADB RID: 6875 RVA: 0x00057318 File Offset: 0x00055518
		// (remove) Token: 0x06001ADC RID: 6876 RVA: 0x00057354 File Offset: 0x00055554
		public event EventHandler OnConnected;

		// Token: 0x1400032B RID: 811
		// (add) Token: 0x06001ADD RID: 6877 RVA: 0x00057390 File Offset: 0x00055590
		// (remove) Token: 0x06001ADE RID: 6878 RVA: 0x000573CC File Offset: 0x000555CC
		public event EventHandler OnLoginCompleted;

		// Token: 0x1400032C RID: 812
		// (add) Token: 0x06001ADF RID: 6879 RVA: 0x00057408 File Offset: 0x00055608
		// (remove) Token: 0x06001AE0 RID: 6880 RVA: 0x00057444 File Offset: 0x00055644
		public event IRemoteDesktopClientEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x1400032D RID: 813
		// (add) Token: 0x06001AE1 RID: 6881 RVA: 0x00057480 File Offset: 0x00055680
		// (remove) Token: 0x06001AE2 RID: 6882 RVA: 0x000574BC File Offset: 0x000556BC
		public event IRemoteDesktopClientEvents_OnStatusChangedEventHandler OnStatusChanged;

		// Token: 0x1400032E RID: 814
		// (add) Token: 0x06001AE3 RID: 6883 RVA: 0x000574F8 File Offset: 0x000556F8
		// (remove) Token: 0x06001AE4 RID: 6884 RVA: 0x00057534 File Offset: 0x00055734
		public event IRemoteDesktopClientEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x1400032F RID: 815
		// (add) Token: 0x06001AE5 RID: 6885 RVA: 0x00057570 File Offset: 0x00055770
		// (remove) Token: 0x06001AE6 RID: 6886 RVA: 0x000575AC File Offset: 0x000557AC
		public event EventHandler OnAutoReconnected;

		// Token: 0x14000330 RID: 816
		// (add) Token: 0x06001AE7 RID: 6887 RVA: 0x000575E8 File Offset: 0x000557E8
		// (remove) Token: 0x06001AE8 RID: 6888 RVA: 0x00057624 File Offset: 0x00055824
		public event EventHandler OnDialogDisplaying;

		// Token: 0x14000331 RID: 817
		// (add) Token: 0x06001AE9 RID: 6889 RVA: 0x00057660 File Offset: 0x00055860
		// (remove) Token: 0x06001AEA RID: 6890 RVA: 0x0005769C File Offset: 0x0005589C
		public event EventHandler OnDialogDismissed;

		// Token: 0x14000332 RID: 818
		// (add) Token: 0x06001AEB RID: 6891 RVA: 0x000576D8 File Offset: 0x000558D8
		// (remove) Token: 0x06001AEC RID: 6892 RVA: 0x00057714 File Offset: 0x00055914
		public event IRemoteDesktopClientEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x14000333 RID: 819
		// (add) Token: 0x06001AED RID: 6893 RVA: 0x00057750 File Offset: 0x00055950
		// (remove) Token: 0x06001AEE RID: 6894 RVA: 0x0005778C File Offset: 0x0005598C
		public event IRemoteDesktopClientEvents_OnAdminMessageReceivedEventHandler OnAdminMessageReceived;

		// Token: 0x14000334 RID: 820
		// (add) Token: 0x06001AEF RID: 6895 RVA: 0x000577C8 File Offset: 0x000559C8
		// (remove) Token: 0x06001AF0 RID: 6896 RVA: 0x00057804 File Offset: 0x00055A04
		public event IRemoteDesktopClientEvents_OnKeyCombinationPressedEventHandler OnKeyCombinationPressed;

		// Token: 0x14000335 RID: 821
		// (add) Token: 0x06001AF1 RID: 6897 RVA: 0x00057840 File Offset: 0x00055A40
		// (remove) Token: 0x06001AF2 RID: 6898 RVA: 0x0005787C File Offset: 0x00055A7C
		public event IRemoteDesktopClientEvents_OnRemoteDesktopSizeChangedEventHandler OnRemoteDesktopSizeChanged;

		// Token: 0x14000336 RID: 822
		// (add) Token: 0x06001AF3 RID: 6899 RVA: 0x000578B8 File Offset: 0x00055AB8
		// (remove) Token: 0x06001AF4 RID: 6900 RVA: 0x000578F4 File Offset: 0x00055AF4
		public event IRemoteDesktopClientEvents_OnTouchPointerCursorMovedEventHandler OnTouchPointerCursorMoved;

		// Token: 0x06001AF5 RID: 6901 RVA: 0x00057930 File Offset: 0x00055B30
		public virtual void Connect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Connect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Connect();
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x00057954 File Offset: 0x00055B54
		public virtual void Disconnect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Disconnect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Disconnect();
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x00057978 File Offset: 0x00055B78
		public virtual void Reconnect(uint width, uint height)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Reconnect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Reconnect(width, height);
		}

		// Token: 0x06001AF8 RID: 6904 RVA: 0x000579A0 File Offset: 0x00055BA0
		public virtual void DeleteSavedCredentials(string serverName)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("DeleteSavedCredentials", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.DeleteSavedCredentials(serverName);
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x000579C8 File Offset: 0x00055BC8
		public virtual void UpdateSessionDisplaySettings(uint width, uint height)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("UpdateSessionDisplaySettings", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.UpdateSessionDisplaySettings(width, height);
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x000579F0 File Offset: 0x00055BF0
		public virtual void attachEvent(string eventName, object callback)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("attachEvent", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.attachEvent(eventName, callback);
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x00057A18 File Offset: 0x00055C18
		public virtual void detachEvent(string eventName, object callback)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("detachEvent", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.detachEvent(eventName, callback);
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x00057A40 File Offset: 0x00055C40
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

		// Token: 0x06001AFD RID: 6909 RVA: 0x00057A98 File Offset: 0x00055C98
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

		// Token: 0x06001AFE RID: 6910 RVA: 0x00057ACC File Offset: 0x00055CCC
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

		// Token: 0x06001AFF RID: 6911 RVA: 0x00057B08 File Offset: 0x00055D08
		internal void RaiseOnOnConnecting(object sender, EventArgs e)
		{
			if (this.OnConnecting != null)
			{
				this.OnConnecting(sender, e);
			}
		}

		// Token: 0x06001B00 RID: 6912 RVA: 0x00057B24 File Offset: 0x00055D24
		internal void RaiseOnOnConnected(object sender, EventArgs e)
		{
			if (this.OnConnected != null)
			{
				this.OnConnected(sender, e);
			}
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x00057B40 File Offset: 0x00055D40
		internal void RaiseOnOnLoginCompleted(object sender, EventArgs e)
		{
			if (this.OnLoginCompleted != null)
			{
				this.OnLoginCompleted(sender, e);
			}
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x00057B5C File Offset: 0x00055D5C
		internal void RaiseOnOnDisconnected(object sender, IRemoteDesktopClientEvents_OnDisconnectedEvent e)
		{
			if (this.OnDisconnected != null)
			{
				this.OnDisconnected(sender, e);
			}
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x00057B78 File Offset: 0x00055D78
		internal void RaiseOnOnStatusChanged(object sender, IRemoteDesktopClientEvents_OnStatusChangedEvent e)
		{
			if (this.OnStatusChanged != null)
			{
				this.OnStatusChanged(sender, e);
			}
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x00057B94 File Offset: 0x00055D94
		internal void RaiseOnOnAutoReconnecting(object sender, IRemoteDesktopClientEvents_OnAutoReconnectingEvent e)
		{
			if (this.OnAutoReconnecting != null)
			{
				this.OnAutoReconnecting(sender, e);
			}
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x00057BB0 File Offset: 0x00055DB0
		internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
		{
			if (this.OnAutoReconnected != null)
			{
				this.OnAutoReconnected(sender, e);
			}
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x00057BCC File Offset: 0x00055DCC
		internal void RaiseOnOnDialogDisplaying(object sender, EventArgs e)
		{
			if (this.OnDialogDisplaying != null)
			{
				this.OnDialogDisplaying(sender, e);
			}
		}

		// Token: 0x06001B07 RID: 6919 RVA: 0x00057BE8 File Offset: 0x00055DE8
		internal void RaiseOnOnDialogDismissed(object sender, EventArgs e)
		{
			if (this.OnDialogDismissed != null)
			{
				this.OnDialogDismissed(sender, e);
			}
		}

		// Token: 0x06001B08 RID: 6920 RVA: 0x00057C04 File Offset: 0x00055E04
		internal void RaiseOnOnNetworkStatusChanged(object sender, IRemoteDesktopClientEvents_OnNetworkStatusChangedEvent e)
		{
			if (this.OnNetworkStatusChanged != null)
			{
				this.OnNetworkStatusChanged(sender, e);
			}
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x00057C20 File Offset: 0x00055E20
		internal void RaiseOnOnAdminMessageReceived(object sender, IRemoteDesktopClientEvents_OnAdminMessageReceivedEvent e)
		{
			if (this.OnAdminMessageReceived != null)
			{
				this.OnAdminMessageReceived(sender, e);
			}
		}

		// Token: 0x06001B0A RID: 6922 RVA: 0x00057C3C File Offset: 0x00055E3C
		internal void RaiseOnOnKeyCombinationPressed(object sender, IRemoteDesktopClientEvents_OnKeyCombinationPressedEvent e)
		{
			if (this.OnKeyCombinationPressed != null)
			{
				this.OnKeyCombinationPressed(sender, e);
			}
		}

		// Token: 0x06001B0B RID: 6923 RVA: 0x00057C58 File Offset: 0x00055E58
		internal void RaiseOnOnRemoteDesktopSizeChanged(object sender, IRemoteDesktopClientEvents_OnRemoteDesktopSizeChangedEvent e)
		{
			if (this.OnRemoteDesktopSizeChanged != null)
			{
				this.OnRemoteDesktopSizeChanged(sender, e);
			}
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x00057C74 File Offset: 0x00055E74
		internal void RaiseOnOnTouchPointerCursorMoved(object sender, IRemoteDesktopClientEvents_OnTouchPointerCursorMovedEvent e)
		{
			if (this.OnTouchPointerCursorMoved != null)
			{
				this.OnTouchPointerCursorMoved(sender, e);
			}
		}

		// Token: 0x0400070F RID: 1807
		private IRemoteDesktopClient ocx;

		// Token: 0x04000710 RID: 1808
		private AxRemoteDesktopClientEventMulticaster eventMulticaster;

		// Token: 0x04000711 RID: 1809
		private AxHost.ConnectionPointCookie cookie;
	}
}
