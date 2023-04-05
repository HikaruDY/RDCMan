using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MSTSCLib;

namespace AxMSTSCLib
{
	// Token: 0x0200012C RID: 300
	[DefaultEvent("OnConnecting")]
	[AxHost.ClsidAttribute("{4eb2f086-c818-447e-b32c-c51ce2b30d31}")]
	[DesignTimeVisible(true)]
	[ComVisible(true)]
	public class AxMsRdpClient5NotSafeForScripting : AxHost
	{
		// Token: 0x0600104F RID: 4175 RVA: 0x000394E4 File Offset: 0x000376E4
		public AxMsRdpClient5NotSafeForScripting() : base("4eb2f086-c818-447e-b32c-c51ce2b30d31")
		{
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06001050 RID: 4176 RVA: 0x000394F4 File Offset: 0x000376F4
		// (set) Token: 0x06001051 RID: 4177 RVA: 0x00039518 File Offset: 0x00037718
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

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06001052 RID: 4178 RVA: 0x00039540 File Offset: 0x00037740
		// (set) Token: 0x06001053 RID: 4179 RVA: 0x00039564 File Offset: 0x00037764
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

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06001054 RID: 4180 RVA: 0x0003958C File Offset: 0x0003778C
		// (set) Token: 0x06001055 RID: 4181 RVA: 0x000395B0 File Offset: 0x000377B0
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

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06001056 RID: 4182 RVA: 0x000395D8 File Offset: 0x000377D8
		// (set) Token: 0x06001057 RID: 4183 RVA: 0x000395FC File Offset: 0x000377FC
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

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06001058 RID: 4184 RVA: 0x00039624 File Offset: 0x00037824
		// (set) Token: 0x06001059 RID: 4185 RVA: 0x00039648 File Offset: 0x00037848
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

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x0600105A RID: 4186 RVA: 0x00039670 File Offset: 0x00037870
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

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x0600105B RID: 4187 RVA: 0x00039694 File Offset: 0x00037894
		// (set) Token: 0x0600105C RID: 4188 RVA: 0x000396B8 File Offset: 0x000378B8
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

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x0600105D RID: 4189 RVA: 0x000396E0 File Offset: 0x000378E0
		// (set) Token: 0x0600105E RID: 4190 RVA: 0x00039704 File Offset: 0x00037904
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

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x0600105F RID: 4191 RVA: 0x0003972C File Offset: 0x0003792C
		// (set) Token: 0x06001060 RID: 4192 RVA: 0x00039750 File Offset: 0x00037950
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

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06001061 RID: 4193 RVA: 0x00039778 File Offset: 0x00037978
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

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06001062 RID: 4194 RVA: 0x0003979C File Offset: 0x0003799C
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

		// Token: 0x170002EF RID: 751
		// (set) Token: 0x06001063 RID: 4195 RVA: 0x000397C0 File Offset: 0x000379C0
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

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06001064 RID: 4196 RVA: 0x000397E8 File Offset: 0x000379E8
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

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06001065 RID: 4197 RVA: 0x0003980C File Offset: 0x00037A0C
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

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06001066 RID: 4198 RVA: 0x00039830 File Offset: 0x00037A30
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

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06001067 RID: 4199 RVA: 0x00039854 File Offset: 0x00037A54
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

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06001068 RID: 4200 RVA: 0x00039878 File Offset: 0x00037A78
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

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06001069 RID: 4201 RVA: 0x0003989C File Offset: 0x00037A9C
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

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x0600106A RID: 4202 RVA: 0x000398C0 File Offset: 0x00037AC0
		// (set) Token: 0x0600106B RID: 4203 RVA: 0x000398E4 File Offset: 0x00037AE4
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

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x0600106C RID: 4204 RVA: 0x0003990C File Offset: 0x00037B0C
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

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x0600106D RID: 4205 RVA: 0x00039930 File Offset: 0x00037B30
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

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x0600106E RID: 4206 RVA: 0x00039954 File Offset: 0x00037B54
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

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x0600106F RID: 4207 RVA: 0x00039978 File Offset: 0x00037B78
		// (set) Token: 0x06001070 RID: 4208 RVA: 0x0003999C File Offset: 0x00037B9C
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

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06001071 RID: 4209 RVA: 0x000399C4 File Offset: 0x00037BC4
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

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06001072 RID: 4210 RVA: 0x000399E8 File Offset: 0x00037BE8
		// (set) Token: 0x06001073 RID: 4211 RVA: 0x00039A0C File Offset: 0x00037C0C
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

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06001074 RID: 4212 RVA: 0x00039A34 File Offset: 0x00037C34
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

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06001075 RID: 4213 RVA: 0x00039A58 File Offset: 0x00037C58
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

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06001076 RID: 4214 RVA: 0x00039A7C File Offset: 0x00037C7C
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(500)]
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

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06001077 RID: 4215 RVA: 0x00039AA0 File Offset: 0x00037CA0
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

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06001078 RID: 4216 RVA: 0x00039AC4 File Offset: 0x00037CC4
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

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06001079 RID: 4217 RVA: 0x00039AE8 File Offset: 0x00037CE8
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DispId(505)]
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

