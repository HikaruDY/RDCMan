using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001A5 RID: 421
	[TypeLibType(4160)]
	[Guid("19CD856B-C542-4C53-ACEE-F127E3BE1A59")]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpClientAdvancedSettings3 : IMsRdpClientAdvancedSettings2
	{
		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x060023A3 RID: 9123
		// (set) Token: 0x060023A2 RID: 9122
		[DispId(121)]
		int Compress { [DispId(121)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(121)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x060023A5 RID: 9125
		// (set) Token: 0x060023A4 RID: 9124
		[DispId(122)]
		int BitmapPeristence { [DispId(122)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(122)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x060023A7 RID: 9127
		// (set) Token: 0x060023A6 RID: 9126
		[DispId(161)]
		int allowBackgroundInput { [DispId(161)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(161)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700081A RID: 2074
		// (set) Token: 0x060023A8 RID: 9128
		[DispId(162)]
		string KeyBoardLayoutStr { [DispId(162)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700081B RID: 2075
		// (set) Token: 0x060023A9 RID: 9129
		[DispId(170)]
		string PluginDlls { [DispId(170)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700081C RID: 2076
		// (set) Token: 0x060023AA RID: 9130
		[DispId(171)]
		string IconFile { [DispId(171)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700081D RID: 2077
		// (set) Token: 0x060023AB RID: 9131
		[DispId(172)]
		int IconIndex { [DispId(172)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x060023AD RID: 9133
		// (set) Token: 0x060023AC RID: 9132
		[DispId(173)]
		int ContainerHandledFullScreen { [DispId(173)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(173)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x060023AF RID: 9135
		// (set) Token: 0x060023AE RID: 9134
		[DispId(174)]
		int DisableRdpdr { [DispId(174)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(174)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x060023B1 RID: 9137
		// (set) Token: 0x060023B0 RID: 9136
		[DispId(101)]
		int SmoothScroll { [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x060023B3 RID: 9139
		// (set) Token: 0x060023B2 RID: 9138
		[DispId(102)]
		int AcceleratorPassthrough { [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x060023B5 RID: 9141
		// (set) Token: 0x060023B4 RID: 9140
		[DispId(103)]
		int ShadowBitmap { [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x060023B7 RID: 9143
		// (set) Token: 0x060023B6 RID: 9142
		[DispId(104)]
		int TransportType { [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x060023B9 RID: 9145
		// (set) Token: 0x060023B8 RID: 9144
		[DispId(105)]
		int SasSequence { [DispId(105)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(105)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x060023BB RID: 9147
		// (set) Token: 0x060023BA RID: 9146
		[DispId(106)]
		int EncryptionEnabled { [DispId(106)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(106)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x060023BD RID: 9149
		// (set) Token: 0x060023BC RID: 9148
		[DispId(107)]
		int DedicatedTerminal { [DispId(107)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(107)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x060023BF RID: 9151
		// (set) Token: 0x060023BE RID: 9150
		[DispId(108)]
		int RDPPort { [DispId(108)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(108)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x060023C1 RID: 9153
		// (set) Token: 0x060023C0 RID: 9152
		[DispId(109)]
		int EnableMouse { [DispId(109)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(109)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x060023C3 RID: 9155
		// (set) Token: 0x060023C2 RID: 9154
		[DispId(110)]
		int DisableCtrlAltDel { [DispId(110)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(110)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x060023C5 RID: 9157
		// (set) Token: 0x060023C4 RID: 9156
		[DispId(111)]
		int EnableWindowsKey { [DispId(111)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(111)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x060023C7 RID: 9159
		// (set) Token: 0x060023C6 RID: 9158
		[DispId(112)]
		int DoubleClickDetect { [DispId(112)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(112)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x060023C9 RID: 9161
		// (set) Token: 0x060023C8 RID: 9160
		[DispId(113)]
		int MaximizeShell { [DispId(113)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(113)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x060023CB RID: 9163
		// (set) Token: 0x060023CA RID: 9162
		[DispId(114)]
		int HotKeyFullScreen { [DispId(114)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(114)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x060023CD RID: 9165
		// (set) Token: 0x060023CC RID: 9164
		[DispId(115)]
		int HotKeyCtrlEsc { [DispId(115)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(115)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x060023CF RID: 9167
		// (set) Token: 0x060023CE RID: 9166
		[DispId(116)]
		int HotKeyAltEsc { [DispId(116)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(116)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x060023D1 RID: 9169
		// (set) Token: 0x060023D0 RID: 9168
		[DispId(117)]
		int HotKeyAltTab { [DispId(117)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(117)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x060023D3 RID: 9171
		// (set) Token: 0x060023D2 RID: 9170
		[DispId(118)]
		int HotKeyAltShiftTab { [DispId(118)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(118)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x060023D5 RID: 9173
		// (set) Token: 0x060023D4 RID: 9172
		[DispId(119)]
		int HotKeyAltSpace { [DispId(119)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(119)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x060023D7 RID: 9175
		// (set) Token: 0x060023D6 RID: 9174
		[DispId(120)]
		int HotKeyCtrlAltDel { [DispId(120)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(120)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x060023D9 RID: 9177
		// (set) Token: 0x060023D8 RID: 9176
		[DispId(123)]
		int orderDrawThreshold { [DispId(123)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(123)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x060023DB RID: 9179
		// (set) Token: 0x060023DA RID: 9178
		[DispId(124)]
		int BitmapCacheSize { [DispId(124)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(124)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x060023DD RID: 9181
		// (set) Token: 0x060023DC RID: 9180
		[DispId(125)]
		int BitmapVirtualCacheSize { [DispId(125)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(125)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x060023DF RID: 9183
		// (set) Token: 0x060023DE RID: 9182
		[DispId(175)]
		int ScaleBitmapCachesByBPP { [DispId(175)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(175)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x060023E1 RID: 9185
		// (set) Token: 0x060023E0 RID: 9184
		[DispId(126)]
		int NumBitmapCaches { [DispId(126)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(126)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x060023E3 RID: 9187
		// (set) Token: 0x060023E2 RID: 9186
		[DispId(127)]
		int CachePersistenceActive { [DispId(127)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(127)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700083A RID: 2106
		// (set) Token: 0x060023E4 RID: 9188
		[DispId(138)]
		string PersistCacheDirectory { [DispId(138)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x060023E6 RID: 9190
		// (set) Token: 0x060023E5 RID: 9189
		[DispId(156)]
		int brushSupportLevel { [DispId(156)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(156)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x060023E8 RID: 9192
		// (set) Token: 0x060023E7 RID: 9191
		[DispId(157)]
		int minInputSendInterval { [DispId(157)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(157)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x060023EA RID: 9194
		// (set) Token: 0x060023E9 RID: 9193
		[DispId(158)]
		int InputEventsAtOnce { [DispId(158)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(158)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x060023EC RID: 9196
		// (set) Token: 0x060023EB RID: 9195
		[DispId(159)]
		int maxEventCount { [DispId(159)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(159)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x060023EE RID: 9198
		// (set) Token: 0x060023ED RID: 9197
		[DispId(160)]
		int keepAliveInterval { [DispId(160)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(160)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x060023F0 RID: 9200
		// (set) Token: 0x060023EF RID: 9199
		[DispId(163)]
		int shutdownTimeout { [DispId(163)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(163)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x060023F2 RID: 9202
		// (set) Token: 0x060023F1 RID: 9201
		[DispId(164)]
		int overallConnectionTimeout { [DispId(164)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(164)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x060023F4 RID: 9204
		// (set) Token: 0x060023F3 RID: 9203
		[DispId(165)]
		int singleConnectionTimeout { [DispId(165)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(165)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x060023F6 RID: 9206
		// (set) Token: 0x060023F5 RID: 9205
		[DispId(166)]
		int KeyboardType { [DispId(166)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(166)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x060023F8 RID: 9208
		// (set) Token: 0x060023F7 RID: 9207
		[DispId(167)]
		int KeyboardSubType { [DispId(167)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(167)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x060023FA RID: 9210
		// (set) Token: 0x060023F9 RID: 9209
		[DispId(168)]
		int KeyboardFunctionKey { [DispId(168)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(168)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x060023FC RID: 9212
		// (set) Token: 0x060023FB RID: 9211
		[DispId(169)]
		int WinceFixedPalette { [DispId(169)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(169)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x060023FE RID: 9214
		// (set) Token: 0x060023FD RID: 9213
		[DispId(178)]
		bool ConnectToServerConsole { [DispId(178)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(178)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06002400 RID: 9216
		// (set) Token: 0x060023FF RID: 9215
		[DispId(182)]
		int BitmapPersistence { [DispId(182)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(182)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06002402 RID: 9218
		// (set) Token: 0x06002401 RID: 9217
		[DispId(183)]
		int MinutesToIdleTimeout { [DispId(183)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(183)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06002404 RID: 9220
		// (set) Token: 0x06002403 RID: 9219
		[DispId(184)]
		bool SmartSizing { [DispId(184)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(184)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06002406 RID: 9222
		// (set) Token: 0x06002405 RID: 9221
		[DispId(185)]
		string RdpdrLocalPrintingDocName { [DispId(185)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(185)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06002408 RID: 9224
		// (set) Token: 0x06002407 RID: 9223
		[DispId(201)]
		string RdpdrClipCleanTempDirString { [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x0600240A RID: 9226
		// (set) Token: 0x06002409 RID: 9225
		[DispId(202)]
		string RdpdrClipPasteInfoString { [DispId(202)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(202)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700084E RID: 2126
		// (set) Token: 0x0600240B RID: 9227
		[DispId(186)]
		string ClearTextPassword { [DispId(186)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x0600240D RID: 9229
		// (set) Token: 0x0600240C RID: 9228
		[DispId(187)]
		bool DisplayConnectionBar { [DispId(187)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(187)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x0600240F RID: 9231
		// (set) Token: 0x0600240E RID: 9230
		[DispId(188)]
		bool PinConnectionBar { [DispId(188)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(188)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06002411 RID: 9233
		// (set) Token: 0x06002410 RID: 9232
		[DispId(189)]
		bool GrabFocusOnConnect { [DispId(189)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(189)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06002413 RID: 9235
		// (set) Token: 0x06002412 RID: 9234
		[DispId(190)]
		string LoadBalanceInfo { [DispId(190)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(190)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06002415 RID: 9237
		// (set) Token: 0x06002414 RID: 9236
		[DispId(191)]
		bool RedirectDrives { [DispId(191)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(191)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06002417 RID: 9239
		// (set) Token: 0x06002416 RID: 9238
		[DispId(192)]
		bool RedirectPrinters { [DispId(192)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(192)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06002419 RID: 9241
		// (set) Token: 0x06002418 RID: 9240
		[DispId(193)]
		bool RedirectPorts { [DispId(193)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(193)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x0600241B RID: 9243
		// (set) Token: 0x0600241A RID: 9242
		[DispId(194)]
		bool RedirectSmartCards { [DispId(194)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(194)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x0600241D RID: 9245
		// (set) Token: 0x0600241C RID: 9244
		[DispId(195)]
		int BitmapVirtualCache16BppSize { [DispId(195)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(195)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x0600241F RID: 9247
		// (set) Token: 0x0600241E RID: 9246
		[DispId(196)]
		int BitmapVirtualCache24BppSize { [DispId(196)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(196)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06002421 RID: 9249
		// (set) Token: 0x06002420 RID: 9248
		[DispId(200)]
		int PerformanceFlags { [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700085A RID: 2138
		// (set) Token: 0x06002422 RID: 9250
		[DispId(203)]
		ref object ConnectWithEndpoint { [DispId(203)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Struct)] [param: In] set; }

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06002424 RID: 9252
		// (set) Token: 0x06002423 RID: 9251
		[DispId(204)]
		bool NotifyTSPublicKey { [DispId(204)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(204)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06002425 RID: 9253
		[DispId(205)]
		bool CanAutoReconnect { [DispId(205)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06002427 RID: 9255
		// (set) Token: 0x06002426 RID: 9254
		[DispId(206)]
		bool EnableAutoReconnect { [DispId(206)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(206)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x06002429 RID: 9257
		// (set) Token: 0x06002428 RID: 9256
		[DispId(207)]
		int MaxReconnectAttempts { [DispId(207)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(207)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x0600242B RID: 9259
		// (set) Token: 0x0600242A RID: 9258
		[DispId(210)]
		bool ConnectionBarShowMinimizeButton { [DispId(210)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(210)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x0600242D RID: 9261
		// (set) Token: 0x0600242C RID: 9260
		[DispId(211)]
		bool ConnectionBarShowRestoreButton { [DispId(211)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(211)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
