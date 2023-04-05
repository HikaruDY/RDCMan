using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MSTSCLib;

namespace AxMSTSCLib
{
	// Token: 0x0200013C RID: 316
	[DefaultEvent("OnConnecting")]
	[AxHost.ClsidAttribute("{8b918b82-7985-4c24-89df-c33ad2bbfbcd}")]
	[DesignTimeVisible(true)]
	[ComVisible(true)]
	public class AxMsRdpClient9NotSafeForScripting : AxHost
	{
		// Token: 0x0600162D RID: 5677 RVA: 0x00049F7C File Offset: 0x0004817C
		public AxMsRdpClient9NotSafeForScripting() : base("8b918b82-7985-4c24-89df-c33ad2bbfbcd")
		{
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x0600162E RID: 5678 RVA: 0x00049F8C File Offset: 0x0004818C
		// (set) Token: 0x0600162F RID: 5679 RVA: 0x00049FB0 File Offset: 0x000481B0
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

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06001630 RID: 5680 RVA: 0x00049FD8 File Offset: 0x000481D8
		// (set) Token: 0x06001631 RID: 5681 RVA: 0x00049FFC File Offset: 0x000481FC
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

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06001632 RID: 5682 RVA: 0x0004A024 File Offset: 0x00048224
		// (set) Token: 0x06001633 RID: 5683 RVA: 0x0004A048 File Offset: 0x00048248
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

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06001634 RID: 5684 RVA: 0x0004A070 File Offset: 0x00048270
		// (set) Token: 0x06001635 RID: 5685 RVA: 0x0004A094 File Offset: 0x00048294
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

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06001636 RID: 5686 RVA: 0x0004A0BC File Offset: 0x000482BC
		// (set) Token: 0x06001637 RID: 5687 RVA: 0x0004A0E0 File Offset: 0x000482E0
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

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06001638 RID: 5688 RVA: 0x0004A108 File Offset: 0x00048308
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

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06001639 RID: 5689 RVA: 0x0004A12C File Offset: 0x0004832C
		// (set) Token: 0x0600163A RID: 5690 RVA: 0x0004A150 File Offset: 0x00048350
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

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x0600163B RID: 5691 RVA: 0x0004A178 File Offset: 0x00048378
		// (set) Token: 0x0600163C RID: 5692 RVA: 0x0004A19C File Offset: 0x0004839C
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

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x0600163D RID: 5693 RVA: 0x0004A1C4 File Offset: 0x000483C4
		// (set) Token: 0x0600163E RID: 5694 RVA: 0x0004A1E8 File Offset: 0x000483E8
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

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x0600163F RID: 5695 RVA: 0x0004A210 File Offset: 0x00048410
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

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06001640 RID: 5696 RVA: 0x0004A234 File Offset: 0x00048434
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

		// Token: 0x17000405 RID: 1029
		// (set) Token: 0x06001641 RID: 5697 RVA: 0x0004A258 File Offset: 0x00048458
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

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06001642 RID: 5698 RVA: 0x0004A280 File Offset: 0x00048480
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

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06001643 RID: 5699 RVA: 0x0004A2A4 File Offset: 0x000484A4
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

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06001644 RID: 5700 RVA: 0x0004A2C8 File Offset: 0x000484C8
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

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06001645 RID: 5701 RVA: 0x0004A2EC File Offset: 0x000484EC
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

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06001646 RID: 5702 RVA: 0x0004A310 File Offset: 0x00048510
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

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06001647 RID: 5703 RVA: 0x0004A334 File Offset: 0x00048534
		[Browsable(false)]
		[DispId(99)]
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

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06001648 RID: 5704 RVA: 0x0004A358 File Offset: 0x00048558
		// (set) Token: 0x06001649 RID: 5705 RVA: 0x0004A37C File Offset: 0x0004857C
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

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x0600164A RID: 5706 RVA: 0x0004A3A4 File Offset: 0x000485A4
		[DispId(101)]
		[Browsable(false)]
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

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x0600164B RID: 5707 RVA: 0x0004A3C8 File Offset: 0x000485C8
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

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x0600164C RID: 5708 RVA: 0x0004A3EC File Offset: 0x000485EC
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

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x0600164D RID: 5709 RVA: 0x0004A410 File Offset: 0x00048610
		// (set) Token: 0x0600164E RID: 5710 RVA: 0x0004A434 File Offset: 0x00048634
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

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x0600164F RID: 5711 RVA: 0x0004A45C File Offset: 0x0004865C
		[DispId(200)]
		[Browsable(false)]
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

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06001650 RID: 5712 RVA: 0x0004A480 File Offset: 0x00048680
		// (set) Token: 0x06001651 RID: 5713 RVA: 0x0004A4A4 File Offset: 0x000486A4
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

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06001652 RID: 5714 RVA: 0x0004A4CC File Offset: 0x000486CC
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

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06001653 RID: 5715 RVA: 0x0004A4F0 File Offset: 0x000486F0
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

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06001654 RID: 5716 RVA: 0x0004A514 File Offset: 0x00048714
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

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06001655 RID: 5717 RVA: 0x0004A538 File Offset: 0x00048738
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

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06001656 RID: 5718 RVA: 0x0004A55C File Offset: 0x0004875C
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

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06001657 RID: 5719 RVA: 0x0004A580 File Offset: 0x00048780
		[DispId(505)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06001658 RID: 5720 RVA: 0x0004A5A4 File Offset: 0x000487A4
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

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06001659 RID: 5721 RVA: 0x0004A5C8 File Offset: 0x000487C8
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

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x0600165A RID: 5722 RVA: 0x0004A5EC File Offset: 0x000487EC
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

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x0600165B RID: 5723 RVA: 0x0004A610 File Offset: 0x00048810
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(601)]
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

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x0600165C RID: 5724 RVA: 0x0004A634 File Offset: 0x00048834
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

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x0600165D RID: 5725 RVA: 0x0004A658 File Offset: 0x00048858
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

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x0600165E RID: 5726 RVA: 0x0004A67C File Offset: 0x0004887C
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

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x0600165F RID: 5727 RVA: 0x0004A6A0 File Offset: 0x000488A0
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

		// Token: 0x14000269 RID: 617
		// (add) Token: 0x06001660 RID: 5728 RVA: 0x0004A6C4 File Offset: 0x000488C4
		// (remove) Token: 0x06001661 RID: 5729 RVA: 0x0004A700 File Offset: 0x00048900
		public event EventHandler OnConnecting;

		// Token: 0x1400026A RID: 618
		// (add) Token: 0x06001662 RID: 5730 RVA: 0x0004A73C File Offset: 0x0004893C
		// (remove) Token: 0x06001663 RID: 5731 RVA: 0x0004A778 File Offset: 0x00048978
		public event EventHandler OnConnected;

		// Token: 0x1400026B RID: 619
		// (add) Token: 0x06001664 RID: 5732 RVA: 0x0004A7B4 File Offset: 0x000489B4
		// (remove) Token: 0x06001665 RID: 5733 RVA: 0x0004A7F0 File Offset: 0x000489F0
		public event EventHandler OnLoginComplete;

		// Token: 0x1400026C RID: 620
		// (add) Token: 0x06001666 RID: 5734 RVA: 0x0004A82C File Offset: 0x00048A2C
		// (remove) Token: 0x06001667 RID: 5735 RVA: 0x0004A868 File Offset: 0x00048A68
		public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x1400026D RID: 621
		// (add) Token: 0x06001668 RID: 5736 RVA: 0x0004A8A4 File Offset: 0x00048AA4
		// (remove) Token: 0x06001669 RID: 5737 RVA: 0x0004A8E0 File Offset: 0x00048AE0
		public event EventHandler OnEnterFullScreenMode;

		// Token: 0x1400026E RID: 622
		// (add) Token: 0x0600166A RID: 5738 RVA: 0x0004A91C File Offset: 0x00048B1C
		// (remove) Token: 0x0600166B RID: 5739 RVA: 0x0004A958 File Offset: 0x00048B58
		public event EventHandler OnLeaveFullScreenMode;

		// Token: 0x1400026F RID: 623
		// (add) Token: 0x0600166C RID: 5740 RVA: 0x0004A994 File Offset: 0x00048B94
		// (remove) Token: 0x0600166D RID: 5741 RVA: 0x0004A9D0 File Offset: 0x00048BD0
		public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x14000270 RID: 624
		// (add) Token: 0x0600166E RID: 5742 RVA: 0x0004AA0C File Offset: 0x00048C0C
		// (remove) Token: 0x0600166F RID: 5743 RVA: 0x0004AA48 File Offset: 0x00048C48
		public event EventHandler OnRequestGoFullScreen;

		// Token: 0x14000271 RID: 625
		// (add) Token: 0x06001670 RID: 5744 RVA: 0x0004AA84 File Offset: 0x00048C84
		// (remove) Token: 0x06001671 RID: 5745 RVA: 0x0004AAC0 File Offset: 0x00048CC0
		public event EventHandler OnRequestLeaveFullScreen;

		// Token: 0x14000272 RID: 626
		// (add) Token: 0x06001672 RID: 5746 RVA: 0x0004AAFC File Offset: 0x00048CFC
		// (remove) Token: 0x06001673 RID: 5747 RVA: 0x0004AB38 File Offset: 0x00048D38
		public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x14000273 RID: 627
		// (add) Token: 0x06001674 RID: 5748 RVA: 0x0004AB74 File Offset: 0x00048D74
		// (remove) Token: 0x06001675 RID: 5749 RVA: 0x0004ABB0 File Offset: 0x00048DB0
		public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x14000274 RID: 628
		// (add) Token: 0x06001676 RID: 5750 RVA: 0x0004ABEC File Offset: 0x00048DEC
		// (remove) Token: 0x06001677 RID: 5751 RVA: 0x0004AC28 File Offset: 0x00048E28
		public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x14000275 RID: 629
		// (add) Token: 0x06001678 RID: 5752 RVA: 0x0004AC64 File Offset: 0x00048E64
		// (remove) Token: 0x06001679 RID: 5753 RVA: 0x0004ACA0 File Offset: 0x00048EA0
		public event EventHandler OnIdleTimeoutNotification;

		// Token: 0x14000276 RID: 630
		// (add) Token: 0x0600167A RID: 5754 RVA: 0x0004ACDC File Offset: 0x00048EDC
		// (remove) Token: 0x0600167B RID: 5755 RVA: 0x0004AD18 File Offset: 0x00048F18
		public event EventHandler OnRequestContainerMinimize;

		// Token: 0x14000277 RID: 631
		// (add) Token: 0x0600167C RID: 5756 RVA: 0x0004AD54 File Offset: 0x00048F54
		// (remove) Token: 0x0600167D RID: 5757 RVA: 0x0004AD90 File Offset: 0x00048F90
		public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x14000278 RID: 632
		// (add) Token: 0x0600167E RID: 5758 RVA: 0x0004ADCC File Offset: 0x00048FCC
		// (remove) Token: 0x0600167F RID: 5759 RVA: 0x0004AE08 File Offset: 0x00049008
		public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x14000279 RID: 633
		// (add) Token: 0x06001680 RID: 5760 RVA: 0x0004AE44 File Offset: 0x00049044
		// (remove) Token: 0x06001681 RID: 5761 RVA: 0x0004AE80 File Offset: 0x00049080
		public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x1400027A RID: 634
		// (add) Token: 0x06001682 RID: 5762 RVA: 0x0004AEBC File Offset: 0x000490BC
		// (remove) Token: 0x06001683 RID: 5763 RVA: 0x0004AEF8 File Offset: 0x000490F8
		public event EventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x1400027B RID: 635
		// (add) Token: 0x06001684 RID: 5764 RVA: 0x0004AF34 File Offset: 0x00049134
		// (remove) Token: 0x06001685 RID: 5765 RVA: 0x0004AF70 File Offset: 0x00049170
		public event EventHandler OnAuthenticationWarningDismissed;

		// Token: 0x1400027C RID: 636
		// (add) Token: 0x06001686 RID: 5766 RVA: 0x0004AFAC File Offset: 0x000491AC
		// (remove) Token: 0x06001687 RID: 5767 RVA: 0x0004AFE8 File Offset: 0x000491E8
		public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x1400027D RID: 637
		// (add) Token: 0x06001688 RID: 5768 RVA: 0x0004B024 File Offset: 0x00049224
		// (remove) Token: 0x06001689 RID: 5769 RVA: 0x0004B060 File Offset: 0x00049260
		public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x1400027E RID: 638
		// (add) Token: 0x0600168A RID: 5770 RVA: 0x0004B09C File Offset: 0x0004929C
		// (remove) Token: 0x0600168B RID: 5771 RVA: 0x0004B0D8 File Offset: 0x000492D8
		public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x1400027F RID: 639
		// (add) Token: 0x0600168C RID: 5772 RVA: 0x0004B114 File Offset: 0x00049314
		// (remove) Token: 0x0600168D RID: 5773 RVA: 0x0004B150 File Offset: 0x00049350
		public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x14000280 RID: 640
		// (add) Token: 0x0600168E RID: 5774 RVA: 0x0004B18C File Offset: 0x0004938C
		// (remove) Token: 0x0600168F RID: 5775 RVA: 0x0004B1C8 File Offset: 0x000493C8
		public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x14000281 RID: 641
		// (add) Token: 0x06001690 RID: 5776 RVA: 0x0004B204 File Offset: 0x00049404
		// (remove) Token: 0x06001691 RID: 5777 RVA: 0x0004B240 File Offset: 0x00049440
		public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x14000282 RID: 642
		// (add) Token: 0x06001692 RID: 5778 RVA: 0x0004B27C File Offset: 0x0004947C
		// (remove) Token: 0x06001693 RID: 5779 RVA: 0x0004B2B8 File Offset: 0x000494B8
		public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x14000283 RID: 643
		// (add) Token: 0x06001694 RID: 5780 RVA: 0x0004B2F4 File Offset: 0x000494F4
		// (remove) Token: 0x06001695 RID: 5781 RVA: 0x0004B330 File Offset: 0x00049530
		public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x14000284 RID: 644
		// (add) Token: 0x06001696 RID: 5782 RVA: 0x0004B36C File Offset: 0x0004956C
		// (remove) Token: 0x06001697 RID: 5783 RVA: 0x0004B3A8 File Offset: 0x000495A8
		public event EventHandler OnConnectionBarPullDown;

		// Token: 0x14000285 RID: 645
		// (add) Token: 0x06001698 RID: 5784 RVA: 0x0004B3E4 File Offset: 0x000495E4
		// (remove) Token: 0x06001699 RID: 5785 RVA: 0x0004B420 File Offset: 0x00049620
		public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x14000286 RID: 646
		// (add) Token: 0x0600169A RID: 5786 RVA: 0x0004B45C File Offset: 0x0004965C
		// (remove) Token: 0x0600169B RID: 5787 RVA: 0x0004B498 File Offset: 0x00049698
		public event EventHandler OnDevicesButtonPressed;

		// Token: 0x14000287 RID: 647
		// (add) Token: 0x0600169C RID: 5788 RVA: 0x0004B4D4 File Offset: 0x000496D4
		// (remove) Token: 0x0600169D RID: 5789 RVA: 0x0004B510 File Offset: 0x00049710
		public event EventHandler OnAutoReconnected;

		// Token: 0x14000288 RID: 648
		// (add) Token: 0x0600169E RID: 5790 RVA: 0x0004B54C File Offset: 0x0004974C
		// (remove) Token: 0x0600169F RID: 5791 RVA: 0x0004B588 File Offset: 0x00049788
		public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

		// Token: 0x060016A0 RID: 5792 RVA: 0x0004B5C4 File Offset: 0x000497C4
		public virtual void Connect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Connect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Connect();
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x0004B5E8 File Offset: 0x000497E8
		public virtual void Disconnect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Disconnect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Disconnect();
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x0004B60C File Offset: 0x0004980C
		public virtual void CreateVirtualChannels(string newVal)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("CreateVirtualChannels", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.CreateVirtualChannels(newVal);
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x0004B634 File Offset: 0x00049834
		public virtual void SendOnVirtualChannel(string chanName, string chanData)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SendOnVirtualChannel", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SendOnVirtualChannel(chanName, chanData);
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x0004B65C File Offset: 0x0004985C
		public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SetVirtualChannelOptions(chanName, chanOptions);
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x0004B684 File Offset: 0x00049884
		public virtual int GetVirtualChannelOptions(string chanName)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetVirtualChannelOptions(chanName);
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x0004B6BC File Offset: 0x000498BC
		public virtual ControlCloseStatus RequestClose()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("RequestClose", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.RequestClose();
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x0004B6F4 File Offset: 0x000498F4
		public virtual string GetErrorDescription(uint disconnectReason, uint extendedDisconnectReason)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetErrorDescription", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetErrorDescription(disconnectReason, extendedDisconnectReason);
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x0004B72C File Offset: 0x0004992C
		public virtual string GetStatusText(uint statusCode)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetStatusText", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetStatusText(statusCode);
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x0004B764 File Offset: 0x00049964
		public virtual void SendRemoteAction(RemoteSessionActionType actionType)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SendRemoteAction", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SendRemoteAction(actionType);
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x0004B78C File Offset: 0x0004998C
		public virtual ControlReconnectStatus Reconnect(uint ulWidth, uint ulHeight)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Reconnect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.Reconnect(ulWidth, ulHeight);
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x0004B7C4 File Offset: 0x000499C4
		public virtual void SyncSessionDisplaySettings()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SyncSessionDisplaySettings", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SyncSessionDisplaySettings();
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x0004B7E8 File Offset: 0x000499E8
		public virtual void UpdateSessionDisplaySettings(uint ulDesktopWidth, uint ulDesktopHeight, uint ulPhysicalWidth, uint ulPhysicalHeight, uint ulOrientation, uint ulDesktopScaleFactor, uint ulDeviceScaleFactor)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("UpdateSessionDisplaySettings", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.UpdateSessionDisplaySettings(ulDesktopWidth, ulDesktopHeight, ulPhysicalWidth, ulPhysicalHeight, ulOrientation, ulDesktopScaleFactor, ulDeviceScaleFactor);
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x0004B828 File Offset: 0x00049A28
		public virtual void attachEvent(string eventName, object callback)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("attachEvent", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.attachEvent(eventName, callback);
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x0004B850 File Offset: 0x00049A50
		public virtual void detachEvent(string eventName, object callback)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("detachEvent", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.detachEvent(eventName, callback);
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x0004B878 File Offset: 0x00049A78
		protected override void CreateSink()
		{
			try
			{
				this.eventMulticaster = new AxMsRdpClient9NotSafeForScriptingEventMulticaster(this);
				this.cookie = new AxHost.ConnectionPointCookie(this.ocx, this.eventMulticaster, typeof(IMsTscAxEvents));
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x0004B8D0 File Offset: 0x00049AD0
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

		// Token: 0x060016B1 RID: 5809 RVA: 0x0004B904 File Offset: 0x00049B04
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

		// Token: 0x060016B2 RID: 5810 RVA: 0x0004B940 File Offset: 0x00049B40
		internal void RaiseOnOnConnecting(object sender, EventArgs e)
		{
			if (this.OnConnecting != null)
			{
				this.OnConnecting(sender, e);
			}
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x0004B95C File Offset: 0x00049B5C
		internal void RaiseOnOnConnected(object sender, EventArgs e)
		{
			if (this.OnConnected != null)
			{
				this.OnConnected(sender, e);
			}
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x0004B978 File Offset: 0x00049B78
		internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
		{
			if (this.OnLoginComplete != null)
			{
				this.OnLoginComplete(sender, e);
			}
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x0004B994 File Offset: 0x00049B94
		internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
		{
			if (this.OnDisconnected != null)
			{
				this.OnDisconnected(sender, e);
			}
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x0004B9B0 File Offset: 0x00049BB0
		internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnEnterFullScreenMode != null)
			{
				this.OnEnterFullScreenMode(sender, e);
			}
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x0004B9CC File Offset: 0x00049BCC
		internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnLeaveFullScreenMode != null)
			{
				this.OnLeaveFullScreenMode(sender, e);
			}
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x0004B9E8 File Offset: 0x00049BE8
		internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
		{
			if (this.OnChannelReceivedData != null)
			{
				this.OnChannelReceivedData(sender, e);
			}
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x0004BA04 File Offset: 0x00049C04
		internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestGoFullScreen != null)
			{
				this.OnRequestGoFullScreen(sender, e);
			}
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x0004BA20 File Offset: 0x00049C20
		internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestLeaveFullScreen != null)
			{
				this.OnRequestLeaveFullScreen(sender, e);
			}
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x0004BA3C File Offset: 0x00049C3C
		internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
		{
			if (this.OnFatalError != null)
			{
				this.OnFatalError(sender, e);
			}
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x0004BA58 File Offset: 0x00049C58
		internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
		{
			if (this.OnWarning != null)
			{
				this.OnWarning(sender, e);
			}
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x0004BA74 File Offset: 0x00049C74
		internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
		{
			if (this.OnRemoteDesktopSizeChange != null)
			{
				this.OnRemoteDesktopSizeChange(sender, e);
			}
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x0004BA90 File Offset: 0x00049C90
		internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
		{
			if (this.OnIdleTimeoutNotification != null)
			{
				this.OnIdleTimeoutNotification(sender, e);
			}
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x0004BAAC File Offset: 0x00049CAC
		internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
		{
			if (this.OnRequestContainerMinimize != null)
			{
				this.OnRequestContainerMinimize(sender, e);
			}
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x0004BAC8 File Offset: 0x00049CC8
		internal void RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
		{
			if (this.OnConfirmClose != null)
			{
				this.OnConfirmClose(sender, e);
			}
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x0004BAE4 File Offset: 0x00049CE4
		internal void RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
		{
			if (this.OnReceivedTSPublicKey != null)
			{
				this.OnReceivedTSPublicKey(sender, e);
			}
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x0004BB00 File Offset: 0x00049D00
		internal void RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
		{
			if (this.OnAutoReconnecting != null)
			{
				this.OnAutoReconnecting(sender, e);
			}
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x0004BB1C File Offset: 0x00049D1C
		internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDisplayed != null)
			{
				this.OnAuthenticationWarningDisplayed(sender, e);
			}
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x0004BB38 File Offset: 0x00049D38
		internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDismissed != null)
			{
				this.OnAuthenticationWarningDismissed(sender, e);
			}
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x0004BB54 File Offset: 0x00049D54
		internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
		{
			if (this.OnRemoteProgramResult != null)
			{
				this.OnRemoteProgramResult(sender, e);
			}
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x0004BB70 File Offset: 0x00049D70
		internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
		{
			if (this.OnRemoteProgramDisplayed != null)
			{
				this.OnRemoteProgramDisplayed(sender, e);
			}
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x0004BB8C File Offset: 0x00049D8C
		internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
		{
			if (this.OnRemoteWindowDisplayed != null)
			{
				this.OnRemoteWindowDisplayed(sender, e);
			}
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x0004BBA8 File Offset: 0x00049DA8
		internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
		{
			if (this.OnLogonError != null)
			{
				this.OnLogonError(sender, e);
			}
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x0004BBC4 File Offset: 0x00049DC4
		internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
		{
			if (this.OnFocusReleased != null)
			{
				this.OnFocusReleased(sender, e);
			}
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x0004BBE0 File Offset: 0x00049DE0
		internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
		{
			if (this.OnUserNameAcquired != null)
			{
				this.OnUserNameAcquired(sender, e);
			}
		}

		// Token: 0x060016CB RID: 5835 RVA: 0x0004BBFC File Offset: 0x00049DFC
		internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
		{
			if (this.OnMouseInputModeChanged != null)
			{
				this.OnMouseInputModeChanged(sender, e);
			}
		}

		// Token: 0x060016CC RID: 5836 RVA: 0x0004BC18 File Offset: 0x00049E18
		internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
		{
			if (this.OnServiceMessageReceived != null)
			{
				this.OnServiceMessageReceived(sender, e);
			}
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x0004BC34 File Offset: 0x00049E34
		internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
		{
			if (this.OnConnectionBarPullDown != null)
			{
				this.OnConnectionBarPullDown(sender, e);
			}
		}

		// Token: 0x060016CE RID: 5838 RVA: 0x0004BC50 File Offset: 0x00049E50
		internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
		{
			if (this.OnNetworkStatusChanged != null)
			{
				this.OnNetworkStatusChanged(sender, e);
			}
		}

		// Token: 0x060016CF RID: 5839 RVA: 0x0004BC6C File Offset: 0x00049E6C
		internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
		{
			if (this.OnDevicesButtonPressed != null)
			{
				this.OnDevicesButtonPressed(sender, e);
			}
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x0004BC88 File Offset: 0x00049E88
		internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
		{
			if (this.OnAutoReconnected != null)
			{
				this.OnAutoReconnected(sender, e);
			}
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x0004BCA4 File Offset: 0x00049EA4
		internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
		{
			if (this.OnAutoReconnecting2 != null)
			{
				this.OnAutoReconnecting2(sender, e);
			}
		}

		// Token: 0x04000637 RID: 1591
		private IMsRdpClient9 ocx;

		// Token: 0x04000638 RID: 1592
		private AxMsRdpClient9NotSafeForScriptingEventMulticaster eventMulticaster;

		// Token: 0x04000639 RID: 1593
		private AxHost.ConnectionPointCookie cookie;
	}
}
