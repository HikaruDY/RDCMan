using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MSTSCLib;

namespace AxMSTSCLib
{
	// Token: 0x020000F2 RID: 242
	[DefaultEvent("OnConnecting")]
	[DesignTimeVisible(true)]
	[AxHost.ClsidAttribute("{a41a4187-5a86-4e26-b40a-856f9035d9cb}")]
	[ComVisible(true)]
	public class AxMsTscAxNotSafeForScripting : AxHost
	{
		// Token: 0x0600086C RID: 2156 RVA: 0x000239C4 File Offset: 0x00021BC4
		public AxMsTscAxNotSafeForScripting() : base("a41a4187-5a86-4e26-b40a-856f9035d9cb")
		{
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x000239D4 File Offset: 0x00021BD4
		// (set) Token: 0x0600086E RID: 2158 RVA: 0x000239F8 File Offset: 0x00021BF8
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(1)]
		public virtual string Server
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("Server", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.Server;
			}
			set
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("Server", AxHost.ActiveXInvokeKind.PropertySet);
				}
				this.ocx.Server = value;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x0600086F RID: 2159 RVA: 0x00023A20 File Offset: 0x00021C20
		// (set) Token: 0x06000870 RID: 2160 RVA: 0x00023A44 File Offset: 0x00021C44
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(2)]
		public virtual string Domain
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("Domain", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.Domain;
			}
			set
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("Domain", AxHost.ActiveXInvokeKind.PropertySet);
				}
				this.ocx.Domain = value;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x00023A6C File Offset: 0x00021C6C
		// (set) Token: 0x06000872 RID: 2162 RVA: 0x00023A90 File Offset: 0x00021C90
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(3)]
		public virtual string UserName
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("UserName", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.UserName;
			}
			set
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("UserName", AxHost.ActiveXInvokeKind.PropertySet);
				}
				this.ocx.UserName = value;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x00023AB8 File Offset: 0x00021CB8
		// (set) Token: 0x06000874 RID: 2164 RVA: 0x00023ADC File Offset: 0x00021CDC
		[DispId(4)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual string DisconnectedText
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("DisconnectedText", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.DisconnectedText;
			}
			set
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("DisconnectedText", AxHost.ActiveXInvokeKind.PropertySet);
				}
				this.ocx.DisconnectedText = value;
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x00023B04 File Offset: 0x00021D04
		// (set) Token: 0x06000876 RID: 2166 RVA: 0x00023B28 File Offset: 0x00021D28
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(5)]
		public virtual string ConnectingText
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("ConnectingText", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.ConnectingText;
			}
			set
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("ConnectingText", AxHost.ActiveXInvokeKind.PropertySet);
				}
				this.ocx.ConnectingText = value;
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x00023B50 File Offset: 0x00021D50
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(6)]
		public virtual short Connected
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("Connected", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.Connected;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000878 RID: 2168 RVA: 0x00023B74 File Offset: 0x00021D74
		// (set) Token: 0x06000879 RID: 2169 RVA: 0x00023B98 File Offset: 0x00021D98
		[DispId(12)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual int DesktopWidth
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("DesktopWidth", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.DesktopWidth;
			}
			set
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("DesktopWidth", AxHost.ActiveXInvokeKind.PropertySet);
				}
				this.ocx.DesktopWidth = value;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x0600087A RID: 2170 RVA: 0x00023BC0 File Offset: 0x00021DC0
		// (set) Token: 0x0600087B RID: 2171 RVA: 0x00023BE4 File Offset: 0x00021DE4
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(13)]
		public virtual int DesktopHeight
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("DesktopHeight", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.DesktopHeight;
			}
			set
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("DesktopHeight", AxHost.ActiveXInvokeKind.PropertySet);
				}
				this.ocx.DesktopHeight = value;
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x0600087C RID: 2172 RVA: 0x00023C0C File Offset: 0x00021E0C
		// (set) Token: 0x0600087D RID: 2173 RVA: 0x00023C30 File Offset: 0x00021E30
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(16)]
		public virtual int StartConnected
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("StartConnected", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.StartConnected;
			}
			set
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("StartConnected", AxHost.ActiveXInvokeKind.PropertySet);
				}
				this.ocx.StartConnected = value;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x0600087E RID: 2174 RVA: 0x00023C58 File Offset: 0x00021E58
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(17)]
		public virtual int HorizontalScrollBarVisible
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("HorizontalScrollBarVisible", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.HorizontalScrollBarVisible;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x0600087F RID: 2175 RVA: 0x00023C7C File Offset: 0x00021E7C
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(18)]
		public virtual int VerticalScrollBarVisible
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("VerticalScrollBarVisible", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.VerticalScrollBarVisible;
			}
		}

		// Token: 0x170001DC RID: 476
		// (set) Token: 0x06000880 RID: 2176 RVA: 0x00023CA0 File Offset: 0x00021EA0
		[DispId(19)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public virtual string FullScreenTitle
		{
			set
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("FullScreenTitle", AxHost.ActiveXInvokeKind.PropertySet);
				}
				this.ocx.FullScreenTitle = value;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000881 RID: 2177 RVA: 0x00023CC8 File Offset: 0x00021EC8
		[DispId(20)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual int CipherStrength
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("CipherStrength", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.CipherStrength;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000882 RID: 2178 RVA: 0x00023CEC File Offset: 0x00021EEC
		[DispId(21)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual string Version
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("Version", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.Version;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000883 RID: 2179 RVA: 0x00023D10 File Offset: 0x00021F10
		[DispId(22)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual int SecuredSettingsEnabled
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("SecuredSettingsEnabled", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.SecuredSettingsEnabled;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000884 RID: 2180 RVA: 0x00023D34 File Offset: 0x00021F34
		[Browsable(false)]
		[DispId(97)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual IMsTscSecuredSettings SecuredSettings
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("SecuredSettings", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.SecuredSettings;
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000885 RID: 2181 RVA: 0x00023D58 File Offset: 0x00021F58
		[DispId(98)]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual IMsTscAdvancedSettings AdvancedSettings
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("AdvancedSettings", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.AdvancedSettings;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000886 RID: 2182 RVA: 0x00023D7C File Offset: 0x00021F7C
		[Browsable(false)]
		[DispId(99)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual IMsTscDebug Debugger
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("Debugger", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.Debugger;
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000887 RID: 2183 RVA: 0x00023DA0 File Offset: 0x00021FA0
		// (remove) Token: 0x06000888 RID: 2184 RVA: 0x00023DDC File Offset: 0x00021FDC
		public event EventHandler OnConnecting;

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000889 RID: 2185 RVA: 0x00023E18 File Offset: 0x00022018
		// (remove) Token: 0x0600088A RID: 2186 RVA: 0x00023E54 File Offset: 0x00022054
		public event EventHandler OnConnected;

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x0600088B RID: 2187 RVA: 0x00023E90 File Offset: 0x00022090
		// (remove) Token: 0x0600088C RID: 2188 RVA: 0x00023ECC File Offset: 0x000220CC
		public event EventHandler OnLoginComplete;

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x0600088D RID: 2189 RVA: 0x00023F08 File Offset: 0x00022108
		// (remove) Token: 0x0600088E RID: 2190 RVA: 0x00023F44 File Offset: 0x00022144
		public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x0600088F RID: 2191 RVA: 0x00023F80 File Offset: 0x00022180
		// (remove) Token: 0x06000890 RID: 2192 RVA: 0x00023FBC File Offset: 0x000221BC
		public event EventHandler OnEnterFullScreenMode;

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06000891 RID: 2193 RVA: 0x00023FF8 File Offset: 0x000221F8
		// (remove) Token: 0x06000892 RID: 2194 RVA: 0x00024034 File Offset: 0x00022234
		public event EventHandler OnLeaveFullScreenMode;

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06000893 RID: 2195 RVA: 0x00024070 File Offset: 0x00022270
		// (remove) Token: 0x06000894 RID: 2196 RVA: 0x000240AC File Offset: 0x000222AC
		public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06000895 RID: 2197 RVA: 0x000240E8 File Offset: 0x000222E8
		// (remove) Token: 0x06000896 RID: 2198 RVA: 0x00024124 File Offset: 0x00022324
		public event EventHandler OnRequestGoFullScreen;

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06000897 RID: 2199 RVA: 0x00024160 File Offset: 0x00022360
		// (remove) Token: 0x06000898 RID: 2200 RVA: 0x0002419C File Offset: 0x0002239C
		public event EventHandler OnRequestLeaveFullScreen;

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06000899 RID: 2201 RVA: 0x000241D8 File Offset: 0x000223D8
		// (remove) Token: 0x0600089A RID: 2202 RVA: 0x00024214 File Offset: 0x00022414
		public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x0600089B RID: 2203 RVA: 0x00024250 File Offset: 0x00022450
		// (remove) Token: 0x0600089C RID: 2204 RVA: 0x0002428C File Offset: 0x0002248C
		public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x0600089D RID: 2205 RVA: 0x000242C8 File Offset: 0x000224C8
		// (remove) Token: 0x0600089E RID: 2206 RVA: 0x00024304 File Offset: 0x00022504
		public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x0600089F RID: 2207 RVA: 0x00024340 File Offset: 0x00022540
		// (remove) Token: 0x060008A0 RID: 2208 RVA: 0x0002437C File Offset: 0x0002257C
		public event EventHandler OnIdleTimeoutNotification;

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x060008A1 RID: 2209 RVA: 0x000243B8 File Offset: 0x000225B8
		// (remove) Token: 0x060008A2 RID: 2210 RVA: 0x000243F4 File Offset: 0x000225F4
		public event EventHandler OnRequestContainerMinimize;

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x060008A3 RID: 2211 RVA: 0x00024430 File Offset: 0x00022630
		// (remove) Token: 0x060008A4 RID: 2212 RVA: 0x0002446C File Offset: 0x0002266C
		public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x060008A5 RID: 2213 RVA: 0x000244A8 File Offset: 0x000226A8
		// (remove) Token: 0x060008A6 RID: 2214 RVA: 0x000244E4 File Offset: 0x000226E4
		public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x060008A7 RID: 2215 RVA: 0x00024520 File Offset: 0x00022720
		// (remove) Token: 0x060008A8 RID: 2216 RVA: 0x0002455C File Offset: 0x0002275C
		public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x060008A9 RID: 2217 RVA: 0x00024598 File Offset: 0x00022798
		// (remove) Token: 0x060008AA RID: 2218 RVA: 0x000245D4 File Offset: 0x000227D4
		public event EventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x060008AB RID: 2219 RVA: 0x00024610 File Offset: 0x00022810
		// (remove) Token: 0x060008AC RID: 2220 RVA: 0x0002464C File Offset: 0x0002284C
		public event EventHandler OnAuthenticationWarningDismissed;

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x060008AD RID: 2221 RVA: 0x00024688 File Offset: 0x00022888
		// (remove) Token: 0x060008AE RID: 2222 RVA: 0x000246C4 File Offset: 0x000228C4
		public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x060008AF RID: 2223 RVA: 0x00024700 File Offset: 0x00022900
		// (remove) Token: 0x060008B0 RID: 2224 RVA: 0x0002473C File Offset: 0x0002293C
		public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x060008B1 RID: 2225 RVA: 0x00024778 File Offset: 0x00022978
		// (remove) Token: 0x060008B2 RID: 2226 RVA: 0x000247B4 File Offset: 0x000229B4
		public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x060008B3 RID: 2227 RVA: 0x000247F0 File Offset: 0x000229F0
		// (remove) Token: 0x060008B4 RID: 2228 RVA: 0x0002482C File Offset: 0x00022A2C
		public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x060008B5 RID: 2229 RVA: 0x00024868 File Offset: 0x00022A68
		// (remove) Token: 0x060008B6 RID: 2230 RVA: 0x000248A4 File Offset: 0x00022AA4
		public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x14000021 RID: 33
		// (add) Token: 0x060008B7 RID: 2231 RVA: 0x000248E0 File Offset: 0x00022AE0
		// (remove) Token: 0x060008B8 RID: 2232 RVA: 0x0002491C File Offset: 0x00022B1C
		public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x14000022 RID: 34
		// (add) Token: 0x060008B9 RID: 2233 RVA: 0x00024958 File Offset: 0x00022B58
		// (remove) Token: 0x060008BA RID: 2234 RVA: 0x00024994 File Offset: 0x00022B94
		public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x14000023 RID: 35
		// (add) Token: 0x060008BB RID: 2235 RVA: 0x000249D0 File Offset: 0x00022BD0
		// (remove) Token: 0x060008BC RID: 2236 RVA: 0x00024A0C File Offset: 0x00022C0C
		public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x14000024 RID: 36
		// (add) Token: 0x060008BD RID: 2237 RVA: 0x00024A48 File Offset: 0x00022C48
		// (remove) Token: 0x060008BE RID: 2238 RVA: 0x00024A84 File Offset: 0x00022C84
		public event EventHandler OnConnectionBarPullDown;

		// Token: 0x14000025 RID: 37
		// (add) Token: 0x060008BF RID: 2239 RVA: 0x00024AC0 File Offset: 0x00022CC0
		// (remove) Token: 0x060008C0 RID: 2240 RVA: 0x00024AFC File Offset: 0x00022CFC
		public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x14000026 RID: 38
		// (add) Token: 0x060008C1 RID: 2241 RVA: 0x00024B38 File Offset: 0x00022D38
		// (remove) Token: 0x060008C2 RID: 2242 RVA: 0x00024B74 File Offset: 0x00022D74
		public event EventHandler OnDevicesButtonPressed;

		// Token: 0x14000027 RID: 39
		// (add) Token: 0x060008C3 RID: 2243 RVA: 0x00024BB0 File Offset: 0x00022DB0
		// (remove) Token: 0x060008C4 RID: 2244 RVA: 0x00024BEC File Offset: 0x00022DEC
		public event EventHandler OnAutoReconnected;

		// Token: 0x14000028 RID: 40
		// (add) Token: 0x060008C5 RID: 2245 RVA: 0x00024C28 File Offset: 0x00022E28
		// (remove) Token: 0x060008C6 RID: 2246 RVA: 0x00024C64 File Offset: 0x00022E64
		public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

		// Token: 0x060008C7 RID: 2247 RVA: 0x00024CA0 File Offset: 0x00022EA0
		public virtual void Connect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Connect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Connect();
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00024CC4 File Offset: 0x00022EC4
		public virtual void Disconnect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Disconnect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Disconnect();
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x00024CE8 File Offset: 0x00022EE8
		public virtual void CreateVirtualChannels(string newVal)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("CreateVirtualChannels", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.CreateVirtualChannels(newVal);
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00024D10 File Offset: 0x00022F10
		public virtual void SendOnVirtualChannel(string chanName, string chanData)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SendOnVirtualChannel", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SendOnVirtualChannel(chanName, chanData);
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00024D38 File Offset: 0x00022F38
		protected override void CreateSink()
		{
			try
			{
				this.eventMulticaster = new AxMsTscAxNotSafeForScriptingEventMulticaster(this);
				this.cookie = new AxHost.ConnectionPointCookie(this.ocx, this.eventMulticaster, typeof(IMsTscAxEvents));
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00024D90 File Offset: 0x00022F90
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

		// Token: 0x060008CD RID: 2253 RVA: 0x00024DC4 File Offset: 0x00022FC4
		protected override void AttachInterfaces()
		{
			try
			{
				this.ocx = (IMsTscAx)base.GetOcx();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00024E00 File Offset: 0x00023000
		internal void RaiseOnOnConnecting(object sender, EventArgs e)
		{
			if (this.OnConnecting != null)
			{
				this.OnConnecting(sender, e);
			}
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x00024E1C File Offset: 0x0002301C
		internal void RaiseOnOnConnected(object sender, EventArgs e)
		{
			if (this.OnConnected != null)
			{
				this.OnConnected(sender, e);
			}
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00024E38 File Offset: 0x00023038
		internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
		{
			if (this.OnLoginComplete != null)
			{
				this.OnLoginComplete(sender, e);
			}
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00024E54 File Offset: 0x00023054
		internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
		{
			if (this.OnDisconnected != null)
			{
				this.OnDisconnected(sender, e);
			}
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00024E70 File Offset: 0x00023070
		internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnEnterFullScreenMode != null)
			{
				this.OnEnterFullScreenMode(sender, e);
			}
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00024E8C File Offset: 0x0002308C
		internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnLeaveFullScreenMode != null)
			{
				this.OnLeaveFullScreenMode(sender, e);
			}
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x00024EA8 File Offset: 0x000230A8
		internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
		{
			if (this.OnChannelReceivedData != null)
			{
				this.OnChannelReceivedData(sender, e);
			}
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x00024EC4 File Offset: 0x000230C4
		internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestGoFullScreen != null)
			{
				this.OnRequestGoFullScreen(sender, e);
			}
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x00024EE0 File Offset: 0x000230E0
		internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestLeaveFullScreen != null)
			{
				this.OnRequestLeaveFullScreen(sender, e);
			}
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x00024EFC File Offset: 0x000230FC
		internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
		{
			if (this.OnFatalError != null)
			{
				this.OnFatalError(sender, e);
			}
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00024F18 File Offset: 0x00023118
		internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
		{
			if (this.OnWarning != null)
			{
				this.OnWarning(sender, e);
			}
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00024F34 File Offset: 0x00023134
		internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
		{
			if (this.OnRemoteDesktopSizeChange != null)
			{
				this.OnRemoteDesktopSizeChange(sender, e);
			}
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x00024F50 File Offset: 0x00023150
		internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
		{
			if (this.OnIdleTimeoutNotification != null)
			{
				this.OnIdleTimeoutNotification(sender, e);
			}
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00024F6C File Offset: 0x0002316C
		internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
		{
			if (this.OnRequestContainerMinimize != null)
			{
				this.OnRequestContainerMinimize(sender, e);
			}
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00024F88 File Offset: 0x00023188
		internal void RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
		{
			if (this.OnConfirmClose != null)
			{
				this.OnConfirmClose(sender, e);
			}
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x00024FA4 File Offset: 0x000231A4
		internal void RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
		{
			if (this.OnReceivedTSPublicKey != null)
			{
				this.OnReceivedTSPublicKey(sender, e);
			}
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x00024FC0 File Offset: 0x000231C0
		internal void RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
		{
			if (this.OnAutoReconnecting != null)
			{
				this.OnAutoReconnecting(sender, e);
			}
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x00024FDC File Offset: 0x000231DC
		internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDisplayed != null)
			{
				this.OnAuthenticationWarningDisplayed(sender, e);
			}
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x00024FF8 File Offset: 0x000231F8
		internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDismissed != null)
			{
				this.OnAuthenticationWarningDismissed(sender, e);
			}
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x00025014 File Offset: 0x00023214
		internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
		{
			if (this.OnRemoteProgramResult != null)
			{
				this.OnRemoteProgramResult(sender, e);
			}
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x00025030 File Offset: 0x00023230
		internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
		{
			if (this.OnRemoteProgramDisplayed != null)
			{
				this.OnRemoteProgramDisplayed(sender, e);
			}
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x0002504C File Offset: 0x0002324C
		internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
		{
			if (this.OnRemoteWindowDisplayed != null)
			{
				this.OnRemoteWindowDisplayed(sender, e);
			}
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00025068 File Offset: 0x00023268
		internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
		{
			if (this.OnLogonError != null)
			{
				this.OnLogonError(sender, e);
			}
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x00025084 File Offset: 0x00023284
		internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
		{
			if (this.OnFocusReleased != null)
			{
				this.OnFocusReleased(sender, e);
			}
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x000250A0 File Offset: 0x000232A0
		internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
		{
			if (this.OnUserNameAcquired != null)
			{
				this.OnUserNameAcquired(sender, e);
			}
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x000250BC File Offset: 0x000232BC
		internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
		{
			if (this.OnMouseInputModeChanged != null)
			{
				this.OnMouseInputModeChanged(sender, e);
			}
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x000250D8 File Offset: 0x000232D8
		internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
		{
			if (this.OnServiceMessageReceived != null)
			{
				this.OnServiceMessageReceived(sender, e);
			}
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x000250F4 File Offset: 0x000232F4
		internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
		{
			if (this.OnConnectionBarPullDown != null)
			{
				this.OnConnectionBarPullDown(sender, e);
			}
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00025110 File Offset: 0x00023310
		internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
		{
			if (this.OnNetworkStatusChanged != null)
			{
				this.OnNetworkStatusChanged(sender, e);
			}
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x0002512C File Offset: 0x0002332C
		internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
		{
			if (this.OnDevicesButtonPressed != null)
			{
				this.OnDevicesButtonPressed(sender, e);
			}
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x00025148 File Offset: 0x00023348
		internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
		{
			if (this.OnAutoReconnected != null)
			{
				this.OnAutoReconnected(sender, e);
			}
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00025164 File Offset: 0x00023364
		internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
		{
			if (this.OnAutoReconnecting2 != null)
			{
				this.OnAutoReconnecting2(sender, e);
			}
		}

		// Token: 0x0400036A RID: 874
		private IMsTscAx ocx;

		// Token: 0x0400036B RID: 875
		private AxMsTscAxNotSafeForScriptingEventMulticaster eventMulticaster;

		// Token: 0x0400036C RID: 876
		private AxHost.ConnectionPointCookie cookie;
	}
}
