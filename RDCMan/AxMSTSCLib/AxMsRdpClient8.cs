using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MSTSCLib;

namespace AxMSTSCLib
{
	// Token: 0x0200013A RID: 314
	[DefaultEvent("OnConnecting")]
	[AxHost.ClsidAttribute("{5f681803-2900-4c43-a1cc-cf405404a676}")]
	[DesignTimeVisible(true)]
	[ComVisible(true)]
	public class AxMsRdpClient8 : AxHost
	{
		// Token: 0x0600156C RID: 5484 RVA: 0x00047D50 File Offset: 0x00045F50
		public AxMsRdpClient8() : base("5f681803-2900-4c43-a1cc-cf405404a676")
		{
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x0600156D RID: 5485 RVA: 0x00047D60 File Offset: 0x00045F60
		// (set) Token: 0x0600156E RID: 5486 RVA: 0x00047D84 File Offset: 0x00045F84
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

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x0600156F RID: 5487 RVA: 0x00047DAC File Offset: 0x00045FAC
		// (set) Token: 0x06001570 RID: 5488 RVA: 0x00047DD0 File Offset: 0x00045FD0
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

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06001571 RID: 5489 RVA: 0x00047DF8 File Offset: 0x00045FF8
		// (set) Token: 0x06001572 RID: 5490 RVA: 0x00047E1C File Offset: 0x0004601C
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

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06001573 RID: 5491 RVA: 0x00047E44 File Offset: 0x00046044
		// (set) Token: 0x06001574 RID: 5492 RVA: 0x00047E68 File Offset: 0x00046068
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

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06001575 RID: 5493 RVA: 0x00047E90 File Offset: 0x00046090
		// (set) Token: 0x06001576 RID: 5494 RVA: 0x00047EB4 File Offset: 0x000460B4
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

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06001577 RID: 5495 RVA: 0x00047EDC File Offset: 0x000460DC
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

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06001578 RID: 5496 RVA: 0x00047F00 File Offset: 0x00046100
		// (set) Token: 0x06001579 RID: 5497 RVA: 0x00047F24 File Offset: 0x00046124
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

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x0600157A RID: 5498 RVA: 0x00047F4C File Offset: 0x0004614C
		// (set) Token: 0x0600157B RID: 5499 RVA: 0x00047F70 File Offset: 0x00046170
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

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x0600157C RID: 5500 RVA: 0x00047F98 File Offset: 0x00046198
		// (set) Token: 0x0600157D RID: 5501 RVA: 0x00047FBC File Offset: 0x000461BC
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

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x0600157E RID: 5502 RVA: 0x00047FE4 File Offset: 0x000461E4
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

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x0600157F RID: 5503 RVA: 0x00048008 File Offset: 0x00046208
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

		// Token: 0x170003DF RID: 991
		// (set) Token: 0x06001580 RID: 5504 RVA: 0x0004802C File Offset: 0x0004622C
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

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06001581 RID: 5505 RVA: 0x00048054 File Offset: 0x00046254
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

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06001582 RID: 5506 RVA: 0x00048078 File Offset: 0x00046278
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

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06001583 RID: 5507 RVA: 0x0004809C File Offset: 0x0004629C
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

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06001584 RID: 5508 RVA: 0x000480C0 File Offset: 0x000462C0
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

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06001585 RID: 5509 RVA: 0x000480E4 File Offset: 0x000462E4
		[DispId(98)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06001586 RID: 5510 RVA: 0x00048108 File Offset: 0x00046308
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

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06001587 RID: 5511 RVA: 0x0004812C File Offset: 0x0004632C
		// (set) Token: 0x06001588 RID: 5512 RVA: 0x00048150 File Offset: 0x00046350
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

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06001589 RID: 5513 RVA: 0x00048178 File Offset: 0x00046378
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

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x0600158A RID: 5514 RVA: 0x0004819C File Offset: 0x0004639C
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

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x0600158B RID: 5515 RVA: 0x000481C0 File Offset: 0x000463C0
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

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x0600158C RID: 5516 RVA: 0x000481E4 File Offset: 0x000463E4
		// (set) Token: 0x0600158D RID: 5517 RVA: 0x00048208 File Offset: 0x00046408
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

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x0600158E RID: 5518 RVA: 0x00048230 File Offset: 0x00046430
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

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x0600158F RID: 5519 RVA: 0x00048254 File Offset: 0x00046454
		// (set) Token: 0x06001590 RID: 5520 RVA: 0x00048278 File Offset: 0x00046478
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

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06001591 RID: 5521 RVA: 0x000482A0 File Offset: 0x000464A0
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
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

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06001592 RID: 5522 RVA: 0x000482C4 File Offset: 0x000464C4
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

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06001593 RID: 5523 RVA: 0x000482E8 File Offset: 0x000464E8
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

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06001594 RID: 5524 RVA: 0x0004830C File Offset: 0x0004650C
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

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06001595 RID: 5525 RVA: 0x00048330 File Offset: 0x00046530
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

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06001596 RID: 5526 RVA: 0x00048354 File Offset: 0x00046554
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

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06001597 RID: 5527 RVA: 0x00048378 File Offset: 0x00046578
		[Browsable(false)]
		[DispId(507)]
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

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06001598 RID: 5528 RVA: 0x0004839C File Offset: 0x0004659C
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

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06001599 RID: 5529 RVA: 0x000483C0 File Offset: 0x000465C0
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

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x0600159A RID: 5530 RVA: 0x000483E4 File Offset: 0x000465E4
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

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x0600159B RID: 5531 RVA: 0x00048408 File Offset: 0x00046608
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

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x0600159C RID: 5532 RVA: 0x0004842C File Offset: 0x0004662C
		[Browsable(false)]
		[DispId(604)]
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

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x0600159D RID: 5533 RVA: 0x00048450 File Offset: 0x00046650
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

		// Token: 0x14000249 RID: 585
		// (add) Token: 0x0600159E RID: 5534 RVA: 0x00048474 File Offset: 0x00046674
		// (remove) Token: 0x0600159F RID: 5535 RVA: 0x000484B0 File Offset: 0x000466B0
		public event EventHandler OnConnecting;

		// Token: 0x1400024A RID: 586
		// (add) Token: 0x060015A0 RID: 5536 RVA: 0x000484EC File Offset: 0x000466EC
		// (remove) Token: 0x060015A1 RID: 5537 RVA: 0x00048528 File Offset: 0x00046728
		public event EventHandler OnConnected;

		// Token: 0x1400024B RID: 587
		// (add) Token: 0x060015A2 RID: 5538 RVA: 0x00048564 File Offset: 0x00046764
		// (remove) Token: 0x060015A3 RID: 5539 RVA: 0x000485A0 File Offset: 0x000467A0
		public event EventHandler OnLoginComplete;

		// Token: 0x1400024C RID: 588
		// (add) Token: 0x060015A4 RID: 5540 RVA: 0x000485DC File Offset: 0x000467DC
		// (remove) Token: 0x060015A5 RID: 5541 RVA: 0x00048618 File Offset: 0x00046818
		public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x1400024D RID: 589
		// (add) Token: 0x060015A6 RID: 5542 RVA: 0x00048654 File Offset: 0x00046854
		// (remove) Token: 0x060015A7 RID: 5543 RVA: 0x00048690 File Offset: 0x00046890
		public event EventHandler OnEnterFullScreenMode;

		// Token: 0x1400024E RID: 590
		// (add) Token: 0x060015A8 RID: 5544 RVA: 0x000486CC File Offset: 0x000468CC
		// (remove) Token: 0x060015A9 RID: 5545 RVA: 0x00048708 File Offset: 0x00046908
		public event EventHandler OnLeaveFullScreenMode;

		// Token: 0x1400024F RID: 591
		// (add) Token: 0x060015AA RID: 5546 RVA: 0x00048744 File Offset: 0x00046944
		// (remove) Token: 0x060015AB RID: 5547 RVA: 0x00048780 File Offset: 0x00046980
		public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x14000250 RID: 592
		// (add) Token: 0x060015AC RID: 5548 RVA: 0x000487BC File Offset: 0x000469BC
		// (remove) Token: 0x060015AD RID: 5549 RVA: 0x000487F8 File Offset: 0x000469F8
		public event EventHandler OnRequestGoFullScreen;

		// Token: 0x14000251 RID: 593
		// (add) Token: 0x060015AE RID: 5550 RVA: 0x00048834 File Offset: 0x00046A34
		// (remove) Token: 0x060015AF RID: 5551 RVA: 0x00048870 File Offset: 0x00046A70
		public event EventHandler OnRequestLeaveFullScreen;

		// Token: 0x14000252 RID: 594
		// (add) Token: 0x060015B0 RID: 5552 RVA: 0x000488AC File Offset: 0x00046AAC
		// (remove) Token: 0x060015B1 RID: 5553 RVA: 0x000488E8 File Offset: 0x00046AE8
		public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x14000253 RID: 595
		// (add) Token: 0x060015B2 RID: 5554 RVA: 0x00048924 File Offset: 0x00046B24
		// (remove) Token: 0x060015B3 RID: 5555 RVA: 0x00048960 File Offset: 0x00046B60
		public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x14000254 RID: 596
		// (add) Token: 0x060015B4 RID: 5556 RVA: 0x0004899C File Offset: 0x00046B9C
		// (remove) Token: 0x060015B5 RID: 5557 RVA: 0x000489D8 File Offset: 0x00046BD8
		public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x14000255 RID: 597
		// (add) Token: 0x060015B6 RID: 5558 RVA: 0x00048A14 File Offset: 0x00046C14
		// (remove) Token: 0x060015B7 RID: 5559 RVA: 0x00048A50 File Offset: 0x00046C50
		public event EventHandler OnIdleTimeoutNotification;

		// Token: 0x14000256 RID: 598
		// (add) Token: 0x060015B8 RID: 5560 RVA: 0x00048A8C File Offset: 0x00046C8C
		// (remove) Token: 0x060015B9 RID: 5561 RVA: 0x00048AC8 File Offset: 0x00046CC8
		public event EventHandler OnRequestContainerMinimize;

		// Token: 0x14000257 RID: 599
		// (add) Token: 0x060015BA RID: 5562 RVA: 0x00048B04 File Offset: 0x00046D04
		// (remove) Token: 0x060015BB RID: 5563 RVA: 0x00048B40 File Offset: 0x00046D40
		public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x14000258 RID: 600
		// (add) Token: 0x060015BC RID: 5564 RVA: 0x00048B7C File Offset: 0x00046D7C
		// (remove) Token: 0x060015BD RID: 5565 RVA: 0x00048BB8 File Offset: 0x00046DB8
		public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x14000259 RID: 601
		// (add) Token: 0x060015BE RID: 5566 RVA: 0x00048BF4 File Offset: 0x00046DF4
		// (remove) Token: 0x060015BF RID: 5567 RVA: 0x00048C30 File Offset: 0x00046E30
		public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x1400025A RID: 602
		// (add) Token: 0x060015C0 RID: 5568 RVA: 0x00048C6C File Offset: 0x00046E6C
		// (remove) Token: 0x060015C1 RID: 5569 RVA: 0x00048CA8 File Offset: 0x00046EA8
		public event EventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x1400025B RID: 603
		// (add) Token: 0x060015C2 RID: 5570 RVA: 0x00048CE4 File Offset: 0x00046EE4
		// (remove) Token: 0x060015C3 RID: 5571 RVA: 0x00048D20 File Offset: 0x00046F20
		public event EventHandler OnAuthenticationWarningDismissed;

		// Token: 0x1400025C RID: 604
		// (add) Token: 0x060015C4 RID: 5572 RVA: 0x00048D5C File Offset: 0x00046F5C
		// (remove) Token: 0x060015C5 RID: 5573 RVA: 0x00048D98 File Offset: 0x00046F98
		public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x1400025D RID: 605
		// (add) Token: 0x060015C6 RID: 5574 RVA: 0x00048DD4 File Offset: 0x00046FD4
		// (remove) Token: 0x060015C7 RID: 5575 RVA: 0x00048E10 File Offset: 0x00047010
		public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x1400025E RID: 606
		// (add) Token: 0x060015C8 RID: 5576 RVA: 0x00048E4C File Offset: 0x0004704C
		// (remove) Token: 0x060015C9 RID: 5577 RVA: 0x00048E88 File Offset: 0x00047088
		public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x1400025F RID: 607
		// (add) Token: 0x060015CA RID: 5578 RVA: 0x00048EC4 File Offset: 0x000470C4
		// (remove) Token: 0x060015CB RID: 5579 RVA: 0x00048F00 File Offset: 0x00047100
		public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x14000260 RID: 608
		// (add) Token: 0x060015CC RID: 5580 RVA: 0x00048F3C File Offset: 0x0004713C
		// (remove) Token: 0x060015CD RID: 5581 RVA: 0x00048F78 File Offset: 0x00047178
		public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x14000261 RID: 609
		// (add) Token: 0x060015CE RID: 5582 RVA: 0x00048FB4 File Offset: 0x000471B4
		// (remove) Token: 0x060015CF RID: 5583 RVA: 0x00048FF0 File Offset: 0x000471F0
		public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x14000262 RID: 610
		// (add) Token: 0x060015D0 RID: 5584 RVA: 0x0004902C File Offset: 0x0004722C
		// (remove) Token: 0x060015D1 RID: 5585 RVA: 0x00049068 File Offset: 0x00047268
		public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x14000263 RID: 611
		// (add) Token: 0x060015D2 RID: 5586 RVA: 0x000490A4 File Offset: 0x000472A4
		// (remove) Token: 0x060015D3 RID: 5587 RVA: 0x000490E0 File Offset: 0x000472E0
		public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x14000264 RID: 612
		// (add) Token: 0x060015D4 RID: 5588 RVA: 0x0004911C File Offset: 0x0004731C
		// (remove) Token: 0x060015D5 RID: 5589 RVA: 0x00049158 File Offset: 0x00047358
		public event EventHandler OnConnectionBarPullDown;

		// Token: 0x14000265 RID: 613
		// (add) Token: 0x060015D6 RID: 5590 RVA: 0x00049194 File Offset: 0x00047394
		// (remove) Token: 0x060015D7 RID: 5591 RVA: 0x000491D0 File Offset: 0x000473D0
		public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x14000266 RID: 614
		// (add) Token: 0x060015D8 RID: 5592 RVA: 0x0004920C File Offset: 0x0004740C
		// (remove) Token: 0x060015D9 RID: 5593 RVA: 0x00049248 File Offset: 0x00047448
		public event EventHandler OnDevicesButtonPressed;

		// Token: 0x14000267 RID: 615
		// (add) Token: 0x060015DA RID: 5594 RVA: 0x00049284 File Offset: 0x00047484
		// (remove) Token: 0x060015DB RID: 5595 RVA: 0x000492C0 File Offset: 0x000474C0
		public event EventHandler OnAutoReconnected;

		// Token: 0x14000268 RID: 616
		// (add) Token: 0x060015DC RID: 5596 RVA: 0x000492FC File Offset: 0x000474FC
		// (remove) Token: 0x060015DD RID: 5597 RVA: 0x00049338 File Offset: 0x00047538
		public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

		// Token: 0x060015DE RID: 5598 RVA: 0x00049374 File Offset: 0x00047574
		public virtual void Connect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Connect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Connect();
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x00049398 File Offset: 0x00047598
		public virtual void Disconnect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Disconnect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Disconnect();
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x000493BC File Offset: 0x000475BC
		public virtual void CreateVirtualChannels(string newVal)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("CreateVirtualChannels", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.CreateVirtualChannels(newVal);
		}

		// Token: 0x060015E1 RID: 5601 RVA: 0x000493E4 File Offset: 0x000475E4
		public virtual void SendOnVirtualChannel(string chanName, string chanData)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SendOnVirtualChannel", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SendOnVirtualChannel(chanName, chanData);
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x0004940C File Offset: 0x0004760C
		public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SetVirtualChannelOptions(chanName, chanOptions);
		}

		// Token: 0x060015E3 RID: 5603 RVA: 0x00049434 File Offset: 0x00047634
		public virtual int GetVirtualChannelOptions(string chanName)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetVirtualChannelOptions(chanName);
		}

