using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001C1 RID: 449
	[Guid("D2EA46A7-C2BF-426B-AF24-E19C44456399")]
	[ClassInterface(0)]
	[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0")]
	[TypeLibType(34)]
	[ComVisible(true)]
	[ComImport]
	public class MsRdpClient6NotSafeForScriptingClass : IMsRdpClient6, MsRdpClient6NotSafeForScripting, IMsTscAxEvents_Event, IMsRdpClient5, IMsRdpClient4, IMsRdpClient3, IMsRdpClient2, IMsRdpClient, IMsTscAx, IMsTscAx_Redist, IMsTscNonScriptable, IMsRdpClientNonScriptable, IMsRdpClientNonScriptable2, IMsRdpClientNonScriptable3, IMsRdpClientNonScriptable4
	{
		// Token: 0x06002E89 RID: 11913
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern MsRdpClient6NotSafeForScriptingClass();

		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x06002E8B RID: 11915
		// (set) Token: 0x06002E8A RID: 11914
		[DispId(1)]
		public virtual extern string Server { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x06002E8D RID: 11917
		// (set) Token: 0x06002E8C RID: 11916
		[DispId(2)]
		public virtual extern string Domain { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x06002E8F RID: 11919
		// (set) Token: 0x06002E8E RID: 11918
		[DispId(3)]
		public virtual extern string UserName { [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x06002E91 RID: 11921
		// (set) Token: 0x06002E90 RID: 11920
		[DispId(4)]
		public virtual extern string DisconnectedText { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x06002E93 RID: 11923
		// (set) Token: 0x06002E92 RID: 11922
		[DispId(5)]
		public virtual extern string ConnectingText { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x06002E94 RID: 11924
		[DispId(6)]
		public virtual extern short Connected { [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x06002E96 RID: 11926
		// (set) Token: 0x06002E95 RID: 11925
		[DispId(12)]
		public virtual extern int DesktopWidth { [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x06002E98 RID: 11928
		// (set) Token: 0x06002E97 RID: 11927
		[DispId(13)]
		public virtual extern int DesktopHeight { [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x06002E9A RID: 11930
		// (set) Token: 0x06002E99 RID: 11929
		[DispId(16)]
		public virtual extern int StartConnected { [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x06002E9B RID: 11931
		[DispId(17)]
		public virtual extern int HorizontalScrollBarVisible { [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x06002E9C RID: 11932
		[DispId(18)]
		public virtual extern int VerticalScrollBarVisible { [DispId(18)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000D3F RID: 3391
		// (set) Token: 0x06002E9D RID: 11933
		[DispId(19)]
		public virtual extern string FullScreenTitle { [DispId(19)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x06002E9E RID: 11934
		[DispId(20)]
		public virtual extern int CipherStrength { [DispId(20)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x06002E9F RID: 11935
		[DispId(21)]
		public virtual extern string Version { [DispId(21)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x06002EA0 RID: 11936
		[DispId(22)]
		public virtual extern int SecuredSettingsEnabled { [DispId(22)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x06002EA1 RID: 11937
		[DispId(97)]
		public virtual extern IMsTscSecuredSettings SecuredSettings { [DispId(97)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x06002EA2 RID: 11938
		[DispId(98)]
		public virtual extern IMsTscAdvancedSettings AdvancedSettings { [DispId(98)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x06002EA3 RID: 11939
		[DispId(99)]
		public virtual extern IMsTscDebug Debugger { [TypeLibFunc(64)] [DispId(99)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06002EA4 RID: 11940
		[DispId(30)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Connect();

		// Token: 0x06002EA5 RID: 11941
		[DispId(31)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Disconnect();

		// Token: 0x06002EA6 RID: 11942
		[DispId(33)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06002EA7 RID: 11943
		[DispId(34)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x06002EA9 RID: 11945
		// (set) Token: 0x06002EA8 RID: 11944
		[DispId(100)]
		public virtual extern int ColorDepth { [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x06002EAA RID: 11946
		[DispId(101)]
		public virtual extern IMsRdpClientAdvancedSettings AdvancedSettings2 { [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x06002EAB RID: 11947
		[DispId(102)]
		public virtual extern IMsRdpClientSecuredSettings SecuredSettings2 { [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x06002EAC RID: 11948
		[DispId(103)]
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode ExtendedDisconnectReason { [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x06002EAE RID: 11950
		// (set) Token: 0x06002EAD RID: 11949
		[DispId(104)]
		public virtual extern bool FullScreen { [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06002EAF RID: 11951
		[DispId(35)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06002EB0 RID: 11952
		[DispId(36)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06002EB1 RID: 11953
		[DispId(37)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus RequestClose();

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x06002EB2 RID: 11954
		[DispId(200)]
		public virtual extern IMsRdpClientAdvancedSettings2 AdvancedSettings3 { [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x06002EB4 RID: 11956
		// (set) Token: 0x06002EB3 RID: 11955
		[DispId(201)]
		public virtual extern string ConnectedStatusText { [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x06002EB5 RID: 11957
		[DispId(300)]
		public virtual extern IMsRdpClientAdvancedSettings3 AdvancedSettings4 { [DispId(300)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x06002EB6 RID: 11958
		[DispId(400)]
		public virtual extern IMsRdpClientAdvancedSettings4 AdvancedSettings5 { [DispId(400)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x06002EB7 RID: 11959
		[DispId(500)]
		public virtual extern IMsRdpClientTransportSettings TransportSettings { [DispId(500)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000D50 RID: 3408
		// (get) Token: 0x06002EB8 RID: 11960
		[DispId(502)]
		public virtual extern IMsRdpClientAdvancedSettings5 AdvancedSettings6 { [DispId(502)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06002EB9 RID: 11961
		[DispId(503)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x06002EBA RID: 11962
		[DispId(504)]
		public virtual extern ITSRemoteProgram RemoteProgram { [DispId(504)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x06002EBB RID: 11963
		[DispId(505)]
		public virtual extern IMsRdpClientShell MsRdpClientShell { [DispId(505)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x06002EBC RID: 11964
		[DispId(507)]
		public virtual extern IMsRdpClientAdvancedSettings6 AdvancedSettings7 { [DispId(507)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x06002EBD RID: 11965
		[DispId(506)]
		public virtual extern IMsRdpClientTransportSettings2 TransportSettings2 { [DispId(506)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000D55 RID: 3413
		// (get) Token: 0x06002EBF RID: 11967
		// (set) Token: 0x06002EBE RID: 11966
		public virtual extern string IMsRdpClient5_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D56 RID: 3414
		// (get) Token: 0x06002EC1 RID: 11969
		// (set) Token: 0x06002EC0 RID: 11968
		public virtual extern string IMsRdpClient5_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x06002EC3 RID: 11971
		// (set) Token: 0x06002EC2 RID: 11970
		public virtual extern string IMsRdpClient5_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x06002EC5 RID: 11973
		// (set) Token: 0x06002EC4 RID: 11972
		public virtual extern string IMsRdpClient5_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x06002EC7 RID: 11975
		// (set) Token: 0x06002EC6 RID: 11974
		public virtual extern string IMsRdpClient5_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x06002EC8 RID: 11976
		public virtual extern short IMsRdpClient5_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x06002ECA RID: 11978
		// (set) Token: 0x06002EC9 RID: 11977
		public virtual extern int IMsRdpClient5_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x06002ECC RID: 11980
		// (set) Token: 0x06002ECB RID: 11979
		public virtual extern int IMsRdpClient5_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x06002ECE RID: 11982
		// (set) Token: 0x06002ECD RID: 11981
		public virtual extern int IMsRdpClient5_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x06002ECF RID: 11983
		public virtual extern int IMsRdpClient5_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x06002ED0 RID: 11984
		public virtual extern int IMsRdpClient5_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000D60 RID: 3424
		// (set) Token: 0x06002ED1 RID: 11985
		public virtual extern string IMsRdpClient5_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x06002ED2 RID: 11986
		public virtual extern int IMsRdpClient5_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x06002ED3 RID: 11987
		public virtual extern string IMsRdpClient5_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x06002ED4 RID: 11988
		public virtual extern int IMsRdpClient5_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x06002ED5 RID: 11989
		public virtual extern IMsTscSecuredSettings IMsRdpClient5_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000D65 RID: 3429
		// (get) Token: 0x06002ED6 RID: 11990
		public virtual extern IMsTscAdvancedSettings IMsRdpClient5_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x06002ED7 RID: 11991
		public virtual extern IMsTscDebug IMsRdpClient5_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06002ED8 RID: 11992
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient5_Connect();

		// Token: 0x06002ED9 RID: 11993
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient5_Disconnect();

		// Token: 0x06002EDA RID: 11994
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient5_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06002EDB RID: 11995
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient5_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x06002EDD RID: 11997
		// (set) Token: 0x06002EDC RID: 11996
		public virtual extern int IMsRdpClient5_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x06002EDE RID: 11998
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient5_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000D69 RID: 3433
		// (get) Token: 0x06002EDF RID: 11999
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient5_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x06002EE0 RID: 12000
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient5_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x06002EE2 RID: 12002
		// (set) Token: 0x06002EE1 RID: 12001
		public virtual extern bool IMsRdpClient5_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06002EE3 RID: 12003
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient5_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06002EE4 RID: 12004
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient5_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06002EE5 RID: 12005
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient5_RequestClose();

		// Token: 0x17000D6C RID: 3436
		// (get) Token: 0x06002EE6 RID: 12006
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient5_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000D6D RID: 3437
		// (get) Token: 0x06002EE8 RID: 12008
		// (set) Token: 0x06002EE7 RID: 12007
		public virtual extern string IMsRdpClient5_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D6E RID: 3438
		// (get) Token: 0x06002EE9 RID: 12009
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient5_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000D6F RID: 3439
		// (get) Token: 0x06002EEA RID: 12010
		public virtual extern IMsRdpClientAdvancedSettings4 IMsRdpClient5_AdvancedSettings5 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000D70 RID: 3440
		// (get) Token: 0x06002EEB RID: 12011
		public virtual extern IMsRdpClientTransportSettings IMsRdpClient5_TransportSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000D71 RID: 3441
		// (get) Token: 0x06002EEC RID: 12012
		public virtual extern IMsRdpClientAdvancedSettings5 IMsRdpClient5_AdvancedSettings6 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06002EED RID: 12013
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IMsRdpClient5_GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

		// Token: 0x17000D72 RID: 3442
		// (get) Token: 0x06002EEE RID: 12014
		public virtual extern ITSRemoteProgram IMsRdpClient5_RemoteProgram { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000D73 RID: 3443
		// (get) Token: 0x06002EEF RID: 12015
		public virtual extern IMsRdpClientShell IMsRdpClient5_MsRdpClientShell { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000D74 RID: 3444
		// (get) Token: 0x06002EF1 RID: 12017
		// (set) Token: 0x06002EF0 RID: 12016
		public virtual extern string IMsRdpClient4_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D75 RID: 3445
		// (get) Token: 0x06002EF3 RID: 12019
		// (set) Token: 0x06002EF2 RID: 12018
		public virtual extern string IMsRdpClient4_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D76 RID: 3446
		// (get) Token: 0x06002EF5 RID: 12021
		// (set) Token: 0x06002EF4 RID: 12020
		public virtual extern string IMsRdpClient4_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D77 RID: 3447
		// (get) Token: 0x06002EF7 RID: 12023
		// (set) Token: 0x06002EF6 RID: 12022
		public virtual extern string IMsRdpClient4_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D78 RID: 3448
		// (get) Token: 0x06002EF9 RID: 12025
		// (set) Token: 0x06002EF8 RID: 12024
		public virtual extern string IMsRdpClient4_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D79 RID: 3449
		// (get) Token: 0x06002EFA RID: 12026
		public virtual extern short IMsRdpClient4_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000D7A RID: 3450
		// (get) Token: 0x06002EFC RID: 12028
		// (set) Token: 0x06002EFB RID: 12027
		public virtual extern int IMsRdpClient4_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000D7B RID: 3451
		// (get) Token: 0x06002EFE RID: 12030
		// (set) Token: 0x06002EFD RID: 12029
		public virtual extern int IMsRdpClient4_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000D7C RID: 3452
		// (get) Token: 0x06002F00 RID: 12032
		// (set) Token: 0x06002EFF RID: 12031
		public virtual extern int IMsRdpClient4_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000D7D RID: 3453
		// (get) Token: 0x06002F01 RID: 12033
		public virtual extern int IMsRdpClient4_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000D7E RID: 3454
		// (get) Token: 0x06002F02 RID: 12034
		public virtual extern int IMsRdpClient4_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000D7F RID: 3455
		// (set) Token: 0x06002F03 RID: 12035
		public virtual extern string IMsRdpClient4_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D80 RID: 3456
		// (get) Token: 0x06002F04 RID: 12036
		public virtual extern int IMsRdpClient4_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000D81 RID: 3457
		// (get) Token: 0x06002F05 RID: 12037
		public virtual extern string IMsRdpClient4_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000D82 RID: 3458
		// (get) Token: 0x06002F06 RID: 12038
		public virtual extern int IMsRdpClient4_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000D83 RID: 3459
		// (get) Token: 0x06002F07 RID: 12039
		public virtual extern IMsTscSecuredSettings IMsRdpClient4_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000D84 RID: 3460
		// (get) Token: 0x06002F08 RID: 12040
		public virtual extern IMsTscAdvancedSettings IMsRdpClient4_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000D85 RID: 3461
		// (get) Token: 0x06002F09 RID: 12041
		public virtual extern IMsTscDebug IMsRdpClient4_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06002F0A RID: 12042
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_Connect();

		// Token: 0x06002F0B RID: 12043
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_Disconnect();

		// Token: 0x06002F0C RID: 12044
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06002F0D RID: 12045
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17000D86 RID: 3462
		// (get) Token: 0x06002F0F RID: 12047
		// (set) Token: 0x06002F0E RID: 12046
		public virtual extern int IMsRdpClient4_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000D87 RID: 3463
		// (get) Token: 0x06002F10 RID: 12048
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient4_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000D88 RID: 3464
		// (get) Token: 0x06002F11 RID: 12049
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient4_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000D89 RID: 3465
		// (get) Token: 0x06002F12 RID: 12050
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient4_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17000D8A RID: 3466
		// (get) Token: 0x06002F14 RID: 12052
		// (set) Token: 0x06002F13 RID: 12051
		public virtual extern bool IMsRdpClient4_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06002F15 RID: 12053
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06002F16 RID: 12054
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient4_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06002F17 RID: 12055
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient4_RequestClose();

		// Token: 0x17000D8B RID: 3467
		// (get) Token: 0x06002F18 RID: 12056
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient4_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000D8C RID: 3468
		// (get) Token: 0x06002F1A RID: 12058
		// (set) Token: 0x06002F19 RID: 12057
		public virtual extern string IMsRdpClient4_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D8D RID: 3469
		// (get) Token: 0x06002F1B RID: 12059
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient4_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000D8E RID: 3470
		// (get) Token: 0x06002F1C RID: 12060
		public virtual extern IMsRdpClientAdvancedSettings4 IMsRdpClient4_AdvancedSettings5 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000D8F RID: 3471
		// (get) Token: 0x06002F1E RID: 12062
		// (set) Token: 0x06002F1D RID: 12061
		public virtual extern string IMsRdpClient3_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D90 RID: 3472
		// (get) Token: 0x06002F20 RID: 12064
		// (set) Token: 0x06002F1F RID: 12063
		public virtual extern string IMsRdpClient3_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x06002F22 RID: 12066
		// (set) Token: 0x06002F21 RID: 12065
		public virtual extern string IMsRdpClient3_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D92 RID: 3474
		// (get) Token: 0x06002F24 RID: 12068
		// (set) Token: 0x06002F23 RID: 12067
		public virtual extern string IMsRdpClient3_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D93 RID: 3475
		// (get) Token: 0x06002F26 RID: 12070
		// (set) Token: 0x06002F25 RID: 12069
		public virtual extern string IMsRdpClient3_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D94 RID: 3476
		// (get) Token: 0x06002F27 RID: 12071
		public virtual extern short IMsRdpClient3_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x06002F29 RID: 12073
		// (set) Token: 0x06002F28 RID: 12072
		public virtual extern int IMsRdpClient3_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000D96 RID: 3478
		// (get) Token: 0x06002F2B RID: 12075
		// (set) Token: 0x06002F2A RID: 12074
		public virtual extern int IMsRdpClient3_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000D97 RID: 3479
		// (get) Token: 0x06002F2D RID: 12077
		// (set) Token: 0x06002F2C RID: 12076
		public virtual extern int IMsRdpClient3_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000D98 RID: 3480
		// (get) Token: 0x06002F2E RID: 12078
		public virtual extern int IMsRdpClient3_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000D99 RID: 3481
		// (get) Token: 0x06002F2F RID: 12079
		public virtual extern int IMsRdpClient3_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000D9A RID: 3482
		// (set) Token: 0x06002F30 RID: 12080
		public virtual extern string IMsRdpClient3_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x06002F31 RID: 12081
		public virtual extern int IMsRdpClient3_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000D9C RID: 3484
		// (get) Token: 0x06002F32 RID: 12082
		public virtual extern string IMsRdpClient3_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000D9D RID: 3485
		// (get) Token: 0x06002F33 RID: 12083
		public virtual extern int IMsRdpClient3_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000D9E RID: 3486
		// (get) Token: 0x06002F34 RID: 12084
		public virtual extern IMsTscSecuredSettings IMsRdpClient3_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000D9F RID: 3487
		// (get) Token: 0x06002F35 RID: 12085
		public virtual extern IMsTscAdvancedSettings IMsRdpClient3_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000DA0 RID: 3488
		// (get) Token: 0x06002F36 RID: 12086
		public virtual extern IMsTscDebug IMsRdpClient3_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06002F37 RID: 12087
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_Connect();

		// Token: 0x06002F38 RID: 12088
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_Disconnect();

		// Token: 0x06002F39 RID: 12089
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06002F3A RID: 12090
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17000DA1 RID: 3489
		// (get) Token: 0x06002F3C RID: 12092
		// (set) Token: 0x06002F3B RID: 12091
		public virtual extern int IMsRdpClient3_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000DA2 RID: 3490
		// (get) Token: 0x06002F3D RID: 12093
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient3_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000DA3 RID: 3491
		// (get) Token: 0x06002F3E RID: 12094
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient3_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000DA4 RID: 3492
		// (get) Token: 0x06002F3F RID: 12095
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient3_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17000DA5 RID: 3493
		// (get) Token: 0x06002F41 RID: 12097
		// (set) Token: 0x06002F40 RID: 12096
		public virtual extern bool IMsRdpClient3_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06002F42 RID: 12098
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06002F43 RID: 12099
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient3_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06002F44 RID: 12100
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient3_RequestClose();

		// Token: 0x17000DA6 RID: 3494
		// (get) Token: 0x06002F45 RID: 12101
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient3_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000DA7 RID: 3495
		// (get) Token: 0x06002F47 RID: 12103
		// (set) Token: 0x06002F46 RID: 12102
		public virtual extern string IMsRdpClient3_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000DA8 RID: 3496
		// (get) Token: 0x06002F48 RID: 12104
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient3_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000DA9 RID: 3497
		// (get) Token: 0x06002F4A RID: 12106
		// (set) Token: 0x06002F49 RID: 12105
		public virtual extern string IMsRdpClient2_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000DAA RID: 3498
		// (get) Token: 0x06002F4C RID: 12108
		// (set) Token: 0x06002F4B RID: 12107
		public virtual extern string IMsRdpClient2_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000DAB RID: 3499
		// (get) Token: 0x06002F4E RID: 12110
		// (set) Token: 0x06002F4D RID: 12109
		public virtual extern string IMsRdpClient2_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000DAC RID: 3500
		// (get) Token: 0x06002F50 RID: 12112
		// (set) Token: 0x06002F4F RID: 12111
		public virtual extern string IMsRdpClient2_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000DAD RID: 3501
		// (get) Token: 0x06002F52 RID: 12114
		// (set) Token: 0x06002F51 RID: 12113
		public virtual extern string IMsRdpClient2_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000DAE RID: 3502
		// (get) Token: 0x06002F53 RID: 12115
		public virtual extern short IMsRdpClient2_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000DAF RID: 3503
		// (get) Token: 0x06002F55 RID: 12117
		// (set) Token: 0x06002F54 RID: 12116
		public virtual extern int IMsRdpClient2_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000DB0 RID: 3504
		// (get) Token: 0x06002F57 RID: 12119
		// (set) Token: 0x06002F56 RID: 12118
		public virtual extern int IMsRdpClient2_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000DB1 RID: 3505
		// (get) Token: 0x06002F59 RID: 12121
		// (set) Token: 0x06002F58 RID: 12120
		public virtual extern int IMsRdpClient2_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000DB2 RID: 3506
		// (get) Token: 0x06002F5A RID: 12122
		public virtual extern int IMsRdpClient2_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x06002F5B RID: 12123
		public virtual extern int IMsRdpClient2_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000DB4 RID: 3508
		// (set) Token: 0x06002F5C RID: 12124
		public virtual extern string IMsRdpClient2_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000DB5 RID: 3509
		// (get) Token: 0x06002F5D RID: 12125
		public virtual extern int IMsRdpClient2_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000DB6 RID: 3510
		// (get) Token: 0x06002F5E RID: 12126
		public virtual extern string IMsRdpClient2_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000DB7 RID: 3511
		// (get) Token: 0x06002F5F RID: 12127
		public virtual extern int IMsRdpClient2_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000DB8 RID: 3512
		// (get) Token: 0x06002F60 RID: 12128
		public virtual extern IMsTscSecuredSettings IMsRdpClient2_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000DB9 RID: 3513
		// (get) Token: 0x06002F61 RID: 12129
		public virtual extern IMsTscAdvancedSettings IMsRdpClient2_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000DBA RID: 3514
		// (get) Token: 0x06002F62 RID: 12130
		public virtual extern IMsTscDebug IMsRdpClient2_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06002F63 RID: 12131
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_Connect();

		// Token: 0x06002F64 RID: 12132
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_Disconnect();

		// Token: 0x06002F65 RID: 12133
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06002F66 RID: 12134
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17000DBB RID: 3515
		// (get) Token: 0x06002F68 RID: 12136
		// (set) Token: 0x06002F67 RID: 12135
		public virtual extern int IMsRdpClient2_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000DBC RID: 3516
		// (get) Token: 0x06002F69 RID: 12137
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient2_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000DBD RID: 3517
		// (get) Token: 0x06002F6A RID: 12138
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient2_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x06002F6B RID: 12139
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient2_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x06002F6D RID: 12141
		// (set) Token: 0x06002F6C RID: 12140
		public virtual extern bool IMsRdpClient2_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06002F6E RID: 12142
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06002F6F RID: 12143
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient2_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06002F70 RID: 12144
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient2_RequestClose();

		// Token: 0x17000DC0 RID: 3520
		// (get) Token: 0x06002F71 RID: 12145
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient2_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000DC1 RID: 3521
		// (get) Token: 0x06002F73 RID: 12147
		// (set) Token: 0x06002F72 RID: 12146
		public virtual extern string IMsRdpClient2_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000DC2 RID: 3522
		// (get) Token: 0x06002F75 RID: 12149
		// (set) Token: 0x06002F74 RID: 12148
		public virtual extern string IMsRdpClient_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000DC3 RID: 3523
		// (get) Token: 0x06002F77 RID: 12151
		// (set) Token: 0x06002F76 RID: 12150
		public virtual extern string IMsRdpClient_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000DC4 RID: 3524
		// (get) Token: 0x06002F79 RID: 12153
		// (set) Token: 0x06002F78 RID: 12152
		public virtual extern string IMsRdpClient_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000DC5 RID: 3525
		// (get) Token: 0x06002F7B RID: 12155
		// (set) Token: 0x06002F7A RID: 12154
		public virtual extern string IMsRdpClient_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000DC6 RID: 3526
		// (get) Token: 0x06002F7D RID: 12157
		// (set) Token: 0x06002F7C RID: 12156
		public virtual extern string IMsRdpClient_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000DC7 RID: 3527
		// (get) Token: 0x06002F7E RID: 12158
		public virtual extern short IMsRdpClient_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000DC8 RID: 3528
		// (get) Token: 0x06002F80 RID: 12160
		// (set) Token: 0x06002F7F RID: 12159
		public virtual extern int IMsRdpClient_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000DC9 RID: 3529
		// (get) Token: 0x06002F82 RID: 12162
		// (set) Token: 0x06002F81 RID: 12161
		public virtual extern int IMsRdpClient_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000DCA RID: 3530
		// (get) Token: 0x06002F84 RID: 12164
		// (set) Token: 0x06002F83 RID: 12163
		public virtual extern int IMsRdpClient_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000DCB RID: 3531
		// (get) Token: 0x06002F85 RID: 12165
		public virtual extern int IMsRdpClient_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000DCC RID: 3532
		// (get) Token: 0x06002F86 RID: 12166
		public virtual extern int IMsRdpClient_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000DCD RID: 3533
		// (set) Token: 0x06002F87 RID: 12167
		public virtual extern string IMsRdpClient_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000DCE RID: 3534
		// (get) Token: 0x06002F88 RID: 12168
		public virtual extern int IMsRdpClient_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000DCF RID: 3535
		// (get) Token: 0x06002F89 RID: 12169
		public virtual extern string IMsRdpClient_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000DD0 RID: 3536
		// (get) Token: 0x06002F8A RID: 12170
		public virtual extern int IMsRdpClient_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000DD1 RID: 3537
		// (get) Token: 0x06002F8B RID: 12171
		public virtual extern IMsTscSecuredSettings IMsRdpClient_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x06002F8C RID: 12172
		public virtual extern IMsTscAdvancedSettings IMsRdpClient_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000DD3 RID: 3539
		// (get) Token: 0x06002F8D RID: 12173
		public virtual extern IMsTscDebug IMsRdpClient_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06002F8E RID: 12174
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_Connect();

		// Token: 0x06002F8F RID: 12175
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_Disconnect();

		// Token: 0x06002F90 RID: 12176
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06002F91 RID: 12177
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x06002F93 RID: 12179
		// (set) Token: 0x06002F92 RID: 12178
		public virtual extern int IMsRdpClient_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x06002F94 RID: 12180
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x06002F95 RID: 12181
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000DD7 RID: 3543
		// (get) Token: 0x06002F96 RID: 12182
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17000DD8 RID: 3544
		// (get) Token: 0x06002F98 RID: 12184
		// (set) Token: 0x06002F97 RID: 12183
		public virtual extern bool IMsRdpClient_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06002F99 RID: 12185
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06002F9A RID: 12186
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06002F9B RID: 12187
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient_RequestClose();

		// Token: 0x17000DD9 RID: 3545
		// (get) Token: 0x06002F9D RID: 12189
		// (set) Token: 0x06002F9C RID: 12188
		public virtual extern string IMsTscAx_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000DDA RID: 3546
		// (get) Token: 0x06002F9F RID: 12191
		// (set) Token: 0x06002F9E RID: 12190
		public virtual extern string IMsTscAx_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000DDB RID: 3547
		// (get) Token: 0x06002FA1 RID: 12193
		// (set) Token: 0x06002FA0 RID: 12192
		public virtual extern string IMsTscAx_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000DDC RID: 3548
		// (get) Token: 0x06002FA3 RID: 12195
		// (set) Token: 0x06002FA2 RID: 12194
		public virtual extern string IMsTscAx_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x06002FA5 RID: 12197
		// (set) Token: 0x06002FA4 RID: 12196
		public virtual extern string IMsTscAx_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x06002FA6 RID: 12198
		public virtual extern short IMsTscAx_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x06002FA8 RID: 12200
		// (set) Token: 0x06002FA7 RID: 12199
		public virtual extern int IMsTscAx_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x06002FAA RID: 12202
		// (set) Token: 0x06002FA9 RID: 12201
		public virtual extern int IMsTscAx_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000DE1 RID: 3553
		// (get) Token: 0x06002FAC RID: 12204
		// (set) Token: 0x06002FAB RID: 12203
		public virtual extern int IMsTscAx_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x06002FAD RID: 12205
		public virtual extern int IMsTscAx_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x06002FAE RID: 12206
		public virtual extern int IMsTscAx_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000DE4 RID: 3556
		// (set) Token: 0x06002FAF RID: 12207
		public virtual extern string IMsTscAx_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000DE5 RID: 3557
		// (get) Token: 0x06002FB0 RID: 12208
		public virtual extern int IMsTscAx_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x06002FB1 RID: 12209
		public virtual extern string IMsTscAx_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x06002FB2 RID: 12210
		public virtual extern int IMsTscAx_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x06002FB3 RID: 12211
		public virtual extern IMsTscSecuredSettings IMsTscAx_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x06002FB4 RID: 12212
		public virtual extern IMsTscAdvancedSettings IMsTscAx_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000DEA RID: 3562
		// (get) Token: 0x06002FB5 RID: 12213
		public virtual extern IMsTscDebug IMsTscAx_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06002FB6 RID: 12214
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_Connect();

		// Token: 0x06002FB7 RID: 12215
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_Disconnect();

		// Token: 0x06002FB8 RID: 12216
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06002FB9 RID: 12217
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17000DEB RID: 3563
		// (set) Token: 0x06002FBA RID: 12218
		public virtual extern string ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x06002FBC RID: 12220
		// (set) Token: 0x06002FBB RID: 12219
		public virtual extern string PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x06002FBE RID: 12222
		// (set) Token: 0x06002FBD RID: 12221
		public virtual extern string PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000DEE RID: 3566
		// (get) Token: 0x06002FC0 RID: 12224
		// (set) Token: 0x06002FBF RID: 12223
		public virtual extern string BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000DEF RID: 3567
		// (get) Token: 0x06002FC2 RID: 12226
		// (set) Token: 0x06002FC1 RID: 12225
		public virtual extern string BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06002FC3 RID: 12227
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void ResetPassword();

		// Token: 0x17000DF0 RID: 3568
		// (set) Token: 0x06002FC4 RID: 12228
		public virtual extern string IMsRdpClientNonScriptable_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x06002FC6 RID: 12230
		// (set) Token: 0x06002FC5 RID: 12229
		public virtual extern string IMsRdpClientNonScriptable_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000DF2 RID: 3570
		// (get) Token: 0x06002FC8 RID: 12232
		// (set) Token: 0x06002FC7 RID: 12231
		public virtual extern string IMsRdpClientNonScriptable_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000DF3 RID: 3571
		// (get) Token: 0x06002FCA RID: 12234
		// (set) Token: 0x06002FC9 RID: 12233
		public virtual extern string IMsRdpClientNonScriptable_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x06002FCC RID: 12236
		// (set) Token: 0x06002FCB RID: 12235
		public virtual extern string IMsRdpClientNonScriptable_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06002FCD RID: 12237
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable_ResetPassword();

		// Token: 0x06002FCE RID: 12238
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06002FCF RID: 12239
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x17000DF5 RID: 3573
		// (set) Token: 0x06002FD0 RID: 12240
		public virtual extern string IMsRdpClientNonScriptable2_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000DF6 RID: 3574
		// (get) Token: 0x06002FD2 RID: 12242
		// (set) Token: 0x06002FD1 RID: 12241
		public virtual extern string IMsRdpClientNonScriptable2_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x06002FD4 RID: 12244
		// (set) Token: 0x06002FD3 RID: 12243
		public virtual extern string IMsRdpClientNonScriptable2_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x06002FD6 RID: 12246
		// (set) Token: 0x06002FD5 RID: 12245
		public virtual extern string IMsRdpClientNonScriptable2_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x06002FD8 RID: 12248
		// (set) Token: 0x06002FD7 RID: 12247
		public virtual extern string IMsRdpClientNonScriptable2_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06002FD9 RID: 12249
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable2_ResetPassword();

		// Token: 0x06002FDA RID: 12250
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable2_NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06002FDB RID: 12251
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable2_SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x06002FDD RID: 12253
		// (set) Token: 0x06002FDC RID: 12252
		[ComAliasName("MSTSCLib.wireHWND")]
		public virtual extern IntPtr UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x17000DFB RID: 3579
		// (set) Token: 0x06002FDE RID: 12254
		public virtual extern string IMsRdpClientNonScriptable3_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x06002FE0 RID: 12256
		// (set) Token: 0x06002FDF RID: 12255
		public virtual extern string IMsRdpClientNonScriptable3_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000DFD RID: 3581
		// (get) Token: 0x06002FE2 RID: 12258
		// (set) Token: 0x06002FE1 RID: 12257
		public virtual extern string IMsRdpClientNonScriptable3_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000DFE RID: 3582
		// (get) Token: 0x06002FE4 RID: 12260
		// (set) Token: 0x06002FE3 RID: 12259
		public virtual extern string IMsRdpClientNonScriptable3_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000DFF RID: 3583
		// (get) Token: 0x06002FE6 RID: 12262
		// (set) Token: 0x06002FE5 RID: 12261
		public virtual extern string IMsRdpClientNonScriptable3_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06002FE7 RID: 12263
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable3_ResetPassword();

		// Token: 0x06002FE8 RID: 12264
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable3_NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06002FE9 RID: 12265
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable3_SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x17000E00 RID: 3584
		// (get) Token: 0x06002FEB RID: 12267
		// (set) Token: 0x06002FEA RID: 12266
		[ComAliasName("MSTSCLib.wireHWND")]
		public virtual extern IntPtr IMsRdpClientNonScriptable3_UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x06002FED RID: 12269
		// (set) Token: 0x06002FEC RID: 12268
		public virtual extern bool ShowRedirectionWarningDialog { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E02 RID: 3586
		// (get) Token: 0x06002FEF RID: 12271
		// (set) Token: 0x06002FEE RID: 12270
		public virtual extern bool PromptForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x06002FF1 RID: 12273
		// (set) Token: 0x06002FF0 RID: 12272
		public virtual extern bool NegotiateSecurityLayer { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E04 RID: 3588
		// (get) Token: 0x06002FF3 RID: 12275
		// (set) Token: 0x06002FF2 RID: 12274
		public virtual extern bool EnableCredSspSupport { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x06002FF5 RID: 12277
		// (set) Token: 0x06002FF4 RID: 12276
		public virtual extern bool RedirectDynamicDrives { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x06002FF7 RID: 12279
		// (set) Token: 0x06002FF6 RID: 12278
		public virtual extern bool RedirectDynamicDevices { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x06002FF8 RID: 12280
		public virtual extern IMsRdpDeviceCollection DeviceCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000E08 RID: 3592
		// (get) Token: 0x06002FF9 RID: 12281
		public virtual extern IMsRdpDriveCollection DriveCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x06002FFB RID: 12283
		// (set) Token: 0x06002FFA RID: 12282
		public virtual extern bool WarnAboutSendingCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x06002FFD RID: 12285
		// (set) Token: 0x06002FFC RID: 12284
		public virtual extern bool WarnAboutClipboardRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x06002FFF RID: 12287
		// (set) Token: 0x06002FFE RID: 12286
		public virtual extern string ConnectionBarText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000E0C RID: 3596
		// (set) Token: 0x06003000 RID: 12288
		public virtual extern string IMsRdpClientNonScriptable4_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x06003002 RID: 12290
		// (set) Token: 0x06003001 RID: 12289
		public virtual extern string IMsRdpClientNonScriptable4_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x06003004 RID: 12292
		// (set) Token: 0x06003003 RID: 12291
		public virtual extern string IMsRdpClientNonScriptable4_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x06003006 RID: 12294
		// (set) Token: 0x06003005 RID: 12293
		public virtual extern string IMsRdpClientNonScriptable4_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000E10 RID: 3600
		// (get) Token: 0x06003008 RID: 12296
		// (set) Token: 0x06003007 RID: 12295
		public virtual extern string IMsRdpClientNonScriptable4_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06003009 RID: 12297
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable4_ResetPassword();

		// Token: 0x0600300A RID: 12298
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable4_NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x0600300B RID: 12299
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable4_SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x0600300D RID: 12301
		// (set) Token: 0x0600300C RID: 12300
		[ComAliasName("MSTSCLib.wireHWND")]
		public virtual extern IntPtr IMsRdpClientNonScriptable4_UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x0600300F RID: 12303
		// (set) Token: 0x0600300E RID: 12302
		public virtual extern bool IMsRdpClientNonScriptable4_ShowRedirectionWarningDialog { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E13 RID: 3603
		// (get) Token: 0x06003011 RID: 12305
		// (set) Token: 0x06003010 RID: 12304
		public virtual extern bool IMsRdpClientNonScriptable4_PromptForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x06003013 RID: 12307
		// (set) Token: 0x06003012 RID: 12306
		public virtual extern bool IMsRdpClientNonScriptable4_NegotiateSecurityLayer { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E15 RID: 3605
		// (get) Token: 0x06003015 RID: 12309
		// (set) Token: 0x06003014 RID: 12308
		public virtual extern bool IMsRdpClientNonScriptable4_EnableCredSspSupport { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x06003017 RID: 12311
		// (set) Token: 0x06003016 RID: 12310
		public virtual extern bool IMsRdpClientNonScriptable4_RedirectDynamicDrives { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x06003019 RID: 12313
		// (set) Token: 0x06003018 RID: 12312
		public virtual extern bool IMsRdpClientNonScriptable4_RedirectDynamicDevices { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E18 RID: 3608
		// (get) Token: 0x0600301A RID: 12314
		public virtual extern IMsRdpDeviceCollection IMsRdpClientNonScriptable4_DeviceCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000E19 RID: 3609
		// (get) Token: 0x0600301B RID: 12315
		public virtual extern IMsRdpDriveCollection IMsRdpClientNonScriptable4_DriveCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000E1A RID: 3610
		// (get) Token: 0x0600301D RID: 12317
		// (set) Token: 0x0600301C RID: 12316
		public virtual extern bool IMsRdpClientNonScriptable4_WarnAboutSendingCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E1B RID: 3611
		// (get) Token: 0x0600301F RID: 12319
		// (set) Token: 0x0600301E RID: 12318
		public virtual extern bool IMsRdpClientNonScriptable4_WarnAboutClipboardRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E1C RID: 3612
		// (get) Token: 0x06003021 RID: 12321
		// (set) Token: 0x06003020 RID: 12320
		public virtual extern string IMsRdpClientNonScriptable4_ConnectionBarText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000E1D RID: 3613
		// (get) Token: 0x06003023 RID: 12323
		// (set) Token: 0x06003022 RID: 12322
		[ComAliasName("MSTSCLib.RedirectionWarningType")]
		public virtual extern RedirectionWarningType RedirectionWarningType { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.RedirectionWarningType")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.RedirectionWarningType")] [param: In] set; }

		// Token: 0x17000E1E RID: 3614
		// (get) Token: 0x06003025 RID: 12325
		// (set) Token: 0x06003024 RID: 12324
		public virtual extern bool MarkRdpSettingsSecure { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E1F RID: 3615
		// (get) Token: 0x06003027 RID: 12327
		// (set) Token: 0x06003026 RID: 12326
		public virtual extern object PublisherCertificateChain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Struct)] [param: In] set; }

		// Token: 0x17000E20 RID: 3616
		// (get) Token: 0x06003029 RID: 12329
		// (set) Token: 0x06003028 RID: 12328
		public virtual extern bool WarnAboutPrinterRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E21 RID: 3617
		// (get) Token: 0x0600302B RID: 12331
		// (set) Token: 0x0600302A RID: 12330
		public virtual extern bool AllowCredentialSaving { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E22 RID: 3618
		// (get) Token: 0x0600302D RID: 12333
		// (set) Token: 0x0600302C RID: 12332
		public virtual extern bool PromptForCredsOnClient { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x0600302F RID: 12335
		// (set) Token: 0x0600302E RID: 12334
		public virtual extern bool LaunchedViaClientShellInterface { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000E24 RID: 3620
		// (get) Token: 0x06003031 RID: 12337
		// (set) Token: 0x06003030 RID: 12336
		public virtual extern bool TrustedZoneSite { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x14000537 RID: 1335
		// (add) Token: 0x06003032 RID: 12338
		// (remove) Token: 0x06003033 RID: 12339
		public virtual extern event IMsTscAxEvents_OnConnectingEventHandler OnConnecting;

		// Token: 0x14000538 RID: 1336
		// (add) Token: 0x06003034 RID: 12340
		// (remove) Token: 0x06003035 RID: 12341
		public virtual extern event IMsTscAxEvents_OnConnectedEventHandler OnConnected;

		// Token: 0x14000539 RID: 1337
		// (add) Token: 0x06003036 RID: 12342
		// (remove) Token: 0x06003037 RID: 12343
		public virtual extern event IMsTscAxEvents_OnLoginCompleteEventHandler OnLoginComplete;

		// Token: 0x1400053A RID: 1338
		// (add) Token: 0x06003038 RID: 12344
		// (remove) Token: 0x06003039 RID: 12345
		public virtual extern event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x1400053B RID: 1339
		// (add) Token: 0x0600303A RID: 12346
		// (remove) Token: 0x0600303B RID: 12347
		public virtual extern event IMsTscAxEvents_OnEnterFullScreenModeEventHandler OnEnterFullScreenMode;

		// Token: 0x1400053C RID: 1340
		// (add) Token: 0x0600303C RID: 12348
		// (remove) Token: 0x0600303D RID: 12349
		public virtual extern event IMsTscAxEvents_OnLeaveFullScreenModeEventHandler OnLeaveFullScreenMode;

		// Token: 0x1400053D RID: 1341
		// (add) Token: 0x0600303E RID: 12350
		// (remove) Token: 0x0600303F RID: 12351
		public virtual extern event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x1400053E RID: 1342
		// (add) Token: 0x06003040 RID: 12352
		// (remove) Token: 0x06003041 RID: 12353
		public virtual extern event IMsTscAxEvents_OnRequestGoFullScreenEventHandler OnRequestGoFullScreen;

		// Token: 0x1400053F RID: 1343
		// (add) Token: 0x06003042 RID: 12354
		// (remove) Token: 0x06003043 RID: 12355
		public virtual extern event IMsTscAxEvents_OnRequestLeaveFullScreenEventHandler OnRequestLeaveFullScreen;

		// Token: 0x14000540 RID: 1344
		// (add) Token: 0x06003044 RID: 12356
		// (remove) Token: 0x06003045 RID: 12357
		public virtual extern event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x14000541 RID: 1345
		// (add) Token: 0x06003046 RID: 12358
		// (remove) Token: 0x06003047 RID: 12359
		public virtual extern event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x14000542 RID: 1346
		// (add) Token: 0x06003048 RID: 12360
		// (remove) Token: 0x06003049 RID: 12361
		public virtual extern event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x14000543 RID: 1347
		// (add) Token: 0x0600304A RID: 12362
		// (remove) Token: 0x0600304B RID: 12363
		public virtual extern event IMsTscAxEvents_OnIdleTimeoutNotificationEventHandler OnIdleTimeoutNotification;

		// Token: 0x14000544 RID: 1348
		// (add) Token: 0x0600304C RID: 12364
		// (remove) Token: 0x0600304D RID: 12365
		public virtual extern event IMsTscAxEvents_OnRequestContainerMinimizeEventHandler OnRequestContainerMinimize;

		// Token: 0x14000545 RID: 1349
		// (add) Token: 0x0600304E RID: 12366
		// (remove) Token: 0x0600304F RID: 12367
		public virtual extern event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x14000546 RID: 1350
		// (add) Token: 0x06003050 RID: 12368
		// (remove) Token: 0x06003051 RID: 12369
		public virtual extern event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x14000547 RID: 1351
		// (add) Token: 0x06003052 RID: 12370
		// (remove) Token: 0x06003053 RID: 12371
		public virtual extern event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x14000548 RID: 1352
		// (add) Token: 0x06003054 RID: 12372
		// (remove) Token: 0x06003055 RID: 12373
		public virtual extern event IMsTscAxEvents_OnAuthenticationWarningDisplayedEventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x14000549 RID: 1353
		// (add) Token: 0x06003056 RID: 12374
		// (remove) Token: 0x06003057 RID: 12375
		public virtual extern event IMsTscAxEvents_OnAuthenticationWarningDismissedEventHandler OnAuthenticationWarningDismissed;

		// Token: 0x1400054A RID: 1354
		// (add) Token: 0x06003058 RID: 12376
		// (remove) Token: 0x06003059 RID: 12377
		public virtual extern event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x1400054B RID: 1355
		// (add) Token: 0x0600305A RID: 12378
		// (remove) Token: 0x0600305B RID: 12379
		public virtual extern event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x1400054C RID: 1356
		// (add) Token: 0x0600305C RID: 12380
		// (remove) Token: 0x0600305D RID: 12381
		public virtual extern event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x1400054D RID: 1357
		// (add) Token: 0x0600305E RID: 12382
		// (remove) Token: 0x0600305F RID: 12383
		public virtual extern event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x1400054E RID: 1358
		// (add) Token: 0x06003060 RID: 12384
		// (remove) Token: 0x06003061 RID: 12385
		public virtual extern event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x1400054F RID: 1359
		// (add) Token: 0x06003062 RID: 12386
		// (remove) Token: 0x06003063 RID: 12387
		public virtual extern event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x14000550 RID: 1360
		// (add) Token: 0x06003064 RID: 12388
		// (remove) Token: 0x06003065 RID: 12389
		public virtual extern event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x14000551 RID: 1361
		// (add) Token: 0x06003066 RID: 12390
		// (remove) Token: 0x06003067 RID: 12391
		public virtual extern event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x14000552 RID: 1362
		// (add) Token: 0x06003068 RID: 12392
		// (remove) Token: 0x06003069 RID: 12393
		public virtual extern event IMsTscAxEvents_OnConnectionBarPullDownEventHandler OnConnectionBarPullDown;

		// Token: 0x14000553 RID: 1363
		// (add) Token: 0x0600306A RID: 12394
		// (remove) Token: 0x0600306B RID: 12395
		public virtual extern event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x14000554 RID: 1364
		// (add) Token: 0x0600306C RID: 12396
		// (remove) Token: 0x0600306D RID: 12397
		public virtual extern event IMsTscAxEvents_OnDevicesButtonPressedEventHandler OnDevicesButtonPressed;

		// Token: 0x14000555 RID: 1365
		// (add) Token: 0x0600306E RID: 12398
		// (remove) Token: 0x0600306F RID: 12399
		public virtual extern event IMsTscAxEvents_OnAutoReconnectedEventHandler OnAutoReconnected;

		// Token: 0x14000556 RID: 1366
		// (add) Token: 0x06003070 RID: 12400
		// (remove) Token: 0x06003071 RID: 12401
		public virtual extern event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;
	}
}
