using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MSTSCLib;

namespace AxMSTSCLib
{
	// Token: 0x02000120 RID: 288
	[DefaultEvent("OnConnecting")]
	[AxHost.ClsidAttribute("{ace575fd-1fcf-4074-9401-ebab990fa9de}")]
	[DesignTimeVisible(true)]
	[ComVisible(true)]
	public class AxMsRdpClient3NotSafeForScripting : AxHost
	{
		// Token: 0x06000C26 RID: 3110 RVA: 0x0002D670 File Offset: 0x0002B870
		public AxMsRdpClient3NotSafeForScripting() : base("ace575fd-1fcf-4074-9401-ebab990fa9de")
		{
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000C27 RID: 3111 RVA: 0x0002D680 File Offset: 0x0002B880
		// (set) Token: 0x06000C28 RID: 3112 RVA: 0x0002D6A4 File Offset: 0x0002B8A4
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

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000C29 RID: 3113 RVA: 0x0002D6CC File Offset: 0x0002B8CC
		// (set) Token: 0x06000C2A RID: 3114 RVA: 0x0002D6F0 File Offset: 0x0002B8F0
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

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000C2B RID: 3115 RVA: 0x0002D718 File Offset: 0x0002B918
		// (set) Token: 0x06000C2C RID: 3116 RVA: 0x0002D73C File Offset: 0x0002B93C
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

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000C2D RID: 3117 RVA: 0x0002D764 File Offset: 0x0002B964
		// (set) Token: 0x06000C2E RID: 3118 RVA: 0x0002D788 File Offset: 0x0002B988
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

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000C2F RID: 3119 RVA: 0x0002D7B0 File Offset: 0x0002B9B0
		// (set) Token: 0x06000C30 RID: 3120 RVA: 0x0002D7D4 File Offset: 0x0002B9D4
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

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000C31 RID: 3121 RVA: 0x0002D7FC File Offset: 0x0002B9FC
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

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000C32 RID: 3122 RVA: 0x0002D820 File Offset: 0x0002BA20
		// (set) Token: 0x06000C33 RID: 3123 RVA: 0x0002D844 File Offset: 0x0002BA44
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

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000C34 RID: 3124 RVA: 0x0002D86C File Offset: 0x0002BA6C
		// (set) Token: 0x06000C35 RID: 3125 RVA: 0x0002D890 File Offset: 0x0002BA90
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

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000C36 RID: 3126 RVA: 0x0002D8B8 File Offset: 0x0002BAB8
		// (set) Token: 0x06000C37 RID: 3127 RVA: 0x0002D8DC File Offset: 0x0002BADC
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

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000C38 RID: 3128 RVA: 0x0002D904 File Offset: 0x0002BB04
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

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000C39 RID: 3129 RVA: 0x0002D928 File Offset: 0x0002BB28
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

		// Token: 0x17000250 RID: 592
		// (set) Token: 0x06000C3A RID: 3130 RVA: 0x0002D94C File Offset: 0x0002BB4C
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

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000C3B RID: 3131 RVA: 0x0002D974 File Offset: 0x0002BB74
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

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000C3C RID: 3132 RVA: 0x0002D998 File Offset: 0x0002BB98
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

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000C3D RID: 3133 RVA: 0x0002D9BC File Offset: 0x0002BBBC
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

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000C3E RID: 3134 RVA: 0x0002D9E0 File Offset: 0x0002BBE0
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

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000C3F RID: 3135 RVA: 0x0002DA04 File Offset: 0x0002BC04
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

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000C40 RID: 3136 RVA: 0x0002DA28 File Offset: 0x0002BC28
		[DispId(99)]
		[Browsable(false)]
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

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000C41 RID: 3137 RVA: 0x0002DA4C File Offset: 0x0002BC4C
		// (set) Token: 0x06000C42 RID: 3138 RVA: 0x0002DA70 File Offset: 0x0002BC70
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

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000C43 RID: 3139 RVA: 0x0002DA98 File Offset: 0x0002BC98
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

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000C44 RID: 3140 RVA: 0x0002DABC File Offset: 0x0002BCBC
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

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000C45 RID: 3141 RVA: 0x0002DAE0 File Offset: 0x0002BCE0
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

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000C46 RID: 3142 RVA: 0x0002DB04 File Offset: 0x0002BD04
		// (set) Token: 0x06000C47 RID: 3143 RVA: 0x0002DB28 File Offset: 0x0002BD28
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

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000C48 RID: 3144 RVA: 0x0002DB50 File Offset: 0x0002BD50
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

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000C49 RID: 3145 RVA: 0x0002DB74 File Offset: 0x0002BD74
		// (set) Token: 0x06000C4A RID: 3146 RVA: 0x0002DB98 File Offset: 0x0002BD98
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

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000C4B RID: 3147 RVA: 0x0002DBC0 File Offset: 0x0002BDC0
		[Browsable(false)]
		[DispId(300)]
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

		// Token: 0x140000A9 RID: 169
		// (add) Token: 0x06000C4C RID: 3148 RVA: 0x0002DBE4 File Offset: 0x0002BDE4
		// (remove) Token: 0x06000C4D RID: 3149 RVA: 0x0002DC20 File Offset: 0x0002BE20
		public event EventHandler OnConnecting;

		// Token: 0x140000AA RID: 170
		// (add) Token: 0x06000C4E RID: 3150 RVA: 0x0002DC5C File Offset: 0x0002BE5C
		// (remove) Token: 0x06000C4F RID: 3151 RVA: 0x0002DC98 File Offset: 0x0002BE98
		public event EventHandler OnConnected;

		// Token: 0x140000AB RID: 171
		// (add) Token: 0x06000C50 RID: 3152 RVA: 0x0002DCD4 File Offset: 0x0002BED4
		// (remove) Token: 0x06000C51 RID: 3153 RVA: 0x0002DD10 File Offset: 0x0002BF10
		public event EventHandler OnLoginComplete;

		// Token: 0x140000AC RID: 172
		// (add) Token: 0x06000C52 RID: 3154 RVA: 0x0002DD4C File Offset: 0x0002BF4C
		// (remove) Token: 0x06000C53 RID: 3155 RVA: 0x0002DD88 File Offset: 0x0002BF88
		public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x140000AD RID: 173
		// (add) Token: 0x06000C54 RID: 3156 RVA: 0x0002DDC4 File Offset: 0x0002BFC4
		// (remove) Token: 0x06000C55 RID: 3157 RVA: 0x0002DE00 File Offset: 0x0002C000
		public event EventHandler OnEnterFullScreenMode;

		// Token: 0x140000AE RID: 174
		// (add) Token: 0x06000C56 RID: 3158 RVA: 0x0002DE3C File Offset: 0x0002C03C
		// (remove) Token: 0x06000C57 RID: 3159 RVA: 0x0002DE78 File Offset: 0x0002C078
		public event EventHandler OnLeaveFullScreenMode;

		// Token: 0x140000AF RID: 175
		// (add) Token: 0x06000C58 RID: 3160 RVA: 0x0002DEB4 File Offset: 0x0002C0B4
		// (remove) Token: 0x06000C59 RID: 3161 RVA: 0x0002DEF0 File Offset: 0x0002C0F0
		public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x140000B0 RID: 176
		// (add) Token: 0x06000C5A RID: 3162 RVA: 0x0002DF2C File Offset: 0x0002C12C
		// (remove) Token: 0x06000C5B RID: 3163 RVA: 0x0002DF68 File Offset: 0x0002C168
		public event EventHandler OnRequestGoFullScreen;

		// Token: 0x140000B1 RID: 177
		// (add) Token: 0x06000C5C RID: 3164 RVA: 0x0002DFA4 File Offset: 0x0002C1A4
		// (remove) Token: 0x06000C5D RID: 3165 RVA: 0x0002DFE0 File Offset: 0x0002C1E0
		public event EventHandler OnRequestLeaveFullScreen;

		// Token: 0x140000B2 RID: 178
		// (add) Token: 0x06000C5E RID: 3166 RVA: 0x0002E01C File Offset: 0x0002C21C
		// (remove) Token: 0x06000C5F RID: 3167 RVA: 0x0002E058 File Offset: 0x0002C258
		public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x140000B3 RID: 179
		// (add) Token: 0x06000C60 RID: 3168 RVA: 0x0002E094 File Offset: 0x0002C294
		// (remove) Token: 0x06000C61 RID: 3169 RVA: 0x0002E0D0 File Offset: 0x0002C2D0
		public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x140000B4 RID: 180
		// (add) Token: 0x06000C62 RID: 3170 RVA: 0x0002E10C File Offset: 0x0002C30C
		// (remove) Token: 0x06000C63 RID: 3171 RVA: 0x0002E148 File Offset: 0x0002C348
		public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x140000B5 RID: 181
		// (add) Token: 0x06000C64 RID: 3172 RVA: 0x0002E184 File Offset: 0x0002C384
		// (remove) Token: 0x06000C65 RID: 3173 RVA: 0x0002E1C0 File Offset: 0x0002C3C0
		public event EventHandler OnIdleTimeoutNotification;

		// Token: 0x140000B6 RID: 182
		// (add) Token: 0x06000C66 RID: 3174 RVA: 0x0002E1FC File Offset: 0x0002C3FC
		// (remove) Token: 0x06000C67 RID: 3175 RVA: 0x0002E238 File Offset: 0x0002C438
		public event EventHandler OnRequestContainerMinimize;

		// Token: 0x140000B7 RID: 183
		// (add) Token: 0x06000C68 RID: 3176 RVA: 0x0002E274 File Offset: 0x0002C474
		// (remove) Token: 0x06000C69 RID: 3177 RVA: 0x0002E2B0 File Offset: 0x0002C4B0
		public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x140000B8 RID: 184
		// (add) Token: 0x06000C6A RID: 3178 RVA: 0x0002E2EC File Offset: 0x0002C4EC
		// (remove) Token: 0x06000C6B RID: 3179 RVA: 0x0002E328 File Offset: 0x0002C528
		public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x140000B9 RID: 185
		// (add) Token: 0x06000C6C RID: 3180 RVA: 0x0002E364 File Offset: 0x0002C564
		// (remove) Token: 0x06000C6D RID: 3181 RVA: 0x0002E3A0 File Offset: 0x0002C5A0
		public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x140000BA RID: 186
		// (add) Token: 0x06000C6E RID: 3182 RVA: 0x0002E3DC File Offset: 0x0002C5DC
		// (remove) Token: 0x06000C6F RID: 3183 RVA: 0x0002E418 File Offset: 0x0002C618
		public event EventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x140000BB RID: 187
		// (add) Token: 0x06000C70 RID: 3184 RVA: 0x0002E454 File Offset: 0x0002C654
		// (remove) Token: 0x06000C71 RID: 3185 RVA: 0x0002E490 File Offset: 0x0002C690
		public event EventHandler OnAuthenticationWarningDismissed;

		// Token: 0x140000BC RID: 188
		// (add) Token: 0x06000C72 RID: 3186 RVA: 0x0002E4CC File Offset: 0x0002C6CC
		// (remove) Token: 0x06000C73 RID: 3187 RVA: 0x0002E508 File Offset: 0x0002C708
		public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x140000BD RID: 189
		// (add) Token: 0x06000C74 RID: 3188 RVA: 0x0002E544 File Offset: 0x0002C744
		// (remove) Token: 0x06000C75 RID: 3189 RVA: 0x0002E580 File Offset: 0x0002C780
		public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x140000BE RID: 190
		// (add) Token: 0x06000C76 RID: 3190 RVA: 0x0002E5BC File Offset: 0x0002C7BC
		// (remove) Token: 0x06000C77 RID: 3191 RVA: 0x0002E5F8 File Offset: 0x0002C7F8
		public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x140000BF RID: 191
		// (add) Token: 0x06000C78 RID: 3192 RVA: 0x0002E634 File Offset: 0x0002C834
		// (remove) Token: 0x06000C79 RID: 3193 RVA: 0x0002E670 File Offset: 0x0002C870
		public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x140000C0 RID: 192
		// (add) Token: 0x06000C7A RID: 3194 RVA: 0x0002E6AC File Offset: 0x0002C8AC
		// (remove) Token: 0x06000C7B RID: 3195 RVA: 0x0002E6E8 File Offset: 0x0002C8E8
		public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x140000C1 RID: 193
		// (add) Token: 0x06000C7C RID: 3196 RVA: 0x0002E724 File Offset: 0x0002C924
		// (remove) Token: 0x06000C7D RID: 3197 RVA: 0x0002E760 File Offset: 0x0002C960
		public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x140000C2 RID: 194
		// (add) Token: 0x06000C7E RID: 3198 RVA: 0x0002E79C File Offset: 0x0002C99C
		// (remove) Token: 0x06000C7F RID: 3199 RVA: 0x0002E7D8 File Offset: 0x0002C9D8
		public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x140000C3 RID: 195
		// (add) Token: 0x06000C80 RID: 3200 RVA: 0x0002E814 File Offset: 0x0002CA14
		// (remove) Token: 0x06000C81 RID: 3201 RVA: 0x0002E850 File Offset: 0x0002CA50
		public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x140000C4 RID: 196
		// (add) Token: 0x06000C82 RID: 3202 RVA: 0x0002E88C File Offset: 0x0002CA8C
		// (remove) Token: 0x06000C83 RID: 3203 RVA: 0x0002E8C8 File Offset: 0x0002CAC8
		public event EventHandler OnConnectionBarPullDown;

		// Token: 0x140000C5 RID: 197
		// (add) Token: 0x06000C84 RID: 3204 RVA: 0x0002E904 File Offset: 0x0002CB04
		// (remove) Token: 0x06000C85 RID: 3205 RVA: 0x0002E940 File Offset: 0x0002CB40
		public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x140000C6 RID: 198
		// (add) Token: 0x06000C86 RID: 3206 RVA: 0x0002E97C File Offset: 0x0002CB7C
		// (remove) Token: 0x06000C87 RID: 3207 RVA: 0x0002E9B8 File Offset: 0x0002CBB8
		public event EventHandler OnDevicesButtonPressed;

		// Token: 0x140000C7 RID: 199
		// (add) Token: 0x06000C88 RID: 3208 RVA: 0x0002E9F4 File Offset: 0x0002CBF4
		// (remove) Token: 0x06000C89 RID: 3209 RVA: 0x0002EA30 File Offset: 0x0002CC30
		public event EventHandler OnAutoReconnected;

		// Token: 0x140000C8 RID: 200
		// (add) Token: 0x06000C8A RID: 3210 RVA: 0x0002EA6C File Offset: 0x0002CC6C
		// (remove) Token: 0x06000C8B RID: 3211 RVA: 0x0002EAA8 File Offset: 0x0002CCA8
		public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

		// Token: 0x06000C8C RID: 3212 RVA: 0x0002EAE4 File Offset: 0x0002CCE4
		public virtual void Connect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Connect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Connect();
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x0002EB08 File Offset: 0x0002CD08
		public virtual void Disconnect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Disconnect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Disconnect();
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x0002EB2C File Offset: 0x0002CD2C
		public virtual void CreateVirtualChannels(string newVal)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("CreateVirtualChannels", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.CreateVirtualChannels(newVal);
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x0002EB54 File Offset: 0x0002CD54
		public virtual void SendOnVirtualChannel(string chanName, string chanData)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SendOnVirtualChannel", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SendOnVirtualChannel(chanName, chanData);
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x0002EB7C File Offset: 0x0002CD7C
		public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SetVirtualChannelOptions(chanName, chanOptions);
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x0002EBA4 File Offset: 0x0002CDA4
		public virtual int GetVirtualChannelOptions(string chanName)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetVirtualChannelOptions(chanName);
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x0002EBDC File Offset: 0x0002CDDC
		public virtual ControlCloseStatus RequestClose()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("RequestClose", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.RequestClose();
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x0002EC14 File Offset: 0x0002CE14
		protected override void CreateSink()
		{
			try
			{
				this.eventMulticaster = new AxMsRdpClient3NotSafeForScriptingEventMulticaster(this);
				this.cookie = new AxHost.ConnectionPointCookie(this.ocx, this.eventMulticaster, typeof(IMsTscAxEvents));
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x0002EC6C File Offset: 0x0002CE6C
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

		// Token: 0x06000C95 RID: 3221 RVA: 0x0002ECA0 File Offset: 0x0002CEA0
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

		// Token: 0x06000C96 RID: 3222 RVA: 0x0002ECDC File Offset: 0x0002CEDC
		internal void RaiseOnOnConnecting(object sender, EventArgs e)
		{
			if (this.OnConnecting != null)
			{
				this.OnConnecting(sender, e);
			}
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x0002ECF8 File Offset: 0x0002CEF8
		internal void RaiseOnOnConnected(object sender, EventArgs e)
		{
			if (this.OnConnected != null)
			{
				this.OnConnected(sender, e);
			}
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x0002ED14 File Offset: 0x0002CF14
		internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
		{
			if (this.OnLoginComplete != null)
			{
				this.OnLoginComplete(sender, e);
			}
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x0002ED30 File Offset: 0x0002CF30
		internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
		{
			if (this.OnDisconnected != null)
			{
				this.OnDisconnected(sender, e);
			}
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x0002ED4C File Offset: 0x0002CF4C
		internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnEnterFullScreenMode != null)
			{
				this.OnEnterFullScreenMode(sender, e);
			}
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x0002ED68 File Offset: 0x0002CF68
		internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnLeaveFullScreenMode != null)
			{
				this.OnLeaveFullScreenMode(sender, e);
			}
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x0002ED84 File Offset: 0x0002CF84
		internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
		{
			if (this.OnChannelReceivedData != null)
			{
				this.OnChannelReceivedData(sender, e);
			}
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x0002EDA0 File Offset: 0x0002CFA0
		internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestGoFullScreen != null)
			{
				this.OnRequestGoFullScreen(sender, e);
			}
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x0002EDBC File Offset: 0x0002CFBC
		internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestLeaveFullScreen != null)
			{
				this.OnRequestLeaveFullScreen(sender, e);
			}
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x0002EDD8 File Offset: 0x0002CFD8
		internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
		{
			if (this.OnFatalError != null)
			{
				this.OnFatalError(sender, e);
			}
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x0002EDF4 File Offset: 0x0002CFF4
		internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
		{
			if (this.OnWarning != null)
			{
				this.OnWarning(sender, e);
			}
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x0002EE10 File Offset: 0x0002D010
		internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
		{
			if (this.OnRemoteDesktopSizeChange != null)
			{
				this.OnRemoteDesktopSizeChange(sender, e);
			}
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x0002EE2C File Offset: 0x0002D02C
		internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
		{
			if (this.OnIdleTimeoutNotification != null)
			{
				this.OnIdleTimeoutNotification(sender, e);
			}
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x0002EE48 File Offset: 0x0002D048
		internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
		{
			if (this.OnRequestContainerMinimize != null)
			{
				this.OnRequestContainerMinimize(sender, e);
			}
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x0002EE64 File Offset: 0x0002D064
		internal void RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
		{
			if (this.OnConfirmClose != null)
			{
				this.OnConfirmClose(sender, e);
			}
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x0002EE80 File Offset: 0x0002D080
		internal void RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
		{
			if (this.OnReceivedTSPublicKey != null)
			{
				this.OnReceivedTSPublicKey(sender, e);
			}
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x0002EE9C File Offset: 0x0002D09C
		internal void RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
		{
			if (this.OnAutoReconnecting != null)
			{
				this.OnAutoReconnecting(sender, e);
			}
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x0002EEB8 File Offset: 0x0002D0B8
		internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDisplayed != null)
			{
				this.OnAuthenticationWarningDisplayed(sender, e);
			}
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x0002EED4 File Offset: 0x0002D0D4
		internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDismissed != null)
			{
				this.OnAuthenticationWarningDismissed(sender, e);
			}
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x0002EEF0 File Offset: 0x0002D0F0
		internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
		{
			if (this.OnRemoteProgramResult != null)
			{
				this.OnRemoteProgramResult(sender, e);
			}
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x0002EF0C File Offset: 0x0002D10C
		internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
		{
			if (this.OnRemoteProgramDisplayed != null)
			{
				this.OnRemoteProgramDisplayed(sender, e);
			}
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x0002EF28 File Offset: 0x0002D128
		internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
		{
			if (this.OnRemoteWindowDisplayed != null)
			{
				this.OnRemoteWindowDisplayed(sender, e);
			}
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x0002EF44 File Offset: 0x0002D144
		internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
		{
			if (this.OnLogonError != null)
			{
				this.OnLogonError(sender, e);
			}
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x0002EF60 File Offset: 0x0002D160
		internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
		{
			if (this.OnFocusReleased != null)
			{
				this.OnFocusReleased(sender, e);
			}
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x0002EF7C File Offset: 0x0002D17C
		internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
		{
			if (this.OnUserNameAcquired != null)
			{
				this.OnUserNameAcquired(sender, e);
			}
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x0002EF98 File Offset: 0x0002D198
		internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
		{
			if (this.OnMouseInputModeChanged != null)
			{
				this.OnMouseInputModeChanged(sender, e);
			}
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x0002EFB4 File Offset: 0x0002D1B4
		internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
		{
			if (this.OnServiceMessageReceived != null)
			{
				this.OnServiceMessageReceived(sender, e);
			}
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x0002EFD0 File Offset: 0x0002D1D0
		internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
		{
			if (this.OnConnectionBarPullDown != null)
			{
				this.OnConnectionBarPullDown(sender, e);
			}
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x0002EFEC File Offset: 0x0002D1EC
		internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
		{
			if (this.OnNetworkStatusChanged != null)
			{
				this.OnNetworkStatusChanged(sender, e);
			}
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x0002F008 File Offset: 0x0002D208
		internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
		{
			if (this.OnDevicesButtonPressed != null)
			{
				this.OnDevicesButtonPressed(sender, e);
			}
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x0002F024 File Offset: 0x0002D224
		internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
		{
			if (this.OnAutoReconnected != null)
			{
				this.OnAutoReconnected(sender, e);
			}
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x0002F040 File Offset: 0x0002D240
		internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
		{
			if (this.OnAutoReconnecting2 != null)
			{
				this.OnAutoReconnecting2(sender, e);
			}
		}

		// Token: 0x0400043F RID: 1087
		private IMsRdpClient3 ocx;

		// Token: 0x04000440 RID: 1088
		private AxMsRdpClient3NotSafeForScriptingEventMulticaster eventMulticaster;

		// Token: 0x04000441 RID: 1089
		private AxHost.ConnectionPointCookie cookie;
	}
}
