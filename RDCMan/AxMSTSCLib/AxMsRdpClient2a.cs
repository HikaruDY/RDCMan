using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MSTSCLib;

namespace AxMSTSCLib
{
	// Token: 0x0200011E RID: 286
	[DesignTimeVisible(true)]
	[DefaultEvent("OnConnecting")]
	[AxHost.ClsidAttribute("{971127bb-259f-48c2-bd75-5f97a3331551}")]
	[ComVisible(true)]
	public class AxMsRdpClient2a : AxHost
	{
		// Token: 0x06000B76 RID: 2934 RVA: 0x0002B6E8 File Offset: 0x000298E8
		public AxMsRdpClient2a() : base("971127bb-259f-48c2-bd75-5f97a3331551")
		{
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000B77 RID: 2935 RVA: 0x0002B6F8 File Offset: 0x000298F8
		// (set) Token: 0x06000B78 RID: 2936 RVA: 0x0002B71C File Offset: 0x0002991C
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

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000B79 RID: 2937 RVA: 0x0002B744 File Offset: 0x00029944
		// (set) Token: 0x06000B7A RID: 2938 RVA: 0x0002B768 File Offset: 0x00029968
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

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x0002B790 File Offset: 0x00029990
		// (set) Token: 0x06000B7C RID: 2940 RVA: 0x0002B7B4 File Offset: 0x000299B4
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

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000B7D RID: 2941 RVA: 0x0002B7DC File Offset: 0x000299DC
		// (set) Token: 0x06000B7E RID: 2942 RVA: 0x0002B800 File Offset: 0x00029A00
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

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000B7F RID: 2943 RVA: 0x0002B828 File Offset: 0x00029A28
		// (set) Token: 0x06000B80 RID: 2944 RVA: 0x0002B84C File Offset: 0x00029A4C
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

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000B81 RID: 2945 RVA: 0x0002B874 File Offset: 0x00029A74
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

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000B82 RID: 2946 RVA: 0x0002B898 File Offset: 0x00029A98
		// (set) Token: 0x06000B83 RID: 2947 RVA: 0x0002B8BC File Offset: 0x00029ABC
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

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000B84 RID: 2948 RVA: 0x0002B8E4 File Offset: 0x00029AE4
		// (set) Token: 0x06000B85 RID: 2949 RVA: 0x0002B908 File Offset: 0x00029B08
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

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000B86 RID: 2950 RVA: 0x0002B930 File Offset: 0x00029B30
		// (set) Token: 0x06000B87 RID: 2951 RVA: 0x0002B954 File Offset: 0x00029B54
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

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000B88 RID: 2952 RVA: 0x0002B97C File Offset: 0x00029B7C
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

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000B89 RID: 2953 RVA: 0x0002B9A0 File Offset: 0x00029BA0
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

		// Token: 0x17000237 RID: 567
		// (set) Token: 0x06000B8A RID: 2954 RVA: 0x0002B9C4 File Offset: 0x00029BC4
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(19)]
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

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000B8B RID: 2955 RVA: 0x0002B9EC File Offset: 0x00029BEC
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

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000B8C RID: 2956 RVA: 0x0002BA10 File Offset: 0x00029C10
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

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000B8D RID: 2957 RVA: 0x0002BA34 File Offset: 0x00029C34
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

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000B8E RID: 2958 RVA: 0x0002BA58 File Offset: 0x00029C58
		[DispId(97)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000B8F RID: 2959 RVA: 0x0002BA7C File Offset: 0x00029C7C
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

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000B90 RID: 2960 RVA: 0x0002BAA0 File Offset: 0x00029CA0
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

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000B91 RID: 2961 RVA: 0x0002BAC4 File Offset: 0x00029CC4
		// (set) Token: 0x06000B92 RID: 2962 RVA: 0x0002BAE8 File Offset: 0x00029CE8
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

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000B93 RID: 2963 RVA: 0x0002BB10 File Offset: 0x00029D10
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

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000B94 RID: 2964 RVA: 0x0002BB34 File Offset: 0x00029D34
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(102)]
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

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000B95 RID: 2965 RVA: 0x0002BB58 File Offset: 0x00029D58
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

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000B96 RID: 2966 RVA: 0x0002BB7C File Offset: 0x00029D7C
		// (set) Token: 0x06000B97 RID: 2967 RVA: 0x0002BBA0 File Offset: 0x00029DA0
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

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000B98 RID: 2968 RVA: 0x0002BBC8 File Offset: 0x00029DC8
		[Browsable(false)]
		[DispId(200)]
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

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000B99 RID: 2969 RVA: 0x0002BBEC File Offset: 0x00029DEC
		// (set) Token: 0x06000B9A RID: 2970 RVA: 0x0002BC10 File Offset: 0x00029E10
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

