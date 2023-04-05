using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MSTSCLib;

namespace AxMSTSCLib
{
	// Token: 0x02000144 RID: 324
	[DefaultEvent("OnConnecting")]
	[AxHost.ClsidAttribute("{1df7c823-b2d4-4b54-975a-f2ac5d7cf8b8}")]
	[DesignTimeVisible(true)]
	[ComVisible(true)]
	public class AxMsRdpClient11NotSafeForScripting : AxHost
	{
		// Token: 0x06001947 RID: 6471 RVA: 0x00052BD4 File Offset: 0x00050DD4
		public AxMsRdpClient11NotSafeForScripting() : base("1df7c823-b2d4-4b54-975a-f2ac5d7cf8b8")
		{
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06001948 RID: 6472 RVA: 0x00052BE4 File Offset: 0x00050DE4
		// (set) Token: 0x06001949 RID: 6473 RVA: 0x00052C08 File Offset: 0x00050E08
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

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x0600194A RID: 6474 RVA: 0x00052C30 File Offset: 0x00050E30
		// (set) Token: 0x0600194B RID: 6475 RVA: 0x00052C54 File Offset: 0x00050E54
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

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x0600194C RID: 6476 RVA: 0x00052C7C File Offset: 0x00050E7C
		// (set) Token: 0x0600194D RID: 6477 RVA: 0x00052CA0 File Offset: 0x00050EA0
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

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x0600194E RID: 6478 RVA: 0x00052CC8 File Offset: 0x00050EC8
		// (set) Token: 0x0600194F RID: 6479 RVA: 0x00052CEC File Offset: 0x00050EEC
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

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06001950 RID: 6480 RVA: 0x00052D14 File Offset: 0x00050F14
		// (set) Token: 0x06001951 RID: 6481 RVA: 0x00052D38 File Offset: 0x00050F38
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

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06001952 RID: 6482 RVA: 0x00052D60 File Offset: 0x00050F60
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

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06001953 RID: 6483 RVA: 0x00052D84 File Offset: 0x00050F84
		// (set) Token: 0x06001954 RID: 6484 RVA: 0x00052DA8 File Offset: 0x00050FA8
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

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06001955 RID: 6485 RVA: 0x00052DD0 File Offset: 0x00050FD0
		// (set) Token: 0x06001956 RID: 6486 RVA: 0x00052DF4 File Offset: 0x00050FF4
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

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06001957 RID: 6487 RVA: 0x00052E1C File Offset: 0x0005101C
		// (set) Token: 0x06001958 RID: 6488 RVA: 0x00052E40 File Offset: 0x00051040
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

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06001959 RID: 6489 RVA: 0x00052E68 File Offset: 0x00051068
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

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x0600195A RID: 6490 RVA: 0x00052E8C File Offset: 0x0005108C
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

		// Token: 0x170004A3 RID: 1187
		// (set) Token: 0x0600195B RID: 6491 RVA: 0x00052EB0 File Offset: 0x000510B0
		[DispId(19)]
		[Browsable(false)]
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

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x0600195C RID: 6492 RVA: 0x00052ED8 File Offset: 0x000510D8
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

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x0600195D RID: 6493 RVA: 0x00052EFC File Offset: 0x000510FC
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

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x0600195E RID: 6494 RVA: 0x00052F20 File Offset: 0x00051120
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

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x0600195F RID: 6495 RVA: 0x00052F44 File Offset: 0x00051144
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

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06001960 RID: 6496 RVA: 0x00052F68 File Offset: 0x00051168
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06001961 RID: 6497 RVA: 0x00052F8C File Offset: 0x0005118C
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

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06001962 RID: 6498 RVA: 0x00052FB0 File Offset: 0x000511B0
		// (set) Token: 0x06001963 RID: 6499 RVA: 0x00052FD4 File Offset: 0x000511D4
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

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06001964 RID: 6500 RVA: 0x00052FFC File Offset: 0x000511FC
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

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06001965 RID: 6501 RVA: 0x00053020 File Offset: 0x00051220
		[DispId(102)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06001966 RID: 6502 RVA: 0x00053044 File Offset: 0x00051244
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

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06001967 RID: 6503 RVA: 0x00053068 File Offset: 0x00051268
		// (set) Token: 0x06001968 RID: 6504 RVA: 0x0005308C File Offset: 0x0005128C
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

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06001969 RID: 6505 RVA: 0x000530B4 File Offset: 0x000512B4
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

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x0600196A RID: 6506 RVA: 0x000530D8 File Offset: 0x000512D8
		// (set) Token: 0x0600196B RID: 6507 RVA: 0x000530FC File Offset: 0x000512FC
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

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x0600196C RID: 6508 RVA: 0x00053124 File Offset: 0x00051324
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

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x0600196D RID: 6509 RVA: 0x00053148 File Offset: 0x00051348
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

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x0600196E RID: 6510 RVA: 0x0005316C File Offset: 0x0005136C
		[Browsable(false)]
		[DispId(500)]
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

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x0600196F RID: 6511 RVA: 0x00053190 File Offset: 0x00051390
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

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06001970 RID: 6512 RVA: 0x000531B4 File Offset: 0x000513B4
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

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06001971 RID: 6513 RVA: 0x000531D8 File Offset: 0x000513D8
		[Browsable(false)]
		[DispId(505)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06001972 RID: 6514 RVA: 0x000531FC File Offset: 0x000513FC
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
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

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06001973 RID: 6515 RVA: 0x00053220 File Offset: 0x00051420
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(506)]
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

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06001974 RID: 6516 RVA: 0x00053244 File Offset: 0x00051444
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

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06001975 RID: 6517 RVA: 0x00053268 File Offset: 0x00051468
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

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06001976 RID: 6518 RVA: 0x0005328C File Offset: 0x0005148C
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

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06001977 RID: 6519 RVA: 0x000532B0 File Offset: 0x000514B0
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

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06001978 RID: 6520 RVA: 0x000532D4 File Offset: 0x000514D4
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(701)]
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

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06001979 RID: 6521 RVA: 0x000532F8 File Offset: 0x000514F8
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(800)]
		[Browsable(false)]
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

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x0600197A RID: 6522 RVA: 0x0005331C File Offset: 0x0005151C
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

