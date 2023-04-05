using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MSTSCLib;

namespace AxMSTSCLib
{
	// Token: 0x0200011C RID: 284
	[AxHost.ClsidAttribute("{9059f30f-4eb1-4bd2-9fdc-36f43a218f4a}")]
	[DefaultEvent("OnConnecting")]
	[DesignTimeVisible(true)]
	[ComVisible(true)]
	public class AxMsRdpClient2 : AxHost
	{
		// Token: 0x06000AC6 RID: 2758 RVA: 0x00029760 File Offset: 0x00027960
		public AxMsRdpClient2() : base("9059f30f-4eb1-4bd2-9fdc-36f43a218f4a")
		{
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000AC7 RID: 2759 RVA: 0x00029770 File Offset: 0x00027970
		// (set) Token: 0x06000AC8 RID: 2760 RVA: 0x00029794 File Offset: 0x00027994
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

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000AC9 RID: 2761 RVA: 0x000297BC File Offset: 0x000279BC
		// (set) Token: 0x06000ACA RID: 2762 RVA: 0x000297E0 File Offset: 0x000279E0
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

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x00029808 File Offset: 0x00027A08
		// (set) Token: 0x06000ACC RID: 2764 RVA: 0x0002982C File Offset: 0x00027A2C
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

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000ACD RID: 2765 RVA: 0x00029854 File Offset: 0x00027A54
		// (set) Token: 0x06000ACE RID: 2766 RVA: 0x00029878 File Offset: 0x00027A78
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

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x000298A0 File Offset: 0x00027AA0
		// (set) Token: 0x06000AD0 RID: 2768 RVA: 0x000298C4 File Offset: 0x00027AC4
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

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x000298EC File Offset: 0x00027AEC
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

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000AD2 RID: 2770 RVA: 0x00029910 File Offset: 0x00027B10
		// (set) Token: 0x06000AD3 RID: 2771 RVA: 0x00029934 File Offset: 0x00027B34
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

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000AD4 RID: 2772 RVA: 0x0002995C File Offset: 0x00027B5C
		// (set) Token: 0x06000AD5 RID: 2773 RVA: 0x00029980 File Offset: 0x00027B80
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

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000AD6 RID: 2774 RVA: 0x000299A8 File Offset: 0x00027BA8
		// (set) Token: 0x06000AD7 RID: 2775 RVA: 0x000299CC File Offset: 0x00027BCC
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

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000AD8 RID: 2776 RVA: 0x000299F4 File Offset: 0x00027BF4
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

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x00029A18 File Offset: 0x00027C18
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

		// Token: 0x1700021E RID: 542
		// (set) Token: 0x06000ADA RID: 2778 RVA: 0x00029A3C File Offset: 0x00027C3C
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

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000ADB RID: 2779 RVA: 0x00029A64 File Offset: 0x00027C64
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

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000ADC RID: 2780 RVA: 0x00029A88 File Offset: 0x00027C88
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

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000ADD RID: 2781 RVA: 0x00029AAC File Offset: 0x00027CAC
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

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000ADE RID: 2782 RVA: 0x00029AD0 File Offset: 0x00027CD0
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

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x00029AF4 File Offset: 0x00027CF4
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
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

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x00029B18 File Offset: 0x00027D18
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

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x00029B3C File Offset: 0x00027D3C
		// (set) Token: 0x06000AE2 RID: 2786 RVA: 0x00029B60 File Offset: 0x00027D60
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

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000AE3 RID: 2787 RVA: 0x00029B88 File Offset: 0x00027D88
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

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000AE4 RID: 2788 RVA: 0x00029BAC File Offset: 0x00027DAC
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		[DispId(102)]
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

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000AE5 RID: 2789 RVA: 0x00029BD0 File Offset: 0x00027DD0
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

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000AE6 RID: 2790 RVA: 0x00029BF4 File Offset: 0x00027DF4
		// (set) Token: 0x06000AE7 RID: 2791 RVA: 0x00029C18 File Offset: 0x00027E18
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

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000AE8 RID: 2792 RVA: 0x00029C40 File Offset: 0x00027E40
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

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000AE9 RID: 2793 RVA: 0x00029C64 File Offset: 0x00027E64
		// (set) Token: 0x06000AEA RID: 2794 RVA: 0x00029C88 File Offset: 0x00027E88
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

		// Token: 0x14000069 RID: 105
		// (add) Token: 0x06000AEB RID: 2795 RVA: 0x00029CB0 File Offset: 0x00027EB0
		// (remove) Token: 0x06000AEC RID: 2796 RVA: 0x00029CEC File Offset: 0x00027EEC
		public event EventHandler OnConnecting;

		// Token: 0x1400006A RID: 106
		// (add) Token: 0x06000AED RID: 2797 RVA: 0x00029D28 File Offset: 0x00027F28
		// (remove) Token: 0x06000AEE RID: 2798 RVA: 0x00029D64 File Offset: 0x00027F64
		public event EventHandler OnConnected;

		// Token: 0x1400006B RID: 107
		// (add) Token: 0x06000AEF RID: 2799 RVA: 0x00029DA0 File Offset: 0x00027FA0
		// (remove) Token: 0x06000AF0 RID: 2800 RVA: 0x00029DDC File Offset: 0x00027FDC
		public event EventHandler OnLoginComplete;

		// Token: 0x1400006C RID: 108
		// (add) Token: 0x06000AF1 RID: 2801 RVA: 0x00029E18 File Offset: 0x00028018
		// (remove) Token: 0x06000AF2 RID: 2802 RVA: 0x00029E54 File Offset: 0x00028054
		public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x1400006D RID: 109
		// (add) Token: 0x06000AF3 RID: 2803 RVA: 0x00029E90 File Offset: 0x00028090
		// (remove) Token: 0x06000AF4 RID: 2804 RVA: 0x00029ECC File Offset: 0x000280CC
		public event EventHandler OnEnterFullScreenMode;

		// Token: 0x1400006E RID: 110
		// (add) Token: 0x06000AF5 RID: 2805 RVA: 0x00029F08 File Offset: 0x00028108
		// (remove) Token: 0x06000AF6 RID: 2806 RVA: 0x00029F44 File Offset: 0x00028144
		public event EventHandler OnLeaveFullScreenMode;

		// Token: 0x1400006F RID: 111
		// (add) Token: 0x06000AF7 RID: 2807 RVA: 0x00029F80 File Offset: 0x00028180
		// (remove) Token: 0x06000AF8 RID: 2808 RVA: 0x00029FBC File Offset: 0x000281BC
		public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x14000070 RID: 112
		// (add) Token: 0x06000AF9 RID: 2809 RVA: 0x00029FF8 File Offset: 0x000281F8
		// (remove) Token: 0x06000AFA RID: 2810 RVA: 0x0002A034 File Offset: 0x00028234
		public event EventHandler OnRequestGoFullScreen;

		// Token: 0x14000071 RID: 113
		// (add) Token: 0x06000AFB RID: 2811 RVA: 0x0002A070 File Offset: 0x00028270
		// (remove) Token: 0x06000AFC RID: 2812 RVA: 0x0002A0AC File Offset: 0x000282AC
		public event EventHandler OnRequestLeaveFullScreen;

		// Token: 0x14000072 RID: 114
		// (add) Token: 0x06000AFD RID: 2813 RVA: 0x0002A0E8 File Offset: 0x000282E8
		// (remove) Token: 0x06000AFE RID: 2814 RVA: 0x0002A124 File Offset: 0x00028324
		public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x14000073 RID: 115
		// (add) Token: 0x06000AFF RID: 2815 RVA: 0x0002A160 File Offset: 0x00028360
		// (remove) Token: 0x06000B00 RID: 2816 RVA: 0x0002A19C File Offset: 0x0002839C
		public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x14000074 RID: 116
		// (add) Token: 0x06000B01 RID: 2817 RVA: 0x0002A1D8 File Offset: 0x000283D8
		// (remove) Token: 0x06000B02 RID: 2818 RVA: 0x0002A214 File Offset: 0x00028414
		public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x14000075 RID: 117
		// (add) Token: 0x06000B03 RID: 2819 RVA: 0x0002A250 File Offset: 0x00028450
		// (remove) Token: 0x06000B04 RID: 2820 RVA: 0x0002A28C File Offset: 0x0002848C
		public event EventHandler OnIdleTimeoutNotification;

		// Token: 0x14000076 RID: 118
		// (add) Token: 0x06000B05 RID: 2821 RVA: 0x0002A2C8 File Offset: 0x000284C8
		// (remove) Token: 0x06000B06 RID: 2822 RVA: 0x0002A304 File Offset: 0x00028504
		public event EventHandler OnRequestContainerMinimize;

		// Token: 0x14000077 RID: 119
		// (add) Token: 0x06000B07 RID: 2823 RVA: 0x0002A340 File Offset: 0x00028540
		// (remove) Token: 0x06000B08 RID: 2824 RVA: 0x0002A37C File Offset: 0x0002857C
		public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x14000078 RID: 120
		// (add) Token: 0x06000B09 RID: 2825 RVA: 0x0002A3B8 File Offset: 0x000285B8
		// (remove) Token: 0x06000B0A RID: 2826 RVA: 0x0002A3F4 File Offset: 0x000285F4
		public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x14000079 RID: 121
		// (add) Token: 0x06000B0B RID: 2827 RVA: 0x0002A430 File Offset: 0x00028630
		// (remove) Token: 0x06000B0C RID: 2828 RVA: 0x0002A46C File Offset: 0x0002866C
		public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x1400007A RID: 122
		// (add) Token: 0x06000B0D RID: 2829 RVA: 0x0002A4A8 File Offset: 0x000286A8
		// (remove) Token: 0x06000B0E RID: 2830 RVA: 0x0002A4E4 File Offset: 0x000286E4
		public event EventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x1400007B RID: 123
		// (add) Token: 0x06000B0F RID: 2831 RVA: 0x0002A520 File Offset: 0x00028720
		// (remove) Token: 0x06000B10 RID: 2832 RVA: 0x0002A55C File Offset: 0x0002875C
		public event EventHandler OnAuthenticationWarningDismissed;

		// Token: 0x1400007C RID: 124
		// (add) Token: 0x06000B11 RID: 2833 RVA: 0x0002A598 File Offset: 0x00028798
		// (remove) Token: 0x06000B12 RID: 2834 RVA: 0x0002A5D4 File Offset: 0x000287D4
		public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x1400007D RID: 125
		// (add) Token: 0x06000B13 RID: 2835 RVA: 0x0002A610 File Offset: 0x00028810
		// (remove) Token: 0x06000B14 RID: 2836 RVA: 0x0002A64C File Offset: 0x0002884C
		public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x1400007E RID: 126
		// (add) Token: 0x06000B15 RID: 2837 RVA: 0x0002A688 File Offset: 0x00028888
		// (remove) Token: 0x06000B16 RID: 2838 RVA: 0x0002A6C4 File Offset: 0x000288C4
		public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x1400007F RID: 127
		// (add) Token: 0x06000B17 RID: 2839 RVA: 0x0002A700 File Offset: 0x00028900
		// (remove) Token: 0x06000B18 RID: 2840 RVA: 0x0002A73C File Offset: 0x0002893C
		public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x14000080 RID: 128
		// (add) Token: 0x06000B19 RID: 2841 RVA: 0x0002A778 File Offset: 0x00028978
		// (remove) Token: 0x06000B1A RID: 2842 RVA: 0x0002A7B4 File Offset: 0x000289B4
		public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x14000081 RID: 129
		// (add) Token: 0x06000B1B RID: 2843 RVA: 0x0002A7F0 File Offset: 0x000289F0
		// (remove) Token: 0x06000B1C RID: 2844 RVA: 0x0002A82C File Offset: 0x00028A2C
		public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x14000082 RID: 130
		// (add) Token: 0x06000B1D RID: 2845 RVA: 0x0002A868 File Offset: 0x00028A68
		// (remove) Token: 0x06000B1E RID: 2846 RVA: 0x0002A8A4 File Offset: 0x00028AA4
		public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x14000083 RID: 131
		// (add) Token: 0x06000B1F RID: 2847 RVA: 0x0002A8E0 File Offset: 0x00028AE0
		// (remove) Token: 0x06000B20 RID: 2848 RVA: 0x0002A91C File Offset: 0x00028B1C
		public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x14000084 RID: 132
		// (add) Token: 0x06000B21 RID: 2849 RVA: 0x0002A958 File Offset: 0x00028B58
		// (remove) Token: 0x06000B22 RID: 2850 RVA: 0x0002A994 File Offset: 0x00028B94
		public event EventHandler OnConnectionBarPullDown;

		// Token: 0x14000085 RID: 133
		// (add) Token: 0x06000B23 RID: 2851 RVA: 0x0002A9D0 File Offset: 0x00028BD0
		// (remove) Token: 0x06000B24 RID: 2852 RVA: 0x0002AA0C File Offset: 0x00028C0C
		public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x14000086 RID: 134
		// (add) Token: 0x06000B25 RID: 2853 RVA: 0x0002AA48 File Offset: 0x00028C48
		// (remove) Token: 0x06000B26 RID: 2854 RVA: 0x0002AA84 File Offset: 0x00028C84
		public event EventHandler OnDevicesButtonPressed;

		// Token: 0x14000087 RID: 135
		// (add) Token: 0x06000B27 RID: 2855 RVA: 0x0002AAC0 File Offset: 0x00028CC0
		// (remove) Token: 0x06000B28 RID: 2856 RVA: 0x0002AAFC File Offset: 0x00028CFC
		public event EventHandler OnAutoReconnected;

		// Token: 0x14000088 RID: 136
		// (add) Token: 0x06000B29 RID: 2857 RVA: 0x0002AB38 File Offset: 0x00028D38
		// (remove) Token: 0x06000B2A RID: 2858 RVA: 0x0002AB74 File Offset: 0x00028D74
		public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

		// Token: 0x06000B2B RID: 2859 RVA: 0x0002ABB0 File Offset: 0x00028DB0
		public virtual void Connect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Connect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Connect();
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x0002ABD4 File Offset: 0x00028DD4
		public virtual void Disconnect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Disconnect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Disconnect();
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x0002ABF8 File Offset: 0x00028DF8
		public virtual void CreateVirtualChannels(string newVal)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("CreateVirtualChannels", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.CreateVirtualChannels(newVal);
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x0002AC20 File Offset: 0x00028E20
		public virtual void SendOnVirtualChannel(string chanName, string chanData)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SendOnVirtualChannel", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SendOnVirtualChannel(chanName, chanData);
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x0002AC48 File Offset: 0x00028E48
		public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SetVirtualChannelOptions(chanName, chanOptions);
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x0002AC70 File Offset: 0x00028E70
		public virtual int GetVirtualChannelOptions(string chanName)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetVirtualChannelOptions(chanName);
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x0002ACA8 File Offset: 0x00028EA8
		public virtual ControlCloseStatus RequestClose()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("RequestClose", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.RequestClose();
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x0002ACE0 File Offset: 0x00028EE0
		protected override void CreateSink()
		{
			try
			{
				this.eventMulticaster = new AxMsRdpClient2EventMulticaster(this);
				this.cookie = new AxHost.ConnectionPointCookie(this.ocx, this.eventMulticaster, typeof(IMsTscAxEvents));
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x0002AD38 File Offset: 0x00028F38
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

		// Token: 0x06000B34 RID: 2868 RVA: 0x0002AD6C File Offset: 0x00028F6C
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

		// Token: 0x06000B35 RID: 2869 RVA: 0x0002ADA8 File Offset: 0x00028FA8
		internal void RaiseOnOnConnecting(object sender, EventArgs e)
		{
			if (this.OnConnecting != null)
			{
				this.OnConnecting(sender, e);
			}
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x0002ADC4 File Offset: 0x00028FC4
		internal void RaiseOnOnConnected(object sender, EventArgs e)
		{
			if (this.OnConnected != null)
			{
				this.OnConnected(sender, e);
			}
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x0002ADE0 File Offset: 0x00028FE0
		internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
		{
			if (this.OnLoginComplete != null)
			{
				this.OnLoginComplete(sender, e);
			}
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x0002ADFC File Offset: 0x00028FFC
		internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
		{
			if (this.OnDisconnected != null)
			{
				this.OnDisconnected(sender, e);
			}
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x0002AE18 File Offset: 0x00029018
		internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnEnterFullScreenMode != null)
			{
				this.OnEnterFullScreenMode(sender, e);
			}
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x0002AE34 File Offset: 0x00029034
		internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnLeaveFullScreenMode != null)
			{
				this.OnLeaveFullScreenMode(sender, e);
			}
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x0002AE50 File Offset: 0x00029050
		internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
		{
			if (this.OnChannelReceivedData != null)
			{
				this.OnChannelReceivedData(sender, e);
			}
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x0002AE6C File Offset: 0x0002906C
		internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestGoFullScreen != null)
			{
				this.OnRequestGoFullScreen(sender, e);
			}
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x0002AE88 File Offset: 0x00029088
		internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestLeaveFullScreen != null)
			{
				this.OnRequestLeaveFullScreen(sender, e);
			}
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x0002AEA4 File Offset: 0x000290A4
		internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
		{
			if (this.OnFatalError != null)
			{
				this.OnFatalError(sender, e);
			}
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x0002AEC0 File Offset: 0x000290C0
		internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
		{
			if (this.OnWarning != null)
			{
				this.OnWarning(sender, e);
			}
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x0002AEDC File Offset: 0x000290DC
		internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
		{
			if (this.OnRemoteDesktopSizeChange != null)
			{
				this.OnRemoteDesktopSizeChange(sender, e);
			}
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x0002AEF8 File Offset: 0x000290F8
		internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
		{
			if (this.OnIdleTimeoutNotification != null)
			{
				this.OnIdleTimeoutNotification(sender, e);
			}
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x0002AF14 File Offset: 0x00029114
		internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
		{
			if (this.OnRequestContainerMinimize != null)
			{
				this.OnRequestContainerMinimize(sender, e);
			}
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x0002AF30 File Offset: 0x00029130
		internal void RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
		{
			if (this.OnConfirmClose != null)
			{
				this.OnConfirmClose(sender, e);
			}
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x0002AF4C File Offset: 0x0002914C
		internal void RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
		{
			if (this.OnReceivedTSPublicKey != null)
			{
				this.OnReceivedTSPublicKey(sender, e);
			}
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x0002AF68 File Offset: 0x00029168
		internal void RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
		{
			if (this.OnAutoReconnecting != null)
			{
				this.OnAutoReconnecting(sender, e);
			}
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x0002AF84 File Offset: 0x00029184
		internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDisplayed != null)
			{
				this.OnAuthenticationWarningDisplayed(sender, e);
			}
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x0002AFA0 File Offset: 0x000291A0
		internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDismissed != null)
			{
				this.OnAuthenticationWarningDismissed(sender, e);
			}
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x0002AFBC File Offset: 0x000291BC
		internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
		{
			if (this.OnRemoteProgramResult != null)
			{
				this.OnRemoteProgramResult(sender, e);
			}
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x0002AFD8 File Offset: 0x000291D8
		internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
		{
			if (this.OnRemoteProgramDisplayed != null)
			{
				this.OnRemoteProgramDisplayed(sender, e);
			}
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x0002AFF4 File Offset: 0x000291F4
		internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
		{
			if (this.OnRemoteWindowDisplayed != null)
			{
				this.OnRemoteWindowDisplayed(sender, e);
			}
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x0002B010 File Offset: 0x00029210
		internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
		{
			if (this.OnLogonError != null)
			{
				this.OnLogonError(sender, e);
			}
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x0002B02C File Offset: 0x0002922C
		internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
		{
			if (this.OnFocusReleased != null)
			{
				this.OnFocusReleased(sender, e);
			}
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x0002B048 File Offset: 0x00029248
		internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
		{
			if (this.OnUserNameAcquired != null)
			{
				this.OnUserNameAcquired(sender, e);
			}
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x0002B064 File Offset: 0x00029264
		internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
		{
			if (this.OnMouseInputModeChanged != null)
			{
				this.OnMouseInputModeChanged(sender, e);
			}
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x0002B080 File Offset: 0x00029280
		internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
		{
			if (this.OnServiceMessageReceived != null)
			{
				this.OnServiceMessageReceived(sender, e);
			}
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x0002B09C File Offset: 0x0002929C
		internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
		{
			if (this.OnConnectionBarPullDown != null)
			{
				this.OnConnectionBarPullDown(sender, e);
			}
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x0002B0B8 File Offset: 0x000292B8
		internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
		{
			if (this.OnNetworkStatusChanged != null)
			{
				this.OnNetworkStatusChanged(sender, e);
			}
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x0002B0D4 File Offset: 0x000292D4
		internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
		{
			if (this.OnDevicesButtonPressed != null)
			{
				this.OnDevicesButtonPressed(sender, e);
			}
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x0002B0F0 File Offset: 0x000292F0
		internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
		{
			if (this.OnAutoReconnected != null)
			{
				this.OnAutoReconnected(sender, e);
			}
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x0002B10C File Offset: 0x0002930C
		internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
		{
			if (this.OnAutoReconnecting2 != null)
			{
				this.OnAutoReconnecting2(sender, e);
			}
		}

		// Token: 0x040003F7 RID: 1015
		private IMsRdpClient2 ocx;

		// Token: 0x040003F8 RID: 1016
		private AxMsRdpClient2EventMulticaster eventMulticaster;

		// Token: 0x040003F9 RID: 1017
		private AxHost.ConnectionPointCookie cookie;
	}
}
