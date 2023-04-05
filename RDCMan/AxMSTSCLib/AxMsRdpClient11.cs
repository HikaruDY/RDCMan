using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MSTSCLib;

namespace AxMSTSCLib
{
	// Token: 0x02000146 RID: 326
	[DefaultEvent("OnConnecting")]
	[AxHost.ClsidAttribute("{22a7e88c-5bf5-4de6-b687-60f7331df190}")]
	[DesignTimeVisible(true)]
	[ComVisible(true)]
	public class AxMsRdpClient11 : AxHost
	{
		// Token: 0x06001A0E RID: 6670 RVA: 0x00054EFC File Offset: 0x000530FC
		public AxMsRdpClient11() : base("22a7e88c-5bf5-4de6-b687-60f7331df190")
		{
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06001A0F RID: 6671 RVA: 0x00054F0C File Offset: 0x0005310C
		// (set) Token: 0x06001A10 RID: 6672 RVA: 0x00054F30 File Offset: 0x00053130
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

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06001A11 RID: 6673 RVA: 0x00054F58 File Offset: 0x00053158
		// (set) Token: 0x06001A12 RID: 6674 RVA: 0x00054F7C File Offset: 0x0005317C
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

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06001A13 RID: 6675 RVA: 0x00054FA4 File Offset: 0x000531A4
		// (set) Token: 0x06001A14 RID: 6676 RVA: 0x00054FC8 File Offset: 0x000531C8
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

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06001A15 RID: 6677 RVA: 0x00054FF0 File Offset: 0x000531F0
		// (set) Token: 0x06001A16 RID: 6678 RVA: 0x00055014 File Offset: 0x00053214
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

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06001A17 RID: 6679 RVA: 0x0005503C File Offset: 0x0005323C
		// (set) Token: 0x06001A18 RID: 6680 RVA: 0x00055060 File Offset: 0x00053260
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

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06001A19 RID: 6681 RVA: 0x00055088 File Offset: 0x00053288
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

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06001A1A RID: 6682 RVA: 0x000550AC File Offset: 0x000532AC
		// (set) Token: 0x06001A1B RID: 6683 RVA: 0x000550D0 File Offset: 0x000532D0
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

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06001A1C RID: 6684 RVA: 0x000550F8 File Offset: 0x000532F8
		// (set) Token: 0x06001A1D RID: 6685 RVA: 0x0005511C File Offset: 0x0005331C
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

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06001A1E RID: 6686 RVA: 0x00055144 File Offset: 0x00053344
		// (set) Token: 0x06001A1F RID: 6687 RVA: 0x00055168 File Offset: 0x00053368
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

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06001A20 RID: 6688 RVA: 0x00055190 File Offset: 0x00053390
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

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06001A21 RID: 6689 RVA: 0x000551B4 File Offset: 0x000533B4
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

		// Token: 0x170004CB RID: 1227
		// (set) Token: 0x06001A22 RID: 6690 RVA: 0x000551D8 File Offset: 0x000533D8
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

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06001A23 RID: 6691 RVA: 0x00055200 File Offset: 0x00053400
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

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06001A24 RID: 6692 RVA: 0x00055224 File Offset: 0x00053424
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

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06001A25 RID: 6693 RVA: 0x00055248 File Offset: 0x00053448
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

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06001A26 RID: 6694 RVA: 0x0005526C File Offset: 0x0005346C
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(97)]
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

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06001A27 RID: 6695 RVA: 0x00055290 File Offset: 0x00053490
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

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06001A28 RID: 6696 RVA: 0x000552B4 File Offset: 0x000534B4
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

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06001A29 RID: 6697 RVA: 0x000552D8 File Offset: 0x000534D8
		// (set) Token: 0x06001A2A RID: 6698 RVA: 0x000552FC File Offset: 0x000534FC
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

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06001A2B RID: 6699 RVA: 0x00055324 File Offset: 0x00053524
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

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06001A2C RID: 6700 RVA: 0x00055348 File Offset: 0x00053548
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

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06001A2D RID: 6701 RVA: 0x0005536C File Offset: 0x0005356C
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

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06001A2E RID: 6702 RVA: 0x00055390 File Offset: 0x00053590
		// (set) Token: 0x06001A2F RID: 6703 RVA: 0x000553B4 File Offset: 0x000535B4
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

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06001A30 RID: 6704 RVA: 0x000553DC File Offset: 0x000535DC
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

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06001A31 RID: 6705 RVA: 0x00055400 File Offset: 0x00053600
		// (set) Token: 0x06001A32 RID: 6706 RVA: 0x00055424 File Offset: 0x00053624
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

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06001A33 RID: 6707 RVA: 0x0005544C File Offset: 0x0005364C
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(300)]
		[Browsable(false)]
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

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06001A34 RID: 6708 RVA: 0x00055470 File Offset: 0x00053670
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

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06001A35 RID: 6709 RVA: 0x00055494 File Offset: 0x00053694
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06001A36 RID: 6710 RVA: 0x000554B8 File Offset: 0x000536B8
		[Browsable(false)]
		[DispId(502)]
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

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06001A37 RID: 6711 RVA: 0x000554DC File Offset: 0x000536DC
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

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06001A38 RID: 6712 RVA: 0x00055500 File Offset: 0x00053700
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

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06001A39 RID: 6713 RVA: 0x00055524 File Offset: 0x00053724
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

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06001A3A RID: 6714 RVA: 0x00055548 File Offset: 0x00053748
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

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06001A3B RID: 6715 RVA: 0x0005556C File Offset: 0x0005376C
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

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06001A3C RID: 6716 RVA: 0x00055590 File Offset: 0x00053790
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

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06001A3D RID: 6717 RVA: 0x000555B4 File Offset: 0x000537B4
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

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06001A3E RID: 6718 RVA: 0x000555D8 File Offset: 0x000537D8
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

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06001A3F RID: 6719 RVA: 0x000555FC File Offset: 0x000537FC
		[DispId(701)]
		[Browsable(false)]
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

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06001A40 RID: 6720 RVA: 0x00055620 File Offset: 0x00053820
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

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06001A41 RID: 6721 RVA: 0x00055644 File Offset: 0x00053844
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

