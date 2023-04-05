using System;
using System.Drawing;
using System.Windows.Forms;
using AxMSTSCLib;
using MSTSCLib;

namespace RdcMan
{
	// Token: 0x020000AB RID: 171
	public class RdpClient
	{
		// Token: 0x06000607 RID: 1543 RVA: 0x0001C534 File Offset: 0x0001A734
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

		// Token: 0x06000608 RID: 1544 RVA: 0x0001C58C File Offset: 0x0001A78C
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

		// Token: 0x06000609 RID: 1545 RVA: 0x0001C5E4 File Offset: 0x0001A7E4
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

		// Token: 0x0600060A RID: 1546 RVA: 0x0001C620 File Offset: 0x0001A820
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

		// Token: 0x0600060B RID: 1547 RVA: 0x0001C678 File Offset: 0x0001A878
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

		// Token: 0x0600060C RID: 1548 RVA: 0x0001C6AC File Offset: 0x0001A8AC
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

		// Token: 0x0600060D RID: 1549 RVA: 0x0001C6E4 File Offset: 0x0001A8E4
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

		// Token: 0x0600060E RID: 1550 RVA: 0x0001C73C File Offset: 0x0001A93C
		public static string SmartSizeMethodToString(RdpClient.SmartSizeMethod method)
		{
			switch (method)
			{
			case RdpClient.SmartSizeMethod.None:
				return "No scaling";
			case RdpClient.SmartSizeMethod.Scale:
				return "Scale to fit window";
			case RdpClient.SmartSizeMethod.Reconnect:
				return "Reconnect with new resolution";
			default:
				throw new Exception("Unexpected SmartSizeMethod:" + method.ToString());
			}
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x0001C794 File Offset: 0x0001A994
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
			case 9:
				this._rdpClient9 = new RdpClient9(form);
				return;
			case 10:
				this._rdpClient10 = new RdpClient10(form);
				return;
			default:
				this._rdpClient5 = new RdpClient5(form);
				return;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000610 RID: 1552 RVA: 0x0001C820 File Offset: 0x0001AA20
		// (set) Token: 0x06000611 RID: 1553 RVA: 0x0001C84C File Offset: 0x0001AA4C
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

		// Token: 0x06000612 RID: 1554 RVA: 0x0001C898 File Offset: 0x0001AA98
		internal static void Initialize(MainForm form)
		{
			using (RdpClient5 rdpClient = new RdpClient5(form))
			{
				RdpClient.RdpControlVersion = rdpClient.Version;
				string[] array = rdpClient.Version.Split(new char[]
				{
					'.'
				});
				int num = int.Parse(array[2]);
				if (num >= 10240)
				{
					RdpClient.RdpClientVersion = 9;
				}
				else if (num >= 9600)
				{
					RdpClient.RdpClientVersion = 9;
				}
				else if (num >= 9200)
				{
					RdpClient.RdpClientVersion = 8;
				}
				else if (num >= 7600)
				{
					RdpClient.RdpClientVersion = 7;
				}
				else if (num >= 6001)
				{
					RdpClient.RdpClientVersion = 6;
				}
				else
				{
					RdpClient.RdpClientVersion = 5;
				}
				if (RdpClient.RdpClientVersion >= 6)
				{
					RdpClient.SupportsMonitorSpanning = true;
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

		// Token: 0x06000613 RID: 1555 RVA: 0x0001CA00 File Offset: 0x0001AC00
		internal static RdpClient AllocClient(Server server, MainForm form)
		{
			return new RdpClient(form)
			{
				_server = server
			};
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x0001CA20 File Offset: 0x0001AC20
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
				axHost = client._rdpClient9;
				if (axHost != null)
				{
					client._rdpClient9 = null;
					axHost.Dispose();
				}
				axHost = client._rdpClient10;
				if (axHost != null)
				{
					client._rdpClient10 = null;
					axHost.Dispose();
				}
			}
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x0001CAF8 File Offset: 0x0001ACF8
		public void SetText()
		{
			if (this._rdpClient10 != null)
			{
				this._rdpClient10.ConnectingText = this._server.ConnectingText;
				this._rdpClient10.DisconnectedText = this._server.DisconnectedText;
				return;
			}
			if (this._rdpClient9 != null)
			{
				this._rdpClient9.ConnectingText = this._server.ConnectingText;
				this._rdpClient9.DisconnectedText = this._server.DisconnectedText;
				return;
			}
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

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x0001CC50 File Offset: 0x0001AE50
		public Control Control
		{
			get
			{
				if (this._rdpClient10 != null)
				{
					return this._rdpClient10;
				}
				if (this._rdpClient9 != null)
				{
					return this._rdpClient9;
				}
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

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000617 RID: 1559 RVA: 0x0001CCC4 File Offset: 0x0001AEC4
		public IMsRdpClient MsRdpClient
		{
			get
			{
				return this.GetOcx() as IMsRdpClient;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000618 RID: 1560 RVA: 0x0001CCD4 File Offset: 0x0001AED4
		public IMsRdpClientAdvancedSettings AdvancedSettings2
		{
			get
			{
				if (this._rdpClient10 != null)
				{
					return this._rdpClient10.AdvancedSettings2;
				}
				if (this._rdpClient9 != null)
				{
					return this._rdpClient9.AdvancedSettings2;
				}
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

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000619 RID: 1561 RVA: 0x0001CD64 File Offset: 0x0001AF64
		public IMsRdpClientAdvancedSettings4 AdvancedSettings5
		{
			get
			{
				if (this._rdpClient10 != null)
				{
					return this._rdpClient10.AdvancedSettings5;
				}
				if (this._rdpClient9 != null)
				{
					return this._rdpClient9.AdvancedSettings5;
				}
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

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600061A RID: 1562 RVA: 0x0001CDF4 File Offset: 0x0001AFF4
		public IMsRdpClientAdvancedSettings5 AdvancedSettings6
		{
			get
			{
				if (this._rdpClient10 != null)
				{
					return this._rdpClient10.AdvancedSettings6;
				}
				if (this._rdpClient9 != null)
				{
					return this._rdpClient9.AdvancedSettings6;
				}
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

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x0001CE84 File Offset: 0x0001B084
		public IMsRdpClientAdvancedSettings6 AdvancedSettings7
		{
			get
			{
				if (this._rdpClient10 != null)
				{
					return this._rdpClient10.AdvancedSettings7;
				}
				if (this._rdpClient9 != null)
				{
					return this._rdpClient9.AdvancedSettings7;
				}
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

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x0001CF0C File Offset: 0x0001B10C
		public IMsRdpClientAdvancedSettings7 AdvancedSettings8
		{
			get
			{
				if (this._rdpClient10 != null)
				{
					return this._rdpClient10.AdvancedSettings8;
				}
				if (this._rdpClient9 != null)
				{
					return this._rdpClient9.AdvancedSettings8;
				}
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

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600061D RID: 1565 RVA: 0x0001CF7C File Offset: 0x0001B17C
		public IMsRdpClientNonScriptable3 ClientNonScriptable3
		{
			get
			{
				return this.GetOcx() as IMsRdpClientNonScriptable3;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600061E RID: 1566 RVA: 0x0001CF8C File Offset: 0x0001B18C
		public IMsRdpClient8 MsRdpClient8
		{
			get
			{
				return this.MsRdpClient as IMsRdpClient8;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600061F RID: 1567 RVA: 0x0001CF9C File Offset: 0x0001B19C
		public IMsRdpClientTransportSettings TransportSettings
		{
			get
			{
				if (this._rdpClient10 != null)
				{
					return this._rdpClient10.TransportSettings;
				}
				if (this._rdpClient9 != null)
				{
					return this._rdpClient9.TransportSettings;
				}
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

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x0001D02C File Offset: 0x0001B22C
		public IMsRdpClientTransportSettings2 TransportSettings2
		{
			get
			{
				if (this._rdpClient10 != null)
				{
					return this._rdpClient10.TransportSettings2;
				}
				if (this._rdpClient9 != null)
				{
					return this._rdpClient9.TransportSettings2;
				}
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

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000621 RID: 1569 RVA: 0x0001D0B4 File Offset: 0x0001B2B4
		public IMsTscSecuredSettings SecuredSettings
		{
			get
			{
				if (this._rdpClient10 != null)
				{
					return this._rdpClient10.SecuredSettings;
				}
				if (this._rdpClient9 != null)
				{
					return this._rdpClient9.SecuredSettings;
				}
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

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000622 RID: 1570 RVA: 0x0001D144 File Offset: 0x0001B344
		public IMsRdpClientSecuredSettings SecuredSettings2
		{
			get
			{
				if (this._rdpClient10 != null)
				{
					return this._rdpClient10.SecuredSettings2;
				}
				if (this._rdpClient9 != null)
				{
					return this._rdpClient9.SecuredSettings2;
				}
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

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x0001D1D4 File Offset: 0x0001B3D4
		public ITSRemoteProgram RemoteProgram
		{
			get
			{
				if (this._rdpClient10 != null)
				{
					return this._rdpClient10.RemoteProgram;
				}
				if (this._rdpClient9 != null)
				{
					return this._rdpClient9.RemoteProgram;
				}
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

		// Token: 0x06000624 RID: 1572 RVA: 0x0001D264 File Offset: 0x0001B464
		public object GetOcx()
		{
			if (this._rdpClient10 != null)
			{
				return this._rdpClient10.GetOcx();
			}
			if (this._rdpClient9 != null)
			{
				return this._rdpClient9.GetOcx();
			}
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

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x0001D2F4 File Offset: 0x0001B4F4
		public static IMsRdpDriveCollection DriveCollection
		{
			get
			{
				return RdpClient.StaticClient.ClientNonScriptable3.DriveCollection;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000626 RID: 1574 RVA: 0x0001D308 File Offset: 0x0001B508
		public static IMsRdpDeviceCollection DeviceCollection
		{
			get
			{
				return RdpClient.StaticClient.ClientNonScriptable3.DeviceCollection;
			}
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x0001D31C File Offset: 0x0001B51C
		public void ConnectConnectionHandlers(EventHandler onConnected, EventHandler onConnecting, AxMSTSCLib.IMsTscAxEvents_OnDisconnectedEventHandler onDisconnected, AxMSTSCLib.IMsTscAxEvents_OnAutoReconnectingEventHandler onAutoReconnecting, AxMSTSCLib.IMsTscAxEvents_OnAutoReconnecting2EventHandler onAutoReconnecting2, EventHandler onAutoReconnected, AxMSTSCLib.IMsTscAxEvents_OnFocusReleasedEventHandler onFocusReleased)
		{
			if (this._rdpClient10 != null)
			{
				this._rdpClient10.OnConnected += onConnected;
				this._rdpClient10.OnConnecting += onConnecting;
				this._rdpClient10.OnDisconnected += onDisconnected;
				this._rdpClient10.OnAutoReconnecting += onAutoReconnecting;
				this._rdpClient10.OnAutoReconnecting2 += onAutoReconnecting2;
				this._rdpClient10.OnAutoReconnected += onAutoReconnected;
				this._rdpClient10.OnFocusReleased += onFocusReleased;
				return;
			}
			if (this._rdpClient9 != null)
			{
				this._rdpClient9.OnConnected += onConnected;
				this._rdpClient9.OnConnecting += onConnecting;
				this._rdpClient9.OnDisconnected += onDisconnected;
				this._rdpClient9.OnAutoReconnecting += onAutoReconnecting;
				this._rdpClient9.OnAutoReconnecting2 += onAutoReconnecting2;
				this._rdpClient9.OnAutoReconnected += onAutoReconnected;
				this._rdpClient9.OnFocusReleased += onFocusReleased;
				return;
			}
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

		// Token: 0x06000628 RID: 1576 RVA: 0x0001D57C File Offset: 0x0001B77C
		public void DisconnectConnectionHandlers(EventHandler onConnected, EventHandler onConnecting, AxMSTSCLib.IMsTscAxEvents_OnDisconnectedEventHandler onDisconnected, AxMSTSCLib.IMsTscAxEvents_OnAutoReconnectingEventHandler onAutoReconnecting, AxMSTSCLib.IMsTscAxEvents_OnAutoReconnecting2EventHandler onAutoReconnecting2, EventHandler onAutoReconnected, AxMSTSCLib.IMsTscAxEvents_OnFocusReleasedEventHandler onFocusReleased)
		{
			if (this._rdpClient10 != null)
			{
				this._rdpClient10.OnConnected -= onConnected;
				this._rdpClient10.OnConnecting -= onConnecting;
				this._rdpClient10.OnDisconnected -= onDisconnected;
				this._rdpClient10.OnAutoReconnecting -= onAutoReconnecting;
				this._rdpClient10.OnAutoReconnecting2 -= onAutoReconnecting2;
				this._rdpClient10.OnAutoReconnected -= onAutoReconnected;
				this._rdpClient10.OnFocusReleased -= onFocusReleased;
				return;
			}
			if (this._rdpClient9 != null)
			{
				this._rdpClient9.OnConnected -= onConnected;
				this._rdpClient9.OnConnecting -= onConnecting;
				this._rdpClient9.OnDisconnected -= onDisconnected;
				this._rdpClient9.OnAutoReconnecting -= onAutoReconnecting;
				this._rdpClient9.OnAutoReconnecting2 -= onAutoReconnecting2;
				this._rdpClient9.OnAutoReconnected -= onAutoReconnected;
				this._rdpClient9.OnFocusReleased -= onFocusReleased;
				return;
			}
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

		// Token: 0x06000629 RID: 1577 RVA: 0x0001D7DC File Offset: 0x0001B9DC
		public void ConnectContainerHandlers(EventHandler onRequestGoFullScreen, EventHandler onRequestLeaveFullScreen, EventHandler onRequestContainerMinimize, AxMSTSCLib.IMsTscAxEvents_OnConfirmCloseEventHandler onConfirmClose, AxMSTSCLib.IMsTscAxEvents_OnFatalErrorEventHandler onFatalError)
		{
			if (this._rdpClient10 != null)
			{
				this._rdpClient10.OnRequestGoFullScreen += onRequestGoFullScreen;
				this._rdpClient10.OnRequestLeaveFullScreen += onRequestLeaveFullScreen;
				this._rdpClient10.OnRequestContainerMinimize += onRequestContainerMinimize;
				this._rdpClient10.OnConfirmClose += onConfirmClose;
				this._rdpClient10.OnFatalError += onFatalError;
				return;
			}
			if (this._rdpClient9 != null)
			{
				this._rdpClient9.OnRequestGoFullScreen += onRequestGoFullScreen;
				this._rdpClient9.OnRequestLeaveFullScreen += onRequestLeaveFullScreen;
				this._rdpClient9.OnRequestContainerMinimize += onRequestContainerMinimize;
				this._rdpClient9.OnConfirmClose += onConfirmClose;
				this._rdpClient9.OnFatalError += onFatalError;
				return;
			}
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

		// Token: 0x0600062A RID: 1578 RVA: 0x0001D9A0 File Offset: 0x0001BBA0
		public void DisconnectContainerHandlers(EventHandler onRequestGoFullScreen, EventHandler onRequestLeaveFullScreen, EventHandler onRequestContainerMinimize, AxMSTSCLib.IMsTscAxEvents_OnConfirmCloseEventHandler onConfirmClose, AxMSTSCLib.IMsTscAxEvents_OnFatalErrorEventHandler onFatalError)
		{
			if (this._rdpClient10 != null)
			{
				this._rdpClient10.OnRequestGoFullScreen -= onRequestGoFullScreen;
				this._rdpClient10.OnRequestLeaveFullScreen -= onRequestLeaveFullScreen;
				this._rdpClient10.OnRequestContainerMinimize -= onRequestContainerMinimize;
				this._rdpClient10.OnConfirmClose -= onConfirmClose;
				this._rdpClient10.OnFatalError -= onFatalError;
				return;
			}
			if (this._rdpClient9 != null)
			{
				this._rdpClient9.OnRequestGoFullScreen -= onRequestGoFullScreen;
				this._rdpClient9.OnRequestLeaveFullScreen -= onRequestLeaveFullScreen;
				this._rdpClient9.OnRequestContainerMinimize -= onRequestContainerMinimize;
				this._rdpClient9.OnConfirmClose -= onConfirmClose;
				this._rdpClient9.OnFatalError -= onFatalError;
				return;
			}
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

		// Token: 0x0600062B RID: 1579 RVA: 0x0001DB64 File Offset: 0x0001BD64
		public void Dump()
		{
			try
			{
				if (this._rdpClient10 != null)
				{
					Log.DumpObject<IMsRdpClientAdvancedSettings8>(this._rdpClient10.AdvancedSettings9);
					Log.DumpObject<IMsRdpClientSecuredSettings2>(this._rdpClient10.SecuredSettings3);
					Log.DumpObject<IMsRdpClientTransportSettings3>(this._rdpClient10.TransportSettings3);
					Log.DumpObject<IMsRdpClientNonScriptable5>((IMsRdpClientNonScriptable5)this._rdpClient10.GetOcx());
				}
				else if (this._rdpClient9 != null)
				{
					Log.DumpObject<IMsRdpClientAdvancedSettings8>(this._rdpClient9.AdvancedSettings9);
					Log.DumpObject<IMsRdpClientSecuredSettings2>(this._rdpClient9.SecuredSettings3);
					Log.DumpObject<IMsRdpClientTransportSettings3>(this._rdpClient9.TransportSettings3);
					Log.DumpObject<IMsRdpClientNonScriptable5>((IMsRdpClientNonScriptable5)this._rdpClient9.GetOcx());
				}
				else if (this._rdpClient8 != null)
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

		// Token: 0x0600062C RID: 1580 RVA: 0x0001DD94 File Offset: 0x0001BF94
		public bool Resize(uint width, uint height)
		{
			if (this._rdpClient10 != null)
			{
				this._rdpClient10.Reconnect(width, height);
				return true;
			}
			if (this._rdpClient9 != null)
			{
				this._rdpClient9.Reconnect(width, height);
				return true;
			}
			if (this._rdpClient8 != null)
			{
				this._rdpClient8.Reconnect(width, height);
				return true;
			}
			return false;
		}

		// Token: 0x04000227 RID: 551
		public const int DefaultRDPPort = 3389;

		// Token: 0x04000228 RID: 552
		public const int DefaultVMConsoleConnectPort = 2179;

		// Token: 0x04000229 RID: 553
		public const int DefaultColorDepth = 24;

		// Token: 0x0400022A RID: 554
		public const int PerfDisableNothing = 0;

		// Token: 0x0400022B RID: 555
		public const int PerfDisableWallpaper = 1;

		// Token: 0x0400022C RID: 556
		public const int PerfDisableFullWindowDrag = 2;

		// Token: 0x0400022D RID: 557
		public const int PerfDisableMenuAnimations = 4;

		// Token: 0x0400022E RID: 558
		public const int PerfDisableTheming = 8;

		// Token: 0x0400022F RID: 559
		public const int PerfEnableEnhancedGraphics = 16;

		// Token: 0x04000230 RID: 560
		public const int PerfDisableCursorShadow = 32;

		// Token: 0x04000231 RID: 561
		public const int PerfDisableCursorBlinking = 64;

		// Token: 0x04000232 RID: 562
		public const int PerfEnableFontSmoothing = 128;

		// Token: 0x04000233 RID: 563
		public const int PerfEnableDesktopComposition = 256;

		// Token: 0x04000234 RID: 564
		public static bool SupportsGatewayCredentials;

		// Token: 0x04000235 RID: 565
		public static bool SupportsAdvancedAudioVideoRedirection;

		// Token: 0x04000236 RID: 566
		public static bool SupportsMonitorSpanning;

		// Token: 0x04000237 RID: 567
		public static bool SupportsPanning;

		// Token: 0x04000238 RID: 568
		public static bool SupportsFineGrainedRedirection;

		// Token: 0x04000239 RID: 569
		public static bool SupportsRemoteSessionActions;

		// Token: 0x0400023A RID: 570
		private Server _server;

		// Token: 0x0400023B RID: 571
		public static int MaxDesktopHeight;

		// Token: 0x0400023C RID: 572
		public static int MaxDesktopWidth;

		// Token: 0x0400023D RID: 573
		public static string RdpControlVersion;

		// Token: 0x0400023E RID: 574
		private static int RdpClientVersion;

		// Token: 0x0400023F RID: 575
		private static RdpClient StaticClient;

		// Token: 0x04000240 RID: 576
		private RdpClient5 _rdpClient5;

		// Token: 0x04000241 RID: 577
		private RdpClient6 _rdpClient6;

		// Token: 0x04000242 RID: 578
		private RdpClient7 _rdpClient7;

		// Token: 0x04000243 RID: 579
		private RdpClient8 _rdpClient8;

		// Token: 0x04000244 RID: 580
		private RdpClient9 _rdpClient9;

		// Token: 0x04000245 RID: 581
		private RdpClient10 _rdpClient10;

		// Token: 0x02000294 RID: 660
		public enum ConnectionState
		{
			// Token: 0x04000AF9 RID: 2809
			Disconnected,
			// Token: 0x04000AFA RID: 2810
			Connecting,
			// Token: 0x04000AFB RID: 2811
			Connected
		}

		// Token: 0x02000295 RID: 661
		public enum ConnectionBarState
		{
			// Token: 0x04000AFD RID: 2813
			AutoHide,
			// Token: 0x04000AFE RID: 2814
			Pinned,
			// Token: 0x04000AFF RID: 2815
			Off
		}

		// Token: 0x02000296 RID: 662
		public enum AudioRedirectionMode
		{
			// Token: 0x04000B01 RID: 2817
			Client,
			// Token: 0x04000B02 RID: 2818
			Remote,
			// Token: 0x04000B03 RID: 2819
			NoSound
		}

		// Token: 0x02000297 RID: 663
		public enum AudioRedirectionQuality
		{
			// Token: 0x04000B05 RID: 2821
			Dynamic,
			// Token: 0x04000B06 RID: 2822
			High,
			// Token: 0x04000B07 RID: 2823
			Medium
		}

		// Token: 0x02000298 RID: 664
		public enum AudioCaptureRedirectionMode
		{
			// Token: 0x04000B09 RID: 2825
			DoNotRecord,
			// Token: 0x04000B0A RID: 2826
			Record
		}

		// Token: 0x02000299 RID: 665
		public enum KeyboardHookMode
		{
			// Token: 0x04000B0C RID: 2828
			Client,
			// Token: 0x04000B0D RID: 2829
			Remote,
			// Token: 0x04000B0E RID: 2830
			FullScreenClient
		}

		// Token: 0x0200029A RID: 666
		public enum GatewayUsageMethod
		{
			// Token: 0x04000B10 RID: 2832
			NoneDirect,
			// Token: 0x04000B11 RID: 2833
			ProxyDirect,
			// Token: 0x04000B12 RID: 2834
			ProxyDetect,
			// Token: 0x04000B13 RID: 2835
			Default,
			// Token: 0x04000B14 RID: 2836
			NoneDetect
		}

		// Token: 0x0200029B RID: 667
		public enum GatewayLogonMethod
		{
			// Token: 0x04000B16 RID: 2838
			NTLM,
			// Token: 0x04000B17 RID: 2839
			SmartCard,
			// Token: 0x04000B18 RID: 2840
			Any = 4
		}

		// Token: 0x0200029C RID: 668
		public enum AuthenticationLevel
		{
			// Token: 0x04000B1A RID: 2842
			None,
			// Token: 0x04000B1B RID: 2843
			Required,
			// Token: 0x04000B1C RID: 2844
			Warn
		}

		// Token: 0x0200029D RID: 669
		public enum SmartSizeMethod
		{
			// Token: 0x04000B1E RID: 2846
			None,
			// Token: 0x04000B1F RID: 2847
			Scale,
			// Token: 0x04000B20 RID: 2848
			Reconnect
		}

		// Token: 0x0200029E RID: 670
		// (Invoke) Token: 0x06005722 RID: 22306
		public delegate void VoidDelegate();
	}
}
