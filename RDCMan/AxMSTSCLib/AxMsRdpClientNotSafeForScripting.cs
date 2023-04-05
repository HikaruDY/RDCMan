using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MSTSCLib;

namespace AxMSTSCLib
{
	// Token: 0x02000118 RID: 280
	[DefaultEvent("OnConnecting")]
	[DesignTimeVisible(true)]
	[AxHost.ClsidAttribute("{7cacbd7b-0d99-468f-ac33-22e495c0afe5}")]
	[ComVisible(true)]
	public class AxMsRdpClientNotSafeForScripting : AxHost
	{
		// Token: 0x06000969 RID: 2409 RVA: 0x000258C0 File Offset: 0x00023AC0
		public AxMsRdpClientNotSafeForScripting() : base("7cacbd7b-0d99-468f-ac33-22e495c0afe5")
		{
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x0600096A RID: 2410 RVA: 0x000258D0 File Offset: 0x00023AD0
		// (set) Token: 0x0600096B RID: 2411 RVA: 0x000258F4 File Offset: 0x00023AF4
		[DispId(1)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x0600096C RID: 2412 RVA: 0x0002591C File Offset: 0x00023B1C
		// (set) Token: 0x0600096D RID: 2413 RVA: 0x00025940 File Offset: 0x00023B40
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

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x0600096E RID: 2414 RVA: 0x00025968 File Offset: 0x00023B68
		// (set) Token: 0x0600096F RID: 2415 RVA: 0x0002598C File Offset: 0x00023B8C
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

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000970 RID: 2416 RVA: 0x000259B4 File Offset: 0x00023BB4
		// (set) Token: 0x06000971 RID: 2417 RVA: 0x000259D8 File Offset: 0x00023BD8
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

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000972 RID: 2418 RVA: 0x00025A00 File Offset: 0x00023C00
		// (set) Token: 0x06000973 RID: 2419 RVA: 0x00025A24 File Offset: 0x00023C24
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

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000974 RID: 2420 RVA: 0x00025A4C File Offset: 0x00023C4C
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

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000975 RID: 2421 RVA: 0x00025A70 File Offset: 0x00023C70
		// (set) Token: 0x06000976 RID: 2422 RVA: 0x00025A94 File Offset: 0x00023C94
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

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000977 RID: 2423 RVA: 0x00025ABC File Offset: 0x00023CBC
		// (set) Token: 0x06000978 RID: 2424 RVA: 0x00025AE0 File Offset: 0x00023CE0
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

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000979 RID: 2425 RVA: 0x00025B08 File Offset: 0x00023D08
		// (set) Token: 0x0600097A RID: 2426 RVA: 0x00025B2C File Offset: 0x00023D2C
		[DispId(16)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x0600097B RID: 2427 RVA: 0x00025B54 File Offset: 0x00023D54
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

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x0600097C RID: 2428 RVA: 0x00025B78 File Offset: 0x00023D78
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

		// Token: 0x170001EE RID: 494
		// (set) Token: 0x0600097D RID: 2429 RVA: 0x00025B9C File Offset: 0x00023D9C
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

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x0600097E RID: 2430 RVA: 0x00025BC4 File Offset: 0x00023DC4
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

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x0600097F RID: 2431 RVA: 0x00025BE8 File Offset: 0x00023DE8
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

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000980 RID: 2432 RVA: 0x00025C0C File Offset: 0x00023E0C
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

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000981 RID: 2433 RVA: 0x00025C30 File Offset: 0x00023E30
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

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000982 RID: 2434 RVA: 0x00025C54 File Offset: 0x00023E54
		[Browsable(false)]
		[DispId(98)]
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

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000983 RID: 2435 RVA: 0x00025C78 File Offset: 0x00023E78
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(99)]
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

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000984 RID: 2436 RVA: 0x00025C9C File Offset: 0x00023E9C
		// (set) Token: 0x06000985 RID: 2437 RVA: 0x00025CC0 File Offset: 0x00023EC0
		[DispId(100)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000986 RID: 2438 RVA: 0x00025CE8 File Offset: 0x00023EE8
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(101)]
		[Browsable(false)]
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

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000987 RID: 2439 RVA: 0x00025D0C File Offset: 0x00023F0C
		[DispId(102)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
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

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000988 RID: 2440 RVA: 0x00025D30 File Offset: 0x00023F30
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

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000989 RID: 2441 RVA: 0x00025D54 File Offset: 0x00023F54
		// (set) Token: 0x0600098A RID: 2442 RVA: 0x00025D78 File Offset: 0x00023F78
		[DispId(104)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x14000029 RID: 41
		// (add) Token: 0x0600098B RID: 2443 RVA: 0x00025DA0 File Offset: 0x00023FA0
		// (remove) Token: 0x0600098C RID: 2444 RVA: 0x00025DDC File Offset: 0x00023FDC
		public event EventHandler OnConnecting;

		// Token: 0x1400002A RID: 42
		// (add) Token: 0x0600098D RID: 2445 RVA: 0x00025E18 File Offset: 0x00024018
		// (remove) Token: 0x0600098E RID: 2446 RVA: 0x00025E54 File Offset: 0x00024054
		public event EventHandler OnConnected;

		// Token: 0x1400002B RID: 43
		// (add) Token: 0x0600098F RID: 2447 RVA: 0x00025E90 File Offset: 0x00024090
		// (remove) Token: 0x06000990 RID: 2448 RVA: 0x00025ECC File Offset: 0x000240CC
		public event EventHandler OnLoginComplete;

		// Token: 0x1400002C RID: 44
		// (add) Token: 0x06000991 RID: 2449 RVA: 0x00025F08 File Offset: 0x00024108
		// (remove) Token: 0x06000992 RID: 2450 RVA: 0x00025F44 File Offset: 0x00024144
		public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x1400002D RID: 45
		// (add) Token: 0x06000993 RID: 2451 RVA: 0x00025F80 File Offset: 0x00024180
		// (remove) Token: 0x06000994 RID: 2452 RVA: 0x00025FBC File Offset: 0x000241BC
		public event EventHandler OnEnterFullScreenMode;

		// Token: 0x1400002E RID: 46
		// (add) Token: 0x06000995 RID: 2453 RVA: 0x00025FF8 File Offset: 0x000241F8
		// (remove) Token: 0x06000996 RID: 2454 RVA: 0x00026034 File Offset: 0x00024234
		public event EventHandler OnLeaveFullScreenMode;

		// Token: 0x1400002F RID: 47
		// (add) Token: 0x06000997 RID: 2455 RVA: 0x00026070 File Offset: 0x00024270
		// (remove) Token: 0x06000998 RID: 2456 RVA: 0x000260AC File Offset: 0x000242AC
		public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x14000030 RID: 48
		// (add) Token: 0x06000999 RID: 2457 RVA: 0x000260E8 File Offset: 0x000242E8
		// (remove) Token: 0x0600099A RID: 2458 RVA: 0x00026124 File Offset: 0x00024324
		public event EventHandler OnRequestGoFullScreen;

		// Token: 0x14000031 RID: 49
		// (add) Token: 0x0600099B RID: 2459 RVA: 0x00026160 File Offset: 0x00024360
		// (remove) Token: 0x0600099C RID: 2460 RVA: 0x0002619C File Offset: 0x0002439C
		public event EventHandler OnRequestLeaveFullScreen;

		// Token: 0x14000032 RID: 50
		// (add) Token: 0x0600099D RID: 2461 RVA: 0x000261D8 File Offset: 0x000243D8
		// (remove) Token: 0x0600099E RID: 2462 RVA: 0x00026214 File Offset: 0x00024414
		public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x14000033 RID: 51
		// (add) Token: 0x0600099F RID: 2463 RVA: 0x00026250 File Offset: 0x00024450
		// (remove) Token: 0x060009A0 RID: 2464 RVA: 0x0002628C File Offset: 0x0002448C
		public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x14000034 RID: 52
		// (add) Token: 0x060009A1 RID: 2465 RVA: 0x000262C8 File Offset: 0x000244C8
		// (remove) Token: 0x060009A2 RID: 2466 RVA: 0x00026304 File Offset: 0x00024504
		public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x14000035 RID: 53
		// (add) Token: 0x060009A3 RID: 2467 RVA: 0x00026340 File Offset: 0x00024540
		// (remove) Token: 0x060009A4 RID: 2468 RVA: 0x0002637C File Offset: 0x0002457C
		public event EventHandler OnIdleTimeoutNotification;

		// Token: 0x14000036 RID: 54
		// (add) Token: 0x060009A5 RID: 2469 RVA: 0x000263B8 File Offset: 0x000245B8
		// (remove) Token: 0x060009A6 RID: 2470 RVA: 0x000263F4 File Offset: 0x000245F4
		public event EventHandler OnRequestContainerMinimize;

		// Token: 0x14000037 RID: 55
		// (add) Token: 0x060009A7 RID: 2471 RVA: 0x00026430 File Offset: 0x00024630
		// (remove) Token: 0x060009A8 RID: 2472 RVA: 0x0002646C File Offset: 0x0002466C
		public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x14000038 RID: 56
		// (add) Token: 0x060009A9 RID: 2473 RVA: 0x000264A8 File Offset: 0x000246A8
		// (remove) Token: 0x060009AA RID: 2474 RVA: 0x000264E4 File Offset: 0x000246E4
		public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x14000039 RID: 57
		// (add) Token: 0x060009AB RID: 2475 RVA: 0x00026520 File Offset: 0x00024720
		// (remove) Token: 0x060009AC RID: 2476 RVA: 0x0002655C File Offset: 0x0002475C
		public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x1400003A RID: 58
		// (add) Token: 0x060009AD RID: 2477 RVA: 0x00026598 File Offset: 0x00024798
		// (remove) Token: 0x060009AE RID: 2478 RVA: 0x000265D4 File Offset: 0x000247D4
		public event EventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x1400003B RID: 59
		// (add) Token: 0x060009AF RID: 2479 RVA: 0x00026610 File Offset: 0x00024810
		// (remove) Token: 0x060009B0 RID: 2480 RVA: 0x0002664C File Offset: 0x0002484C
		public event EventHandler OnAuthenticationWarningDismissed;

		// Token: 0x1400003C RID: 60
		// (add) Token: 0x060009B1 RID: 2481 RVA: 0x00026688 File Offset: 0x00024888
		// (remove) Token: 0x060009B2 RID: 2482 RVA: 0x000266C4 File Offset: 0x000248C4
		public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x1400003D RID: 61
		// (add) Token: 0x060009B3 RID: 2483 RVA: 0x00026700 File Offset: 0x00024900
		// (remove) Token: 0x060009B4 RID: 2484 RVA: 0x0002673C File Offset: 0x0002493C
		public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x1400003E RID: 62
		// (add) Token: 0x060009B5 RID: 2485 RVA: 0x00026778 File Offset: 0x00024978
		// (remove) Token: 0x060009B6 RID: 2486 RVA: 0x000267B4 File Offset: 0x000249B4
		public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x1400003F RID: 63
		// (add) Token: 0x060009B7 RID: 2487 RVA: 0x000267F0 File Offset: 0x000249F0
		// (remove) Token: 0x060009B8 RID: 2488 RVA: 0x0002682C File Offset: 0x00024A2C
		public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x14000040 RID: 64
		// (add) Token: 0x060009B9 RID: 2489 RVA: 0x00026868 File Offset: 0x00024A68
		// (remove) Token: 0x060009BA RID: 2490 RVA: 0x000268A4 File Offset: 0x00024AA4
		public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x14000041 RID: 65
		// (add) Token: 0x060009BB RID: 2491 RVA: 0x000268E0 File Offset: 0x00024AE0
		// (remove) Token: 0x060009BC RID: 2492 RVA: 0x0002691C File Offset: 0x00024B1C
		public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x14000042 RID: 66
		// (add) Token: 0x060009BD RID: 2493 RVA: 0x00026958 File Offset: 0x00024B58
		// (remove) Token: 0x060009BE RID: 2494 RVA: 0x00026994 File Offset: 0x00024B94
		public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x14000043 RID: 67
		// (add) Token: 0x060009BF RID: 2495 RVA: 0x000269D0 File Offset: 0x00024BD0
		// (remove) Token: 0x060009C0 RID: 2496 RVA: 0x00026A0C File Offset: 0x00024C0C
		public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x14000044 RID: 68
		// (add) Token: 0x060009C1 RID: 2497 RVA: 0x00026A48 File Offset: 0x00024C48
		// (remove) Token: 0x060009C2 RID: 2498 RVA: 0x00026A84 File Offset: 0x00024C84
		public event EventHandler OnConnectionBarPullDown;

		// Token: 0x14000045 RID: 69
		// (add) Token: 0x060009C3 RID: 2499 RVA: 0x00026AC0 File Offset: 0x00024CC0
		// (remove) Token: 0x060009C4 RID: 2500 RVA: 0x00026AFC File Offset: 0x00024CFC
		public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x14000046 RID: 70
		// (add) Token: 0x060009C5 RID: 2501 RVA: 0x00026B38 File Offset: 0x00024D38
		// (remove) Token: 0x060009C6 RID: 2502 RVA: 0x00026B74 File Offset: 0x00024D74
		public event EventHandler OnDevicesButtonPressed;

		// Token: 0x14000047 RID: 71
		// (add) Token: 0x060009C7 RID: 2503 RVA: 0x00026BB0 File Offset: 0x00024DB0
		// (remove) Token: 0x060009C8 RID: 2504 RVA: 0x00026BEC File Offset: 0x00024DEC
		public event EventHandler OnAutoReconnected;

		// Token: 0x14000048 RID: 72
		// (add) Token: 0x060009C9 RID: 2505 RVA: 0x00026C28 File Offset: 0x00024E28
		// (remove) Token: 0x060009CA RID: 2506 RVA: 0x00026C64 File Offset: 0x00024E64
		public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

		// Token: 0x060009CB RID: 2507 RVA: 0x00026CA0 File Offset: 0x00024EA0
		public virtual void Connect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Connect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Connect();
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x00026CC4 File Offset: 0x00024EC4
		public virtual void Disconnect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Disconnect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Disconnect();
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x00026CE8 File Offset: 0x00024EE8
		public virtual void CreateVirtualChannels(string newVal)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("CreateVirtualChannels", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.CreateVirtualChannels(newVal);
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x00026D10 File Offset: 0x00024F10
		public virtual void SendOnVirtualChannel(string chanName, string chanData)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SendOnVirtualChannel", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SendOnVirtualChannel(chanName, chanData);
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x00026D38 File Offset: 0x00024F38
		public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SetVirtualChannelOptions(chanName, chanOptions);
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x00026D60 File Offset: 0x00024F60
		public virtual int GetVirtualChannelOptions(string chanName)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetVirtualChannelOptions(chanName);
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x00026D98 File Offset: 0x00024F98
		public virtual ControlCloseStatus RequestClose()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("RequestClose", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.RequestClose();
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x00026DD0 File Offset: 0x00024FD0
		protected override void CreateSink()
		{
			try
			{
				this.eventMulticaster = new AxMsRdpClientNotSafeForScriptingEventMulticaster(this);
				this.cookie = new AxHost.ConnectionPointCookie(this.ocx, this.eventMulticaster, typeof(IMsTscAxEvents));
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x00026E28 File Offset: 0x00025028
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

		// Token: 0x060009D4 RID: 2516 RVA: 0x00026E5C File Offset: 0x0002505C
		protected override void AttachInterfaces()
		{
			try
			{
				this.ocx = (IMsRdpClient)base.GetOcx();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x00026E98 File Offset: 0x00025098
		internal void RaiseOnOnConnecting(object sender, EventArgs e)
		{
			if (this.OnConnecting != null)
			{
				this.OnConnecting(sender, e);
			}
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x00026EB4 File Offset: 0x000250B4
		internal void RaiseOnOnConnected(object sender, EventArgs e)
		{
			if (this.OnConnected != null)
			{
				this.OnConnected(sender, e);
			}
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x00026ED0 File Offset: 0x000250D0
		internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
		{
			if (this.OnLoginComplete != null)
			{
				this.OnLoginComplete(sender, e);
			}
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x00026EEC File Offset: 0x000250EC
		internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
		{
			if (this.OnDisconnected != null)
			{
				this.OnDisconnected(sender, e);
			}
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00026F08 File Offset: 0x00025108
		internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnEnterFullScreenMode != null)
			{
				this.OnEnterFullScreenMode(sender, e);
			}
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x00026F24 File Offset: 0x00025124
		internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnLeaveFullScreenMode != null)
			{
				this.OnLeaveFullScreenMode(sender, e);
			}
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x00026F40 File Offset: 0x00025140
		internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
		{
			if (this.OnChannelReceivedData != null)
			{
				this.OnChannelReceivedData(sender, e);
			}
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00026F5C File Offset: 0x0002515C
		internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestGoFullScreen != null)
			{
				this.OnRequestGoFullScreen(sender, e);
			}
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x00026F78 File Offset: 0x00025178
		internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestLeaveFullScreen != null)
			{
				this.OnRequestLeaveFullScreen(sender, e);
			}
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x00026F94 File Offset: 0x00025194
		internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
		{
			if (this.OnFatalError != null)
			{
				this.OnFatalError(sender, e);
			}
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x00026FB0 File Offset: 0x000251B0
		internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
		{
			if (this.OnWarning != null)
			{
				this.OnWarning(sender, e);
			}
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00026FCC File Offset: 0x000251CC
		internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
		{
			if (this.OnRemoteDesktopSizeChange != null)
			{
				this.OnRemoteDesktopSizeChange(sender, e);
			}
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x00026FE8 File Offset: 0x000251E8
		internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
		{
			if (this.OnIdleTimeoutNotification != null)
			{
				this.OnIdleTimeoutNotification(sender, e);
			}
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x00027004 File Offset: 0x00025204
		internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
		{
			if (this.OnRequestContainerMinimize != null)
			{
				this.OnRequestContainerMinimize(sender, e);
			}
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x00027020 File Offset: 0x00025220
		internal void RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
		{
			if (this.OnConfirmClose != null)
			{
				this.OnConfirmClose(sender, e);
			}
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x0002703C File Offset: 0x0002523C
		internal void RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
		{
			if (this.OnReceivedTSPublicKey != null)
			{
				this.OnReceivedTSPublicKey(sender, e);
			}
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x00027058 File Offset: 0x00025258
		internal void RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
		{
			if (this.OnAutoReconnecting != null)
			{
				this.OnAutoReconnecting(sender, e);
			}
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x00027074 File Offset: 0x00025274
		internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDisplayed != null)
			{
				this.OnAuthenticationWarningDisplayed(sender, e);
			}
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x00027090 File Offset: 0x00025290
		internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDismissed != null)
			{
				this.OnAuthenticationWarningDismissed(sender, e);
			}
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x000270AC File Offset: 0x000252AC
		internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
		{
			if (this.OnRemoteProgramResult != null)
			{
				this.OnRemoteProgramResult(sender, e);
			}
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x000270C8 File Offset: 0x000252C8
		internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
		{
			if (this.OnRemoteProgramDisplayed != null)
			{
				this.OnRemoteProgramDisplayed(sender, e);
			}
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x000270E4 File Offset: 0x000252E4
		internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
		{
			if (this.OnRemoteWindowDisplayed != null)
			{
				this.OnRemoteWindowDisplayed(sender, e);
			}
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x00027100 File Offset: 0x00025300
		internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
		{
			if (this.OnLogonError != null)
			{
				this.OnLogonError(sender, e);
			}
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x0002711C File Offset: 0x0002531C
		internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
		{
			if (this.OnFocusReleased != null)
			{
				this.OnFocusReleased(sender, e);
			}
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x00027138 File Offset: 0x00025338
		internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
		{
			if (this.OnUserNameAcquired != null)
			{
				this.OnUserNameAcquired(sender, e);
			}
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x00027154 File Offset: 0x00025354
		internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
		{
			if (this.OnMouseInputModeChanged != null)
			{
				this.OnMouseInputModeChanged(sender, e);
			}
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x00027170 File Offset: 0x00025370
		internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
		{
			if (this.OnServiceMessageReceived != null)
			{
				this.OnServiceMessageReceived(sender, e);
			}
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x0002718C File Offset: 0x0002538C
		internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
		{
			if (this.OnConnectionBarPullDown != null)
			{
				this.OnConnectionBarPullDown(sender, e);
			}
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x000271A8 File Offset: 0x000253A8
		internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
		{
			if (this.OnNetworkStatusChanged != null)
			{
				this.OnNetworkStatusChanged(sender, e);
			}
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x000271C4 File Offset: 0x000253C4
		internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
		{
			if (this.OnDevicesButtonPressed != null)
			{
				this.OnDevicesButtonPressed(sender, e);
			}
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x000271E0 File Offset: 0x000253E0
		internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
		{
			if (this.OnAutoReconnected != null)
			{
				this.OnAutoReconnected(sender, e);
			}
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x000271FC File Offset: 0x000253FC
		internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
		{
			if (this.OnAutoReconnecting2 != null)
			{
				this.OnAutoReconnecting2(sender, e);
			}
		}

		// Token: 0x040003AF RID: 943
		private IMsRdpClient ocx;

		// Token: 0x040003B0 RID: 944
		private AxMsRdpClientNotSafeForScriptingEventMulticaster eventMulticaster;

		// Token: 0x040003B1 RID: 945
		private AxHost.ConnectionPointCookie cookie;
	}
}