		// Token: 0x14000169 RID: 361
		// (add) Token: 0x0600107A RID: 4218 RVA: 0x00039B0C File Offset: 0x00037D0C
		// (remove) Token: 0x0600107B RID: 4219 RVA: 0x00039B48 File Offset: 0x00037D48
		public event EventHandler OnConnecting;

		// Token: 0x1400016A RID: 362
		// (add) Token: 0x0600107C RID: 4220 RVA: 0x00039B84 File Offset: 0x00037D84
		// (remove) Token: 0x0600107D RID: 4221 RVA: 0x00039BC0 File Offset: 0x00037DC0
		public event EventHandler OnConnected;

		// Token: 0x1400016B RID: 363
		// (add) Token: 0x0600107E RID: 4222 RVA: 0x00039BFC File Offset: 0x00037DFC
		// (remove) Token: 0x0600107F RID: 4223 RVA: 0x00039C38 File Offset: 0x00037E38
		public event EventHandler OnLoginComplete;

		// Token: 0x1400016C RID: 364
		// (add) Token: 0x06001080 RID: 4224 RVA: 0x00039C74 File Offset: 0x00037E74
		// (remove) Token: 0x06001081 RID: 4225 RVA: 0x00039CB0 File Offset: 0x00037EB0
		public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x1400016D RID: 365
		// (add) Token: 0x06001082 RID: 4226 RVA: 0x00039CEC File Offset: 0x00037EEC
		// (remove) Token: 0x06001083 RID: 4227 RVA: 0x00039D28 File Offset: 0x00037F28
		public event EventHandler OnEnterFullScreenMode;

		// Token: 0x1400016E RID: 366
		// (add) Token: 0x06001084 RID: 4228 RVA: 0x00039D64 File Offset: 0x00037F64
		// (remove) Token: 0x06001085 RID: 4229 RVA: 0x00039DA0 File Offset: 0x00037FA0
		public event EventHandler OnLeaveFullScreenMode;

		// Token: 0x1400016F RID: 367
		// (add) Token: 0x06001086 RID: 4230 RVA: 0x00039DDC File Offset: 0x00037FDC
		// (remove) Token: 0x06001087 RID: 4231 RVA: 0x00039E18 File Offset: 0x00038018
		public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x14000170 RID: 368
		// (add) Token: 0x06001088 RID: 4232 RVA: 0x00039E54 File Offset: 0x00038054
		// (remove) Token: 0x06001089 RID: 4233 RVA: 0x00039E90 File Offset: 0x00038090
		public event EventHandler OnRequestGoFullScreen;

