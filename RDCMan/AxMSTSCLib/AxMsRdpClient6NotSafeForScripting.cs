using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MSTSCLib;

namespace AxMSTSCLib
{
	// Token: 0x02000130 RID: 304
	[DefaultEvent("OnConnecting")]
	[AxHost.ClsidAttribute("{d2ea46a7-c2bf-426b-af24-e19c44456399}")]
	[DesignTimeVisible(true)]
	[ComVisible(true)]
	public class AxMsRdpClient6NotSafeForScripting : AxHost
	{
		// Token: 0x060011BD RID: 4541 RVA: 0x0003D614 File Offset: 0x0003B814
		public AxMsRdpClient6NotSafeForScripting() : base("d2ea46a7-c2bf-426b-af24-e19c44456399")
		{
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x060011BE RID: 4542 RVA: 0x0003D624 File Offset: 0x0003B824
		// (set) Token: 0x060011BF RID: 4543 RVA: 0x0003D648 File Offset: 0x0003B848
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

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x060011C0 RID: 4544 RVA: 0x0003D670 File Offset: 0x0003B870
		// (set) Token: 0x060011C1 RID: 4545 RVA: 0x0003D694 File Offset: 0x0003B894
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

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x060011C2 RID: 4546 RVA: 0x0003D6BC File Offset: 0x0003B8BC
		// (set) Token: 0x060011C3 RID: 4547 RVA: 0x0003D6E0 File Offset: 0x0003B8E0
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

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x060011C4 RID: 4548 RVA: 0x0003D708 File Offset: 0x0003B908
		// (set) Token: 0x060011C5 RID: 4549 RVA: 0x0003D72C File Offset: 0x0003B92C
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

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x060011C6 RID: 4550 RVA: 0x0003D754 File Offset: 0x0003B954
		// (set) Token: 0x060011C7 RID: 4551 RVA: 0x0003D778 File Offset: 0x0003B978
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

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x060011C8 RID: 4552 RVA: 0x0003D7A0 File Offset: 0x0003B9A0
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

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x060011C9 RID: 4553 RVA: 0x0003D7C4 File Offset: 0x0003B9C4
		// (set) Token: 0x060011CA RID: 4554 RVA: 0x0003D7E8 File Offset: 0x0003B9E8
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

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x060011CB RID: 4555 RVA: 0x0003D810 File Offset: 0x0003BA10
		// (set) Token: 0x060011CC RID: 4556 RVA: 0x0003D834 File Offset: 0x0003BA34
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

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x060011CD RID: 4557 RVA: 0x0003D85C File Offset: 0x0003BA5C
		// (set) Token: 0x060011CE RID: 4558 RVA: 0x0003D880 File Offset: 0x0003BA80
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

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x060011CF RID: 4559 RVA: 0x0003D8A8 File Offset: 0x0003BAA8
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

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x060011D0 RID: 4560 RVA: 0x0003D8CC File Offset: 0x0003BACC
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

		// Token: 0x1700032D RID: 813
		// (set) Token: 0x060011D1 RID: 4561 RVA: 0x0003D8F0 File Offset: 0x0003BAF0
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

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x060011D2 RID: 4562 RVA: 0x0003D918 File Offset: 0x0003BB18
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

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x060011D3 RID: 4563 RVA: 0x0003D93C File Offset: 0x0003BB3C
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

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x060011D4 RID: 4564 RVA: 0x0003D960 File Offset: 0x0003BB60
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

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x060011D5 RID: 4565 RVA: 0x0003D984 File Offset: 0x0003BB84
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

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x060011D6 RID: 4566 RVA: 0x0003D9A8 File Offset: 0x0003BBA8
		[Browsable(false)]
		[DispId(98)]
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

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x060011D7 RID: 4567 RVA: 0x0003D9CC File Offset: 0x0003BBCC
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

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x060011D8 RID: 4568 RVA: 0x0003D9F0 File Offset: 0x0003BBF0
		// (set) Token: 0x060011D9 RID: 4569 RVA: 0x0003DA14 File Offset: 0x0003BC14
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

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x060011DA RID: 4570 RVA: 0x0003DA3C File Offset: 0x0003BC3C
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
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

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x060011DB RID: 4571 RVA: 0x0003DA60 File Offset: 0x0003BC60
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x060011DC RID: 4572 RVA: 0x0003DA84 File Offset: 0x0003BC84
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

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x060011DD RID: 4573 RVA: 0x0003DAA8 File Offset: 0x0003BCA8
		// (set) Token: 0x060011DE RID: 4574 RVA: 0x0003DACC File Offset: 0x0003BCCC
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

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x060011DF RID: 4575 RVA: 0x0003DAF4 File Offset: 0x0003BCF4
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

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x060011E0 RID: 4576 RVA: 0x0003DB18 File Offset: 0x0003BD18
		// (set) Token: 0x060011E1 RID: 4577 RVA: 0x0003DB3C File Offset: 0x0003BD3C
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

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x060011E2 RID: 4578 RVA: 0x0003DB64 File Offset: 0x0003BD64
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

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x060011E3 RID: 4579 RVA: 0x0003DB88 File Offset: 0x0003BD88
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

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x060011E4 RID: 4580 RVA: 0x0003DBAC File Offset: 0x0003BDAC
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

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x060011E5 RID: 4581 RVA: 0x0003DBD0 File Offset: 0x0003BDD0
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
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

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x060011E6 RID: 4582 RVA: 0x0003DBF4 File Offset: 0x0003BDF4
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(504)]
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

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x060011E7 RID: 4583 RVA: 0x0003DC18 File Offset: 0x0003BE18
		[DispId(505)]
		[Browsable(false)]
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

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x060011E8 RID: 4584 RVA: 0x0003DC3C File Offset: 0x0003BE3C
		[DispId(507)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x060011E9 RID: 4585 RVA: 0x0003DC60 File Offset: 0x0003BE60
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

		// Token: 0x140001A9 RID: 425
		// (add) Token: 0x060011EA RID: 4586 RVA: 0x0003DC84 File Offset: 0x0003BE84
		// (remove) Token: 0x060011EB RID: 4587 RVA: 0x0003DCC0 File Offset: 0x0003BEC0
		public event EventHandler OnConnecting;

		// Token: 0x140001AA RID: 426
		// (add) Token: 0x060011EC RID: 4588 RVA: 0x0003DCFC File Offset: 0x0003BEFC
		// (remove) Token: 0x060011ED RID: 4589 RVA: 0x0003DD38 File Offset: 0x0003BF38
		public event EventHandler OnConnected;

		// Token: 0x140001AB RID: 427
		// (add) Token: 0x060011EE RID: 4590 RVA: 0x0003DD74 File Offset: 0x0003BF74
		// (remove) Token: 0x060011EF RID: 4591 RVA: 0x0003DDB0 File Offset: 0x0003BFB0
		public event EventHandler OnLoginComplete;

		// Token: 0x140001AC RID: 428
		// (add) Token: 0x060011F0 RID: 4592 RVA: 0x0003DDEC File Offset: 0x0003BFEC
		// (remove) Token: 0x060011F1 RID: 4593 RVA: 0x0003DE28 File Offset: 0x0003C028
		public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x140001AD RID: 429
		// (add) Token: 0x060011F2 RID: 4594 RVA: 0x0003DE64 File Offset: 0x0003C064
		// (remove) Token: 0x060011F3 RID: 4595 RVA: 0x0003DEA0 File Offset: 0x0003C0A0
		public event EventHandler OnEnterFullScreenMode;

		// Token: 0x140001AE RID: 430
		// (add) Token: 0x060011F4 RID: 4596 RVA: 0x0003DEDC File Offset: 0x0003C0DC
		// (remove) Token: 0x060011F5 RID: 4597 RVA: 0x0003DF18 File Offset: 0x0003C118
		public event EventHandler OnLeaveFullScreenMode;

		// Token: 0x140001AF RID: 431
		// (add) Token: 0x060011F6 RID: 4598 RVA: 0x0003DF54 File Offset: 0x0003C154
		// (remove) Token: 0x060011F7 RID: 4599 RVA: 0x0003DF90 File Offset: 0x0003C190
		public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x140001B0 RID: 432
		// (add) Token: 0x060011F8 RID: 4600 RVA: 0x0003DFCC File Offset: 0x0003C1CC
		// (remove) Token: 0x060011F9 RID: 4601 RVA: 0x0003E008 File Offset: 0x0003C208
		public event EventHandler OnRequestGoFullScreen;

		// Token: 0x140001B1 RID: 433
		// (add) Token: 0x060011FA RID: 4602 RVA: 0x0003E044 File Offset: 0x0003C244
		// (remove) Token: 0x060011FB RID: 4603 RVA: 0x0003E080 File Offset: 0x0003C280
		public event EventHandler OnRequestLeaveFullScreen;

		// Token: 0x140001B2 RID: 434
		// (add) Token: 0x060011FC RID: 4604 RVA: 0x0003E0BC File Offset: 0x0003C2BC
		// (remove) Token: 0x060011FD RID: 4605 RVA: 0x0003E0F8 File Offset: 0x0003C2F8
		public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x140001B3 RID: 435
		// (add) Token: 0x060011FE RID: 4606 RVA: 0x0003E134 File Offset: 0x0003C334
		// (remove) Token: 0x060011FF RID: 4607 RVA: 0x0003E170 File Offset: 0x0003C370
		public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x140001B4 RID: 436
		// (add) Token: 0x06001200 RID: 4608 RVA: 0x0003E1AC File Offset: 0x0003C3AC
		// (remove) Token: 0x06001201 RID: 4609 RVA: 0x0003E1E8 File Offset: 0x0003C3E8
		public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x140001B5 RID: 437
		// (add) Token: 0x06001202 RID: 4610 RVA: 0x0003E224 File Offset: 0x0003C424
		// (remove) Token: 0x06001203 RID: 4611 RVA: 0x0003E260 File Offset: 0x0003C460
		public event EventHandler OnIdleTimeoutNotification;

		// Token: 0x140001B6 RID: 438
		// (add) Token: 0x06001204 RID: 4612 RVA: 0x0003E29C File Offset: 0x0003C49C
		// (remove) Token: 0x06001205 RID: 4613 RVA: 0x0003E2D8 File Offset: 0x0003C4D8
		public event EventHandler OnRequestContainerMinimize;

		// Token: 0x140001B7 RID: 439
		// (add) Token: 0x06001206 RID: 4614 RVA: 0x0003E314 File Offset: 0x0003C514
		// (remove) Token: 0x06001207 RID: 4615 RVA: 0x0003E350 File Offset: 0x0003C550
		public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x140001B8 RID: 440
		// (add) Token: 0x06001208 RID: 4616 RVA: 0x0003E38C File Offset: 0x0003C58C
		// (remove) Token: 0x06001209 RID: 4617 RVA: 0x0003E3C8 File Offset: 0x0003C5C8
		public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x140001B9 RID: 441
		// (add) Token: 0x0600120A RID: 4618 RVA: 0x0003E404 File Offset: 0x0003C604
		// (remove) Token: 0x0600120B RID: 4619 RVA: 0x0003E440 File Offset: 0x0003C640
		public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x140001BA RID: 442
		// (add) Token: 0x0600120C RID: 4620 RVA: 0x0003E47C File Offset: 0x0003C67C
		// (remove) Token: 0x0600120D RID: 4621 RVA: 0x0003E4B8 File Offset: 0x0003C6B8
		public event EventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x140001BB RID: 443
		// (add) Token: 0x0600120E RID: 4622 RVA: 0x0003E4F4 File Offset: 0x0003C6F4
		// (remove) Token: 0x0600120F RID: 4623 RVA: 0x0003E530 File Offset: 0x0003C730
		public event EventHandler OnAuthenticationWarningDismissed;

		// Token: 0x140001BC RID: 444
		// (add) Token: 0x06001210 RID: 4624 RVA: 0x0003E56C File Offset: 0x0003C76C
		// (remove) Token: 0x06001211 RID: 4625 RVA: 0x0003E5A8 File Offset: 0x0003C7A8
		public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x140001BD RID: 445
		// (add) Token: 0x06001212 RID: 4626 RVA: 0x0003E5E4 File Offset: 0x0003C7E4
		// (remove) Token: 0x06001213 RID: 4627 RVA: 0x0003E620 File Offset: 0x0003C820
		public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x140001BE RID: 446
		// (add) Token: 0x06001214 RID: 4628 RVA: 0x0003E65C File Offset: 0x0003C85C
		// (remove) Token: 0x06001215 RID: 4629 RVA: 0x0003E698 File Offset: 0x0003C898
		public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x140001BF RID: 447
		// (add) Token: 0x06001216 RID: 4630 RVA: 0x0003E6D4 File Offset: 0x0003C8D4
		// (remove) Token: 0x06001217 RID: 4631 RVA: 0x0003E710 File Offset: 0x0003C910
		public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x140001C0 RID: 448
		// (add) Token: 0x06001218 RID: 4632 RVA: 0x0003E74C File Offset: 0x0003C94C
		// (remove) Token: 0x06001219 RID: 4633 RVA: 0x0003E788 File Offset: 0x0003C988
		public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x140001C1 RID: 449
		// (add) Token: 0x0600121A RID: 4634 RVA: 0x0003E7C4 File Offset: 0x0003C9C4
		// (remove) Token: 0x0600121B RID: 4635 RVA: 0x0003E800 File Offset: 0x0003CA00
		public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x140001C2 RID: 450
		// (add) Token: 0x0600121C RID: 4636 RVA: 0x0003E83C File Offset: 0x0003CA3C
		// (remove) Token: 0x0600121D RID: 4637 RVA: 0x0003E878 File Offset: 0x0003CA78
		public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x140001C3 RID: 451
		// (add) Token: 0x0600121E RID: 4638 RVA: 0x0003E8B4 File Offset: 0x0003CAB4
		// (remove) Token: 0x0600121F RID: 4639 RVA: 0x0003E8F0 File Offset: 0x0003CAF0
		public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x140001C4 RID: 452
		// (add) Token: 0x06001220 RID: 4640 RVA: 0x0003E92C File Offset: 0x0003CB2C
		// (remove) Token: 0x06001221 RID: 4641 RVA: 0x0003E968 File Offset: 0x0003CB68
		public event EventHandler OnConnectionBarPullDown;

		// Token: 0x140001C5 RID: 453
		// (add) Token: 0x06001222 RID: 4642 RVA: 0x0003E9A4 File Offset: 0x0003CBA4
		// (remove) Token: 0x06001223 RID: 4643 RVA: 0x0003E9E0 File Offset: 0x0003CBE0
		public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x140001C6 RID: 454
		// (add) Token: 0x06001224 RID: 4644 RVA: 0x0003EA1C File Offset: 0x0003CC1C
		// (remove) Token: 0x06001225 RID: 4645 RVA: 0x0003EA58 File Offset: 0x0003CC58
		public event EventHandler OnDevicesButtonPressed;

		// Token: 0x140001C7 RID: 455
		// (add) Token: 0x06001226 RID: 4646 RVA: 0x0003EA94 File Offset: 0x0003CC94
		// (remove) Token: 0x06001227 RID: 4647 RVA: 0x0003EAD0 File Offset: 0x0003CCD0
		public event EventHandler OnAutoReconnected;

		// Token: 0x140001C8 RID: 456
		// (add) Token: 0x06001228 RID: 4648 RVA: 0x0003EB0C File Offset: 0x0003CD0C
		// (remove) Token: 0x06001229 RID: 4649 RVA: 0x0003EB48 File Offset: 0x0003CD48
		public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

		// Token: 0x0600122A RID: 4650 RVA: 0x0003EB84 File Offset: 0x0003CD84
		public virtual void Connect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Connect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Connect();
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x0003EBA8 File Offset: 0x0003CDA8
		public virtual void Disconnect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Disconnect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Disconnect();
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x0003EBCC File Offset: 0x0003CDCC
		public virtual void CreateVirtualChannels(string newVal)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("CreateVirtualChannels", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.CreateVirtualChannels(newVal);
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x0003EBF4 File Offset: 0x0003CDF4
		public virtual void SendOnVirtualChannel(string chanName, string chanData)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SendOnVirtualChannel", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SendOnVirtualChannel(chanName, chanData);
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x0003EC1C File Offset: 0x0003CE1C
		public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SetVirtualChannelOptions(chanName, chanOptions);
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x0003EC44 File Offset: 0x0003CE44
		public virtual int GetVirtualChannelOptions(string chanName)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetVirtualChannelOptions(chanName);
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x0003EC7C File Offset: 0x0003CE7C
		public virtual ControlCloseStatus RequestClose()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("RequestClose", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.RequestClose();
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x0003ECB4 File Offset: 0x0003CEB4
		public virtual string GetErrorDescription(uint disconnectReason, uint extendedDisconnectReason)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetErrorDescription", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetErrorDescription(disconnectReason, extendedDisconnectReason);
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x0003ECEC File Offset: 0x0003CEEC
		protected override void CreateSink()
		{
			try
			{
				this.eventMulticaster = new AxMsRdpClient6NotSafeForScriptingEventMulticaster(this);
				this.cookie = new AxHost.ConnectionPointCookie(this.ocx, this.eventMulticaster, typeof(IMsTscAxEvents));
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x0003ED44 File Offset: 0x0003CF44
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

		// Token: 0x06001234 RID: 4660 RVA: 0x0003ED78 File Offset: 0x0003CF78
		protected override void AttachInterfaces()
		{
			try
			{
				this.ocx = (IMsRdpClient6)base.GetOcx();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x0003EDB4 File Offset: 0x0003CFB4
		internal void RaiseOnOnConnecting(object sender, EventArgs e)
		{
			if (this.OnConnecting != null)
			{
				this.OnConnecting(sender, e);
			}
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x0003EDD0 File Offset: 0x0003CFD0
		internal void RaiseOnOnConnected(object sender, EventArgs e)
		{
			if (this.OnConnected != null)
			{
				this.OnConnected(sender, e);
			}
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x0003EDEC File Offset: 0x0003CFEC
		internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
		{
			if (this.OnLoginComplete != null)
			{
				this.OnLoginComplete(sender, e);
			}
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x0003EE08 File Offset: 0x0003D008
		internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
		{
			if (this.OnDisconnected != null)
			{
				this.OnDisconnected(sender, e);
			}
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x0003EE24 File Offset: 0x0003D024
		internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnEnterFullScreenMode != null)
			{
				this.OnEnterFullScreenMode(sender, e);
			}
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x0003EE40 File Offset: 0x0003D040
		internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnLeaveFullScreenMode != null)
			{
				this.OnLeaveFullScreenMode(sender, e);
			}
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x0003EE5C File Offset: 0x0003D05C
		internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
		{
			if (this.OnChannelReceivedData != null)
			{
				this.OnChannelReceivedData(sender, e);
			}
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x0003EE78 File Offset: 0x0003D078
		internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestGoFullScreen != null)
			{
				this.OnRequestGoFullScreen(sender, e);
			}
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x0003EE94 File Offset: 0x0003D094
		internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestLeaveFullScreen != null)
			{
				this.OnRequestLeaveFullScreen(sender, e);
			}
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x0003EEB0 File Offset: 0x0003D0B0
		internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
		{
			if (this.OnFatalError != null)
			{
				this.OnFatalError(sender, e);
			}
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x0003EECC File Offset: 0x0003D0CC
		internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
		{
			if (this.OnWarning != null)
			{
				this.OnWarning(sender, e);
			}
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x0003EEE8 File Offset: 0x0003D0E8
		internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
		{
			if (this.OnRemoteDesktopSizeChange != null)
			{
				this.OnRemoteDesktopSizeChange(sender, e);
			}
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x0003EF04 File Offset: 0x0003D104
		internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
		{
			if (this.OnIdleTimeoutNotification != null)
			{
				this.OnIdleTimeoutNotification(sender, e);
			}
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x0003EF20 File Offset: 0x0003D120
		internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
		{
			if (this.OnRequestContainerMinimize != null)
			{
				this.OnRequestContainerMinimize(sender, e);
			}
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x0003EF3C File Offset: 0x0003D13C
		internal void RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
		{
			if (this.OnConfirmClose != null)
			{
				this.OnConfirmClose(sender, e);
			}
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x0003EF58 File Offset: 0x0003D158
		internal void RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
		{
			if (this.OnReceivedTSPublicKey != null)
			{
				this.OnReceivedTSPublicKey(sender, e);
			}
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x0003EF74 File Offset: 0x0003D174
		internal void RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
		{
			if (this.OnAutoReconnecting != null)
			{
				this.OnAutoReconnecting(sender, e);
			}
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x0003EF90 File Offset: 0x0003D190
		internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDisplayed != null)
			{
				this.OnAuthenticationWarningDisplayed(sender, e);
			}
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x0003EFAC File Offset: 0x0003D1AC
		internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDismissed != null)
			{
				this.OnAuthenticationWarningDismissed(sender, e);
			}
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x0003EFC8 File Offset: 0x0003D1C8
		internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
		{
			if (this.OnRemoteProgramResult != null)
			{
				this.OnRemoteProgramResult(sender, e);
			}
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x0003EFE4 File Offset: 0x0003D1E4
		internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
		{
			if (this.OnRemoteProgramDisplayed != null)
			{
				this.OnRemoteProgramDisplayed(sender, e);
			}
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x0003F000 File Offset: 0x0003D200
		internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
		{
			if (this.OnRemoteWindowDisplayed != null)
			{
				this.OnRemoteWindowDisplayed(sender, e);
			}
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x0003F01C File Offset: 0x0003D21C
		internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
		{
			if (this.OnLogonError != null)
			{
				this.OnLogonError(sender, e);
			}
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x0003F038 File Offset: 0x0003D238
		internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
		{
			if (this.OnFocusReleased != null)
			{
				this.OnFocusReleased(sender, e);
			}
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x0003F054 File Offset: 0x0003D254
		internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
		{
			if (this.OnUserNameAcquired != null)
			{
				this.OnUserNameAcquired(sender, e);
			}
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x0003F070 File Offset: 0x0003D270
		internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
		{
			if (this.OnMouseInputModeChanged != null)
			{
				this.OnMouseInputModeChanged(sender, e);
			}
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x0003F08C File Offset: 0x0003D28C
		internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
		{
			if (this.OnServiceMessageReceived != null)
			{
				this.OnServiceMessageReceived(sender, e);
			}
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x0003F0A8 File Offset: 0x0003D2A8
		internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
		{
			if (this.OnConnectionBarPullDown != null)
			{
				this.OnConnectionBarPullDown(sender, e);
			}
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x0003F0C4 File Offset: 0x0003D2C4
		internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
		{
			if (this.OnNetworkStatusChanged != null)
			{
				this.OnNetworkStatusChanged(sender, e);
			}
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x0003F0E0 File Offset: 0x0003D2E0
		internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
		{
			if (this.OnDevicesButtonPressed != null)
			{
				this.OnDevicesButtonPressed(sender, e);
			}
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x0003F0FC File Offset: 0x0003D2FC
		internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
		{
			if (this.OnAutoReconnected != null)
			{
				this.OnAutoReconnected(sender, e);
			}
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x0003F118 File Offset: 0x0003D318
		internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
		{
			if (this.OnAutoReconnecting2 != null)
			{
				this.OnAutoReconnecting2(sender, e);
			}
		}

		// Token: 0x0400055F RID: 1375
		private IMsRdpClient6 ocx;

		// Token: 0x04000560 RID: 1376
		private AxMsRdpClient6NotSafeForScriptingEventMulticaster eventMulticaster;

		// Token: 0x04000561 RID: 1377
		private AxHost.ConnectionPointCookie cookie;
	}
}