		// Token: 0x140002E9 RID: 745
		// (add) Token: 0x0600197B RID: 6523 RVA: 0x00053340 File Offset: 0x00051540
		// (remove) Token: 0x0600197C RID: 6524 RVA: 0x0005337C File Offset: 0x0005157C
		public event EventHandler OnConnecting;

		// Token: 0x140002EA RID: 746
		// (add) Token: 0x0600197D RID: 6525 RVA: 0x000533B8 File Offset: 0x000515B8
		// (remove) Token: 0x0600197E RID: 6526 RVA: 0x000533F4 File Offset: 0x000515F4
		public event EventHandler OnConnected;

		// Token: 0x140002EB RID: 747
		// (add) Token: 0x0600197F RID: 6527 RVA: 0x00053430 File Offset: 0x00051630
		// (remove) Token: 0x06001980 RID: 6528 RVA: 0x0005346C File Offset: 0x0005166C
		public event EventHandler OnLoginComplete;

		// Token: 0x140002EC RID: 748
		// (add) Token: 0x06001981 RID: 6529 RVA: 0x000534A8 File Offset: 0x000516A8
		// (remove) Token: 0x06001982 RID: 6530 RVA: 0x000534E4 File Offset: 0x000516E4
		public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x140002ED RID: 749
		// (add) Token: 0x06001983 RID: 6531 RVA: 0x00053520 File Offset: 0x00051720
		// (remove) Token: 0x06001984 RID: 6532 RVA: 0x0005355C File Offset: 0x0005175C
		public event EventHandler OnEnterFullScreenMode;

