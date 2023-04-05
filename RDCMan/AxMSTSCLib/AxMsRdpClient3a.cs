using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MSTSCLib;

namespace AxMSTSCLib
{
	// Token: 0x02000124 RID: 292
	[DesignTimeVisible(true)]
	[DefaultEvent("OnConnecting")]
	[AxHost.ClsidAttribute("{6a6f4b83-45c5-4ca9-bdd9-0d81c12295e4}")]
	[ComVisible(true)]
	public class AxMsRdpClient3a : AxHost
	{
		// Token: 0x06000D88 RID: 3464 RVA: 0x000315C8 File Offset: 0x0002F7C8
		public AxMsRdpClient3a() : base("6a6f4b83-45c5-4ca9-bdd9-0d81c12295e4")
		{
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000D89 RID: 3465 RVA: 0x000315D8 File Offset: 0x0002F7D8
		// (set) Token: 0x06000D8A RID: 3466 RVA: 0x000315FC File Offset: 0x0002F7FC
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

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000D8B RID: 3467 RVA: 0x00031624 File Offset: 0x0002F824
		// (set) Token: 0x06000D8C RID: 3468 RVA: 0x00031648 File Offset: 0x0002F848
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

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000D8D RID: 3469 RVA: 0x00031670 File Offset: 0x0002F870
		// (set) Token: 0x06000D8E RID: 3470 RVA: 0x00031694 File Offset: 0x0002F894
		[DispId(3)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000D8F RID: 3471 RVA: 0x000316BC File Offset: 0x0002F8BC
		// (set) Token: 0x06000D90 RID: 3472 RVA: 0x000316E0 File Offset: 0x0002F8E0
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

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000D91 RID: 3473 RVA: 0x00031708 File Offset: 0x0002F908
		// (set) Token: 0x06000D92 RID: 3474 RVA: 0x0003172C File Offset: 0x0002F92C
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

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000D93 RID: 3475 RVA: 0x00031754 File Offset: 0x0002F954
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

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000D94 RID: 3476 RVA: 0x00031778 File Offset: 0x0002F978
		// (set) Token: 0x06000D95 RID: 3477 RVA: 0x0003179C File Offset: 0x0002F99C
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

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000D96 RID: 3478 RVA: 0x000317C4 File Offset: 0x0002F9C4
		// (set) Token: 0x06000D97 RID: 3479 RVA: 0x000317E8 File Offset: 0x0002F9E8
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

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000D98 RID: 3480 RVA: 0x00031810 File Offset: 0x0002FA10
		// (set) Token: 0x06000D99 RID: 3481 RVA: 0x00031834 File Offset: 0x0002FA34
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

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000D9A RID: 3482 RVA: 0x0003185C File Offset: 0x0002FA5C
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

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000D9B RID: 3483 RVA: 0x00031880 File Offset: 0x0002FA80
		[DispId(18)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x17000284 RID: 644
		// (set) Token: 0x06000D9C RID: 3484 RVA: 0x000318A4 File Offset: 0x0002FAA4
		[Browsable(false)]
		[DispId(19)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000D9D RID: 3485 RVA: 0x000318CC File Offset: 0x0002FACC
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(20)]
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

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000D9E RID: 3486 RVA: 0x000318F0 File Offset: 0x0002FAF0
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

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000D9F RID: 3487 RVA: 0x00031914 File Offset: 0x0002FB14
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(22)]
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

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000DA0 RID: 3488 RVA: 0x00031938 File Offset: 0x0002FB38
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

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000DA1 RID: 3489 RVA: 0x0003195C File Offset: 0x0002FB5C
		[DispId(98)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
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

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000DA2 RID: 3490 RVA: 0x00031980 File Offset: 0x0002FB80
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

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000DA3 RID: 3491 RVA: 0x000319A4 File Offset: 0x0002FBA4
		// (set) Token: 0x06000DA4 RID: 3492 RVA: 0x000319C8 File Offset: 0x0002FBC8
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

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000DA5 RID: 3493 RVA: 0x000319F0 File Offset: 0x0002FBF0
		[DispId(101)]
		[Browsable(false)]
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

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000DA6 RID: 3494 RVA: 0x00031A14 File Offset: 0x0002FC14
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

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000DA7 RID: 3495 RVA: 0x00031A38 File Offset: 0x0002FC38
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

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000DA8 RID: 3496 RVA: 0x00031A5C File Offset: 0x0002FC5C
		// (set) Token: 0x06000DA9 RID: 3497 RVA: 0x00031A80 File Offset: 0x0002FC80
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

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000DAA RID: 3498 RVA: 0x00031AA8 File Offset: 0x0002FCA8
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(200)]
		[Browsable(false)]
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

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000DAB RID: 3499 RVA: 0x00031ACC File Offset: 0x0002FCCC
		// (set) Token: 0x06000DAC RID: 3500 RVA: 0x00031AF0 File Offset: 0x0002FCF0
		[DispId(201)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000DAD RID: 3501 RVA: 0x00031B18 File Offset: 0x0002FD18
		[DispId(300)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
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

		// Token: 0x140000E9 RID: 233
		// (add) Token: 0x06000DAE RID: 3502 RVA: 0x00031B3C File Offset: 0x0002FD3C
		// (remove) Token: 0x06000DAF RID: 3503 RVA: 0x00031B78 File Offset: 0x0002FD78
		public event EventHandler OnConnecting;

		// Token: 0x140000EA RID: 234
		// (add) Token: 0x06000DB0 RID: 3504 RVA: 0x00031BB4 File Offset: 0x0002FDB4
		// (remove) Token: 0x06000DB1 RID: 3505 RVA: 0x00031BF0 File Offset: 0x0002FDF0
		public event EventHandler OnConnected;

		// Token: 0x140000EB RID: 235
		// (add) Token: 0x06000DB2 RID: 3506 RVA: 0x00031C2C File Offset: 0x0002FE2C
		// (remove) Token: 0x06000DB3 RID: 3507 RVA: 0x00031C68 File Offset: 0x0002FE68
		public event EventHandler OnLoginComplete;

		// Token: 0x140000EC RID: 236
		// (add) Token: 0x06000DB4 RID: 3508 RVA: 0x00031CA4 File Offset: 0x0002FEA4
		// (remove) Token: 0x06000DB5 RID: 3509 RVA: 0x00031CE0 File Offset: 0x0002FEE0
		public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x140000ED RID: 237
		// (add) Token: 0x06000DB6 RID: 3510 RVA: 0x00031D1C File Offset: 0x0002FF1C
		// (remove) Token: 0x06000DB7 RID: 3511 RVA: 0x00031D58 File Offset: 0x0002FF58
		public event EventHandler OnEnterFullScreenMode;

		// Token: 0x140000EE RID: 238
		// (add) Token: 0x06000DB8 RID: 3512 RVA: 0x00031D94 File Offset: 0x0002FF94
		// (remove) Token: 0x06000DB9 RID: 3513 RVA: 0x00031DD0 File Offset: 0x0002FFD0
		public event EventHandler OnLeaveFullScreenMode;

		// Token: 0x140000EF RID: 239
		// (add) Token: 0x06000DBA RID: 3514 RVA: 0x00031E0C File Offset: 0x0003000C
		// (remove) Token: 0x06000DBB RID: 3515 RVA: 0x00031E48 File Offset: 0x00030048
		public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x140000F0 RID: 240
		// (add) Token: 0x06000DBC RID: 3516 RVA: 0x00031E84 File Offset: 0x00030084
		// (remove) Token: 0x06000DBD RID: 3517 RVA: 0x00031EC0 File Offset: 0x000300C0
		public event EventHandler OnRequestGoFullScreen;

		// Token: 0x140000F1 RID: 241
		// (add) Token: 0x06000DBE RID: 3518 RVA: 0x00031EFC File Offset: 0x000300FC
		// (remove) Token: 0x06000DBF RID: 3519 RVA: 0x00031F38 File Offset: 0x00030138
		public event EventHandler OnRequestLeaveFullScreen;

		// Token: 0x140000F2 RID: 242
		// (add) Token: 0x06000DC0 RID: 3520 RVA: 0x00031F74 File Offset: 0x00030174
		// (remove) Token: 0x06000DC1 RID: 3521 RVA: 0x00031FB0 File Offset: 0x000301B0
		public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x140000F3 RID: 243
		// (add) Token: 0x06000DC2 RID: 3522 RVA: 0x00031FEC File Offset: 0x000301EC
		// (remove) Token: 0x06000DC3 RID: 3523 RVA: 0x00032028 File Offset: 0x00030228
		public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x140000F4 RID: 244
		// (add) Token: 0x06000DC4 RID: 3524 RVA: 0x00032064 File Offset: 0x00030264
		// (remove) Token: 0x06000DC5 RID: 3525 RVA: 0x000320A0 File Offset: 0x000302A0
		public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x140000F5 RID: 245
		// (add) Token: 0x06000DC6 RID: 3526 RVA: 0x000320DC File Offset: 0x000302DC
		// (remove) Token: 0x06000DC7 RID: 3527 RVA: 0x00032118 File Offset: 0x00030318
		public event EventHandler OnIdleTimeoutNotification;

		// Token: 0x140000F6 RID: 246
		// (add) Token: 0x06000DC8 RID: 3528 RVA: 0x00032154 File Offset: 0x00030354
		// (remove) Token: 0x06000DC9 RID: 3529 RVA: 0x00032190 File Offset: 0x00030390
		public event EventHandler OnRequestContainerMinimize;

		// Token: 0x140000F7 RID: 247
		// (add) Token: 0x06000DCA RID: 3530 RVA: 0x000321CC File Offset: 0x000303CC
		// (remove) Token: 0x06000DCB RID: 3531 RVA: 0x00032208 File Offset: 0x00030408
		public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x140000F8 RID: 248
		// (add) Token: 0x06000DCC RID: 3532 RVA: 0x00032244 File Offset: 0x00030444
		// (remove) Token: 0x06000DCD RID: 3533 RVA: 0x00032280 File Offset: 0x00030480
		public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x140000F9 RID: 249
		// (add) Token: 0x06000DCE RID: 3534 RVA: 0x000322BC File Offset: 0x000304BC
		// (remove) Token: 0x06000DCF RID: 3535 RVA: 0x000322F8 File Offset: 0x000304F8
		public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x140000FA RID: 250
		// (add) Token: 0x06000DD0 RID: 3536 RVA: 0x00032334 File Offset: 0x00030534
		// (remove) Token: 0x06000DD1 RID: 3537 RVA: 0x00032370 File Offset: 0x00030570
		public event EventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x140000FB RID: 251
		// (add) Token: 0x06000DD2 RID: 3538 RVA: 0x000323AC File Offset: 0x000305AC
		// (remove) Token: 0x06000DD3 RID: 3539 RVA: 0x000323E8 File Offset: 0x000305E8
		public event EventHandler OnAuthenticationWarningDismissed;

		// Token: 0x140000FC RID: 252
		// (add) Token: 0x06000DD4 RID: 3540 RVA: 0x00032424 File Offset: 0x00030624
		// (remove) Token: 0x06000DD5 RID: 3541 RVA: 0x00032460 File Offset: 0x00030660
		public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x140000FD RID: 253
		// (add) Token: 0x06000DD6 RID: 3542 RVA: 0x0003249C File Offset: 0x0003069C
		// (remove) Token: 0x06000DD7 RID: 3543 RVA: 0x000324D8 File Offset: 0x000306D8
		public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x140000FE RID: 254
		// (add) Token: 0x06000DD8 RID: 3544 RVA: 0x00032514 File Offset: 0x00030714
		// (remove) Token: 0x06000DD9 RID: 3545 RVA: 0x00032550 File Offset: 0x00030750
		public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x140000FF RID: 255
		// (add) Token: 0x06000DDA RID: 3546 RVA: 0x0003258C File Offset: 0x0003078C
		// (remove) Token: 0x06000DDB RID: 3547 RVA: 0x000325C8 File Offset: 0x000307C8
		public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x14000100 RID: 256
		// (add) Token: 0x06000DDC RID: 3548 RVA: 0x00032604 File Offset: 0x00030804
		// (remove) Token: 0x06000DDD RID: 3549 RVA: 0x00032640 File Offset: 0x00030840
		public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x14000101 RID: 257
		// (add) Token: 0x06000DDE RID: 3550 RVA: 0x0003267C File Offset: 0x0003087C
		// (remove) Token: 0x06000DDF RID: 3551 RVA: 0x000326B8 File Offset: 0x000308B8
		public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x14000102 RID: 258
		// (add) Token: 0x06000DE0 RID: 3552 RVA: 0x000326F4 File Offset: 0x000308F4
		// (remove) Token: 0x06000DE1 RID: 3553 RVA: 0x00032730 File Offset: 0x00030930
		public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x14000103 RID: 259
		// (add) Token: 0x06000DE2 RID: 3554 RVA: 0x0003276C File Offset: 0x0003096C
		// (remove) Token: 0x06000DE3 RID: 3555 RVA: 0x000327A8 File Offset: 0x000309A8
		public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x14000104 RID: 260
		// (add) Token: 0x06000DE4 RID: 3556 RVA: 0x000327E4 File Offset: 0x000309E4
		// (remove) Token: 0x06000DE5 RID: 3557 RVA: 0x00032820 File Offset: 0x00030A20
		public event EventHandler OnConnectionBarPullDown;

		// Token: 0x14000105 RID: 261
		// (add) Token: 0x06000DE6 RID: 3558 RVA: 0x0003285C File Offset: 0x00030A5C
		// (remove) Token: 0x06000DE7 RID: 3559 RVA: 0x00032898 File Offset: 0x00030A98
		public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x14000106 RID: 262
		// (add) Token: 0x06000DE8 RID: 3560 RVA: 0x000328D4 File Offset: 0x00030AD4
		// (remove) Token: 0x06000DE9 RID: 3561 RVA: 0x00032910 File Offset: 0x00030B10
		public event EventHandler OnDevicesButtonPressed;

		// Token: 0x14000107 RID: 263
		// (add) Token: 0x06000DEA RID: 3562 RVA: 0x0003294C File Offset: 0x00030B4C
		// (remove) Token: 0x06000DEB RID: 3563 RVA: 0x00032988 File Offset: 0x00030B88
		public event EventHandler OnAutoReconnected;

		// Token: 0x14000108 RID: 264
		// (add) Token: 0x06000DEC RID: 3564 RVA: 0x000329C4 File Offset: 0x00030BC4
		// (remove) Token: 0x06000DED RID: 3565 RVA: 0x00032A00 File Offset: 0x00030C00
		public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

		// Token: 0x06000DEE RID: 3566 RVA: 0x00032A3C File Offset: 0x00030C3C
		public virtual void Connect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Connect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Connect();
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x00032A60 File Offset: 0x00030C60
		public virtual void Disconnect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Disconnect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Disconnect();
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x00032A84 File Offset: 0x00030C84
		public virtual void CreateVirtualChannels(string newVal)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("CreateVirtualChannels", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.CreateVirtualChannels(newVal);
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x00032AAC File Offset: 0x00030CAC
		public virtual void SendOnVirtualChannel(string chanName, string chanData)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SendOnVirtualChannel", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SendOnVirtualChannel(chanName, chanData);
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x00032AD4 File Offset: 0x00030CD4
		public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SetVirtualChannelOptions(chanName, chanOptions);
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x00032AFC File Offset: 0x00030CFC
		public virtual int GetVirtualChannelOptions(string chanName)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetVirtualChannelOptions(chanName);
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x00032B34 File Offset: 0x00030D34
		public virtual ControlCloseStatus RequestClose()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("RequestClose", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.RequestClose();
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x00032B6C File Offset: 0x00030D6C
		protected override void CreateSink()
		{
			try
			{
				this.eventMulticaster = new AxMsRdpClient3aEventMulticaster(this);
				this.cookie = new AxHost.ConnectionPointCookie(this.ocx, this.eventMulticaster, typeof(IMsTscAxEvents));
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x00032BC4 File Offset: 0x00030DC4
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

		// Token: 0x06000DF7 RID: 3575 RVA: 0x00032BF8 File Offset: 0x00030DF8
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

		// Token: 0x06000DF8 RID: 3576 RVA: 0x00032C34 File Offset: 0x00030E34
		internal void RaiseOnOnConnecting(object sender, EventArgs e)
		{
			if (this.OnConnecting != null)
			{
				this.OnConnecting(sender, e);
			}
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x00032C50 File Offset: 0x00030E50
		internal void RaiseOnOnConnected(object sender, EventArgs e)
		{
			if (this.OnConnected != null)
			{
				this.OnConnected(sender, e);
			}
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x00032C6C File Offset: 0x00030E6C
		internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
		{
			if (this.OnLoginComplete != null)
			{
				this.OnLoginComplete(sender, e);
			}
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x00032C88 File Offset: 0x00030E88
		internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
		{
			if (this.OnDisconnected != null)
			{
				this.OnDisconnected(sender, e);
			}
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x00032CA4 File Offset: 0x00030EA4
		internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnEnterFullScreenMode != null)
			{
				this.OnEnterFullScreenMode(sender, e);
			}
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x00032CC0 File Offset: 0x00030EC0
		internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnLeaveFullScreenMode != null)
			{
				this.OnLeaveFullScreenMode(sender, e);
			}
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x00032CDC File Offset: 0x00030EDC
		internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
		{
			if (this.OnChannelReceivedData != null)
			{
				this.OnChannelReceivedData(sender, e);
			}
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x00032CF8 File Offset: 0x00030EF8
		internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestGoFullScreen != null)
			{
				this.OnRequestGoFullScreen(sender, e);
			}
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x00032D14 File Offset: 0x00030F14
		internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestLeaveFullScreen != null)
			{
				this.OnRequestLeaveFullScreen(sender, e);
			}
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x00032D30 File Offset: 0x00030F30
		internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
		{
			if (this.OnFatalError != null)
			{
				this.OnFatalError(sender, e);
			}
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x00032D4C File Offset: 0x00030F4C
		internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
		{
			if (this.OnWarning != null)
			{
				this.OnWarning(sender, e);
			}
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x00032D68 File Offset: 0x00030F68
		internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
		{
			if (this.OnRemoteDesktopSizeChange != null)
			{
				this.OnRemoteDesktopSizeChange(sender, e);
			}
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x00032D84 File Offset: 0x00030F84
		internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
		{
			if (this.OnIdleTimeoutNotification != null)
			{
				this.OnIdleTimeoutNotification(sender, e);
			}
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x00032DA0 File Offset: 0x00030FA0
		internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
		{
			if (this.OnRequestContainerMinimize != null)
			{
				this.OnRequestContainerMinimize(sender, e);
			}
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x00032DBC File Offset: 0x00030FBC
		internal void RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
		{
			if (this.OnConfirmClose != null)
			{
				this.OnConfirmClose(sender, e);
			}
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x00032DD8 File Offset: 0x00030FD8
		internal void RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
		{
			if (this.OnReceivedTSPublicKey != null)
			{
				this.OnReceivedTSPublicKey(sender, e);
			}
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x00032DF4 File Offset: 0x00030FF4
		internal void RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
		{
			if (this.OnAutoReconnecting != null)
			{
				this.OnAutoReconnecting(sender, e);
			}
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x00032E10 File Offset: 0x00031010
		internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDisplayed != null)
			{
				this.OnAuthenticationWarningDisplayed(sender, e);
			}
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x00032E2C File Offset: 0x0003102C
		internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDismissed != null)
			{
				this.OnAuthenticationWarningDismissed(sender, e);
			}
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x00032E48 File Offset: 0x00031048
		internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
		{
			if (this.OnRemoteProgramResult != null)
			{
				this.OnRemoteProgramResult(sender, e);
			}
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x00032E64 File Offset: 0x00031064
		internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
		{
			if (this.OnRemoteProgramDisplayed != null)
			{
				this.OnRemoteProgramDisplayed(sender, e);
			}
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x00032E80 File Offset: 0x00031080
		internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
		{
			if (this.OnRemoteWindowDisplayed != null)
			{
				this.OnRemoteWindowDisplayed(sender, e);
			}
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x00032E9C File Offset: 0x0003109C
		internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
		{
			if (this.OnLogonError != null)
			{
				this.OnLogonError(sender, e);
			}
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x00032EB8 File Offset: 0x000310B8
		internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
		{
			if (this.OnFocusReleased != null)
			{
				this.OnFocusReleased(sender, e);
			}
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x00032ED4 File Offset: 0x000310D4
		internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
		{
			if (this.OnUserNameAcquired != null)
			{
				this.OnUserNameAcquired(sender, e);
			}
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x00032EF0 File Offset: 0x000310F0
		internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
		{
			if (this.OnMouseInputModeChanged != null)
			{
				this.OnMouseInputModeChanged(sender, e);
			}
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x00032F0C File Offset: 0x0003110C
		internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
		{
			if (this.OnServiceMessageReceived != null)
			{
				this.OnServiceMessageReceived(sender, e);
			}
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x00032F28 File Offset: 0x00031128
		internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
		{
			if (this.OnConnectionBarPullDown != null)
			{
				this.OnConnectionBarPullDown(sender, e);
			}
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x00032F44 File Offset: 0x00031144
		internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
		{
			if (this.OnNetworkStatusChanged != null)
			{
				this.OnNetworkStatusChanged(sender, e);
			}
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x00032F60 File Offset: 0x00031160
		internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
		{
			if (this.OnDevicesButtonPressed != null)
			{
				this.OnDevicesButtonPressed(sender, e);
			}
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x00032F7C File Offset: 0x0003117C
		internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
		{
			if (this.OnAutoReconnected != null)
			{
				this.OnAutoReconnected(sender, e);
			}
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x00032F98 File Offset: 0x00031198
		internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
		{
			if (this.OnAutoReconnecting2 != null)
			{
				this.OnAutoReconnecting2(sender, e);
			}
		}

		// Token: 0x04000487 RID: 1159
		private IMsRdpClient3 ocx;

		// Token: 0x04000488 RID: 1160
		private AxMsRdpClient3aEventMulticaster eventMulticaster;

		// Token: 0x04000489 RID: 1161
		private AxHost.ConnectionPointCookie cookie;
	}
}
