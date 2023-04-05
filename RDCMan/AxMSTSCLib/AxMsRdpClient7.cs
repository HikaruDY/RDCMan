using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MSTSCLib;

namespace AxMSTSCLib
{
	// Token: 0x02000136 RID: 310
	[DefaultEvent("OnConnecting")]
	[AxHost.ClsidAttribute("{a9d7038d-b5ed-472e-9c47-94bea90a5910}")]
	[DesignTimeVisible(true)]
	[ComVisible(true)]
	public class AxMsRdpClient7 : AxHost
	{
		// Token: 0x060013ED RID: 5101 RVA: 0x0004397C File Offset: 0x00041B7C
		public AxMsRdpClient7() : base("a9d7038d-b5ed-472e-9c47-94bea90a5910")
		{
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x060013EE RID: 5102 RVA: 0x0004398C File Offset: 0x00041B8C
		// (set) Token: 0x060013EF RID: 5103 RVA: 0x000439B0 File Offset: 0x00041BB0
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

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x060013F0 RID: 5104 RVA: 0x000439D8 File Offset: 0x00041BD8
		// (set) Token: 0x060013F1 RID: 5105 RVA: 0x000439FC File Offset: 0x00041BFC
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

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x060013F2 RID: 5106 RVA: 0x00043A24 File Offset: 0x00041C24
		// (set) Token: 0x060013F3 RID: 5107 RVA: 0x00043A48 File Offset: 0x00041C48
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

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x060013F4 RID: 5108 RVA: 0x00043A70 File Offset: 0x00041C70
		// (set) Token: 0x060013F5 RID: 5109 RVA: 0x00043A94 File Offset: 0x00041C94
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

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x060013F6 RID: 5110 RVA: 0x00043ABC File Offset: 0x00041CBC
		// (set) Token: 0x060013F7 RID: 5111 RVA: 0x00043AE0 File Offset: 0x00041CE0
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

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x060013F8 RID: 5112 RVA: 0x00043B08 File Offset: 0x00041D08
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

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x060013F9 RID: 5113 RVA: 0x00043B2C File Offset: 0x00041D2C
		// (set) Token: 0x060013FA RID: 5114 RVA: 0x00043B50 File Offset: 0x00041D50
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

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x060013FB RID: 5115 RVA: 0x00043B78 File Offset: 0x00041D78
		// (set) Token: 0x060013FC RID: 5116 RVA: 0x00043B9C File Offset: 0x00041D9C
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

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x060013FD RID: 5117 RVA: 0x00043BC4 File Offset: 0x00041DC4
		// (set) Token: 0x060013FE RID: 5118 RVA: 0x00043BE8 File Offset: 0x00041DE8
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

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x060013FF RID: 5119 RVA: 0x00043C10 File Offset: 0x00041E10
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

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06001400 RID: 5120 RVA: 0x00043C34 File Offset: 0x00041E34
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

		// Token: 0x17000394 RID: 916
		// (set) Token: 0x06001401 RID: 5121 RVA: 0x00043C58 File Offset: 0x00041E58
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

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06001402 RID: 5122 RVA: 0x00043C80 File Offset: 0x00041E80
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

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06001403 RID: 5123 RVA: 0x00043CA4 File Offset: 0x00041EA4
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

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06001404 RID: 5124 RVA: 0x00043CC8 File Offset: 0x00041EC8
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

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06001405 RID: 5125 RVA: 0x00043CEC File Offset: 0x00041EEC
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

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06001406 RID: 5126 RVA: 0x00043D10 File Offset: 0x00041F10
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

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06001407 RID: 5127 RVA: 0x00043D34 File Offset: 0x00041F34
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

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06001408 RID: 5128 RVA: 0x00043D58 File Offset: 0x00041F58
		// (set) Token: 0x06001409 RID: 5129 RVA: 0x00043D7C File Offset: 0x00041F7C
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

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x0600140A RID: 5130 RVA: 0x00043DA4 File Offset: 0x00041FA4
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

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x0600140B RID: 5131 RVA: 0x00043DC8 File Offset: 0x00041FC8
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

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x0600140C RID: 5132 RVA: 0x00043DEC File Offset: 0x00041FEC
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

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x0600140D RID: 5133 RVA: 0x00043E10 File Offset: 0x00042010
		// (set) Token: 0x0600140E RID: 5134 RVA: 0x00043E34 File Offset: 0x00042034
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

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x0600140F RID: 5135 RVA: 0x00043E5C File Offset: 0x0004205C
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

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06001410 RID: 5136 RVA: 0x00043E80 File Offset: 0x00042080
		// (set) Token: 0x06001411 RID: 5137 RVA: 0x00043EA4 File Offset: 0x000420A4
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

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06001412 RID: 5138 RVA: 0x00043ECC File Offset: 0x000420CC
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

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06001413 RID: 5139 RVA: 0x00043EF0 File Offset: 0x000420F0
		[DispId(400)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06001414 RID: 5140 RVA: 0x00043F14 File Offset: 0x00042114
		[DispId(500)]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06001415 RID: 5141 RVA: 0x00043F38 File Offset: 0x00042138
		[DispId(502)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
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

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06001416 RID: 5142 RVA: 0x00043F5C File Offset: 0x0004215C
		[DispId(504)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
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

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06001417 RID: 5143 RVA: 0x00043F80 File Offset: 0x00042180
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(505)]
		[Browsable(false)]
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

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06001418 RID: 5144 RVA: 0x00043FA4 File Offset: 0x000421A4
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(507)]
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

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06001419 RID: 5145 RVA: 0x00043FC8 File Offset: 0x000421C8
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

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x0600141A RID: 5146 RVA: 0x00043FEC File Offset: 0x000421EC
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

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x0600141B RID: 5147 RVA: 0x00044010 File Offset: 0x00042210
		[DispId(601)]
		[Browsable(false)]
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

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x0600141C RID: 5148 RVA: 0x00044034 File Offset: 0x00042234
		[DispId(603)]
		[Browsable(false)]
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

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x0600141D RID: 5149 RVA: 0x00044058 File Offset: 0x00042258
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
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

		// Token: 0x14000209 RID: 521
		// (add) Token: 0x0600141E RID: 5150 RVA: 0x0004407C File Offset: 0x0004227C
		// (remove) Token: 0x0600141F RID: 5151 RVA: 0x000440B8 File Offset: 0x000422B8
		public event EventHandler OnConnecting;

		// Token: 0x1400020A RID: 522
		// (add) Token: 0x06001420 RID: 5152 RVA: 0x000440F4 File Offset: 0x000422F4
		// (remove) Token: 0x06001421 RID: 5153 RVA: 0x00044130 File Offset: 0x00042330
		public event EventHandler OnConnected;

		// Token: 0x1400020B RID: 523
		// (add) Token: 0x06001422 RID: 5154 RVA: 0x0004416C File Offset: 0x0004236C
		// (remove) Token: 0x06001423 RID: 5155 RVA: 0x000441A8 File Offset: 0x000423A8
		public event EventHandler OnLoginComplete;

		// Token: 0x1400020C RID: 524
		// (add) Token: 0x06001424 RID: 5156 RVA: 0x000441E4 File Offset: 0x000423E4
		// (remove) Token: 0x06001425 RID: 5157 RVA: 0x00044220 File Offset: 0x00042420
		public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x1400020D RID: 525
		// (add) Token: 0x06001426 RID: 5158 RVA: 0x0004425C File Offset: 0x0004245C
		// (remove) Token: 0x06001427 RID: 5159 RVA: 0x00044298 File Offset: 0x00042498
		public event EventHandler OnEnterFullScreenMode;

		// Token: 0x1400020E RID: 526
		// (add) Token: 0x06001428 RID: 5160 RVA: 0x000442D4 File Offset: 0x000424D4
		// (remove) Token: 0x06001429 RID: 5161 RVA: 0x00044310 File Offset: 0x00042510
		public event EventHandler OnLeaveFullScreenMode;

		// Token: 0x1400020F RID: 527
		// (add) Token: 0x0600142A RID: 5162 RVA: 0x0004434C File Offset: 0x0004254C
		// (remove) Token: 0x0600142B RID: 5163 RVA: 0x00044388 File Offset: 0x00042588
		public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x14000210 RID: 528
		// (add) Token: 0x0600142C RID: 5164 RVA: 0x000443C4 File Offset: 0x000425C4
		// (remove) Token: 0x0600142D RID: 5165 RVA: 0x00044400 File Offset: 0x00042600
		public event EventHandler OnRequestGoFullScreen;

		// Token: 0x14000211 RID: 529
		// (add) Token: 0x0600142E RID: 5166 RVA: 0x0004443C File Offset: 0x0004263C
		// (remove) Token: 0x0600142F RID: 5167 RVA: 0x00044478 File Offset: 0x00042678
		public event EventHandler OnRequestLeaveFullScreen;

		// Token: 0x14000212 RID: 530
		// (add) Token: 0x06001430 RID: 5168 RVA: 0x000444B4 File Offset: 0x000426B4
		// (remove) Token: 0x06001431 RID: 5169 RVA: 0x000444F0 File Offset: 0x000426F0
		public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x14000213 RID: 531
		// (add) Token: 0x06001432 RID: 5170 RVA: 0x0004452C File Offset: 0x0004272C
		// (remove) Token: 0x06001433 RID: 5171 RVA: 0x00044568 File Offset: 0x00042768
		public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x14000214 RID: 532
		// (add) Token: 0x06001434 RID: 5172 RVA: 0x000445A4 File Offset: 0x000427A4
		// (remove) Token: 0x06001435 RID: 5173 RVA: 0x000445E0 File Offset: 0x000427E0
		public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x14000215 RID: 533
		// (add) Token: 0x06001436 RID: 5174 RVA: 0x0004461C File Offset: 0x0004281C
		// (remove) Token: 0x06001437 RID: 5175 RVA: 0x00044658 File Offset: 0x00042858
		public event EventHandler OnIdleTimeoutNotification;

		// Token: 0x14000216 RID: 534
		// (add) Token: 0x06001438 RID: 5176 RVA: 0x00044694 File Offset: 0x00042894
		// (remove) Token: 0x06001439 RID: 5177 RVA: 0x000446D0 File Offset: 0x000428D0
		public event EventHandler OnRequestContainerMinimize;

		// Token: 0x14000217 RID: 535
		// (add) Token: 0x0600143A RID: 5178 RVA: 0x0004470C File Offset: 0x0004290C
		// (remove) Token: 0x0600143B RID: 5179 RVA: 0x00044748 File Offset: 0x00042948
		public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x14000218 RID: 536
		// (add) Token: 0x0600143C RID: 5180 RVA: 0x00044784 File Offset: 0x00042984
		// (remove) Token: 0x0600143D RID: 5181 RVA: 0x000447C0 File Offset: 0x000429C0
		public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x14000219 RID: 537
		// (add) Token: 0x0600143E RID: 5182 RVA: 0x000447FC File Offset: 0x000429FC
		// (remove) Token: 0x0600143F RID: 5183 RVA: 0x00044838 File Offset: 0x00042A38
		public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x1400021A RID: 538
		// (add) Token: 0x06001440 RID: 5184 RVA: 0x00044874 File Offset: 0x00042A74
		// (remove) Token: 0x06001441 RID: 5185 RVA: 0x000448B0 File Offset: 0x00042AB0
		public event EventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x1400021B RID: 539
		// (add) Token: 0x06001442 RID: 5186 RVA: 0x000448EC File Offset: 0x00042AEC
		// (remove) Token: 0x06001443 RID: 5187 RVA: 0x00044928 File Offset: 0x00042B28
		public event EventHandler OnAuthenticationWarningDismissed;

		// Token: 0x1400021C RID: 540
		// (add) Token: 0x06001444 RID: 5188 RVA: 0x00044964 File Offset: 0x00042B64
		// (remove) Token: 0x06001445 RID: 5189 RVA: 0x000449A0 File Offset: 0x00042BA0
		public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x1400021D RID: 541
		// (add) Token: 0x06001446 RID: 5190 RVA: 0x000449DC File Offset: 0x00042BDC
		// (remove) Token: 0x06001447 RID: 5191 RVA: 0x00044A18 File Offset: 0x00042C18
		public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x1400021E RID: 542
		// (add) Token: 0x06001448 RID: 5192 RVA: 0x00044A54 File Offset: 0x00042C54
		// (remove) Token: 0x06001449 RID: 5193 RVA: 0x00044A90 File Offset: 0x00042C90
		public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x1400021F RID: 543
		// (add) Token: 0x0600144A RID: 5194 RVA: 0x00044ACC File Offset: 0x00042CCC
		// (remove) Token: 0x0600144B RID: 5195 RVA: 0x00044B08 File Offset: 0x00042D08
		public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x14000220 RID: 544
		// (add) Token: 0x0600144C RID: 5196 RVA: 0x00044B44 File Offset: 0x00042D44
		// (remove) Token: 0x0600144D RID: 5197 RVA: 0x00044B80 File Offset: 0x00042D80
		public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x14000221 RID: 545
		// (add) Token: 0x0600144E RID: 5198 RVA: 0x00044BBC File Offset: 0x00042DBC
		// (remove) Token: 0x0600144F RID: 5199 RVA: 0x00044BF8 File Offset: 0x00042DF8
		public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x14000222 RID: 546
		// (add) Token: 0x06001450 RID: 5200 RVA: 0x00044C34 File Offset: 0x00042E34
		// (remove) Token: 0x06001451 RID: 5201 RVA: 0x00044C70 File Offset: 0x00042E70
		public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x14000223 RID: 547
		// (add) Token: 0x06001452 RID: 5202 RVA: 0x00044CAC File Offset: 0x00042EAC
		// (remove) Token: 0x06001453 RID: 5203 RVA: 0x00044CE8 File Offset: 0x00042EE8
		public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x14000224 RID: 548
		// (add) Token: 0x06001454 RID: 5204 RVA: 0x00044D24 File Offset: 0x00042F24
		// (remove) Token: 0x06001455 RID: 5205 RVA: 0x00044D60 File Offset: 0x00042F60
		public event EventHandler OnConnectionBarPullDown;

		// Token: 0x14000225 RID: 549
		// (add) Token: 0x06001456 RID: 5206 RVA: 0x00044D9C File Offset: 0x00042F9C
		// (remove) Token: 0x06001457 RID: 5207 RVA: 0x00044DD8 File Offset: 0x00042FD8
		public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x14000226 RID: 550
		// (add) Token: 0x06001458 RID: 5208 RVA: 0x00044E14 File Offset: 0x00043014
		// (remove) Token: 0x06001459 RID: 5209 RVA: 0x00044E50 File Offset: 0x00043050
		public event EventHandler OnDevicesButtonPressed;

		// Token: 0x14000227 RID: 551
		// (add) Token: 0x0600145A RID: 5210 RVA: 0x00044E8C File Offset: 0x0004308C
		// (remove) Token: 0x0600145B RID: 5211 RVA: 0x00044EC8 File Offset: 0x000430C8
		public event EventHandler OnAutoReconnected;

		// Token: 0x14000228 RID: 552
		// (add) Token: 0x0600145C RID: 5212 RVA: 0x00044F04 File Offset: 0x00043104
		// (remove) Token: 0x0600145D RID: 5213 RVA: 0x00044F40 File Offset: 0x00043140
		public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

		// Token: 0x0600145E RID: 5214 RVA: 0x00044F7C File Offset: 0x0004317C
		public virtual void Connect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Connect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Connect();
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x00044FA0 File Offset: 0x000431A0
		public virtual void Disconnect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Disconnect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Disconnect();
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x00044FC4 File Offset: 0x000431C4
		public virtual void CreateVirtualChannels(string newVal)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("CreateVirtualChannels", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.CreateVirtualChannels(newVal);
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x00044FEC File Offset: 0x000431EC
		public virtual void SendOnVirtualChannel(string chanName, string chanData)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SendOnVirtualChannel", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SendOnVirtualChannel(chanName, chanData);
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x00045014 File Offset: 0x00043214
		public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SetVirtualChannelOptions(chanName, chanOptions);
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x0004503C File Offset: 0x0004323C
		public virtual int GetVirtualChannelOptions(string chanName)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetVirtualChannelOptions(chanName);
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x00045074 File Offset: 0x00043274
		public virtual ControlCloseStatus RequestClose()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("RequestClose", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.RequestClose();
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x000450AC File Offset: 0x000432AC
		public virtual string GetErrorDescription(uint disconnectReason, uint extendedDisconnectReason)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetErrorDescription", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetErrorDescription(disconnectReason, extendedDisconnectReason);
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x000450E4 File Offset: 0x000432E4
		public virtual string GetStatusText(uint statusCode)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetStatusText", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetStatusText(statusCode);
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x0004511C File Offset: 0x0004331C
		protected override void CreateSink()
		{
			try
			{
				this.eventMulticaster = new AxMsRdpClient7EventMulticaster(this);
				this.cookie = new AxHost.ConnectionPointCookie(this.ocx, this.eventMulticaster, typeof(IMsTscAxEvents));
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x00045174 File Offset: 0x00043374
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

		// Token: 0x06001469 RID: 5225 RVA: 0x000451A8 File Offset: 0x000433A8
		protected override void AttachInterfaces()
		{
			try
			{
				this.ocx = (IMsRdpClient7)base.GetOcx();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x000451E4 File Offset: 0x000433E4
		internal void RaiseOnOnConnecting(object sender, EventArgs e)
		{
			if (this.OnConnecting != null)
			{
				this.OnConnecting(sender, e);
			}
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x00045200 File Offset: 0x00043400
		internal void RaiseOnOnConnected(object sender, EventArgs e)
		{
			if (this.OnConnected != null)
			{
				this.OnConnected(sender, e);
			}
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x0004521C File Offset: 0x0004341C
		internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
		{
			if (this.OnLoginComplete != null)
			{
				this.OnLoginComplete(sender, e);
			}
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x00045238 File Offset: 0x00043438
		internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
		{
			if (this.OnDisconnected != null)
			{
				this.OnDisconnected(sender, e);
			}
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x00045254 File Offset: 0x00043454
		internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnEnterFullScreenMode != null)
			{
				this.OnEnterFullScreenMode(sender, e);
			}
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x00045270 File Offset: 0x00043470
		internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnLeaveFullScreenMode != null)
			{
				this.OnLeaveFullScreenMode(sender, e);
			}
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x0004528C File Offset: 0x0004348C
		internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
		{
			if (this.OnChannelReceivedData != null)
			{
				this.OnChannelReceivedData(sender, e);
			}
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x000452A8 File Offset: 0x000434A8
		internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestGoFullScreen != null)
			{
				this.OnRequestGoFullScreen(sender, e);
			}
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x000452C4 File Offset: 0x000434C4
		internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestLeaveFullScreen != null)
			{
				this.OnRequestLeaveFullScreen(sender, e);
			}
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x000452E0 File Offset: 0x000434E0
		internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
		{
			if (this.OnFatalError != null)
			{
				this.OnFatalError(sender, e);
			}
		}

		// Token: 0x06001474 RID: 5236 RVA: 0x000452FC File Offset: 0x000434FC
		internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
		{
			if (this.OnWarning != null)
			{
				this.OnWarning(sender, e);
			}
		}

		// Token: 0x06001475 RID: 5237 RVA: 0x00045318 File Offset: 0x00043518
		internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
		{
			if (this.OnRemoteDesktopSizeChange != null)
			{
				this.OnRemoteDesktopSizeChange(sender, e);
			}
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x00045334 File Offset: 0x00043534
		internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
		{
			if (this.OnIdleTimeoutNotification != null)
			{
				this.OnIdleTimeoutNotification(sender, e);
			}
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x00045350 File Offset: 0x00043550
		internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
		{
			if (this.OnRequestContainerMinimize != null)
			{
				this.OnRequestContainerMinimize(sender, e);
			}
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x0004536C File Offset: 0x0004356C
		internal void RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
		{
			if (this.OnConfirmClose != null)
			{
				this.OnConfirmClose(sender, e);
			}
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x00045388 File Offset: 0x00043588
		internal void RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
		{
			if (this.OnReceivedTSPublicKey != null)
			{
				this.OnReceivedTSPublicKey(sender, e);
			}
		}

		// Token: 0x0600147A RID: 5242 RVA: 0x000453A4 File Offset: 0x000435A4
		internal void RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
		{
			if (this.OnAutoReconnecting != null)
			{
				this.OnAutoReconnecting(sender, e);
			}
		}

		// Token: 0x0600147B RID: 5243 RVA: 0x000453C0 File Offset: 0x000435C0
		internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDisplayed != null)
			{
				this.OnAuthenticationWarningDisplayed(sender, e);
			}
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x000453DC File Offset: 0x000435DC
		internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDismissed != null)
			{
				this.OnAuthenticationWarningDismissed(sender, e);
			}
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x000453F8 File Offset: 0x000435F8
		internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
		{
			if (this.OnRemoteProgramResult != null)
			{
				this.OnRemoteProgramResult(sender, e);
			}
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x00045414 File Offset: 0x00043614
		internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
		{
			if (this.OnRemoteProgramDisplayed != null)
			{
				this.OnRemoteProgramDisplayed(sender, e);
			}
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x00045430 File Offset: 0x00043630
		internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
		{
			if (this.OnRemoteWindowDisplayed != null)
			{
				this.OnRemoteWindowDisplayed(sender, e);
			}
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x0004544C File Offset: 0x0004364C
		internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
		{
			if (this.OnLogonError != null)
			{
				this.OnLogonError(sender, e);
			}
		}

		// Token: 0x06001481 RID: 5249 RVA: 0x00045468 File Offset: 0x00043668
		internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
		{
			if (this.OnFocusReleased != null)
			{
				this.OnFocusReleased(sender, e);
			}
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x00045484 File Offset: 0x00043684
		internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
		{
			if (this.OnUserNameAcquired != null)
			{
				this.OnUserNameAcquired(sender, e);
			}
		}

		// Token: 0x06001483 RID: 5251 RVA: 0x000454A0 File Offset: 0x000436A0
		internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
		{
			if (this.OnMouseInputModeChanged != null)
			{
				this.OnMouseInputModeChanged(sender, e);
			}
		}

		// Token: 0x06001484 RID: 5252 RVA: 0x000454BC File Offset: 0x000436BC
		internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
		{
			if (this.OnServiceMessageReceived != null)
			{
				this.OnServiceMessageReceived(sender, e);
			}
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x000454D8 File Offset: 0x000436D8
		internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
		{
			if (this.OnConnectionBarPullDown != null)
			{
				this.OnConnectionBarPullDown(sender, e);
			}
		}

		// Token: 0x06001486 RID: 5254 RVA: 0x000454F4 File Offset: 0x000436F4
		internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
		{
			if (this.OnNetworkStatusChanged != null)
			{
				this.OnNetworkStatusChanged(sender, e);
			}
		}

		// Token: 0x06001487 RID: 5255 RVA: 0x00045510 File Offset: 0x00043710
		internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
		{
			if (this.OnDevicesButtonPressed != null)
			{
				this.OnDevicesButtonPressed(sender, e);
			}
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x0004552C File Offset: 0x0004372C
		internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
		{
			if (this.OnAutoReconnected != null)
			{
				this.OnAutoReconnected(sender, e);
			}
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x00045548 File Offset: 0x00043748
		internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
		{
			if (this.OnAutoReconnecting2 != null)
			{
				this.OnAutoReconnecting2(sender, e);
			}
		}

		// Token: 0x040005CB RID: 1483
		private IMsRdpClient7 ocx;

		// Token: 0x040005CC RID: 1484
		private AxMsRdpClient7EventMulticaster eventMulticaster;

		// Token: 0x040005CD RID: 1485
		private AxHost.ConnectionPointCookie cookie;
	}
}
