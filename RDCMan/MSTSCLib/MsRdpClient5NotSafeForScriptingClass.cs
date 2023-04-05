using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001B3 RID: 435
	[Guid("4EB2F086-C818-447E-B32C-C51CE2B30D31")]
	[ClassInterface(0)]
	[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0")]
	[TypeLibType(34)]
	[ComVisible(true)]
	[ComImport]
	public class MsRdpClient5NotSafeForScriptingClass : IMsRdpClient5, MsRdpClient5NotSafeForScripting, IMsTscAxEvents_Event, IMsRdpClient4, IMsRdpClient3, IMsRdpClient2, IMsRdpClient, IMsTscAx, IMsTscAx_Redist, IMsTscNonScriptable, IMsRdpClientNonScriptable, IMsRdpClientNonScriptable2, IMsRdpClientNonScriptable3
	{
		// Token: 0x06002A6C RID: 10860
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern MsRdpClient5NotSafeForScriptingClass();

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x06002A6E RID: 10862
		// (set) Token: 0x06002A6D RID: 10861
		[DispId(1)]
		public virtual extern string Server { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x06002A70 RID: 10864
		// (set) Token: 0x06002A6F RID: 10863
		[DispId(2)]
		public virtual extern string Domain { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x06002A72 RID: 10866
		// (set) Token: 0x06002A71 RID: 10865
		[DispId(3)]
		public virtual extern string UserName { [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x06002A74 RID: 10868
		// (set) Token: 0x06002A73 RID: 10867
		[DispId(4)]
		public virtual extern string DisconnectedText { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x06002A76 RID: 10870
		// (set) Token: 0x06002A75 RID: 10869
		[DispId(5)]
		public virtual extern string ConnectingText { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x06002A77 RID: 10871
		[DispId(6)]
		public virtual extern short Connected { [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x06002A79 RID: 10873
		// (set) Token: 0x06002A78 RID: 10872
		[DispId(12)]
		public virtual extern int DesktopWidth { [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x06002A7B RID: 10875
		// (set) Token: 0x06002A7A RID: 10874
		[DispId(13)]
		public virtual extern int DesktopHeight { [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x06002A7D RID: 10877
		// (set) Token: 0x06002A7C RID: 10876
		[DispId(16)]
		public virtual extern int StartConnected { [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x06002A7E RID: 10878
		[DispId(17)]
		public virtual extern int HorizontalScrollBarVisible { [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x06002A7F RID: 10879
		[DispId(18)]
		public virtual extern int VerticalScrollBarVisible { [DispId(18)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000B39 RID: 2873
		// (set) Token: 0x06002A80 RID: 10880
		[DispId(19)]
		public virtual extern string FullScreenTitle { [DispId(19)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x06002A81 RID: 10881
		[DispId(20)]
		public virtual extern int CipherStrength { [DispId(20)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x06002A82 RID: 10882
		[DispId(21)]
		public virtual extern string Version { [DispId(21)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x06002A83 RID: 10883
		[DispId(22)]
		public virtual extern int SecuredSettingsEnabled { [DispId(22)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x06002A84 RID: 10884
		[DispId(97)]
		public virtual extern IMsTscSecuredSettings SecuredSettings { [DispId(97)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x06002A85 RID: 10885
		[DispId(98)]
		public virtual extern IMsTscAdvancedSettings AdvancedSettings { [DispId(98)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x06002A86 RID: 10886
		[DispId(99)]
		public virtual extern IMsTscDebug Debugger { [DispId(99)] [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06002A87 RID: 10887
		[DispId(30)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Connect();

		// Token: 0x06002A88 RID: 10888
		[DispId(31)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Disconnect();

		// Token: 0x06002A89 RID: 10889
		[DispId(33)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06002A8A RID: 10890
		[DispId(34)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x06002A8C RID: 10892
		// (set) Token: 0x06002A8B RID: 10891
		[DispId(100)]
		public virtual extern int ColorDepth { [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x06002A8D RID: 10893
		[DispId(101)]
		public virtual extern IMsRdpClientAdvancedSettings AdvancedSettings2 { [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x06002A8E RID: 10894
		[DispId(102)]
		public virtual extern IMsRdpClientSecuredSettings SecuredSettings2 { [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x06002A8F RID: 10895
		[DispId(103)]
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode ExtendedDisconnectReason { [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x06002A91 RID: 10897
		// (set) Token: 0x06002A90 RID: 10896
		[DispId(104)]
		public virtual extern bool FullScreen { [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06002A92 RID: 10898
		[DispId(35)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06002A93 RID: 10899
		[DispId(36)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06002A94 RID: 10900
		[DispId(37)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus RequestClose();

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x06002A95 RID: 10901
		[DispId(200)]
		public virtual extern IMsRdpClientAdvancedSettings2 AdvancedSettings3 { [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x06002A97 RID: 10903
		// (set) Token: 0x06002A96 RID: 10902
		[DispId(201)]
		public virtual extern string ConnectedStatusText { [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x06002A98 RID: 10904
		[DispId(300)]
		public virtual extern IMsRdpClientAdvancedSettings3 AdvancedSettings4 { [DispId(300)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x06002A99 RID: 10905
		[DispId(400)]
		public virtual extern IMsRdpClientAdvancedSettings4 AdvancedSettings5 { [DispId(400)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x06002A9A RID: 10906
		[DispId(500)]
		public virtual extern IMsRdpClientTransportSettings TransportSettings { [DispId(500)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x06002A9B RID: 10907
		[DispId(502)]
		public virtual extern IMsRdpClientAdvancedSettings5 AdvancedSettings6 { [DispId(502)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06002A9C RID: 10908
		[DispId(503)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x06002A9D RID: 10909
		[DispId(504)]
		public virtual extern ITSRemoteProgram RemoteProgram { [DispId(504)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x06002A9E RID: 10910
		[DispId(505)]
		public virtual extern IMsRdpClientShell MsRdpClientShell { [DispId(505)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x06002AA0 RID: 10912
		// (set) Token: 0x06002A9F RID: 10911
		public virtual extern string IMsRdpClient4_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x06002AA2 RID: 10914
		// (set) Token: 0x06002AA1 RID: 10913
		public virtual extern string IMsRdpClient4_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x06002AA4 RID: 10916
		// (set) Token: 0x06002AA3 RID: 10915
		public virtual extern string IMsRdpClient4_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x06002AA6 RID: 10918
		// (set) Token: 0x06002AA5 RID: 10917
		public virtual extern string IMsRdpClient4_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x06002AA8 RID: 10920
		// (set) Token: 0x06002AA7 RID: 10919
		public virtual extern string IMsRdpClient4_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x06002AA9 RID: 10921
		public virtual extern short IMsRdpClient4_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x06002AAB RID: 10923
		// (set) Token: 0x06002AAA RID: 10922
		public virtual extern int IMsRdpClient4_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x06002AAD RID: 10925
		// (set) Token: 0x06002AAC RID: 10924
		public virtual extern int IMsRdpClient4_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x06002AAF RID: 10927
		// (set) Token: 0x06002AAE RID: 10926
		public virtual extern int IMsRdpClient4_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x06002AB0 RID: 10928
		public virtual extern int IMsRdpClient4_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x06002AB1 RID: 10929
		public virtual extern int IMsRdpClient4_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000B58 RID: 2904
		// (set) Token: 0x06002AB2 RID: 10930
		public virtual extern string IMsRdpClient4_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x06002AB3 RID: 10931
		public virtual extern int IMsRdpClient4_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x06002AB4 RID: 10932
		public virtual extern string IMsRdpClient4_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x06002AB5 RID: 10933
		public virtual extern int IMsRdpClient4_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x06002AB6 RID: 10934
		public virtual extern IMsTscSecuredSettings IMsRdpClient4_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x06002AB7 RID: 10935
		public virtual extern IMsTscAdvancedSettings IMsRdpClient4_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x06002AB8 RID: 10936
		public virtual extern IMsTscDebug IMsRdpClient4_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06002AB9 RID: 10937
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_Connect();

		// Token: 0x06002ABA RID: 10938
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_Disconnect();

		// Token: 0x06002ABB RID: 10939
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06002ABC RID: 10940
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x06002ABE RID: 10942
		// (set) Token: 0x06002ABD RID: 10941
		public virtual extern int IMsRdpClient4_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x06002ABF RID: 10943
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient4_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x06002AC0 RID: 10944
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient4_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x06002AC1 RID: 10945
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient4_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x06002AC3 RID: 10947
		// (set) Token: 0x06002AC2 RID: 10946
		public virtual extern bool IMsRdpClient4_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06002AC4 RID: 10948
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient4_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06002AC5 RID: 10949
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient4_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06002AC6 RID: 10950
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient4_RequestClose();

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x06002AC7 RID: 10951
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient4_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x06002AC9 RID: 10953
		// (set) Token: 0x06002AC8 RID: 10952
		public virtual extern string IMsRdpClient4_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x06002ACA RID: 10954
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient4_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x06002ACB RID: 10955
		public virtual extern IMsRdpClientAdvancedSettings4 IMsRdpClient4_AdvancedSettings5 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x06002ACD RID: 10957
		// (set) Token: 0x06002ACC RID: 10956
		public virtual extern string IMsRdpClient3_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x06002ACF RID: 10959
		// (set) Token: 0x06002ACE RID: 10958
		public virtual extern string IMsRdpClient3_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x06002AD1 RID: 10961
		// (set) Token: 0x06002AD0 RID: 10960
		public virtual extern string IMsRdpClient3_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x06002AD3 RID: 10963
		// (set) Token: 0x06002AD2 RID: 10962
		public virtual extern string IMsRdpClient3_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x06002AD5 RID: 10965
		// (set) Token: 0x06002AD4 RID: 10964
		public virtual extern string IMsRdpClient3_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x06002AD6 RID: 10966
		public virtual extern short IMsRdpClient3_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x06002AD8 RID: 10968
		// (set) Token: 0x06002AD7 RID: 10967
		public virtual extern int IMsRdpClient3_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x06002ADA RID: 10970
		// (set) Token: 0x06002AD9 RID: 10969
		public virtual extern int IMsRdpClient3_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x06002ADC RID: 10972
		// (set) Token: 0x06002ADB RID: 10971
		public virtual extern int IMsRdpClient3_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x06002ADD RID: 10973
		public virtual extern int IMsRdpClient3_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x06002ADE RID: 10974
		public virtual extern int IMsRdpClient3_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000B73 RID: 2931
		// (set) Token: 0x06002ADF RID: 10975
		public virtual extern string IMsRdpClient3_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x06002AE0 RID: 10976
		public virtual extern int IMsRdpClient3_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x06002AE1 RID: 10977
		public virtual extern string IMsRdpClient3_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x06002AE2 RID: 10978
		public virtual extern int IMsRdpClient3_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x06002AE3 RID: 10979
		public virtual extern IMsTscSecuredSettings IMsRdpClient3_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x06002AE4 RID: 10980
		public virtual extern IMsTscAdvancedSettings IMsRdpClient3_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x06002AE5 RID: 10981
		public virtual extern IMsTscDebug IMsRdpClient3_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06002AE6 RID: 10982
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_Connect();

		// Token: 0x06002AE7 RID: 10983
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_Disconnect();

		// Token: 0x06002AE8 RID: 10984
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06002AE9 RID: 10985
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x06002AEB RID: 10987
		// (set) Token: 0x06002AEA RID: 10986
		public virtual extern int IMsRdpClient3_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x06002AEC RID: 10988
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient3_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x06002AED RID: 10989
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient3_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x06002AEE RID: 10990
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient3_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x06002AF0 RID: 10992
		// (set) Token: 0x06002AEF RID: 10991
		public virtual extern bool IMsRdpClient3_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06002AF1 RID: 10993
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06002AF2 RID: 10994
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient3_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06002AF3 RID: 10995
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient3_RequestClose();

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x06002AF4 RID: 10996
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient3_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x06002AF6 RID: 10998
		// (set) Token: 0x06002AF5 RID: 10997
		public virtual extern string IMsRdpClient3_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x06002AF7 RID: 10999
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient3_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x06002AF9 RID: 11001
		// (set) Token: 0x06002AF8 RID: 11000
		public virtual extern string IMsRdpClient2_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x06002AFB RID: 11003
		// (set) Token: 0x06002AFA RID: 11002
		public virtual extern string IMsRdpClient2_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x06002AFD RID: 11005
		// (set) Token: 0x06002AFC RID: 11004
		public virtual extern string IMsRdpClient2_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x06002AFF RID: 11007
		// (set) Token: 0x06002AFE RID: 11006
		public virtual extern string IMsRdpClient2_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x06002B01 RID: 11009
		// (set) Token: 0x06002B00 RID: 11008
		public virtual extern string IMsRdpClient2_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x06002B02 RID: 11010
		public virtual extern short IMsRdpClient2_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x06002B04 RID: 11012
		// (set) Token: 0x06002B03 RID: 11011
		public virtual extern int IMsRdpClient2_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x06002B06 RID: 11014
		// (set) Token: 0x06002B05 RID: 11013
		public virtual extern int IMsRdpClient2_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x06002B08 RID: 11016
		// (set) Token: 0x06002B07 RID: 11015
		public virtual extern int IMsRdpClient2_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x06002B09 RID: 11017
		public virtual extern int IMsRdpClient2_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x06002B0A RID: 11018
		public virtual extern int IMsRdpClient2_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000B8D RID: 2957
		// (set) Token: 0x06002B0B RID: 11019
		public virtual extern string IMsRdpClient2_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x06002B0C RID: 11020
		public virtual extern int IMsRdpClient2_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x06002B0D RID: 11021
		public virtual extern string IMsRdpClient2_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x06002B0E RID: 11022
		public virtual extern int IMsRdpClient2_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x06002B0F RID: 11023
		public virtual extern IMsTscSecuredSettings IMsRdpClient2_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x06002B10 RID: 11024
		public virtual extern IMsTscAdvancedSettings IMsRdpClient2_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x06002B11 RID: 11025
		public virtual extern IMsTscDebug IMsRdpClient2_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06002B12 RID: 11026
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_Connect();

		// Token: 0x06002B13 RID: 11027
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_Disconnect();

		// Token: 0x06002B14 RID: 11028
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06002B15 RID: 11029
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x06002B17 RID: 11031
		// (set) Token: 0x06002B16 RID: 11030
		public virtual extern int IMsRdpClient2_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x06002B18 RID: 11032
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient2_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x06002B19 RID: 11033
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient2_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x06002B1A RID: 11034
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient2_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x06002B1C RID: 11036
		// (set) Token: 0x06002B1B RID: 11035
		public virtual extern bool IMsRdpClient2_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06002B1D RID: 11037
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06002B1E RID: 11038
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient2_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06002B1F RID: 11039
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient2_RequestClose();

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x06002B20 RID: 11040
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient2_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x06002B22 RID: 11042
		// (set) Token: 0x06002B21 RID: 11041
		public virtual extern string IMsRdpClient2_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x06002B24 RID: 11044
		// (set) Token: 0x06002B23 RID: 11043
		public virtual extern string IMsRdpClient_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x06002B26 RID: 11046
		// (set) Token: 0x06002B25 RID: 11045
		public virtual extern string IMsRdpClient_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x06002B28 RID: 11048
		// (set) Token: 0x06002B27 RID: 11047
		public virtual extern string IMsRdpClient_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x06002B2A RID: 11050
		// (set) Token: 0x06002B29 RID: 11049
		public virtual extern string IMsRdpClient_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x06002B2C RID: 11052
		// (set) Token: 0x06002B2B RID: 11051
		public virtual extern string IMsRdpClient_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x06002B2D RID: 11053
		public virtual extern short IMsRdpClient_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x06002B2F RID: 11055
		// (set) Token: 0x06002B2E RID: 11054
		public virtual extern int IMsRdpClient_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x06002B31 RID: 11057
		// (set) Token: 0x06002B30 RID: 11056
		public virtual extern int IMsRdpClient_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x06002B33 RID: 11059
		// (set) Token: 0x06002B32 RID: 11058
		public virtual extern int IMsRdpClient_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x06002B34 RID: 11060
		public virtual extern int IMsRdpClient_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x06002B35 RID: 11061
		public virtual extern int IMsRdpClient_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000BA6 RID: 2982
		// (set) Token: 0x06002B36 RID: 11062
		public virtual extern string IMsRdpClient_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x06002B37 RID: 11063
		public virtual extern int IMsRdpClient_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x06002B38 RID: 11064
		public virtual extern string IMsRdpClient_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x06002B39 RID: 11065
		public virtual extern int IMsRdpClient_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x06002B3A RID: 11066
		public virtual extern IMsTscSecuredSettings IMsRdpClient_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x06002B3B RID: 11067
		public virtual extern IMsTscAdvancedSettings IMsRdpClient_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x06002B3C RID: 11068
		public virtual extern IMsTscDebug IMsRdpClient_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06002B3D RID: 11069
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_Connect();

		// Token: 0x06002B3E RID: 11070
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_Disconnect();

		// Token: 0x06002B3F RID: 11071
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06002B40 RID: 11072
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x06002B42 RID: 11074
		// (set) Token: 0x06002B41 RID: 11073
		public virtual extern int IMsRdpClient_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x06002B43 RID: 11075
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x06002B44 RID: 11076
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x06002B45 RID: 11077
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x06002B47 RID: 11079
		// (set) Token: 0x06002B46 RID: 11078
		public virtual extern bool IMsRdpClient_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06002B48 RID: 11080
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06002B49 RID: 11081
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06002B4A RID: 11082
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient_RequestClose();

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x06002B4C RID: 11084
		// (set) Token: 0x06002B4B RID: 11083
		public virtual extern string IMsTscAx_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x06002B4E RID: 11086
		// (set) Token: 0x06002B4D RID: 11085
		public virtual extern string IMsTscAx_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x06002B50 RID: 11088
		// (set) Token: 0x06002B4F RID: 11087
		public virtual extern string IMsTscAx_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x06002B52 RID: 11090
		// (set) Token: 0x06002B51 RID: 11089
		public virtual extern string IMsTscAx_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x06002B54 RID: 11092
		// (set) Token: 0x06002B53 RID: 11091
		public virtual extern string IMsTscAx_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x06002B55 RID: 11093
		public virtual extern short IMsTscAx_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x06002B57 RID: 11095
		// (set) Token: 0x06002B56 RID: 11094
		public virtual extern int IMsTscAx_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x06002B59 RID: 11097
		// (set) Token: 0x06002B58 RID: 11096
		public virtual extern int IMsTscAx_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x06002B5B RID: 11099
		// (set) Token: 0x06002B5A RID: 11098
		public virtual extern int IMsTscAx_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x06002B5C RID: 11100
		public virtual extern int IMsTscAx_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x06002B5D RID: 11101
		public virtual extern int IMsTscAx_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000BBD RID: 3005
		// (set) Token: 0x06002B5E RID: 11102
		public virtual extern string IMsTscAx_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x06002B5F RID: 11103
		public virtual extern int IMsTscAx_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x06002B60 RID: 11104
		public virtual extern string IMsTscAx_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x06002B61 RID: 11105
		public virtual extern int IMsTscAx_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x06002B62 RID: 11106
		public virtual extern IMsTscSecuredSettings IMsTscAx_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x06002B63 RID: 11107
		public virtual extern IMsTscAdvancedSettings IMsTscAx_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x06002B64 RID: 11108
		public virtual extern IMsTscDebug IMsTscAx_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06002B65 RID: 11109
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_Connect();

		// Token: 0x06002B66 RID: 11110
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_Disconnect();

		// Token: 0x06002B67 RID: 11111
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06002B68 RID: 11112
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17000BC4 RID: 3012
		// (set) Token: 0x06002B69 RID: 11113
		public virtual extern string ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x06002B6B RID: 11115
		// (set) Token: 0x06002B6A RID: 11114
		public virtual extern string PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x06002B6D RID: 11117
		// (set) Token: 0x06002B6C RID: 11116
		public virtual extern string PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x06002B6F RID: 11119
		// (set) Token: 0x06002B6E RID: 11118
		public virtual extern string BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x06002B71 RID: 11121
		// (set) Token: 0x06002B70 RID: 11120
		public virtual extern string BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06002B72 RID: 11122
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void ResetPassword();

		// Token: 0x17000BC9 RID: 3017
		// (set) Token: 0x06002B73 RID: 11123
		public virtual extern string IMsRdpClientNonScriptable_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x06002B75 RID: 11125
		// (set) Token: 0x06002B74 RID: 11124
		public virtual extern string IMsRdpClientNonScriptable_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x06002B77 RID: 11127
		// (set) Token: 0x06002B76 RID: 11126
		public virtual extern string IMsRdpClientNonScriptable_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x06002B79 RID: 11129
		// (set) Token: 0x06002B78 RID: 11128
		public virtual extern string IMsRdpClientNonScriptable_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x06002B7B RID: 11131
		// (set) Token: 0x06002B7A RID: 11130
		public virtual extern string IMsRdpClientNonScriptable_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06002B7C RID: 11132
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable_ResetPassword();

		// Token: 0x06002B7D RID: 11133
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06002B7E RID: 11134
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x17000BCE RID: 3022
		// (set) Token: 0x06002B7F RID: 11135
		public virtual extern string IMsRdpClientNonScriptable2_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x06002B81 RID: 11137
		// (set) Token: 0x06002B80 RID: 11136
		public virtual extern string IMsRdpClientNonScriptable2_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x06002B83 RID: 11139
		// (set) Token: 0x06002B82 RID: 11138
		public virtual extern string IMsRdpClientNonScriptable2_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x06002B85 RID: 11141
		// (set) Token: 0x06002B84 RID: 11140
		public virtual extern string IMsRdpClientNonScriptable2_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x06002B87 RID: 11143
		// (set) Token: 0x06002B86 RID: 11142
		public virtual extern string IMsRdpClientNonScriptable2_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06002B88 RID: 11144
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable2_ResetPassword();

		// Token: 0x06002B89 RID: 11145
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable2_NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06002B8A RID: 11146
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable2_SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x06002B8C RID: 11148
		// (set) Token: 0x06002B8B RID: 11147
		[ComAliasName("MSTSCLib.wireHWND")]
		public virtual extern IntPtr UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x17000BD4 RID: 3028
		// (set) Token: 0x06002B8D RID: 11149
		public virtual extern string IMsRdpClientNonScriptable3_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x06002B8F RID: 11151
		// (set) Token: 0x06002B8E RID: 11150
		public virtual extern string IMsRdpClientNonScriptable3_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x06002B91 RID: 11153
		// (set) Token: 0x06002B90 RID: 11152
		public virtual extern string IMsRdpClientNonScriptable3_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x06002B93 RID: 11155
		// (set) Token: 0x06002B92 RID: 11154
		public virtual extern string IMsRdpClientNonScriptable3_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x06002B95 RID: 11157
		// (set) Token: 0x06002B94 RID: 11156
		public virtual extern string IMsRdpClientNonScriptable3_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06002B96 RID: 11158
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable3_ResetPassword();

		// Token: 0x06002B97 RID: 11159
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable3_NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06002B98 RID: 11160
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable3_SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x06002B9A RID: 11162
		// (set) Token: 0x06002B99 RID: 11161
		[ComAliasName("MSTSCLib.wireHWND")]
		public virtual extern IntPtr IMsRdpClientNonScriptable3_UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x06002B9C RID: 11164
		// (set) Token: 0x06002B9B RID: 11163
		public virtual extern bool ShowRedirectionWarningDialog { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x06002B9E RID: 11166
		// (set) Token: 0x06002B9D RID: 11165
		public virtual extern bool PromptForCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x06002BA0 RID: 11168
		// (set) Token: 0x06002B9F RID: 11167
		public virtual extern bool NegotiateSecurityLayer { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x06002BA2 RID: 11170
		// (set) Token: 0x06002BA1 RID: 11169
		public virtual extern bool EnableCredSspSupport { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x06002BA4 RID: 11172
		// (set) Token: 0x06002BA3 RID: 11171
		public virtual extern bool RedirectDynamicDrives { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x06002BA6 RID: 11174
		// (set) Token: 0x06002BA5 RID: 11173
		public virtual extern bool RedirectDynamicDevices { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x06002BA7 RID: 11175
		public virtual extern IMsRdpDeviceCollection DeviceCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x06002BA8 RID: 11176
		public virtual extern IMsRdpDriveCollection DriveCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x06002BAA RID: 11178
		// (set) Token: 0x06002BA9 RID: 11177
		public virtual extern bool WarnAboutSendingCredentials { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x06002BAC RID: 11180
		// (set) Token: 0x06002BAB RID: 11179
		public virtual extern bool WarnAboutClipboardRedirection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x06002BAE RID: 11182
		// (set) Token: 0x06002BAD RID: 11181
		public virtual extern string ConnectionBarText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x140004F7 RID: 1271
		// (add) Token: 0x06002BAF RID: 11183
		// (remove) Token: 0x06002BB0 RID: 11184
		public virtual extern event IMsTscAxEvents_OnConnectingEventHandler OnConnecting;

		// Token: 0x140004F8 RID: 1272
		// (add) Token: 0x06002BB1 RID: 11185
		// (remove) Token: 0x06002BB2 RID: 11186
		public virtual extern event IMsTscAxEvents_OnConnectedEventHandler OnConnected;

		// Token: 0x140004F9 RID: 1273
		// (add) Token: 0x06002BB3 RID: 11187
		// (remove) Token: 0x06002BB4 RID: 11188
		public virtual extern event IMsTscAxEvents_OnLoginCompleteEventHandler OnLoginComplete;

		// Token: 0x140004FA RID: 1274
		// (add) Token: 0x06002BB5 RID: 11189
		// (remove) Token: 0x06002BB6 RID: 11190
		public virtual extern event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x140004FB RID: 1275
		// (add) Token: 0x06002BB7 RID: 11191
		// (remove) Token: 0x06002BB8 RID: 11192
		public virtual extern event IMsTscAxEvents_OnEnterFullScreenModeEventHandler OnEnterFullScreenMode;

		// Token: 0x140004FC RID: 1276
		// (add) Token: 0x06002BB9 RID: 11193
		// (remove) Token: 0x06002BBA RID: 11194
		public virtual extern event IMsTscAxEvents_OnLeaveFullScreenModeEventHandler OnLeaveFullScreenMode;

		// Token: 0x140004FD RID: 1277
		// (add) Token: 0x06002BBB RID: 11195
		// (remove) Token: 0x06002BBC RID: 11196
		public virtual extern event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x140004FE RID: 1278
		// (add) Token: 0x06002BBD RID: 11197
		// (remove) Token: 0x06002BBE RID: 11198
		public virtual extern event IMsTscAxEvents_OnRequestGoFullScreenEventHandler OnRequestGoFullScreen;

		// Token: 0x140004FF RID: 1279
		// (add) Token: 0x06002BBF RID: 11199
		// (remove) Token: 0x06002BC0 RID: 11200
		public virtual extern event IMsTscAxEvents_OnRequestLeaveFullScreenEventHandler OnRequestLeaveFullScreen;

		// Token: 0x14000500 RID: 1280
		// (add) Token: 0x06002BC1 RID: 11201
		// (remove) Token: 0x06002BC2 RID: 11202
		public virtual extern event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x14000501 RID: 1281
		// (add) Token: 0x06002BC3 RID: 11203
		// (remove) Token: 0x06002BC4 RID: 11204
		public virtual extern event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x14000502 RID: 1282
		// (add) Token: 0x06002BC5 RID: 11205
		// (remove) Token: 0x06002BC6 RID: 11206
		public virtual extern event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x14000503 RID: 1283
		// (add) Token: 0x06002BC7 RID: 11207
		// (remove) Token: 0x06002BC8 RID: 11208
		public virtual extern event IMsTscAxEvents_OnIdleTimeoutNotificationEventHandler OnIdleTimeoutNotification;

		// Token: 0x14000504 RID: 1284
		// (add) Token: 0x06002BC9 RID: 11209
		// (remove) Token: 0x06002BCA RID: 11210
		public virtual extern event IMsTscAxEvents_OnRequestContainerMinimizeEventHandler OnRequestContainerMinimize;

		// Token: 0x14000505 RID: 1285
		// (add) Token: 0x06002BCB RID: 11211
		// (remove) Token: 0x06002BCC RID: 11212
		public virtual extern event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x14000506 RID: 1286
		// (add) Token: 0x06002BCD RID: 11213
		// (remove) Token: 0x06002BCE RID: 11214
		public virtual extern event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x14000507 RID: 1287
		// (add) Token: 0x06002BCF RID: 11215
		// (remove) Token: 0x06002BD0 RID: 11216
		public virtual extern event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x14000508 RID: 1288
		// (add) Token: 0x06002BD1 RID: 11217
		// (remove) Token: 0x06002BD2 RID: 11218
		public virtual extern event IMsTscAxEvents_OnAuthenticationWarningDisplayedEventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x14000509 RID: 1289
		// (add) Token: 0x06002BD3 RID: 11219
		// (remove) Token: 0x06002BD4 RID: 11220
		public virtual extern event IMsTscAxEvents_OnAuthenticationWarningDismissedEventHandler OnAuthenticationWarningDismissed;

		// Token: 0x1400050A RID: 1290
		// (add) Token: 0x06002BD5 RID: 11221
		// (remove) Token: 0x06002BD6 RID: 11222
		public virtual extern event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x1400050B RID: 1291
		// (add) Token: 0x06002BD7 RID: 11223
		// (remove) Token: 0x06002BD8 RID: 11224
		public virtual extern event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x1400050C RID: 1292
		// (add) Token: 0x06002BD9 RID: 11225
		// (remove) Token: 0x06002BDA RID: 11226
		public virtual extern event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x1400050D RID: 1293
		// (add) Token: 0x06002BDB RID: 11227
		// (remove) Token: 0x06002BDC RID: 11228
		public virtual extern event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x1400050E RID: 1294
		// (add) Token: 0x06002BDD RID: 11229
		// (remove) Token: 0x06002BDE RID: 11230
		public virtual extern event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x1400050F RID: 1295
		// (add) Token: 0x06002BDF RID: 11231
		// (remove) Token: 0x06002BE0 RID: 11232
		public virtual extern event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x14000510 RID: 1296
		// (add) Token: 0x06002BE1 RID: 11233
		// (remove) Token: 0x06002BE2 RID: 11234
		public virtual extern event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x14000511 RID: 1297
		// (add) Token: 0x06002BE3 RID: 11235
		// (remove) Token: 0x06002BE4 RID: 11236
		public virtual extern event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x14000512 RID: 1298
		// (add) Token: 0x06002BE5 RID: 11237
		// (remove) Token: 0x06002BE6 RID: 11238
		public virtual extern event IMsTscAxEvents_OnConnectionBarPullDownEventHandler OnConnectionBarPullDown;

		// Token: 0x14000513 RID: 1299
		// (add) Token: 0x06002BE7 RID: 11239
		// (remove) Token: 0x06002BE8 RID: 11240
		public virtual extern event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x14000514 RID: 1300
		// (add) Token: 0x06002BE9 RID: 11241
		// (remove) Token: 0x06002BEA RID: 11242
		public virtual extern event IMsTscAxEvents_OnDevicesButtonPressedEventHandler OnDevicesButtonPressed;

		// Token: 0x14000515 RID: 1301
		// (add) Token: 0x06002BEB RID: 11243
		// (remove) Token: 0x06002BEC RID: 11244
		public virtual extern event IMsTscAxEvents_OnAutoReconnectedEventHandler OnAutoReconnected;

		// Token: 0x14000516 RID: 1302
		// (add) Token: 0x06002BED RID: 11245
		// (remove) Token: 0x06002BEE RID: 11246
		public virtual extern event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;
	}
}
