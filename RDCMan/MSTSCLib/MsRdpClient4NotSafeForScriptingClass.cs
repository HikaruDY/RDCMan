using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001AA RID: 426
	[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0")]
	[Guid("6AE29350-321B-42BE-BBE5-12FB5270C0DE")]
	[TypeLibType(34)]
	[ClassInterface(0)]
	[ComVisible(true)]
	[ComImport]
	public class MsRdpClient4NotSafeForScriptingClass : IMsRdpClient4, MsRdpClient4NotSafeForScripting, IMsTscAxEvents_Event, IMsRdpClient3, IMsRdpClient2, IMsRdpClient, IMsTscAx, IMsTscAx_Redist, IMsTscNonScriptable, IMsRdpClientNonScriptable, IMsRdpClientNonScriptable2
	{
		// Token: 0x06002616 RID: 9750
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern MsRdpClient4NotSafeForScriptingClass();

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06002618 RID: 9752
		// (set) Token: 0x06002617 RID: 9751
		[DispId(1)]
		public virtual extern string Server { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x0600261A RID: 9754
		// (set) Token: 0x06002619 RID: 9753
		[DispId(2)]
		public virtual extern string Domain { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x0600261C RID: 9756
		// (set) Token: 0x0600261B RID: 9755
		[DispId(3)]
		public virtual extern string UserName { [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x0600261E RID: 9758
		// (set) Token: 0x0600261D RID: 9757
		[DispId(4)]
		public virtual extern string DisconnectedText { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06002620 RID: 9760
		// (set) Token: 0x0600261F RID: 9759
		[DispId(5)]
		public virtual extern string ConnectingText { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06002621 RID: 9761
		[DispId(6)]
		public virtual extern short Connected { [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06002623 RID: 9763
		// (set) Token: 0x06002622 RID: 9762
		[DispId(12)]
		public virtual extern int DesktopWidth { [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06002625 RID: 9765
		// (set) Token: 0x06002624 RID: 9764
		[DispId(13)]
		public virtual extern int DesktopHeight { [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06002627 RID: 9767
		// (set) Token: 0x06002626 RID: 9766
		[DispId(16)]
		public virtual extern int StartConnected { [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06002628 RID: 9768
		[DispId(17)]
		public virtual extern int HorizontalScrollBarVisible { [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06002629 RID: 9769
		[DispId(18)]
		public virtual extern int VerticalScrollBarVisible { [DispId(18)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000938 RID: 2360
		// (set) Token: 0x0600262A RID: 9770
		[DispId(19)]
		public virtual extern string FullScreenTitle { [DispId(19)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x0600262B RID: 9771
		[DispId(20)]
		public virtual extern int CipherStrength { [DispId(20)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x0600262C RID: 9772
		[DispId(21)]
		public virtual extern string Version { [DispId(21)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x0600262D RID: 9773
		[DispId(22)]
		public virtual extern int SecuredSettingsEnabled { [DispId(22)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x0600262E RID: 9774
		[DispId(97)]
		public virtual extern IMsTscSecuredSettings SecuredSettings { [DispId(97)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x0600262F RID: 9775
		[DispId(98)]
		public virtual extern IMsTscAdvancedSettings AdvancedSettings { [DispId(98)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06002630 RID: 9776
		[DispId(99)]
		public virtual extern IMsTscDebug Debugger { [TypeLibFunc(64)] [DispId(99)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06002631 RID: 9777
		[DispId(30)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Connect();

		// Token: 0x06002632 RID: 9778
		[DispId(31)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Disconnect();

		// Token: 0x06002633 RID: 9779
		[DispId(33)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06002634 RID: 9780
		[DispId(34)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06002636 RID: 9782
		// (set) Token: 0x06002635 RID: 9781
		[DispId(100)]
		public virtual extern int ColorDepth { [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06002637 RID: 9783
		[DispId(101)]
		public virtual extern IMsRdpClientAdvancedSettings AdvancedSettings2 { [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06002638 RID: 9784
		[DispId(102)]
		public virtual extern IMsRdpClientSecuredSettings SecuredSettings2 { [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06002639 RID: 9785
		[DispId(103)]
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode ExtendedDisconnectReason { [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x0600263B RID: 9787
		// (set) Token: 0x0600263A RID: 9786
		[DispId(104)]
		public virtual extern bool FullScreen { [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x0600263C RID: 9788
		[DispId(35)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x0600263D RID: 9789
		[DispId(36)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x0600263E RID: 9790
		[DispId(37)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus RequestClose();

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x0600263F RID: 9791
		[DispId(200)]
		public virtual extern IMsRdpClientAdvancedSettings2 AdvancedSettings3 { [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06002641 RID: 9793
		// (set) Token: 0x06002640 RID: 9792
		[DispId(201)]
		public virtual extern string ConnectedStatusText { [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06002642 RID: 9794
		[DispId(300)]
		public virtual extern IMsRdpClientAdvancedSettings3 AdvancedSettings4 { [DispId(300)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06002643 RID: 9795
		[DispId(400)]
		public virtual extern IMsRdpClientAdvancedSettings4 AdvancedSettings5 { [DispId(400)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06002645 RID: 9797
		// (set) Token: 0x06002644 RID: 9796
		public virtual extern string IMsRdpClient3_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06002647 RID: 9799
		// (set) Token: 0x06002646 RID: 9798
		public virtual extern string IMsRdpClient3_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06002649 RID: 9801
		// (set) Token: 0x06002648 RID: 9800
		public virtual extern string IMsRdpClient3_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x0600264B RID: 9803
		// (set) Token: 0x0600264A RID: 9802
		public virtual extern string IMsRdpClient3_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x0600264D RID: 9805
		// (set) Token: 0x0600264C RID: 9804
		public virtual extern string IMsRdpClient3_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x0600264E RID: 9806
		public virtual extern short IMsRdpClient3_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06002650 RID: 9808
		// (set) Token: 0x0600264F RID: 9807
		public virtual extern int IMsRdpClient3_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06002652 RID: 9810
		// (set) Token: 0x06002651 RID: 9809
		public virtual extern int IMsRdpClient3_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06002654 RID: 9812
		// (set) Token: 0x06002653 RID: 9811
		public virtual extern int IMsRdpClient3_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06002655 RID: 9813
		public virtual extern int IMsRdpClient3_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06002656 RID: 9814
		public virtual extern int IMsRdpClient3_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000953 RID: 2387
		// (set) Token: 0x06002657 RID: 9815
		public virtual extern string IMsRdpClient3_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06002658 RID: 9816
		public virtual extern int IMsRdpClient3_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06002659 RID: 9817
		public virtual extern string IMsRdpClient3_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x0600265A RID: 9818
		public virtual extern int IMsRdpClient3_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x0600265B RID: 9819
		public virtual extern IMsTscSecuredSettings IMsRdpClient3_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x0600265C RID: 9820
		public virtual extern IMsTscAdvancedSettings IMsRdpClient3_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x0600265D RID: 9821
		public virtual extern IMsTscDebug IMsRdpClient3_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600265E RID: 9822
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_Connect();

		// Token: 0x0600265F RID: 9823
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_Disconnect();

		// Token: 0x06002660 RID: 9824
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06002661 RID: 9825
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06002663 RID: 9827
		// (set) Token: 0x06002662 RID: 9826
		public virtual extern int IMsRdpClient3_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x06002664 RID: 9828
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient3_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06002665 RID: 9829
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient3_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06002666 RID: 9830
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient3_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06002668 RID: 9832
		// (set) Token: 0x06002667 RID: 9831
		public virtual extern bool IMsRdpClient3_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06002669 RID: 9833
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient3_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x0600266A RID: 9834
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient3_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x0600266B RID: 9835
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient3_RequestClose();

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x0600266C RID: 9836
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient3_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x0600266E RID: 9838
		// (set) Token: 0x0600266D RID: 9837
		public virtual extern string IMsRdpClient3_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x0600266F RID: 9839
		public virtual extern IMsRdpClientAdvancedSettings3 IMsRdpClient3_AdvancedSettings4 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06002671 RID: 9841
		// (set) Token: 0x06002670 RID: 9840
		public virtual extern string IMsRdpClient2_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06002673 RID: 9843
		// (set) Token: 0x06002672 RID: 9842
		public virtual extern string IMsRdpClient2_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06002675 RID: 9845
		// (set) Token: 0x06002674 RID: 9844
		public virtual extern string IMsRdpClient2_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06002677 RID: 9847
		// (set) Token: 0x06002676 RID: 9846
		public virtual extern string IMsRdpClient2_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06002679 RID: 9849
		// (set) Token: 0x06002678 RID: 9848
		public virtual extern string IMsRdpClient2_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x0600267A RID: 9850
		public virtual extern short IMsRdpClient2_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x0600267C RID: 9852
		// (set) Token: 0x0600267B RID: 9851
		public virtual extern int IMsRdpClient2_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x0600267E RID: 9854
		// (set) Token: 0x0600267D RID: 9853
		public virtual extern int IMsRdpClient2_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x06002680 RID: 9856
		// (set) Token: 0x0600267F RID: 9855
		public virtual extern int IMsRdpClient2_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06002681 RID: 9857
		public virtual extern int IMsRdpClient2_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06002682 RID: 9858
		public virtual extern int IMsRdpClient2_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700096D RID: 2413
		// (set) Token: 0x06002683 RID: 9859
		public virtual extern string IMsRdpClient2_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x06002684 RID: 9860
		public virtual extern int IMsRdpClient2_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x06002685 RID: 9861
		public virtual extern string IMsRdpClient2_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x06002686 RID: 9862
		public virtual extern int IMsRdpClient2_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06002687 RID: 9863
		public virtual extern IMsTscSecuredSettings IMsRdpClient2_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06002688 RID: 9864
		public virtual extern IMsTscAdvancedSettings IMsRdpClient2_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06002689 RID: 9865
		public virtual extern IMsTscDebug IMsRdpClient2_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600268A RID: 9866
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_Connect();

		// Token: 0x0600268B RID: 9867
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_Disconnect();

		// Token: 0x0600268C RID: 9868
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x0600268D RID: 9869
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x0600268F RID: 9871
		// (set) Token: 0x0600268E RID: 9870
		public virtual extern int IMsRdpClient2_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x06002690 RID: 9872
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient2_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x06002691 RID: 9873
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient2_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x06002692 RID: 9874
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient2_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x06002694 RID: 9876
		// (set) Token: 0x06002693 RID: 9875
		public virtual extern bool IMsRdpClient2_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06002695 RID: 9877
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient2_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x06002696 RID: 9878
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient2_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x06002697 RID: 9879
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient2_RequestClose();

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x06002698 RID: 9880
		public virtual extern IMsRdpClientAdvancedSettings2 IMsRdpClient2_AdvancedSettings3 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x0600269A RID: 9882
		// (set) Token: 0x06002699 RID: 9881
		public virtual extern string IMsRdpClient2_ConnectedStatusText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x0600269C RID: 9884
		// (set) Token: 0x0600269B RID: 9883
		public virtual extern string IMsRdpClient_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x0600269E RID: 9886
		// (set) Token: 0x0600269D RID: 9885
		public virtual extern string IMsRdpClient_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x060026A0 RID: 9888
		// (set) Token: 0x0600269F RID: 9887
		public virtual extern string IMsRdpClient_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x060026A2 RID: 9890
		// (set) Token: 0x060026A1 RID: 9889
		public virtual extern string IMsRdpClient_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x060026A4 RID: 9892
		// (set) Token: 0x060026A3 RID: 9891
		public virtual extern string IMsRdpClient_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x060026A5 RID: 9893
		public virtual extern short IMsRdpClient_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x060026A7 RID: 9895
		// (set) Token: 0x060026A6 RID: 9894
		public virtual extern int IMsRdpClient_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x060026A9 RID: 9897
		// (set) Token: 0x060026A8 RID: 9896
		public virtual extern int IMsRdpClient_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x060026AB RID: 9899
		// (set) Token: 0x060026AA RID: 9898
		public virtual extern int IMsRdpClient_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x060026AC RID: 9900
		public virtual extern int IMsRdpClient_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x060026AD RID: 9901
		public virtual extern int IMsRdpClient_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000986 RID: 2438
		// (set) Token: 0x060026AE RID: 9902
		public virtual extern string IMsRdpClient_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x060026AF RID: 9903
		public virtual extern int IMsRdpClient_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x060026B0 RID: 9904
		public virtual extern string IMsRdpClient_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x060026B1 RID: 9905
		public virtual extern int IMsRdpClient_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x060026B2 RID: 9906
		public virtual extern IMsTscSecuredSettings IMsRdpClient_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x060026B3 RID: 9907
		public virtual extern IMsTscAdvancedSettings IMsRdpClient_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x060026B4 RID: 9908
		public virtual extern IMsTscDebug IMsRdpClient_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060026B5 RID: 9909
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_Connect();

		// Token: 0x060026B6 RID: 9910
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_Disconnect();

		// Token: 0x060026B7 RID: 9911
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x060026B8 RID: 9912
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x060026BA RID: 9914
		// (set) Token: 0x060026B9 RID: 9913
		public virtual extern int IMsRdpClient_ColorDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x060026BB RID: 9915
		public virtual extern IMsRdpClientAdvancedSettings IMsRdpClient_AdvancedSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x060026BC RID: 9916
		public virtual extern IMsRdpClientSecuredSettings IMsRdpClient_SecuredSettings2 { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x060026BD RID: 9917
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode IMsRdpClient_ExtendedDisconnectReason { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x060026BF RID: 9919
		// (set) Token: 0x060026BE RID: 9918
		public virtual extern bool IMsRdpClient_FullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x060026C0 RID: 9920
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClient_SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		// Token: 0x060026C1 RID: 9921
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IMsRdpClient_GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		// Token: 0x060026C2 RID: 9922
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus IMsRdpClient_RequestClose();

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x060026C4 RID: 9924
		// (set) Token: 0x060026C3 RID: 9923
		public virtual extern string IMsTscAx_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x060026C6 RID: 9926
		// (set) Token: 0x060026C5 RID: 9925
		public virtual extern string IMsTscAx_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x060026C8 RID: 9928
		// (set) Token: 0x060026C7 RID: 9927
		public virtual extern string IMsTscAx_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x060026CA RID: 9930
		// (set) Token: 0x060026C9 RID: 9929
		public virtual extern string IMsTscAx_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x060026CC RID: 9932
		// (set) Token: 0x060026CB RID: 9931
		public virtual extern string IMsTscAx_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x060026CD RID: 9933
		public virtual extern short IMsTscAx_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x060026CF RID: 9935
		// (set) Token: 0x060026CE RID: 9934
		public virtual extern int IMsTscAx_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x060026D1 RID: 9937
		// (set) Token: 0x060026D0 RID: 9936
		public virtual extern int IMsTscAx_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x060026D3 RID: 9939
		// (set) Token: 0x060026D2 RID: 9938
		public virtual extern int IMsTscAx_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x060026D4 RID: 9940
		public virtual extern int IMsTscAx_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x060026D5 RID: 9941
		public virtual extern int IMsTscAx_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700099D RID: 2461
		// (set) Token: 0x060026D6 RID: 9942
		public virtual extern string IMsTscAx_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x060026D7 RID: 9943
		public virtual extern int IMsTscAx_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x060026D8 RID: 9944
		public virtual extern string IMsTscAx_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x060026D9 RID: 9945
		public virtual extern int IMsTscAx_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x060026DA RID: 9946
		public virtual extern IMsTscSecuredSettings IMsTscAx_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x060026DB RID: 9947
		public virtual extern IMsTscAdvancedSettings IMsTscAx_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x060026DC RID: 9948
		public virtual extern IMsTscDebug IMsTscAx_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060026DD RID: 9949
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_Connect();

		// Token: 0x060026DE RID: 9950
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_Disconnect();

		// Token: 0x060026DF RID: 9951
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x060026E0 RID: 9952
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		// Token: 0x170009A4 RID: 2468
		// (set) Token: 0x060026E1 RID: 9953
		public virtual extern string ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x060026E3 RID: 9955
		// (set) Token: 0x060026E2 RID: 9954
		public virtual extern string PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x060026E5 RID: 9957
		// (set) Token: 0x060026E4 RID: 9956
		public virtual extern string PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x060026E7 RID: 9959
		// (set) Token: 0x060026E6 RID: 9958
		public virtual extern string BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x060026E9 RID: 9961
		// (set) Token: 0x060026E8 RID: 9960
		public virtual extern string BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x060026EA RID: 9962
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void ResetPassword();

		// Token: 0x170009A9 RID: 2473
		// (set) Token: 0x060026EB RID: 9963
		public virtual extern string IMsRdpClientNonScriptable_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x060026ED RID: 9965
		// (set) Token: 0x060026EC RID: 9964
		public virtual extern string IMsRdpClientNonScriptable_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x060026EF RID: 9967
		// (set) Token: 0x060026EE RID: 9966
		public virtual extern string IMsRdpClientNonScriptable_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x060026F1 RID: 9969
		// (set) Token: 0x060026F0 RID: 9968
		public virtual extern string IMsRdpClientNonScriptable_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x060026F3 RID: 9971
		// (set) Token: 0x060026F2 RID: 9970
		public virtual extern string IMsRdpClientNonScriptable_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x060026F4 RID: 9972
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable_ResetPassword();

		// Token: 0x060026F5 RID: 9973
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x060026F6 RID: 9974
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x170009AE RID: 2478
		// (set) Token: 0x060026F7 RID: 9975
		public virtual extern string IMsRdpClientNonScriptable2_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x060026F9 RID: 9977
		// (set) Token: 0x060026F8 RID: 9976
		public virtual extern string IMsRdpClientNonScriptable2_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x060026FB RID: 9979
		// (set) Token: 0x060026FA RID: 9978
		public virtual extern string IMsRdpClientNonScriptable2_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x060026FD RID: 9981
		// (set) Token: 0x060026FC RID: 9980
		public virtual extern string IMsRdpClientNonScriptable2_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x060026FF RID: 9983
		// (set) Token: 0x060026FE RID: 9982
		public virtual extern string IMsRdpClientNonScriptable2_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06002700 RID: 9984
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable2_ResetPassword();

		// Token: 0x06002701 RID: 9985
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable2_NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		// Token: 0x06002702 RID: 9986
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable2_SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06002704 RID: 9988
		// (set) Token: 0x06002703 RID: 9987
		[ComAliasName("MSTSCLib.wireHWND")]
		public virtual extern IntPtr UIParentWindowHandle { [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: ComAliasName("MSTSCLib.wireHWND")] [param: In] set; }

		// Token: 0x14000497 RID: 1175
		// (add) Token: 0x06002705 RID: 9989
		// (remove) Token: 0x06002706 RID: 9990
		public virtual extern event IMsTscAxEvents_OnConnectingEventHandler OnConnecting;

		// Token: 0x14000498 RID: 1176
		// (add) Token: 0x06002707 RID: 9991
		// (remove) Token: 0x06002708 RID: 9992
		public virtual extern event IMsTscAxEvents_OnConnectedEventHandler OnConnected;

		// Token: 0x14000499 RID: 1177
		// (add) Token: 0x06002709 RID: 9993
		// (remove) Token: 0x0600270A RID: 9994
		public virtual extern event IMsTscAxEvents_OnLoginCompleteEventHandler OnLoginComplete;

		// Token: 0x1400049A RID: 1178
		// (add) Token: 0x0600270B RID: 9995
		// (remove) Token: 0x0600270C RID: 9996
		public virtual extern event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x1400049B RID: 1179
		// (add) Token: 0x0600270D RID: 9997
		// (remove) Token: 0x0600270E RID: 9998
		public virtual extern event IMsTscAxEvents_OnEnterFullScreenModeEventHandler OnEnterFullScreenMode;

		// Token: 0x1400049C RID: 1180
		// (add) Token: 0x0600270F RID: 9999
		// (remove) Token: 0x06002710 RID: 10000
		public virtual extern event IMsTscAxEvents_OnLeaveFullScreenModeEventHandler OnLeaveFullScreenMode;

		// Token: 0x1400049D RID: 1181
		// (add) Token: 0x06002711 RID: 10001
		// (remove) Token: 0x06002712 RID: 10002
		public virtual extern event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x1400049E RID: 1182
		// (add) Token: 0x06002713 RID: 10003
		// (remove) Token: 0x06002714 RID: 10004
		public virtual extern event IMsTscAxEvents_OnRequestGoFullScreenEventHandler OnRequestGoFullScreen;

		// Token: 0x1400049F RID: 1183
		// (add) Token: 0x06002715 RID: 10005
		// (remove) Token: 0x06002716 RID: 10006
		public virtual extern event IMsTscAxEvents_OnRequestLeaveFullScreenEventHandler OnRequestLeaveFullScreen;

		// Token: 0x140004A0 RID: 1184
		// (add) Token: 0x06002717 RID: 10007
		// (remove) Token: 0x06002718 RID: 10008
		public virtual extern event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x140004A1 RID: 1185
		// (add) Token: 0x06002719 RID: 10009
		// (remove) Token: 0x0600271A RID: 10010
		public virtual extern event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x140004A2 RID: 1186
		// (add) Token: 0x0600271B RID: 10011
		// (remove) Token: 0x0600271C RID: 10012
		public virtual extern event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x140004A3 RID: 1187
		// (add) Token: 0x0600271D RID: 10013
		// (remove) Token: 0x0600271E RID: 10014
		public virtual extern event IMsTscAxEvents_OnIdleTimeoutNotificationEventHandler OnIdleTimeoutNotification;

		// Token: 0x140004A4 RID: 1188
		// (add) Token: 0x0600271F RID: 10015
		// (remove) Token: 0x06002720 RID: 10016
		public virtual extern event IMsTscAxEvents_OnRequestContainerMinimizeEventHandler OnRequestContainerMinimize;

		// Token: 0x140004A5 RID: 1189
		// (add) Token: 0x06002721 RID: 10017
		// (remove) Token: 0x06002722 RID: 10018
		public virtual extern event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x140004A6 RID: 1190
		// (add) Token: 0x06002723 RID: 10019
		// (remove) Token: 0x06002724 RID: 10020
		public virtual extern event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x140004A7 RID: 1191
		// (add) Token: 0x06002725 RID: 10021
		// (remove) Token: 0x06002726 RID: 10022
		public virtual extern event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x140004A8 RID: 1192
		// (add) Token: 0x06002727 RID: 10023
		// (remove) Token: 0x06002728 RID: 10024
		public virtual extern event IMsTscAxEvents_OnAuthenticationWarningDisplayedEventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x140004A9 RID: 1193
		// (add) Token: 0x06002729 RID: 10025
		// (remove) Token: 0x0600272A RID: 10026
		public virtual extern event IMsTscAxEvents_OnAuthenticationWarningDismissedEventHandler OnAuthenticationWarningDismissed;

		// Token: 0x140004AA RID: 1194
		// (add) Token: 0x0600272B RID: 10027
		// (remove) Token: 0x0600272C RID: 10028
		public virtual extern event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x140004AB RID: 1195
		// (add) Token: 0x0600272D RID: 10029
		// (remove) Token: 0x0600272E RID: 10030
		public virtual extern event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x140004AC RID: 1196
		// (add) Token: 0x0600272F RID: 10031
		// (remove) Token: 0x06002730 RID: 10032
		public virtual extern event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x140004AD RID: 1197
		// (add) Token: 0x06002731 RID: 10033
		// (remove) Token: 0x06002732 RID: 10034
		public virtual extern event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x140004AE RID: 1198
		// (add) Token: 0x06002733 RID: 10035
		// (remove) Token: 0x06002734 RID: 10036
		public virtual extern event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x140004AF RID: 1199
		// (add) Token: 0x06002735 RID: 10037
		// (remove) Token: 0x06002736 RID: 10038
		public virtual extern event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x140004B0 RID: 1200
		// (add) Token: 0x06002737 RID: 10039
		// (remove) Token: 0x06002738 RID: 10040
		public virtual extern event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x140004B1 RID: 1201
		// (add) Token: 0x06002739 RID: 10041
		// (remove) Token: 0x0600273A RID: 10042
		public virtual extern event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x140004B2 RID: 1202
		// (add) Token: 0x0600273B RID: 10043
		// (remove) Token: 0x0600273C RID: 10044
		public virtual extern event IMsTscAxEvents_OnConnectionBarPullDownEventHandler OnConnectionBarPullDown;

		// Token: 0x140004B3 RID: 1203
		// (add) Token: 0x0600273D RID: 10045
		// (remove) Token: 0x0600273E RID: 10046
		public virtual extern event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x140004B4 RID: 1204
		// (add) Token: 0x0600273F RID: 10047
		// (remove) Token: 0x06002740 RID: 10048
		public virtual extern event IMsTscAxEvents_OnDevicesButtonPressedEventHandler OnDevicesButtonPressed;

		// Token: 0x140004B5 RID: 1205
		// (add) Token: 0x06002741 RID: 10049
		// (remove) Token: 0x06002742 RID: 10050
		public virtual extern event IMsTscAxEvents_OnAutoReconnectedEventHandler OnAutoReconnected;

		// Token: 0x140004B6 RID: 1206
		// (add) Token: 0x06002743 RID: 10051
		// (remove) Token: 0x06002744 RID: 10052
		public virtual extern event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;
	}
}
