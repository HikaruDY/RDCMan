using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MSTSCLib;

namespace AxMSTSCLib
{
	// Token: 0x02000138 RID: 312
	[DefaultEvent("OnConnecting")]
	[AxHost.ClsidAttribute("{a3bc03a0-041d-42e3-ad22-882b7865c9c5}")]
	[DesignTimeVisible(true)]
	[ComVisible(true)]
	public class AxMsRdpClient8NotSafeForScripting : AxHost
	{
		// Token: 0x060014AB RID: 5291 RVA: 0x00045B24 File Offset: 0x00043D24
		public AxMsRdpClient8NotSafeForScripting() : base("a3bc03a0-041d-42e3-ad22-882b7865c9c5")
		{
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x060014AC RID: 5292 RVA: 0x00045B34 File Offset: 0x00043D34
		// (set) Token: 0x060014AD RID: 5293 RVA: 0x00045B58 File Offset: 0x00043D58
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

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x060014AE RID: 5294 RVA: 0x00045B80 File Offset: 0x00043D80
		// (set) Token: 0x060014AF RID: 5295 RVA: 0x00045BA4 File Offset: 0x00043DA4
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

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x060014B0 RID: 5296 RVA: 0x00045BCC File Offset: 0x00043DCC
		// (set) Token: 0x060014B1 RID: 5297 RVA: 0x00045BF0 File Offset: 0x00043DF0
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

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x060014B2 RID: 5298 RVA: 0x00045C18 File Offset: 0x00043E18
		// (set) Token: 0x060014B3 RID: 5299 RVA: 0x00045C3C File Offset: 0x00043E3C
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

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x060014B4 RID: 5300 RVA: 0x00045C64 File Offset: 0x00043E64
		// (set) Token: 0x060014B5 RID: 5301 RVA: 0x00045C88 File Offset: 0x00043E88
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

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x060014B6 RID: 5302 RVA: 0x00045CB0 File Offset: 0x00043EB0
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

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x060014B7 RID: 5303 RVA: 0x00045CD4 File Offset: 0x00043ED4
		// (set) Token: 0x060014B8 RID: 5304 RVA: 0x00045CF8 File Offset: 0x00043EF8
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

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x060014B9 RID: 5305 RVA: 0x00045D20 File Offset: 0x00043F20
		// (set) Token: 0x060014BA RID: 5306 RVA: 0x00045D44 File Offset: 0x00043F44
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

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x060014BB RID: 5307 RVA: 0x00045D6C File Offset: 0x00043F6C
		// (set) Token: 0x060014BC RID: 5308 RVA: 0x00045D90 File Offset: 0x00043F90
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

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x060014BD RID: 5309 RVA: 0x00045DB8 File Offset: 0x00043FB8
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

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x060014BE RID: 5310 RVA: 0x00045DDC File Offset: 0x00043FDC
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

		// Token: 0x170003B9 RID: 953
		// (set) Token: 0x060014BF RID: 5311 RVA: 0x00045E00 File Offset: 0x00044000
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

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x060014C0 RID: 5312 RVA: 0x00045E28 File Offset: 0x00044028
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

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x060014C1 RID: 5313 RVA: 0x00045E4C File Offset: 0x0004404C
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

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x060014C2 RID: 5314 RVA: 0x00045E70 File Offset: 0x00044070
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

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x060014C3 RID: 5315 RVA: 0x00045E94 File Offset: 0x00044094
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

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x060014C4 RID: 5316 RVA: 0x00045EB8 File Offset: 0x000440B8
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

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x060014C5 RID: 5317 RVA: 0x00045EDC File Offset: 0x000440DC
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
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

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x060014C6 RID: 5318 RVA: 0x00045F00 File Offset: 0x00044100
		// (set) Token: 0x060014C7 RID: 5319 RVA: 0x00045F24 File Offset: 0x00044124
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

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x060014C8 RID: 5320 RVA: 0x00045F4C File Offset: 0x0004414C
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(101)]
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

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x060014C9 RID: 5321 RVA: 0x00045F70 File Offset: 0x00044170
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

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x060014CA RID: 5322 RVA: 0x00045F94 File Offset: 0x00044194
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

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x060014CB RID: 5323 RVA: 0x00045FB8 File Offset: 0x000441B8
		// (set) Token: 0x060014CC RID: 5324 RVA: 0x00045FDC File Offset: 0x000441DC
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

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x060014CD RID: 5325 RVA: 0x00046004 File Offset: 0x00044204
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x060014CE RID: 5326 RVA: 0x00046028 File Offset: 0x00044228
		// (set) Token: 0x060014CF RID: 5327 RVA: 0x0004604C File Offset: 0x0004424C
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

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x060014D0 RID: 5328 RVA: 0x00046074 File Offset: 0x00044274
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		[DispId(300)]
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

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x060014D1 RID: 5329 RVA: 0x00046098 File Offset: 0x00044298
		[DispId(400)]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x060014D2 RID: 5330 RVA: 0x000460BC File Offset: 0x000442BC
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		[DispId(500)]
		public virtual IMsRdpClientTransportSettings TransportSettings
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("TransportSettings", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.TransportSettings;
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x060014D3 RID: 5331 RVA: 0x000460E0 File Offset: 0x000442E0
		[DispId(502)]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual IMsRdpClientAdvancedSettings5 AdvancedSettings6
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("AdvancedSettings6", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.AdvancedSettings6;
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x060014D4 RID: 5332 RVA: 0x00046104 File Offset: 0x00044304
		[Browsable(false)]
		[DispId(504)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual ITSRemoteProgram RemoteProgram
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("RemoteProgram", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.RemoteProgram;
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x060014D5 RID: 5333 RVA: 0x00046128 File Offset: 0x00044328
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		[DispId(505)]
		public virtual IMsRdpClientShell MsRdpClientShell
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("MsRdpClientShell", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.MsRdpClientShell;
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x060014D6 RID: 5334 RVA: 0x0004614C File Offset: 0x0004434C
		[DispId(507)]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual IMsRdpClientAdvancedSettings6 AdvancedSettings7
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("AdvancedSettings7", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.AdvancedSettings7;
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x060014D7 RID: 5335 RVA: 0x00046170 File Offset: 0x00044370
		[DispId(506)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public virtual IMsRdpClientTransportSettings2 TransportSettings2
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("TransportSettings2", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.TransportSettings2;
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x060014D8 RID: 5336 RVA: 0x00046194 File Offset: 0x00044394
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(600)]
		public virtual IMsRdpClientAdvancedSettings7 AdvancedSettings8
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("AdvancedSettings8", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.AdvancedSettings8;
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x060014D9 RID: 5337 RVA: 0x000461B8 File Offset: 0x000443B8
		[Browsable(false)]
		[DispId(601)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual IMsRdpClientTransportSettings3 TransportSettings3
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("TransportSettings3", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.TransportSettings3;
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x060014DA RID: 5338 RVA: 0x000461DC File Offset: 0x000443DC
		[Browsable(false)]
		[DispId(603)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual IMsRdpClientSecuredSettings2 SecuredSettings3
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("SecuredSettings3", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.SecuredSettings3;
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x060014DB RID: 5339 RVA: 0x00046200 File Offset: 0x00044400
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(604)]
		[Browsable(false)]
		public virtual ITSRemoteProgram2 RemoteProgram2
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("RemoteProgram2", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.RemoteProgram2;
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x060014DC RID: 5340 RVA: 0x00046224 File Offset: 0x00044424
		[DispId(701)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public virtual IMsRdpClientAdvancedSettings8 AdvancedSettings9
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("AdvancedSettings9", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.AdvancedSettings9;
			}
		}

		// Token: 0x14000229 RID: 553
		// (add) Token: 0x060014DD RID: 5341 RVA: 0x00046248 File Offset: 0x00044448
		// (remove) Token: 0x060014DE RID: 5342 RVA: 0x00046284 File Offset: 0x00044484
		public event EventHandler OnConnecting;

		// Token: 0x1400022A RID: 554
		// (add) Token: 0x060014DF RID: 5343 RVA: 0x000462C0 File Offset: 0x000444C0
		// (remove) Token: 0x060014E0 RID: 5344 RVA: 0x000462FC File Offset: 0x000444FC
		public event EventHandler OnConnected;

		// Token: 0x1400022B RID: 555
		// (add) Token: 0x060014E1 RID: 5345 RVA: 0x00046338 File Offset: 0x00044538
		// (remove) Token: 0x060014E2 RID: 5346 RVA: 0x00046374 File Offset: 0x00044574
		public event EventHandler OnLoginComplete;

		// Token: 0x1400022C RID: 556
		// (add) Token: 0x060014E3 RID: 5347 RVA: 0x000463B0 File Offset: 0x000445B0
		// (remove) Token: 0x060014E4 RID: 5348 RVA: 0x000463EC File Offset: 0x000445EC
		public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x1400022D RID: 557
		// (add) Token: 0x060014E5 RID: 5349 RVA: 0x00046428 File Offset: 0x00044628
		// (remove) Token: 0x060014E6 RID: 5350 RVA: 0x00046464 File Offset: 0x00044664
		public event EventHandler OnEnterFullScreenMode;

		// Token: 0x1400022E RID: 558
		// (add) Token: 0x060014E7 RID: 5351 RVA: 0x000464A0 File Offset: 0x000446A0
		// (remove) Token: 0x060014E8 RID: 5352 RVA: 0x000464DC File Offset: 0x000446DC
		public event EventHandler OnLeaveFullScreenMode;

		// Token: 0x1400022F RID: 559
		// (add) Token: 0x060014E9 RID: 5353 RVA: 0x00046518 File Offset: 0x00044718
		// (remove) Token: 0x060014EA RID: 5354 RVA: 0x00046554 File Offset: 0x00044754
		public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x14000230 RID: 560
		// (add) Token: 0x060014EB RID: 5355 RVA: 0x00046590 File Offset: 0x00044790
		// (remove) Token: 0x060014EC RID: 5356 RVA: 0x000465CC File Offset: 0x000447CC
		public event EventHandler OnRequestGoFullScreen;

		// Token: 0x14000231 RID: 561
		// (add) Token: 0x060014ED RID: 5357 RVA: 0x00046608 File Offset: 0x00044808
		// (remove) Token: 0x060014EE RID: 5358 RVA: 0x00046644 File Offset: 0x00044844
		public event EventHandler OnRequestLeaveFullScreen;

		// Token: 0x14000232 RID: 562
		// (add) Token: 0x060014EF RID: 5359 RVA: 0x00046680 File Offset: 0x00044880
		// (remove) Token: 0x060014F0 RID: 5360 RVA: 0x000466BC File Offset: 0x000448BC
		public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x14000233 RID: 563
		// (add) Token: 0x060014F1 RID: 5361 RVA: 0x000466F8 File Offset: 0x000448F8
		// (remove) Token: 0x060014F2 RID: 5362 RVA: 0x00046734 File Offset: 0x00044934
		public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x14000234 RID: 564
		// (add) Token: 0x060014F3 RID: 5363 RVA: 0x00046770 File Offset: 0x00044970
		// (remove) Token: 0x060014F4 RID: 5364 RVA: 0x000467AC File Offset: 0x000449AC
		public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x14000235 RID: 565
		// (add) Token: 0x060014F5 RID: 5365 RVA: 0x000467E8 File Offset: 0x000449E8
		// (remove) Token: 0x060014F6 RID: 5366 RVA: 0x00046824 File Offset: 0x00044A24
		public event EventHandler OnIdleTimeoutNotification;

		// Token: 0x14000236 RID: 566
		// (add) Token: 0x060014F7 RID: 5367 RVA: 0x00046860 File Offset: 0x00044A60
		// (remove) Token: 0x060014F8 RID: 5368 RVA: 0x0004689C File Offset: 0x00044A9C
		public event EventHandler OnRequestContainerMinimize;

		// Token: 0x14000237 RID: 567
		// (add) Token: 0x060014F9 RID: 5369 RVA: 0x000468D8 File Offset: 0x00044AD8
		// (remove) Token: 0x060014FA RID: 5370 RVA: 0x00046914 File Offset: 0x00044B14
		public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x14000238 RID: 568
		// (add) Token: 0x060014FB RID: 5371 RVA: 0x00046950 File Offset: 0x00044B50
		// (remove) Token: 0x060014FC RID: 5372 RVA: 0x0004698C File Offset: 0x00044B8C
		public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x14000239 RID: 569
		// (add) Token: 0x060014FD RID: 5373 RVA: 0x000469C8 File Offset: 0x00044BC8
		// (remove) Token: 0x060014FE RID: 5374 RVA: 0x00046A04 File Offset: 0x00044C04
		public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x1400023A RID: 570
		// (add) Token: 0x060014FF RID: 5375 RVA: 0x00046A40 File Offset: 0x00044C40
		// (remove) Token: 0x06001500 RID: 5376 RVA: 0x00046A7C File Offset: 0x00044C7C
		public event EventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x1400023B RID: 571
		// (add) Token: 0x06001501 RID: 5377 RVA: 0x00046AB8 File Offset: 0x00044CB8
		// (remove) Token: 0x06001502 RID: 5378 RVA: 0x00046AF4 File Offset: 0x00044CF4
		public event EventHandler OnAuthenticationWarningDismissed;

		// Token: 0x1400023C RID: 572
		// (add) Token: 0x06001503 RID: 5379 RVA: 0x00046B30 File Offset: 0x00044D30
		// (remove) Token: 0x06001504 RID: 5380 RVA: 0x00046B6C File Offset: 0x00044D6C
		public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x1400023D RID: 573
		// (add) Token: 0x06001505 RID: 5381 RVA: 0x00046BA8 File Offset: 0x00044DA8
		// (remove) Token: 0x06001506 RID: 5382 RVA: 0x00046BE4 File Offset: 0x00044DE4
		public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x1400023E RID: 574
		// (add) Token: 0x06001507 RID: 5383 RVA: 0x00046C20 File Offset: 0x00044E20
		// (remove) Token: 0x06001508 RID: 5384 RVA: 0x00046C5C File Offset: 0x00044E5C
		public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x1400023F RID: 575
		// (add) Token: 0x06001509 RID: 5385 RVA: 0x00046C98 File Offset: 0x00044E98
		// (remove) Token: 0x0600150A RID: 5386 RVA: 0x00046CD4 File Offset: 0x00044ED4
		public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x14000240 RID: 576
		// (add) Token: 0x0600150B RID: 5387 RVA: 0x00046D10 File Offset: 0x00044F10
		// (remove) Token: 0x0600150C RID: 5388 RVA: 0x00046D4C File Offset: 0x00044F4C
		public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x14000241 RID: 577
		// (add) Token: 0x0600150D RID: 5389 RVA: 0x00046D88 File Offset: 0x00044F88
		// (remove) Token: 0x0600150E RID: 5390 RVA: 0x00046DC4 File Offset: 0x00044FC4
		public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x14000242 RID: 578
		// (add) Token: 0x0600150F RID: 5391 RVA: 0x00046E00 File Offset: 0x00045000
		// (remove) Token: 0x06001510 RID: 5392 RVA: 0x00046E3C File Offset: 0x0004503C
		public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x14000243 RID: 579
		// (add) Token: 0x06001511 RID: 5393 RVA: 0x00046E78 File Offset: 0x00045078
		// (remove) Token: 0x06001512 RID: 5394 RVA: 0x00046EB4 File Offset: 0x000450B4
		public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x14000244 RID: 580
		// (add) Token: 0x06001513 RID: 5395 RVA: 0x00046EF0 File Offset: 0x000450F0
		// (remove) Token: 0x06001514 RID: 5396 RVA: 0x00046F2C File Offset: 0x0004512C
		public event EventHandler OnConnectionBarPullDown;

		// Token: 0x14000245 RID: 581
		// (add) Token: 0x06001515 RID: 5397 RVA: 0x00046F68 File Offset: 0x00045168
		// (remove) Token: 0x06001516 RID: 5398 RVA: 0x00046FA4 File Offset: 0x000451A4
		public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x14000246 RID: 582
		// (add) Token: 0x06001517 RID: 5399 RVA: 0x00046FE0 File Offset: 0x000451E0
		// (remove) Token: 0x06001518 RID: 5400 RVA: 0x0004701C File Offset: 0x0004521C
		public event EventHandler OnDevicesButtonPressed;

		// Token: 0x14000247 RID: 583
		// (add) Token: 0x06001519 RID: 5401 RVA: 0x00047058 File Offset: 0x00045258
		// (remove) Token: 0x0600151A RID: 5402 RVA: 0x00047094 File Offset: 0x00045294
		public event EventHandler OnAutoReconnected;

		// Token: 0x14000248 RID: 584
		// (add) Token: 0x0600151B RID: 5403 RVA: 0x000470D0 File Offset: 0x000452D0
		// (remove) Token: 0x0600151C RID: 5404 RVA: 0x0004710C File Offset: 0x0004530C
		public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

		// Token: 0x0600151D RID: 5405 RVA: 0x00047148 File Offset: 0x00045348
		public virtual void Connect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Connect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Connect();
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x0004716C File Offset: 0x0004536C
		public virtual void Disconnect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Disconnect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Disconnect();
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x00047190 File Offset: 0x00045390
		public virtual void CreateVirtualChannels(string newVal)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("CreateVirtualChannels", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.CreateVirtualChannels(newVal);
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x000471B8 File Offset: 0x000453B8
		public virtual void SendOnVirtualChannel(string chanName, string chanData)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SendOnVirtualChannel", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SendOnVirtualChannel(chanName, chanData);
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x000471E0 File Offset: 0x000453E0
		public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SetVirtualChannelOptions(chanName, chanOptions);
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x00047208 File Offset: 0x00045408
		public virtual int GetVirtualChannelOptions(string chanName)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetVirtualChannelOptions(chanName);
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x00047240 File Offset: 0x00045440
		public virtual ControlCloseStatus RequestClose()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("RequestClose", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.RequestClose();
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x00047278 File Offset: 0x00045478
		public virtual string GetErrorDescription(uint disconnectReason, uint extendedDisconnectReason)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetErrorDescription", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetErrorDescription(disconnectReason, extendedDisconnectReason);
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x000472B0 File Offset: 0x000454B0
		public virtual string GetStatusText(uint statusCode)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetStatusText", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetStatusText(statusCode);
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x000472E8 File Offset: 0x000454E8
		public virtual void SendRemoteAction(RemoteSessionActionType actionType)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SendRemoteAction", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SendRemoteAction(actionType);
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x00047310 File Offset: 0x00045510
		public virtual ControlReconnectStatus Reconnect(uint ulWidth, uint ulHeight)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Reconnect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.Reconnect(ulWidth, ulHeight);
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x00047348 File Offset: 0x00045548
		protected override void CreateSink()
		{
			try
			{
				this.eventMulticaster = new AxMsRdpClient8NotSafeForScriptingEventMulticaster(this);
				this.cookie = new AxHost.ConnectionPointCookie(this.ocx, this.eventMulticaster, typeof(IMsTscAxEvents));
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x000473A0 File Offset: 0x000455A0
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

		// Token: 0x0600152A RID: 5418 RVA: 0x000473D4 File Offset: 0x000455D4
		protected override void AttachInterfaces()
		{
			try
			{
				this.ocx = (IMsRdpClient8)base.GetOcx();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x00047410 File Offset: 0x00045610
		internal void RaiseOnOnConnecting(object sender, EventArgs e)
		{
			if (this.OnConnecting != null)
			{
				this.OnConnecting(sender, e);
			}
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x0004742C File Offset: 0x0004562C
		internal void RaiseOnOnConnected(object sender, EventArgs e)
		{
			if (this.OnConnected != null)
			{
				this.OnConnected(sender, e);
			}
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x00047448 File Offset: 0x00045648
		internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
		{
			if (this.OnLoginComplete != null)
			{
				this.OnLoginComplete(sender, e);
			}
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x00047464 File Offset: 0x00045664
		internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
		{
			if (this.OnDisconnected != null)
			{
				this.OnDisconnected(sender, e);
			}
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x00047480 File Offset: 0x00045680
		internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnEnterFullScreenMode != null)
			{
				this.OnEnterFullScreenMode(sender, e);
			}
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x0004749C File Offset: 0x0004569C
		internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnLeaveFullScreenMode != null)
			{
				this.OnLeaveFullScreenMode(sender, e);
			}
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x000474B8 File Offset: 0x000456B8
		internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
		{
			if (this.OnChannelReceivedData != null)
			{
				this.OnChannelReceivedData(sender, e);
			}
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x000474D4 File Offset: 0x000456D4
		internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestGoFullScreen != null)
			{
				this.OnRequestGoFullScreen(sender, e);
			}
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x000474F0 File Offset: 0x000456F0
		internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestLeaveFullScreen != null)
			{
				this.OnRequestLeaveFullScreen(sender, e);
			}
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x0004750C File Offset: 0x0004570C
		internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
		{
			if (this.OnFatalError != null)
			{
				this.OnFatalError(sender, e);
			}
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x00047528 File Offset: 0x00045728
		internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
		{
			if (this.OnWarning != null)
			{
				this.OnWarning(sender, e);
			}
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x00047544 File Offset: 0x00045744
		internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
		{
			if (this.OnRemoteDesktopSizeChange != null)
			{
				this.OnRemoteDesktopSizeChange(sender, e);
			}
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x00047560 File Offset: 0x00045760
		internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
		{
			if (this.OnIdleTimeoutNotification != null)
			{
				this.OnIdleTimeoutNotification(sender, e);
			}
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x0004757C File Offset: 0x0004577C
		internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
		{
			if (this.OnRequestContainerMinimize != null)
			{
				this.OnRequestContainerMinimize(sender, e);
			}
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x00047598 File Offset: 0x00045798
		internal void RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
		{
			if (this.OnConfirmClose != null)
			{
				this.OnConfirmClose(sender, e);
			}
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x000475B4 File Offset: 0x000457B4
		internal void RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
		{
			if (this.OnReceivedTSPublicKey != null)
			{
				this.OnReceivedTSPublicKey(sender, e);
			}
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x000475D0 File Offset: 0x000457D0
		internal void RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
		{
			if (this.OnAutoReconnecting != null)
			{
				this.OnAutoReconnecting(sender, e);
			}
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x000475EC File Offset: 0x000457EC
		internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDisplayed != null)
			{
				this.OnAuthenticationWarningDisplayed(sender, e);
			}
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x00047608 File Offset: 0x00045808
		internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDismissed != null)
			{
				this.OnAuthenticationWarningDismissed(sender, e);
			}
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x00047624 File Offset: 0x00045824
		internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
		{
			if (this.OnRemoteProgramResult != null)
			{
				this.OnRemoteProgramResult(sender, e);
			}
		}

		// Token: 0x0600153F RID: 5439 RVA: 0x00047640 File Offset: 0x00045840
		internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
		{
			if (this.OnRemoteProgramDisplayed != null)
			{
				this.OnRemoteProgramDisplayed(sender, e);
			}
		}

		// Token: 0x06001540 RID: 5440 RVA: 0x0004765C File Offset: 0x0004585C
		internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
		{
			if (this.OnRemoteWindowDisplayed != null)
			{
				this.OnRemoteWindowDisplayed(sender, e);
			}
		}

		// Token: 0x06001541 RID: 5441 RVA: 0x00047678 File Offset: 0x00045878
		internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
		{
			if (this.OnLogonError != null)
			{
				this.OnLogonError(sender, e);
			}
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x00047694 File Offset: 0x00045894
		internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
		{
			if (this.OnFocusReleased != null)
			{
				this.OnFocusReleased(sender, e);
			}
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x000476B0 File Offset: 0x000458B0
		internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
		{
			if (this.OnUserNameAcquired != null)
			{
				this.OnUserNameAcquired(sender, e);
			}
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x000476CC File Offset: 0x000458CC
		internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
		{
			if (this.OnMouseInputModeChanged != null)
			{
				this.OnMouseInputModeChanged(sender, e);
			}
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x000476E8 File Offset: 0x000458E8
		internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
		{
			if (this.OnServiceMessageReceived != null)
			{
				this.OnServiceMessageReceived(sender, e);
			}
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x00047704 File Offset: 0x00045904
		internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
		{
			if (this.OnConnectionBarPullDown != null)
			{
				this.OnConnectionBarPullDown(sender, e);
			}
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x00047720 File Offset: 0x00045920
		internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
		{
			if (this.OnNetworkStatusChanged != null)
			{
				this.OnNetworkStatusChanged(sender, e);
			}
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x0004773C File Offset: 0x0004593C
		internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
		{
			if (this.OnDevicesButtonPressed != null)
			{
				this.OnDevicesButtonPressed(sender, e);
			}
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x00047758 File Offset: 0x00045958
		internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
		{
			if (this.OnAutoReconnected != null)
			{
				this.OnAutoReconnected(sender, e);
			}
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x00047774 File Offset: 0x00045974
		internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
		{
			if (this.OnAutoReconnecting2 != null)
			{
				this.OnAutoReconnecting2(sender, e);
			}
		}

		// Token: 0x040005EF RID: 1519
		private IMsRdpClient8 ocx;

		// Token: 0x040005F0 RID: 1520
		private AxMsRdpClient8NotSafeForScriptingEventMulticaster eventMulticaster;

		// Token: 0x040005F1 RID: 1521
		private AxHost.ConnectionPointCookie cookie;
	}
}
