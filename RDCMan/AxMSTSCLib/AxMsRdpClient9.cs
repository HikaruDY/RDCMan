using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MSTSCLib;

namespace AxMSTSCLib
{
	// Token: 0x0200013E RID: 318
	[DefaultEvent("OnConnecting")]
	[AxHost.ClsidAttribute("{301b94ba-5d25-4a12-bffe-3b6e7a616585}")]
	[DesignTimeVisible(true)]
	[ComVisible(true)]
	public class AxMsRdpClient9 : AxHost
	{
		// Token: 0x060016F3 RID: 5875 RVA: 0x0004C280 File Offset: 0x0004A480
		public AxMsRdpClient9() : base("301b94ba-5d25-4a12-bffe-3b6e7a616585")
		{
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x060016F4 RID: 5876 RVA: 0x0004C290 File Offset: 0x0004A490
		// (set) Token: 0x060016F5 RID: 5877 RVA: 0x0004C2B4 File Offset: 0x0004A4B4
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

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x060016F6 RID: 5878 RVA: 0x0004C2DC File Offset: 0x0004A4DC
		// (set) Token: 0x060016F7 RID: 5879 RVA: 0x0004C300 File Offset: 0x0004A500
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

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x060016F8 RID: 5880 RVA: 0x0004C328 File Offset: 0x0004A528
		// (set) Token: 0x060016F9 RID: 5881 RVA: 0x0004C34C File Offset: 0x0004A54C
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

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x060016FA RID: 5882 RVA: 0x0004C374 File Offset: 0x0004A574
		// (set) Token: 0x060016FB RID: 5883 RVA: 0x0004C398 File Offset: 0x0004A598
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

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x060016FC RID: 5884 RVA: 0x0004C3C0 File Offset: 0x0004A5C0
		// (set) Token: 0x060016FD RID: 5885 RVA: 0x0004C3E4 File Offset: 0x0004A5E4
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

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x060016FE RID: 5886 RVA: 0x0004C40C File Offset: 0x0004A60C
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

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x060016FF RID: 5887 RVA: 0x0004C430 File Offset: 0x0004A630
		// (set) Token: 0x06001700 RID: 5888 RVA: 0x0004C454 File Offset: 0x0004A654
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

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06001701 RID: 5889 RVA: 0x0004C47C File Offset: 0x0004A67C
		// (set) Token: 0x06001702 RID: 5890 RVA: 0x0004C4A0 File Offset: 0x0004A6A0
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

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06001703 RID: 5891 RVA: 0x0004C4C8 File Offset: 0x0004A6C8
		// (set) Token: 0x06001704 RID: 5892 RVA: 0x0004C4EC File Offset: 0x0004A6EC
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

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06001705 RID: 5893 RVA: 0x0004C514 File Offset: 0x0004A714
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

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06001706 RID: 5894 RVA: 0x0004C538 File Offset: 0x0004A738
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

		// Token: 0x1700042C RID: 1068
		// (set) Token: 0x06001707 RID: 5895 RVA: 0x0004C55C File Offset: 0x0004A75C
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

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06001708 RID: 5896 RVA: 0x0004C584 File Offset: 0x0004A784
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

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06001709 RID: 5897 RVA: 0x0004C5A8 File Offset: 0x0004A7A8
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

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x0600170A RID: 5898 RVA: 0x0004C5CC File Offset: 0x0004A7CC
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

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x0600170B RID: 5899 RVA: 0x0004C5F0 File Offset: 0x0004A7F0
		[DispId(97)]
		[Browsable(false)]
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

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x0600170C RID: 5900 RVA: 0x0004C614 File Offset: 0x0004A814
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

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x0600170D RID: 5901 RVA: 0x0004C638 File Offset: 0x0004A838
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

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x0600170E RID: 5902 RVA: 0x0004C65C File Offset: 0x0004A85C
		// (set) Token: 0x0600170F RID: 5903 RVA: 0x0004C680 File Offset: 0x0004A880
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

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06001710 RID: 5904 RVA: 0x0004C6A8 File Offset: 0x0004A8A8
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

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06001711 RID: 5905 RVA: 0x0004C6CC File Offset: 0x0004A8CC
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

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06001712 RID: 5906 RVA: 0x0004C6F0 File Offset: 0x0004A8F0
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

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06001713 RID: 5907 RVA: 0x0004C714 File Offset: 0x0004A914
		// (set) Token: 0x06001714 RID: 5908 RVA: 0x0004C738 File Offset: 0x0004A938
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

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06001715 RID: 5909 RVA: 0x0004C760 File Offset: 0x0004A960
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

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06001716 RID: 5910 RVA: 0x0004C784 File Offset: 0x0004A984
		// (set) Token: 0x06001717 RID: 5911 RVA: 0x0004C7A8 File Offset: 0x0004A9A8
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

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06001718 RID: 5912 RVA: 0x0004C7D0 File Offset: 0x0004A9D0
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06001719 RID: 5913 RVA: 0x0004C7F4 File Offset: 0x0004A9F4
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

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x0600171A RID: 5914 RVA: 0x0004C818 File Offset: 0x0004AA18
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

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x0600171B RID: 5915 RVA: 0x0004C83C File Offset: 0x0004AA3C
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(502)]
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

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x0600171C RID: 5916 RVA: 0x0004C860 File Offset: 0x0004AA60
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		[DispId(504)]
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

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x0600171D RID: 5917 RVA: 0x0004C884 File Offset: 0x0004AA84
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

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x0600171E RID: 5918 RVA: 0x0004C8A8 File Offset: 0x0004AAA8
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(507)]
		[Browsable(false)]
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

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x0600171F RID: 5919 RVA: 0x0004C8CC File Offset: 0x0004AACC
		[DispId(506)]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06001720 RID: 5920 RVA: 0x0004C8F0 File Offset: 0x0004AAF0
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(600)]
		[Browsable(false)]
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

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06001721 RID: 5921 RVA: 0x0004C914 File Offset: 0x0004AB14
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(601)]
		[Browsable(false)]
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

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06001722 RID: 5922 RVA: 0x0004C938 File Offset: 0x0004AB38
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(603)]
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

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06001723 RID: 5923 RVA: 0x0004C95C File Offset: 0x0004AB5C
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(604)]
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

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06001724 RID: 5924 RVA: 0x0004C980 File Offset: 0x0004AB80
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(701)]
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

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06001725 RID: 5925 RVA: 0x0004C9A4 File Offset: 0x0004ABA4
		[DispId(800)]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual IMsRdpClientTransportSettings4 TransportSettings4
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("TransportSettings4", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.TransportSettings4;
			}
		}

		// Token: 0x14000289 RID: 649
		// (add) Token: 0x06001726 RID: 5926 RVA: 0x0004C9C8 File Offset: 0x0004ABC8
		// (remove) Token: 0x06001727 RID: 5927 RVA: 0x0004CA04 File Offset: 0x0004AC04
		public event EventHandler OnConnecting;

		// Token: 0x1400028A RID: 650
		// (add) Token: 0x06001728 RID: 5928 RVA: 0x0004CA40 File Offset: 0x0004AC40
		// (remove) Token: 0x06001729 RID: 5929 RVA: 0x0004CA7C File Offset: 0x0004AC7C
		public event EventHandler OnConnected;

		// Token: 0x1400028B RID: 651
		// (add) Token: 0x0600172A RID: 5930 RVA: 0x0004CAB8 File Offset: 0x0004ACB8
		// (remove) Token: 0x0600172B RID: 5931 RVA: 0x0004CAF4 File Offset: 0x0004ACF4
		public event EventHandler OnLoginComplete;

		// Token: 0x1400028C RID: 652
		// (add) Token: 0x0600172C RID: 5932 RVA: 0x0004CB30 File Offset: 0x0004AD30
		// (remove) Token: 0x0600172D RID: 5933 RVA: 0x0004CB6C File Offset: 0x0004AD6C
		public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x1400028D RID: 653
		// (add) Token: 0x0600172E RID: 5934 RVA: 0x0004CBA8 File Offset: 0x0004ADA8
		// (remove) Token: 0x0600172F RID: 5935 RVA: 0x0004CBE4 File Offset: 0x0004ADE4
		public event EventHandler OnEnterFullScreenMode;

		// Token: 0x1400028E RID: 654
		// (add) Token: 0x06001730 RID: 5936 RVA: 0x0004CC20 File Offset: 0x0004AE20
		// (remove) Token: 0x06001731 RID: 5937 RVA: 0x0004CC5C File Offset: 0x0004AE5C
		public event EventHandler OnLeaveFullScreenMode;

		// Token: 0x1400028F RID: 655
		// (add) Token: 0x06001732 RID: 5938 RVA: 0x0004CC98 File Offset: 0x0004AE98
		// (remove) Token: 0x06001733 RID: 5939 RVA: 0x0004CCD4 File Offset: 0x0004AED4
		public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x14000290 RID: 656
		// (add) Token: 0x06001734 RID: 5940 RVA: 0x0004CD10 File Offset: 0x0004AF10
		// (remove) Token: 0x06001735 RID: 5941 RVA: 0x0004CD4C File Offset: 0x0004AF4C
		public event EventHandler OnRequestGoFullScreen;

		// Token: 0x14000291 RID: 657
		// (add) Token: 0x06001736 RID: 5942 RVA: 0x0004CD88 File Offset: 0x0004AF88
		// (remove) Token: 0x06001737 RID: 5943 RVA: 0x0004CDC4 File Offset: 0x0004AFC4
		public event EventHandler OnRequestLeaveFullScreen;

		// Token: 0x14000292 RID: 658
		// (add) Token: 0x06001738 RID: 5944 RVA: 0x0004CE00 File Offset: 0x0004B000
		// (remove) Token: 0x06001739 RID: 5945 RVA: 0x0004CE3C File Offset: 0x0004B03C
		public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x14000293 RID: 659
		// (add) Token: 0x0600173A RID: 5946 RVA: 0x0004CE78 File Offset: 0x0004B078
		// (remove) Token: 0x0600173B RID: 5947 RVA: 0x0004CEB4 File Offset: 0x0004B0B4
		public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x14000294 RID: 660
		// (add) Token: 0x0600173C RID: 5948 RVA: 0x0004CEF0 File Offset: 0x0004B0F0
		// (remove) Token: 0x0600173D RID: 5949 RVA: 0x0004CF2C File Offset: 0x0004B12C
		public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x14000295 RID: 661
		// (add) Token: 0x0600173E RID: 5950 RVA: 0x0004CF68 File Offset: 0x0004B168
		// (remove) Token: 0x0600173F RID: 5951 RVA: 0x0004CFA4 File Offset: 0x0004B1A4
		public event EventHandler OnIdleTimeoutNotification;

		// Token: 0x14000296 RID: 662
		// (add) Token: 0x06001740 RID: 5952 RVA: 0x0004CFE0 File Offset: 0x0004B1E0
		// (remove) Token: 0x06001741 RID: 5953 RVA: 0x0004D01C File Offset: 0x0004B21C
		public event EventHandler OnRequestContainerMinimize;

		// Token: 0x14000297 RID: 663
		// (add) Token: 0x06001742 RID: 5954 RVA: 0x0004D058 File Offset: 0x0004B258
		// (remove) Token: 0x06001743 RID: 5955 RVA: 0x0004D094 File Offset: 0x0004B294
		public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x14000298 RID: 664
		// (add) Token: 0x06001744 RID: 5956 RVA: 0x0004D0D0 File Offset: 0x0004B2D0
		// (remove) Token: 0x06001745 RID: 5957 RVA: 0x0004D10C File Offset: 0x0004B30C
		public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x14000299 RID: 665
		// (add) Token: 0x06001746 RID: 5958 RVA: 0x0004D148 File Offset: 0x0004B348
		// (remove) Token: 0x06001747 RID: 5959 RVA: 0x0004D184 File Offset: 0x0004B384
		public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x1400029A RID: 666
		// (add) Token: 0x06001748 RID: 5960 RVA: 0x0004D1C0 File Offset: 0x0004B3C0
		// (remove) Token: 0x06001749 RID: 5961 RVA: 0x0004D1FC File Offset: 0x0004B3FC
		public event EventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x1400029B RID: 667
		// (add) Token: 0x0600174A RID: 5962 RVA: 0x0004D238 File Offset: 0x0004B438
		// (remove) Token: 0x0600174B RID: 5963 RVA: 0x0004D274 File Offset: 0x0004B474
		public event EventHandler OnAuthenticationWarningDismissed;

		// Token: 0x1400029C RID: 668
		// (add) Token: 0x0600174C RID: 5964 RVA: 0x0004D2B0 File Offset: 0x0004B4B0
		// (remove) Token: 0x0600174D RID: 5965 RVA: 0x0004D2EC File Offset: 0x0004B4EC
		public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x1400029D RID: 669
		// (add) Token: 0x0600174E RID: 5966 RVA: 0x0004D328 File Offset: 0x0004B528
		// (remove) Token: 0x0600174F RID: 5967 RVA: 0x0004D364 File Offset: 0x0004B564
		public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x1400029E RID: 670
		// (add) Token: 0x06001750 RID: 5968 RVA: 0x0004D3A0 File Offset: 0x0004B5A0
		// (remove) Token: 0x06001751 RID: 5969 RVA: 0x0004D3DC File Offset: 0x0004B5DC
		public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x1400029F RID: 671
		// (add) Token: 0x06001752 RID: 5970 RVA: 0x0004D418 File Offset: 0x0004B618
		// (remove) Token: 0x06001753 RID: 5971 RVA: 0x0004D454 File Offset: 0x0004B654
		public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x140002A0 RID: 672
		// (add) Token: 0x06001754 RID: 5972 RVA: 0x0004D490 File Offset: 0x0004B690
		// (remove) Token: 0x06001755 RID: 5973 RVA: 0x0004D4CC File Offset: 0x0004B6CC
		public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x140002A1 RID: 673
		// (add) Token: 0x06001756 RID: 5974 RVA: 0x0004D508 File Offset: 0x0004B708
		// (remove) Token: 0x06001757 RID: 5975 RVA: 0x0004D544 File Offset: 0x0004B744
		public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x140002A2 RID: 674
		// (add) Token: 0x06001758 RID: 5976 RVA: 0x0004D580 File Offset: 0x0004B780
		// (remove) Token: 0x06001759 RID: 5977 RVA: 0x0004D5BC File Offset: 0x0004B7BC
		public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x140002A3 RID: 675
		// (add) Token: 0x0600175A RID: 5978 RVA: 0x0004D5F8 File Offset: 0x0004B7F8
		// (remove) Token: 0x0600175B RID: 5979 RVA: 0x0004D634 File Offset: 0x0004B834
		public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x140002A4 RID: 676
		// (add) Token: 0x0600175C RID: 5980 RVA: 0x0004D670 File Offset: 0x0004B870
		// (remove) Token: 0x0600175D RID: 5981 RVA: 0x0004D6AC File Offset: 0x0004B8AC
		public event EventHandler OnConnectionBarPullDown;

		// Token: 0x140002A5 RID: 677
		// (add) Token: 0x0600175E RID: 5982 RVA: 0x0004D6E8 File Offset: 0x0004B8E8
		// (remove) Token: 0x0600175F RID: 5983 RVA: 0x0004D724 File Offset: 0x0004B924
		public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x140002A6 RID: 678
		// (add) Token: 0x06001760 RID: 5984 RVA: 0x0004D760 File Offset: 0x0004B960
		// (remove) Token: 0x06001761 RID: 5985 RVA: 0x0004D79C File Offset: 0x0004B99C
		public event EventHandler OnDevicesButtonPressed;

		// Token: 0x140002A7 RID: 679
		// (add) Token: 0x06001762 RID: 5986 RVA: 0x0004D7D8 File Offset: 0x0004B9D8
		// (remove) Token: 0x06001763 RID: 5987 RVA: 0x0004D814 File Offset: 0x0004BA14
		public event EventHandler OnAutoReconnected;

		// Token: 0x140002A8 RID: 680
		// (add) Token: 0x06001764 RID: 5988 RVA: 0x0004D850 File Offset: 0x0004BA50
		// (remove) Token: 0x06001765 RID: 5989 RVA: 0x0004D88C File Offset: 0x0004BA8C
		public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

		// Token: 0x06001766 RID: 5990 RVA: 0x0004D8C8 File Offset: 0x0004BAC8
		public virtual void Connect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Connect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Connect();
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x0004D8EC File Offset: 0x0004BAEC
		public virtual void Disconnect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Disconnect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Disconnect();
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x0004D910 File Offset: 0x0004BB10
		public virtual void CreateVirtualChannels(string newVal)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("CreateVirtualChannels", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.CreateVirtualChannels(newVal);
		}

		// Token: 0x06001769 RID: 5993 RVA: 0x0004D938 File Offset: 0x0004BB38
		public virtual void SendOnVirtualChannel(string chanName, string chanData)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SendOnVirtualChannel", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SendOnVirtualChannel(chanName, chanData);
		}

		// Token: 0x0600176A RID: 5994 RVA: 0x0004D960 File Offset: 0x0004BB60
		public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SetVirtualChannelOptions(chanName, chanOptions);
		}

		// Token: 0x0600176B RID: 5995 RVA: 0x0004D988 File Offset: 0x0004BB88
		public virtual int GetVirtualChannelOptions(string chanName)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetVirtualChannelOptions(chanName);
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x0004D9C0 File Offset: 0x0004BBC0
		public virtual ControlCloseStatus RequestClose()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("RequestClose", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.RequestClose();
		}

		// Token: 0x0600176D RID: 5997 RVA: 0x0004D9F8 File Offset: 0x0004BBF8
		public virtual string GetErrorDescription(uint disconnectReason, uint extendedDisconnectReason)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetErrorDescription", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetErrorDescription(disconnectReason, extendedDisconnectReason);
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x0004DA30 File Offset: 0x0004BC30
		public virtual string GetStatusText(uint statusCode)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetStatusText", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetStatusText(statusCode);
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x0004DA68 File Offset: 0x0004BC68
		public virtual void SendRemoteAction(RemoteSessionActionType actionType)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SendRemoteAction", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SendRemoteAction(actionType);
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x0004DA90 File Offset: 0x0004BC90
		public virtual ControlReconnectStatus Reconnect(uint ulWidth, uint ulHeight)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Reconnect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.Reconnect(ulWidth, ulHeight);
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x0004DAC8 File Offset: 0x0004BCC8
		public virtual void SyncSessionDisplaySettings()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SyncSessionDisplaySettings", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SyncSessionDisplaySettings();
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x0004DAEC File Offset: 0x0004BCEC
		public virtual void UpdateSessionDisplaySettings(uint ulDesktopWidth, uint ulDesktopHeight, uint ulPhysicalWidth, uint ulPhysicalHeight, uint ulOrientation, uint ulDesktopScaleFactor, uint ulDeviceScaleFactor)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("UpdateSessionDisplaySettings", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.UpdateSessionDisplaySettings(ulDesktopWidth, ulDesktopHeight, ulPhysicalWidth, ulPhysicalHeight, ulOrientation, ulDesktopScaleFactor, ulDeviceScaleFactor);
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x0004DB2C File Offset: 0x0004BD2C
		public virtual void attachEvent(string eventName, object callback)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("attachEvent", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.attachEvent(eventName, callback);
		}

		// Token: 0x06001774 RID: 6004 RVA: 0x0004DB54 File Offset: 0x0004BD54
		public virtual void detachEvent(string eventName, object callback)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("detachEvent", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.detachEvent(eventName, callback);
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x0004DB7C File Offset: 0x0004BD7C
		protected override void CreateSink()
		{
			try
			{
				this.eventMulticaster = new AxMsRdpClient9EventMulticaster(this);
				this.cookie = new AxHost.ConnectionPointCookie(this.ocx, this.eventMulticaster, typeof(IMsTscAxEvents));
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x0004DBD4 File Offset: 0x0004BDD4
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

		// Token: 0x06001777 RID: 6007 RVA: 0x0004DC08 File Offset: 0x0004BE08
		protected override void AttachInterfaces()
		{
			try
			{
				this.ocx = (IMsRdpClient9)base.GetOcx();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06001778 RID: 6008 RVA: 0x0004DC44 File Offset: 0x0004BE44
		internal void RaiseOnOnConnecting(object sender, EventArgs e)
		{
			if (this.OnConnecting != null)
			{
				this.OnConnecting(sender, e);
			}
		}

		// Token: 0x06001779 RID: 6009 RVA: 0x0004DC60 File Offset: 0x0004BE60
		internal void RaiseOnOnConnected(object sender, EventArgs e)
		{
			if (this.OnConnected != null)
			{
				this.OnConnected(sender, e);
			}
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x0004DC7C File Offset: 0x0004BE7C
		internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
		{
			if (this.OnLoginComplete != null)
			{
				this.OnLoginComplete(sender, e);
			}
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x0004DC98 File Offset: 0x0004BE98
		internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
		{
			if (this.OnDisconnected != null)
			{
				this.OnDisconnected(sender, e);
			}
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x0004DCB4 File Offset: 0x0004BEB4
		internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnEnterFullScreenMode != null)
			{
				this.OnEnterFullScreenMode(sender, e);
			}
		}

		// Token: 0x0600177D RID: 6013 RVA: 0x0004DCD0 File Offset: 0x0004BED0
		internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnLeaveFullScreenMode != null)
			{
				this.OnLeaveFullScreenMode(sender, e);
			}
		}

		// Token: 0x0600177E RID: 6014 RVA: 0x0004DCEC File Offset: 0x0004BEEC
		internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
		{
			if (this.OnChannelReceivedData != null)
			{
				this.OnChannelReceivedData(sender, e);
			}
		}

		// Token: 0x0600177F RID: 6015 RVA: 0x0004DD08 File Offset: 0x0004BF08
		internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestGoFullScreen != null)
			{
				this.OnRequestGoFullScreen(sender, e);
			}
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x0004DD24 File Offset: 0x0004BF24
		internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestLeaveFullScreen != null)
			{
				this.OnRequestLeaveFullScreen(sender, e);
			}
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x0004DD40 File Offset: 0x0004BF40
		internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
		{
			if (this.OnFatalError != null)
			{
				this.OnFatalError(sender, e);
			}
		}

		// Token: 0x06001782 RID: 6018 RVA: 0x0004DD5C File Offset: 0x0004BF5C
		internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
		{
			if (this.OnWarning != null)
			{
				this.OnWarning(sender, e);
			}
		}

		// Token: 0x06001783 RID: 6019 RVA: 0x0004DD78 File Offset: 0x0004BF78
		internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
		{
			if (this.OnRemoteDesktopSizeChange != null)
			{
				this.OnRemoteDesktopSizeChange(sender, e);
			}
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x0004DD94 File Offset: 0x0004BF94
		internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
		{
			if (this.OnIdleTimeoutNotification != null)
			{
				this.OnIdleTimeoutNotification(sender, e);
			}
		}

		// Token: 0x06001785 RID: 6021 RVA: 0x0004DDB0 File Offset: 0x0004BFB0
		internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
		{
			if (this.OnRequestContainerMinimize != null)
			{
				this.OnRequestContainerMinimize(sender, e);
			}
		}

		// Token: 0x06001786 RID: 6022 RVA: 0x0004DDCC File Offset: 0x0004BFCC
		internal void RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
		{
			if (this.OnConfirmClose != null)
			{
				this.OnConfirmClose(sender, e);
			}
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x0004DDE8 File Offset: 0x0004BFE8
		internal void RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
		{
			if (this.OnReceivedTSPublicKey != null)
			{
				this.OnReceivedTSPublicKey(sender, e);
			}
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x0004DE04 File Offset: 0x0004C004
		internal void RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
		{
			if (this.OnAutoReconnecting != null)
			{
				this.OnAutoReconnecting(sender, e);
			}
		}

		// Token: 0x06001789 RID: 6025 RVA: 0x0004DE20 File Offset: 0x0004C020
		internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDisplayed != null)
			{
				this.OnAuthenticationWarningDisplayed(sender, e);
			}
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x0004DE3C File Offset: 0x0004C03C
		internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDismissed != null)
			{
				this.OnAuthenticationWarningDismissed(sender, e);
			}
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x0004DE58 File Offset: 0x0004C058
		internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
		{
			if (this.OnRemoteProgramResult != null)
			{
				this.OnRemoteProgramResult(sender, e);
			}
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x0004DE74 File Offset: 0x0004C074
		internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
		{
			if (this.OnRemoteProgramDisplayed != null)
			{
				this.OnRemoteProgramDisplayed(sender, e);
			}
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x0004DE90 File Offset: 0x0004C090
		internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
		{
			if (this.OnRemoteWindowDisplayed != null)
			{
				this.OnRemoteWindowDisplayed(sender, e);
			}
		}

		// Token: 0x0600178E RID: 6030 RVA: 0x0004DEAC File Offset: 0x0004C0AC
		internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
		{
			if (this.OnLogonError != null)
			{
				this.OnLogonError(sender, e);
			}
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x0004DEC8 File Offset: 0x0004C0C8
		internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
		{
			if (this.OnFocusReleased != null)
			{
				this.OnFocusReleased(sender, e);
			}
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x0004DEE4 File Offset: 0x0004C0E4
		internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
		{
			if (this.OnUserNameAcquired != null)
			{
				this.OnUserNameAcquired(sender, e);
			}
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x0004DF00 File Offset: 0x0004C100
		internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
		{
			if (this.OnMouseInputModeChanged != null)
			{
				this.OnMouseInputModeChanged(sender, e);
			}
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x0004DF1C File Offset: 0x0004C11C
		internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
		{
			if (this.OnServiceMessageReceived != null)
			{
				this.OnServiceMessageReceived(sender, e);
			}
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x0004DF38 File Offset: 0x0004C138
		internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
		{
			if (this.OnConnectionBarPullDown != null)
			{
				this.OnConnectionBarPullDown(sender, e);
			}
		}

		// Token: 0x06001794 RID: 6036 RVA: 0x0004DF54 File Offset: 0x0004C154
		internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
		{
			if (this.OnNetworkStatusChanged != null)
			{
				this.OnNetworkStatusChanged(sender, e);
			}
		}

		// Token: 0x06001795 RID: 6037 RVA: 0x0004DF70 File Offset: 0x0004C170
		internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
		{
			if (this.OnDevicesButtonPressed != null)
			{
				this.OnDevicesButtonPressed(sender, e);
			}
		}

		// Token: 0x06001796 RID: 6038 RVA: 0x0004DF8C File Offset: 0x0004C18C
		internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
		{
			if (this.OnAutoReconnected != null)
			{
				this.OnAutoReconnected(sender, e);
			}
		}

		// Token: 0x06001797 RID: 6039 RVA: 0x0004DFA8 File Offset: 0x0004C1A8
		internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
		{
			if (this.OnAutoReconnecting2 != null)
			{
				this.OnAutoReconnecting2(sender, e);
			}
		}

		// Token: 0x0400065B RID: 1627
		private IMsRdpClient9 ocx;

		// Token: 0x0400065C RID: 1628
		private AxMsRdpClient9EventMulticaster eventMulticaster;

		// Token: 0x0400065D RID: 1629
		private AxHost.ConnectionPointCookie cookie;
	}
}
