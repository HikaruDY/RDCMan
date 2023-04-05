using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MSTSCLib;

namespace AxMSTSCLib
{
	// Token: 0x02000140 RID: 320
	[DefaultEvent("OnConnecting")]
	[AxHost.ClsidAttribute("{a0c63c30-f08d-4ab4-907c-34905d770c7d}")]
	[DesignTimeVisible(true)]
	[ComVisible(true)]
	public class AxMsRdpClient10NotSafeForScripting : AxHost
	{
		// Token: 0x060017B9 RID: 6073 RVA: 0x0004E584 File Offset: 0x0004C784
		public AxMsRdpClient10NotSafeForScripting() : base("a0c63c30-f08d-4ab4-907c-34905d770c7d")
		{
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x060017BA RID: 6074 RVA: 0x0004E594 File Offset: 0x0004C794
		// (set) Token: 0x060017BB RID: 6075 RVA: 0x0004E5B8 File Offset: 0x0004C7B8
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

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x060017BC RID: 6076 RVA: 0x0004E5E0 File Offset: 0x0004C7E0
		// (set) Token: 0x060017BD RID: 6077 RVA: 0x0004E604 File Offset: 0x0004C804
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

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x060017BE RID: 6078 RVA: 0x0004E62C File Offset: 0x0004C82C
		// (set) Token: 0x060017BF RID: 6079 RVA: 0x0004E650 File Offset: 0x0004C850
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

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x060017C0 RID: 6080 RVA: 0x0004E678 File Offset: 0x0004C878
		// (set) Token: 0x060017C1 RID: 6081 RVA: 0x0004E69C File Offset: 0x0004C89C
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

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x060017C2 RID: 6082 RVA: 0x0004E6C4 File Offset: 0x0004C8C4
		// (set) Token: 0x060017C3 RID: 6083 RVA: 0x0004E6E8 File Offset: 0x0004C8E8
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

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x060017C4 RID: 6084 RVA: 0x0004E710 File Offset: 0x0004C910
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

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x060017C5 RID: 6085 RVA: 0x0004E734 File Offset: 0x0004C934
		// (set) Token: 0x060017C6 RID: 6086 RVA: 0x0004E758 File Offset: 0x0004C958
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

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x060017C7 RID: 6087 RVA: 0x0004E780 File Offset: 0x0004C980
		// (set) Token: 0x060017C8 RID: 6088 RVA: 0x0004E7A4 File Offset: 0x0004C9A4
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

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x060017C9 RID: 6089 RVA: 0x0004E7CC File Offset: 0x0004C9CC
		// (set) Token: 0x060017CA RID: 6090 RVA: 0x0004E7F0 File Offset: 0x0004C9F0
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

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x060017CB RID: 6091 RVA: 0x0004E818 File Offset: 0x0004CA18
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

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x060017CC RID: 6092 RVA: 0x0004E83C File Offset: 0x0004CA3C
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

		// Token: 0x17000453 RID: 1107
		// (set) Token: 0x060017CD RID: 6093 RVA: 0x0004E860 File Offset: 0x0004CA60
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

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x060017CE RID: 6094 RVA: 0x0004E888 File Offset: 0x0004CA88
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

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x060017CF RID: 6095 RVA: 0x0004E8AC File Offset: 0x0004CAAC
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

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x060017D0 RID: 6096 RVA: 0x0004E8D0 File Offset: 0x0004CAD0
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

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x060017D1 RID: 6097 RVA: 0x0004E8F4 File Offset: 0x0004CAF4
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

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x060017D2 RID: 6098 RVA: 0x0004E918 File Offset: 0x0004CB18
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

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x060017D3 RID: 6099 RVA: 0x0004E93C File Offset: 0x0004CB3C
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

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x060017D4 RID: 6100 RVA: 0x0004E960 File Offset: 0x0004CB60
		// (set) Token: 0x060017D5 RID: 6101 RVA: 0x0004E984 File Offset: 0x0004CB84
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

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x060017D6 RID: 6102 RVA: 0x0004E9AC File Offset: 0x0004CBAC
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

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x060017D7 RID: 6103 RVA: 0x0004E9D0 File Offset: 0x0004CBD0
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

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x060017D8 RID: 6104 RVA: 0x0004E9F4 File Offset: 0x0004CBF4
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

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x060017D9 RID: 6105 RVA: 0x0004EA18 File Offset: 0x0004CC18
		// (set) Token: 0x060017DA RID: 6106 RVA: 0x0004EA3C File Offset: 0x0004CC3C
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

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x060017DB RID: 6107 RVA: 0x0004EA64 File Offset: 0x0004CC64
		[DispId(200)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x060017DC RID: 6108 RVA: 0x0004EA88 File Offset: 0x0004CC88
		// (set) Token: 0x060017DD RID: 6109 RVA: 0x0004EAAC File Offset: 0x0004CCAC
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

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x060017DE RID: 6110 RVA: 0x0004EAD4 File Offset: 0x0004CCD4
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

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x060017DF RID: 6111 RVA: 0x0004EAF8 File Offset: 0x0004CCF8
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(400)]
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

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x060017E0 RID: 6112 RVA: 0x0004EB1C File Offset: 0x0004CD1C
		[DispId(500)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
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

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x060017E1 RID: 6113 RVA: 0x0004EB40 File Offset: 0x0004CD40
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

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x060017E2 RID: 6114 RVA: 0x0004EB64 File Offset: 0x0004CD64
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x060017E3 RID: 6115 RVA: 0x0004EB88 File Offset: 0x0004CD88
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x060017E4 RID: 6116 RVA: 0x0004EBAC File Offset: 0x0004CDAC
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

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x060017E5 RID: 6117 RVA: 0x0004EBD0 File Offset: 0x0004CDD0
		[Browsable(false)]
		[DispId(506)]
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

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x060017E6 RID: 6118 RVA: 0x0004EBF4 File Offset: 0x0004CDF4
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

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x060017E7 RID: 6119 RVA: 0x0004EC18 File Offset: 0x0004CE18
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

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x060017E8 RID: 6120 RVA: 0x0004EC3C File Offset: 0x0004CE3C
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(603)]
		[Browsable(false)]
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

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x060017E9 RID: 6121 RVA: 0x0004EC60 File Offset: 0x0004CE60
		[DispId(604)]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x060017EA RID: 6122 RVA: 0x0004EC84 File Offset: 0x0004CE84
		[Browsable(false)]
		[DispId(701)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x060017EB RID: 6123 RVA: 0x0004ECA8 File Offset: 0x0004CEA8
		[Browsable(false)]
		[DispId(800)]
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

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x060017EC RID: 6124 RVA: 0x0004ECCC File Offset: 0x0004CECC
		[DispId(900)]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual ITSRemoteProgram3 RemoteProgram3
		{
			get
			{
				if (this.ocx == null)
				{
					throw new AxHost.InvalidActiveXStateException("RemoteProgram3", AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.RemoteProgram3;
			}
		}

		// Token: 0x140002A9 RID: 681
		// (add) Token: 0x060017ED RID: 6125 RVA: 0x0004ECF0 File Offset: 0x0004CEF0
		// (remove) Token: 0x060017EE RID: 6126 RVA: 0x0004ED2C File Offset: 0x0004CF2C
		public event EventHandler OnConnecting;

		// Token: 0x140002AA RID: 682
		// (add) Token: 0x060017EF RID: 6127 RVA: 0x0004ED68 File Offset: 0x0004CF68
		// (remove) Token: 0x060017F0 RID: 6128 RVA: 0x0004EDA4 File Offset: 0x0004CFA4
		public event EventHandler OnConnected;

		// Token: 0x140002AB RID: 683
		// (add) Token: 0x060017F1 RID: 6129 RVA: 0x0004EDE0 File Offset: 0x0004CFE0
		// (remove) Token: 0x060017F2 RID: 6130 RVA: 0x0004EE1C File Offset: 0x0004D01C
		public event EventHandler OnLoginComplete;

		// Token: 0x140002AC RID: 684
		// (add) Token: 0x060017F3 RID: 6131 RVA: 0x0004EE58 File Offset: 0x0004D058
		// (remove) Token: 0x060017F4 RID: 6132 RVA: 0x0004EE94 File Offset: 0x0004D094
		public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x140002AD RID: 685
		// (add) Token: 0x060017F5 RID: 6133 RVA: 0x0004EED0 File Offset: 0x0004D0D0
		// (remove) Token: 0x060017F6 RID: 6134 RVA: 0x0004EF0C File Offset: 0x0004D10C
		public event EventHandler OnEnterFullScreenMode;

		// Token: 0x140002AE RID: 686
		// (add) Token: 0x060017F7 RID: 6135 RVA: 0x0004EF48 File Offset: 0x0004D148
		// (remove) Token: 0x060017F8 RID: 6136 RVA: 0x0004EF84 File Offset: 0x0004D184
		public event EventHandler OnLeaveFullScreenMode;

		// Token: 0x140002AF RID: 687
		// (add) Token: 0x060017F9 RID: 6137 RVA: 0x0004EFC0 File Offset: 0x0004D1C0
		// (remove) Token: 0x060017FA RID: 6138 RVA: 0x0004EFFC File Offset: 0x0004D1FC
		public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x140002B0 RID: 688
		// (add) Token: 0x060017FB RID: 6139 RVA: 0x0004F038 File Offset: 0x0004D238
		// (remove) Token: 0x060017FC RID: 6140 RVA: 0x0004F074 File Offset: 0x0004D274
		public event EventHandler OnRequestGoFullScreen;

		// Token: 0x140002B1 RID: 689
		// (add) Token: 0x060017FD RID: 6141 RVA: 0x0004F0B0 File Offset: 0x0004D2B0
		// (remove) Token: 0x060017FE RID: 6142 RVA: 0x0004F0EC File Offset: 0x0004D2EC
		public event EventHandler OnRequestLeaveFullScreen;

		// Token: 0x140002B2 RID: 690
		// (add) Token: 0x060017FF RID: 6143 RVA: 0x0004F128 File Offset: 0x0004D328
		// (remove) Token: 0x06001800 RID: 6144 RVA: 0x0004F164 File Offset: 0x0004D364
		public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x140002B3 RID: 691
		// (add) Token: 0x06001801 RID: 6145 RVA: 0x0004F1A0 File Offset: 0x0004D3A0
		// (remove) Token: 0x06001802 RID: 6146 RVA: 0x0004F1DC File Offset: 0x0004D3DC
		public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x140002B4 RID: 692
		// (add) Token: 0x06001803 RID: 6147 RVA: 0x0004F218 File Offset: 0x0004D418
		// (remove) Token: 0x06001804 RID: 6148 RVA: 0x0004F254 File Offset: 0x0004D454
		public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x140002B5 RID: 693
		// (add) Token: 0x06001805 RID: 6149 RVA: 0x0004F290 File Offset: 0x0004D490
		// (remove) Token: 0x06001806 RID: 6150 RVA: 0x0004F2CC File Offset: 0x0004D4CC
		public event EventHandler OnIdleTimeoutNotification;

		// Token: 0x140002B6 RID: 694
		// (add) Token: 0x06001807 RID: 6151 RVA: 0x0004F308 File Offset: 0x0004D508
		// (remove) Token: 0x06001808 RID: 6152 RVA: 0x0004F344 File Offset: 0x0004D544
		public event EventHandler OnRequestContainerMinimize;

		// Token: 0x140002B7 RID: 695
		// (add) Token: 0x06001809 RID: 6153 RVA: 0x0004F380 File Offset: 0x0004D580
		// (remove) Token: 0x0600180A RID: 6154 RVA: 0x0004F3BC File Offset: 0x0004D5BC
		public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x140002B8 RID: 696
		// (add) Token: 0x0600180B RID: 6155 RVA: 0x0004F3F8 File Offset: 0x0004D5F8
		// (remove) Token: 0x0600180C RID: 6156 RVA: 0x0004F434 File Offset: 0x0004D634
		public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x140002B9 RID: 697
		// (add) Token: 0x0600180D RID: 6157 RVA: 0x0004F470 File Offset: 0x0004D670
		// (remove) Token: 0x0600180E RID: 6158 RVA: 0x0004F4AC File Offset: 0x0004D6AC
		public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x140002BA RID: 698
		// (add) Token: 0x0600180F RID: 6159 RVA: 0x0004F4E8 File Offset: 0x0004D6E8
		// (remove) Token: 0x06001810 RID: 6160 RVA: 0x0004F524 File Offset: 0x0004D724
		public event EventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x140002BB RID: 699
		// (add) Token: 0x06001811 RID: 6161 RVA: 0x0004F560 File Offset: 0x0004D760
		// (remove) Token: 0x06001812 RID: 6162 RVA: 0x0004F59C File Offset: 0x0004D79C
		public event EventHandler OnAuthenticationWarningDismissed;

		// Token: 0x140002BC RID: 700
		// (add) Token: 0x06001813 RID: 6163 RVA: 0x0004F5D8 File Offset: 0x0004D7D8
		// (remove) Token: 0x06001814 RID: 6164 RVA: 0x0004F614 File Offset: 0x0004D814
		public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x140002BD RID: 701
		// (add) Token: 0x06001815 RID: 6165 RVA: 0x0004F650 File Offset: 0x0004D850
		// (remove) Token: 0x06001816 RID: 6166 RVA: 0x0004F68C File Offset: 0x0004D88C
		public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x140002BE RID: 702
		// (add) Token: 0x06001817 RID: 6167 RVA: 0x0004F6C8 File Offset: 0x0004D8C8
		// (remove) Token: 0x06001818 RID: 6168 RVA: 0x0004F704 File Offset: 0x0004D904
		public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x140002BF RID: 703
		// (add) Token: 0x06001819 RID: 6169 RVA: 0x0004F740 File Offset: 0x0004D940
		// (remove) Token: 0x0600181A RID: 6170 RVA: 0x0004F77C File Offset: 0x0004D97C
		public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x140002C0 RID: 704
		// (add) Token: 0x0600181B RID: 6171 RVA: 0x0004F7B8 File Offset: 0x0004D9B8
		// (remove) Token: 0x0600181C RID: 6172 RVA: 0x0004F7F4 File Offset: 0x0004D9F4
		public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x140002C1 RID: 705
		// (add) Token: 0x0600181D RID: 6173 RVA: 0x0004F830 File Offset: 0x0004DA30
		// (remove) Token: 0x0600181E RID: 6174 RVA: 0x0004F86C File Offset: 0x0004DA6C
		public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x140002C2 RID: 706
		// (add) Token: 0x0600181F RID: 6175 RVA: 0x0004F8A8 File Offset: 0x0004DAA8
		// (remove) Token: 0x06001820 RID: 6176 RVA: 0x0004F8E4 File Offset: 0x0004DAE4
		public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x140002C3 RID: 707
		// (add) Token: 0x06001821 RID: 6177 RVA: 0x0004F920 File Offset: 0x0004DB20
		// (remove) Token: 0x06001822 RID: 6178 RVA: 0x0004F95C File Offset: 0x0004DB5C
		public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x140002C4 RID: 708
		// (add) Token: 0x06001823 RID: 6179 RVA: 0x0004F998 File Offset: 0x0004DB98
		// (remove) Token: 0x06001824 RID: 6180 RVA: 0x0004F9D4 File Offset: 0x0004DBD4
		public event EventHandler OnConnectionBarPullDown;

		// Token: 0x140002C5 RID: 709
		// (add) Token: 0x06001825 RID: 6181 RVA: 0x0004FA10 File Offset: 0x0004DC10
		// (remove) Token: 0x06001826 RID: 6182 RVA: 0x0004FA4C File Offset: 0x0004DC4C
		public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x140002C6 RID: 710
		// (add) Token: 0x06001827 RID: 6183 RVA: 0x0004FA88 File Offset: 0x0004DC88
		// (remove) Token: 0x06001828 RID: 6184 RVA: 0x0004FAC4 File Offset: 0x0004DCC4
		public event EventHandler OnDevicesButtonPressed;

		// Token: 0x140002C7 RID: 711
		// (add) Token: 0x06001829 RID: 6185 RVA: 0x0004FB00 File Offset: 0x0004DD00
		// (remove) Token: 0x0600182A RID: 6186 RVA: 0x0004FB3C File Offset: 0x0004DD3C
		public event EventHandler OnAutoReconnected;

		// Token: 0x140002C8 RID: 712
		// (add) Token: 0x0600182B RID: 6187 RVA: 0x0004FB78 File Offset: 0x0004DD78
		// (remove) Token: 0x0600182C RID: 6188 RVA: 0x0004FBB4 File Offset: 0x0004DDB4
		public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

		// Token: 0x0600182D RID: 6189 RVA: 0x0004FBF0 File Offset: 0x0004DDF0
		public virtual void Connect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Connect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Connect();
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x0004FC14 File Offset: 0x0004DE14
		public virtual void Disconnect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Disconnect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Disconnect();
		}

		// Token: 0x0600182F RID: 6191 RVA: 0x0004FC38 File Offset: 0x0004DE38
		public virtual void CreateVirtualChannels(string newVal)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("CreateVirtualChannels", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.CreateVirtualChannels(newVal);
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x0004FC60 File Offset: 0x0004DE60
		public virtual void SendOnVirtualChannel(string chanName, string chanData)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SendOnVirtualChannel", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SendOnVirtualChannel(chanName, chanData);
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x0004FC88 File Offset: 0x0004DE88
		public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SetVirtualChannelOptions(chanName, chanOptions);
		}

		// Token: 0x06001832 RID: 6194 RVA: 0x0004FCB0 File Offset: 0x0004DEB0
		public virtual int GetVirtualChannelOptions(string chanName)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetVirtualChannelOptions(chanName);
		}

		// Token: 0x06001833 RID: 6195 RVA: 0x0004FCE8 File Offset: 0x0004DEE8
		public virtual ControlCloseStatus RequestClose()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("RequestClose", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.RequestClose();
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x0004FD20 File Offset: 0x0004DF20
		public virtual string GetErrorDescription(uint disconnectReason, uint extendedDisconnectReason)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetErrorDescription", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetErrorDescription(disconnectReason, extendedDisconnectReason);
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x0004FD58 File Offset: 0x0004DF58
		public virtual string GetStatusText(uint statusCode)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetStatusText", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetStatusText(statusCode);
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x0004FD90 File Offset: 0x0004DF90
		public virtual void SendRemoteAction(RemoteSessionActionType actionType)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SendRemoteAction", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SendRemoteAction(actionType);
		}

		// Token: 0x06001837 RID: 6199 RVA: 0x0004FDB8 File Offset: 0x0004DFB8
		public virtual ControlReconnectStatus Reconnect(uint ulWidth, uint ulHeight)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Reconnect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.Reconnect(ulWidth, ulHeight);
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x0004FDF0 File Offset: 0x0004DFF0
		public virtual void SyncSessionDisplaySettings()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SyncSessionDisplaySettings", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SyncSessionDisplaySettings();
		}

		// Token: 0x06001839 RID: 6201 RVA: 0x0004FE14 File Offset: 0x0004E014
		public virtual void UpdateSessionDisplaySettings(uint ulDesktopWidth, uint ulDesktopHeight, uint ulPhysicalWidth, uint ulPhysicalHeight, uint ulOrientation, uint ulDesktopScaleFactor, uint ulDeviceScaleFactor)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("UpdateSessionDisplaySettings", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.UpdateSessionDisplaySettings(ulDesktopWidth, ulDesktopHeight, ulPhysicalWidth, ulPhysicalHeight, ulOrientation, ulDesktopScaleFactor, ulDeviceScaleFactor);
		}

		// Token: 0x0600183A RID: 6202 RVA: 0x0004FE54 File Offset: 0x0004E054
		public virtual void attachEvent(string eventName, object callback)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("attachEvent", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.attachEvent(eventName, callback);
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x0004FE7C File Offset: 0x0004E07C
		public virtual void detachEvent(string eventName, object callback)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("detachEvent", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.detachEvent(eventName, callback);
		}

		// Token: 0x0600183C RID: 6204 RVA: 0x0004FEA4 File Offset: 0x0004E0A4
		protected override void CreateSink()
		{
			try
			{
				this.eventMulticaster = new AxMsRdpClient10NotSafeForScriptingEventMulticaster(this);
				this.cookie = new AxHost.ConnectionPointCookie(this.ocx, this.eventMulticaster, typeof(IMsTscAxEvents));
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x0004FEFC File Offset: 0x0004E0FC
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

		// Token: 0x0600183E RID: 6206 RVA: 0x0004FF30 File Offset: 0x0004E130
		protected override void AttachInterfaces()
		{
			try
			{
				this.ocx = (IMsRdpClient10)base.GetOcx();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x0004FF6C File Offset: 0x0004E16C
		internal void RaiseOnOnConnecting(object sender, EventArgs e)
		{
			if (this.OnConnecting != null)
			{
				this.OnConnecting(sender, e);
			}
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x0004FF88 File Offset: 0x0004E188
		internal void RaiseOnOnConnected(object sender, EventArgs e)
		{
			if (this.OnConnected != null)
			{
				this.OnConnected(sender, e);
			}
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x0004FFA4 File Offset: 0x0004E1A4
		internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
		{
			if (this.OnLoginComplete != null)
			{
				this.OnLoginComplete(sender, e);
			}
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x0004FFC0 File Offset: 0x0004E1C0
		internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
		{
			if (this.OnDisconnected != null)
			{
				this.OnDisconnected(sender, e);
			}
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x0004FFDC File Offset: 0x0004E1DC
		internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnEnterFullScreenMode != null)
			{
				this.OnEnterFullScreenMode(sender, e);
			}
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x0004FFF8 File Offset: 0x0004E1F8
		internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnLeaveFullScreenMode != null)
			{
				this.OnLeaveFullScreenMode(sender, e);
			}
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x00050014 File Offset: 0x0004E214
		internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
		{
			if (this.OnChannelReceivedData != null)
			{
				this.OnChannelReceivedData(sender, e);
			}
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x00050030 File Offset: 0x0004E230
		internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestGoFullScreen != null)
			{
				this.OnRequestGoFullScreen(sender, e);
			}
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x0005004C File Offset: 0x0004E24C
		internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestLeaveFullScreen != null)
			{
				this.OnRequestLeaveFullScreen(sender, e);
			}
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x00050068 File Offset: 0x0004E268
		internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
		{
			if (this.OnFatalError != null)
			{
				this.OnFatalError(sender, e);
			}
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x00050084 File Offset: 0x0004E284
		internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
		{
			if (this.OnWarning != null)
			{
				this.OnWarning(sender, e);
			}
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x000500A0 File Offset: 0x0004E2A0
		internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
		{
			if (this.OnRemoteDesktopSizeChange != null)
			{
				this.OnRemoteDesktopSizeChange(sender, e);
			}
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x000500BC File Offset: 0x0004E2BC
		internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
		{
			if (this.OnIdleTimeoutNotification != null)
			{
				this.OnIdleTimeoutNotification(sender, e);
			}
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x000500D8 File Offset: 0x0004E2D8
		internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
		{
			if (this.OnRequestContainerMinimize != null)
			{
				this.OnRequestContainerMinimize(sender, e);
			}
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x000500F4 File Offset: 0x0004E2F4
		internal void RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
		{
			if (this.OnConfirmClose != null)
			{
				this.OnConfirmClose(sender, e);
			}
		}

		// Token: 0x0600184E RID: 6222 RVA: 0x00050110 File Offset: 0x0004E310
		internal void RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
		{
			if (this.OnReceivedTSPublicKey != null)
			{
				this.OnReceivedTSPublicKey(sender, e);
			}
		}

		// Token: 0x0600184F RID: 6223 RVA: 0x0005012C File Offset: 0x0004E32C
		internal void RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
		{
			if (this.OnAutoReconnecting != null)
			{
				this.OnAutoReconnecting(sender, e);
			}
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x00050148 File Offset: 0x0004E348
		internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDisplayed != null)
			{
				this.OnAuthenticationWarningDisplayed(sender, e);
			}
		}

		// Token: 0x06001851 RID: 6225 RVA: 0x00050164 File Offset: 0x0004E364
		internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDismissed != null)
			{
				this.OnAuthenticationWarningDismissed(sender, e);
			}
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x00050180 File Offset: 0x0004E380
		internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
		{
			if (this.OnRemoteProgramResult != null)
			{
				this.OnRemoteProgramResult(sender, e);
			}
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x0005019C File Offset: 0x0004E39C
		internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
		{
			if (this.OnRemoteProgramDisplayed != null)
			{
				this.OnRemoteProgramDisplayed(sender, e);
			}
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x000501B8 File Offset: 0x0004E3B8
		internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
		{
			if (this.OnRemoteWindowDisplayed != null)
			{
				this.OnRemoteWindowDisplayed(sender, e);
			}
		}

		// Token: 0x06001855 RID: 6229 RVA: 0x000501D4 File Offset: 0x0004E3D4
		internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
		{
			if (this.OnLogonError != null)
			{
				this.OnLogonError(sender, e);
			}
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x000501F0 File Offset: 0x0004E3F0
		internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
		{
			if (this.OnFocusReleased != null)
			{
				this.OnFocusReleased(sender, e);
			}
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x0005020C File Offset: 0x0004E40C
		internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
		{
			if (this.OnUserNameAcquired != null)
			{
				this.OnUserNameAcquired(sender, e);
			}
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x00050228 File Offset: 0x0004E428
		internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
		{
			if (this.OnMouseInputModeChanged != null)
			{
				this.OnMouseInputModeChanged(sender, e);
			}
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x00050244 File Offset: 0x0004E444
		internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
		{
			if (this.OnServiceMessageReceived != null)
			{
				this.OnServiceMessageReceived(sender, e);
			}
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x00050260 File Offset: 0x0004E460
		internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
		{
			if (this.OnConnectionBarPullDown != null)
			{
				this.OnConnectionBarPullDown(sender, e);
			}
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x0005027C File Offset: 0x0004E47C
		internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
		{
			if (this.OnNetworkStatusChanged != null)
			{
				this.OnNetworkStatusChanged(sender, e);
			}
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x00050298 File Offset: 0x0004E498
		internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
		{
			if (this.OnDevicesButtonPressed != null)
			{
				this.OnDevicesButtonPressed(sender, e);
			}
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x000502B4 File Offset: 0x0004E4B4
		internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
		{
			if (this.OnAutoReconnected != null)
			{
				this.OnAutoReconnected(sender, e);
			}
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x000502D0 File Offset: 0x0004E4D0
		internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
		{
			if (this.OnAutoReconnecting2 != null)
			{
				this.OnAutoReconnecting2(sender, e);
			}
		}

		// Token: 0x0400067F RID: 1663
		private IMsRdpClient10 ocx;

		// Token: 0x04000680 RID: 1664
		private AxMsRdpClient10NotSafeForScriptingEventMulticaster eventMulticaster;

		// Token: 0x04000681 RID: 1665
		private AxHost.ConnectionPointCookie cookie;
	}
}