		// Token: 0x14000089 RID: 137
		// (add) Token: 0x06000B9B RID: 2971 RVA: 0x0002BC38 File Offset: 0x00029E38
		// (remove) Token: 0x06000B9C RID: 2972 RVA: 0x0002BC74 File Offset: 0x00029E74
		public event EventHandler OnConnecting;

		// Token: 0x1400008A RID: 138
		// (add) Token: 0x06000B9D RID: 2973 RVA: 0x0002BCB0 File Offset: 0x00029EB0
		// (remove) Token: 0x06000B9E RID: 2974 RVA: 0x0002BCEC File Offset: 0x00029EEC
		public event EventHandler OnConnected;

		// Token: 0x1400008B RID: 139
		// (add) Token: 0x06000B9F RID: 2975 RVA: 0x0002BD28 File Offset: 0x00029F28
		// (remove) Token: 0x06000BA0 RID: 2976 RVA: 0x0002BD64 File Offset: 0x00029F64
		public event EventHandler OnLoginComplete;

		// Token: 0x1400008C RID: 140
		// (add) Token: 0x06000BA1 RID: 2977 RVA: 0x0002BDA0 File Offset: 0x00029FA0
		// (remove) Token: 0x06000BA2 RID: 2978 RVA: 0x0002BDDC File Offset: 0x00029FDC
		public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x1400008D RID: 141
		// (add) Token: 0x06000BA3 RID: 2979 RVA: 0x0002BE18 File Offset: 0x0002A018
		// (remove) Token: 0x06000BA4 RID: 2980 RVA: 0x0002BE54 File Offset: 0x0002A054
		public event EventHandler OnEnterFullScreenMode;

		// Token: 0x1400008E RID: 142
		// (add) Token: 0x06000BA5 RID: 2981 RVA: 0x0002BE90 File Offset: 0x0002A090
		// (remove) Token: 0x06000BA6 RID: 2982 RVA: 0x0002BECC File Offset: 0x0002A0CC
		public event EventHandler OnLeaveFullScreenMode;

		// Token: 0x1400008F RID: 143
		// (add) Token: 0x06000BA7 RID: 2983 RVA: 0x0002BF08 File Offset: 0x0002A108
		// (remove) Token: 0x06000BA8 RID: 2984 RVA: 0x0002BF44 File Offset: 0x0002A144
		public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x14000090 RID: 144
		// (add) Token: 0x06000BA9 RID: 2985 RVA: 0x0002BF80 File Offset: 0x0002A180
		// (remove) Token: 0x06000BAA RID: 2986 RVA: 0x0002BFBC File Offset: 0x0002A1BC
		public event EventHandler OnRequestGoFullScreen;

		// Token: 0x14000091 RID: 145
		// (add) Token: 0x06000BAB RID: 2987 RVA: 0x0002BFF8 File Offset: 0x0002A1F8
		// (remove) Token: 0x06000BAC RID: 2988 RVA: 0x0002C034 File Offset: 0x0002A234
		public event EventHandler OnRequestLeaveFullScreen;

		// Token: 0x14000092 RID: 146
		// (add) Token: 0x06000BAD RID: 2989 RVA: 0x0002C070 File Offset: 0x0002A270
		// (remove) Token: 0x06000BAE RID: 2990 RVA: 0x0002C0AC File Offset: 0x0002A2AC
		public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x14000093 RID: 147
		// (add) Token: 0x06000BAF RID: 2991 RVA: 0x0002C0E8 File Offset: 0x0002A2E8
		// (remove) Token: 0x06000BB0 RID: 2992 RVA: 0x0002C124 File Offset: 0x0002A324
		public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x14000094 RID: 148
		// (add) Token: 0x06000BB1 RID: 2993 RVA: 0x0002C160 File Offset: 0x0002A360
		// (remove) Token: 0x06000BB2 RID: 2994 RVA: 0x0002C19C File Offset: 0x0002A39C
		public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x14000095 RID: 149
		// (add) Token: 0x06000BB3 RID: 2995 RVA: 0x0002C1D8 File Offset: 0x0002A3D8
		// (remove) Token: 0x06000BB4 RID: 2996 RVA: 0x0002C214 File Offset: 0x0002A414
		public event EventHandler OnIdleTimeoutNotification;

		// Token: 0x14000096 RID: 150
		// (add) Token: 0x06000BB5 RID: 2997 RVA: 0x0002C250 File Offset: 0x0002A450
		// (remove) Token: 0x06000BB6 RID: 2998 RVA: 0x0002C28C File Offset: 0x0002A48C
		public event EventHandler OnRequestContainerMinimize;