		// Token: 0x14000171 RID: 369
		// (add) Token: 0x0600108A RID: 4234 RVA: 0x00039ECC File Offset: 0x000380CC
		// (remove) Token: 0x0600108B RID: 4235 RVA: 0x00039F08 File Offset: 0x00038108
		public event EventHandler OnRequestLeaveFullScreen;

		// Token: 0x14000172 RID: 370
		// (add) Token: 0x0600108C RID: 4236 RVA: 0x00039F44 File Offset: 0x00038144
		// (remove) Token: 0x0600108D RID: 4237 RVA: 0x00039F80 File Offset: 0x00038180
		public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x14000173 RID: 371
		// (add) Token: 0x0600108E RID: 4238 RVA: 0x00039FBC File Offset: 0x000381BC
		// (remove) Token: 0x0600108F RID: 4239 RVA: 0x00039FF8 File Offset: 0x000381F8
		public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x14000174 RID: 372
		// (add) Token: 0x06001090 RID: 4240 RVA: 0x0003A034 File Offset: 0x00038234
		// (remove) Token: 0x06001091 RID: 4241 RVA: 0x0003A070 File Offset: 0x00038270
		public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x14000175 RID: 373
		// (add) Token: 0x06001092 RID: 4242 RVA: 0x0003A0AC File Offset: 0x000382AC
		// (remove) Token: 0x06001093 RID: 4243 RVA: 0x0003A0E8 File Offset: 0x000382E8
		public event EventHandler OnIdleTimeoutNotification;

		// Token: 0x14000176 RID: 374
		// (add) Token: 0x06001094 RID: 4244 RVA: 0x0003A124 File Offset: 0x00038324
		// (remove) Token: 0x06001095 RID: 4245 RVA: 0x0003A160 File Offset: 0x00038360
		public event EventHandler OnRequestContainerMinimize;

		// Token: 0x14000177 RID: 375
		// (add) Token: 0x06001096 RID: 4246 RVA: 0x0003A19C File Offset: 0x0003839C
		// (remove) Token: 0x06001097 RID: 4247 RVA: 0x0003A1D8 File Offset: 0x000383D8
		public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x14000178 RID: 376
		// (add) Token: 0x06001098 RID: 4248 RVA: 0x0003A214 File Offset: 0x00038414
		// (remove) Token: 0x06001099 RID: 4249 RVA: 0x0003A250 File Offset: 0x00038450
		public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x14000179 RID: 377
		// (add) Token: 0x0600109A RID: 4250 RVA: 0x0003A28C File Offset: 0x0003848C
		// (remove) Token: 0x0600109B RID: 4251 RVA: 0x0003A2C8 File Offset: 0x000384C8
		public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x1400017A RID: 378
		// (add) Token: 0x0600109C RID: 4252 RVA: 0x0003A304 File Offset: 0x00038504
		// (remove) Token: 0x0600109D RID: 4253 RVA: 0x0003A340 File Offset: 0x00038540
		public event EventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x1400017B RID: 379
		// (add) Token: 0x0600109E RID: 4254 RVA: 0x0003A37C File Offset: 0x0003857C
		// (remove) Token: 0x0600109F RID: 4255 RVA: 0x0003A3B8 File Offset: 0x000385B8
		public event EventHandler OnAuthenticationWarningDismissed;

