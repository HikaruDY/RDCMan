using System;
using System.Drawing;
using System.Windows.Forms;
using AxMSTSCLib;
using MSTSCLib;

namespace RdcMan
{
	// Token: 0x02000127 RID: 295
	public class RdpClient
	{
		// Token: 0x0600077C RID: 1916 RVA: 0x0001DDBC File Offset: 0x0001BFBC
		public static string AudioRedirectionModeToString(RdpClient.AudioRedirectionMode mode)
		{
			switch (mode)
			{
			case RdpClient.AudioRedirectionMode.Client:
				return "Bring to this computer";
			case RdpClient.AudioRedirectionMode.Remote:
				return "Leave at remote computer";
			case RdpClient.AudioRedirectionMode.NoSound:
				return "Do not play";
			default:
				throw new Exception("Unexpected AudioRedirectionMode:" + mode.ToString());
			}
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x0001DE0C File Offset: 0x0001C00C
		public static string AudioRedirectionQualityToString(RdpClient.AudioRedirectionQuality mode)
		{
			switch (mode)
			{
			case RdpClient.AudioRedirectionQuality.Dynamic:
				return "Dynamically adjusted";
			case RdpClient.AudioRedirectionQuality.High:
				return "High quality";
			case RdpClient.AudioRedirectionQuality.Medium:
				return "Medium quality";
			default:
				throw new Exception("Unexpected AudioRedirectionQuality:" + mode.ToString());
			}
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00006AB7 File Offset: 0x00004CB7
		public static string AudioCaptureRedirectionModeToString(RdpClient.AudioCaptureRedirectionMode mode)
		{
			if (mode == RdpClient.AudioCaptureRedirectionMode.DoNotRecord)
			{
				return "Do not record";
			}
			if (mode != RdpClient.AudioCaptureRedirectionMode.Record)
			{
				throw new Exception("Unexpected AudioCaptureRedirectionMode:" + mode.ToString());
			}
			return "Record from this computer";
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x0001DE5C File Offset: 0x0001C05C
		public static string KeyboardHookModeToString(RdpClient.KeyboardHookMode mode)
		{
			switch (mode)
			{
			case RdpClient.KeyboardHookMode.Client:
				return "On the local computer";
			case RdpClient.KeyboardHookMode.Remote:
				return "On the remote computer";
			case RdpClient.KeyboardHookMode.FullScreenClient:
				return "In full screen mode only";
			default:
				throw new Exception("Unexpected KeyboardHookMode:" + mode.ToString());
			}
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x00006AEA File Offset: 0x00004CEA
		public static string GatewayLogonMethodToString(RdpClient.GatewayLogonMethod mode)
		{
			switch (mode)
			{
			case RdpClient.GatewayLogonMethod.NTLM:
				return "Ask for password (NTLM)";
			case RdpClient.GatewayLogonMethod.SmartCard:
				return "Smart card";
			case RdpClient.GatewayLogonMethod.Any:
				return "Allow me to select later";
			}
			return null;
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x00006B1B File Offset: 0x00004D1B
		public static string GatewayUsageMethodToString(RdpClient.GatewayUsageMethod mode)
		{
			if (mode == RdpClient.GatewayUsageMethod.NoneDirect)
			{
				return "Do not use a Gateway server";
			}
			if (mode == RdpClient.GatewayUsageMethod.NoneDetect)
			{
				return "Automatically detect Gateway";
			}
			throw new Exception("Unexpected GatewayUsageMethod:" + mode.ToString());
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x0001DEAC File Offset: 0x0001C0AC
		public static string AuthenticationLevelToString(RdpClient.AuthenticationLevel mode)
		{
			switch (mode)
			{
			case RdpClient.AuthenticationLevel.None:
				return "Connect and don't warn if authentication fails";
			case RdpClient.AuthenticationLevel.Required:
				return "Do not connect if authentication fails";
			case RdpClient.AuthenticationLevel.Warn:
				return "Warn if authentication fails";
			default:
				throw new Exception("Unexpected AuthenticationLevel:" + mode.ToString());
			}
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x0001DEFC File Offset: 0x0001C0FC
		private RdpClient(MainForm form)
		{
			switch (RdpClient.RdpClientVersion)
			{
			case 6:
				this._rdpClient6 = new RdpClient6(form);
				return;
			case 7:
				this._rdpClient7 = new RdpClient7(form);
				return;
			case 8:
				this._rdpClient8 = new RdpClient8(form);
				return;
			default:
				this._rdpClient5 = new RdpClient5(form);
				return;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x00006B4C File Offset: 0x00004D4C
		// (set) Token: 0x06000785 RID: 1925 RVA: 0x00006B69 File Offset: 0x00004D69
		public Size DesktopSize
		{
			get
			{
				return new Size(this.MsRdpClient.DesktopWidth, this.MsRdpClient.DesktopHeight);
			}
			set
			{
				this.MsRdpClient.DesktopHeight = Math.Min(RdpClient.MaxDesktopHeight, value.Height);
				this.MsRdpClient.DesktopWidth = Math.Min(RdpClient.MaxDesktopWidth, value.Width);
			}
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x0001DF60 File Offset: 0x0001C160
		internal static void Initialize(MainForm form)
		{
			using (RdpClient5 rdpClient = new RdpClient5(form))
			{
				RdpClient.RdpControlVersion = rdpClient.Version;
				string[] array = rdpClient.Version.Split(new char[]
				{
					'.'
				});
				RdpClient.RdpClientVersion = 5;
				if (int.Parse(array[2]) >= 6001)
				{
					RdpClient.RdpClientVersion = 6;
					RdpClient.SupportsMonitorSpanning = true;
					if (int.Parse(array[2]) >= 7600)
					{
						RdpClient.RdpClientVersion = 7;
						if (int.Parse(array[2]) >= 9200)
						{
							RdpClient.RdpClientVersion = 8;
						}
					}
				}
				form.RemoveFromClientPanel(rdpClient);
			}
			RdpClient.StaticClient = new RdpClient(form);
			RdpClient staticClient = RdpClient.StaticClient;
			staticClient.Control.Enabled = false;
			RdpClient.MaxDesktopWidth = 4096;
			RdpClient.MaxDesktopHeight = 2048;
			if (staticClient.AdvancedSettings7 != null)
			{
				RdpClient.SupportsGatewayCredentials = true;
			}
			if (staticClient.AdvancedSettings8 != null)
			{
				RdpClient.SupportsAdvancedAudioVideoRedirection = true;
			}
			if (staticClient.ClientNonScriptable3 != null)
			{
				RdpClient.SupportsFineGrainedRedirection = true;
			}
			if (staticClient.MsRdpClient8 != null)
			{
				RdpClient.SupportsRemoteSessionActions = true;
			}
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x0001E070 File Offset: 0x0001C270
		internal static RdpClient AllocClient(Server server, MainForm form)
		{
			return new RdpClient(form)
			{
				_server = server
			};
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x0001E08C File Offset: 0x0001C28C
		internal static void ReleaseClient(RdpClient client)
		{
			try
			{
				client._server = null;
				Program.TheForm.RemoveFromClientPanel(client.Control);
			}
			finally
			{
				AxHost axHost = client._rdpClient5;
				if (axHost != null)
				{
					client._rdpClient5 = null;
					axHost.Dispose();
				}
				axHost = client._rdpClient6;
				if (axHost != null)
				{
					client._rdpClient6 = null;
					axHost.Dispose();
				}
				axHost = client._rdpClient7;
				if (axHost != null)
				{
					client._rdpClient7 = null;
					axHost.Dispose();
				}
				axHost = client._rdpClient8;
				if (axHost != null)
				{
					client._rdpClient8 = null;
					axHost.Dispose();
				}
			}
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x0001E120 File Offset: 0x0001C320
		public void SetText()
		{
			if (this._rdpClient8 != null)
			{
				this._rdpClient8.ConnectingText = this._server.ConnectingText;
				this._rdpClient8.DisconnectedText = this._server.DisconnectedText;
				return;
			}
			if (this._rdpClient7 != null)
			{
				this._rdpClient7.ConnectingText = this._server.ConnectingText;
				this._rdpClient7.DisconnectedText = this._server.DisconnectedText;
				return;
			}
			if (this._rdpClient6 != null)
			{
				this._rdpClient6.ConnectingText = this._server.ConnectingText;
				this._rdpClient6.DisconnectedText = this._server.DisconnectedText;
				return;
			}
			this._rdpClient5.ConnectingText = this._server.ConnectingText;
			this._rdpClient5.DisconnectedText = this._server.DisconnectedText;
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600078A RID: 1930 RVA: 0x00006BA3 File Offset: 0x00004DA3
		public Control Control
		{
			get
			{
				if (this._rdpClient8 != null)
				{
					return this._rdpClient8;
				}
				if (this._rdpClient7 != null)
				{
					return this._rdpClient7;
				}
				if (this._rdpClient6 != null)
				{
					return this._rdpClient6;
				}
				return this._rdpClient5;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600078B RID: 1931 RVA: 0x00006BD8 File Offset: 0x00004DD8
		public IMsRdpClient MsRdpClient
		{
			get
			{
				return this.GetOcx() as IMsRdpClient;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600078C RID: 1932 RVA: 0x0001E1F8 File Offset: 0x0001C3F8
		public IMsRdpClientAdvancedSettings AdvancedSettings2
		{
			get
			{
				if (this._rdpClient8 != null)
				{
					return this._rdpClient8.AdvancedSettings2;
				}
				if (this._rdpClient7 != null)
				{
					return this._rdpClient7.AdvancedSettings2;
				}
				if (this._rdpClient6 != null)
				{
					return this._rdpClient6.AdvancedSettings2;
				}
				return this._rdpClient5.AdvancedSettings2;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600078D RID: 1933 RVA: 0x0001E24C File Offset: 0x0001C44C
		public IMsRdpClientAdvancedSettings4 AdvancedSettings5
		{
			get
			{
				if (this._rdpClient8 != null)
				{
					return this._rdpClient8.AdvancedSettings5;
				}
				if (this._rdpClient7 != null)
				{
					return this._rdpClient7.AdvancedSettings5;
				}
				if (this._rdpClient6 != null)
				{
					return this._rdpClient6.AdvancedSettings5;
				}
				return this._rdpClient5.AdvancedSettings5;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x0001E2A0 File Offset: 0x0001C4A0
		public IMsRdpClientAdvancedSettings5 AdvancedSettings6
		{
			get
			{
				if (this._rdpClient8 != null)
				{
					return this._rdpClient8.AdvancedSettings6;
				}
				if (this._rdpClient7 != null)
				{
					return this._rdpClient7.AdvancedSettings6;
				}
				if (this._rdpClient6 != null)
				{
					return this._rdpClient6.AdvancedSettings6;
				}
				return this._rdpClient5.AdvancedSettings6;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600078F RID: 1935 RVA: 0x00006BE5 File Offset: 0x00004DE5
		public IMsRdpClientAdvancedSettings6 AdvancedSettings7
		{
			get
			{
				if (this._rdpClient8 != null)
				{
					return this._rdpClient8.AdvancedSettings7;
				}
				if (this._rdpClient7 != null)
				{
					return this._rdpClient7.AdvancedSettings7;
				}
				if (this._rdpClient6 != null)
				{
					return this._rdpClient6.AdvancedSettings7;
				}
				return null;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x00006C24 File Offset: 0x00004E24
		public IMsRdpClientAdvancedSettings7 AdvancedSettings8
		{
			get
			{
				if (this._rdpClient8 != null)
				{
					return this._rdpClient8.AdvancedSettings8;
				}
				if (this._rdpClient7 != null)
				{
					return this._rdpClient7.AdvancedSettings8;
				}
				return null;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000791 RID: 1937 RVA: 0x00006C4F File Offset: 0x00004E4F
		public IMsRdpClientNonScriptable3 ClientNonScriptable3
		{
			get
			{
				return this.GetOcx() as IMsRdpClientNonScriptable3;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000792 RID: 1938 RVA: 0x00006C5C File Offset: 0x00004E5C
		public IMsRdpClient8 MsRdpClient8
		{
			get
			{
				return this.MsRdpClient as IMsRdpClient8;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x0001E2F4 File Offset: 0x0001C4F4
		public IMsRdpClientTransportSettings TransportSettings
		{
			get
			{
				if (this._rdpClient8 != null)
				{
					return this._rdpClient8.TransportSettings;
				}
				if (this._rdpClient7 != null)
				{
					return this._rdpClient7.TransportSettings;
				}
				if (this._rdpClient6 != null)
				{
					return this._rdpClient6.TransportSettings;
				}
				return this._rdpClient5.TransportSettings;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000794 RID: 1940 RVA: 0x00006C69 File Offset: 0x00004E69
		public IMsRdpClientTransportSettings2 TransportSettings2
		{
			get
			{
				if (this._rdpClient8 != null)
				{
					return this._rdpClient8.TransportSettings2;
				}
				if (this._rdpClient7 != null)
				{
					return this._rdpClient7.TransportSettings2;
				}
				if (this._rdpClient6 != null)
				{
					return this._rdpClient6.TransportSettings2;
				}
				return null;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000795 RID: 1941 RVA: 0x0001E348 File Offset: 0x0001C548
		public IMsTscSecuredSettings SecuredSettings
		{
			get
			{
				if (this._rdpClient8 != null)
				{
					return this._rdpClient8.SecuredSettings;
				}
				if (this._rdpClient7 != null)
				{
					return this._rdpClient7.SecuredSettings;
				}
				if (this._rdpClient6 != null)
				{
					return this._rdpClient6.SecuredSettings;
				}
				return this._rdpClient5.SecuredSettings;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000796 RID: 1942 RVA: 0x0001E39C File Offset: 0x0001C59C
		public IMsRdpClientSecuredSettings SecuredSettings2
		{
			get
			{
				if (this._rdpClient8 != null)
				{
					return this._rdpClient8.SecuredSettings2;
				}
				if (this._rdpClient7 != null)
				{
					return this._rdpClient7.SecuredSettings2;
				}
				if (this._rdpClient6 != null)
				{
					return this._rdpClient6.SecuredSettings2;
				}
				return this._rdpClient5.SecuredSettings2;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000797 RID: 1943 RVA: 0x0001E3F0 File Offset: 0x0001C5F0
		public ITSRemoteProgram RemoteProgram
		{
			get
			{
				if (this._rdpClient8 != null)
				{
					return this._rdpClient8.RemoteProgram;
				}
				if (this._rdpClient7 != null)
				{
					return this._rdpClient7.RemoteProgram;
				}
				if (this._rdpClient6 != null)
				{
					return this._rdpClient6.RemoteProgram;
				}
				return this._rdpClient5.RemoteProgram;
			}
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x0001E444 File Offset: 0x0001C644
		public object GetOcx()
		{
			if (this._rdpClient8 != null)
			{
				return this._rdpClient8.GetOcx();
			}
			if (this._rdpClient7 != null)
			{
				return this._rdpClient7.GetOcx();
			}
			if (this._rdpClient6 != null)
			{
				return this._rdpClient6.GetOcx();
			}
			return this._rdpClient5.GetOcx();
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000799 RID: 1945 RVA: 0x00006CA8 File Offset: 0x00004EA8
		public static IMsRdpDriveCollection DriveCollection
		{
			get
			{
				return RdpClient.StaticClient.ClientNonScriptable3.DriveCollection;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600079A RID: 1946 RVA: 0x00006CB9 File Offset: 0x00004EB9
		public static IMsRdpDeviceCollection DeviceCollection
		{
			get
			{
				return RdpClient.StaticClient.ClientNonScriptable3.DeviceCollection;
			}
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x0001E498 File Offset: 0x0001C698
		public void ConnectConnectionHandlers(EventHandler onConnected, EventHandler onConnecting, IMsTscAxEvents_OnDisconnectedEventHandler onDisconnected, IMsTscAxEvents_OnAutoReconnectingEventHandler onAutoReconnecting, IMsTscAxEvents_OnAutoReconnecting2EventHandler onAutoReconnecting2, EventHandler onAutoReconnected, IMsTscAxEvents_OnFocusReleasedEventHandler onFocusReleased)
		{
			if (this._rdpClient8 != null)
			{
				this._rdpClient8.OnConnected += onConnected;
				this._rdpClient8.OnConnecting += onConnecting;
				this._rdpClient8.OnDisconnected += onDisconnected;
				this._rdpClient8.OnAutoReconnecting += onAutoReconnecting;
				this._rdpClient8.OnAutoReconnecting2 += onAutoReconnecting2;
				this._rdpClient8.OnAutoReconnected += onAutoReconnected;
				this._rdpClient8.OnFocusReleased += onFocusReleased;
				return;
			}
			if (this._rdpClient7 != null)
			{
				this._rdpClient7.OnConnected += onConnected;
				this._rdpClient7.OnConnecting += onConnecting;
				this._rdpClient7.OnDisconnected += onDisconnected;
				this._rdpClient7.OnAutoReconnecting += onAutoReconnecting;
				this._rdpClient7.OnAutoReconnecting2 += onAutoReconnecting2;
				this._rdpClient7.OnAutoReconnected += onAutoReconnected;
				this._rdpClient7.OnFocusReleased += onFocusReleased;
				return;
			}
			if (this._rdpClient6 != null)
			{
				this._rdpClient6.OnConnected += onConnected;
				this._rdpClient6.OnConnecting += onConnecting;
				this._rdpClient6.OnDisconnected += onDisconnected;
				this._rdpClient6.OnAutoReconnecting += onAutoReconnecting;
				this._rdpClient6.OnAutoReconnecting2 += onAutoReconnecting2;
				this._rdpClient6.OnAutoReconnected += onAutoReconnected;
				this._rdpClient6.OnFocusReleased += onFocusReleased;
				return;
			}
			this._rdpClient5.OnConnected += onConnected;
			this._rdpClient5.OnConnecting += onConnecting;
			this._rdpClient5.OnDisconnected += onDisconnected;
			this._rdpClient5.OnAutoReconnecting += onAutoReconnecting;
			this._rdpClient5.OnAutoReconnecting2 += onAutoReconnecting2;
			this._rdpClient5.OnAutoReconnected += onAutoReconnected;
			this._rdpClient5.OnFocusReleased += onFocusReleased;
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x0001E620 File Offset: 0x0001C820
		public void DisconnectConnectionHandlers(EventHandler onConnected, EventHandler onConnecting, IMsTscAxEvents_OnDisconnectedEventHandler onDisconnected, IMsTscAxEvents_OnAutoReconnectingEventHandler onAutoReconnecting, IMsTscAxEvents_OnAutoReconnecting2EventHandler onAutoReconnecting2, EventHandler onAutoReconnected, IMsTscAxEvents_OnFocusReleasedEventHandler onFocusReleased)
		{
			if (this._rdpClient8 != null)
			{
				this._rdpClient8.OnConnected -= onConnected;
				this._rdpClient8.OnConnecting -= onConnecting;
				this._rdpClient8.OnDisconnected -= onDisconnected;
				this._rdpClient8.OnAutoReconnecting -= onAutoReconnecting;
				this._rdpClient8.OnAutoReconnecting2 -= onAutoReconnecting2;
				this._rdpClient8.OnAutoReconnected -= onAutoReconnected;
				this._rdpClient8.OnFocusReleased -= onFocusReleased;
				return;
			}
			if (this._rdpClient7 != null)
			{
				this._rdpClient7.OnConnected -= onConnected;
				this._rdpClient7.OnConnecting -= onConnecting;
				this._rdpClient7.OnDisconnected -= onDisconnected;
				this._rdpClient7.OnAutoReconnecting -= onAutoReconnecting;
				this._rdpClient7.OnAutoReconnecting2 -= onAutoReconnecting2;
				this._rdpClient7.OnAutoReconnected -= onAutoReconnected;
				this._rdpClient7.OnFocusReleased -= onFocusReleased;
				return;
			}
			if (this._rdpClient6 != null)
			{
				this._rdpClient6.OnConnected -= onConnected;
				this._rdpClient6.OnConnecting -= onConnecting;
				this._rdpClient6.OnDisconnected -= onDisconnected;
				this._rdpClient6.OnAutoReconnecting -= onAutoReconnecting;
				this._rdpClient6.OnAutoReconnecting2 -= onAutoReconnecting2;
				this._rdpClient6.OnAutoReconnected -= onAutoReconnected;
				this._rdpClient6.OnFocusReleased -= onFocusReleased;
				return;
			}
			this._rdpClient5.OnConnected -= onConnected;
			this._rdpClient5.OnConnecting -= onConnecting;
			this._rdpClient5.OnDisconnected -= onDisconnected;
			this._rdpClient5.OnAutoReconnecting -= onAutoReconnecting;
			this._rdpClient5.OnAutoReconnecting2 -= onAutoReconnecting2;
			this._rdpClient5.OnAutoReconnected -= onAutoReconnected;
			this._rdpClient5.OnFocusReleased -= onFocusReleased;
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x0001E7A8 File Offset: 0x0001C9A8
		public void ConnectContainerHandlers(EventHandler onRequestGoFullScreen, EventHandler onRequestLeaveFullScreen, EventHandler onRequestContainerMinimize, IMsTscAxEvents_OnConfirmCloseEventHandler onConfirmClose, IMsTscAxEvents_OnFatalErrorEventHandler onFatalError)
		{
			if (this._rdpClient8 != null)
			{
				this._rdpClient8.OnRequestGoFullScreen += onRequestGoFullScreen;
				this._rdpClient8.OnRequestLeaveFullScreen += onRequestLeaveFullScreen;
				this._rdpClient8.OnRequestContainerMinimize += onRequestContainerMinimize;
				this._rdpClient8.OnConfirmClose += onConfirmClose;
				this._rdpClient8.OnFatalError += onFatalError;
				return;
			}
			if (this._rdpClient7 != null)
			{
				this._rdpClient7.OnRequestGoFullScreen += onRequestGoFullScreen;
				this._rdpClient7.OnRequestLeaveFullScreen += onRequestLeaveFullScreen;
				this._rdpClient7.OnRequestContainerMinimize += onRequestContainerMinimize;
				this._rdpClient7.OnConfirmClose += onConfirmClose;
				this._rdpClient7.OnFatalError += onFatalError;
				return;
			}
			if (this._rdpClient6 != null)
			{
				this._rdpClient6.OnRequestGoFullScreen += onRequestGoFullScreen;
				this._rdpClient6.OnRequestLeaveFullScreen += onRequestLeaveFullScreen;
				this._rdpClient6.OnRequestContainerMinimize += onRequestContainerMinimize;
				this._rdpClient6.OnConfirmClose += onConfirmClose;
				this._rdpClient6.OnFatalError += onFatalError;
				return;
			}
			this._rdpClient5.OnRequestGoFullScreen += onRequestGoFullScreen;
			this._rdpClient5.OnRequestLeaveFullScreen += onRequestLeaveFullScreen;
			this._rdpClient5.OnRequestContainerMinimize += onRequestContainerMinimize;
			this._rdpClient5.OnConfirmClose += onConfirmClose;
			this._rdpClient5.OnFatalError += onFatalError;
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x0001E8C8 File Offset: 0x0001CAC8
		public void DisconnectContainerHandlers(EventHandler onRequestGoFullScreen, EventHandler onRequestLeaveFullScreen, EventHandler onRequestContainerMinimize, IMsTscAxEvents_OnConfirmCloseEventHandler onConfirmClose, IMsTscAxEvents_OnFatalErrorEventHandler onFatalError)
		{
			if (this._rdpClient8 != null)
			{
				this._rdpClient8.OnRequestGoFullScreen -= onRequestGoFullScreen;
				this._rdpClient8.OnRequestLeaveFullScreen -= onRequestLeaveFullScreen;
				this._rdpClient8.OnRequestContainerMinimize -= onRequestContainerMinimize;
				this._rdpClient8.OnConfirmClose -= onConfirmClose;
				this._rdpClient8.OnFatalError -= onFatalError;
				return;
			}
			if (this._rdpClient7 != null)
			{
				this._rdpClient7.OnRequestGoFullScreen -= onRequestGoFullScreen;
				this._rdpClient7.OnRequestLeaveFullScreen -= onRequestLeaveFullScreen;
				this._rdpClient7.OnRequestContainerMinimize -= onRequestContainerMinimize;
				this._rdpClient7.OnConfirmClose -= onConfirmClose;
				this._rdpClient7.OnFatalError -= onFatalError;
				return;
			}
			if (this._rdpClient6 != null)
			{
				this._rdpClient6.OnRequestGoFullScreen -= onRequestGoFullScreen;
				this._rdpClient6.OnRequestLeaveFullScreen -= onRequestLeaveFullScreen;
				this._rdpClient6.OnRequestContainerMinimize -= onRequestContainerMinimize;
				this._rdpClient6.OnConfirmClose -= onConfirmClose;
				this._rdpClient6.OnFatalError -= onFatalError;
				return;
			}
			this._rdpClient5.OnRequestGoFullScreen -= onRequestGoFullScreen;
			this._rdpClient5.OnRequestLeaveFullScreen -= onRequestLeaveFullScreen;
			this._rdpClient5.OnRequestContainerMinimize -= onRequestContainerMinimize;
			this._rdpClient5.OnConfirmClose -= onConfirmClose;
			this._rdpClient5.OnFatalError -= onFatalError;
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x0001E9E8 File Offset: 0x0001CBE8
		public void Dump()
		{
			try
			{
				if (this._rdpClient8 != null)
				{
					Log.DumpObject<IMsRdpClientAdvancedSettings8>(this._rdpClient8.AdvancedSettings9);
					Log.DumpObject<IMsRdpClientSecuredSettings2>(this._rdpClient8.SecuredSettings3);
					Log.DumpObject<IMsRdpClientTransportSettings3>(this._rdpClient8.TransportSettings3);
					Log.DumpObject<IMsRdpClientNonScriptable5>((IMsRdpClientNonScriptable5)this._rdpClient8.GetOcx());
				}
				else if (this._rdpClient7 != null)
				{
					Log.DumpObject<IMsRdpClientAdvancedSettings7>(this._rdpClient7.AdvancedSettings8);
					Log.DumpObject<IMsRdpClientSecuredSettings2>(this._rdpClient7.SecuredSettings3);
					Log.DumpObject<IMsRdpClientTransportSettings3>(this._rdpClient7.TransportSettings3);
					Log.DumpObject<IMsRdpClientNonScriptable5>((IMsRdpClientNonScriptable5)this._rdpClient7.GetOcx());
				}
				else if (this._rdpClient6 != null)
				{
					Log.DumpObject<IMsRdpClientAdvancedSettings6>(this._rdpClient6.AdvancedSettings7);
					Log.DumpObject<IMsRdpClientSecuredSettings>(this._rdpClient6.SecuredSettings2);
					Log.DumpObject<IMsRdpClientTransportSettings2>(this._rdpClient6.TransportSettings2);
					Log.DumpObject<IMsRdpClientNonScriptable4>((IMsRdpClientNonScriptable4)this._rdpClient6.GetOcx());
				}
				else if (this._rdpClient5 != null)
				{
					Log.DumpObject<IMsRdpClientAdvancedSettings5>(this._rdpClient5.AdvancedSettings6);
					Log.DumpObject<IMsRdpClientSecuredSettings>(this._rdpClient5.SecuredSettings2);
					Log.DumpObject<IMsRdpClientTransportSettings>(this._rdpClient5.TransportSettings);
					Log.DumpObject<IMsRdpClientNonScriptable4>((IMsRdpClientNonScriptable4)this._rdpClient5.GetOcx());
				}
			}
			catch
			{
			}
		}

		// Token: 0x04000503 RID: 1283
		public const int DefaultRDPPort = 3389;

		// Token: 0x04000504 RID: 1284
		public const int DefaultVMConsoleConnectPort = 2179;

		// Token: 0x04000505 RID: 1285
		public const int DefaultColorDepth = 24;

		// Token: 0x04000506 RID: 1286
		public const int PerfDisableNothing = 0;

		// Token: 0x04000507 RID: 1287
		public const int PerfDisableWallpaper = 1;

		// Token: 0x04000508 RID: 1288
		public const int PerfDisableFullWindowDrag = 2;

		// Token: 0x04000509 RID: 1289
		public const int PerfDisableMenuAnimations = 4;

		// Token: 0x0400050A RID: 1290
		public const int PerfDisableTheming = 8;

		// Token: 0x0400050B RID: 1291
		public const int PerfEnableEnhancedGraphics = 16;

		// Token: 0x0400050C RID: 1292
		public const int PerfDisableCursorShadow = 32;

		// Token: 0x0400050D RID: 1293
		public const int PerfDisableCursorBlinking = 64;

		// Token: 0x0400050E RID: 1294
		public const int PerfEnableFontSmoothing = 128;

		// Token: 0x0400050F RID: 1295
		public const int PerfEnableDesktopComposition = 256;

		// Token: 0x04000510 RID: 1296
		public static bool SupportsGatewayCredentials;

		// Token: 0x04000511 RID: 1297
		public static bool SupportsAdvancedAudioVideoRedirection;

		// Token: 0x04000512 RID: 1298
		public static bool SupportsMonitorSpanning;

		// Token: 0x04000513 RID: 1299
		public static bool SupportsPanning;

		// Token: 0x04000514 RID: 1300
		public static bool SupportsFineGrainedRedirection;

		// Token: 0x04000515 RID: 1301
		public static bool SupportsRemoteSessionActions;

		// Token: 0x04000516 RID: 1302
		private Server _server;

		// Token: 0x04000517 RID: 1303
		public static int MaxDesktopHeight;

		// Token: 0x04000518 RID: 1304
		public static int MaxDesktopWidth;

		// Token: 0x04000519 RID: 1305
		public static string RdpControlVersion;

		// Token: 0x0400051A RID: 1306
		private static int RdpClientVersion;

		// Token: 0x0400051B RID: 1307
		private static RdpClient StaticClient;

		// Token: 0x0400051C RID: 1308
		private RdpClient5 _rdpClient5;

		// Token: 0x0400051D RID: 1309
		private RdpClient6 _rdpClient6;

		// Token: 0x0400051E RID: 1310
		private RdpClient7 _rdpClient7;

		// Token: 0x0400051F RID: 1311
		private RdpClient8 _rdpClient8;

		// Token: 0x02000128 RID: 296
		public enum ConnectionState
		{
			// Token: 0x04000521 RID: 1313
			Disconnected,
			// Token: 0x04000522 RID: 1314
			Connecting,
			// Token: 0x04000523 RID: 1315
			Connected
		}

		// Token: 0x02000129 RID: 297
		public enum ConnectionBarState
		{
			// Token: 0x04000525 RID: 1317
			AutoHide,
			// Token: 0x04000526 RID: 1318
			Pinned,
			// Token: 0x04000527 RID: 1319
			Off
		}

		// Token: 0x0200012A RID: 298
		public enum AudioRedirectionMode
		{
			// Token: 0x04000529 RID: 1321
			Client,
			// Token: 0x0400052A RID: 1322
			Remote,
			// Token: 0x0400052B RID: 1323
			NoSound
		}

		// Token: 0x0200012B RID: 299
		public enum AudioRedirectionQuality
		{
			// Token: 0x0400052D RID: 1325
			Dynamic,
			// Token: 0x0400052E RID: 1326
			High,
			// Token: 0x0400052F RID: 1327
			Medium
		}

		// Token: 0x0200012C RID: 300
		public enum AudioCaptureRedirectionMode
		{
			// Token: 0x04000531 RID: 1329
			DoNotRecord,
			// Token: 0x04000532 RID: 1330
			Record
		}

		// Token: 0x0200012D RID: 301
		public enum KeyboardHookMode
		{
			// Token: 0x04000534 RID: 1332
			Client,
			// Token: 0x04000535 RID: 1333
			Remote,
			// Token: 0x04000536 RID: 1334
			FullScreenClient
		}

		// Token: 0x0200012E RID: 302
		public enum GatewayUsageMethod
		{
			// Token: 0x04000538 RID: 1336
			NoneDirect,
			// Token: 0x04000539 RID: 1337
			ProxyDirect,
			// Token: 0x0400053A RID: 1338
			ProxyDetect,
			// Token: 0x0400053B RID: 1339
			Default,
			// Token: 0x0400053C RID: 1340
			NoneDetect
		}

		// Token: 0x0200012F RID: 303
		public enum GatewayLogonMethod
		{
			// Token: 0x0400053E RID: 1342
			NTLM,
			// Token: 0x0400053F RID: 1343
			SmartCard,
			// Token: 0x04000540 RID: 1344
			Any = 4
		}

		// Token: 0x02000130 RID: 304
		public enum AuthenticationLevel
		{
			// Token: 0x04000542 RID: 1346
			None,
			// Token: 0x04000543 RID: 1347
			Required,
			// Token: 0x04000544 RID: 1348
			Warn
		}

		// Token: 0x02000131 RID: 305
		// (Invoke) Token: 0x060007A1 RID: 1953
		public delegate void VoidDelegate();
	}
}