		// Token: 0x14000309 RID: 777
		// (add) Token: 0x06001A42 RID: 6722 RVA: 0x00055668 File Offset: 0x00053868
		// (remove) Token: 0x06001A43 RID: 6723 RVA: 0x000556A4 File Offset: 0x000538A4
		public event EventHandler OnConnecting;

		// Token: 0x1400030A RID: 778
		// (add) Token: 0x06001A44 RID: 6724 RVA: 0x000556E0 File Offset: 0x000538E0
		// (remove) Token: 0x06001A45 RID: 6725 RVA: 0x0005571C File Offset: 0x0005391C
		public event EventHandler OnConnected;

		// Token: 0x1400030B RID: 779
		// (add) Token: 0x06001A46 RID: 6726 RVA: 0x00055758 File Offset: 0x00053958
		// (remove) Token: 0x06001A47 RID: 6727 RVA: 0x00055794 File Offset: 0x00053994
		public event EventHandler OnLoginComplete;

		// Token: 0x1400030C RID: 780
		// (add) Token: 0x06001A48 RID: 6728 RVA: 0x000557D0 File Offset: 0x000539D0
		// (remove) Token: 0x06001A49 RID: 6729 RVA: 0x0005580C File Offset: 0x00053A0C
		public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x1400030D RID: 781
		// (add) Token: 0x06001A4A RID: 6730 RVA: 0x00055848 File Offset: 0x00053A48
		// (remove) Token: 0x06001A4B RID: 6731 RVA: 0x00055884 File Offset: 0x00053A84
		public event EventHandler OnEnterFullScreenMode;

		// Token: 0x1400030E RID: 782
		// (add) Token: 0x06001A4C RID: 6732 RVA: 0x000558C0 File Offset: 0x00053AC0
		// (remove) Token: 0x06001A4D RID: 6733 RVA: 0x000558FC File Offset: 0x00053AFC
		public event EventHandler OnLeaveFullScreenMode;

		// Token: 0x1400030F RID: 783
		// (add) Token: 0x06001A4E RID: 6734 RVA: 0x00055938 File Offset: 0x00053B38
		// (remove) Token: 0x06001A4F RID: 6735 RVA: 0x00055974 File Offset: 0x00053B74
		public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x14000310 RID: 784
		// (add) Token: 0x06001A50 RID: 6736 RVA: 0x000559B0 File Offset: 0x00053BB0
		// (remove) Token: 0x06001A51 RID: 6737 RVA: 0x000559EC File Offset: 0x00053BEC
		public event EventHandler OnRequestGoFullScreen;

