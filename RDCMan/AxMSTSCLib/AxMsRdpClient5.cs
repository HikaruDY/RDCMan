using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MSTSCLib;

namespace AxMSTSCLib
{
	// Token: 0x0200012E RID: 302
	[DefaultEvent("OnConnecting")]
	[AxHost.ClsidAttribute("{4eb89ff4-7f78-4a0f-8b8d-2bf02e94e4b2}")]
	[DesignTimeVisible(true)]
	[ComVisible(true)]
	public class AxMsRdpClient5 : AxHost
	{
		// Token: 0x06001106 RID: 4358 RVA: 0x0003B57C File Offset: 0x0003977C
		public AxMsRdpClient5() : base("4eb89ff4-7f78-4a0f-8b8d-2bf02e94e4b2")
		{
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06001107 RID: 4359 RVA: 0x0003B58C File Offset: 0x0003978C
		// (set) Token: 0x06001108 RID: 4360 RVA: 0x0003B5B0 File Offset: 0x000397B0
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

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06001109 RID: 4361 RVA: 0x0003B5D8 File Offset: 0x000397D8
		// (set) Token: 0x0600110A RID: 4362 RVA: 0x0003B5FC File Offset: 0x000397FC
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

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x0600110B RID: 4363 RVA: 0x0003B624 File Offset: 0x00039824
		// (set) Token: 0x0600110C RID: 4364 RVA: 0x0003B648 File Offset: 0x00039848
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

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x0600110D RID: 4365 RVA: 0x0003B670 File Offset: 0x00039870
		// (set) Token: 0x0600110E RID: 4366 RVA: 0x0003B694 File Offset: 0x00039894
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

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x0600110F RID: 4367 RVA: 0x0003B6BC File Offset: 0x000398BC
		// (set) Token: 0x06001110 RID: 4368 RVA: 0x0003B6E0 File Offset: 0x000398E0
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

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06001111 RID: 4369 RVA: 0x0003B708 File Offset: 0x00039908
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

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06001112 RID: 4370 RVA: 0x0003B72C File Offset: 0x0003992C
		// (set) Token: 0x06001113 RID: 4371 RVA: 0x0003B750 File Offset: 0x00039950
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

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06001114 RID: 4372 RVA: 0x0003B778 File Offset: 0x00039978
		// (set) Token: 0x06001115 RID: 4373 RVA: 0x0003B79C File Offset: 0x0003999C
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

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06001116 RID: 4374 RVA: 0x0003B7C4 File Offset: 0x000399C4
		// (set) Token: 0x06001117 RID: 4375 RVA: 0x0003B7E8 File Offset: 0x000399E8
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

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06001118 RID: 4376 RVA: 0x0003B810 File Offset: 0x00039A10
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

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06001119 RID: 4377 RVA: 0x0003B834 File Offset: 0x00039A34
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

		// Token: 0x1700030E RID: 782
		// (set) Token: 0x0600111A RID: 4378 RVA: 0x0003B858 File Offset: 0x00039A58
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

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x0600111B RID: 4379 RVA: 0x0003B880 File Offset: 0x00039A80
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

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x0600111C RID: 4380 RVA: 0x0003B8A4 File Offset: 0x00039AA4
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

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x0600111D RID: 4381 RVA: 0x0003B8C8 File Offset: 0x00039AC8
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

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x0600111E RID: 4382 RVA: 0x0003B8EC File Offset: 0x00039AEC
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

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x0600111F RID: 4383 RVA: 0x0003B910 File Offset: 0x00039B10
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
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

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06001120 RID: 4384 RVA: 0x0003B934 File Offset: 0x00039B34
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

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06001121 RID: 4385 RVA: 0x0003B958 File Offset: 0x00039B58
		// (set) Token: 0x06001122 RID: 4386 RVA: 0x0003B97C File Offset: 0x00039B7C
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

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06001123 RID: 4387 RVA: 0x0003B9A4 File Offset: 0x00039BA4
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

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06001124 RID: 4388 RVA: 0x0003B9C8 File Offset: 0x00039BC8
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

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06001125 RID: 4389 RVA: 0x0003B9EC File Offset: 0x00039BEC
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

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06001126 RID: 4390 RVA: 0x0003BA10 File Offset: 0x00039C10
		// (set) Token: 0x06001127 RID: 4391 RVA: 0x0003BA34 File Offset: 0x00039C34
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

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06001128 RID: 4392 RVA: 0x0003BA5C File Offset: 0x00039C5C
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

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06001129 RID: 4393 RVA: 0x0003BA80 File Offset: 0x00039C80
		// (set) Token: 0x0600112A RID: 4394 RVA: 0x0003BAA4 File Offset: 0x00039CA4
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

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x0600112B RID: 4395 RVA: 0x0003BACC File Offset: 0x00039CCC
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

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x0600112C RID: 4396 RVA: 0x0003BAF0 File Offset: 0x00039CF0
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

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x0600112D RID: 4397 RVA: 0x0003BB14 File Offset: 0x00039D14
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

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x0600112E RID: 4398 RVA: 0x0003BB38 File Offset: 0x00039D38
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

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x0600112F RID: 4399 RVA: 0x0003BB5C File Offset: 0x00039D5C
		[DispId(504)]
		[Browsable(false)]
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

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06001130 RID: 4400 RVA: 0x0003BB80 File Offset: 0x00039D80
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

		// Token: 0x14000189 RID: 393
		// (add) Token: 0x06001131 RID: 4401 RVA: 0x0003BBA4 File Offset: 0x00039DA4
		// (remove) Token: 0x06001132 RID: 4402 RVA: 0x0003BBE0 File Offset: 0x00039DE0
		public event EventHandler OnConnecting;

		// Token: 0x1400018A RID: 394
		// (add) Token: 0x06001133 RID: 4403 RVA: 0x0003BC1C File Offset: 0x00039E1C
		// (remove) Token: 0x06001134 RID: 4404 RVA: 0x0003BC58 File Offset: 0x00039E58
		public event EventHandler OnConnected;

		// Token: 0x1400018B RID: 395
		// (add) Token: 0x06001135 RID: 4405 RVA: 0x0003BC94 File Offset: 0x00039E94
		// (remove) Token: 0x06001136 RID: 4406 RVA: 0x0003BCD0 File Offset: 0x00039ED0
		public event EventHandler OnLoginComplete;

		// Token: 0x1400018C RID: 396
		// (add) Token: 0x06001137 RID: 4407 RVA: 0x0003BD0C File Offset: 0x00039F0C
		// (remove) Token: 0x06001138 RID: 4408 RVA: 0x0003BD48 File Offset: 0x00039F48
		public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x1400018D RID: 397
		// (add) Token: 0x06001139 RID: 4409 RVA: 0x0003BD84 File Offset: 0x00039F84
		// (remove) Token: 0x0600113A RID: 4410 RVA: 0x0003BDC0 File Offset: 0x00039FC0
		public event EventHandler OnEnterFullScreenMode;

		// Token: 0x1400018E RID: 398
		// (add) Token: 0x0600113B RID: 4411 RVA: 0x0003BDFC File Offset: 0x00039FFC
		// (remove) Token: 0x0600113C RID: 4412 RVA: 0x0003BE38 File Offset: 0x0003A038
		public event EventHandler OnLeaveFullScreenMode;

		// Token: 0x1400018F RID: 399
		// (add) Token: 0x0600113D RID: 4413 RVA: 0x0003BE74 File Offset: 0x0003A074
		// (remove) Token: 0x0600113E RID: 4414 RVA: 0x0003BEB0 File Offset: 0x0003A0B0
		public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x14000190 RID: 400
		// (add) Token: 0x0600113F RID: 4415 RVA: 0x0003BEEC File Offset: 0x0003A0EC
		// (remove) Token: 0x06001140 RID: 4416 RVA: 0x0003BF28 File Offset: 0x0003A128
		public event EventHandler OnRequestGoFullScreen;

		// Token: 0x14000191 RID: 401
		// (add) Token: 0x06001141 RID: 4417 RVA: 0x0003BF64 File Offset: 0x0003A164
		// (remove) Token: 0x06001142 RID: 4418 RVA: 0x0003BFA0 File Offset: 0x0003A1A0
		public event EventHandler OnRequestLeaveFullScreen;

		// Token: 0x14000192 RID: 402
		// (add) Token: 0x06001143 RID: 4419 RVA: 0x0003BFDC File Offset: 0x0003A1DC
		// (remove) Token: 0x06001144 RID: 4420 RVA: 0x0003C018 File Offset: 0x0003A218
		public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x14000193 RID: 403
		// (add) Token: 0x06001145 RID: 4421 RVA: 0x0003C054 File Offset: 0x0003A254
		// (remove) Token: 0x06001146 RID: 4422 RVA: 0x0003C090 File Offset: 0x0003A290
		public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x14000194 RID: 404
		// (add) Token: 0x06001147 RID: 4423 RVA: 0x0003C0CC File Offset: 0x0003A2CC
		// (remove) Token: 0x06001148 RID: 4424 RVA: 0x0003C108 File Offset: 0x0003A308
		public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x14000195 RID: 405
		// (add) Token: 0x06001149 RID: 4425 RVA: 0x0003C144 File Offset: 0x0003A344
		// (remove) Token: 0x0600114A RID: 4426 RVA: 0x0003C180 File Offset: 0x0003A380
		public event EventHandler OnIdleTimeoutNotification;

		// Token: 0x14000196 RID: 406
		// (add) Token: 0x0600114B RID: 4427 RVA: 0x0003C1BC File Offset: 0x0003A3BC
		// (remove) Token: 0x0600114C RID: 4428 RVA: 0x0003C1F8 File Offset: 0x0003A3F8
		public event EventHandler OnRequestContainerMinimize;

		// Token: 0x14000197 RID: 407
		// (add) Token: 0x0600114D RID: 4429 RVA: 0x0003C234 File Offset: 0x0003A434
		// (remove) Token: 0x0600114E RID: 4430 RVA: 0x0003C270 File Offset: 0x0003A470
		public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x14000198 RID: 408
		// (add) Token: 0x0600114F RID: 4431 RVA: 0x0003C2AC File Offset: 0x0003A4AC
		// (remove) Token: 0x06001150 RID: 4432 RVA: 0x0003C2E8 File Offset: 0x0003A4E8
		public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x14000199 RID: 409
		// (add) Token: 0x06001151 RID: 4433 RVA: 0x0003C324 File Offset: 0x0003A524
		// (remove) Token: 0x06001152 RID: 4434 RVA: 0x0003C360 File Offset: 0x0003A560
		public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x1400019A RID: 410
		// (add) Token: 0x06001153 RID: 4435 RVA: 0x0003C39C File Offset: 0x0003A59C
		// (remove) Token: 0x06001154 RID: 4436 RVA: 0x0003C3D8 File Offset: 0x0003A5D8
		public event EventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x1400019B RID: 411
		// (add) Token: 0x06001155 RID: 4437 RVA: 0x0003C414 File Offset: 0x0003A614
		// (remove) Token: 0x06001156 RID: 4438 RVA: 0x0003C450 File Offset: 0x0003A650
		public event EventHandler OnAuthenticationWarningDismissed;

		// Token: 0x1400019C RID: 412
		// (add) Token: 0x06001157 RID: 4439 RVA: 0x0003C48C File Offset: 0x0003A68C
		// (remove) Token: 0x06001158 RID: 4440 RVA: 0x0003C4C8 File Offset: 0x0003A6C8
		public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x1400019D RID: 413
		// (add) Token: 0x06001159 RID: 4441 RVA: 0x0003C504 File Offset: 0x0003A704
		// (remove) Token: 0x0600115A RID: 4442 RVA: 0x0003C540 File Offset: 0x0003A740
		public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x1400019E RID: 414
		// (add) Token: 0x0600115B RID: 4443 RVA: 0x0003C57C File Offset: 0x0003A77C
		// (remove) Token: 0x0600115C RID: 4444 RVA: 0x0003C5B8 File Offset: 0x0003A7B8
		public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x1400019F RID: 415
		// (add) Token: 0x0600115D RID: 4445 RVA: 0x0003C5F4 File Offset: 0x0003A7F4
		// (remove) Token: 0x0600115E RID: 4446 RVA: 0x0003C630 File Offset: 0x0003A830
		public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x140001A0 RID: 416
		// (add) Token: 0x0600115F RID: 4447 RVA: 0x0003C66C File Offset: 0x0003A86C
		// (remove) Token: 0x06001160 RID: 4448 RVA: 0x0003C6A8 File Offset: 0x0003A8A8
		public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x140001A1 RID: 417
		// (add) Token: 0x06001161 RID: 4449 RVA: 0x0003C6E4 File Offset: 0x0003A8E4
		// (remove) Token: 0x06001162 RID: 4450 RVA: 0x0003C720 File Offset: 0x0003A920
		public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x140001A2 RID: 418
		// (add) Token: 0x06001163 RID: 4451 RVA: 0x0003C75C File Offset: 0x0003A95C
		// (remove) Token: 0x06001164 RID: 4452 RVA: 0x0003C798 File Offset: 0x0003A998
		public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x140001A3 RID: 419
		// (add) Token: 0x06001165 RID: 4453 RVA: 0x0003C7D4 File Offset: 0x0003A9D4
		// (remove) Token: 0x06001166 RID: 4454 RVA: 0x0003C810 File Offset: 0x0003AA10
		public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x140001A4 RID: 420
		// (add) Token: 0x06001167 RID: 4455 RVA: 0x0003C84C File Offset: 0x0003AA4C
		// (remove) Token: 0x06001168 RID: 4456 RVA: 0x0003C888 File Offset: 0x0003AA88
		public event EventHandler OnConnectionBarPullDown;

		// Token: 0x140001A5 RID: 421
		// (add) Token: 0x06001169 RID: 4457 RVA: 0x0003C8C4 File Offset: 0x0003AAC4
		// (remove) Token: 0x0600116A RID: 4458 RVA: 0x0003C900 File Offset: 0x0003AB00
		public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x140001A6 RID: 422
		// (add) Token: 0x0600116B RID: 4459 RVA: 0x0003C93C File Offset: 0x0003AB3C
		// (remove) Token: 0x0600116C RID: 4460 RVA: 0x0003C978 File Offset: 0x0003AB78
		public event EventHandler OnDevicesButtonPressed;

		// Token: 0x140001A7 RID: 423
		// (add) Token: 0x0600116D RID: 4461 RVA: 0x0003C9B4 File Offset: 0x0003ABB4
		// (remove) Token: 0x0600116E RID: 4462 RVA: 0x0003C9F0 File Offset: 0x0003ABF0
		public event EventHandler OnAutoReconnected;

		// Token: 0x140001A8 RID: 424
		// (add) Token: 0x0600116F RID: 4463 RVA: 0x0003CA2C File Offset: 0x0003AC2C
		// (remove) Token: 0x06001170 RID: 4464 RVA: 0x0003CA68 File Offset: 0x0003AC68
		public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

		// Token: 0x06001171 RID: 4465 RVA: 0x0003CAA4 File Offset: 0x0003ACA4
		public virtual void Connect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Connect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Connect();
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x0003CAC8 File Offset: 0x0003ACC8
		public virtual void Disconnect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Disconnect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Disconnect();
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x0003CAEC File Offset: 0x0003ACEC
		public virtual void CreateVirtualChannels(string newVal)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("CreateVirtualChannels", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.CreateVirtualChannels(newVal);
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x0003CB14 File Offset: 0x0003AD14
		public virtual void SendOnVirtualChannel(string chanName, string chanData)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SendOnVirtualChannel", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SendOnVirtualChannel(chanName, chanData);
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x0003CB3C File Offset: 0x0003AD3C
		public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SetVirtualChannelOptions(chanName, chanOptions);
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x0003CB64 File Offset: 0x0003AD64
		public virtual int GetVirtualChannelOptions(string chanName)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetVirtualChannelOptions(chanName);
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x0003CB9C File Offset: 0x0003AD9C
		public virtual ControlCloseStatus RequestClose()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("RequestClose", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.RequestClose();
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x0003CBD4 File Offset: 0x0003ADD4
		public virtual string GetErrorDescription(uint disconnectReason, uint extendedDisconnectReason)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetErrorDescription", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetErrorDescription(disconnectReason, extendedDisconnectReason);
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x0003CC0C File Offset: 0x0003AE0C
		protected override void CreateSink()
		{
			try
			{
				this.eventMulticaster = new AxMsRdpClient5EventMulticaster(this);
				this.cookie = new AxHost.ConnectionPointCookie(this.ocx, this.eventMulticaster, typeof(IMsTscAxEvents));
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600117A RID: 4474 RVA: 0x0003CC64 File Offset: 0x0003AE64
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

		// Token: 0x0600117B RID: 4475 RVA: 0x0003CC98 File Offset: 0x0003AE98
		protected override void AttachInterfaces()
		{
			try
			{
				this.ocx = (IMsRdpClient5)base.GetOcx();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x0003CCD4 File Offset: 0x0003AED4
		internal void RaiseOnOnConnecting(object sender, EventArgs e)
		{
			if (this.OnConnecting != null)
			{
				this.OnConnecting(sender, e);
			}
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x0003CCF0 File Offset: 0x0003AEF0
		internal void RaiseOnOnConnected(object sender, EventArgs e)
		{
			if (this.OnConnected != null)
			{
				this.OnConnected(sender, e);
			}
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x0003CD0C File Offset: 0x0003AF0C
		internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
		{
			if (this.OnLoginComplete != null)
			{
				this.OnLoginComplete(sender, e);
			}
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x0003CD28 File Offset: 0x0003AF28
		internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
		{
			if (this.OnDisconnected != null)
			{
				this.OnDisconnected(sender, e);
			}
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x0003CD44 File Offset: 0x0003AF44
		internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnEnterFullScreenMode != null)
			{
				this.OnEnterFullScreenMode(sender, e);
			}
		}

		// Token: 0x06001181 RID: 4481 RVA: 0x0003CD60 File Offset: 0x0003AF60
		internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnLeaveFullScreenMode != null)
			{
				this.OnLeaveFullScreenMode(sender, e);
			}
		}

		// Token: 0x06001182 RID: 4482 RVA: 0x0003CD7C File Offset: 0x0003AF7C
		internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
		{
			if (this.OnChannelReceivedData != null)
			{
				this.OnChannelReceivedData(sender, e);
			}
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x0003CD98 File Offset: 0x0003AF98
		internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestGoFullScreen != null)
			{
				this.OnRequestGoFullScreen(sender, e);
			}
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x0003CDB4 File Offset: 0x0003AFB4
		internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestLeaveFullScreen != null)
			{
				this.OnRequestLeaveFullScreen(sender, e);
			}
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x0003CDD0 File Offset: 0x0003AFD0
		internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
		{
			if (this.OnFatalError != null)
			{
				this.OnFatalError(sender, e);
			}
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x0003CDEC File Offset: 0x0003AFEC
		internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
		{
			if (this.OnWarning != null)
			{
				this.OnWarning(sender, e);
			}
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x0003CE08 File Offset: 0x0003B008
		internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
		{
			if (this.OnRemoteDesktopSizeChange != null)
			{
				this.OnRemoteDesktopSizeChange(sender, e);
			}
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x0003CE24 File Offset: 0x0003B024
		internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
		{
			if (this.OnIdleTimeoutNotification != null)
			{
				this.OnIdleTimeoutNotification(sender, e);
			}
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x0003CE40 File Offset: 0x0003B040
		internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
		{
			if (this.OnRequestContainerMinimize != null)
			{
				this.OnRequestContainerMinimize(sender, e);
			}
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x0003CE5C File Offset: 0x0003B05C
		internal void RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
		{
			if (this.OnConfirmClose != null)
			{
				this.OnConfirmClose(sender, e);
			}
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x0003CE78 File Offset: 0x0003B078
		internal void RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
		{
			if (this.OnReceivedTSPublicKey != null)
			{
				this.OnReceivedTSPublicKey(sender, e);
			}
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x0003CE94 File Offset: 0x0003B094
		internal void RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
		{
			if (this.OnAutoReconnecting != null)
			{
				this.OnAutoReconnecting(sender, e);
			}
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x0003CEB0 File Offset: 0x0003B0B0
		internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDisplayed != null)
			{
				this.OnAuthenticationWarningDisplayed(sender, e);
			}
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x0003CECC File Offset: 0x0003B0CC
		internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDismissed != null)
			{
				this.OnAuthenticationWarningDismissed(sender, e);
			}
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x0003CEE8 File Offset: 0x0003B0E8
		internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
		{
			if (this.OnRemoteProgramResult != null)
			{
				this.OnRemoteProgramResult(sender, e);
			}
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x0003CF04 File Offset: 0x0003B104
		internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
		{
			if (this.OnRemoteProgramDisplayed != null)
			{
				this.OnRemoteProgramDisplayed(sender, e);
			}
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x0003CF20 File Offset: 0x0003B120
		internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
		{
			if (this.OnRemoteWindowDisplayed != null)
			{
				this.OnRemoteWindowDisplayed(sender, e);
			}
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x0003CF3C File Offset: 0x0003B13C
		internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
		{
			if (this.OnLogonError != null)
			{
				this.OnLogonError(sender, e);
			}
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x0003CF58 File Offset: 0x0003B158
		internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
		{
			if (this.OnFocusReleased != null)
			{
				this.OnFocusReleased(sender, e);
			}
		}

		// Token: 0x06001194 RID: 4500 RVA: 0x0003CF74 File Offset: 0x0003B174
		internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
		{
			if (this.OnUserNameAcquired != null)
			{
				this.OnUserNameAcquired(sender, e);
			}
		}

		// Token: 0x06001195 RID: 4501 RVA: 0x0003CF90 File Offset: 0x0003B190
		internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
		{
			if (this.OnMouseInputModeChanged != null)
			{
				this.OnMouseInputModeChanged(sender, e);
			}
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x0003CFAC File Offset: 0x0003B1AC
		internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
		{
			if (this.OnServiceMessageReceived != null)
			{
				this.OnServiceMessageReceived(sender, e);
			}
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x0003CFC8 File Offset: 0x0003B1C8
		internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
		{
			if (this.OnConnectionBarPullDown != null)
			{
				this.OnConnectionBarPullDown(sender, e);
			}
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x0003CFE4 File Offset: 0x0003B1E4
		internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
		{
			if (this.OnNetworkStatusChanged != null)
			{
				this.OnNetworkStatusChanged(sender, e);
			}
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x0003D000 File Offset: 0x0003B200
		internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
		{
			if (this.OnDevicesButtonPressed != null)
			{
				this.OnDevicesButtonPressed(sender, e);
			}
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x0003D01C File Offset: 0x0003B21C
		internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
		{
			if (this.OnAutoReconnected != null)
			{
				this.OnAutoReconnected(sender, e);
			}
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x0003D038 File Offset: 0x0003B238
		internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
		{
			if (this.OnAutoReconnecting2 != null)
			{
				this.OnAutoReconnecting2(sender, e);
			}
		}

		// Token: 0x0400053B RID: 1339
		private IMsRdpClient5 ocx;

		// Token: 0x0400053C RID: 1340
		private AxMsRdpClient5EventMulticaster eventMulticaster;

		// Token: 0x0400053D RID: 1341
		private AxHost.ConnectionPointCookie cookie;
	}
}