		// Token: 0x060015E4 RID: 5604 RVA: 0x0004946C File Offset: 0x0004766C
		public virtual ControlCloseStatus RequestClose()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("RequestClose", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.RequestClose();
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x000494A4 File Offset: 0x000476A4
		public virtual string GetErrorDescription(uint disconnectReason, uint extendedDisconnectReason)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetErrorDescription", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetErrorDescription(disconnectReason, extendedDisconnectReason);
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x000494DC File Offset: 0x000476DC
		public virtual string GetStatusText(uint statusCode)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetStatusText", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetStatusText(statusCode);
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x00049514 File Offset: 0x00047714
		public virtual void SendRemoteAction(RemoteSessionActionType actionType)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SendRemoteAction", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SendRemoteAction(actionType);
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x0004953C File Offset: 0x0004773C
		public virtual ControlReconnectStatus Reconnect(uint ulWidth, uint ulHeight)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Reconnect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.Reconnect(ulWidth, ulHeight);
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x00049574 File Offset: 0x00047774
		protected override void CreateSink()
		{
			try
			{
				this.eventMulticaster = new AxMsRdpClient8EventMulticaster(this);
				this.cookie = new AxHost.ConnectionPointCookie(this.ocx, this.eventMulticaster, typeof(IMsTscAxEvents));
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x000495CC File Offset: 0x000477CC
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

		// Token: 0x060015EB RID: 5611 RVA: 0x00049600 File Offset: 0x00047800
		protected override void AttachInterfaces()
		{
			try
			{
				this.ocx = (IMsRdpClient8)base.GetOcx();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x0004963C File Offset: 0x0004783C
		internal void RaiseOnOnConnecting(object sender, EventArgs e)
		{
			if (this.OnConnecting != null)
			{
				this.OnConnecting(sender, e);
			}
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x00049658 File Offset: 0x00047858
		internal void RaiseOnOnConnected(object sender, EventArgs e)
		{
			if (this.OnConnected != null)
			{
				this.OnConnected(sender, e);
			}
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x00049674 File Offset: 0x00047874
		internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
		{
			if (this.OnLoginComplete != null)
			{
				this.OnLoginComplete(sender, e);
			}
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x00049690 File Offset: 0x00047890
		internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
		{
			if (this.OnDisconnected != null)
			{
				this.OnDisconnected(sender, e);
			}
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x000496AC File Offset: 0x000478AC
		internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnEnterFullScreenMode != null)
			{
				this.OnEnterFullScreenMode(sender, e);
			}
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x000496C8 File Offset: 0x000478C8
		internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnLeaveFullScreenMode != null)
			{
				this.OnLeaveFullScreenMode(sender, e);
			}
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x000496E4 File Offset: 0x000478E4
		internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
		{
			if (this.OnChannelReceivedData != null)
			{
				this.OnChannelReceivedData(sender, e);
			}
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x00049700 File Offset: 0x00047900
		internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestGoFullScreen != null)
			{
				this.OnRequestGoFullScreen(sender, e);
			}
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x0004971C File Offset: 0x0004791C
		internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestLeaveFullScreen != null)
			{
				this.OnRequestLeaveFullScreen(sender, e);
			}
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x00049738 File Offset: 0x00047938
		internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
		{
			if (this.OnFatalError != null)
			{
				this.OnFatalError(sender, e);
			}
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x00049754 File Offset: 0x00047954
		internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
		{
			if (this.OnWarning != null)
			{
				this.OnWarning(sender, e);
			}
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x00049770 File Offset: 0x00047970
		internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
		{
			if (this.OnRemoteDesktopSizeChange != null)
			{
				this.OnRemoteDesktopSizeChange(sender, e);
			}
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x0004978C File Offset: 0x0004798C
		internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
		{
			if (this.OnIdleTimeoutNotification != null)
			{
				this.OnIdleTimeoutNotification(sender, e);
			}
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x000497A8 File Offset: 0x000479A8
		internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
		{
			if (this.OnRequestContainerMinimize != null)
			{
				this.OnRequestContainerMinimize(sender, e);
			}
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x000497C4 File Offset: 0x000479C4
		internal void RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
		{
			if (this.OnConfirmClose != null)
			{
				this.OnConfirmClose(sender, e);
			}
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x000497E0 File Offset: 0x000479E0
		internal void RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
		{
			if (this.OnReceivedTSPublicKey != null)
			{
				this.OnReceivedTSPublicKey(sender, e);
			}
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x000497FC File Offset: 0x000479FC
		internal void RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
		{
			if (this.OnAutoReconnecting != null)
			{
				this.OnAutoReconnecting(sender, e);
			}
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x00049818 File Offset: 0x00047A18
		internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDisplayed != null)
			{
				this.OnAuthenticationWarningDisplayed(sender, e);
			}
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x00049834 File Offset: 0x00047A34
		internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDismissed != null)
			{
				this.OnAuthenticationWarningDismissed(sender, e);
			}
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x00049850 File Offset: 0x00047A50
		internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
		{
			if (this.OnRemoteProgramResult != null)
			{
				this.OnRemoteProgramResult(sender, e);
			}
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x0004986C File Offset: 0x00047A6C
		internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
		{
			if (this.OnRemoteProgramDisplayed != null)
			{
				this.OnRemoteProgramDisplayed(sender, e);
			}
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x00049888 File Offset: 0x00047A88
		internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
		{
			if (this.OnRemoteWindowDisplayed != null)
			{
				this.OnRemoteWindowDisplayed(sender, e);
			}
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x000498A4 File Offset: 0x00047AA4
		internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
		{
			if (this.OnLogonError != null)
			{
				this.OnLogonError(sender, e);
			}
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x000498C0 File Offset: 0x00047AC0
		internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
		{
			if (this.OnFocusReleased != null)
			{
				this.OnFocusReleased(sender, e);
			}
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x000498DC File Offset: 0x00047ADC
		internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
		{
			if (this.OnUserNameAcquired != null)
			{
				this.OnUserNameAcquired(sender, e);
			}
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x000498F8 File Offset: 0x00047AF8
		internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
		{
			if (this.OnMouseInputModeChanged != null)
			{
				this.OnMouseInputModeChanged(sender, e);
			}
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x00049914 File Offset: 0x00047B14
		internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
		{
			if (this.OnServiceMessageReceived != null)
			{
				this.OnServiceMessageReceived(sender, e);
			}
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x00049930 File Offset: 0x00047B30
		internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
		{
			if (this.OnConnectionBarPullDown != null)
			{
				this.OnConnectionBarPullDown(sender, e);
			}
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x0004994C File Offset: 0x00047B4C
		internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
		{
			if (this.OnNetworkStatusChanged != null)
			{
				this.OnNetworkStatusChanged(sender, e);
			}
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x00049968 File Offset: 0x00047B68
		internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
		{
			if (this.OnDevicesButtonPressed != null)
			{
				this.OnDevicesButtonPressed(sender, e);
			}
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x00049984 File Offset: 0x00047B84
		internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
		{
			if (this.OnAutoReconnected != null)
			{
				this.OnAutoReconnected(sender, e);
			}
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x000499A0 File Offset: 0x00047BA0
		internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
		{
			if (this.OnAutoReconnecting2 != null)
			{
				this.OnAutoReconnecting2(sender, e);
			}
		}

		// Token: 0x04000613 RID: 1555
		private IMsRdpClient8 ocx;

		// Token: 0x04000614 RID: 1556
		private AxMsRdpClient8EventMulticaster eventMulticaster;

		// Token: 0x04000615 RID: 1557
		private AxHost.ConnectionPointCookie cookie;
	}
}