		// Token: 0x14000097 RID: 151
		// (add) Token: 0x06000BB7 RID: 2999 RVA: 0x0002C2C8 File Offset: 0x0002A4C8
		// (remove) Token: 0x06000BB8 RID: 3000 RVA: 0x0002C304 File Offset: 0x0002A504
		public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x14000098 RID: 152
		// (add) Token: 0x06000BB9 RID: 3001 RVA: 0x0002C340 File Offset: 0x0002A540
		// (remove) Token: 0x06000BBA RID: 3002 RVA: 0x0002C37C File Offset: 0x0002A57C
		public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x14000099 RID: 153
		// (add) Token: 0x06000BBB RID: 3003 RVA: 0x0002C3B8 File Offset: 0x0002A5B8
		// (remove) Token: 0x06000BBC RID: 3004 RVA: 0x0002C3F4 File Offset: 0x0002A5F4
		public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x1400009A RID: 154
		// (add) Token: 0x06000BBD RID: 3005 RVA: 0x0002C430 File Offset: 0x0002A630
		// (remove) Token: 0x06000BBE RID: 3006 RVA: 0x0002C46C File Offset: 0x0002A66C
		public event EventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x1400009B RID: 155
		// (add) Token: 0x06000BBF RID: 3007 RVA: 0x0002C4A8 File Offset: 0x0002A6A8
		// (remove) Token: 0x06000BC0 RID: 3008 RVA: 0x0002C4E4 File Offset: 0x0002A6E4
		public event EventHandler OnAuthenticationWarningDismissed;

		// Token: 0x1400009C RID: 156
		// (add) Token: 0x06000BC1 RID: 3009 RVA: 0x0002C520 File Offset: 0x0002A720
		// (remove) Token: 0x06000BC2 RID: 3010 RVA: 0x0002C55C File Offset: 0x0002A75C
		public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x1400009D RID: 157
		// (add) Token: 0x06000BC3 RID: 3011 RVA: 0x0002C598 File Offset: 0x0002A798
		// (remove) Token: 0x06000BC4 RID: 3012 RVA: 0x0002C5D4 File Offset: 0x0002A7D4
		public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x1400009E RID: 158
		// (add) Token: 0x06000BC5 RID: 3013 RVA: 0x0002C610 File Offset: 0x0002A810
		// (remove) Token: 0x06000BC6 RID: 3014 RVA: 0x0002C64C File Offset: 0x0002A84C
		public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x1400009F RID: 159
		// (add) Token: 0x06000BC7 RID: 3015 RVA: 0x0002C688 File Offset: 0x0002A888
		// (remove) Token: 0x06000BC8 RID: 3016 RVA: 0x0002C6C4 File Offset: 0x0002A8C4
		public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x140000A0 RID: 160
		// (add) Token: 0x06000BC9 RID: 3017 RVA: 0x0002C700 File Offset: 0x0002A900
		// (remove) Token: 0x06000BCA RID: 3018 RVA: 0x0002C73C File Offset: 0x0002A93C
		public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x140000A1 RID: 161
		// (add) Token: 0x06000BCB RID: 3019 RVA: 0x0002C778 File Offset: 0x0002A978
		// (remove) Token: 0x06000BCC RID: 3020 RVA: 0x0002C7B4 File Offset: 0x0002A9B4
		public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x140000A2 RID: 162
		// (add) Token: 0x06000BCD RID: 3021 RVA: 0x0002C7F0 File Offset: 0x0002A9F0
		// (remove) Token: 0x06000BCE RID: 3022 RVA: 0x0002C82C File Offset: 0x0002AA2C
		public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x140000A3 RID: 163
		// (add) Token: 0x06000BCF RID: 3023 RVA: 0x0002C868 File Offset: 0x0002AA68
		// (remove) Token: 0x06000BD0 RID: 3024 RVA: 0x0002C8A4 File Offset: 0x0002AAA4
		public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x140000A4 RID: 164
		// (add) Token: 0x06000BD1 RID: 3025 RVA: 0x0002C8E0 File Offset: 0x0002AAE0
		// (remove) Token: 0x06000BD2 RID: 3026 RVA: 0x0002C91C File Offset: 0x0002AB1C
		public event EventHandler OnConnectionBarPullDown;