		// Token: 0x1400017C RID: 380
		// (add) Token: 0x060010A0 RID: 4256 RVA: 0x0003A3F4 File Offset: 0x000385F4
		// (remove) Token: 0x060010A1 RID: 4257 RVA: 0x0003A430 File Offset: 0x00038630
		public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x1400017D RID: 381
		// (add) Token: 0x060010A2 RID: 4258 RVA: 0x0003A46C File Offset: 0x0003866C
		// (remove) Token: 0x060010A3 RID: 4259 RVA: 0x0003A4A8 File Offset: 0x000386A8
		public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x1400017E RID: 382
		// (add) Token: 0x060010A4 RID: 4260 RVA: 0x0003A4E4 File Offset: 0x000386E4
		// (remove) Token: 0x060010A5 RID: 4261 RVA: 0x0003A520 File Offset: 0x00038720
		public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x1400017F RID: 383
		// (add) Token: 0x060010A6 RID: 4262 RVA: 0x0003A55C File Offset: 0x0003875C
		// (remove) Token: 0x060010A7 RID: 4263 RVA: 0x0003A598 File Offset: 0x00038798
		public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x14000180 RID: 384
		// (add) Token: 0x060010A8 RID: 4264 RVA: 0x0003A5D4 File Offset: 0x000387D4
		// (remove) Token: 0x060010A9 RID: 4265 RVA: 0x0003A610 File Offset: 0x00038810
		public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x14000181 RID: 385
		// (add) Token: 0x060010AA RID: 4266 RVA: 0x0003A64C File Offset: 0x0003884C
		// (remove) Token: 0x060010AB RID: 4267 RVA: 0x0003A688 File Offset: 0x00038888
		public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x14000182 RID: 386
		// (add) Token: 0x060010AC RID: 4268 RVA: 0x0003A6C4 File Offset: 0x000388C4
		// (remove) Token: 0x060010AD RID: 4269 RVA: 0x0003A700 File Offset: 0x00038900
		public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x14000183 RID: 387
		// (add) Token: 0x060010AE RID: 4270 RVA: 0x0003A73C File Offset: 0x0003893C
		// (remove) Token: 0x060010AF RID: 4271 RVA: 0x0003A778 File Offset: 0x00038978
		public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x14000184 RID: 388
		// (add) Token: 0x060010B0 RID: 4272 RVA: 0x0003A7B4 File Offset: 0x000389B4
		// (remove) Token: 0x060010B1 RID: 4273 RVA: 0x0003A7F0 File Offset: 0x000389F0
		public event EventHandler OnConnectionBarPullDown;

		// Token: 0x14000185 RID: 389
		// (add) Token: 0x060010B2 RID: 4274 RVA: 0x0003A82C File Offset: 0x00038A2C
		// (remove) Token: 0x060010B3 RID: 4275 RVA: 0x0003A868 File Offset: 0x00038A68
		public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x14000186 RID: 390
		// (add) Token: 0x060010B4 RID: 4276 RVA: 0x0003A8A4 File Offset: 0x00038AA4
		// (remove) Token: 0x060010B5 RID: 4277 RVA: 0x0003A8E0 File Offset: 0x00038AE0
		public event EventHandler OnDevicesButtonPressed;

		// Token: 0x14000187 RID: 391
		// (add) Token: 0x060010B6 RID: 4278 RVA: 0x0003A91C File Offset: 0x00038B1C
		// (remove) Token: 0x060010B7 RID: 4279 RVA: 0x0003A958 File Offset: 0x00038B58
		public event EventHandler OnAutoReconnected;

		// Token: 0x14000188 RID: 392
		// (add) Token: 0x060010B8 RID: 4280 RVA: 0x0003A994 File Offset: 0x00038B94
		// (remove) Token: 0x060010B9 RID: 4281 RVA: 0x0003A9D0 File Offset: 0x00038BD0
		public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