		// Token: 0x14000311 RID: 785
		// (add) Token: 0x06001A52 RID: 6738 RVA: 0x00055A28 File Offset: 0x00053C28
		// (remove) Token: 0x06001A53 RID: 6739 RVA: 0x00055A64 File Offset: 0x00053C64
		public event EventHandler OnRequestLeaveFullScreen;

		// Token: 0x14000312 RID: 786
		// (add) Token: 0x06001A54 RID: 6740 RVA: 0x00055AA0 File Offset: 0x00053CA0
		// (remove) Token: 0x06001A55 RID: 6741 RVA: 0x00055ADC File Offset: 0x00053CDC
		public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x14000313 RID: 787
		// (add) Token: 0x06001A56 RID: 6742 RVA: 0x00055B18 File Offset: 0x00053D18
		// (remove) Token: 0x06001A57 RID: 6743 RVA: 0x00055B54 File Offset: 0x00053D54
		public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x14000314 RID: 788
		// (add) Token: 0x06001A58 RID: 6744 RVA: 0x00055B90 File Offset: 0x00053D90
		// (remove) Token: 0x06001A59 RID: 6745 RVA: 0x00055BCC File Offset: 0x00053DCC
		public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x14000315 RID: 789
		// (add) Token: 0x06001A5A RID: 6746 RVA: 0x00055C08 File Offset: 0x00053E08
		// (remove) Token: 0x06001A5B RID: 6747 RVA: 0x00055C44 File Offset: 0x00053E44
		public event EventHandler OnIdleTimeoutNotification;

		// Token: 0x14000316 RID: 790
		// (add) Token: 0x06001A5C RID: 6748 RVA: 0x00055C80 File Offset: 0x00053E80
		// (remove) Token: 0x06001A5D RID: 6749 RVA: 0x00055CBC File Offset: 0x00053EBC
		public event EventHandler OnRequestContainerMinimize;

		// Token: 0x14000317 RID: 791
		// (add) Token: 0x06001A5E RID: 6750 RVA: 0x00055CF8 File Offset: 0x00053EF8
		// (remove) Token: 0x06001A5F RID: 6751 RVA: 0x00055D34 File Offset: 0x00053F34
		public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x14000318 RID: 792
		// (add) Token: 0x06001A60 RID: 6752 RVA: 0x00055D70 File Offset: 0x00053F70
		// (remove) Token: 0x06001A61 RID: 6753 RVA: 0x00055DAC File Offset: 0x00053FAC
		public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x14000319 RID: 793
		// (add) Token: 0x06001A62 RID: 6754 RVA: 0x00055DE8 File Offset: 0x00053FE8
		// (remove) Token: 0x06001A63 RID: 6755 RVA: 0x00055E24 File Offset: 0x00054024
		public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x1400031A RID: 794
		// (add) Token: 0x06001A64 RID: 6756 RVA: 0x00055E60 File Offset: 0x00054060
		// (remove) Token: 0x06001A65 RID: 6757 RVA: 0x00055E9C File Offset: 0x0005409C
		public event EventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x1400031B RID: 795
		// (add) Token: 0x06001A66 RID: 6758 RVA: 0x00055ED8 File Offset: 0x000540D8
		// (remove) Token: 0x06001A67 RID: 6759 RVA: 0x00055F14 File Offset: 0x00054114
		public event EventHandler OnAuthenticationWarningDismissed;

