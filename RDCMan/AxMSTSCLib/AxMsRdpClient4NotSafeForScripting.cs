using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MSTSCLib;

namespace AxMSTSCLib
{
	// Token: 0x02000126 RID: 294
	[AxHost.ClsidAttribute("{6ae29350-321b-42be-bbe5-12fb5270c0de}")]
	[DefaultEvent("OnConnecting")]
	[DesignTimeVisible(true)]
	[ComVisible(true)]
	public class AxMsRdpClient4NotSafeForScripting : AxHost
	{
		// Token: 0x06000E39 RID: 3641 RVA: 0x00033574 File Offset: 0x00031774
		public AxMsRdpClient4NotSafeForScripting() : base("6ae29350-321b-42be-bbe5-12fb5270c0de")
		{
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000E3A RID: 3642 RVA: 0x00033584 File Offset: 0x00031784
		// (set) Token: 0x06000E3B RID: 3643 RVA: 0x000335A8 File Offset: 0x000317A8
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

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000E3C RID: 3644 RVA: 0x000335D0 File Offset: 0x000317D0
		// (set) Token: 0x06000E3D RID: 3645 RVA: 0x000335F4 File Offset: 0x000317F4
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

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000E3E RID: 3646 RVA: 0x0003361C File Offset: 0x0003181C
		// (set) Token: 0x06000E3F RID: 3647 RVA: 0x00033640 File Offset: 0x00031840
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

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000E40 RID: 3648 RVA: 0x00033668 File Offset: 0x00031868
		// (set) Token: 0x06000E41 RID: 3649 RVA: 0x0003368C File Offset: 0x0003188C
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

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000E42 RID: 3650 RVA: 0x000336B4 File Offset: 0x000318B4
		// (set) Token: 0x06000E43 RID: 3651 RVA: 0x000336D8 File Offset: 0x000318D8
		[DispId(5)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000E44 RID: 3652 RVA: 0x00033700 File Offset: 0x00031900
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

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000E45 RID: 3653 RVA: 0x00033724 File Offset: 0x00031924
		// (set) Token: 0x06000E46 RID: 3654 RVA: 0x00033748 File Offset: 0x00031948
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

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000E47 RID: 3655 RVA: 0x00033770 File Offset: 0x00031970
		// (set) Token: 0x06000E48 RID: 3656 RVA: 0x00033794 File Offset: 0x00031994
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

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000E49 RID: 3657 RVA: 0x000337BC File Offset: 0x000319BC
		// (set) Token: 0x06000E4A RID: 3658 RVA: 0x000337E0 File Offset: 0x000319E0
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

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000E4B RID: 3659 RVA: 0x00033808 File Offset: 0x00031A08
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

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000E4C RID: 3660 RVA: 0x0003382C File Offset: 0x00031A2C
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

		// Token: 0x1700029E RID: 670
		// (set) Token: 0x06000E4D RID: 3661 RVA: 0x00033850 File Offset: 0x00031A50
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
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

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000E4E RID: 3662 RVA: 0x00033878 File Offset: 0x00031A78
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

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000E4F RID: 3663 RVA: 0x0003389C File Offset: 0x00031A9C
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

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000E50 RID: 3664 RVA: 0x000338C0 File Offset: 0x00031AC0
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

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000E51 RID: 3665 RVA: 0x000338E4 File Offset: 0x00031AE4
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
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

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000E52 RID: 3666 RVA: 0x00033908 File Offset: 0x00031B08
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

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000E53 RID: 3667 RVA: 0x0003392C File Offset: 0x00031B2C
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

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000E54 RID: 3668 RVA: 0x00033950 File Offset: 0x00031B50
		// (set) Token: 0x06000E55 RID: 3669 RVA: 0x00033974 File Offset: 0x00031B74
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

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000E56 RID: 3670 RVA: 0x0003399C File Offset: 0x00031B9C
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

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000E57 RID: 3671 RVA: 0x000339C0 File Offset: 0x00031BC0
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

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000E58 RID: 3672 RVA: 0x000339E4 File Offset: 0x00031BE4
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(103)]
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

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000E59 RID: 3673 RVA: 0x00033A08 File Offset: 0x00031C08
		// (set) Token: 0x06000E5A RID: 3674 RVA: 0x00033A2C File Offset: 0x00031C2C
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

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000E5B RID: 3675 RVA: 0x00033A54 File Offset: 0x00031C54
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

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000E5C RID: 3676 RVA: 0x00033A78 File Offset: 0x00031C78
		// (set) Token: 0x06000E5D RID: 3677 RVA: 0x00033A9C File Offset: 0x00031C9C
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

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000E5E RID: 3678 RVA: 0x00033AC4 File Offset: 0x00031CC4
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

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000E5F RID: 3679 RVA: 0x00033AE8 File Offset: 0x00031CE8
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(400)]
		[Browsable(false)]
		public virtual IMsRdpClientAdvancedSettings4 AdvancedSettings5
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("AdvancedSettings5", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.AdvancedSettings5;
			}
		}