		// Token: 0x060010BA RID: 4282 RVA: 0x0003AA0C File Offset: 0x00038C0C
		public virtual void Connect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Connect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Connect();
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x0003AA30 File Offset: 0x00038C30
		public virtual void Disconnect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("Disconnect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Disconnect();
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x0003AA54 File Offset: 0x00038C54
		public virtual void CreateVirtualChannels(string newVal)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("CreateVirtualChannels", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.CreateVirtualChannels(newVal);
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x0003AA7C File Offset: 0x00038C7C
		public virtual void SendOnVirtualChannel(string chanName, string chanData)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SendOnVirtualChannel", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SendOnVirtualChannel(chanName, chanData);
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x0003AAA4 File Offset: 0x00038CA4
		public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SetVirtualChannelOptions(chanName, chanOptions);
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x0003AACC File Offset: 0x00038CCC
		public virtual int GetVirtualChannelOptions(string chanName)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetVirtualChannelOptions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetVirtualChannelOptions(chanName);
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x0003AB04 File Offset: 0x00038D04
		public virtual ControlCloseStatus RequestClose()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("RequestClose", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.RequestClose();
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x0003AB3C File Offset: 0x00038D3C
		public virtual string GetErrorDescription(uint disconnectReason, uint extendedDisconnectReason)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetErrorDescription", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetErrorDescription(disconnectReason, extendedDisconnectReason);
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x0003AB74 File Offset: 0x00038D74
		protected override void CreateSink()
		{
			try
			{
				this.eventMulticaster = new AxMsRdpClient5NotSafeForScriptingEventMulticaster(this);
				this.cookie = new AxHost.ConnectionPointCookie(this.ocx, this.eventMulticaster, typeof(IMsTscAxEvents));
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x0003ABCC File Offset: 0x00038DCC
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

		// Token: 0x060010C4 RID: 4292 RVA: 0x0003AC00 File Offset: 0x00038E00
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

		// Token: 0x060010C5 RID: 4293 RVA: 0x0003AC3C File Offset: 0x00038E3C
		internal void RaiseOnOnConnecting(object sender, EventArgs e)
		{
			if (this.OnConnecting != null)
			{
				this.OnConnecting(sender, e);
			}
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x0003AC58 File Offset: 0x00038E58
		internal void RaiseOnOnConnected(object sender, EventArgs e)
		{
			if (this.OnConnected != null)
			{
				this.OnConnected(sender, e);
			}
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x0003AC74 File Offset: 0x00038E74
		internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
		{
			if (this.OnLoginComplete != null)
			{
				this.OnLoginComplete(sender, e);
			}
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x0003AC90 File Offset: 0x00038E90
		internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
		{
			if (this.OnDisconnected != null)
			{
				this.OnDisconnected(sender, e);
			}
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x0003ACAC File Offset: 0x00038EAC
		internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnEnterFullScreenMode != null)
			{
				this.OnEnterFullScreenMode(sender, e);
			}
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x0003ACC8 File Offset: 0x00038EC8
		internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
		{
			if (this.OnLeaveFullScreenMode != null)
			{
				this.OnLeaveFullScreenMode(sender, e);
			}
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x0003ACE4 File Offset: 0x00038EE4
		internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
		{
			if (this.OnChannelReceivedData != null)
			{
				this.OnChannelReceivedData(sender, e);
			}
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x0003AD00 File Offset: 0x00038F00
		internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestGoFullScreen != null)
			{
				this.OnRequestGoFullScreen(sender, e);
			}
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x0003AD1C File Offset: 0x00038F1C
		internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
		{
			if (this.OnRequestLeaveFullScreen != null)
			{
				this.OnRequestLeaveFullScreen(sender, e);
			}
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x0003AD38 File Offset: 0x00038F38
		internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
		{
			if (this.OnFatalError != null)
			{
				this.OnFatalError(sender, e);
			}
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x0003AD54 File Offset: 0x00038F54
		internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
		{
			if (this.OnWarning != null)
			{
				this.OnWarning(sender, e);
			}
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x0003AD70 File Offset: 0x00038F70
		internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
		{
			if (this.OnRemoteDesktopSizeChange != null)
			{
				this.OnRemoteDesktopSizeChange(sender, e);
			}
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x0003AD8C File Offset: 0x00038F8C
		internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
		{
			if (this.OnIdleTimeoutNotification != null)
			{
				this.OnIdleTimeoutNotification(sender, e);
			}
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x0003ADA8 File Offset: 0x00038FA8
		internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
		{
			if (this.OnRequestContainerMinimize != null)
			{
				this.OnRequestContainerMinimize(sender, e);
			}
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x0003ADC4 File Offset: 0x00038FC4
		internal void RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
		{
			if (this.OnConfirmClose != null)
			{
				this.OnConfirmClose(sender, e);
			}
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x0003ADE0 File Offset: 0x00038FE0
		internal void RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
		{
			if (this.OnReceivedTSPublicKey != null)
			{
				this.OnReceivedTSPublicKey(sender, e);
			}
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x0003ADFC File Offset: 0x00038FFC
		internal void RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
		{
			if (this.OnAutoReconnecting != null)
			{
				this.OnAutoReconnecting(sender, e);
			}
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x0003AE18 File Offset: 0x00039018
		internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDisplayed != null)
			{
				this.OnAuthenticationWarningDisplayed(sender, e);
			}
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x0003AE34 File Offset: 0x00039034
		internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
		{
			if (this.OnAuthenticationWarningDismissed != null)
			{
				this.OnAuthenticationWarningDismissed(sender, e);
			}
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x0003AE50 File Offset: 0x00039050
		internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
		{
			if (this.OnRemoteProgramResult != null)
			{
				this.OnRemoteProgramResult(sender, e);
			}
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x0003AE6C File Offset: 0x0003906C
		internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
		{
			if (this.OnRemoteProgramDisplayed != null)
			{
				this.OnRemoteProgramDisplayed(sender, e);
			}
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x0003AE88 File Offset: 0x00039088
		internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
		{
			if (this.OnRemoteWindowDisplayed != null)
			{
				this.OnRemoteWindowDisplayed(sender, e);
			}
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x0003AEA4 File Offset: 0x000390A4
		internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
		{
			if (this.OnLogonError != null)
			{
				this.OnLogonError(sender, e);
			}
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x0003AEC0 File Offset: 0x000390C0
		internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
		{
			if (this.OnFocusReleased != null)
			{
				this.OnFocusReleased(sender, e);
			}
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x0003AEDC File Offset: 0x000390DC
		internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
		{
			if (this.OnUserNameAcquired != null)
			{
				this.OnUserNameAcquired(sender, e);
			}
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x0003AEF8 File Offset: 0x000390F8
		internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
		{
			if (this.OnMouseInputModeChanged != null)
			{
				this.OnMouseInputModeChanged(sender, e);
			}
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x0003AF14 File Offset: 0x00039114
		internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
		{
			if (this.OnServiceMessageReceived != null)
			{
				this.OnServiceMessageReceived(sender, e);
			}
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x0003AF30 File Offset: 0x00039130
		internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
		{
			if (this.OnConnectionBarPullDown != null)
			{
				this.OnConnectionBarPullDown(sender, e);
			}
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x0003AF4C File Offset: 0x0003914C
		internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
		{
			if (this.OnNetworkStatusChanged != null)
			{
				this.OnNetworkStatusChanged(sender, e);
			}
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x0003AF68 File Offset: 0x00039168
		internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
		{
			if (this.OnDevicesButtonPressed != null)
			{
				this.OnDevicesButtonPressed(sender, e);
			}
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x0003AF84 File Offset: 0x00039184
		internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
		{
			if (this.OnAutoReconnected != null)
			{
				this.OnAutoReconnected(sender, e);
			}
		}

		// Token: 0x060010E4 RID: 4324 RVA: 0x0003AFA0 File Offset: 0x000391A0
		internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
		{
			if (this.OnAutoReconnecting2 != null)
			{
				this.OnAutoReconnecting2(sender, e);
			}
		}

		// Token: 0x04000517 RID: 1303
		private IMsRdpClient5 ocx;

		// Token: 0x04000518 RID: 1304
		private AxMsRdpClient5NotSafeForScriptingEventMulticaster eventMulticaster;

		// Token: 0x04000519 RID: 1305
		private AxHost.ConnectionPointCookie cookie;
	}
}
