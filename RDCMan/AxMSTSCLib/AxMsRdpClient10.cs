using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MSTSCLib;

namespace AxMSTSCLib
{
	// Token: 0x02000142 RID: 322
	[DefaultEvent("OnConnecting")]
	[AxHost.ClsidAttribute("{c0efa91a-eeb7-41c7-97fa-f0ed645efb24}")]
	[DesignTimeVisible(true)]
	[ComVisible(true)]
	public class AxMsRdpClient10 : AxHost
	{
		// Token: 0x06001880 RID: 6272 RVA: 0x000508AC File Offset: 0x0004EAAC
		public AxMsRdpClient10() : base("c0efa91a-eeb7-41c7-97fa-f0ed645efb24")
		{
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06001881 RID: 6273 RVA: 0x000508BC File Offset: 0x0004EABC
		// (set) Token: 0x06001882 RID: 6274 RVA: 0x000508E0 File Offset: 0x0004EAE0
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

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06001883 RID: 6275 RVA: 0x00050908 File Offset: 0x0004EB08
		// (set) Token: 0x06001884 RID: 6276 RVA: 0x0005092C File Offset: 0x0004EB2C
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

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06001885 RID: 6277 RVA: 0x00050954 File Offset: 0x0004EB54
		// (set) Token: 0x06001886 RID: 6278 RVA: 0x00050978 File Offset: 0x0004EB78
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

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06001887 RID: 6279 RVA: 0x000509A0 File Offset: 0x0004EBA0
		// (set) Token: 0x06001888 RID: 6280 RVA: 0x000509C4 File Offset: 0x0004EBC4
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

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06001889 RID: 6281 RVA: 0x000509EC File Offset: 0x0004EBEC
		// (set) Token: 0x0600188A RID: 6282 RVA: 0x00050A10 File Offset: 0x0004EC10
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

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x0600188B RID: 6283 RVA: 0x00050A38 File Offset: 0x0004EC38
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

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x0600188C RID: 6284 RVA: 0x00050A5C File Offset: 0x0004EC5C
		// (set) Token: 0x0600188D RID: 6285 RVA: 0x00050A80 File Offset: 0x0004EC80
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

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x0600188E RID: 6286 RVA: 0x00050AA8 File Offset: 0x0004ECA8
		// (set) Token: 0x0600188F RID: 6287 RVA: 0x00050ACC File Offset: 0x0004ECCC
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

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06001890 RID: 6288 RVA: 0x00050AF4 File Offset: 0x0004ECF4
		// (set) Token: 0x06001891 RID: 6289 RVA: 0x00050B18 File Offset: 0x0004ED18
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

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06001892 RID: 6290 RVA: 0x00050B40 File Offset: 0x0004ED40
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

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06001893 RID: 6291 RVA: 0x00050B64 File Offset: 0x0004ED64
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

		// Token: 0x1700047B RID: 1147
		// (set) Token: 0x06001894 RID: 6292 RVA: 0x00050B88 File Offset: 0x0004ED88
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

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06001895 RID: 6293 RVA: 0x00050BB0 File Offset: 0x0004EDB0
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

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06001896 RID: 6294 RVA: 0x00050BD4 File Offset: 0x0004EDD4
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

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06001897 RID: 6295 RVA: 0x00050BF8 File Offset: 0x0004EDF8
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

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06001898 RID: 6296 RVA: 0x00050C1C File Offset: 0x0004EE1C
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

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06001899 RID: 6297 RVA: 0x00050C40 File Offset: 0x0004EE40
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(98)]
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

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x0600189A RID: 6298 RVA: 0x00050C64 File Offset: 0x0004EE64
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x0600189B RID: 6299 RVA: 0x00050C88 File Offset: 0x0004EE88
		// (set) Token: 0x0600189C RID: 6300 RVA: 0x00050CAC File Offset: 0x0004EEAC
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

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x0600189D RID: 6301 RVA: 0x00050CD4 File Offset: 0x0004EED4
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

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x0600189E RID: 6302 RVA: 0x00050CF8 File Offset: 0x0004EEF8
		[Browsable(false)]
		[DispId(102)]
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

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x0600189F RID: 6303 RVA: 0x00050D1C File Offset: 0x0004EF1C
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

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x060018A0 RID: 6304 RVA: 0x00050D40 File Offset: 0x0004EF40
		// (set) Token: 0x060018A1 RID: 6305 RVA: 0x00050D64 File Offset: 0x0004EF64
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

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x060018A2 RID: 6306 RVA: 0x00050D8C File Offset: 0x0004EF8C
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

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x060018A3 RID: 6307 RVA: 0x00050DB0 File Offset: 0x0004EFB0
		// (set) Token: 0x060018A4 RID: 6308 RVA: 0x00050DD4 File Offset: 0x0004EFD4
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

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x060018A5 RID: 6309 RVA: 0x00050DFC File Offset: 0x0004EFFC
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

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x060018A6 RID: 6310 RVA: 0x00050E20 File Offset: 0x0004F020
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

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x060018A7 RID: 6311 RVA: 0x00050E44 File Offset: 0x0004F044
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(500)]
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

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x060018A8 RID: 6312 RVA: 0x00050E68 File Offset: 0x0004F068
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

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x060018A9 RID: 6313 RVA: 0x00050E8C File Offset: 0x0004F08C
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

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x060018AA RID: 6314 RVA: 0x00050EB0 File Offset: 0x0004F0B0
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

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x060018AB RID: 6315 RVA: 0x00050ED4 File Offset: 0x0004F0D4
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

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x060018AC RID: 6316 RVA: 0x00050EF8 File Offset: 0x0004F0F8
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

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x060018AD RID: 6317 RVA: 0x00050F1C File Offset: 0x0004F11C
		[DispId(600)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x060018AE RID: 6318 RVA: 0x00050F40 File Offset: 0x0004F140
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

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x060018AF RID: 6319 RVA: 0x00050F64 File Offset: 0x0004F164
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

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x060018B0 RID: 6320 RVA: 0x00050F88 File Offset: 0x0004F188
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

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x060018B1 RID: 6321 RVA: 0x00050FAC File Offset: 0x0004F1AC
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

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x060018B2 RID: 6322 RVA: 0x00050FD0 File Offset: 0x0004F1D0
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

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x060018B3 RID: 6323 RVA: 0x00050FF4 File Offset: 0x0004F1F4
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(900)]
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

