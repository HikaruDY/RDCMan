using System;
using System.Drawing;
using System.Windows.Forms;
using AxMSTSCLib;
using MSTSCLib;

namespace RdcMan
{
	public class RdpClient
	{
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

		internal static RdpClient AllocClient(Server server, MainForm form)
		{
			return new RdpClient(form)
			{
				_server = server
			};
		}

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

		public IMsRdpClient MsRdpClient
		{
			get
			{
				return this.GetOcx() as IMsRdpClient;
			}
		}

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

		public IMsRdpClientNonScriptable3 ClientNonScriptable3
		{
			get
			{
				return this.GetOcx() as IMsRdpClientNonScriptable3;
			}
		}

		public IMsRdpClient8 MsRdpClient8
		{
			get
			{
				return this.MsRdpClient as IMsRdpClient8;
			}
		}

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

		public static IMsRdpDriveCollection DriveCollection
		{
			get
			{
				return RdpClient.StaticClient.ClientNonScriptable3.DriveCollection;
			}
		}

		public static IMsRdpDeviceCollection DeviceCollection
		{
			get
			{
				return RdpClient.StaticClient.ClientNonScriptable3.DeviceCollection;
			}
		}

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

		public const int DefaultRDPPort = 3389;

		public const int DefaultVMConsoleConnectPort = 2179;

		public const int DefaultColorDepth = 24;

		public const int PerfDisableNothing = 0;

		public const int PerfDisableWallpaper = 1;

		public const int PerfDisableFullWindowDrag = 2;

		public const int PerfDisableMenuAnimations = 4;

		public const int PerfDisableTheming = 8;

		public const int PerfEnableEnhancedGraphics = 16;

		public const int PerfDisableCursorShadow = 32;

		public const int PerfDisableCursorBlinking = 64;

		public const int PerfEnableFontSmoothing = 128;

		public const int PerfEnableDesktopComposition = 256;

		public static bool SupportsGatewayCredentials;

		public static bool SupportsAdvancedAudioVideoRedirection;

		public static bool SupportsMonitorSpanning;

		public static bool SupportsPanning;

		public static bool SupportsFineGrainedRedirection;

		public static bool SupportsRemoteSessionActions;

		private Server _server;

		public static int MaxDesktopHeight;

		public static int MaxDesktopWidth;

		public static string RdpControlVersion;

		private static int RdpClientVersion;

		private static RdpClient StaticClient;

		private RdpClient5 _rdpClient5;

		private RdpClient6 _rdpClient6;

		private RdpClient7 _rdpClient7;

		private RdpClient8 _rdpClient8;

		private RdpClient9 _rdpClient9;

		private RdpClient10 _rdpClient10;

		public enum ConnectionState
		{
			Disconnected,
			Connecting,
			Connected
		}

		public enum ConnectionBarState
		{
			AutoHide,
			Pinned,
			Off
		}

		public enum AudioRedirectionMode
		{
			Client,
			Remote,
			NoSound
		}

		public enum AudioRedirectionQuality
		{
			Dynamic,
			High,
			Medium
		}

		public enum AudioCaptureRedirectionMode
		{
			DoNotRecord,
			Record
		}

		public enum KeyboardHookMode
		{
			Client,
			Remote,
			FullScreenClient
		}

		public enum GatewayUsageMethod
		{
			NoneDirect,
			ProxyDirect,
			ProxyDetect,
			Default,
			NoneDetect
		}

		public enum GatewayLogonMethod
		{
			NTLM,
			SmartCard,
			Any = 4
		}

		public enum AuthenticationLevel
		{
			None,
			Required,
			Warn
		}

		public enum SmartSizeMethod
		{
			None,
			Scale,
			Reconnect
		}

		public delegate void VoidDelegate();
	}
}