		// Token: 0x140000A5 RID: 165
		// (add) Token: 0x06000BD3 RID: 3027 RVA: 0x0002C958 File Offset: 0x0002AB58
		// (remove) Token: 0x06000BD4 RID: 3028 RVA: 0x0002C994 File Offset: 0x0002AB94
		public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x140000A6 RID: 166
		// (add) Token: 0x06000BD5 RID: 3029 RVA: 0x0002C9D0 File Offset: 0x0002ABD0
		// (remove) Token: 0x06000BD6 RID: 3030 RVA: 0x0002CA0C File Offset: 0x0002AC0C
		public event EventHandler OnDevicesButtonPressed;

		// Token: 0x140000A7 RID: 167
		// (add) Token: 0x06000BD7 RID: 3031 RVA: 0x0002CA48 File Offset: 0x0002AC48
		// (remove) Token: 0x06000BD8 RID: 3032 RVA: 0x0002CA84 File Offset: 0x0002AC84
		public event EventHandler OnAutoReconnected;

		// Token: 0x140000A8 RID: 168
		// (add) Token: 0x06000BD9 RID: 3033 RVA: 0x0002CAC0 File Offset: 0x0002ACC0
		// (remove) Token: 0x06000BDA RID: 3034 RVA: 0x0002CAFC File Offset: 0x0002ACFC
		public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

