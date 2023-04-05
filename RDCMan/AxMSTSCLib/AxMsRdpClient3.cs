using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MSTSCLib;

namespace AxMSTSCLib
{
	// Token: 0x02000122 RID: 290
	[DefaultEvent("OnConnecting")]
	[AxHost.ClsidAttribute("{7584c670-2274-4efb-b00b-d6aaba6d3850}")]
	[DesignTimeVisible(true)]
	[ComVisible(true)]
	public class AxMsRdpClient3 : AxHost
	{
		// Token: 0x06000CD7 RID: 3287 RVA: 0x0002F61C File Offset: 0x0002D81C
		public AxMsRdpClient3() : base("7584c670-2274-4efb-b00b-d6aaba6d3850")
		{
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000CD8 RID: 3288 RVA: 0x0002F62C File Offset: 0x0002D82C
		// (set) Token: 0x06000CD9 RID: 3289 RVA: 0x0002F650 File Offset: 0x0002D850
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

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000CDA RID: 3290 RVA: 0x0002F678 File Offset: 0x0002D878
		// (set) Token: 0x06000CDB RID: 3291 RVA: 0x0002F69C File Offset: 0x0002D89C
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

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000CDC RID: 3292 RVA: 0x0002F6C4 File Offset: 0x0002D8C4
		// (set) Token: 0x06000CDD RID: 3293 RVA: 0x0002F6E8 File Offset: 0x0002D8E8
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

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000CDE RID: 3294 RVA: 0x0002F710 File Offset: 0x0002D910
		// (set) Token: 0x06000CDF RID: 3295 RVA: 0x0002F734 File Offset: 0x0002D934
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(4)]
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

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000CE0 RID: 3296 RVA: 0x0002F75C File Offset: 0x0002D95C
		// (set) Token: 0x06000CE1 RID: 3297 RVA: 0x0002F780 File Offset: 0x0002D980
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

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000CE2 RID: 3298 RVA: 0x0002F7A8 File Offset: 0x0002D9A8
		[DispId(6)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x0002F7CC File Offset: 0x0002D9CC
		// (set) Token: 0x06000CE4 RID: 3300 RVA: 0x0002F7F0 File Offset: 0x0002D9F0
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(12)]
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

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x0002F818 File Offset: 0x0002DA18
		// (set) Token: 0x06000CE6 RID: 3302 RVA: 0x0002F83C File Offset: 0x0002DA3C
		[DispId(13)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000CE7 RID: 3303 RVA: 0x0002F864 File Offset: 0x0002DA64
		// (set) Token: 0x06000CE8 RID: 3304 RVA: 0x0002F888 File Offset: 0x0002DA88
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

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x0002F8B0 File Offset: 0x0002DAB0
		[DispId(17)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000CEA RID: 3306 RVA: 0x0002F8D4 File Offset: 0x0002DAD4
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

		// Token: 0x1700026A RID: 618
		// (set) Token: 0x06000CEB RID: 3307 RVA: 0x0002F8F8 File Offset: 0x0002DAF8
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(19)]
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

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000CEC RID: 3308 RVA: 0x0002F920 File Offset: 0x0002DB20
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

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000CED RID: 3309 RVA: 0x0002F944 File Offset: 0x0002DB44
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(21)]
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

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000CEE RID: 3310 RVA: 0x0002F968 File Offset: 0x0002DB68
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

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000CEF RID: 3311 RVA: 0x0002F98C File Offset: 0x0002DB8C
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(97)]
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

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000CF0 RID: 3312 RVA: 0x0002F9B0 File Offset: 0x0002DBB0
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(98)]
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

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000CF1 RID: 3313 RVA: 0x0002F9D4 File Offset: 0x0002DBD4
		[DispId(99)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
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

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000CF2 RID: 3314 RVA: 0x0002F9F8 File Offset: 0x0002DBF8
		// (set) Token: 0x06000CF3 RID: 3315 RVA: 0x0002FA1C File Offset: 0x0002DC1C
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(100)]
		public virtual int ColorDepth
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("ColorDepth", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.ColorDepth;
			}
			set
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("ColorDepth", AxHost.ActiveXInvokeKind.PropertySet);
				}
				this.ocx.ColorDepth = value;
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000CF4 RID: 3316 RVA: 0x0002FA44 File Offset: 0x0002DC44
		[Browsable(false)]
		[DispId(101)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual IMsRdpClientAdvancedSettings AdvancedSettings2
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("AdvancedSettings2", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.AdvancedSettings2;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000CF5 RID: 3317 RVA: 0x0002FA68 File Offset: 0x0002DC68
		[Browsable(false)]
		[DispId(102)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual IMsRdpClientSecuredSettings SecuredSettings2
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("SecuredSettings2", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.SecuredSettings2;
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000CF6 RID: 3318 RVA: 0x0002FA8C File Offset: 0x0002DC8C
		[DispId(103)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual ExtendedDisconnectReasonCode ExtendedDisconnectReason
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("ExtendedDisconnectReason", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.ExtendedDisconnectReason;
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000CF7 RID: 3319 RVA: 0x0002FAB0 File Offset: 0x0002DCB0
		// (set) Token: 0x06000CF8 RID: 3320 RVA: 0x0002FAD4 File Offset: 0x0002DCD4
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(104)]
		public virtual bool FullScreen
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("FullScreen", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.FullScreen;
			}
			set
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("FullScreen", AxHost.ActiveXInvokeKind.PropertySet);
				}
				this.ocx.FullScreen = value;
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000CF9 RID: 3321 RVA: 0x0002FAFC File Offset: 0x0002DCFC
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		[DispId(200)]
		public virtual IMsRdpClientAdvancedSettings2 AdvancedSettings3
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("AdvancedSettings3", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.AdvancedSettings3;
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000CFA RID: 3322 RVA: 0x0002FB20 File Offset: 0x0002DD20
		// (set) Token: 0x06000CFB RID: 3323 RVA: 0x0002FB44 File Offset: 0x0002DD44
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(201)]
		public virtual string ConnectedStatusText
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("ConnectedStatusText", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.ConnectedStatusText;
			}
			set
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("ConnectedStatusText", AxHost.ActiveXInvokeKind.PropertySet);
				}
				this.ocx.ConnectedStatusText = value;
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000CFC RID: 3324 RVA: 0x0002FB6C File Offset: 0x0002DD6C
		[DispId(300)]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual IMsRdpClientAdvancedSettings3 AdvancedSettings4
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("AdvancedSettings4", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.AdvancedSettings4;
			}
		}

		// Token: 0x140000C9 RID: 201
		// (add) Token: 0x06000CFD RID: 3325 RVA: 0x0002FB90 File Offset: 0x0002DD90
		// (remove) Token: 0x06000CFE RID: 3326 RVA: 0x0002FBCC File Offset: 0x0002DDCC
		public event EventHandler OnConnecting;

		// Token: 0x140000CA RID: 202
		// (add) Token: 0x06000CFF RID: 3327 RVA: 0x0002FC08 File Offset: 0x0002DE08
		// (remove) Token: 0x06000D00 RID: 3328 RVA: 0x0002FC44 File Offset: 0x0002DE44
		public event EventHandler OnConnected;

		// Token: 0x140000CB RID: 203
		// (add) Token: 0x06000D01 RID: 3329 RVA: 0x0002FC80 File Offset: 0x0002DE80
		// (remove) Token: 0x06000D02 RID: 3330 RVA: 0x0002FCBC File Offset: 0x0002DEBC
		public event EventHandler OnLoginComplete;

		// Token: 0x140000CC RID: 204
		// (add) Token: 0x06000D03 RID: 3331 RVA: 0x0002FCF8 File Offset: 0x0002DEF8
		// (remove) Token: 0x06000D04 RID: 3332 RVA: 0x0002FD34 File Offset: 0x0002DF34
		public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x140000CD RID: 205
		// (add) Token: 0x06000D05 RID: 3333 RVA: 0x0002FD70 File Offset: 0x0002DF70
		// (remove) Token: 0x06000D06 RID: 3334 RVA: 0x0002FDAC File Offset: 0x0002DFAC
		public event EventHandler OnEnterFullScreenMode;

		// Token: 0x140000CE RID: 206
		// (add) Token: 0x06000D07 RID: 3335 RVA: 0x0002FDE8 File Offset: 0x0002DFE8
		// (remove) Token: 0x06000D08 RID: 3336 RVA: 0x0002FE24 File Offset: 0x0002E024
		public event EventHandler OnLeaveFullScreenMode;

		// Token: 0x140000CF RID: 207
		// (add) Token: 0x06000D09 RID: 3337 RVA: 0x0002FE60 File Offset: 0x0002E060
		// (remove) Token: 0x06000D0A RID: 3338 RVA: 0x0002FE9C File Offset: 0x0002E09C
		public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x140000D0 RID: 208
		// (add) Token: 0x06000D0B RID: 3339 RVA: 0x0002FED8 File Offset: 0x0002E0D8
		// (remove) Token: 0x06000D0C RID: 3340 RVA: 0x0002FF14 File Offset: 0x0002E114
		public event EventHandler OnRequestGoFullScreen;

		// Token: 0x140000D1 RID: 209
		// (add) Token: 0x06000D0D RID: 3341 RVA: 0x0002FF50 File Offset: 0x0002E150
		// (remove) Token: 0x06000D0E RID: 3342 RVA: 0x0002FF8C File Offset: 0x0002E18C
		public event EventHandler OnRequestLeaveFullScreen;

		// Token: 0x140000D2 RID: 210
		// (add) Token: 0x06000D0F RID: 3343 RVA: 0x0002FFC8 File Offset: 0x0002E1C8
		// (remove) Token: 0x06000D10 RID: 3344 RVA: 0x00030004 File Offset: 0x0002E204
		public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x140000D3 RID: 211
		// (add) Token: 0x06000D11 RID: 3345 RVA: 0x00030040 File Offset: 0x0002E240
		// (remove) Token: 0x06000D12 RID: 3346 RVA: 0x0003007C File Offset: 0x0002E27C
		public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x140000D4 RID: 212
		// (add) Token: 0x06000D13 RID: 3347 RVA: 0x000300B8 File Offset: 0x0002E2B8
		// (remove) Token: 0x06000D14 RID: 3348 RVA: 0x000300F4 File Offset: 0x0002E2F4
		public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x140000D5 RID: 213
		// (add) Token: 0x06000D15 RID: 3349 RVA: 0x00030130 File Offset: 0x0002E330
		// (remove) Token: 0x06000D16 RID: 3350 RVA: 0x0003016C File Offset: 0x0002E36C
		public event EventHandler OnIdleTimeoutNotification;

		// Token: 0x140000D6 RID: 214
		// (add) Token: 0x06000D17 RID: 3351 RVA: 0x000301A8 File Offset: 0x0002E3A8
		// (remove) Token: 0x06000D18 RID: 3352 RVA: 0x000301E4 File Offset: 0x0002E3E4
		public event EventHandler OnRequestContainerMinimize;

		// Token: 0x140000D7 RID: 215
		// (add) Token: 0x06000D19 RID: 3353 RVA: 0x00030220 File Offset: 0x0002E420
		// (remove) Token: 0x06000D1A RID: 3354 RVA: 0x0003025C File Offset: 0x0002E45C
		public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x140000D8 RID: 216
		// (add) Token: 0x06000D1B RID: 3355 RVA: 0x00030298 File Offset: 0x0002E498
		// (remove) Token: 0x06000D1C RID: 3356 RVA: 0x000302D4 File Offset: 0x0002E4D4
		public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x140000D9 RID: 217
		// (add) Token: 0x06000D1D RID: 3357 RVA: 0x00030310 File Offset: 0x0002E510
		// (remove) Token: 0x06000D1E RID: 3358 RVA: 0x0003034C File Offset: 0x0002E54C
		public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x140000DA RID: 218
		// (add) Token: 0x06000D1F RID: 3359 RVA: 0x00030388 File Offset: 0x0002E588
		// (remove) Token: 0x06000D20 RID: 3360 RVA: 0x000303C4 File Offset: 0x0002E5C4
		public event EventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x140000DB RID: 219
		// (add) Token: 0x06000D21 RID: 3361 RVA: 0x00030400 File Offset: 0x0002E600
		// (remove) Token: 0x06000D22 RID: 3362 RVA: 0x0003043C File Offset: 0x0002E63C
		public event EventHandler OnAuthenticationWarningDismissed;

		// Token: 0x140000DC RID: 220
		// (add) Token: 0x06000D23 RID: 3363 RVA: 0x00030478 File Offset: 0x0002E678
		// (remove) Token: 0x06000D24 RID: 3364 RVA: 0x000304B4 File Offset: 0x0002E6B4
		public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x140000DD RID: 221
		// (add) Token: 0x06000D25 RID: 3365 RVA: 0x000304F0 File Offset: 0x0002E6F0
		// (remove) Token: 0x06000D26 RID: 3366 RVA: 0x0003052C File Offset: 0x0002E72C
		public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x140000DE RID: 222
		// (add) Token: 0x06000D27 RID: 3367 RVA: 0x00030568 File Offset: 0x0002E768
		// (remove) Token: 0x06000D28 RID: 3368 RVA: 0x000305A4 File Offset: 0x0002E7A4
		public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x140000DF RID: 223
		// (add) Token: 0x06000D29 RID: 3369 RVA: 0x000305E0 File Offset: 0x0002E7E0
		// (remove) Token: 0x06000D2A RID: 3370 RVA: 0x0003061C File Offset: 0x0002E81C
		public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x140000E0 RID: 224
		// (add) Token: 0x06000D2B RID: 3371 RVA: 0x00030658 File Offset: 0x0002E858
		// (remove) Token: 0x06000D2C RID: 3372 RVA: 0x00030694 File Offset: 0x0002E894
		public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x140000E1 RID: 225
		// (add) Token: 0x06000D2D RID: 3373 RVA: 0x000306D0 File Offset: 0x0002E8D0
		// (remove) Token: 0x06000D2E RID: 3374 RVA: 0x0003070C File Offset: 0x0002E90C
		public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x140000E2 RID: 226
		// (add) Token: 0x06000D2F RID: 3375 RVA: 0x00030748 File Offset: 0x0002E948
		// (remove) Token: 0x06000D30 RID: 3376 RVA: 0x00030784 File Offset: 0x0002E984
		public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x140000E3 RID: 227
		// (add) Token: 0x06000D31 RID: 3377 RVA: 0x000307C0 File Offset: 0x0002E9C0
		// (remove) Token: 0x06000D32 RID: 3378 RVA: 0x000307FC File Offset: 0x0002E9FC
		public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x140000E4 RID: 228
		// (add) Token: 0x06000D33 RID: 3379 RVA: 0x00030838 File Offset: 0x0002EA38
		// (remove) Token: 0x06000D34 RID: 3380 RVA: 0x00030874 File Offset: 0x0002EA74
		public event EventHandler OnConnectionBarPullDown;

		// Token: 0x140000E5 RID: 229
		// (add) Token: 0x06000D35 RID: 3381 RVA: 0x000308B0 File Offset: 0x0002EAB0
		// (remove) Token: 0x06000D36 RID: 3382 RVA: 0x000308EC File Offset: 0x0002EAEC
		public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x140000E6 RID: 230
		// (add) Token: 0x06000D37 RID: 3383 RVA: 0x00030928 File Offset: 0x0002EB28
		// (remove) Token: 0x06000D38 RID: 3384 RVA: 0x00030964 File Offset: 0x0002EB64
		public event EventHandler OnDevicesButtonPressed;

		// Token: 0x140000E7 RID: 231
		// (add) Token: 0x06000D39 RID: 3385 RVA: 0x000309A0 File Offset: 0x0002EBA0
		// (remove) Token: 0x06000D3A RID: 3386 RVA: 0x000309DC File Offset: 0x0002EBDC
		public event EventHandler OnAutoReconnected;

		// Token: 0x140000E8 RID: 232
		// (add) Token: 0x06000D3B RID: 3387 RVA: 0x00030A18 File Offset: 0x0002EC18
		// (remove) Token: 0x06000D3C RID: 3388 RVA: 0x00030A54 File Offset: 0x0002EC54
		public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

		// Token: 0x06000D3D RID: 3389 RVA: 0x00030A90 File Offset: 0x0002EC90
		public virtual void Connect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Connect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Connect();
		}

		// Token: 0x06000D3E RID: 3390 RVA: 0x00030AB4 File Offset: 0x0002ECB4
		public virtual void Disconnect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Disconnect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Disconnect();
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x00030AD8 File Offset: 0x0002ECD8
		public virtual void CreateVirtualChannels(string newVal)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("CreateVirtualChannels", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.CreateVirtualChannels(newVal);
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x00030B00 File Offset: 0x0002ED00
		public virtual void SendOnVirtualChannel(string chanName, string chanData)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SendOnVirtualChannel", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SendOnVirtualChannel(chanName, chanData);
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x00030B28 File Offset: 0x0002ED28
		public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SetVirtualChannelOptions(chanName, chanOptions);
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x00030B50 File Offset: 0x0002ED50
		public virtual int GetVirtualChannelOptions(string chanName)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetVirtualChannelOptions(chanName);
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x00030B88 File Offset: 0x0002ED88
		public virtual ControlCloseStatus RequestClose()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("RequestClose", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.RequestClose();
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x00030BC0 File Offset: 0x0002EDC0
		protected override void CreateSink()
		{
			try
			{
				this.eventMulticaster = new AxMsRdpClient3EventMulticaster(this);
				this.cookie = new AxHost.ConnectionPointCookie(this.ocx, this.eventMulticaster, typeof(IMsTscAxEvents));
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x00030C18 File Offset: 0x0002EE18
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

		// Token: 0x06000D46 RID: 3398 RVA: 0x00030C4C File Offset: 0x0002EE4C
		protected override void AttachInterfaces()
		{
			try
			{
				this.ocx = (IMsRdpClient3)base.GetOcx();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x00030C88 File Offset: 0x0002EE88
		internal void RaiseOnOnConnecting(object sender, EventArgs e)
		{
			if (this.OnConnecting != null)
			{
				this.OnConnecting(sender, e);
			}
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x00030CA4 File Offset: 0x0002EEA4
		internal void RaiseOnOnConnected(object sender, EventArgs e)
		{
			if (this.OnConnected != null)
			{
				this.OnConnected(sender, e);
			}
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x00030CC0 File Offset: 0x0002EEC0
		internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
		{
			if (this.OnLoginComplete != null)
			{
				this.OnLoginComplete(sender, e);
			}
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x00030CDC File Offset: 0x0002EEDC
		internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
		{
			if (this.OnDisconnected != null)
			{
				this.OnDisconnected(sender, e);
			}
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x00030CF8 File Offset: 0x0002EEF8
		internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnEnterFullScreenMode != null)
			{
				this.OnEnterFullScreenMode(sender, e);
			}
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x00030D14 File Offset: 0x0002EF14
		internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnLeaveFullScreenMode != null)
			{
				this.OnLeaveFullScreenMode(sender, e);
			}
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x00030D30 File Offset: 0x0002EF30
		internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
		{
			if (this.OnChannelReceivedData != null)
			{
				this.OnChannelReceivedData(sender, e);
			}
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x00030D4C File Offset: 0x0002EF4C
		internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestGoFullScreen != null)
			{
				this.OnRequestGoFullScreen(sender, e);
			}
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x00030D68 File Offset: 0x0002EF68
		internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestLeaveFullScreen != null)
			{
				this.OnRequestLeaveFullScreen(sender, e);
			}
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x00030D84 File Offset: 0x0002EF84
		internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
		{
			if (this.OnFatalError != null)
			{
				this.OnFatalError(sender, e);
			}
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x00030DA0 File Offset: 0x0002EFA0
		internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
		{
			if (this.OnWarning != null)
			{
				this.OnWarning(sender, e);
			}
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x00030DBC File Offset: 0x0002EFBC
		internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
		{
			if (this.OnRemoteDesktopSizeChange != null)
			{
				this.OnRemoteDesktopSizeChange(sender, e);
			}
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x00030DD8 File Offset: 0x0002EFD8
		internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
		{
			if (this.OnIdleTimeoutNotification != null)
			{
				this.OnIdleTimeoutNotification(sender, e);
			}
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x00030DF4 File Offset: 0x0002EFF4
		internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
		{
			if (this.OnRequestContainerMinimize != null)
			{
				this.OnRequestContainerMinimize(sender, e);
			}
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x00030E10 File Offset: 0x0002F010
		internal void RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
		{
			if (this.OnConfirmClose != null)
			{
				this.OnConfirmClose(sender, e);
			}
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x00030E2C File Offset: 0x0002F02C
		internal void RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
		{
			if (this.OnReceivedTSPublicKey != null)
			{
				this.OnReceivedTSPublicKey(sender, e);
			}
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x00030E48 File Offset: 0x0002F048
		internal void RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
		{
			if (this.OnAutoReconnecting != null)
			{
				this.OnAutoReconnecting(sender, e);
			}
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x00030E64 File Offset: 0x0002F064
		internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDisplayed != null)
			{
				this.OnAuthenticationWarningDisplayed(sender, e);
			}
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x00030E80 File Offset: 0x0002F080
		internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDismissed != null)
			{
				this.OnAuthenticationWarningDismissed(sender, e);
			}
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x00030E9C File Offset: 0x0002F09C
		internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
		{
			if (this.OnRemoteProgramResult != null)
			{
				this.OnRemoteProgramResult(sender, e);
			}
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x00030EB8 File Offset: 0x0002F0B8
		internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
		{
			if (this.OnRemoteProgramDisplayed != null)
			{
				this.OnRemoteProgramDisplayed(sender, e);
			}
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x00030ED4 File Offset: 0x0002F0D4
		internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
		{
			if (this.OnRemoteWindowDisplayed != null)
			{
				this.OnRemoteWindowDisplayed(sender, e);
			}
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x00030EF0 File Offset: 0x0002F0F0
		internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
		{
			if (this.OnLogonError != null)
			{
				this.OnLogonError(sender, e);
			}
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x00030F0C File Offset: 0x0002F10C
		internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
		{
			if (this.OnFocusReleased != null)
			{
				this.OnFocusReleased(sender, e);
			}
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x00030F28 File Offset: 0x0002F128
		internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
		{
			if (this.OnUserNameAcquired != null)
			{
				this.OnUserNameAcquired(sender, e);
			}
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x00030F44 File Offset: 0x0002F144
		internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
		{
			if (this.OnMouseInputModeChanged != null)
			{
				this.OnMouseInputModeChanged(sender, e);
			}
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x00030F60 File Offset: 0x0002F160
		internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
		{
			if (this.OnServiceMessageReceived != null)
			{
				this.OnServiceMessageReceived(sender, e);
			}
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x00030F7C File Offset: 0x0002F17C
		internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
		{
			if (this.OnConnectionBarPullDown != null)
			{
				this.OnConnectionBarPullDown(sender, e);
			}
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x00030F98 File Offset: 0x0002F198
		internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
		{
			if (this.OnNetworkStatusChanged != null)
			{
				this.OnNetworkStatusChanged(sender, e);
			}
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x00030FB4 File Offset: 0x0002F1B4
		internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
		{
			if (this.OnDevicesButtonPressed != null)
			{
				this.OnDevicesButtonPressed(sender, e);
			}
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x00030FD0 File Offset: 0x0002F1D0
		internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
		{
			if (this.OnAutoReconnected != null)
			{
				this.OnAutoReconnected(sender, e);
			}
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x00030FEC File Offset: 0x0002F1EC
		internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
		{
			if (this.OnAutoReconnecting2 != null)
			{
				this.OnAutoReconnecting2(sender, e);
			}
		}

		// Token: 0x04000463 RID: 1123
		private IMsRdpClient3 ocx;

		// Token: 0x04000464 RID: 1124
		private AxMsRdpClient3EventMulticaster eventMulticaster;

		// Token: 0x04000465 RID: 1125
		private AxHost.ConnectionPointCookie cookie;
	}
}