		// Token: 0x14000109 RID: 265
		// (add) Token: 0x06000E60 RID: 3680 RVA: 0x00033B0C File Offset: 0x00031D0C
		// (remove) Token: 0x06000E61 RID: 3681 RVA: 0x00033B48 File Offset: 0x00031D48
		public event EventHandler OnConnecting;

		// Token: 0x1400010A RID: 266
		// (add) Token: 0x06000E62 RID: 3682 RVA: 0x00033B84 File Offset: 0x00031D84
		// (remove) Token: 0x06000E63 RID: 3683 RVA: 0x00033BC0 File Offset: 0x00031DC0
		public event EventHandler OnConnected;

		// Token: 0x1400010B RID: 267
		// (add) Token: 0x06000E64 RID: 3684 RVA: 0x00033BFC File Offset: 0x00031DFC
		// (remove) Token: 0x06000E65 RID: 3685 RVA: 0x00033C38 File Offset: 0x00031E38
		public event EventHandler OnLoginComplete;

		// Token: 0x1400010C RID: 268
		// (add) Token: 0x06000E66 RID: 3686 RVA: 0x00033C74 File Offset: 0x00031E74
		// (remove) Token: 0x06000E67 RID: 3687 RVA: 0x00033CB0 File Offset: 0x00031EB0
		public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x1400010D RID: 269
		// (add) Token: 0x06000E68 RID: 3688 RVA: 0x00033CEC File Offset: 0x00031EEC
		// (remove) Token: 0x06000E69 RID: 3689 RVA: 0x00033D28 File Offset: 0x00031F28
		public event EventHandler OnEnterFullScreenMode;

		// Token: 0x1400010E RID: 270
		// (add) Token: 0x06000E6A RID: 3690 RVA: 0x00033D64 File Offset: 0x00031F64
		// (remove) Token: 0x06000E6B RID: 3691 RVA: 0x00033DA0 File Offset: 0x00031FA0
		public event EventHandler OnLeaveFullScreenMode;

		// Token: 0x1400010F RID: 271
		// (add) Token: 0x06000E6C RID: 3692 RVA: 0x00033DDC File Offset: 0x00031FDC
		// (remove) Token: 0x06000E6D RID: 3693 RVA: 0x00033E18 File Offset: 0x00032018
		public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x14000110 RID: 272
		// (add) Token: 0x06000E6E RID: 3694 RVA: 0x00033E54 File Offset: 0x00032054
		// (remove) Token: 0x06000E6F RID: 3695 RVA: 0x00033E90 File Offset: 0x00032090
		public event EventHandler OnRequestGoFullScreen;

		// Token: 0x14000111 RID: 273
		// (add) Token: 0x06000E70 RID: 3696 RVA: 0x00033ECC File Offset: 0x000320CC
		// (remove) Token: 0x06000E71 RID: 3697 RVA: 0x00033F08 File Offset: 0x00032108
		public event EventHandler OnRequestLeaveFullScreen;

		// Token: 0x14000112 RID: 274
		// (add) Token: 0x06000E72 RID: 3698 RVA: 0x00033F44 File Offset: 0x00032144
		// (remove) Token: 0x06000E73 RID: 3699 RVA: 0x00033F80 File Offset: 0x00032180
		public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x14000113 RID: 275
		// (add) Token: 0x06000E74 RID: 3700 RVA: 0x00033FBC File Offset: 0x000321BC
		// (remove) Token: 0x06000E75 RID: 3701 RVA: 0x00033FF8 File Offset: 0x000321F8
		public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x14000114 RID: 276
		// (add) Token: 0x06000E76 RID: 3702 RVA: 0x00034034 File Offset: 0x00032234
		// (remove) Token: 0x06000E77 RID: 3703 RVA: 0x00034070 File Offset: 0x00032270
		public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x14000115 RID: 277
		// (add) Token: 0x06000E78 RID: 3704 RVA: 0x000340AC File Offset: 0x000322AC
		// (remove) Token: 0x06000E79 RID: 3705 RVA: 0x000340E8 File Offset: 0x000322E8
		public event EventHandler OnIdleTimeoutNotification;