		// Token: 0x140002EE RID: 750
		// (add) Token: 0x06001985 RID: 6533 RVA: 0x00053598 File Offset: 0x00051798
		// (remove) Token: 0x06001986 RID: 6534 RVA: 0x000535D4 File Offset: 0x000517D4
		public event EventHandler OnLeaveFullScreenMode;

		// Token: 0x140002EF RID: 751
		// (add) Token: 0x06001987 RID: 6535 RVA: 0x00053610 File Offset: 0x00051810
		// (remove) Token: 0x06001988 RID: 6536 RVA: 0x0005364C File Offset: 0x0005184C
		public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x140002F0 RID: 752
		// (add) Token: 0x06001989 RID: 6537 RVA: 0x00053688 File Offset: 0x00051888
		// (remove) Token: 0x0600198A RID: 6538 RVA: 0x000536C4 File Offset: 0x000518C4
		public event EventHandler OnRequestGoFullScreen;

		// Token: 0x140002F1 RID: 753
		// (add) Token: 0x0600198B RID: 6539 RVA: 0x00053700 File Offset: 0x00051900
		// (remove) Token: 0x0600198C RID: 6540 RVA: 0x0005373C File Offset: 0x0005193C
		public event EventHandler OnRequestLeaveFullScreen;

		// Token: 0x140002F2 RID: 754
		// (add) Token: 0x0600198D RID: 6541 RVA: 0x00053778 File Offset: 0x00051978
		// (remove) Token: 0x0600198E RID: 6542 RVA: 0x000537B4 File Offset: 0x000519B4
		public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x140002F3 RID: 755
		// (add) Token: 0x0600198F RID: 6543 RVA: 0x000537F0 File Offset: 0x000519F0
		// (remove) Token: 0x06001990 RID: 6544 RVA: 0x0005382C File Offset: 0x00051A2C
		public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x140002F4 RID: 756
		// (add) Token: 0x06001991 RID: 6545 RVA: 0x00053868 File Offset: 0x00051A68
		// (remove) Token: 0x06001992 RID: 6546 RVA: 0x000538A4 File Offset: 0x00051AA4
		public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x140002F5 RID: 757
		// (add) Token: 0x06001993 RID: 6547 RVA: 0x000538E0 File Offset: 0x00051AE0
		// (remove) Token: 0x06001994 RID: 6548 RVA: 0x0005391C File Offset: 0x00051B1C
		public event EventHandler OnIdleTimeoutNotification;

		// Token: 0x140002F6 RID: 758
		// (add) Token: 0x06001995 RID: 6549 RVA: 0x00053958 File Offset: 0x00051B58
		// (remove) Token: 0x06001996 RID: 6550 RVA: 0x00053994 File Offset: 0x00051B94
		public event EventHandler OnRequestContainerMinimize;

		// Token: 0x140002F7 RID: 759
		// (add) Token: 0x06001997 RID: 6551 RVA: 0x000539D0 File Offset: 0x00051BD0
		// (remove) Token: 0x06001998 RID: 6552 RVA: 0x00053A0C File Offset: 0x00051C0C
		public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x140002F8 RID: 760
		// (add) Token: 0x06001999 RID: 6553 RVA: 0x00053A48 File Offset: 0x00051C48
		// (remove) Token: 0x0600199A RID: 6554 RVA: 0x00053A84 File Offset: 0x00051C84
		public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x140002F9 RID: 761
		// (add) Token: 0x0600199B RID: 6555 RVA: 0x00053AC0 File Offset: 0x00051CC0
		// (remove) Token: 0x0600199C RID: 6556 RVA: 0x00053AFC File Offset: 0x00051CFC
		public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x140002FA RID: 762
		// (add) Token: 0x0600199D RID: 6557 RVA: 0x00053B38 File Offset: 0x00051D38
		// (remove) Token: 0x0600199E RID: 6558 RVA: 0x00053B74 File Offset: 0x00051D74
		public event EventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x140002FB RID: 763
		// (add) Token: 0x0600199F RID: 6559 RVA: 0x00053BB0 File Offset: 0x00051DB0
		// (remove) Token: 0x060019A0 RID: 6560 RVA: 0x00053BEC File Offset: 0x00051DEC
		public event EventHandler OnAuthenticationWarningDismissed;