		// Token: 0x06000BDB RID: 3035 RVA: 0x0002CB38 File Offset: 0x0002AD38
		public virtual void Connect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Connect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Connect();
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x0002CB5C File Offset: 0x0002AD5C
		public virtual void Disconnect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Disconnect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Disconnect();
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x0002CB80 File Offset: 0x0002AD80
		public virtual void CreateVirtualChannels(string newVal)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("CreateVirtualChannels", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.CreateVirtualChannels(newVal);
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x0002CBA8 File Offset: 0x0002ADA8
		public virtual void SendOnVirtualChannel(string chanName, string chanData)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SendOnVirtualChannel", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SendOnVirtualChannel(chanName, chanData);
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x0002CBD0 File Offset: 0x0002ADD0
		public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SetVirtualChannelOptions(chanName, chanOptions);
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x0002CBF8 File Offset: 0x0002ADF8
		public virtual int GetVirtualChannelOptions(string chanName)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetVirtualChannelOptions(chanName);
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x0002CC30 File Offset: 0x0002AE30
		public virtual ControlCloseStatus RequestClose()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("RequestClose", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.RequestClose();
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x0002CC68 File Offset: 0x0002AE68
		protected override void CreateSink()
		{
			try
			{
				this.eventMulticaster = new AxMsRdpClient2aEventMulticaster(this);
				this.cookie = new AxHost.ConnectionPointCookie(this.ocx, this.eventMulticaster, typeof(IMsTscAxEvents));
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x0002CCC0 File Offset: 0x0002AEC0
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

		// Token: 0x06000BE4 RID: 3044 RVA: 0x0002CCF4 File Offset: 0x0002AEF4
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

		// Token: 0x06000BE5 RID: 3045 RVA: 0x0002CD30 File Offset: 0x0002AF30
		internal void RaiseOnOnConnecting(object sender, EventArgs e)
		{
			if (this.OnConnecting != null)
			{
				this.OnConnecting(sender, e);
			}
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x0002CD4C File Offset: 0x0002AF4C
		internal void RaiseOnOnConnected(object sender, EventArgs e)
		{
			if (this.OnConnected != null)
			{
				this.OnConnected(sender, e);
			}
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x0002CD68 File Offset: 0x0002AF68
		internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
		{
			if (this.OnLoginComplete != null)
			{
				this.OnLoginComplete(sender, e);
			}
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x0002CD84 File Offset: 0x0002AF84
		internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
		{
			if (this.OnDisconnected != null)
			{
				this.OnDisconnected(sender, e);
			}
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x0002CDA0 File Offset: 0x0002AFA0
		internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnEnterFullScreenMode != null)
			{
				this.OnEnterFullScreenMode(sender, e);
			}
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x0002CDBC File Offset: 0x0002AFBC
		internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnLeaveFullScreenMode != null)
			{
				this.OnLeaveFullScreenMode(sender, e);
			}
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x0002CDD8 File Offset: 0x0002AFD8
		internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
		{
			if (this.OnChannelReceivedData != null)
			{
				this.OnChannelReceivedData(sender, e);
			}
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x0002CDF4 File Offset: 0x0002AFF4
		internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestGoFullScreen != null)
			{
				this.OnRequestGoFullScreen(sender, e);
			}
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x0002CE10 File Offset: 0x0002B010
		internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestLeaveFullScreen != null)
			{
				this.OnRequestLeaveFullScreen(sender, e);
			}
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x0002CE2C File Offset: 0x0002B02C
		internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
		{
			if (this.OnFatalError != null)
			{
				this.OnFatalError(sender, e);
			}
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x0002CE48 File Offset: 0x0002B048
		internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
		{
			if (this.OnWarning != null)
			{
				this.OnWarning(sender, e);
			}
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x0002CE64 File Offset: 0x0002B064
		internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
		{
			if (this.OnRemoteDesktopSizeChange != null)
			{
				this.OnRemoteDesktopSizeChange(sender, e);
			}
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x0002CE80 File Offset: 0x0002B080
		internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
		{
			if (this.OnIdleTimeoutNotification != null)
			{
				this.OnIdleTimeoutNotification(sender, e);
			}
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x0002CE9C File Offset: 0x0002B09C
		internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
		{
			if (this.OnRequestContainerMinimize != null)
			{
				this.OnRequestContainerMinimize(sender, e);
			}
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x0002CEB8 File Offset: 0x0002B0B8
		internal void RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
		{
			if (this.OnConfirmClose != null)
			{
				this.OnConfirmClose(sender, e);
			}
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x0002CED4 File Offset: 0x0002B0D4
		internal void RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
		{
			if (this.OnReceivedTSPublicKey != null)
			{
				this.OnReceivedTSPublicKey(sender, e);
			}
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x0002CEF0 File Offset: 0x0002B0F0
		internal void RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
		{
			if (this.OnAutoReconnecting != null)
			{
				this.OnAutoReconnecting(sender, e);
			}
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x0002CF0C File Offset: 0x0002B10C
		internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDisplayed != null)
			{
				this.OnAuthenticationWarningDisplayed(sender, e);
			}
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x0002CF28 File Offset: 0x0002B128
		internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDismissed != null)
			{
				this.OnAuthenticationWarningDismissed(sender, e);
			}
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x0002CF44 File Offset: 0x0002B144
		internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
		{
			if (this.OnRemoteProgramResult != null)
			{
				this.OnRemoteProgramResult(sender, e);
			}
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x0002CF60 File Offset: 0x0002B160
		internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
		{
			if (this.OnRemoteProgramDisplayed != null)
			{
				this.OnRemoteProgramDisplayed(sender, e);
			}
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x0002CF7C File Offset: 0x0002B17C
		internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
		{
			if (this.OnRemoteWindowDisplayed != null)
			{
				this.OnRemoteWindowDisplayed(sender, e);
			}
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x0002CF98 File Offset: 0x0002B198
		internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
		{
			if (this.OnLogonError != null)
			{
				this.OnLogonError(sender, e);
			}
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x0002CFB4 File Offset: 0x0002B1B4
		internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
		{
			if (this.OnFocusReleased != null)
			{
				this.OnFocusReleased(sender, e);
			}
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x0002CFD0 File Offset: 0x0002B1D0
		internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
		{
			if (this.OnUserNameAcquired != null)
			{
				this.OnUserNameAcquired(sender, e);
			}
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x0002CFEC File Offset: 0x0002B1EC
		internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
		{
			if (this.OnMouseInputModeChanged != null)
			{
				this.OnMouseInputModeChanged(sender, e);
			}
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x0002D008 File Offset: 0x0002B208
		internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
		{
			if (this.OnServiceMessageReceived != null)
			{
				this.OnServiceMessageReceived(sender, e);
			}
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x0002D024 File Offset: 0x0002B224
		internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
		{
			if (this.OnConnectionBarPullDown != null)
			{
				this.OnConnectionBarPullDown(sender, e);
			}
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x0002D040 File Offset: 0x0002B240
		internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
		{
			if (this.OnNetworkStatusChanged != null)
			{
				this.OnNetworkStatusChanged(sender, e);
			}
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x0002D05C File Offset: 0x0002B25C
		internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
		{
			if (this.OnDevicesButtonPressed != null)
			{
				this.OnDevicesButtonPressed(sender, e);
			}
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x0002D078 File Offset: 0x0002B278
		internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
		{
			if (this.OnAutoReconnected != null)
			{
				this.OnAutoReconnected(sender, e);
			}
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x0002D094 File Offset: 0x0002B294
		internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
		{
			if (this.OnAutoReconnecting2 != null)
			{
				this.OnAutoReconnecting2(sender, e);
			}
		}

		// Token: 0x0400041B RID: 1051
		private IMsRdpClient2 ocx;

		// Token: 0x0400041C RID: 1052
		private AxMsRdpClient2aEventMulticaster eventMulticaster;

		// Token: 0x0400041D RID: 1053
		private AxHost.ConnectionPointCookie cookie;
	}
}