		// Token: 0x14000116 RID: 278
		// (add) Token: 0x06000E7A RID: 3706 RVA: 0x00034124 File Offset: 0x00032324
		// (remove) Token: 0x06000E7B RID: 3707 RVA: 0x00034160 File Offset: 0x00032360
		public event EventHandler OnRequestContainerMinimize;

		// Token: 0x14000117 RID: 279
		// (add) Token: 0x06000E7C RID: 3708 RVA: 0x0003419C File Offset: 0x0003239C
		// (remove) Token: 0x06000E7D RID: 3709 RVA: 0x000341D8 File Offset: 0x000323D8
		public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x14000118 RID: 280
		// (add) Token: 0x06000E7E RID: 3710 RVA: 0x00034214 File Offset: 0x00032414
		// (remove) Token: 0x06000E7F RID: 3711 RVA: 0x00034250 File Offset: 0x00032450
		public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x14000119 RID: 281
		// (add) Token: 0x06000E80 RID: 3712 RVA: 0x0003428C File Offset: 0x0003248C
		// (remove) Token: 0x06000E81 RID: 3713 RVA: 0x000342C8 File Offset: 0x000324C8
		public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x1400011A RID: 282
		// (add) Token: 0x06000E82 RID: 3714 RVA: 0x00034304 File Offset: 0x00032504
		// (remove) Token: 0x06000E83 RID: 3715 RVA: 0x00034340 File Offset: 0x00032540
		public event EventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x1400011B RID: 283
		// (add) Token: 0x06000E84 RID: 3716 RVA: 0x0003437C File Offset: 0x0003257C
		// (remove) Token: 0x06000E85 RID: 3717 RVA: 0x000343B8 File Offset: 0x000325B8
		public event EventHandler OnAuthenticationWarningDismissed;

		// Token: 0x1400011C RID: 284
		// (add) Token: 0x06000E86 RID: 3718 RVA: 0x000343F4 File Offset: 0x000325F4
		// (remove) Token: 0x06000E87 RID: 3719 RVA: 0x00034430 File Offset: 0x00032630
		public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x1400011D RID: 285
		// (add) Token: 0x06000E88 RID: 3720 RVA: 0x0003446C File Offset: 0x0003266C
		// (remove) Token: 0x06000E89 RID: 3721 RVA: 0x000344A8 File Offset: 0x000326A8
		public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x1400011E RID: 286
		// (add) Token: 0x06000E8A RID: 3722 RVA: 0x000344E4 File Offset: 0x000326E4
		// (remove) Token: 0x06000E8B RID: 3723 RVA: 0x00034520 File Offset: 0x00032720
		public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x1400011F RID: 287
		// (add) Token: 0x06000E8C RID: 3724 RVA: 0x0003455C File Offset: 0x0003275C
		// (remove) Token: 0x06000E8D RID: 3725 RVA: 0x00034598 File Offset: 0x00032798
		public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x14000120 RID: 288
		// (add) Token: 0x06000E8E RID: 3726 RVA: 0x000345D4 File Offset: 0x000327D4
		// (remove) Token: 0x06000E8F RID: 3727 RVA: 0x00034610 File Offset: 0x00032810
		public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x14000121 RID: 289
		// (add) Token: 0x06000E90 RID: 3728 RVA: 0x0003464C File Offset: 0x0003284C
		// (remove) Token: 0x06000E91 RID: 3729 RVA: 0x00034688 File Offset: 0x00032888
		public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x14000122 RID: 290
		// (add) Token: 0x06000E92 RID: 3730 RVA: 0x000346C4 File Offset: 0x000328C4
		// (remove) Token: 0x06000E93 RID: 3731 RVA: 0x00034700 File Offset: 0x00032900
		public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x14000123 RID: 291
		// (add) Token: 0x06000E94 RID: 3732 RVA: 0x0003473C File Offset: 0x0003293C
		// (remove) Token: 0x06000E95 RID: 3733 RVA: 0x00034778 File Offset: 0x00032978
		public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x14000124 RID: 292
		// (add) Token: 0x06000E96 RID: 3734 RVA: 0x000347B4 File Offset: 0x000329B4
		// (remove) Token: 0x06000E97 RID: 3735 RVA: 0x000347F0 File Offset: 0x000329F0
		public event EventHandler OnConnectionBarPullDown;