		// Token: 0x140002FC RID: 764
		// (add) Token: 0x060019A1 RID: 6561 RVA: 0x00053C28 File Offset: 0x00051E28
		// (remove) Token: 0x060019A2 RID: 6562 RVA: 0x00053C64 File Offset: 0x00051E64
		public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x140002FD RID: 765
		// (add) Token: 0x060019A3 RID: 6563 RVA: 0x00053CA0 File Offset: 0x00051EA0
		// (remove) Token: 0x060019A4 RID: 6564 RVA: 0x00053CDC File Offset: 0x00051EDC
		public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x140002FE RID: 766
		// (add) Token: 0x060019A5 RID: 6565 RVA: 0x00053D18 File Offset: 0x00051F18
		// (remove) Token: 0x060019A6 RID: 6566 RVA: 0x00053D54 File Offset: 0x00051F54
		public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x140002FF RID: 767
		// (add) Token: 0x060019A7 RID: 6567 RVA: 0x00053D90 File Offset: 0x00051F90
		// (remove) Token: 0x060019A8 RID: 6568 RVA: 0x00053DCC File Offset: 0x00051FCC
		public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x14000300 RID: 768
		// (add) Token: 0x060019A9 RID: 6569 RVA: 0x00053E08 File Offset: 0x00052008
		// (remove) Token: 0x060019AA RID: 6570 RVA: 0x00053E44 File Offset: 0x00052044
		public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x14000301 RID: 769
		// (add) Token: 0x060019AB RID: 6571 RVA: 0x00053E80 File Offset: 0x00052080
		// (remove) Token: 0x060019AC RID: 6572 RVA: 0x00053EBC File Offset: 0x000520BC
		public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x14000302 RID: 770
		// (add) Token: 0x060019AD RID: 6573 RVA: 0x00053EF8 File Offset: 0x000520F8
		// (remove) Token: 0x060019AE RID: 6574 RVA: 0x00053F34 File Offset: 0x00052134
		public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x14000303 RID: 771
		// (add) Token: 0x060019AF RID: 6575 RVA: 0x00053F70 File Offset: 0x00052170
		// (remove) Token: 0x060019B0 RID: 6576 RVA: 0x00053FAC File Offset: 0x000521AC
		public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x14000304 RID: 772
		// (add) Token: 0x060019B1 RID: 6577 RVA: 0x00053FE8 File Offset: 0x000521E8
		// (remove) Token: 0x060019B2 RID: 6578 RVA: 0x00054024 File Offset: 0x00052224
		public event EventHandler OnConnectionBarPullDown;

		// Token: 0x14000305 RID: 773
		// (add) Token: 0x060019B3 RID: 6579 RVA: 0x00054060 File Offset: 0x00052260
		// (remove) Token: 0x060019B4 RID: 6580 RVA: 0x0005409C File Offset: 0x0005229C
		public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x14000306 RID: 774
		// (add) Token: 0x060019B5 RID: 6581 RVA: 0x000540D8 File Offset: 0x000522D8
		// (remove) Token: 0x060019B6 RID: 6582 RVA: 0x00054114 File Offset: 0x00052314
		public event EventHandler OnDevicesButtonPressed;

		// Token: 0x14000307 RID: 775
		// (add) Token: 0x060019B7 RID: 6583 RVA: 0x00054150 File Offset: 0x00052350
		// (remove) Token: 0x060019B8 RID: 6584 RVA: 0x0005418C File Offset: 0x0005238C
		public event EventHandler OnAutoReconnected;

