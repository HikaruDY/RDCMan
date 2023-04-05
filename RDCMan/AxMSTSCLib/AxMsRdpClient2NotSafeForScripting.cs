using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MSTSCLib;

namespace AxMSTSCLib
{
	// Token: 0x0200011A RID: 282
	[DefaultEvent("OnConnecting")]
	[AxHost.ClsidAttribute("{3523c2fb-4031-44e4-9a3b-f1e94986ee7f}")]
	[DesignTimeVisible(true)]
	[ComVisible(true)]
	public class AxMsRdpClient2NotSafeForScripting : AxHost
	{
		// Token: 0x06000A16 RID: 2582 RVA: 0x000277D8 File Offset: 0x000259D8
		public AxMsRdpClient2NotSafeForScripting() : base("3523c2fb-4031-44e4-9a3b-f1e94986ee7f")
		{
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x000277E8 File Offset: 0x000259E8
		// (set) Token: 0x06000A18 RID: 2584 RVA: 0x0002780C File Offset: 0x00025A0C
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

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x00027834 File Offset: 0x00025A34
		// (set) Token: 0x06000A1A RID: 2586 RVA: 0x00027858 File Offset: 0x00025A58
		[DispId(2)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x00027880 File Offset: 0x00025A80
		// (set) Token: 0x06000A1C RID: 2588 RVA: 0x000278A4 File Offset: 0x00025AA4
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

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000A1D RID: 2589 RVA: 0x000278CC File Offset: 0x00025ACC
		// (set) Token: 0x06000A1E RID: 2590 RVA: 0x000278F0 File Offset: 0x00025AF0
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

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x00027918 File Offset: 0x00025B18
		// (set) Token: 0x06000A20 RID: 2592 RVA: 0x0002793C File Offset: 0x00025B3C
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

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x00027964 File Offset: 0x00025B64
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

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x00027988 File Offset: 0x00025B88
		// (set) Token: 0x06000A23 RID: 2595 RVA: 0x000279AC File Offset: 0x00025BAC
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

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000A24 RID: 2596 RVA: 0x000279D4 File Offset: 0x00025BD4
		// (set) Token: 0x06000A25 RID: 2597 RVA: 0x000279F8 File Offset: 0x00025BF8
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

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000A26 RID: 2598 RVA: 0x00027A20 File Offset: 0x00025C20
		// (set) Token: 0x06000A27 RID: 2599 RVA: 0x00027A44 File Offset: 0x00025C44
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

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x00027A6C File Offset: 0x00025C6C
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

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x00027A90 File Offset: 0x00025C90
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

		// Token: 0x17000205 RID: 517
		// (set) Token: 0x06000A2A RID: 2602 RVA: 0x00027AB4 File Offset: 0x00025CB4
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

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000A2B RID: 2603 RVA: 0x00027ADC File Offset: 0x00025CDC
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

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x00027B00 File Offset: 0x00025D00
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

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x00027B24 File Offset: 0x00025D24
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

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000A2E RID: 2606 RVA: 0x00027B48 File Offset: 0x00025D48
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(97)]
		[Browsable(false)]
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

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x00027B6C File Offset: 0x00025D6C
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

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000A30 RID: 2608 RVA: 0x00027B90 File Offset: 0x00025D90
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(99)]
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

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x00027BB4 File Offset: 0x00025DB4
		// (set) Token: 0x06000A32 RID: 2610 RVA: 0x00027BD8 File Offset: 0x00025DD8
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

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x00027C00 File Offset: 0x00025E00
		[DispId(101)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000A34 RID: 2612 RVA: 0x00027C24 File Offset: 0x00025E24
		[DispId(102)]
		[Browsable(false)]
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

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x00027C48 File Offset: 0x00025E48
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

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000A36 RID: 2614 RVA: 0x00027C6C File Offset: 0x00025E6C
		// (set) Token: 0x06000A37 RID: 2615 RVA: 0x00027C90 File Offset: 0x00025E90
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

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000A38 RID: 2616 RVA: 0x00027CB8 File Offset: 0x00025EB8
		[DispId(200)]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x00027CDC File Offset: 0x00025EDC
		// (set) Token: 0x06000A3A RID: 2618 RVA: 0x00027D00 File Offset: 0x00025F00
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

		// Token: 0x14000049 RID: 73
		// (add) Token: 0x06000A3B RID: 2619 RVA: 0x00027D28 File Offset: 0x00025F28
		// (remove) Token: 0x06000A3C RID: 2620 RVA: 0x00027D64 File Offset: 0x00025F64
		public event EventHandler OnConnecting;

		// Token: 0x1400004A RID: 74
		// (add) Token: 0x06000A3D RID: 2621 RVA: 0x00027DA0 File Offset: 0x00025FA0
		// (remove) Token: 0x06000A3E RID: 2622 RVA: 0x00027DDC File Offset: 0x00025FDC
		public event EventHandler OnConnected;

		// Token: 0x1400004B RID: 75
		// (add) Token: 0x06000A3F RID: 2623 RVA: 0x00027E18 File Offset: 0x00026018
		// (remove) Token: 0x06000A40 RID: 2624 RVA: 0x00027E54 File Offset: 0x00026054
		public event EventHandler OnLoginComplete;

		// Token: 0x1400004C RID: 76
		// (add) Token: 0x06000A41 RID: 2625 RVA: 0x00027E90 File Offset: 0x00026090
		// (remove) Token: 0x06000A42 RID: 2626 RVA: 0x00027ECC File Offset: 0x000260CC
		public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x1400004D RID: 77
		// (add) Token: 0x06000A43 RID: 2627 RVA: 0x00027F08 File Offset: 0x00026108
		// (remove) Token: 0x06000A44 RID: 2628 RVA: 0x00027F44 File Offset: 0x00026144
		public event EventHandler OnEnterFullScreenMode;

		// Token: 0x1400004E RID: 78
		// (add) Token: 0x06000A45 RID: 2629 RVA: 0x00027F80 File Offset: 0x00026180
		// (remove) Token: 0x06000A46 RID: 2630 RVA: 0x00027FBC File Offset: 0x000261BC
		public event EventHandler OnLeaveFullScreenMode;

		// Token: 0x1400004F RID: 79
		// (add) Token: 0x06000A47 RID: 2631 RVA: 0x00027FF8 File Offset: 0x000261F8
		// (remove) Token: 0x06000A48 RID: 2632 RVA: 0x00028034 File Offset: 0x00026234
		public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x14000050 RID: 80
		// (add) Token: 0x06000A49 RID: 2633 RVA: 0x00028070 File Offset: 0x00026270
		// (remove) Token: 0x06000A4A RID: 2634 RVA: 0x000280AC File Offset: 0x000262AC
		public event EventHandler OnRequestGoFullScreen;

		// Token: 0x14000051 RID: 81
		// (add) Token: 0x06000A4B RID: 2635 RVA: 0x000280E8 File Offset: 0x000262E8
		// (remove) Token: 0x06000A4C RID: 2636 RVA: 0x00028124 File Offset: 0x00026324
		public event EventHandler OnRequestLeaveFullScreen;

		// Token: 0x14000052 RID: 82
		// (add) Token: 0x06000A4D RID: 2637 RVA: 0x00028160 File Offset: 0x00026360
		// (remove) Token: 0x06000A4E RID: 2638 RVA: 0x0002819C File Offset: 0x0002639C
		public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x14000053 RID: 83
		// (add) Token: 0x06000A4F RID: 2639 RVA: 0x000281D8 File Offset: 0x000263D8
		// (remove) Token: 0x06000A50 RID: 2640 RVA: 0x00028214 File Offset: 0x00026414
		public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x14000054 RID: 84
		// (add) Token: 0x06000A51 RID: 2641 RVA: 0x00028250 File Offset: 0x00026450
		// (remove) Token: 0x06000A52 RID: 2642 RVA: 0x0002828C File Offset: 0x0002648C
		public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x14000055 RID: 85
		// (add) Token: 0x06000A53 RID: 2643 RVA: 0x000282C8 File Offset: 0x000264C8
		// (remove) Token: 0x06000A54 RID: 2644 RVA: 0x00028304 File Offset: 0x00026504
		public event EventHandler OnIdleTimeoutNotification;

		// Token: 0x14000056 RID: 86
		// (add) Token: 0x06000A55 RID: 2645 RVA: 0x00028340 File Offset: 0x00026540
		// (remove) Token: 0x06000A56 RID: 2646 RVA: 0x0002837C File Offset: 0x0002657C
		public event EventHandler OnRequestContainerMinimize;

		// Token: 0x14000057 RID: 87
		// (add) Token: 0x06000A57 RID: 2647 RVA: 0x000283B8 File Offset: 0x000265B8
		// (remove) Token: 0x06000A58 RID: 2648 RVA: 0x000283F4 File Offset: 0x000265F4
		public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x14000058 RID: 88
		// (add) Token: 0x06000A59 RID: 2649 RVA: 0x00028430 File Offset: 0x00026630
		// (remove) Token: 0x06000A5A RID: 2650 RVA: 0x0002846C File Offset: 0x0002666C
		public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x14000059 RID: 89
		// (add) Token: 0x06000A5B RID: 2651 RVA: 0x000284A8 File Offset: 0x000266A8
		// (remove) Token: 0x06000A5C RID: 2652 RVA: 0x000284E4 File Offset: 0x000266E4
		public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x1400005A RID: 90
		// (add) Token: 0x06000A5D RID: 2653 RVA: 0x00028520 File Offset: 0x00026720
		// (remove) Token: 0x06000A5E RID: 2654 RVA: 0x0002855C File Offset: 0x0002675C
		public event EventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x1400005B RID: 91
		// (add) Token: 0x06000A5F RID: 2655 RVA: 0x00028598 File Offset: 0x00026798
		// (remove) Token: 0x06000A60 RID: 2656 RVA: 0x000285D4 File Offset: 0x000267D4
		public event EventHandler OnAuthenticationWarningDismissed;

		// Token: 0x1400005C RID: 92
		// (add) Token: 0x06000A61 RID: 2657 RVA: 0x00028610 File Offset: 0x00026810
		// (remove) Token: 0x06000A62 RID: 2658 RVA: 0x0002864C File Offset: 0x0002684C
		public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x1400005D RID: 93
		// (add) Token: 0x06000A63 RID: 2659 RVA: 0x00028688 File Offset: 0x00026888
		// (remove) Token: 0x06000A64 RID: 2660 RVA: 0x000286C4 File Offset: 0x000268C4
		public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x1400005E RID: 94
		// (add) Token: 0x06000A65 RID: 2661 RVA: 0x00028700 File Offset: 0x00026900
		// (remove) Token: 0x06000A66 RID: 2662 RVA: 0x0002873C File Offset: 0x0002693C
		public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x1400005F RID: 95
		// (add) Token: 0x06000A67 RID: 2663 RVA: 0x00028778 File Offset: 0x00026978
		// (remove) Token: 0x06000A68 RID: 2664 RVA: 0x000287B4 File Offset: 0x000269B4
		public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x14000060 RID: 96
		// (add) Token: 0x06000A69 RID: 2665 RVA: 0x000287F0 File Offset: 0x000269F0
		// (remove) Token: 0x06000A6A RID: 2666 RVA: 0x0002882C File Offset: 0x00026A2C
		public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x14000061 RID: 97
		// (add) Token: 0x06000A6B RID: 2667 RVA: 0x00028868 File Offset: 0x00026A68
		// (remove) Token: 0x06000A6C RID: 2668 RVA: 0x000288A4 File Offset: 0x00026AA4
		public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x14000062 RID: 98
		// (add) Token: 0x06000A6D RID: 2669 RVA: 0x000288E0 File Offset: 0x00026AE0
		// (remove) Token: 0x06000A6E RID: 2670 RVA: 0x0002891C File Offset: 0x00026B1C
		public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x14000063 RID: 99
		// (add) Token: 0x06000A6F RID: 2671 RVA: 0x00028958 File Offset: 0x00026B58
		// (remove) Token: 0x06000A70 RID: 2672 RVA: 0x00028994 File Offset: 0x00026B94
		public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x14000064 RID: 100
		// (add) Token: 0x06000A71 RID: 2673 RVA: 0x000289D0 File Offset: 0x00026BD0
		// (remove) Token: 0x06000A72 RID: 2674 RVA: 0x00028A0C File Offset: 0x00026C0C
		public event EventHandler OnConnectionBarPullDown;

		// Token: 0x14000065 RID: 101
		// (add) Token: 0x06000A73 RID: 2675 RVA: 0x00028A48 File Offset: 0x00026C48
		// (remove) Token: 0x06000A74 RID: 2676 RVA: 0x00028A84 File Offset: 0x00026C84
		public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x14000066 RID: 102
		// (add) Token: 0x06000A75 RID: 2677 RVA: 0x00028AC0 File Offset: 0x00026CC0
		// (remove) Token: 0x06000A76 RID: 2678 RVA: 0x00028AFC File Offset: 0x00026CFC
		public event EventHandler OnDevicesButtonPressed;

		// Token: 0x14000067 RID: 103
		// (add) Token: 0x06000A77 RID: 2679 RVA: 0x00028B38 File Offset: 0x00026D38
		// (remove) Token: 0x06000A78 RID: 2680 RVA: 0x00028B74 File Offset: 0x00026D74
		public event EventHandler OnAutoReconnected;

		// Token: 0x14000068 RID: 104
		// (add) Token: 0x06000A79 RID: 2681 RVA: 0x00028BB0 File Offset: 0x00026DB0
		// (remove) Token: 0x06000A7A RID: 2682 RVA: 0x00028BEC File Offset: 0x00026DEC
		public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

		// Token: 0x06000A7B RID: 2683 RVA: 0x00028C28 File Offset: 0x00026E28
		public virtual void Connect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Connect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Connect();
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x00028C4C File Offset: 0x00026E4C
		public virtual void Disconnect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Disconnect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Disconnect();
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x00028C70 File Offset: 0x00026E70
		public virtual void CreateVirtualChannels(string newVal)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("CreateVirtualChannels", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.CreateVirtualChannels(newVal);
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x00028C98 File Offset: 0x00026E98
		public virtual void SendOnVirtualChannel(string chanName, string chanData)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SendOnVirtualChannel", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SendOnVirtualChannel(chanName, chanData);
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x00028CC0 File Offset: 0x00026EC0
		public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SetVirtualChannelOptions(chanName, chanOptions);
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x00028CE8 File Offset: 0x00026EE8
		public virtual int GetVirtualChannelOptions(string chanName)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetVirtualChannelOptions(chanName);
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x00028D20 File Offset: 0x00026F20
		public virtual ControlCloseStatus RequestClose()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("RequestClose", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.RequestClose();
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x00028D58 File Offset: 0x00026F58
		protected override void CreateSink()
		{
			try
			{
				this.eventMulticaster = new AxMsRdpClient2NotSafeForScriptingEventMulticaster(this);
				this.cookie = new AxHost.ConnectionPointCookie(this.ocx, this.eventMulticaster, typeof(IMsTscAxEvents));
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x00028DB0 File Offset: 0x00026FB0
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

		// Token: 0x06000A84 RID: 2692 RVA: 0x00028DE4 File Offset: 0x00026FE4
		protected override void AttachInterfaces()
		{
			try
			{
				this.ocx = (IMsRdpClient2)base.GetOcx();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x00028E20 File Offset: 0x00027020
		internal void RaiseOnOnConnecting(object sender, EventArgs e)
		{
			if (this.OnConnecting != null)
			{
				this.OnConnecting(sender, e);
			}
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x00028E3C File Offset: 0x0002703C
		internal void RaiseOnOnConnected(object sender, EventArgs e)
		{
			if (this.OnConnected != null)
			{
				this.OnConnected(sender, e);
			}
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x00028E58 File Offset: 0x00027058
		internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
		{
			if (this.OnLoginComplete != null)
			{
				this.OnLoginComplete(sender, e);
			}
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x00028E74 File Offset: 0x00027074
		internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
		{
			if (this.OnDisconnected != null)
			{
				this.OnDisconnected(sender, e);
			}
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x00028E90 File Offset: 0x00027090
		internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnEnterFullScreenMode != null)
			{
				this.OnEnterFullScreenMode(sender, e);
			}
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x00028EAC File Offset: 0x000270AC
		internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnLeaveFullScreenMode != null)
			{
				this.OnLeaveFullScreenMode(sender, e);
			}
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x00028EC8 File Offset: 0x000270C8
		internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
		{
			if (this.OnChannelReceivedData != null)
			{
				this.OnChannelReceivedData(sender, e);
			}
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x00028EE4 File Offset: 0x000270E4
		internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestGoFullScreen != null)
			{
				this.OnRequestGoFullScreen(sender, e);
			}
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x00028F00 File Offset: 0x00027100
		internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestLeaveFullScreen != null)
			{
				this.OnRequestLeaveFullScreen(sender, e);
			}
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x00028F1C File Offset: 0x0002711C
		internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
		{
			if (this.OnFatalError != null)
			{
				this.OnFatalError(sender, e);
			}
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x00028F38 File Offset: 0x00027138
		internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
		{
			if (this.OnWarning != null)
			{
				this.OnWarning(sender, e);
			}
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x00028F54 File Offset: 0x00027154
		internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
		{
			if (this.OnRemoteDesktopSizeChange != null)
			{
				this.OnRemoteDesktopSizeChange(sender, e);
			}
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x00028F70 File Offset: 0x00027170
		internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
		{
			if (this.OnIdleTimeoutNotification != null)
			{
				this.OnIdleTimeoutNotification(sender, e);
			}
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x00028F8C File Offset: 0x0002718C
		internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
		{
			if (this.OnRequestContainerMinimize != null)
			{
				this.OnRequestContainerMinimize(sender, e);
			}
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x00028FA8 File Offset: 0x000271A8
		internal void RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
		{
			if (this.OnConfirmClose != null)
			{
				this.OnConfirmClose(sender, e);
			}
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x00028FC4 File Offset: 0x000271C4
		internal void RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
		{
			if (this.OnReceivedTSPublicKey != null)
			{
				this.OnReceivedTSPublicKey(sender, e);
			}
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x00028FE0 File Offset: 0x000271E0
		internal void RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
		{
			if (this.OnAutoReconnecting != null)
			{
				this.OnAutoReconnecting(sender, e);
			}
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x00028FFC File Offset: 0x000271FC
		internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDisplayed != null)
			{
				this.OnAuthenticationWarningDisplayed(sender, e);
			}
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x00029018 File Offset: 0x00027218
		internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDismissed != null)
			{
				this.OnAuthenticationWarningDismissed(sender, e);
			}
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x00029034 File Offset: 0x00027234
		internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
		{
			if (this.OnRemoteProgramResult != null)
			{
				this.OnRemoteProgramResult(sender, e);
			}
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x00029050 File Offset: 0x00027250
		internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
		{
			if (this.OnRemoteProgramDisplayed != null)
			{
				this.OnRemoteProgramDisplayed(sender, e);
			}
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x0002906C File Offset: 0x0002726C
		internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
		{
			if (this.OnRemoteWindowDisplayed != null)
			{
				this.OnRemoteWindowDisplayed(sender, e);
			}
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x00029088 File Offset: 0x00027288
		internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
		{
			if (this.OnLogonError != null)
			{
				this.OnLogonError(sender, e);
			}
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x000290A4 File Offset: 0x000272A4
		internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
		{
			if (this.OnFocusReleased != null)
			{
				this.OnFocusReleased(sender, e);
			}
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x000290C0 File Offset: 0x000272C0
		internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
		{
			if (this.OnUserNameAcquired != null)
			{
				this.OnUserNameAcquired(sender, e);
			}
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x000290DC File Offset: 0x000272DC
		internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
		{
			if (this.OnMouseInputModeChanged != null)
			{
				this.OnMouseInputModeChanged(sender, e);
			}
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x000290F8 File Offset: 0x000272F8
		internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
		{
			if (this.OnServiceMessageReceived != null)
			{
				this.OnServiceMessageReceived(sender, e);
			}
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x00029114 File Offset: 0x00027314
		internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
		{
			if (this.OnConnectionBarPullDown != null)
			{
				this.OnConnectionBarPullDown(sender, e);
			}
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x00029130 File Offset: 0x00027330
		internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
		{
			if (this.OnNetworkStatusChanged != null)
			{
				this.OnNetworkStatusChanged(sender, e);
			}
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x0002914C File Offset: 0x0002734C
		internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
		{
			if (this.OnDevicesButtonPressed != null)
			{
				this.OnDevicesButtonPressed(sender, e);
			}
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x00029168 File Offset: 0x00027368
		internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
		{
			if (this.OnAutoReconnected != null)
			{
				this.OnAutoReconnected(sender, e);
			}
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x00029184 File Offset: 0x00027384
		internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
		{
			if (this.OnAutoReconnecting2 != null)
			{
				this.OnAutoReconnecting2(sender, e);
			}
		}

		// Token: 0x040003D3 RID: 979
		private IMsRdpClient2 ocx;

		// Token: 0x040003D4 RID: 980
		private AxMsRdpClient2NotSafeForScriptingEventMulticaster eventMulticaster;

		// Token: 0x040003D5 RID: 981
		private AxHost.ConnectionPointCookie cookie;
	}
}
