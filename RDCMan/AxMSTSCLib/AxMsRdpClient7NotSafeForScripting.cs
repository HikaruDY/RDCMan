using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MSTSCLib;

namespace AxMSTSCLib
{
	// Token: 0x02000134 RID: 308
	[DefaultEvent("OnConnecting")]
	[AxHost.ClsidAttribute("{54d38bf7-b1ef-4479-9674-1bd6ea465258}")]
	[DesignTimeVisible(true)]
	[ComVisible(true)]
	public class AxMsRdpClient7NotSafeForScripting : AxHost
	{
		// Token: 0x0600132F RID: 4911 RVA: 0x000417D4 File Offset: 0x0003F9D4
		public AxMsRdpClient7NotSafeForScripting() : base("54d38bf7-b1ef-4479-9674-1bd6ea465258")
		{
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06001330 RID: 4912 RVA: 0x000417E4 File Offset: 0x0003F9E4
		// (set) Token: 0x06001331 RID: 4913 RVA: 0x00041808 File Offset: 0x0003FA08
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

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06001332 RID: 4914 RVA: 0x00041830 File Offset: 0x0003FA30
		// (set) Token: 0x06001333 RID: 4915 RVA: 0x00041854 File Offset: 0x0003FA54
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

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06001334 RID: 4916 RVA: 0x0004187C File Offset: 0x0003FA7C
		// (set) Token: 0x06001335 RID: 4917 RVA: 0x000418A0 File Offset: 0x0003FAA0
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

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06001336 RID: 4918 RVA: 0x000418C8 File Offset: 0x0003FAC8
		// (set) Token: 0x06001337 RID: 4919 RVA: 0x000418EC File Offset: 0x0003FAEC
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

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06001338 RID: 4920 RVA: 0x00041914 File Offset: 0x0003FB14
		// (set) Token: 0x06001339 RID: 4921 RVA: 0x00041938 File Offset: 0x0003FB38
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

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x0600133A RID: 4922 RVA: 0x00041960 File Offset: 0x0003FB60
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

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x0600133B RID: 4923 RVA: 0x00041984 File Offset: 0x0003FB84
		// (set) Token: 0x0600133C RID: 4924 RVA: 0x000419A8 File Offset: 0x0003FBA8
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

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x0600133D RID: 4925 RVA: 0x000419D0 File Offset: 0x0003FBD0
		// (set) Token: 0x0600133E RID: 4926 RVA: 0x000419F4 File Offset: 0x0003FBF4
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

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x0600133F RID: 4927 RVA: 0x00041A1C File Offset: 0x0003FC1C
		// (set) Token: 0x06001340 RID: 4928 RVA: 0x00041A40 File Offset: 0x0003FC40
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

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06001341 RID: 4929 RVA: 0x00041A68 File Offset: 0x0003FC68
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

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06001342 RID: 4930 RVA: 0x00041A8C File Offset: 0x0003FC8C
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

		// Token: 0x1700036F RID: 879
		// (set) Token: 0x06001343 RID: 4931 RVA: 0x00041AB0 File Offset: 0x0003FCB0
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

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06001344 RID: 4932 RVA: 0x00041AD8 File Offset: 0x0003FCD8
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

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06001345 RID: 4933 RVA: 0x00041AFC File Offset: 0x0003FCFC
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

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06001346 RID: 4934 RVA: 0x00041B20 File Offset: 0x0003FD20
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

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06001347 RID: 4935 RVA: 0x00041B44 File Offset: 0x0003FD44
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

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06001348 RID: 4936 RVA: 0x00041B68 File Offset: 0x0003FD68
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

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06001349 RID: 4937 RVA: 0x00041B8C File Offset: 0x0003FD8C
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

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x0600134A RID: 4938 RVA: 0x00041BB0 File Offset: 0x0003FDB0
		// (set) Token: 0x0600134B RID: 4939 RVA: 0x00041BD4 File Offset: 0x0003FDD4
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

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x0600134C RID: 4940 RVA: 0x00041BFC File Offset: 0x0003FDFC
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

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x0600134D RID: 4941 RVA: 0x00041C20 File Offset: 0x0003FE20
		[DispId(102)]
		[Browsable(false)]
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

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x0600134E RID: 4942 RVA: 0x00041C44 File Offset: 0x0003FE44
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

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x0600134F RID: 4943 RVA: 0x00041C68 File Offset: 0x0003FE68
		// (set) Token: 0x06001350 RID: 4944 RVA: 0x00041C8C File Offset: 0x0003FE8C
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

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06001351 RID: 4945 RVA: 0x00041CB4 File Offset: 0x0003FEB4
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

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06001352 RID: 4946 RVA: 0x00041CD8 File Offset: 0x0003FED8
		// (set) Token: 0x06001353 RID: 4947 RVA: 0x00041CFC File Offset: 0x0003FEFC
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

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06001354 RID: 4948 RVA: 0x00041D24 File Offset: 0x0003FF24
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

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06001355 RID: 4949 RVA: 0x00041D48 File Offset: 0x0003FF48
		[Browsable(false)]
		[DispId(400)]
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

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06001356 RID: 4950 RVA: 0x00041D6C File Offset: 0x0003FF6C
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

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06001357 RID: 4951 RVA: 0x00041D90 File Offset: 0x0003FF90
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

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06001358 RID: 4952 RVA: 0x00041DB4 File Offset: 0x0003FFB4
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

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06001359 RID: 4953 RVA: 0x00041DD8 File Offset: 0x0003FFD8
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

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x0600135A RID: 4954 RVA: 0x00041DFC File Offset: 0x0003FFFC
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

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x0600135B RID: 4955 RVA: 0x00041E20 File Offset: 0x00040020
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

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x0600135C RID: 4956 RVA: 0x00041E44 File Offset: 0x00040044
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

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x0600135D RID: 4957 RVA: 0x00041E68 File Offset: 0x00040068
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

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x0600135E RID: 4958 RVA: 0x00041E8C File Offset: 0x0004008C
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(603)]
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

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x0600135F RID: 4959 RVA: 0x00041EB0 File Offset: 0x000400B0
		[DispId(604)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x140001E9 RID: 489
		// (add) Token: 0x06001360 RID: 4960 RVA: 0x00041ED4 File Offset: 0x000400D4
		// (remove) Token: 0x06001361 RID: 4961 RVA: 0x00041F10 File Offset: 0x00040110
		public event EventHandler OnConnecting;

		// Token: 0x140001EA RID: 490
		// (add) Token: 0x06001362 RID: 4962 RVA: 0x00041F4C File Offset: 0x0004014C
		// (remove) Token: 0x06001363 RID: 4963 RVA: 0x00041F88 File Offset: 0x00040188
		public event EventHandler OnConnected;

		// Token: 0x140001EB RID: 491
		// (add) Token: 0x06001364 RID: 4964 RVA: 0x00041FC4 File Offset: 0x000401C4
		// (remove) Token: 0x06001365 RID: 4965 RVA: 0x00042000 File Offset: 0x00040200
		public event EventHandler OnLoginComplete;

		// Token: 0x140001EC RID: 492
		// (add) Token: 0x06001366 RID: 4966 RVA: 0x0004203C File Offset: 0x0004023C
		// (remove) Token: 0x06001367 RID: 4967 RVA: 0x00042078 File Offset: 0x00040278
		public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x140001ED RID: 493
		// (add) Token: 0x06001368 RID: 4968 RVA: 0x000420B4 File Offset: 0x000402B4
		// (remove) Token: 0x06001369 RID: 4969 RVA: 0x000420F0 File Offset: 0x000402F0
		public event EventHandler OnEnterFullScreenMode;

		// Token: 0x140001EE RID: 494
		// (add) Token: 0x0600136A RID: 4970 RVA: 0x0004212C File Offset: 0x0004032C
		// (remove) Token: 0x0600136B RID: 4971 RVA: 0x00042168 File Offset: 0x00040368
		public event EventHandler OnLeaveFullScreenMode;

		// Token: 0x140001EF RID: 495
		// (add) Token: 0x0600136C RID: 4972 RVA: 0x000421A4 File Offset: 0x000403A4
		// (remove) Token: 0x0600136D RID: 4973 RVA: 0x000421E0 File Offset: 0x000403E0
		public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x140001F0 RID: 496
		// (add) Token: 0x0600136E RID: 4974 RVA: 0x0004221C File Offset: 0x0004041C
		// (remove) Token: 0x0600136F RID: 4975 RVA: 0x00042258 File Offset: 0x00040458
		public event EventHandler OnRequestGoFullScreen;

		// Token: 0x140001F1 RID: 497
		// (add) Token: 0x06001370 RID: 4976 RVA: 0x00042294 File Offset: 0x00040494
		// (remove) Token: 0x06001371 RID: 4977 RVA: 0x000422D0 File Offset: 0x000404D0
		public event EventHandler OnRequestLeaveFullScreen;

		// Token: 0x140001F2 RID: 498
		// (add) Token: 0x06001372 RID: 4978 RVA: 0x0004230C File Offset: 0x0004050C
		// (remove) Token: 0x06001373 RID: 4979 RVA: 0x00042348 File Offset: 0x00040548
		public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x140001F3 RID: 499
		// (add) Token: 0x06001374 RID: 4980 RVA: 0x00042384 File Offset: 0x00040584
		// (remove) Token: 0x06001375 RID: 4981 RVA: 0x000423C0 File Offset: 0x000405C0
		public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x140001F4 RID: 500
		// (add) Token: 0x06001376 RID: 4982 RVA: 0x000423FC File Offset: 0x000405FC
		// (remove) Token: 0x06001377 RID: 4983 RVA: 0x00042438 File Offset: 0x00040638
		public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x140001F5 RID: 501
		// (add) Token: 0x06001378 RID: 4984 RVA: 0x00042474 File Offset: 0x00040674
		// (remove) Token: 0x06001379 RID: 4985 RVA: 0x000424B0 File Offset: 0x000406B0
		public event EventHandler OnIdleTimeoutNotification;

		// Token: 0x140001F6 RID: 502
		// (add) Token: 0x0600137A RID: 4986 RVA: 0x000424EC File Offset: 0x000406EC
		// (remove) Token: 0x0600137B RID: 4987 RVA: 0x00042528 File Offset: 0x00040728
		public event EventHandler OnRequestContainerMinimize;

		// Token: 0x140001F7 RID: 503
		// (add) Token: 0x0600137C RID: 4988 RVA: 0x00042564 File Offset: 0x00040764
		// (remove) Token: 0x0600137D RID: 4989 RVA: 0x000425A0 File Offset: 0x000407A0
		public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x140001F8 RID: 504
		// (add) Token: 0x0600137E RID: 4990 RVA: 0x000425DC File Offset: 0x000407DC
		// (remove) Token: 0x0600137F RID: 4991 RVA: 0x00042618 File Offset: 0x00040818
		public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x140001F9 RID: 505
		// (add) Token: 0x06001380 RID: 4992 RVA: 0x00042654 File Offset: 0x00040854
		// (remove) Token: 0x06001381 RID: 4993 RVA: 0x00042690 File Offset: 0x00040890
		public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x140001FA RID: 506
		// (add) Token: 0x06001382 RID: 4994 RVA: 0x000426CC File Offset: 0x000408CC
		// (remove) Token: 0x06001383 RID: 4995 RVA: 0x00042708 File Offset: 0x00040908
		public event EventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x140001FB RID: 507
		// (add) Token: 0x06001384 RID: 4996 RVA: 0x00042744 File Offset: 0x00040944
		// (remove) Token: 0x06001385 RID: 4997 RVA: 0x00042780 File Offset: 0x00040980
		public event EventHandler OnAuthenticationWarningDismissed;

		// Token: 0x140001FC RID: 508
		// (add) Token: 0x06001386 RID: 4998 RVA: 0x000427BC File Offset: 0x000409BC
		// (remove) Token: 0x06001387 RID: 4999 RVA: 0x000427F8 File Offset: 0x000409F8
		public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x140001FD RID: 509
		// (add) Token: 0x06001388 RID: 5000 RVA: 0x00042834 File Offset: 0x00040A34
		// (remove) Token: 0x06001389 RID: 5001 RVA: 0x00042870 File Offset: 0x00040A70
		public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x140001FE RID: 510
		// (add) Token: 0x0600138A RID: 5002 RVA: 0x000428AC File Offset: 0x00040AAC
		// (remove) Token: 0x0600138B RID: 5003 RVA: 0x000428E8 File Offset: 0x00040AE8
		public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x140001FF RID: 511
		// (add) Token: 0x0600138C RID: 5004 RVA: 0x00042924 File Offset: 0x00040B24
		// (remove) Token: 0x0600138D RID: 5005 RVA: 0x00042960 File Offset: 0x00040B60
		public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x14000200 RID: 512
		// (add) Token: 0x0600138E RID: 5006 RVA: 0x0004299C File Offset: 0x00040B9C
		// (remove) Token: 0x0600138F RID: 5007 RVA: 0x000429D8 File Offset: 0x00040BD8
		public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x14000201 RID: 513
		// (add) Token: 0x06001390 RID: 5008 RVA: 0x00042A14 File Offset: 0x00040C14
		// (remove) Token: 0x06001391 RID: 5009 RVA: 0x00042A50 File Offset: 0x00040C50
		public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x14000202 RID: 514
		// (add) Token: 0x06001392 RID: 5010 RVA: 0x00042A8C File Offset: 0x00040C8C
		// (remove) Token: 0x06001393 RID: 5011 RVA: 0x00042AC8 File Offset: 0x00040CC8
		public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x14000203 RID: 515
		// (add) Token: 0x06001394 RID: 5012 RVA: 0x00042B04 File Offset: 0x00040D04
		// (remove) Token: 0x06001395 RID: 5013 RVA: 0x00042B40 File Offset: 0x00040D40
		public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x14000204 RID: 516
		// (add) Token: 0x06001396 RID: 5014 RVA: 0x00042B7C File Offset: 0x00040D7C
		// (remove) Token: 0x06001397 RID: 5015 RVA: 0x00042BB8 File Offset: 0x00040DB8
		public event EventHandler OnConnectionBarPullDown;

		// Token: 0x14000205 RID: 517
		// (add) Token: 0x06001398 RID: 5016 RVA: 0x00042BF4 File Offset: 0x00040DF4
		// (remove) Token: 0x06001399 RID: 5017 RVA: 0x00042C30 File Offset: 0x00040E30
		public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x14000206 RID: 518
		// (add) Token: 0x0600139A RID: 5018 RVA: 0x00042C6C File Offset: 0x00040E6C
		// (remove) Token: 0x0600139B RID: 5019 RVA: 0x00042CA8 File Offset: 0x00040EA8
		public event EventHandler OnDevicesButtonPressed;

		// Token: 0x14000207 RID: 519
		// (add) Token: 0x0600139C RID: 5020 RVA: 0x00042CE4 File Offset: 0x00040EE4
		// (remove) Token: 0x0600139D RID: 5021 RVA: 0x00042D20 File Offset: 0x00040F20
		public event EventHandler OnAutoReconnected;

		// Token: 0x14000208 RID: 520
		// (add) Token: 0x0600139E RID: 5022 RVA: 0x00042D5C File Offset: 0x00040F5C
		// (remove) Token: 0x0600139F RID: 5023 RVA: 0x00042D98 File Offset: 0x00040F98
		public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

		// Token: 0x060013A0 RID: 5024 RVA: 0x00042DD4 File Offset: 0x00040FD4
		public virtual void Connect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Connect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Connect();
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x00042DF8 File Offset: 0x00040FF8
		public virtual void Disconnect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Disconnect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Disconnect();
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x00042E1C File Offset: 0x0004101C
		public virtual void CreateVirtualChannels(string newVal)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("CreateVirtualChannels", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.CreateVirtualChannels(newVal);
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x00042E44 File Offset: 0x00041044
		public virtual void SendOnVirtualChannel(string chanName, string chanData)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SendOnVirtualChannel", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SendOnVirtualChannel(chanName, chanData);
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x00042E6C File Offset: 0x0004106C
		public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SetVirtualChannelOptions(chanName, chanOptions);
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x00042E94 File Offset: 0x00041094
		public virtual int GetVirtualChannelOptions(string chanName)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetVirtualChannelOptions(chanName);
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x00042ECC File Offset: 0x000410CC
		public virtual ControlCloseStatus RequestClose()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("RequestClose", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.RequestClose();
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x00042F04 File Offset: 0x00041104
		public virtual string GetErrorDescription(uint disconnectReason, uint extendedDisconnectReason)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetErrorDescription", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetErrorDescription(disconnectReason, extendedDisconnectReason);
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x00042F3C File Offset: 0x0004113C
		public virtual string GetStatusText(uint statusCode)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetStatusText", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetStatusText(statusCode);
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x00042F74 File Offset: 0x00041174
		protected override void CreateSink()
		{
			try
			{
				this.eventMulticaster = new AxMsRdpClient7NotSafeForScriptingEventMulticaster(this);
				this.cookie = new AxHost.ConnectionPointCookie(this.ocx, this.eventMulticaster, typeof(IMsTscAxEvents));
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x00042FCC File Offset: 0x000411CC
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

		// Token: 0x060013AB RID: 5035 RVA: 0x00043000 File Offset: 0x00041200
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

		// Token: 0x060013AC RID: 5036 RVA: 0x0004303C File Offset: 0x0004123C
		internal void RaiseOnOnConnecting(object sender, EventArgs e)
		{
			if (this.OnConnecting != null)
			{
				this.OnConnecting(sender, e);
			}
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x00043058 File Offset: 0x00041258
		internal void RaiseOnOnConnected(object sender, EventArgs e)
		{
			if (this.OnConnected != null)
			{
				this.OnConnected(sender, e);
			}
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x00043074 File Offset: 0x00041274
		internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
		{
			if (this.OnLoginComplete != null)
			{
				this.OnLoginComplete(sender, e);
			}
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x00043090 File Offset: 0x00041290
		internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
		{
			if (this.OnDisconnected != null)
			{
				this.OnDisconnected(sender, e);
			}
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x000430AC File Offset: 0x000412AC
		internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnEnterFullScreenMode != null)
			{
				this.OnEnterFullScreenMode(sender, e);
			}
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x000430C8 File Offset: 0x000412C8
		internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnLeaveFullScreenMode != null)
			{
				this.OnLeaveFullScreenMode(sender, e);
			}
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x000430E4 File Offset: 0x000412E4
		internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
		{
			if (this.OnChannelReceivedData != null)
			{
				this.OnChannelReceivedData(sender, e);
			}
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x00043100 File Offset: 0x00041300
		internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestGoFullScreen != null)
			{
				this.OnRequestGoFullScreen(sender, e);
			}
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x0004311C File Offset: 0x0004131C
		internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestLeaveFullScreen != null)
			{
				this.OnRequestLeaveFullScreen(sender, e);
			}
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x00043138 File Offset: 0x00041338
		internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
		{
			if (this.OnFatalError != null)
			{
				this.OnFatalError(sender, e);
			}
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x00043154 File Offset: 0x00041354
		internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
		{
			if (this.OnWarning != null)
			{
				this.OnWarning(sender, e);
			}
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x00043170 File Offset: 0x00041370
		internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
		{
			if (this.OnRemoteDesktopSizeChange != null)
			{
				this.OnRemoteDesktopSizeChange(sender, e);
			}
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x0004318C File Offset: 0x0004138C
		internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
		{
			if (this.OnIdleTimeoutNotification != null)
			{
				this.OnIdleTimeoutNotification(sender, e);
			}
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x000431A8 File Offset: 0x000413A8
		internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
		{
			if (this.OnRequestContainerMinimize != null)
			{
				this.OnRequestContainerMinimize(sender, e);
			}
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x000431C4 File Offset: 0x000413C4
		internal void RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
		{
			if (this.OnConfirmClose != null)
			{
				this.OnConfirmClose(sender, e);
			}
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x000431E0 File Offset: 0x000413E0
		internal void RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
		{
			if (this.OnReceivedTSPublicKey != null)
			{
				this.OnReceivedTSPublicKey(sender, e);
			}
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x000431FC File Offset: 0x000413FC
		internal void RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
		{
			if (this.OnAutoReconnecting != null)
			{
				this.OnAutoReconnecting(sender, e);
			}
		}

		// Token: 0x060013BD RID: 5053 RVA: 0x00043218 File Offset: 0x00041418
		internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDisplayed != null)
			{
				this.OnAuthenticationWarningDisplayed(sender, e);
			}
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x00043234 File Offset: 0x00041434
		internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDismissed != null)
			{
				this.OnAuthenticationWarningDismissed(sender, e);
			}
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x00043250 File Offset: 0x00041450
		internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
		{
			if (this.OnRemoteProgramResult != null)
			{
				this.OnRemoteProgramResult(sender, e);
			}
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x0004326C File Offset: 0x0004146C
		internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
		{
			if (this.OnRemoteProgramDisplayed != null)
			{
				this.OnRemoteProgramDisplayed(sender, e);
			}
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x00043288 File Offset: 0x00041488
		internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
		{
			if (this.OnRemoteWindowDisplayed != null)
			{
				this.OnRemoteWindowDisplayed(sender, e);
			}
		}

		// Token: 0x060013C2 RID: 5058 RVA: 0x000432A4 File Offset: 0x000414A4
		internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
		{
			if (this.OnLogonError != null)
			{
				this.OnLogonError(sender, e);
			}
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x000432C0 File Offset: 0x000414C0
		internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
		{
			if (this.OnFocusReleased != null)
			{
				this.OnFocusReleased(sender, e);
			}
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x000432DC File Offset: 0x000414DC
		internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
		{
			if (this.OnUserNameAcquired != null)
			{
				this.OnUserNameAcquired(sender, e);
			}
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x000432F8 File Offset: 0x000414F8
		internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
		{
			if (this.OnMouseInputModeChanged != null)
			{
				this.OnMouseInputModeChanged(sender, e);
			}
		}

		// Token: 0x060013C6 RID: 5062 RVA: 0x00043314 File Offset: 0x00041514
		internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
		{
			if (this.OnServiceMessageReceived != null)
			{
				this.OnServiceMessageReceived(sender, e);
			}
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x00043330 File Offset: 0x00041530
		internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
		{
			if (this.OnConnectionBarPullDown != null)
			{
				this.OnConnectionBarPullDown(sender, e);
			}
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x0004334C File Offset: 0x0004154C
		internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
		{
			if (this.OnNetworkStatusChanged != null)
			{
				this.OnNetworkStatusChanged(sender, e);
			}
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x00043368 File Offset: 0x00041568
		internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
		{
			if (this.OnDevicesButtonPressed != null)
			{
				this.OnDevicesButtonPressed(sender, e);
			}
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x00043384 File Offset: 0x00041584
		internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
		{
			if (this.OnAutoReconnected != null)
			{
				this.OnAutoReconnected(sender, e);
			}
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x000433A0 File Offset: 0x000415A0
		internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
		{
			if (this.OnAutoReconnecting2 != null)
			{
				this.OnAutoReconnecting2(sender, e);
			}
		}

		// Token: 0x040005A7 RID: 1447
		private IMsRdpClient7 ocx;

		// Token: 0x040005A8 RID: 1448
		private AxMsRdpClient7NotSafeForScriptingEventMulticaster eventMulticaster;

		// Token: 0x040005A9 RID: 1449
		private AxHost.ConnectionPointCookie cookie;
	}
}