		// Token: 0x14000125 RID: 293
		// (add) Token: 0x06000E98 RID: 3736 RVA: 0x0003482C File Offset: 0x00032A2C
		// (remove) Token: 0x06000E99 RID: 3737 RVA: 0x00034868 File Offset: 0x00032A68
		public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x14000126 RID: 294
		// (add) Token: 0x06000E9A RID: 3738 RVA: 0x000348A4 File Offset: 0x00032AA4
		// (remove) Token: 0x06000E9B RID: 3739 RVA: 0x000348E0 File Offset: 0x00032AE0
		public event EventHandler OnDevicesButtonPressed;

		// Token: 0x14000127 RID: 295
		// (add) Token: 0x06000E9C RID: 3740 RVA: 0x0003491C File Offset: 0x00032B1C
		// (remove) Token: 0x06000E9D RID: 3741 RVA: 0x00034958 File Offset: 0x00032B58
		public event EventHandler OnAutoReconnected;

		// Token: 0x14000128 RID: 296
		// (add) Token: 0x06000E9E RID: 3742 RVA: 0x00034994 File Offset: 0x00032B94
		// (remove) Token: 0x06000E9F RID: 3743 RVA: 0x000349D0 File Offset: 0x00032BD0
		public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

		// Token: 0x06000EA0 RID: 3744 RVA: 0x00034A0C File Offset: 0x00032C0C
		public virtual void Connect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Connect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Connect();
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x00034A30 File Offset: 0x00032C30
		public virtual void Disconnect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Disconnect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Disconnect();
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x00034A54 File Offset: 0x00032C54
		public virtual void CreateVirtualChannels(string newVal)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("CreateVirtualChannels", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.CreateVirtualChannels(newVal);
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x00034A7C File Offset: 0x00032C7C
		public virtual void SendOnVirtualChannel(string chanName, string chanData)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SendOnVirtualChannel", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SendOnVirtualChannel(chanName, chanData);
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x00034AA4 File Offset: 0x00032CA4
		public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SetVirtualChannelOptions(chanName, chanOptions);
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x00034ACC File Offset: 0x00032CCC
		public virtual int GetVirtualChannelOptions(string chanName)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetVirtualChannelOptions(chanName);
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x00034B04 File Offset: 0x00032D04
		public virtual ControlCloseStatus RequestClose()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("RequestClose", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.RequestClose();
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x00034B3C File Offset: 0x00032D3C
		protected override void CreateSink()
		{
			try
			{
				this.eventMulticaster = new AxMsRdpClient4NotSafeForScriptingEventMulticaster(this);
				this.cookie = new AxHost.ConnectionPointCookie(this.ocx, this.eventMulticaster, typeof(IMsTscAxEvents));
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x00034B94 File Offset: 0x00032D94
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

		// Token: 0x06000EA9 RID: 3753 RVA: 0x00034BC8 File Offset: 0x00032DC8
		protected override void AttachInterfaces()
		{
			try
			{
				this.ocx = (IMsRdpClient4)base.GetOcx();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x00034C04 File Offset: 0x00032E04
		internal void RaiseOnOnConnecting(object sender, EventArgs e)
		{
			if (this.OnConnecting != null)
			{
				this.OnConnecting(sender, e);
			}
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x00034C20 File Offset: 0x00032E20
		internal void RaiseOnOnConnected(object sender, EventArgs e)
		{
			if (this.OnConnected != null)
			{
				this.OnConnected(sender, e);
			}
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x00034C3C File Offset: 0x00032E3C
		internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
		{
			if (this.OnLoginComplete != null)
			{
				this.OnLoginComplete(sender, e);
			}
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x00034C58 File Offset: 0x00032E58
		internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
		{
			if (this.OnDisconnected != null)
			{
				this.OnDisconnected(sender, e);
			}
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x00034C74 File Offset: 0x00032E74
		internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnEnterFullScreenMode != null)
			{
				this.OnEnterFullScreenMode(sender, e);
			}
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x00034C90 File Offset: 0x00032E90
		internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnLeaveFullScreenMode != null)
			{
				this.OnLeaveFullScreenMode(sender, e);
			}
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x00034CAC File Offset: 0x00032EAC
		internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
		{
			if (this.OnChannelReceivedData != null)
			{
				this.OnChannelReceivedData(sender, e);
			}
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x00034CC8 File Offset: 0x00032EC8
		internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestGoFullScreen != null)
			{
				this.OnRequestGoFullScreen(sender, e);
			}
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x00034CE4 File Offset: 0x00032EE4
		internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestLeaveFullScreen != null)
			{
				this.OnRequestLeaveFullScreen(sender, e);
			}
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x00034D00 File Offset: 0x00032F00
		internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
		{
			if (this.OnFatalError != null)
			{
				this.OnFatalError(sender, e);
			}
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x00034D1C File Offset: 0x00032F1C
		internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
		{
			if (this.OnWarning != null)
			{
				this.OnWarning(sender, e);
			}
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x00034D38 File Offset: 0x00032F38
		internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
		{
			if (this.OnRemoteDesktopSizeChange != null)
			{
				this.OnRemoteDesktopSizeChange(sender, e);
			}
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x00034D54 File Offset: 0x00032F54
		internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
		{
			if (this.OnIdleTimeoutNotification != null)
			{
				this.OnIdleTimeoutNotification(sender, e);
			}
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x00034D70 File Offset: 0x00032F70
		internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
		{
			if (this.OnRequestContainerMinimize != null)
			{
				this.OnRequestContainerMinimize(sender, e);
			}
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x00034D8C File Offset: 0x00032F8C
		internal void RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
		{
			if (this.OnConfirmClose != null)
			{
				this.OnConfirmClose(sender, e);
			}
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x00034DA8 File Offset: 0x00032FA8
		internal void RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
		{
			if (this.OnReceivedTSPublicKey != null)
			{
				this.OnReceivedTSPublicKey(sender, e);
			}
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x00034DC4 File Offset: 0x00032FC4
		internal void RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
		{
			if (this.OnAutoReconnecting != null)
			{
				this.OnAutoReconnecting(sender, e);
			}
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x00034DE0 File Offset: 0x00032FE0
		internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDisplayed != null)
			{
				this.OnAuthenticationWarningDisplayed(sender, e);
			}
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x00034DFC File Offset: 0x00032FFC
		internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDismissed != null)
			{
				this.OnAuthenticationWarningDismissed(sender, e);
			}
		}

		// Token: 0x06000EBD RID: 3773 RVA: 0x00034E18 File Offset: 0x00033018
		internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
		{
			if (this.OnRemoteProgramResult != null)
			{
				this.OnRemoteProgramResult(sender, e);
			}
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x00034E34 File Offset: 0x00033034
		internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
		{
			if (this.OnRemoteProgramDisplayed != null)
			{
				this.OnRemoteProgramDisplayed(sender, e);
			}
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x00034E50 File Offset: 0x00033050
		internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
		{
			if (this.OnRemoteWindowDisplayed != null)
			{
				this.OnRemoteWindowDisplayed(sender, e);
			}
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x00034E6C File Offset: 0x0003306C
		internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
		{
			if (this.OnLogonError != null)
			{
				this.OnLogonError(sender, e);
			}
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x00034E88 File Offset: 0x00033088
		internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
		{
			if (this.OnFocusReleased != null)
			{
				this.OnFocusReleased(sender, e);
			}
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x00034EA4 File Offset: 0x000330A4
		internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
		{
			if (this.OnUserNameAcquired != null)
			{
				this.OnUserNameAcquired(sender, e);
			}
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x00034EC0 File Offset: 0x000330C0
		internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
		{
			if (this.OnMouseInputModeChanged != null)
			{
				this.OnMouseInputModeChanged(sender, e);
			}
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x00034EDC File Offset: 0x000330DC
		internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
		{
			if (this.OnServiceMessageReceived != null)
			{
				this.OnServiceMessageReceived(sender, e);
			}
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x00034EF8 File Offset: 0x000330F8
		internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
		{
			if (this.OnConnectionBarPullDown != null)
			{
				this.OnConnectionBarPullDown(sender, e);
			}
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x00034F14 File Offset: 0x00033114
		internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
		{
			if (this.OnNetworkStatusChanged != null)
			{
				this.OnNetworkStatusChanged(sender, e);
			}
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x00034F30 File Offset: 0x00033130
		internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
		{
			if (this.OnDevicesButtonPressed != null)
			{
				this.OnDevicesButtonPressed(sender, e);
			}
		}

		// Token: 0x06000EC8 RID: 3784 RVA: 0x00034F4C File Offset: 0x0003314C
		internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
		{
			if (this.OnAutoReconnected != null)
			{
				this.OnAutoReconnected(sender, e);
			}
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x00034F68 File Offset: 0x00033168
		internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
		{
			if (this.OnAutoReconnecting2 != null)
			{
				this.OnAutoReconnecting2(sender, e);
			}
		}

		// Token: 0x040004AB RID: 1195
		private IMsRdpClient4 ocx;

		// Token: 0x040004AC RID: 1196
		private AxMsRdpClient4NotSafeForScriptingEventMulticaster eventMulticaster;

		// Token: 0x040004AD RID: 1197
		private AxHost.ConnectionPointCookie cookie;
	}
}