		// Token: 0x140002C9 RID: 713
		// (add) Token: 0x060018B4 RID: 6324 RVA: 0x00051018 File Offset: 0x0004F218
		// (remove) Token: 0x060018B5 RID: 6325 RVA: 0x00051054 File Offset: 0x0004F254
		public event EventHandler OnConnecting;

		// Token: 0x140002CA RID: 714
		// (add) Token: 0x060018B6 RID: 6326 RVA: 0x00051090 File Offset: 0x0004F290
		// (remove) Token: 0x060018B7 RID: 6327 RVA: 0x000510CC File Offset: 0x0004F2CC
		public event EventHandler OnConnected;

		// Token: 0x140002CB RID: 715
		// (add) Token: 0x060018B8 RID: 6328 RVA: 0x00051108 File Offset: 0x0004F308
		// (remove) Token: 0x060018B9 RID: 6329 RVA: 0x00051144 File Offset: 0x0004F344
		public event EventHandler OnLoginComplete;

		// Token: 0x140002CC RID: 716
		// (add) Token: 0x060018BA RID: 6330 RVA: 0x00051180 File Offset: 0x0004F380
		// (remove) Token: 0x060018BB RID: 6331 RVA: 0x000511BC File Offset: 0x0004F3BC
		public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x140002CD RID: 717
		// (add) Token: 0x060018BC RID: 6332 RVA: 0x000511F8 File Offset: 0x0004F3F8
		// (remove) Token: 0x060018BD RID: 6333 RVA: 0x00051234 File Offset: 0x0004F434
		public event EventHandler OnEnterFullScreenMode;

		// Token: 0x140002CE RID: 718
		// (add) Token: 0x060018BE RID: 6334 RVA: 0x00051270 File Offset: 0x0004F470
		// (remove) Token: 0x060018BF RID: 6335 RVA: 0x000512AC File Offset: 0x0004F4AC
		public event EventHandler OnLeaveFullScreenMode;

		// Token: 0x140002CF RID: 719
		// (add) Token: 0x060018C0 RID: 6336 RVA: 0x000512E8 File Offset: 0x0004F4E8
		// (remove) Token: 0x060018C1 RID: 6337 RVA: 0x00051324 File Offset: 0x0004F524
		public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x140002D0 RID: 720
		// (add) Token: 0x060018C2 RID: 6338 RVA: 0x00051360 File Offset: 0x0004F560
		// (remove) Token: 0x060018C3 RID: 6339 RVA: 0x0005139C File Offset: 0x0004F59C
		public event EventHandler OnRequestGoFullScreen;