		// Token: 0x1400031C RID: 796
		// (add) Token: 0x06001A68 RID: 6760 RVA: 0x00055F50 File Offset: 0x00054150
		// (remove) Token: 0x06001A69 RID: 6761 RVA: 0x00055F8C File Offset: 0x0005418C
		public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x1400031D RID: 797
		// (add) Token: 0x06001A6A RID: 6762 RVA: 0x00055FC8 File Offset: 0x000541C8
		// (remove) Token: 0x06001A6B RID: 6763 RVA: 0x00056004 File Offset: 0x00054204
		public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x1400031E RID: 798
		// (add) Token: 0x06001A6C RID: 6764 RVA: 0x00056040 File Offset: 0x00054240
		// (remove) Token: 0x06001A6D RID: 6765 RVA: 0x0005607C File Offset: 0x0005427C
		public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x1400031F RID: 799
		// (add) Token: 0x06001A6E RID: 6766 RVA: 0x000560B8 File Offset: 0x000542B8
		// (remove) Token: 0x06001A6F RID: 6767 RVA: 0x000560F4 File Offset: 0x000542F4
		public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x14000320 RID: 800
		// (add) Token: 0x06001A70 RID: 6768 RVA: 0x00056130 File Offset: 0x00054330
		// (remove) Token: 0x06001A71 RID: 6769 RVA: 0x0005616C File Offset: 0x0005436C
		public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x14000321 RID: 801
		// (add) Token: 0x06001A72 RID: 6770 RVA: 0x000561A8 File Offset: 0x000543A8
		// (remove) Token: 0x06001A73 RID: 6771 RVA: 0x000561E4 File Offset: 0x000543E4
		public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x14000322 RID: 802
		// (add) Token: 0x06001A74 RID: 6772 RVA: 0x00056220 File Offset: 0x00054420
		// (remove) Token: 0x06001A75 RID: 6773 RVA: 0x0005625C File Offset: 0x0005445C
		public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x14000323 RID: 803
		// (add) Token: 0x06001A76 RID: 6774 RVA: 0x00056298 File Offset: 0x00054498
		// (remove) Token: 0x06001A77 RID: 6775 RVA: 0x000562D4 File Offset: 0x000544D4
		public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x14000324 RID: 804
		// (add) Token: 0x06001A78 RID: 6776 RVA: 0x00056310 File Offset: 0x00054510
		// (remove) Token: 0x06001A79 RID: 6777 RVA: 0x0005634C File Offset: 0x0005454C
		public event EventHandler OnConnectionBarPullDown;

		// Token: 0x14000325 RID: 805
		// (add) Token: 0x06001A7A RID: 6778 RVA: 0x00056388 File Offset: 0x00054588
		// (remove) Token: 0x06001A7B RID: 6779 RVA: 0x000563C4 File Offset: 0x000545C4
		public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x14000326 RID: 806
		// (add) Token: 0x06001A7C RID: 6780 RVA: 0x00056400 File Offset: 0x00054600
		// (remove) Token: 0x06001A7D RID: 6781 RVA: 0x0005643C File Offset: 0x0005463C
		public event EventHandler OnDevicesButtonPressed;

		// Token: 0x14000327 RID: 807
		// (add) Token: 0x06001A7E RID: 6782 RVA: 0x00056478 File Offset: 0x00054678
		// (remove) Token: 0x06001A7F RID: 6783 RVA: 0x000564B4 File Offset: 0x000546B4
		public event EventHandler OnAutoReconnected;

		// Token: 0x14000328 RID: 808
		// (add) Token: 0x06001A80 RID: 6784 RVA: 0x000564F0 File Offset: 0x000546F0
		// (remove) Token: 0x06001A81 RID: 6785 RVA: 0x0005652C File Offset: 0x0005472C
		public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

		// Token: 0x06001A82 RID: 6786 RVA: 0x00056568 File Offset: 0x00054768
		public virtual void Connect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Connect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Connect();
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x0005658C File Offset: 0x0005478C
		public virtual void Disconnect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Disconnect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Disconnect();
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x000565B0 File Offset: 0x000547B0
		public virtual void CreateVirtualChannels(string newVal)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("CreateVirtualChannels", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.CreateVirtualChannels(newVal);
		}

