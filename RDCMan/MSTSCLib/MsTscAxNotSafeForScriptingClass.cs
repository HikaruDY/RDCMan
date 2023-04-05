using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x02000163 RID: 355
	[TypeLibType(34)]
	[Guid("A41A4187-5A86-4E26-B40A-856F9035D9CB")]
	[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0")]
	[ClassInterface(0)]
	[ComVisible(true)]
	[ComImport]
	public class MsTscAxNotSafeForScriptingClass : IMsTscAx, MsTscAxNotSafeForScripting, IMsTscAxEvents_Event, IMsRdpClient, IMsTscAx_Redist, IMsTscNonScriptable, IMsRdpClientNonScriptable
	{
		// Token: 0x06001B64 RID: 7012
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern MsTscAxNotSafeForScriptingClass();

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06001B66 RID: 7014
		// (set) Token: 0x06001B65 RID: 7013
		[DispId(1)]
		public virtual extern string Server { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06001B68 RID: 7016
		// (set) Token: 0x06001B67 RID: 7015
		[DispId(2)]
		public virtual extern string Domain { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06001B6A RID: 7018
		// (set) Token: 0x06001B69 RID: 7017
		[DispId(3)]
		public virtual extern string UserName { [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06001B6C RID: 7020
		// (set) Token: 0x06001B6B RID: 7019
		[DispId(4)]
		public virtual extern string DisconnectedText { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06001B6E RID: 7022
		// (set) Token: 0x06001B6D RID: 7021
		[DispId(5)]
		public virtual extern string ConnectingText { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06001B6F RID: 7023
		[DispId(6)]
		public virtual extern short Connected { [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06001B71 RID: 7025
		// (set) Token: 0x06001B70 RID: 7024
		[DispId(12)]
		public virtual extern int DesktopWidth { [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06001B73 RID: 7027
		// (set) Token: 0x06001B72 RID: 7026
		[DispId(13)]
		public virtual extern int DesktopHeight { [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06001B75 RID: 7029
		// (set) Token: 0x06001B74 RID: 7028
		[DispId(16)]
		public virtual extern int StartConnected { [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06001B76 RID: 7030
		[DispId(17)]
		public virtual extern int HorizontalScrollBarVisible { [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06001B77 RID: 7031
		[DispId(18)]
		public virtual extern int VerticalScrollBarVisible { [DispId(18)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170004F6 RID: 1270
		// (set) Token: 0x06001B78 RID: 7032
		[DispId(19)]
		public virtual extern string FullScreenTitle { [DispId(19)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06001B79 RID: 7033
		[DispId(20)]
		public virtual extern int CipherStrength { [DispId(20)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06001B7A RID: 7034
		[DispId(21)]
		public virtual extern string Version { [DispId(21)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06001B7B RID: 7035
		[DispId(22)]
		public virtual extern int SecuredSettingsEnabled { [DispId(22)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06001B7C RID: 7036
		[DispId(97)]
		public virtual extern IMsTscSecuredSettings SecuredSettings { [DispId(97)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06001B7D RID: 7037
		[DispId(98)]
		public virtual extern IMsTscAdvancedSettings AdvancedSettings { [DispId(98)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06001B7E RID: 7038
		[DispId(99)]
		public virtual extern IMsTscDebug Debugger { [DispId(99)] [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06001B7F RID: 7039
		[DispId(30)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Connect();

		// Token: 0x06001B80 RID: 7040
		[DispId(31)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Disconnect();

		// Token: 0x06001B81 RID: 7041
		[DispId(33)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06001B82 RID: 7042
		[DispId(34)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06001B84 RID: 7044
		// (set) Token: 0x06001B83 RID: 7043
		public virtual extern string IMsRdpClient_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06001B86 RID: 7046
		// (set) Token: 0x06001B85 RID: 7045
		public virtual extern string IMsRdpClient_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06001B88 RID: 7048
		// (set) Token: 0x06001B87 RID: 7047
		public virtual extern string IMsRdpClient_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06001B8A RID: 7050
		// (set) Token: 0x06001B89 RID: 7049
		public virtual extern string IMsRdpClient_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06001B8C RID: 7052
		// (set) Token: 0x06001B8B RID: 7051
		public virtual extern string IMsRdpClient_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06001B8D RID: 7053
		public virtual extern short IMsRdpClient_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06001B8F RID: 7055
		// (set) Token: 0x06001B8E RID: 7054
		public virtual extern int IMsRdpClient_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06001B91 RID: 7057
		// (set) Token: 0x06001B90 RID: 7056
		public virtual extern int IMsRdpClient_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06001B93 RID: 7059
		// (set) Token: 0x06001B92 RID: 7058
		public virtual extern int IMsRdpClient_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06001B94 RID: 7060
		public virtual extern int IMsRdpClient_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06001B95 RID: 7061
		public virtual extern int IMsRdpClient_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000508 RID: 1288
		// (set) Token: 0x06001B96 RID: 7062
		public virtual extern string IMsRdpClient_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06001B97 RID: 7063
		public virtual extern int IMsRdpClient_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06001B98 RID: 7064
		public virtual extern string IMsRdpClient_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06001B99 RID: 7065
		public virtual extern int IMsRdpClient_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06001B9A RID: 7066
		public virtual extern IMsTscSecuredSettings IMsRdpClient_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06001B9B RID: 7067
		public virtual extern IMsTscAdvancedSettings IMsRdpClient_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06001B9C RID: 7068
		public virtual extern IMsTscDebug IMsRdpClient_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06001B9D RID: 7069
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_Connect();

		// Token: 0x06001B9E RID: 7070
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_Disconnect();

		// Token: 0x06001B9F RID: 7071
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06001BA0 RID: 7072
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06001BA2 RID: 7074
		// (set) Token: 0x06001BA1 RID: 7073
		public virtual extern int ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06001BA3 RID: 7075
		public virtual extern IMsRdpClientAdvancedSettings AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06001BA4 RID: 7076
		public virtual extern IMsRdpClientSecuredSettings SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06001BA5 RID: 7077
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06001BA7 RID: 7079
		// (set) Token: 0x06001BA6 RID: 7078
		public virtual extern bool FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06001BA8 RID: 7080
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06001BA9 RID: 7081
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06001BAA RID: 7082
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus RequestClose();

		// Token: 0x17000514 RID: 1300
		// (set) Token: 0x06001BAB RID: 7083
		public virtual extern string ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06001BAD RID: 7085
		// (set) Token: 0x06001BAC RID: 7084
		public virtual extern string PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06001BAF RID: 7087
		// (set) Token: 0x06001BAE RID: 7086
		public virtual extern string PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06001BB1 RID: 7089
		// (set) Token: 0x06001BB0 RID: 7088
		public virtual extern string BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06001BB3 RID: 7091
		// (set) Token: 0x06001BB2 RID: 7090
		public virtual extern string BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06001BB4 RID: 7092
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void ResetPassword();

		// Token: 0x17000519 RID: 1305
		// (set) Token: 0x06001BB5 RID: 7093
		public virtual extern string IMsRdpClientNonScriptable_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06001BB7 RID: 7095
		// (set) Token: 0x06001BB6 RID: 7094
		public virtual extern string IMsRdpClientNonScriptable_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06001BB9 RID: 7097
		// (set) Token: 0x06001BB8 RID: 7096
		public virtual extern string IMsRdpClientNonScriptable_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06001BBB RID: 7099
		// (set) Token: 0x06001BBA RID: 7098
		public virtual extern string IMsRdpClientNonScriptable_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06001BBD RID: 7101
		// (set) Token: 0x06001BBC RID: 7100
		public virtual extern string IMsRdpClientNonScriptable_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06001BBE RID: 7102
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable_ResetPassword();

		// Token: 0x06001BBF RID: 7103
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06001BC0 RID: 7104
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x14000337 RID: 823
		// (add) Token: 0x06001BC1 RID: 7105
		// (remove) Token: 0x06001BC2 RID: 7106
		public virtual extern event IMsTscAxEvents_OnConnectingEventHandler OnConnecting;

		// Token: 0x14000338 RID: 824
		// (add) Token: 0x06001BC3 RID: 7107
		// (remove) Token: 0x06001BC4 RID: 7108
		public virtual extern event IMsTscAxEvents_OnConnectedEventHandler OnConnected;

		// Token: 0x14000339 RID: 825
		// (add) Token: 0x06001BC5 RID: 7109
		// (remove) Token: 0x06001BC6 RID: 7110
		public virtual extern event IMsTscAxEvents_OnLoginCompleteEventHandler OnLoginComplete;

		// Token: 0x1400033A RID: 826
		// (add) Token: 0x06001BC7 RID: 7111
		// (remove) Token: 0x06001BC8 RID: 7112
		public virtual extern event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x1400033B RID: 827
		// (add) Token: 0x06001BC9 RID: 7113
		// (remove) Token: 0x06001BCA RID: 7114
		public virtual extern event IMsTscAxEvents_OnEnterFullScreenModeEventHandler OnEnterFullScreenMode;

		// Token: 0x1400033C RID: 828
		// (add) Token: 0x06001BCB RID: 7115
		// (remove) Token: 0x06001BCC RID: 7116
		public virtual extern event IMsTscAxEvents_OnLeaveFullScreenModeEventHandler OnLeaveFullScreenMode;

		// Token: 0x1400033D RID: 829
		// (add) Token: 0x06001BCD RID: 7117
		// (remove) Token: 0x06001BCE RID: 7118
		public virtual extern event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x1400033E RID: 830
		// (add) Token: 0x06001BCF RID: 7119
		// (remove) Token: 0x06001BD0 RID: 7120
		public virtual extern event IMsTscAxEvents_OnRequestGoFullScreenEventHandler OnRequestGoFullScreen;

		// Token: 0x1400033F RID: 831
		// (add) Token: 0x06001BD1 RID: 7121
		// (remove) Token: 0x06001BD2 RID: 7122
		public virtual extern event IMsTscAxEvents_OnRequestLeaveFullScreenEventHandler OnRequestLeaveFullScreen;

		// Token: 0x14000340 RID: 832
		// (add) Token: 0x06001BD3 RID: 7123
		// (remove) Token: 0x06001BD4 RID: 7124
		public virtual extern event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x14000341 RID: 833
		// (add) Token: 0x06001BD5 RID: 7125
		// (remove) Token: 0x06001BD6 RID: 7126
		public virtual extern event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x14000342 RID: 834
		// (add) Token: 0x06001BD7 RID: 7127
		// (remove) Token: 0x06001BD8 RID: 7128
		public virtual extern event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x14000343 RID: 835
		// (add) Token: 0x06001BD9 RID: 7129
		// (remove) Token: 0x06001BDA RID: 7130
		public virtual extern event IMsTscAxEvents_OnIdleTimeoutNotificationEventHandler OnIdleTimeoutNotification;

		// Token: 0x14000344 RID: 836
		// (add) Token: 0x06001BDB RID: 7131
		// (remove) Token: 0x06001BDC RID: 7132
		public virtual extern event IMsTscAxEvents_OnRequestContainerMinimizeEventHandler OnRequestContainerMinimize;

		// Token: 0x14000345 RID: 837
		// (add) Token: 0x06001BDD RID: 7133
		// (remove) Token: 0x06001BDE RID: 7134
		public virtual extern event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x14000346 RID: 838
		// (add) Token: 0x06001BDF RID: 7135
		// (remove) Token: 0x06001BE0 RID: 7136
		public virtual extern event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x14000347 RID: 839
		// (add) Token: 0x06001BE1 RID: 7137
		// (remove) Token: 0x06001BE2 RID: 7138
		public virtual extern event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x14000348 RID: 840
		// (add) Token: 0x06001BE3 RID: 7139
		// (remove) Token: 0x06001BE4 RID: 7140
		public virtual extern event IMsTscAxEvents_OnAuthenticationWarningDisplayedEventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x14000349 RID: 841
		// (add) Token: 0x06001BE5 RID: 7141
		// (remove) Token: 0x06001BE6 RID: 7142
		public virtual extern event IMsTscAxEvents_OnAuthenticationWarningDismissedEventHandler OnAuthenticationWarningDismissed;

		// Token: 0x1400034A RID: 842
		// (add) Token: 0x06001BE7 RID: 7143
		// (remove) Token: 0x06001BE8 RID: 7144
		public virtual extern event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x1400034B RID: 843
		// (add) Token: 0x06001BE9 RID: 7145
		// (remove) Token: 0x06001BEA RID: 7146
		public virtual extern event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x1400034C RID: 844
		// (add) Token: 0x06001BEB RID: 7147
		// (remove) Token: 0x06001BEC RID: 7148
		public virtual extern event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x1400034D RID: 845
		// (add) Token: 0x06001BED RID: 7149
		// (remove) Token: 0x06001BEE RID: 7150
		public virtual extern event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x1400034E RID: 846
		// (add) Token: 0x06001BEF RID: 7151
		// (remove) Token: 0x06001BF0 RID: 7152
		public virtual extern event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x1400034F RID: 847
		// (add) Token: 0x06001BF1 RID: 7153
		// (remove) Token: 0x06001BF2 RID: 7154
		public virtual extern event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x14000350 RID: 848
		// (add) Token: 0x06001BF3 RID: 7155
		// (remove) Token: 0x06001BF4 RID: 7156
		public virtual extern event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x14000351 RID: 849
		// (add) Token: 0x06001BF5 RID: 7157
		// (remove) Token: 0x06001BF6 RID: 7158
		public virtual extern event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x14000352 RID: 850
		// (add) Token: 0x06001BF7 RID: 7159
		// (remove) Token: 0x06001BF8 RID: 7160
		public virtual extern event IMsTscAxEvents_OnConnectionBarPullDownEventHandler OnConnectionBarPullDown;

		// Token: 0x14000353 RID: 851
		// (add) Token: 0x06001BF9 RID: 7161
		// (remove) Token: 0x06001BFA RID: 7162
		public virtual extern event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x14000354 RID: 852
		// (add) Token: 0x06001BFB RID: 7163
		// (remove) Token: 0x06001BFC RID: 7164
		public virtual extern event IMsTscAxEvents_OnDevicesButtonPressedEventHandler OnDevicesButtonPressed;

		// Token: 0x14000355 RID: 853
		// (add) Token: 0x06001BFD RID: 7165
		// (remove) Token: 0x06001BFE RID: 7166
		public virtual extern event IMsTscAxEvents_OnAutoReconnectedEventHandler OnAutoReconnected;

		// Token: 0x14000356 RID: 854
		// (add) Token: 0x06001BFF RID: 7167
		// (remove) Token: 0x06001C00 RID: 7168
		public virtual extern event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;
	}
}