		// Token: 0x140002D1 RID: 721
		// (add) Token: 0x060018C4 RID: 6340 RVA: 0x000513D8 File Offset: 0x0004F5D8
		// (remove) Token: 0x060018C5 RID: 6341 RVA: 0x00051414 File Offset: 0x0004F614
		public event EventHandler OnRequestLeaveFullScreen;

		// Token: 0x140002D2 RID: 722
		// (add) Token: 0x060018C6 RID: 6342 RVA: 0x00051450 File Offset: 0x0004F650
		// (remove) Token: 0x060018C7 RID: 6343 RVA: 0x0005148C File Offset: 0x0004F68C
		public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x140002D3 RID: 723
		// (add) Token: 0x060018C8 RID: 6344 RVA: 0x000514C8 File Offset: 0x0004F6C8
		// (remove) Token: 0x060018C9 RID: 6345 RVA: 0x00051504 File Offset: 0x0004F704
		public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x140002D4 RID: 724
		// (add) Token: 0x060018CA RID: 6346 RVA: 0x00051540 File Offset: 0x0004F740
		// (remove) Token: 0x060018CB RID: 6347 RVA: 0x0005157C File Offset: 0x0004F77C
		public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x140002D5 RID: 725
		// (add) Token: 0x060018CC RID: 6348 RVA: 0x000515B8 File Offset: 0x0004F7B8
		// (remove) Token: 0x060018CD RID: 6349 RVA: 0x000515F4 File Offset: 0x0004F7F4
		public event EventHandler OnIdleTimeoutNotification;

		// Token: 0x140002D6 RID: 726
		// (add) Token: 0x060018CE RID: 6350 RVA: 0x00051630 File Offset: 0x0004F830
		// (remove) Token: 0x060018CF RID: 6351 RVA: 0x0005166C File Offset: 0x0004F86C
		public event EventHandler OnRequestContainerMinimize;

		// Token: 0x140002D7 RID: 727
		// (add) Token: 0x060018D0 RID: 6352 RVA: 0x000516A8 File Offset: 0x0004F8A8
		// (remove) Token: 0x060018D1 RID: 6353 RVA: 0x000516E4 File Offset: 0x0004F8E4
		public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x140002D8 RID: 728
		// (add) Token: 0x060018D2 RID: 6354 RVA: 0x00051720 File Offset: 0x0004F920
		// (remove) Token: 0x060018D3 RID: 6355 RVA: 0x0005175C File Offset: 0x0004F95C
		public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x140002D9 RID: 729
		// (add) Token: 0x060018D4 RID: 6356 RVA: 0x00051798 File Offset: 0x0004F998
		// (remove) Token: 0x060018D5 RID: 6357 RVA: 0x000517D4 File Offset: 0x0004F9D4
		public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x140002DA RID: 730
		// (add) Token: 0x060018D6 RID: 6358 RVA: 0x00051810 File Offset: 0x0004FA10
		// (remove) Token: 0x060018D7 RID: 6359 RVA: 0x0005184C File Offset: 0x0004FA4C
		public event EventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x140002DB RID: 731
		// (add) Token: 0x060018D8 RID: 6360 RVA: 0x00051888 File Offset: 0x0004FA88
		// (remove) Token: 0x060018D9 RID: 6361 RVA: 0x000518C4 File Offset: 0x0004FAC4
		public event EventHandler OnAuthenticationWarningDismissed;

