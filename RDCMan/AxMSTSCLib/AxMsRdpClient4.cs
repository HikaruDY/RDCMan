using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MSTSCLib;

namespace AxMSTSCLib
{
	// Token: 0x02000128 RID: 296
	[AxHost.ClsidAttribute("{4edcb26c-d24c-4e72-af07-b576699ac0de}")]
	[DesignTimeVisible(true)]
	[DefaultEvent("OnConnecting")]
	[ComVisible(true)]
	public class AxMsRdpClient4 : AxHost
	{
		// Token: 0x06000EEB RID: 3819 RVA: 0x00035544 File Offset: 0x00033744
		public AxMsRdpClient4() : base("4edcb26c-d24c-4e72-af07-b576699ac0de")
		{
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000EEC RID: 3820 RVA: 0x00035554 File Offset: 0x00033754
		// (set) Token: 0x06000EED RID: 3821 RVA: 0x00035578 File Offset: 0x00033778
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

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000EEE RID: 3822 RVA: 0x000355A0 File Offset: 0x000337A0
		// (set) Token: 0x06000EEF RID: 3823 RVA: 0x000355C4 File Offset: 0x000337C4
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

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000EF0 RID: 3824 RVA: 0x000355EC File Offset: 0x000337EC
		// (set) Token: 0x06000EF1 RID: 3825 RVA: 0x00035610 File Offset: 0x00033810
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

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000EF2 RID: 3826 RVA: 0x00035638 File Offset: 0x00033838
		// (set) Token: 0x06000EF3 RID: 3827 RVA: 0x0003565C File Offset: 0x0003385C
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

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000EF4 RID: 3828 RVA: 0x00035684 File Offset: 0x00033884
		// (set) Token: 0x06000EF5 RID: 3829 RVA: 0x000356A8 File Offset: 0x000338A8
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

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000EF6 RID: 3830 RVA: 0x000356D0 File Offset: 0x000338D0
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

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000EF7 RID: 3831 RVA: 0x000356F4 File Offset: 0x000338F4
		// (set) Token: 0x06000EF8 RID: 3832 RVA: 0x00035718 File Offset: 0x00033918
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

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000EF9 RID: 3833 RVA: 0x00035740 File Offset: 0x00033940
		// (set) Token: 0x06000EFA RID: 3834 RVA: 0x00035764 File Offset: 0x00033964
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

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000EFB RID: 3835 RVA: 0x0003578C File Offset: 0x0003398C
		// (set) Token: 0x06000EFC RID: 3836 RVA: 0x000357B0 File Offset: 0x000339B0
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

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000EFD RID: 3837 RVA: 0x000357D8 File Offset: 0x000339D8
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

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000EFE RID: 3838 RVA: 0x000357FC File Offset: 0x000339FC
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

		// Token: 0x170002B9 RID: 697
		// (set) Token: 0x06000EFF RID: 3839 RVA: 0x00035820 File Offset: 0x00033A20
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
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

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000F00 RID: 3840 RVA: 0x00035848 File Offset: 0x00033A48
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

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000F01 RID: 3841 RVA: 0x0003586C File Offset: 0x00033A6C
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

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000F02 RID: 3842 RVA: 0x00035890 File Offset: 0x00033A90
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

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000F03 RID: 3843 RVA: 0x000358B4 File Offset: 0x00033AB4
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

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000F04 RID: 3844 RVA: 0x000358D8 File Offset: 0x00033AD8
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

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000F05 RID: 3845 RVA: 0x000358FC File Offset: 0x00033AFC
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

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000F06 RID: 3846 RVA: 0x00035920 File Offset: 0x00033B20
		// (set) Token: 0x06000F07 RID: 3847 RVA: 0x00035944 File Offset: 0x00033B44
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

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000F08 RID: 3848 RVA: 0x0003596C File Offset: 0x00033B6C
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

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000F09 RID: 3849 RVA: 0x00035990 File Offset: 0x00033B90
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

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000F0A RID: 3850 RVA: 0x000359B4 File Offset: 0x00033BB4
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

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000F0B RID: 3851 RVA: 0x000359D8 File Offset: 0x00033BD8
		// (set) Token: 0x06000F0C RID: 3852 RVA: 0x000359FC File Offset: 0x00033BFC
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

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000F0D RID: 3853 RVA: 0x00035A24 File Offset: 0x00033C24
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

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000F0E RID: 3854 RVA: 0x00035A48 File Offset: 0x00033C48
		// (set) Token: 0x06000F0F RID: 3855 RVA: 0x00035A6C File Offset: 0x00033C6C
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

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000F10 RID: 3856 RVA: 0x00035A94 File Offset: 0x00033C94
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

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000F11 RID: 3857 RVA: 0x00035AB8 File Offset: 0x00033CB8
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
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

		// Token: 0x14000129 RID: 297
		// (add) Token: 0x06000F12 RID: 3858 RVA: 0x00035ADC File Offset: 0x00033CDC
		// (remove) Token: 0x06000F13 RID: 3859 RVA: 0x00035B18 File Offset: 0x00033D18
		public event EventHandler OnConnecting;

		// Token: 0x1400012A RID: 298
		// (add) Token: 0x06000F14 RID: 3860 RVA: 0x00035B54 File Offset: 0x00033D54
		// (remove) Token: 0x06000F15 RID: 3861 RVA: 0x00035B90 File Offset: 0x00033D90
		public event EventHandler OnConnected;

		// Token: 0x1400012B RID: 299
		// (add) Token: 0x06000F16 RID: 3862 RVA: 0x00035BCC File Offset: 0x00033DCC
		// (remove) Token: 0x06000F17 RID: 3863 RVA: 0x00035C08 File Offset: 0x00033E08
		public event EventHandler OnLoginComplete;

		// Token: 0x1400012C RID: 300
		// (add) Token: 0x06000F18 RID: 3864 RVA: 0x00035C44 File Offset: 0x00033E44
		// (remove) Token: 0x06000F19 RID: 3865 RVA: 0x00035C80 File Offset: 0x00033E80
		public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x1400012D RID: 301
		// (add) Token: 0x06000F1A RID: 3866 RVA: 0x00035CBC File Offset: 0x00033EBC
		// (remove) Token: 0x06000F1B RID: 3867 RVA: 0x00035CF8 File Offset: 0x00033EF8
		public event EventHandler OnEnterFullScreenMode;

		// Token: 0x1400012E RID: 302
		// (add) Token: 0x06000F1C RID: 3868 RVA: 0x00035D34 File Offset: 0x00033F34
		// (remove) Token: 0x06000F1D RID: 3869 RVA: 0x00035D70 File Offset: 0x00033F70
		public event EventHandler OnLeaveFullScreenMode;

		// Token: 0x1400012F RID: 303
		// (add) Token: 0x06000F1E RID: 3870 RVA: 0x00035DAC File Offset: 0x00033FAC
		// (remove) Token: 0x06000F1F RID: 3871 RVA: 0x00035DE8 File Offset: 0x00033FE8
		public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x14000130 RID: 304
		// (add) Token: 0x06000F20 RID: 3872 RVA: 0x00035E24 File Offset: 0x00034024
		// (remove) Token: 0x06000F21 RID: 3873 RVA: 0x00035E60 File Offset: 0x00034060
		public event EventHandler OnRequestGoFullScreen;

		// Token: 0x14000131 RID: 305
		// (add) Token: 0x06000F22 RID: 3874 RVA: 0x00035E9C File Offset: 0x0003409C
		// (remove) Token: 0x06000F23 RID: 3875 RVA: 0x00035ED8 File Offset: 0x000340D8
		public event EventHandler OnRequestLeaveFullScreen;

		// Token: 0x14000132 RID: 306
		// (add) Token: 0x06000F24 RID: 3876 RVA: 0x00035F14 File Offset: 0x00034114
		// (remove) Token: 0x06000F25 RID: 3877 RVA: 0x00035F50 File Offset: 0x00034150
		public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x14000133 RID: 307
		// (add) Token: 0x06000F26 RID: 3878 RVA: 0x00035F8C File Offset: 0x0003418C
		// (remove) Token: 0x06000F27 RID: 3879 RVA: 0x00035FC8 File Offset: 0x000341C8
		public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x14000134 RID: 308
		// (add) Token: 0x06000F28 RID: 3880 RVA: 0x00036004 File Offset: 0x00034204
		// (remove) Token: 0x06000F29 RID: 3881 RVA: 0x00036040 File Offset: 0x00034240
		public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x14000135 RID: 309
		// (add) Token: 0x06000F2A RID: 3882 RVA: 0x0003607C File Offset: 0x0003427C
		// (remove) Token: 0x06000F2B RID: 3883 RVA: 0x000360B8 File Offset: 0x000342B8
		public event EventHandler OnIdleTimeoutNotification;

		// Token: 0x14000136 RID: 310
		// (add) Token: 0x06000F2C RID: 3884 RVA: 0x000360F4 File Offset: 0x000342F4
		// (remove) Token: 0x06000F2D RID: 3885 RVA: 0x00036130 File Offset: 0x00034330
		public event EventHandler OnRequestContainerMinimize;

		// Token: 0x14000137 RID: 311
		// (add) Token: 0x06000F2E RID: 3886 RVA: 0x0003616C File Offset: 0x0003436C
		// (remove) Token: 0x06000F2F RID: 3887 RVA: 0x000361A8 File Offset: 0x000343A8
		public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x14000138 RID: 312
		// (add) Token: 0x06000F30 RID: 3888 RVA: 0x000361E4 File Offset: 0x000343E4
		// (remove) Token: 0x06000F31 RID: 3889 RVA: 0x00036220 File Offset: 0x00034420
		public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x14000139 RID: 313
		// (add) Token: 0x06000F32 RID: 3890 RVA: 0x0003625C File Offset: 0x0003445C
		// (remove) Token: 0x06000F33 RID: 3891 RVA: 0x00036298 File Offset: 0x00034498
		public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x1400013A RID: 314
		// (add) Token: 0x06000F34 RID: 3892 RVA: 0x000362D4 File Offset: 0x000344D4
		// (remove) Token: 0x06000F35 RID: 3893 RVA: 0x00036310 File Offset: 0x00034510
		public event EventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x1400013B RID: 315
		// (add) Token: 0x06000F36 RID: 3894 RVA: 0x0003634C File Offset: 0x0003454C
		// (remove) Token: 0x06000F37 RID: 3895 RVA: 0x00036388 File Offset: 0x00034588
		public event EventHandler OnAuthenticationWarningDismissed;

		// Token: 0x1400013C RID: 316
		// (add) Token: 0x06000F38 RID: 3896 RVA: 0x000363C4 File Offset: 0x000345C4
		// (remove) Token: 0x06000F39 RID: 3897 RVA: 0x00036400 File Offset: 0x00034600
		public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x1400013D RID: 317
		// (add) Token: 0x06000F3A RID: 3898 RVA: 0x0003643C File Offset: 0x0003463C
		// (remove) Token: 0x06000F3B RID: 3899 RVA: 0x00036478 File Offset: 0x00034678
		public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x1400013E RID: 318
		// (add) Token: 0x06000F3C RID: 3900 RVA: 0x000364B4 File Offset: 0x000346B4
		// (remove) Token: 0x06000F3D RID: 3901 RVA: 0x000364F0 File Offset: 0x000346F0
		public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x1400013F RID: 319
		// (add) Token: 0x06000F3E RID: 3902 RVA: 0x0003652C File Offset: 0x0003472C
		// (remove) Token: 0x06000F3F RID: 3903 RVA: 0x00036568 File Offset: 0x00034768
		public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x14000140 RID: 320
		// (add) Token: 0x06000F40 RID: 3904 RVA: 0x000365A4 File Offset: 0x000347A4
		// (remove) Token: 0x06000F41 RID: 3905 RVA: 0x000365E0 File Offset: 0x000347E0
		public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x14000141 RID: 321
		// (add) Token: 0x06000F42 RID: 3906 RVA: 0x0003661C File Offset: 0x0003481C
		// (remove) Token: 0x06000F43 RID: 3907 RVA: 0x00036658 File Offset: 0x00034858
		public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x14000142 RID: 322
		// (add) Token: 0x06000F44 RID: 3908 RVA: 0x00036694 File Offset: 0x00034894
		// (remove) Token: 0x06000F45 RID: 3909 RVA: 0x000366D0 File Offset: 0x000348D0
		public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x14000143 RID: 323
		// (add) Token: 0x06000F46 RID: 3910 RVA: 0x0003670C File Offset: 0x0003490C
		// (remove) Token: 0x06000F47 RID: 3911 RVA: 0x00036748 File Offset: 0x00034948
		public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x14000144 RID: 324
		// (add) Token: 0x06000F48 RID: 3912 RVA: 0x00036784 File Offset: 0x00034984
		// (remove) Token: 0x06000F49 RID: 3913 RVA: 0x000367C0 File Offset: 0x000349C0
		public event EventHandler OnConnectionBarPullDown;

		// Token: 0x14000145 RID: 325
		// (add) Token: 0x06000F4A RID: 3914 RVA: 0x000367FC File Offset: 0x000349FC
		// (remove) Token: 0x06000F4B RID: 3915 RVA: 0x00036838 File Offset: 0x00034A38
		public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x14000146 RID: 326
		// (add) Token: 0x06000F4C RID: 3916 RVA: 0x00036874 File Offset: 0x00034A74
		// (remove) Token: 0x06000F4D RID: 3917 RVA: 0x000368B0 File Offset: 0x00034AB0
		public event EventHandler OnDevicesButtonPressed;

		// Token: 0x14000147 RID: 327
		// (add) Token: 0x06000F4E RID: 3918 RVA: 0x000368EC File Offset: 0x00034AEC
		// (remove) Token: 0x06000F4F RID: 3919 RVA: 0x00036928 File Offset: 0x00034B28
		public event EventHandler OnAutoReconnected;

		// Token: 0x14000148 RID: 328
		// (add) Token: 0x06000F50 RID: 3920 RVA: 0x00036964 File Offset: 0x00034B64
		// (remove) Token: 0x06000F51 RID: 3921 RVA: 0x000369A0 File Offset: 0x00034BA0
		public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

		// Token: 0x06000F52 RID: 3922 RVA: 0x000369DC File Offset: 0x00034BDC
		public virtual void Connect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Connect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Connect();
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x00036A00 File Offset: 0x00034C00
		public virtual void Disconnect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Disconnect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Disconnect();
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x00036A24 File Offset: 0x00034C24
		public virtual void CreateVirtualChannels(string newVal)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("CreateVirtualChannels", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.CreateVirtualChannels(newVal);
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x00036A4C File Offset: 0x00034C4C
		public virtual void SendOnVirtualChannel(string chanName, string chanData)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SendOnVirtualChannel", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SendOnVirtualChannel(chanName, chanData);
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x00036A74 File Offset: 0x00034C74
		public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SetVirtualChannelOptions(chanName, chanOptions);
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x00036A9C File Offset: 0x00034C9C
		public virtual int GetVirtualChannelOptions(string chanName)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetVirtualChannelOptions(chanName);
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x00036AD4 File Offset: 0x00034CD4
		public virtual ControlCloseStatus RequestClose()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("RequestClose", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.RequestClose();
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x00036B0C File Offset: 0x00034D0C
		protected override void CreateSink()
		{
			try
			{
				this.eventMulticaster = new AxMsRdpClient4EventMulticaster(this);
				this.cookie = new AxHost.ConnectionPointCookie(this.ocx, this.eventMulticaster, typeof(IMsTscAxEvents));
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x00036B64 File Offset: 0x00034D64
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

		// Token: 0x06000F5B RID: 3931 RVA: 0x00036B98 File Offset: 0x00034D98
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

		// Token: 0x06000F5C RID: 3932 RVA: 0x00036BD4 File Offset: 0x00034DD4
		internal void RaiseOnOnConnecting(object sender, EventArgs e)
		{
			if (this.OnConnecting != null)
			{
				this.OnConnecting(sender, e);
			}
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x00036BF0 File Offset: 0x00034DF0
		internal void RaiseOnOnConnected(object sender, EventArgs e)
		{
			if (this.OnConnected != null)
			{
				this.OnConnected(sender, e);
			}
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x00036C0C File Offset: 0x00034E0C
		internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
		{
			if (this.OnLoginComplete != null)
			{
				this.OnLoginComplete(sender, e);
			}
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x00036C28 File Offset: 0x00034E28
		internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
		{
			if (this.OnDisconnected != null)
			{
				this.OnDisconnected(sender, e);
			}
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x00036C44 File Offset: 0x00034E44
		internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnEnterFullScreenMode != null)
			{
				this.OnEnterFullScreenMode(sender, e);
			}
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x00036C60 File Offset: 0x00034E60
		internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnLeaveFullScreenMode != null)
			{
				this.OnLeaveFullScreenMode(sender, e);
			}
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x00036C7C File Offset: 0x00034E7C
		internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
		{
			if (this.OnChannelReceivedData != null)
			{
				this.OnChannelReceivedData(sender, e);
			}
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x00036C98 File Offset: 0x00034E98
		internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestGoFullScreen != null)
			{
				this.OnRequestGoFullScreen(sender, e);
			}
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x00036CB4 File Offset: 0x00034EB4
		internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestLeaveFullScreen != null)
			{
				this.OnRequestLeaveFullScreen(sender, e);
			}
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x00036CD0 File Offset: 0x00034ED0
		internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
		{
			if (this.OnFatalError != null)
			{
				this.OnFatalError(sender, e);
			}
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x00036CEC File Offset: 0x00034EEC
		internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
		{
			if (this.OnWarning != null)
			{
				this.OnWarning(sender, e);
			}
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x00036D08 File Offset: 0x00034F08
		internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
		{
			if (this.OnRemoteDesktopSizeChange != null)
			{
				this.OnRemoteDesktopSizeChange(sender, e);
			}
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x00036D24 File Offset: 0x00034F24
		internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
		{
			if (this.OnIdleTimeoutNotification != null)
			{
				this.OnIdleTimeoutNotification(sender, e);
			}
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x00036D40 File Offset: 0x00034F40
		internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
		{
			if (this.OnRequestContainerMinimize != null)
			{
				this.OnRequestContainerMinimize(sender, e);
			}
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x00036D5C File Offset: 0x00034F5C
		internal void RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
		{
			if (this.OnConfirmClose != null)
			{
				this.OnConfirmClose(sender, e);
			}
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x00036D78 File Offset: 0x00034F78
		internal void RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
		{
			if (this.OnReceivedTSPublicKey != null)
			{
				this.OnReceivedTSPublicKey(sender, e);
			}
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x00036D94 File Offset: 0x00034F94
		internal void RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
		{
			if (this.OnAutoReconnecting != null)
			{
				this.OnAutoReconnecting(sender, e);
			}
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x00036DB0 File Offset: 0x00034FB0
		internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDisplayed != null)
			{
				this.OnAuthenticationWarningDisplayed(sender, e);
			}
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x00036DCC File Offset: 0x00034FCC
		internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDismissed != null)
			{
				this.OnAuthenticationWarningDismissed(sender, e);
			}
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x00036DE8 File Offset: 0x00034FE8
		internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
		{
			if (this.OnRemoteProgramResult != null)
			{
				this.OnRemoteProgramResult(sender, e);
			}
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x00036E04 File Offset: 0x00035004
		internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
		{
			if (this.OnRemoteProgramDisplayed != null)
			{
				this.OnRemoteProgramDisplayed(sender, e);
			}
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x00036E20 File Offset: 0x00035020
		internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
		{
			if (this.OnRemoteWindowDisplayed != null)
			{
				this.OnRemoteWindowDisplayed(sender, e);
			}
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x00036E3C File Offset: 0x0003503C
		internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
		{
			if (this.OnLogonError != null)
			{
				this.OnLogonError(sender, e);
			}
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x00036E58 File Offset: 0x00035058
		internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
		{
			if (this.OnFocusReleased != null)
			{
				this.OnFocusReleased(sender, e);
			}
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x00036E74 File Offset: 0x00035074
		internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
		{
			if (this.OnUserNameAcquired != null)
			{
				this.OnUserNameAcquired(sender, e);
			}
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x00036E90 File Offset: 0x00035090
		internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
		{
			if (this.OnMouseInputModeChanged != null)
			{
				this.OnMouseInputModeChanged(sender, e);
			}
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x00036EAC File Offset: 0x000350AC
		internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
		{
			if (this.OnServiceMessageReceived != null)
			{
				this.OnServiceMessageReceived(sender, e);
			}
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x00036EC8 File Offset: 0x000350C8
		internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
		{
			if (this.OnConnectionBarPullDown != null)
			{
				this.OnConnectionBarPullDown(sender, e);
			}
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x00036EE4 File Offset: 0x000350E4
		internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
		{
			if (this.OnNetworkStatusChanged != null)
			{
				this.OnNetworkStatusChanged(sender, e);
			}
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x00036F00 File Offset: 0x00035100
		internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
		{
			if (this.OnDevicesButtonPressed != null)
			{
				this.OnDevicesButtonPressed(sender, e);
			}
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x00036F1C File Offset: 0x0003511C
		internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
		{
			if (this.OnAutoReconnected != null)
			{
				this.OnAutoReconnected(sender, e);
			}
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x00036F38 File Offset: 0x00035138
		internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
		{
			if (this.OnAutoReconnecting2 != null)
			{
				this.OnAutoReconnecting2(sender, e);
			}
		}

		// Token: 0x040004CF RID: 1231
		private IMsRdpClient4 ocx;

		// Token: 0x040004D0 RID: 1232
		private AxMsRdpClient4EventMulticaster eventMulticaster;

		// Token: 0x040004D1 RID: 1233
		private AxHost.ConnectionPointCookie cookie;
	}
}