		// Token: 0x06001A85 RID: 6789 RVA: 0x000565D8 File Offset: 0x000547D8
		public virtual void SendOnVirtualChannel(string chanName, string chanData)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SendOnVirtualChannel", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SendOnVirtualChannel(chanName, chanData);
		}

		// Token: 0x06001A86 RID: 6790 RVA: 0x00056600 File Offset: 0x00054800
		public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SetVirtualChannelOptions(chanName, chanOptions);
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x00056628 File Offset: 0x00054828
		public virtual int GetVirtualChannelOptions(string chanName)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetVirtualChannelOptions(chanName);
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x00056660 File Offset: 0x00054860
		public virtual ControlCloseStatus RequestClose()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("RequestClose", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.RequestClose();
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x00056698 File Offset: 0x00054898
		public virtual string GetErrorDescription(uint disconnectReason, uint extendedDisconnectReason)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetErrorDescription", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetErrorDescription(disconnectReason, extendedDisconnectReason);
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x000566D0 File Offset: 0x000548D0
		public virtual string GetStatusText(uint statusCode)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetStatusText", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetStatusText(statusCode);
		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x00056708 File Offset: 0x00054908
		public virtual void SendRemoteAction(RemoteSessionActionType actionType)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SendRemoteAction", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SendRemoteAction(actionType);
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x00056730 File Offset: 0x00054930
		public virtual ControlReconnectStatus Reconnect(uint ulWidth, uint ulHeight)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Reconnect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.Reconnect(ulWidth, ulHeight);
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x00056768 File Offset: 0x00054968
		public virtual void SyncSessionDisplaySettings()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SyncSessionDisplaySettings", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SyncSessionDisplaySettings();
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x0005678C File Offset: 0x0005498C
		public virtual void UpdateSessionDisplaySettings(uint ulDesktopWidth, uint ulDesktopHeight, uint ulPhysicalWidth, uint ulPhysicalHeight, uint ulOrientation, uint ulDesktopScaleFactor, uint ulDeviceScaleFactor)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("UpdateSessionDisplaySettings", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.UpdateSessionDisplaySettings(ulDesktopWidth, ulDesktopHeight, ulPhysicalWidth, ulPhysicalHeight, ulOrientation, ulDesktopScaleFactor, ulDeviceScaleFactor);
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x000567CC File Offset: 0x000549CC
		public virtual void attachEvent(string eventName, object callback)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("attachEvent", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.attachEvent(eventName, callback);
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x000567F4 File Offset: 0x000549F4
		public virtual void detachEvent(string eventName, object callback)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("detachEvent", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.detachEvent(eventName, callback);
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x0005681C File Offset: 0x00054A1C
		protected override void CreateSink()
		{
			try
			{
				this.eventMulticaster = new AxMsRdpClient11EventMulticaster(this);
				this.cookie = new AxHost.ConnectionPointCookie(this.ocx, this.eventMulticaster, typeof(IMsTscAxEvents));
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x00056874 File Offset: 0x00054A74
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

		// Token: 0x06001A93 RID: 6803 RVA: 0x000568A8 File Offset: 0x00054AA8
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

		// Token: 0x06001A94 RID: 6804 RVA: 0x000568E4 File Offset: 0x00054AE4
		internal void RaiseOnOnConnecting(object sender, EventArgs e)
		{
			if (this.OnConnecting != null)
			{
				this.OnConnecting(sender, e);
			}
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x00056900 File Offset: 0x00054B00
		internal void RaiseOnOnConnected(object sender, EventArgs e)
		{
			if (this.OnConnected != null)
			{
				this.OnConnected(sender, e);
			}
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x0005691C File Offset: 0x00054B1C
		internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
		{
			if (this.OnLoginComplete != null)
			{
				this.OnLoginComplete(sender, e);
			}
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x00056938 File Offset: 0x00054B38
		internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
		{
			if (this.OnDisconnected != null)
			{
				this.OnDisconnected(sender, e);
			}
		}

		// Token: 0x06001A98 RID: 6808 RVA: 0x00056954 File Offset: 0x00054B54
		internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnEnterFullScreenMode != null)
			{
				this.OnEnterFullScreenMode(sender, e);
			}
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x00056970 File Offset: 0x00054B70
		internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnLeaveFullScreenMode != null)
			{
				this.OnLeaveFullScreenMode(sender, e);
			}
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x0005698C File Offset: 0x00054B8C
		internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
		{
			if (this.OnChannelReceivedData != null)
			{
				this.OnChannelReceivedData(sender, e);
			}
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x000569A8 File Offset: 0x00054BA8
		internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestGoFullScreen != null)
			{
				this.OnRequestGoFullScreen(sender, e);
			}
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x000569C4 File Offset: 0x00054BC4
		internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestLeaveFullScreen != null)
			{
				this.OnRequestLeaveFullScreen(sender, e);
			}
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x000569E0 File Offset: 0x00054BE0
		internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
		{
			if (this.OnFatalError != null)
			{
				this.OnFatalError(sender, e);
			}
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x000569FC File Offset: 0x00054BFC
		internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
		{
			if (this.OnWarning != null)
			{
				this.OnWarning(sender, e);
			}
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x00056A18 File Offset: 0x00054C18
		internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
		{
			if (this.OnRemoteDesktopSizeChange != null)
			{
				this.OnRemoteDesktopSizeChange(sender, e);
			}
		}

		// Token: 0x06001AA0 RID: 6816 RVA: 0x00056A34 File Offset: 0x00054C34
		internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
		{
			if (this.OnIdleTimeoutNotification != null)
			{
				this.OnIdleTimeoutNotification(sender, e);
			}
		}

		// Token: 0x06001AA1 RID: 6817 RVA: 0x00056A50 File Offset: 0x00054C50
		internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
		{
			if (this.OnRequestContainerMinimize != null)
			{
				this.OnRequestContainerMinimize(sender, e);
			}
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x00056A6C File Offset: 0x00054C6C
		internal void RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
		{
			if (this.OnConfirmClose != null)
			{
				this.OnConfirmClose(sender, e);
			}
		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x00056A88 File Offset: 0x00054C88
		internal void RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
		{
			if (this.OnReceivedTSPublicKey != null)
			{
				this.OnReceivedTSPublicKey(sender, e);
			}
		}

		// Token: 0x06001AA4 RID: 6820 RVA: 0x00056AA4 File Offset: 0x00054CA4
		internal void RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
		{
			if (this.OnAutoReconnecting != null)
			{
				this.OnAutoReconnecting(sender, e);
			}
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x00056AC0 File Offset: 0x00054CC0
		internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDisplayed != null)
			{
				this.OnAuthenticationWarningDisplayed(sender, e);
			}
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x00056ADC File Offset: 0x00054CDC
		internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDismissed != null)
			{
				this.OnAuthenticationWarningDismissed(sender, e);
			}
		}

		// Token: 0x06001AA7 RID: 6823 RVA: 0x00056AF8 File Offset: 0x00054CF8
		internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
		{
			if (this.OnRemoteProgramResult != null)
			{
				this.OnRemoteProgramResult(sender, e);
			}
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x00056B14 File Offset: 0x00054D14
		internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
		{
			if (this.OnRemoteProgramDisplayed != null)
			{
				this.OnRemoteProgramDisplayed(sender, e);
			}
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x00056B30 File Offset: 0x00054D30
		internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
		{
			if (this.OnRemoteWindowDisplayed != null)
			{
				this.OnRemoteWindowDisplayed(sender, e);
			}
		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x00056B4C File Offset: 0x00054D4C
		internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
		{
			if (this.OnLogonError != null)
			{
				this.OnLogonError(sender, e);
			}
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x00056B68 File Offset: 0x00054D68
		internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
		{
			if (this.OnFocusReleased != null)
			{
				this.OnFocusReleased(sender, e);
			}
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x00056B84 File Offset: 0x00054D84
		internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
		{
			if (this.OnUserNameAcquired != null)
			{
				this.OnUserNameAcquired(sender, e);
			}
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x00056BA0 File Offset: 0x00054DA0
		internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
		{
			if (this.OnMouseInputModeChanged != null)
			{
				this.OnMouseInputModeChanged(sender, e);
			}
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x00056BBC File Offset: 0x00054DBC
		internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
		{
			if (this.OnServiceMessageReceived != null)
			{
				this.OnServiceMessageReceived(sender, e);
			}
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x00056BD8 File Offset: 0x00054DD8
		internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
		{
			if (this.OnConnectionBarPullDown != null)
			{
				this.OnConnectionBarPullDown(sender, e);
			}
		}

		// Token: 0x06001AB0 RID: 6832 RVA: 0x00056BF4 File Offset: 0x00054DF4
		internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
		{
			if (this.OnNetworkStatusChanged != null)
			{
				this.OnNetworkStatusChanged(sender, e);
			}
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x00056C10 File Offset: 0x00054E10
		internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
		{
			if (this.OnDevicesButtonPressed != null)
			{
				this.OnDevicesButtonPressed(sender, e);
			}
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x00056C2C File Offset: 0x00054E2C
		internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
		{
			if (this.OnAutoReconnected != null)
			{
				this.OnAutoReconnected(sender, e);
			}
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x00056C48 File Offset: 0x00054E48
		internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
		{
			if (this.OnAutoReconnecting2 != null)
			{
				this.OnAutoReconnecting2(sender, e);
			}
		}

		// Token: 0x040006EB RID: 1771
		private IMsRdpClient10 ocx;

		// Token: 0x040006EC RID: 1772
		private AxMsRdpClient11EventMulticaster eventMulticaster;

		// Token: 0x040006ED RID: 1773
		private AxHost.ConnectionPointCookie cookie;
	}
}
