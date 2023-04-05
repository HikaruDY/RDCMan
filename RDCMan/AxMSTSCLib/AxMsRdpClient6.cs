using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MSTSCLib;

namespace AxMSTSCLib
{
	// Token: 0x02000132 RID: 306
	[AxHost.ClsidAttribute("{7390f3d8-0439-4c05-91e3-cf5cb290c3d0}")]
	[DesignTimeVisible(true)]
	[DefaultEvent("OnConnecting")]
	[ComVisible(true)]
	public class AxMsRdpClient6 : AxHost
	{
		// Token: 0x06001276 RID: 4726 RVA: 0x0003F6F4 File Offset: 0x0003D8F4
		public AxMsRdpClient6() : base("7390f3d8-0439-4c05-91e3-cf5cb290c3d0")
		{
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06001277 RID: 4727 RVA: 0x0003F704 File Offset: 0x0003D904
		// (set) Token: 0x06001278 RID: 4728 RVA: 0x0003F728 File Offset: 0x0003D928
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

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06001279 RID: 4729 RVA: 0x0003F750 File Offset: 0x0003D950
		// (set) Token: 0x0600127A RID: 4730 RVA: 0x0003F774 File Offset: 0x0003D974
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

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x0600127B RID: 4731 RVA: 0x0003F79C File Offset: 0x0003D99C
		// (set) Token: 0x0600127C RID: 4732 RVA: 0x0003F7C0 File Offset: 0x0003D9C0
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

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x0600127D RID: 4733 RVA: 0x0003F7E8 File Offset: 0x0003D9E8
		// (set) Token: 0x0600127E RID: 4734 RVA: 0x0003F80C File Offset: 0x0003DA0C
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

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x0600127F RID: 4735 RVA: 0x0003F834 File Offset: 0x0003DA34
		// (set) Token: 0x06001280 RID: 4736 RVA: 0x0003F858 File Offset: 0x0003DA58
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

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06001281 RID: 4737 RVA: 0x0003F880 File Offset: 0x0003DA80
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

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06001282 RID: 4738 RVA: 0x0003F8A4 File Offset: 0x0003DAA4
		// (set) Token: 0x06001283 RID: 4739 RVA: 0x0003F8C8 File Offset: 0x0003DAC8
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

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06001284 RID: 4740 RVA: 0x0003F8F0 File Offset: 0x0003DAF0
		// (set) Token: 0x06001285 RID: 4741 RVA: 0x0003F914 File Offset: 0x0003DB14
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

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06001286 RID: 4742 RVA: 0x0003F93C File Offset: 0x0003DB3C
		// (set) Token: 0x06001287 RID: 4743 RVA: 0x0003F960 File Offset: 0x0003DB60
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

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06001288 RID: 4744 RVA: 0x0003F988 File Offset: 0x0003DB88
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

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06001289 RID: 4745 RVA: 0x0003F9AC File Offset: 0x0003DBAC
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

		// Token: 0x1700034E RID: 846
		// (set) Token: 0x0600128A RID: 4746 RVA: 0x0003F9D0 File Offset: 0x0003DBD0
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

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x0600128B RID: 4747 RVA: 0x0003F9F8 File Offset: 0x0003DBF8
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

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x0600128C RID: 4748 RVA: 0x0003FA1C File Offset: 0x0003DC1C
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

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x0600128D RID: 4749 RVA: 0x0003FA40 File Offset: 0x0003DC40
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

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x0600128E RID: 4750 RVA: 0x0003FA64 File Offset: 0x0003DC64
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

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x0600128F RID: 4751 RVA: 0x0003FA88 File Offset: 0x0003DC88
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

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06001290 RID: 4752 RVA: 0x0003FAAC File Offset: 0x0003DCAC
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

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06001291 RID: 4753 RVA: 0x0003FAD0 File Offset: 0x0003DCD0
		// (set) Token: 0x06001292 RID: 4754 RVA: 0x0003FAF4 File Offset: 0x0003DCF4
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

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06001293 RID: 4755 RVA: 0x0003FB1C File Offset: 0x0003DD1C
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

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06001294 RID: 4756 RVA: 0x0003FB40 File Offset: 0x0003DD40
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

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06001295 RID: 4757 RVA: 0x0003FB64 File Offset: 0x0003DD64
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

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06001296 RID: 4758 RVA: 0x0003FB88 File Offset: 0x0003DD88
		// (set) Token: 0x06001297 RID: 4759 RVA: 0x0003FBAC File Offset: 0x0003DDAC
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

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06001298 RID: 4760 RVA: 0x0003FBD4 File Offset: 0x0003DDD4
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

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06001299 RID: 4761 RVA: 0x0003FBF8 File Offset: 0x0003DDF8
		// (set) Token: 0x0600129A RID: 4762 RVA: 0x0003FC1C File Offset: 0x0003DE1C
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

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x0600129B RID: 4763 RVA: 0x0003FC44 File Offset: 0x0003DE44
		[DispId(300)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x0600129C RID: 4764 RVA: 0x0003FC68 File Offset: 0x0003DE68
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

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x0600129D RID: 4765 RVA: 0x0003FC8C File Offset: 0x0003DE8C
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

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x0600129E RID: 4766 RVA: 0x0003FCB0 File Offset: 0x0003DEB0
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

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x0600129F RID: 4767 RVA: 0x0003FCD4 File Offset: 0x0003DED4
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

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x060012A0 RID: 4768 RVA: 0x0003FCF8 File Offset: 0x0003DEF8
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

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x060012A1 RID: 4769 RVA: 0x0003FD1C File Offset: 0x0003DF1C
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

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x060012A2 RID: 4770 RVA: 0x0003FD40 File Offset: 0x0003DF40
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

		// Token: 0x140001C9 RID: 457
		// (add) Token: 0x060012A3 RID: 4771 RVA: 0x0003FD64 File Offset: 0x0003DF64
		// (remove) Token: 0x060012A4 RID: 4772 RVA: 0x0003FDA0 File Offset: 0x0003DFA0
		public event EventHandler OnConnecting;

		// Token: 0x140001CA RID: 458
		// (add) Token: 0x060012A5 RID: 4773 RVA: 0x0003FDDC File Offset: 0x0003DFDC
		// (remove) Token: 0x060012A6 RID: 4774 RVA: 0x0003FE18 File Offset: 0x0003E018
		public event EventHandler OnConnected;

		// Token: 0x140001CB RID: 459
		// (add) Token: 0x060012A7 RID: 4775 RVA: 0x0003FE54 File Offset: 0x0003E054
		// (remove) Token: 0x060012A8 RID: 4776 RVA: 0x0003FE90 File Offset: 0x0003E090
		public event EventHandler OnLoginComplete;

		// Token: 0x140001CC RID: 460
		// (add) Token: 0x060012A9 RID: 4777 RVA: 0x0003FECC File Offset: 0x0003E0CC
		// (remove) Token: 0x060012AA RID: 4778 RVA: 0x0003FF08 File Offset: 0x0003E108
		public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x140001CD RID: 461
		// (add) Token: 0x060012AB RID: 4779 RVA: 0x0003FF44 File Offset: 0x0003E144
		// (remove) Token: 0x060012AC RID: 4780 RVA: 0x0003FF80 File Offset: 0x0003E180
		public event EventHandler OnEnterFullScreenMode;

		// Token: 0x140001CE RID: 462
		// (add) Token: 0x060012AD RID: 4781 RVA: 0x0003FFBC File Offset: 0x0003E1BC
		// (remove) Token: 0x060012AE RID: 4782 RVA: 0x0003FFF8 File Offset: 0x0003E1F8
		public event EventHandler OnLeaveFullScreenMode;

		// Token: 0x140001CF RID: 463
		// (add) Token: 0x060012AF RID: 4783 RVA: 0x00040034 File Offset: 0x0003E234
		// (remove) Token: 0x060012B0 RID: 4784 RVA: 0x00040070 File Offset: 0x0003E270
		public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x140001D0 RID: 464
		// (add) Token: 0x060012B1 RID: 4785 RVA: 0x000400AC File Offset: 0x0003E2AC
		// (remove) Token: 0x060012B2 RID: 4786 RVA: 0x000400E8 File Offset: 0x0003E2E8
		public event EventHandler OnRequestGoFullScreen;

		// Token: 0x140001D1 RID: 465
		// (add) Token: 0x060012B3 RID: 4787 RVA: 0x00040124 File Offset: 0x0003E324
		// (remove) Token: 0x060012B4 RID: 4788 RVA: 0x00040160 File Offset: 0x0003E360
		public event EventHandler OnRequestLeaveFullScreen;

		// Token: 0x140001D2 RID: 466
		// (add) Token: 0x060012B5 RID: 4789 RVA: 0x0004019C File Offset: 0x0003E39C
		// (remove) Token: 0x060012B6 RID: 4790 RVA: 0x000401D8 File Offset: 0x0003E3D8
		public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x140001D3 RID: 467
		// (add) Token: 0x060012B7 RID: 4791 RVA: 0x00040214 File Offset: 0x0003E414
		// (remove) Token: 0x060012B8 RID: 4792 RVA: 0x00040250 File Offset: 0x0003E450
		public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x140001D4 RID: 468
		// (add) Token: 0x060012B9 RID: 4793 RVA: 0x0004028C File Offset: 0x0003E48C
		// (remove) Token: 0x060012BA RID: 4794 RVA: 0x000402C8 File Offset: 0x0003E4C8
		public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x140001D5 RID: 469
		// (add) Token: 0x060012BB RID: 4795 RVA: 0x00040304 File Offset: 0x0003E504
		// (remove) Token: 0x060012BC RID: 4796 RVA: 0x00040340 File Offset: 0x0003E540
		public event EventHandler OnIdleTimeoutNotification;

		// Token: 0x140001D6 RID: 470
		// (add) Token: 0x060012BD RID: 4797 RVA: 0x0004037C File Offset: 0x0003E57C
		// (remove) Token: 0x060012BE RID: 4798 RVA: 0x000403B8 File Offset: 0x0003E5B8
		public event EventHandler OnRequestContainerMinimize;

		// Token: 0x140001D7 RID: 471
		// (add) Token: 0x060012BF RID: 4799 RVA: 0x000403F4 File Offset: 0x0003E5F4
		// (remove) Token: 0x060012C0 RID: 4800 RVA: 0x00040430 File Offset: 0x0003E630
		public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x140001D8 RID: 472
		// (add) Token: 0x060012C1 RID: 4801 RVA: 0x0004046C File Offset: 0x0003E66C
		// (remove) Token: 0x060012C2 RID: 4802 RVA: 0x000404A8 File Offset: 0x0003E6A8
		public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x140001D9 RID: 473
		// (add) Token: 0x060012C3 RID: 4803 RVA: 0x000404E4 File Offset: 0x0003E6E4
		// (remove) Token: 0x060012C4 RID: 4804 RVA: 0x00040520 File Offset: 0x0003E720
		public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x140001DA RID: 474
		// (add) Token: 0x060012C5 RID: 4805 RVA: 0x0004055C File Offset: 0x0003E75C
		// (remove) Token: 0x060012C6 RID: 4806 RVA: 0x00040598 File Offset: 0x0003E798
		public event EventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x140001DB RID: 475
		// (add) Token: 0x060012C7 RID: 4807 RVA: 0x000405D4 File Offset: 0x0003E7D4
		// (remove) Token: 0x060012C8 RID: 4808 RVA: 0x00040610 File Offset: 0x0003E810
		public event EventHandler OnAuthenticationWarningDismissed;

		// Token: 0x140001DC RID: 476
		// (add) Token: 0x060012C9 RID: 4809 RVA: 0x0004064C File Offset: 0x0003E84C
		// (remove) Token: 0x060012CA RID: 4810 RVA: 0x00040688 File Offset: 0x0003E888
		public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x140001DD RID: 477
		// (add) Token: 0x060012CB RID: 4811 RVA: 0x000406C4 File Offset: 0x0003E8C4
		// (remove) Token: 0x060012CC RID: 4812 RVA: 0x00040700 File Offset: 0x0003E900
		public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x140001DE RID: 478
		// (add) Token: 0x060012CD RID: 4813 RVA: 0x0004073C File Offset: 0x0003E93C
		// (remove) Token: 0x060012CE RID: 4814 RVA: 0x00040778 File Offset: 0x0003E978
		public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x140001DF RID: 479
		// (add) Token: 0x060012CF RID: 4815 RVA: 0x000407B4 File Offset: 0x0003E9B4
		// (remove) Token: 0x060012D0 RID: 4816 RVA: 0x000407F0 File Offset: 0x0003E9F0
		public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x140001E0 RID: 480
		// (add) Token: 0x060012D1 RID: 4817 RVA: 0x0004082C File Offset: 0x0003EA2C
		// (remove) Token: 0x060012D2 RID: 4818 RVA: 0x00040868 File Offset: 0x0003EA68
		public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x140001E1 RID: 481
		// (add) Token: 0x060012D3 RID: 4819 RVA: 0x000408A4 File Offset: 0x0003EAA4
		// (remove) Token: 0x060012D4 RID: 4820 RVA: 0x000408E0 File Offset: 0x0003EAE0
		public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x140001E2 RID: 482
		// (add) Token: 0x060012D5 RID: 4821 RVA: 0x0004091C File Offset: 0x0003EB1C
		// (remove) Token: 0x060012D6 RID: 4822 RVA: 0x00040958 File Offset: 0x0003EB58
		public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x140001E3 RID: 483
		// (add) Token: 0x060012D7 RID: 4823 RVA: 0x00040994 File Offset: 0x0003EB94
		// (remove) Token: 0x060012D8 RID: 4824 RVA: 0x000409D0 File Offset: 0x0003EBD0
		public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x140001E4 RID: 484
		// (add) Token: 0x060012D9 RID: 4825 RVA: 0x00040A0C File Offset: 0x0003EC0C
		// (remove) Token: 0x060012DA RID: 4826 RVA: 0x00040A48 File Offset: 0x0003EC48
		public event EventHandler OnConnectionBarPullDown;

		// Token: 0x140001E5 RID: 485
		// (add) Token: 0x060012DB RID: 4827 RVA: 0x00040A84 File Offset: 0x0003EC84
		// (remove) Token: 0x060012DC RID: 4828 RVA: 0x00040AC0 File Offset: 0x0003ECC0
		public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x140001E6 RID: 486
		// (add) Token: 0x060012DD RID: 4829 RVA: 0x00040AFC File Offset: 0x0003ECFC
		// (remove) Token: 0x060012DE RID: 4830 RVA: 0x00040B38 File Offset: 0x0003ED38
		public event EventHandler OnDevicesButtonPressed;

		// Token: 0x140001E7 RID: 487
		// (add) Token: 0x060012DF RID: 4831 RVA: 0x00040B74 File Offset: 0x0003ED74
		// (remove) Token: 0x060012E0 RID: 4832 RVA: 0x00040BB0 File Offset: 0x0003EDB0
		public event EventHandler OnAutoReconnected;

		// Token: 0x140001E8 RID: 488
		// (add) Token: 0x060012E1 RID: 4833 RVA: 0x00040BEC File Offset: 0x0003EDEC
		// (remove) Token: 0x060012E2 RID: 4834 RVA: 0x00040C28 File Offset: 0x0003EE28
		public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

		// Token: 0x060012E3 RID: 4835 RVA: 0x00040C64 File Offset: 0x0003EE64
		public virtual void Connect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Connect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Connect();
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x00040C88 File Offset: 0x0003EE88
		public virtual void Disconnect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Disconnect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Disconnect();
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x00040CAC File Offset: 0x0003EEAC
		public virtual void CreateVirtualChannels(string newVal)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("CreateVirtualChannels", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.CreateVirtualChannels(newVal);
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x00040CD4 File Offset: 0x0003EED4
		public virtual void SendOnVirtualChannel(string chanName, string chanData)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SendOnVirtualChannel", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SendOnVirtualChannel(chanName, chanData);
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x00040CFC File Offset: 0x0003EEFC
		public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SetVirtualChannelOptions(chanName, chanOptions);
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x00040D24 File Offset: 0x0003EF24
		public virtual int GetVirtualChannelOptions(string chanName)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetVirtualChannelOptions(chanName);
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x00040D5C File Offset: 0x0003EF5C
		public virtual ControlCloseStatus RequestClose()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("RequestClose", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.RequestClose();
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x00040D94 File Offset: 0x0003EF94
		public virtual string GetErrorDescription(uint disconnectReason, uint extendedDisconnectReason)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetErrorDescription", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetErrorDescription(disconnectReason, extendedDisconnectReason);
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x00040DCC File Offset: 0x0003EFCC
		protected override void CreateSink()
		{
			try
			{
				this.eventMulticaster = new AxMsRdpClient6EventMulticaster(this);
				this.cookie = new AxHost.ConnectionPointCookie(this.ocx, this.eventMulticaster, typeof(IMsTscAxEvents));
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x00040E24 File Offset: 0x0003F024
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

		// Token: 0x060012ED RID: 4845 RVA: 0x00040E58 File Offset: 0x0003F058
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

		// Token: 0x060012EE RID: 4846 RVA: 0x00040E94 File Offset: 0x0003F094
		internal void RaiseOnOnConnecting(object sender, EventArgs e)
		{
			if (this.OnConnecting != null)
			{
				this.OnConnecting(sender, e);
			}
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x00040EB0 File Offset: 0x0003F0B0
		internal void RaiseOnOnConnected(object sender, EventArgs e)
		{
			if (this.OnConnected != null)
			{
				this.OnConnected(sender, e);
			}
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x00040ECC File Offset: 0x0003F0CC
		internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
		{
			if (this.OnLoginComplete != null)
			{
				this.OnLoginComplete(sender, e);
			}
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x00040EE8 File Offset: 0x0003F0E8
		internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
		{
			if (this.OnDisconnected != null)
			{
				this.OnDisconnected(sender, e);
			}
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x00040F04 File Offset: 0x0003F104
		internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnEnterFullScreenMode != null)
			{
				this.OnEnterFullScreenMode(sender, e);
			}
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x00040F20 File Offset: 0x0003F120
		internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnLeaveFullScreenMode != null)
			{
				this.OnLeaveFullScreenMode(sender, e);
			}
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x00040F3C File Offset: 0x0003F13C
		internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
		{
			if (this.OnChannelReceivedData != null)
			{
				this.OnChannelReceivedData(sender, e);
			}
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x00040F58 File Offset: 0x0003F158
		internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestGoFullScreen != null)
			{
				this.OnRequestGoFullScreen(sender, e);
			}
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x00040F74 File Offset: 0x0003F174
		internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestLeaveFullScreen != null)
			{
				this.OnRequestLeaveFullScreen(sender, e);
			}
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x00040F90 File Offset: 0x0003F190
		internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
		{
			if (this.OnFatalError != null)
			{
				this.OnFatalError(sender, e);
			}
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x00040FAC File Offset: 0x0003F1AC
		internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
		{
			if (this.OnWarning != null)
			{
				this.OnWarning(sender, e);
			}
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x00040FC8 File Offset: 0x0003F1C8
		internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
		{
			if (this.OnRemoteDesktopSizeChange != null)
			{
				this.OnRemoteDesktopSizeChange(sender, e);
			}
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x00040FE4 File Offset: 0x0003F1E4
		internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
		{
			if (this.OnIdleTimeoutNotification != null)
			{
				this.OnIdleTimeoutNotification(sender, e);
			}
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x00041000 File Offset: 0x0003F200
		internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
		{
			if (this.OnRequestContainerMinimize != null)
			{
				this.OnRequestContainerMinimize(sender, e);
			}
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x0004101C File Offset: 0x0003F21C
		internal void RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
		{
			if (this.OnConfirmClose != null)
			{
				this.OnConfirmClose(sender, e);
			}
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x00041038 File Offset: 0x0003F238
		internal void RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
		{
			if (this.OnReceivedTSPublicKey != null)
			{
				this.OnReceivedTSPublicKey(sender, e);
			}
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x00041054 File Offset: 0x0003F254
		internal void RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
		{
			if (this.OnAutoReconnecting != null)
			{
				this.OnAutoReconnecting(sender, e);
			}
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x00041070 File Offset: 0x0003F270
		internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDisplayed != null)
			{
				this.OnAuthenticationWarningDisplayed(sender, e);
			}
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x0004108C File Offset: 0x0003F28C
		internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDismissed != null)
			{
				this.OnAuthenticationWarningDismissed(sender, e);
			}
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x000410A8 File Offset: 0x0003F2A8
		internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
		{
			if (this.OnRemoteProgramResult != null)
			{
				this.OnRemoteProgramResult(sender, e);
			}
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x000410C4 File Offset: 0x0003F2C4
		internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
		{
			if (this.OnRemoteProgramDisplayed != null)
			{
				this.OnRemoteProgramDisplayed(sender, e);
			}
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x000410E0 File Offset: 0x0003F2E0
		internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
		{
			if (this.OnRemoteWindowDisplayed != null)
			{
				this.OnRemoteWindowDisplayed(sender, e);
			}
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x000410FC File Offset: 0x0003F2FC
		internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
		{
			if (this.OnLogonError != null)
			{
				this.OnLogonError(sender, e);
			}
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x00041118 File Offset: 0x0003F318
		internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
		{
			if (this.OnFocusReleased != null)
			{
				this.OnFocusReleased(sender, e);
			}
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x00041134 File Offset: 0x0003F334
		internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
		{
			if (this.OnUserNameAcquired != null)
			{
				this.OnUserNameAcquired(sender, e);
			}
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x00041150 File Offset: 0x0003F350
		internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
		{
			if (this.OnMouseInputModeChanged != null)
			{
				this.OnMouseInputModeChanged(sender, e);
			}
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x0004116C File Offset: 0x0003F36C
		internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
		{
			if (this.OnServiceMessageReceived != null)
			{
				this.OnServiceMessageReceived(sender, e);
			}
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x00041188 File Offset: 0x0003F388
		internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
		{
			if (this.OnConnectionBarPullDown != null)
			{
				this.OnConnectionBarPullDown(sender, e);
			}
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x000411A4 File Offset: 0x0003F3A4
		internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
		{
			if (this.OnNetworkStatusChanged != null)
			{
				this.OnNetworkStatusChanged(sender, e);
			}
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x000411C0 File Offset: 0x0003F3C0
		internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
		{
			if (this.OnDevicesButtonPressed != null)
			{
				this.OnDevicesButtonPressed(sender, e);
			}
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x000411DC File Offset: 0x0003F3DC
		internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
		{
			if (this.OnAutoReconnected != null)
			{
				this.OnAutoReconnected(sender, e);
			}
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x000411F8 File Offset: 0x0003F3F8
		internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
		{
			if (this.OnAutoReconnecting2 != null)
			{
				this.OnAutoReconnecting2(sender, e);
			}
		}

		// Token: 0x04000583 RID: 1411
		private IMsRdpClient6 ocx;

		// Token: 0x04000584 RID: 1412
		private AxMsRdpClient6EventMulticaster eventMulticaster;

		// Token: 0x04000585 RID: 1413
		private AxHost.ConnectionPointCookie cookie;
	}
}