		// Token: 0x140002DC RID: 732
		// (add) Token: 0x060018DA RID: 6362 RVA: 0x00051900 File Offset: 0x0004FB00
		// (remove) Token: 0x060018DB RID: 6363 RVA: 0x0005193C File Offset: 0x0004FB3C
		public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x140002DD RID: 733
		// (add) Token: 0x060018DC RID: 6364 RVA: 0x00051978 File Offset: 0x0004FB78
		// (remove) Token: 0x060018DD RID: 6365 RVA: 0x000519B4 File Offset: 0x0004FBB4
		public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x140002DE RID: 734
		// (add) Token: 0x060018DE RID: 6366 RVA: 0x000519F0 File Offset: 0x0004FBF0
		// (remove) Token: 0x060018DF RID: 6367 RVA: 0x00051A2C File Offset: 0x0004FC2C
		public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x140002DF RID: 735
		// (add) Token: 0x060018E0 RID: 6368 RVA: 0x00051A68 File Offset: 0x0004FC68
		// (remove) Token: 0x060018E1 RID: 6369 RVA: 0x00051AA4 File Offset: 0x0004FCA4
		public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x140002E0 RID: 736
		// (add) Token: 0x060018E2 RID: 6370 RVA: 0x00051AE0 File Offset: 0x0004FCE0
		// (remove) Token: 0x060018E3 RID: 6371 RVA: 0x00051B1C File Offset: 0x0004FD1C
		public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x140002E1 RID: 737
		// (add) Token: 0x060018E4 RID: 6372 RVA: 0x00051B58 File Offset: 0x0004FD58
		// (remove) Token: 0x060018E5 RID: 6373 RVA: 0x00051B94 File Offset: 0x0004FD94
		public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x140002E2 RID: 738
		// (add) Token: 0x060018E6 RID: 6374 RVA: 0x00051BD0 File Offset: 0x0004FDD0
		// (remove) Token: 0x060018E7 RID: 6375 RVA: 0x00051C0C File Offset: 0x0004FE0C
		public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x140002E3 RID: 739
		// (add) Token: 0x060018E8 RID: 6376 RVA: 0x00051C48 File Offset: 0x0004FE48
		// (remove) Token: 0x060018E9 RID: 6377 RVA: 0x00051C84 File Offset: 0x0004FE84
		public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x140002E4 RID: 740
		// (add) Token: 0x060018EA RID: 6378 RVA: 0x00051CC0 File Offset: 0x0004FEC0
		// (remove) Token: 0x060018EB RID: 6379 RVA: 0x00051CFC File Offset: 0x0004FEFC
		public event EventHandler OnConnectionBarPullDown;

		// Token: 0x140002E5 RID: 741
		// (add) Token: 0x060018EC RID: 6380 RVA: 0x00051D38 File Offset: 0x0004FF38
		// (remove) Token: 0x060018ED RID: 6381 RVA: 0x00051D74 File Offset: 0x0004FF74
		public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x140002E6 RID: 742
		// (add) Token: 0x060018EE RID: 6382 RVA: 0x00051DB0 File Offset: 0x0004FFB0
		// (remove) Token: 0x060018EF RID: 6383 RVA: 0x00051DEC File Offset: 0x0004FFEC
		public event EventHandler OnDevicesButtonPressed;

		// Token: 0x140002E7 RID: 743
		// (add) Token: 0x060018F0 RID: 6384 RVA: 0x00051E28 File Offset: 0x00050028
		// (remove) Token: 0x060018F1 RID: 6385 RVA: 0x00051E64 File Offset: 0x00050064
		public event EventHandler OnAutoReconnected;

		// Token: 0x140002E8 RID: 744
		// (add) Token: 0x060018F2 RID: 6386 RVA: 0x00051EA0 File Offset: 0x000500A0
		// (remove) Token: 0x060018F3 RID: 6387 RVA: 0x00051EDC File Offset: 0x000500DC
		public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

		// Token: 0x060018F4 RID: 6388 RVA: 0x00051F18 File Offset: 0x00050118
		public virtual void Connect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Connect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Connect();
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x00051F3C File Offset: 0x0005013C
		public virtual void Disconnect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Disconnect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Disconnect();
		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x00051F60 File Offset: 0x00050160
		public virtual void CreateVirtualChannels(string newVal)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("CreateVirtualChannels", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.CreateVirtualChannels(newVal);
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x00051F88 File Offset: 0x00050188
		public virtual void SendOnVirtualChannel(string chanName, string chanData)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SendOnVirtualChannel", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SendOnVirtualChannel(chanName, chanData);
		}

