using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MSTSCLib;

namespace AxMSTSCLib
{
	// Token: 0x0200012A RID: 298
	[DefaultEvent("OnConnecting")]
	[AxHost.ClsidAttribute("{54ce37e0-9834-41ae-9896-4dab69dc022b}")]
	[DesignTimeVisible(true)]
	[ComVisible(true)]
	public class AxMsRdpClient4a : AxHost
	{
		// Token: 0x06000F9D RID: 3997 RVA: 0x00037514 File Offset: 0x00035714
		public AxMsRdpClient4a() : base("54ce37e0-9834-41ae-9896-4dab69dc022b")
		{
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000F9E RID: 3998 RVA: 0x00037524 File Offset: 0x00035724
		// (set) Token: 0x06000F9F RID: 3999 RVA: 0x00037548 File Offset: 0x00035748
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

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000FA0 RID: 4000 RVA: 0x00037570 File Offset: 0x00035770
		// (set) Token: 0x06000FA1 RID: 4001 RVA: 0x00037594 File Offset: 0x00035794
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

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000FA2 RID: 4002 RVA: 0x000375BC File Offset: 0x000357BC
		// (set) Token: 0x06000FA3 RID: 4003 RVA: 0x000375E0 File Offset: 0x000357E0
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

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000FA4 RID: 4004 RVA: 0x00037608 File Offset: 0x00035808
		// (set) Token: 0x06000FA5 RID: 4005 RVA: 0x0003762C File Offset: 0x0003582C
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

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000FA6 RID: 4006 RVA: 0x00037654 File Offset: 0x00035854
		// (set) Token: 0x06000FA7 RID: 4007 RVA: 0x00037678 File Offset: 0x00035878
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

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000FA8 RID: 4008 RVA: 0x000376A0 File Offset: 0x000358A0
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

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000FA9 RID: 4009 RVA: 0x000376C4 File Offset: 0x000358C4
		// (set) Token: 0x06000FAA RID: 4010 RVA: 0x000376E8 File Offset: 0x000358E8
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

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000FAB RID: 4011 RVA: 0x00037710 File Offset: 0x00035910
		// (set) Token: 0x06000FAC RID: 4012 RVA: 0x00037734 File Offset: 0x00035934
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

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000FAD RID: 4013 RVA: 0x0003775C File Offset: 0x0003595C
		// (set) Token: 0x06000FAE RID: 4014 RVA: 0x00037780 File Offset: 0x00035980
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

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000FAF RID: 4015 RVA: 0x000377A8 File Offset: 0x000359A8
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

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000FB0 RID: 4016 RVA: 0x000377CC File Offset: 0x000359CC
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

		// Token: 0x170002D4 RID: 724
		// (set) Token: 0x06000FB1 RID: 4017 RVA: 0x000377F0 File Offset: 0x000359F0
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

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000FB2 RID: 4018 RVA: 0x00037818 File Offset: 0x00035A18
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

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000FB3 RID: 4019 RVA: 0x0003783C File Offset: 0x00035A3C
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

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000FB4 RID: 4020 RVA: 0x00037860 File Offset: 0x00035A60
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

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000FB5 RID: 4021 RVA: 0x00037884 File Offset: 0x00035A84
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

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000FB6 RID: 4022 RVA: 0x000378A8 File Offset: 0x00035AA8
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

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000FB7 RID: 4023 RVA: 0x000378CC File Offset: 0x00035ACC
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

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000FB8 RID: 4024 RVA: 0x000378F0 File Offset: 0x00035AF0
		// (set) Token: 0x06000FB9 RID: 4025 RVA: 0x00037914 File Offset: 0x00035B14
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

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000FBA RID: 4026 RVA: 0x0003793C File Offset: 0x00035B3C
		[Browsable(false)]
		[DispId(101)]
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

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000FBB RID: 4027 RVA: 0x00037960 File Offset: 0x00035B60
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

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000FBC RID: 4028 RVA: 0x00037984 File Offset: 0x00035B84
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

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000FBD RID: 4029 RVA: 0x000379A8 File Offset: 0x00035BA8
		// (set) Token: 0x06000FBE RID: 4030 RVA: 0x000379CC File Offset: 0x00035BCC
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

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000FBF RID: 4031 RVA: 0x000379F4 File Offset: 0x00035BF4
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

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000FC0 RID: 4032 RVA: 0x00037A18 File Offset: 0x00035C18
		// (set) Token: 0x06000FC1 RID: 4033 RVA: 0x00037A3C File Offset: 0x00035C3C
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

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000FC2 RID: 4034 RVA: 0x00037A64 File Offset: 0x00035C64
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

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000FC3 RID: 4035 RVA: 0x00037A88 File Offset: 0x00035C88
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

		// Token: 0x14000149 RID: 329
		// (add) Token: 0x06000FC4 RID: 4036 RVA: 0x00037AAC File Offset: 0x00035CAC
		// (remove) Token: 0x06000FC5 RID: 4037 RVA: 0x00037AE8 File Offset: 0x00035CE8
		public event EventHandler OnConnecting;

		// Token: 0x1400014A RID: 330
		// (add) Token: 0x06000FC6 RID: 4038 RVA: 0x00037B24 File Offset: 0x00035D24
		// (remove) Token: 0x06000FC7 RID: 4039 RVA: 0x00037B60 File Offset: 0x00035D60
		public event EventHandler OnConnected;

		// Token: 0x1400014B RID: 331
		// (add) Token: 0x06000FC8 RID: 4040 RVA: 0x00037B9C File Offset: 0x00035D9C
		// (remove) Token: 0x06000FC9 RID: 4041 RVA: 0x00037BD8 File Offset: 0x00035DD8
		public event EventHandler OnLoginComplete;

		// Token: 0x1400014C RID: 332
		// (add) Token: 0x06000FCA RID: 4042 RVA: 0x00037C14 File Offset: 0x00035E14
		// (remove) Token: 0x06000FCB RID: 4043 RVA: 0x00037C50 File Offset: 0x00035E50
		public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x1400014D RID: 333
		// (add) Token: 0x06000FCC RID: 4044 RVA: 0x00037C8C File Offset: 0x00035E8C
		// (remove) Token: 0x06000FCD RID: 4045 RVA: 0x00037CC8 File Offset: 0x00035EC8
		public event EventHandler OnEnterFullScreenMode;

		// Token: 0x1400014E RID: 334
		// (add) Token: 0x06000FCE RID: 4046 RVA: 0x00037D04 File Offset: 0x00035F04
		// (remove) Token: 0x06000FCF RID: 4047 RVA: 0x00037D40 File Offset: 0x00035F40
		public event EventHandler OnLeaveFullScreenMode;

		// Token: 0x1400014F RID: 335
		// (add) Token: 0x06000FD0 RID: 4048 RVA: 0x00037D7C File Offset: 0x00035F7C
		// (remove) Token: 0x06000FD1 RID: 4049 RVA: 0x00037DB8 File Offset: 0x00035FB8
		public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x14000150 RID: 336
		// (add) Token: 0x06000FD2 RID: 4050 RVA: 0x00037DF4 File Offset: 0x00035FF4
		// (remove) Token: 0x06000FD3 RID: 4051 RVA: 0x00037E30 File Offset: 0x00036030
		public event EventHandler OnRequestGoFullScreen;

		// Token: 0x14000151 RID: 337
		// (add) Token: 0x06000FD4 RID: 4052 RVA: 0x00037E6C File Offset: 0x0003606C
		// (remove) Token: 0x06000FD5 RID: 4053 RVA: 0x00037EA8 File Offset: 0x000360A8
		public event EventHandler OnRequestLeaveFullScreen;

		// Token: 0x14000152 RID: 338
		// (add) Token: 0x06000FD6 RID: 4054 RVA: 0x00037EE4 File Offset: 0x000360E4
		// (remove) Token: 0x06000FD7 RID: 4055 RVA: 0x00037F20 File Offset: 0x00036120
		public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x14000153 RID: 339
		// (add) Token: 0x06000FD8 RID: 4056 RVA: 0x00037F5C File Offset: 0x0003615C
		// (remove) Token: 0x06000FD9 RID: 4057 RVA: 0x00037F98 File Offset: 0x00036198
		public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x14000154 RID: 340
		// (add) Token: 0x06000FDA RID: 4058 RVA: 0x00037FD4 File Offset: 0x000361D4
		// (remove) Token: 0x06000FDB RID: 4059 RVA: 0x00038010 File Offset: 0x00036210
		public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x14000155 RID: 341
		// (add) Token: 0x06000FDC RID: 4060 RVA: 0x0003804C File Offset: 0x0003624C
		// (remove) Token: 0x06000FDD RID: 4061 RVA: 0x00038088 File Offset: 0x00036288
		public event EventHandler OnIdleTimeoutNotification;

		// Token: 0x14000156 RID: 342
		// (add) Token: 0x06000FDE RID: 4062 RVA: 0x000380C4 File Offset: 0x000362C4
		// (remove) Token: 0x06000FDF RID: 4063 RVA: 0x00038100 File Offset: 0x00036300
		public event EventHandler OnRequestContainerMinimize;

		// Token: 0x14000157 RID: 343
		// (add) Token: 0x06000FE0 RID: 4064 RVA: 0x0003813C File Offset: 0x0003633C
		// (remove) Token: 0x06000FE1 RID: 4065 RVA: 0x00038178 File Offset: 0x00036378
		public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x14000158 RID: 344
		// (add) Token: 0x06000FE2 RID: 4066 RVA: 0x000381B4 File Offset: 0x000363B4
		// (remove) Token: 0x06000FE3 RID: 4067 RVA: 0x000381F0 File Offset: 0x000363F0
		public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x14000159 RID: 345
		// (add) Token: 0x06000FE4 RID: 4068 RVA: 0x0003822C File Offset: 0x0003642C
		// (remove) Token: 0x06000FE5 RID: 4069 RVA: 0x00038268 File Offset: 0x00036468
		public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x1400015A RID: 346
		// (add) Token: 0x06000FE6 RID: 4070 RVA: 0x000382A4 File Offset: 0x000364A4
		// (remove) Token: 0x06000FE7 RID: 4071 RVA: 0x000382E0 File Offset: 0x000364E0
		public event EventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x1400015B RID: 347
		// (add) Token: 0x06000FE8 RID: 4072 RVA: 0x0003831C File Offset: 0x0003651C
		// (remove) Token: 0x06000FE9 RID: 4073 RVA: 0x00038358 File Offset: 0x00036558
		public event EventHandler OnAuthenticationWarningDismissed;

		// Token: 0x1400015C RID: 348
		// (add) Token: 0x06000FEA RID: 4074 RVA: 0x00038394 File Offset: 0x00036594
		// (remove) Token: 0x06000FEB RID: 4075 RVA: 0x000383D0 File Offset: 0x000365D0
		public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x1400015D RID: 349
		// (add) Token: 0x06000FEC RID: 4076 RVA: 0x0003840C File Offset: 0x0003660C
		// (remove) Token: 0x06000FED RID: 4077 RVA: 0x00038448 File Offset: 0x00036648
		public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x1400015E RID: 350
		// (add) Token: 0x06000FEE RID: 4078 RVA: 0x00038484 File Offset: 0x00036684
		// (remove) Token: 0x06000FEF RID: 4079 RVA: 0x000384C0 File Offset: 0x000366C0
		public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x1400015F RID: 351
		// (add) Token: 0x06000FF0 RID: 4080 RVA: 0x000384FC File Offset: 0x000366FC
		// (remove) Token: 0x06000FF1 RID: 4081 RVA: 0x00038538 File Offset: 0x00036738
		public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x14000160 RID: 352
		// (add) Token: 0x06000FF2 RID: 4082 RVA: 0x00038574 File Offset: 0x00036774
		// (remove) Token: 0x06000FF3 RID: 4083 RVA: 0x000385B0 File Offset: 0x000367B0
		public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x14000161 RID: 353
		// (add) Token: 0x06000FF4 RID: 4084 RVA: 0x000385EC File Offset: 0x000367EC
		// (remove) Token: 0x06000FF5 RID: 4085 RVA: 0x00038628 File Offset: 0x00036828
		public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x14000162 RID: 354
		// (add) Token: 0x06000FF6 RID: 4086 RVA: 0x00038664 File Offset: 0x00036864
		// (remove) Token: 0x06000FF7 RID: 4087 RVA: 0x000386A0 File Offset: 0x000368A0
		public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x14000163 RID: 355
		// (add) Token: 0x06000FF8 RID: 4088 RVA: 0x000386DC File Offset: 0x000368DC
		// (remove) Token: 0x06000FF9 RID: 4089 RVA: 0x00038718 File Offset: 0x00036918
		public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x14000164 RID: 356
		// (add) Token: 0x06000FFA RID: 4090 RVA: 0x00038754 File Offset: 0x00036954
		// (remove) Token: 0x06000FFB RID: 4091 RVA: 0x00038790 File Offset: 0x00036990
		public event EventHandler OnConnectionBarPullDown;

		// Token: 0x14000165 RID: 357
		// (add) Token: 0x06000FFC RID: 4092 RVA: 0x000387CC File Offset: 0x000369CC
		// (remove) Token: 0x06000FFD RID: 4093 RVA: 0x00038808 File Offset: 0x00036A08
		public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x14000166 RID: 358
		// (add) Token: 0x06000FFE RID: 4094 RVA: 0x00038844 File Offset: 0x00036A44
		// (remove) Token: 0x06000FFF RID: 4095 RVA: 0x00038880 File Offset: 0x00036A80
		public event EventHandler OnDevicesButtonPressed;

		// Token: 0x14000167 RID: 359
		// (add) Token: 0x06001000 RID: 4096 RVA: 0x000388BC File Offset: 0x00036ABC
		// (remove) Token: 0x06001001 RID: 4097 RVA: 0x000388F8 File Offset: 0x00036AF8
		public event EventHandler OnAutoReconnected;

		// Token: 0x14000168 RID: 360
		// (add) Token: 0x06001002 RID: 4098 RVA: 0x00038934 File Offset: 0x00036B34
		// (remove) Token: 0x06001003 RID: 4099 RVA: 0x00038970 File Offset: 0x00036B70
		public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

		// Token: 0x06001004 RID: 4100 RVA: 0x000389AC File Offset: 0x00036BAC
		public virtual void Connect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Connect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Connect();
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x000389D0 File Offset: 0x00036BD0
		public virtual void Disconnect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Disconnect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Disconnect();
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x000389F4 File Offset: 0x00036BF4
		public virtual void CreateVirtualChannels(string newVal)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("CreateVirtualChannels", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.CreateVirtualChannels(newVal);
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x00038A1C File Offset: 0x00036C1C
		public virtual void SendOnVirtualChannel(string chanName, string chanData)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SendOnVirtualChannel", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SendOnVirtualChannel(chanName, chanData);
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x00038A44 File Offset: 0x00036C44
		public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SetVirtualChannelOptions(chanName, chanOptions);
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x00038A6C File Offset: 0x00036C6C
		public virtual int GetVirtualChannelOptions(string chanName)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetVirtualChannelOptions(chanName);
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x00038AA4 File Offset: 0x00036CA4
		public virtual ControlCloseStatus RequestClose()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("RequestClose", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.RequestClose();
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x00038ADC File Offset: 0x00036CDC
		protected override void CreateSink()
		{
			try
			{
				this.eventMulticaster = new AxMsRdpClient4aEventMulticaster(this);
				this.cookie = new AxHost.ConnectionPointCookie(this.ocx, this.eventMulticaster, typeof(IMsTscAxEvents));
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x00038B34 File Offset: 0x00036D34
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

		// Token: 0x0600100D RID: 4109 RVA: 0x00038B68 File Offset: 0x00036D68
		protected override void AttachInterfaces()
		{
			try
			{
				this.ocx = (IMsRdpClient4)base.GetOcx();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x00038BA4 File Offset: 0x00036DA4
		internal void RaiseOnOnConnecting(object sender, EventArgs e)
		{
			if (this.OnConnecting != null)
			{
				this.OnConnecting(sender, e);
			}
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x00038BC0 File Offset: 0x00036DC0
		internal void RaiseOnOnConnected(object sender, EventArgs e)
		{
			if (this.OnConnected != null)
			{
				this.OnConnected(sender, e);
			}
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x00038BDC File Offset: 0x00036DDC
		internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
		{
			if (this.OnLoginComplete != null)
			{
				this.OnLoginComplete(sender, e);
			}
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x00038BF8 File Offset: 0x00036DF8
		internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
		{
			if (this.OnDisconnected != null)
			{
				this.OnDisconnected(sender, e);
			}
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x00038C14 File Offset: 0x00036E14
		internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnEnterFullScreenMode != null)
			{
				this.OnEnterFullScreenMode(sender, e);
			}
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x00038C30 File Offset: 0x00036E30
		internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnLeaveFullScreenMode != null)
			{
				this.OnLeaveFullScreenMode(sender, e);
			}
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x00038C4C File Offset: 0x00036E4C
		internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
		{
			if (this.OnChannelReceivedData != null)
			{
				this.OnChannelReceivedData(sender, e);
			}
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x00038C68 File Offset: 0x00036E68
		internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestGoFullScreen != null)
			{
				this.OnRequestGoFullScreen(sender, e);
			}
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x00038C84 File Offset: 0x00036E84
		internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestLeaveFullScreen != null)
			{
				this.OnRequestLeaveFullScreen(sender, e);
			}
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x00038CA0 File Offset: 0x00036EA0
		internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
		{
			if (this.OnFatalError != null)
			{
				this.OnFatalError(sender, e);
			}
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x00038CBC File Offset: 0x00036EBC
		internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
		{
			if (this.OnWarning != null)
			{
				this.OnWarning(sender, e);
			}
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x00038CD8 File Offset: 0x00036ED8
		internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
		{
			if (this.OnRemoteDesktopSizeChange != null)
			{
				this.OnRemoteDesktopSizeChange(sender, e);
			}
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x00038CF4 File Offset: 0x00036EF4
		internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
		{
			if (this.OnIdleTimeoutNotification != null)
			{
				this.OnIdleTimeoutNotification(sender, e);
			}
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x00038D10 File Offset: 0x00036F10
		internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
		{
			if (this.OnRequestContainerMinimize != null)
			{
				this.OnRequestContainerMinimize(sender, e);
			}
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x00038D2C File Offset: 0x00036F2C
		internal void RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
		{
			if (this.OnConfirmClose != null)
			{
				this.OnConfirmClose(sender, e);
			}
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x00038D48 File Offset: 0x00036F48
		internal void RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
		{
			if (this.OnReceivedTSPublicKey != null)
			{
				this.OnReceivedTSPublicKey(sender, e);
			}
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x00038D64 File Offset: 0x00036F64
		internal void RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
		{
			if (this.OnAutoReconnecting != null)
			{
				this.OnAutoReconnecting(sender, e);
			}
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x00038D80 File Offset: 0x00036F80
		internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDisplayed != null)
			{
				this.OnAuthenticationWarningDisplayed(sender, e);
			}
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x00038D9C File Offset: 0x00036F9C
		internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDismissed != null)
			{
				this.OnAuthenticationWarningDismissed(sender, e);
			}
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x00038DB8 File Offset: 0x00036FB8
		internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
		{
			if (this.OnRemoteProgramResult != null)
			{
				this.OnRemoteProgramResult(sender, e);
			}
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x00038DD4 File Offset: 0x00036FD4
		internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
		{
			if (this.OnRemoteProgramDisplayed != null)
			{
				this.OnRemoteProgramDisplayed(sender, e);
			}
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x00038DF0 File Offset: 0x00036FF0
		internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
		{
			if (this.OnRemoteWindowDisplayed != null)
			{
				this.OnRemoteWindowDisplayed(sender, e);
			}
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x00038E0C File Offset: 0x0003700C
		internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
		{
			if (this.OnLogonError != null)
			{
				this.OnLogonError(sender, e);
			}
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x00038E28 File Offset: 0x00037028
		internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
		{
			if (this.OnFocusReleased != null)
			{
				this.OnFocusReleased(sender, e);
			}
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x00038E44 File Offset: 0x00037044
		internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
		{
			if (this.OnUserNameAcquired != null)
			{
				this.OnUserNameAcquired(sender, e);
			}
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x00038E60 File Offset: 0x00037060
		internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
		{
			if (this.OnMouseInputModeChanged != null)
			{
				this.OnMouseInputModeChanged(sender, e);
			}
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x00038E7C File Offset: 0x0003707C
		internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
		{
			if (this.OnServiceMessageReceived != null)
			{
				this.OnServiceMessageReceived(sender, e);
			}
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x00038E98 File Offset: 0x00037098
		internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
		{
			if (this.OnConnectionBarPullDown != null)
			{
				this.OnConnectionBarPullDown(sender, e);
			}
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x00038EB4 File Offset: 0x000370B4
		internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
		{
			if (this.OnNetworkStatusChanged != null)
			{
				this.OnNetworkStatusChanged(sender, e);
			}
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x00038ED0 File Offset: 0x000370D0
		internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
		{
			if (this.OnDevicesButtonPressed != null)
			{
				this.OnDevicesButtonPressed(sender, e);
			}
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x00038EEC File Offset: 0x000370EC
		internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
		{
			if (this.OnAutoReconnected != null)
			{
				this.OnAutoReconnected(sender, e);
			}
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x00038F08 File Offset: 0x00037108
		internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
		{
			if (this.OnAutoReconnecting2 != null)
			{
				this.OnAutoReconnecting2(sender, e);
			}
		}

		// Token: 0x040004F3 RID: 1267
		private IMsRdpClient4 ocx;

		// Token: 0x040004F4 RID: 1268
		private AxMsRdpClient4aEventMulticaster eventMulticaster;

		// Token: 0x040004F5 RID: 1269
		private AxHost.ConnectionPointCookie cookie;
	}
}
