using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x0200018B RID: 395
	[Guid("209D0EB9-6254-47B1-9033-A98DAE55BB27")]
	[TypeLibType(4176)]
	[ComVisible(true)]
	[ComImport]
	public interface IMsTscDebug
	{
		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06001CDC RID: 7388
		// (set) Token: 0x06001CDB RID: 7387
		[DispId(200)]
		int HatchBitmapPDU { [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06001CDE RID: 7390
		// (set) Token: 0x06001CDD RID: 7389
		[DispId(201)]
		int HatchSSBOrder { [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06001CE0 RID: 7392
		// (set) Token: 0x06001CDF RID: 7391
		[DispId(202)]
		int HatchMembltOrder { [DispId(202)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(202)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06001CE2 RID: 7394
		// (set) Token: 0x06001CE1 RID: 7393
		[DispId(203)]
		int HatchIndexPDU { [DispId(203)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(203)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06001CE4 RID: 7396
		// (set) Token: 0x06001CE3 RID: 7395
		[DispId(204)]
		int LabelMemblt { [DispId(204)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(204)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06001CE6 RID: 7398
		// (set) Token: 0x06001CE5 RID: 7397
		[DispId(205)]
		int BitmapCacheMonitor { [DispId(205)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(205)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06001CE8 RID: 7400
		// (set) Token: 0x06001CE7 RID: 7399
		[DispId(206)]
		int MallocFailuresPercent { [DispId(206)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(206)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06001CEA RID: 7402
		// (set) Token: 0x06001CE9 RID: 7401
		[DispId(207)]
		int MallocHugeFailuresPercent { [DispId(207)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(207)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06001CEC RID: 7404
		// (set) Token: 0x06001CEB RID: 7403
		[DispId(208)]
		int NetThroughput { [DispId(208)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(208)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06001CEE RID: 7406
		// (set) Token: 0x06001CED RID: 7405
		[DispId(209)]
		string CLXCmdLine { [DispId(209)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(209)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06001CF0 RID: 7408
		// (set) Token: 0x06001CEF RID: 7407
		[DispId(210)]
		string CLXDll { [DispId(210)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(210)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06001CF2 RID: 7410
		// (set) Token: 0x06001CF1 RID: 7409
		[DispId(211)]
		int RemoteProgramsHatchVisibleRegion { [DispId(211)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(211)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06001CF4 RID: 7412
		// (set) Token: 0x06001CF3 RID: 7411
		[DispId(212)]
		int RemoteProgramsHatchVisibleNoDataRegion { [DispId(212)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(212)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06001CF6 RID: 7414
		// (set) Token: 0x06001CF5 RID: 7413
		[DispId(213)]
		int RemoteProgramsHatchNonVisibleRegion { [DispId(213)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(213)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06001CF8 RID: 7416
		// (set) Token: 0x06001CF7 RID: 7415
		[DispId(214)]
		int RemoteProgramsHatchWindow { [DispId(214)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(214)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06001CFA RID: 7418
		// (set) Token: 0x06001CF9 RID: 7417
		[DispId(215)]
		int RemoteProgramsStayConnectOnBadCaps { [DispId(215)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(215)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06001CFB RID: 7419
		[DispId(216)]
		uint ControlType { [DispId(216)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000564 RID: 1380
		// (set) Token: 0x06001CFC RID: 7420
		[DispId(217)]
		bool DecodeGfx { [DispId(217)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