		// Token: 0x060018F8 RID: 6392 RVA: 0x00051FB0 File Offset: 0x000501B0
		public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SetVirtualChannelOptions(chanName, chanOptions);
		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x00051FD8 File Offset: 0x000501D8
		public virtual int GetVirtualChannelOptions(string chanName)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetVirtualChannelOptions(chanName);
		}

		// Token: 0x060018FA RID: 6394 RVA: 0x00052010 File Offset: 0x00050210
		public virtual ControlCloseStatus RequestClose()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("RequestClose", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.RequestClose();
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x00052048 File Offset: 0x00050248
		public virtual string GetErrorDescription(uint disconnectReason, uint extendedDisconnectReason)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetErrorDescription", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetErrorDescription(disconnectReason, extendedDisconnectReason);
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x00052080 File Offset: 0x00050280
		public virtual string GetStatusText(uint statusCode)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetStatusText", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetStatusText(statusCode);
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x000520B8 File Offset: 0x000502B8
		public virtual void SendRemoteAction(RemoteSessionActionType actionType)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SendRemoteAction", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SendRemoteAction(actionType);
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x000520E0 File Offset: 0x000502E0
		public virtual ControlReconnectStatus Reconnect(uint ulWidth, uint ulHeight)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Reconnect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.Reconnect(ulWidth, ulHeight);
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x00052118 File Offset: 0x00050318
		public virtual void SyncSessionDisplaySettings()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SyncSessionDisplaySettings", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SyncSessionDisplaySettings();
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x0005213C File Offset: 0x0005033C
		public virtual void UpdateSessionDisplaySettings(uint ulDesktopWidth, uint ulDesktopHeight, uint ulPhysicalWidth, uint ulPhysicalHeight, uint ulOrientation, uint ulDesktopScaleFactor, uint ulDeviceScaleFactor)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("UpdateSessionDisplaySettings", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.UpdateSessionDisplaySettings(ulDesktopWidth, ulDesktopHeight, ulPhysicalWidth, ulPhysicalHeight, ulOrientation, ulDesktopScaleFactor, ulDeviceScaleFactor);
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x0005217C File Offset: 0x0005037C
		public virtual void attachEvent(string eventName, object callback)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("attachEvent", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.attachEvent(eventName, callback);
		}

		// Token: 0x06001902 RID: 6402 RVA: 0x000521A4 File Offset: 0x000503A4
		public virtual void detachEvent(string eventName, object callback)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("detachEvent", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.detachEvent(eventName, callback);
		}

		// Token: 0x06001903 RID: 6403 RVA: 0x000521CC File Offset: 0x000503CC
		protected override void CreateSink()
		{
			try
			{
				this.eventMulticaster = new AxMsRdpClient10EventMulticaster(this);
				this.cookie = new AxHost.ConnectionPointCookie(this.ocx, this.eventMulticaster, typeof(IMsTscAxEvents));
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06001904 RID: 6404 RVA: 0x00052224 File Offset: 0x00050424
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

		// Token: 0x06001905 RID: 6405 RVA: 0x00052258 File Offset: 0x00050458
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

		// Token: 0x06001906 RID: 6406 RVA: 0x00052294 File Offset: 0x00050494
		internal void RaiseOnOnConnecting(object sender, EventArgs e)
		{
			if (this.OnConnecting != null)
			{
				this.OnConnecting(sender, e);
			}
		}

		// Token: 0x06001907 RID: 6407 RVA: 0x000522B0 File Offset: 0x000504B0
		internal void RaiseOnOnConnected(object sender, EventArgs e)
		{
			if (this.OnConnected != null)
			{
				this.OnConnected(sender, e);
			}
		}

		// Token: 0x06001908 RID: 6408 RVA: 0x000522CC File Offset: 0x000504CC
		internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
		{
			if (this.OnLoginComplete != null)
			{
				this.OnLoginComplete(sender, e);
			}
		}

		// Token: 0x06001909 RID: 6409 RVA: 0x000522E8 File Offset: 0x000504E8
		internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
		{
			if (this.OnDisconnected != null)
			{
				this.OnDisconnected(sender, e);
			}
		}

		// Token: 0x0600190A RID: 6410 RVA: 0x00052304 File Offset: 0x00050504
		internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnEnterFullScreenMode != null)
			{
				this.OnEnterFullScreenMode(sender, e);
			}
		}

		// Token: 0x0600190B RID: 6411 RVA: 0x00052320 File Offset: 0x00050520
		internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnLeaveFullScreenMode != null)
			{
				this.OnLeaveFullScreenMode(sender, e);
			}
		}

		// Token: 0x0600190C RID: 6412 RVA: 0x0005233C File Offset: 0x0005053C
		internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
		{
			if (this.OnChannelReceivedData != null)
			{
				this.OnChannelReceivedData(sender, e);
			}
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x00052358 File Offset: 0x00050558
		internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestGoFullScreen != null)
			{
				this.OnRequestGoFullScreen(sender, e);
			}
		}

		// Token: 0x0600190E RID: 6414 RVA: 0x00052374 File Offset: 0x00050574
		internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestLeaveFullScreen != null)
			{
				this.OnRequestLeaveFullScreen(sender, e);
			}
		}

		// Token: 0x0600190F RID: 6415 RVA: 0x00052390 File Offset: 0x00050590
		internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
		{
			if (this.OnFatalError != null)
			{
				this.OnFatalError(sender, e);
			}
		}

		// Token: 0x06001910 RID: 6416 RVA: 0x000523AC File Offset: 0x000505AC
		internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
		{
			if (this.OnWarning != null)
			{
				this.OnWarning(sender, e);
			}
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x000523C8 File Offset: 0x000505C8
		internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
		{
			if (this.OnRemoteDesktopSizeChange != null)
			{
				this.OnRemoteDesktopSizeChange(sender, e);
			}
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x000523E4 File Offset: 0x000505E4
		internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
		{
			if (this.OnIdleTimeoutNotification != null)
			{
				this.OnIdleTimeoutNotification(sender, e);
			}
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x00052400 File Offset: 0x00050600
		internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
		{
			if (this.OnRequestContainerMinimize != null)
			{
				this.OnRequestContainerMinimize(sender, e);
			}
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x0005241C File Offset: 0x0005061C
		internal void RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
		{
			if (this.OnConfirmClose != null)
			{
				this.OnConfirmClose(sender, e);
			}
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x00052438 File Offset: 0x00050638
		internal void RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
		{
			if (this.OnReceivedTSPublicKey != null)
			{
				this.OnReceivedTSPublicKey(sender, e);
			}
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x00052454 File Offset: 0x00050654
		internal void RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
		{
			if (this.OnAutoReconnecting != null)
			{
				this.OnAutoReconnecting(sender, e);
			}
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x00052470 File Offset: 0x00050670
		internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDisplayed != null)
			{
				this.OnAuthenticationWarningDisplayed(sender, e);
			}
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x0005248C File Offset: 0x0005068C
		internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDismissed != null)
			{
				this.OnAuthenticationWarningDismissed(sender, e);
			}
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x000524A8 File Offset: 0x000506A8
		internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
		{
			if (this.OnRemoteProgramResult != null)
			{
				this.OnRemoteProgramResult(sender, e);
			}
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x000524C4 File Offset: 0x000506C4
		internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
		{
			if (this.OnRemoteProgramDisplayed != null)
			{
				this.OnRemoteProgramDisplayed(sender, e);
			}
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x000524E0 File Offset: 0x000506E0
		internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
		{
			if (this.OnRemoteWindowDisplayed != null)
			{
				this.OnRemoteWindowDisplayed(sender, e);
			}
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x000524FC File Offset: 0x000506FC
		internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
		{
			if (this.OnLogonError != null)
			{
				this.OnLogonError(sender, e);
			}
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x00052518 File Offset: 0x00050718
		internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
		{
			if (this.OnFocusReleased != null)
			{
				this.OnFocusReleased(sender, e);
			}
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x00052534 File Offset: 0x00050734
		internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
		{
			if (this.OnUserNameAcquired != null)
			{
				this.OnUserNameAcquired(sender, e);
			}
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x00052550 File Offset: 0x00050750
		internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
		{
			if (this.OnMouseInputModeChanged != null)
			{
				this.OnMouseInputModeChanged(sender, e);
			}
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x0005256C File Offset: 0x0005076C
		internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
		{
			if (this.OnServiceMessageReceived != null)
			{
				this.OnServiceMessageReceived(sender, e);
			}
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x00052588 File Offset: 0x00050788
		internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
		{
			if (this.OnConnectionBarPullDown != null)
			{
				this.OnConnectionBarPullDown(sender, e);
			}
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x000525A4 File Offset: 0x000507A4
		internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
		{
			if (this.OnNetworkStatusChanged != null)
			{
				this.OnNetworkStatusChanged(sender, e);
			}
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x000525C0 File Offset: 0x000507C0
		internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
		{
			if (this.OnDevicesButtonPressed != null)
			{
				this.OnDevicesButtonPressed(sender, e);
			}
		}

		// Token: 0x06001924 RID: 6436 RVA: 0x000525DC File Offset: 0x000507DC
		internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
		{
			if (this.OnAutoReconnected != null)
			{
				this.OnAutoReconnected(sender, e);
			}
		}

		// Token: 0x06001925 RID: 6437 RVA: 0x000525F8 File Offset: 0x000507F8
		internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
		{
			if (this.OnAutoReconnecting2 != null)
			{
				this.OnAutoReconnecting2(sender, e);
			}
		}

		// Token: 0x040006A3 RID: 1699
		private IMsRdpClient10 ocx;

		// Token: 0x040006A4 RID: 1700
		private AxMsRdpClient10EventMulticaster eventMulticaster;

		// Token: 0x040006A5 RID: 1701
		private AxHost.ConnectionPointCookie cookie;
	}
}