		// Token: 0x14000308 RID: 776
		// (add) Token: 0x060019B9 RID: 6585 RVA: 0x000541C8 File Offset: 0x000523C8
		// (remove) Token: 0x060019BA RID: 6586 RVA: 0x00054204 File Offset: 0x00052404
		public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

		// Token: 0x060019BB RID: 6587 RVA: 0x00054240 File Offset: 0x00052440
		public virtual void Connect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Connect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Connect();
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x00054264 File Offset: 0x00052464
		public virtual void Disconnect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Disconnect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Disconnect();
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x00054288 File Offset: 0x00052488
		public virtual void CreateVirtualChannels(string newVal)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("CreateVirtualChannels", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.CreateVirtualChannels(newVal);
		}

		// Token: 0x060019BE RID: 6590 RVA: 0x000542B0 File Offset: 0x000524B0
		public virtual void SendOnVirtualChannel(string chanName, string chanData)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SendOnVirtualChannel", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SendOnVirtualChannel(chanName, chanData);
		}

		// Token: 0x060019BF RID: 6591 RVA: 0x000542D8 File Offset: 0x000524D8
		public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SetVirtualChannelOptions(chanName, chanOptions);
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x00054300 File Offset: 0x00052500
		public virtual int GetVirtualChannelOptions(string chanName)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetVirtualChannelOptions(chanName);
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x00054338 File Offset: 0x00052538
		public virtual ControlCloseStatus RequestClose()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("RequestClose", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.RequestClose();
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x00054370 File Offset: 0x00052570
		public virtual string GetErrorDescription(uint disconnectReason, uint extendedDisconnectReason)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetErrorDescription", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetErrorDescription(disconnectReason, extendedDisconnectReason);
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x000543A8 File Offset: 0x000525A8
		public virtual string GetStatusText(uint statusCode)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetStatusText", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetStatusText(statusCode);
		}

		// Token: 0x060019C4 RID: 6596 RVA: 0x000543E0 File Offset: 0x000525E0
		public virtual void SendRemoteAction(RemoteSessionActionType actionType)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SendRemoteAction", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SendRemoteAction(actionType);
		}

		// Token: 0x060019C5 RID: 6597 RVA: 0x00054408 File Offset: 0x00052608
		public virtual ControlReconnectStatus Reconnect(uint ulWidth, uint ulHeight)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Reconnect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.Reconnect(ulWidth, ulHeight);
		}

		// Token: 0x060019C6 RID: 6598 RVA: 0x00054440 File Offset: 0x00052640
		public virtual void SyncSessionDisplaySettings()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SyncSessionDisplaySettings", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SyncSessionDisplaySettings();
		}

		// Token: 0x060019C7 RID: 6599 RVA: 0x00054464 File Offset: 0x00052664
		public virtual void UpdateSessionDisplaySettings(uint ulDesktopWidth, uint ulDesktopHeight, uint ulPhysicalWidth, uint ulPhysicalHeight, uint ulOrientation, uint ulDesktopScaleFactor, uint ulDeviceScaleFactor)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("UpdateSessionDisplaySettings", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.UpdateSessionDisplaySettings(ulDesktopWidth, ulDesktopHeight, ulPhysicalWidth, ulPhysicalHeight, ulOrientation, ulDesktopScaleFactor, ulDeviceScaleFactor);
		}

		// Token: 0x060019C8 RID: 6600 RVA: 0x000544A4 File Offset: 0x000526A4
		public virtual void attachEvent(string eventName, object callback)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("attachEvent", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.attachEvent(eventName, callback);
		}

		// Token: 0x060019C9 RID: 6601 RVA: 0x000544CC File Offset: 0x000526CC
		public virtual void detachEvent(string eventName, object callback)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("detachEvent", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.detachEvent(eventName, callback);
		}

		// Token: 0x060019CA RID: 6602 RVA: 0x000544F4 File Offset: 0x000526F4
		protected override void CreateSink()
		{
			try
			{
				this.eventMulticaster = new AxMsRdpClient11NotSafeForScriptingEventMulticaster(this);
				this.cookie = new AxHost.ConnectionPointCookie(this.ocx, this.eventMulticaster, typeof(IMsTscAxEvents));
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060019CB RID: 6603 RVA: 0x0005454C File Offset: 0x0005274C
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

		// Token: 0x060019CC RID: 6604 RVA: 0x00054580 File Offset: 0x00052780
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

		// Token: 0x060019CD RID: 6605 RVA: 0x000545BC File Offset: 0x000527BC
		internal void RaiseOnOnConnecting(object sender, EventArgs e)
		{
			if (this.OnConnecting != null)
			{
				this.OnConnecting(sender, e);
			}
		}

		// Token: 0x060019CE RID: 6606 RVA: 0x000545D8 File Offset: 0x000527D8
		internal void RaiseOnOnConnected(object sender, EventArgs e)
		{
			if (this.OnConnected != null)
			{
				this.OnConnected(sender, e);
			}
		}

		// Token: 0x060019CF RID: 6607 RVA: 0x000545F4 File Offset: 0x000527F4
		internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
		{
			if (this.OnLoginComplete != null)
			{
				this.OnLoginComplete(sender, e);
			}
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x00054610 File Offset: 0x00052810
		internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
		{
			if (this.OnDisconnected != null)
			{
				this.OnDisconnected(sender, e);
			}
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x0005462C File Offset: 0x0005282C
		internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnEnterFullScreenMode != null)
			{
				this.OnEnterFullScreenMode(sender, e);
			}
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x00054648 File Offset: 0x00052848
		internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnLeaveFullScreenMode != null)
			{
				this.OnLeaveFullScreenMode(sender, e);
			}
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x00054664 File Offset: 0x00052864
		internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
		{
			if (this.OnChannelReceivedData != null)
			{
				this.OnChannelReceivedData(sender, e);
			}
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x00054680 File Offset: 0x00052880
		internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestGoFullScreen != null)
			{
				this.OnRequestGoFullScreen(sender, e);
			}
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x0005469C File Offset: 0x0005289C
		internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestLeaveFullScreen != null)
			{
				this.OnRequestLeaveFullScreen(sender, e);
			}
		}

		// Token: 0x060019D6 RID: 6614 RVA: 0x000546B8 File Offset: 0x000528B8
		internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
		{
			if (this.OnFatalError != null)
			{
				this.OnFatalError(sender, e);
			}
		}

		// Token: 0x060019D7 RID: 6615 RVA: 0x000546D4 File Offset: 0x000528D4
		internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
		{
			if (this.OnWarning != null)
			{
				this.OnWarning(sender, e);
			}
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x000546F0 File Offset: 0x000528F0
		internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
		{
			if (this.OnRemoteDesktopSizeChange != null)
			{
				this.OnRemoteDesktopSizeChange(sender, e);
			}
		}

		// Token: 0x060019D9 RID: 6617 RVA: 0x0005470C File Offset: 0x0005290C
		internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
		{
			if (this.OnIdleTimeoutNotification != null)
			{
				this.OnIdleTimeoutNotification(sender, e);
			}
		}

		// Token: 0x060019DA RID: 6618 RVA: 0x00054728 File Offset: 0x00052928
		internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
		{
			if (this.OnRequestContainerMinimize != null)
			{
				this.OnRequestContainerMinimize(sender, e);
			}
		}

		// Token: 0x060019DB RID: 6619 RVA: 0x00054744 File Offset: 0x00052944
		internal void RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
		{
			if (this.OnConfirmClose != null)
			{
				this.OnConfirmClose(sender, e);
			}
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x00054760 File Offset: 0x00052960
		internal void RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
		{
			if (this.OnReceivedTSPublicKey != null)
			{
				this.OnReceivedTSPublicKey(sender, e);
			}
		}

		// Token: 0x060019DD RID: 6621 RVA: 0x0005477C File Offset: 0x0005297C
		internal void RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
		{
			if (this.OnAutoReconnecting != null)
			{
				this.OnAutoReconnecting(sender, e);
			}
		}

		// Token: 0x060019DE RID: 6622 RVA: 0x00054798 File Offset: 0x00052998
		internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDisplayed != null)
			{
				this.OnAuthenticationWarningDisplayed(sender, e);
			}
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x000547B4 File Offset: 0x000529B4
		internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDismissed != null)
			{
				this.OnAuthenticationWarningDismissed(sender, e);
			}
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x000547D0 File Offset: 0x000529D0
		internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
		{
			if (this.OnRemoteProgramResult != null)
			{
				this.OnRemoteProgramResult(sender, e);
			}
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x000547EC File Offset: 0x000529EC
		internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
		{
			if (this.OnRemoteProgramDisplayed != null)
			{
				this.OnRemoteProgramDisplayed(sender, e);
			}
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x00054808 File Offset: 0x00052A08
		internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
		{
			if (this.OnRemoteWindowDisplayed != null)
			{
				this.OnRemoteWindowDisplayed(sender, e);
			}
		}

		// Token: 0x060019E3 RID: 6627 RVA: 0x00054824 File Offset: 0x00052A24
		internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
		{
			if (this.OnLogonError != null)
			{
				this.OnLogonError(sender, e);
			}
		}

		// Token: 0x060019E4 RID: 6628 RVA: 0x00054840 File Offset: 0x00052A40
		internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
		{
			if (this.OnFocusReleased != null)
			{
				this.OnFocusReleased(sender, e);
			}
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x0005485C File Offset: 0x00052A5C
		internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
		{
			if (this.OnUserNameAcquired != null)
			{
				this.OnUserNameAcquired(sender, e);
			}
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x00054878 File Offset: 0x00052A78
		internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
		{
			if (this.OnMouseInputModeChanged != null)
			{
				this.OnMouseInputModeChanged(sender, e);
			}
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x00054894 File Offset: 0x00052A94
		internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
		{
			if (this.OnServiceMessageReceived != null)
			{
				this.OnServiceMessageReceived(sender, e);
			}
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x000548B0 File Offset: 0x00052AB0
		internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
		{
			if (this.OnConnectionBarPullDown != null)
			{
				this.OnConnectionBarPullDown(sender, e);
			}
		}

		// Token: 0x060019E9 RID: 6633 RVA: 0x000548CC File Offset: 0x00052ACC
		internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
		{
			if (this.OnNetworkStatusChanged != null)
			{
				this.OnNetworkStatusChanged(sender, e);
			}
		}

		// Token: 0x060019EA RID: 6634 RVA: 0x000548E8 File Offset: 0x00052AE8
		internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
		{
			if (this.OnDevicesButtonPressed != null)
			{
				this.OnDevicesButtonPressed(sender, e);
			}
		}

		// Token: 0x060019EB RID: 6635 RVA: 0x00054904 File Offset: 0x00052B04
		internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
		{
			if (this.OnAutoReconnected != null)
			{
				this.OnAutoReconnected(sender, e);
			}
		}

		// Token: 0x060019EC RID: 6636 RVA: 0x00054920 File Offset: 0x00052B20
		internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
		{
			if (this.OnAutoReconnecting2 != null)
			{
				this.OnAutoReconnecting2(sender, e);
			}
		}

		// Token: 0x040006C7 RID: 1735
		private IMsRdpClient10 ocx;

		// Token: 0x040006C8 RID: 1736
		private AxMsRdpClient11NotSafeForScriptingEventMulticaster eventMulticaster;

		// Token: 0x040006C9 RID: 1737
		private AxHost.ConnectionPointCookie cookie;
	}
}
