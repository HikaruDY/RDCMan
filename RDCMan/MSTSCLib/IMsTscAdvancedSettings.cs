using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x0200018A RID: 394
	[Guid("809945CC-4B3B-4A92-A6B0-DBF9B5F2EF2D")]
	[TypeLibType(4160)]
	[ComVisible(true)]
	[ComImport]
	public interface IMsTscAdvancedSettings
	{
		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06001CCE RID: 7374
		// (set) Token: 0x06001CCD RID: 7373
		[DispId(121)]
		int Compress { [DispId(121)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(121)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06001CD0 RID: 7376
		// (set) Token: 0x06001CCF RID: 7375
		[DispId(122)]
		int BitmapPeristence { [DispId(122)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(122)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06001CD2 RID: 7378
		// (set) Token: 0x06001CD1 RID: 7377
		[DispId(161)]
		int allowBackgroundInput { [DispId(161)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(161)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700054D RID: 1357
		// (set) Token: 0x06001CD3 RID: 7379
		[DispId(162)]
		string KeyBoardLayoutStr { [DispId(162)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700054E RID: 1358
		// (set) Token: 0x06001CD4 RID: 7380
		[DispId(170)]
		string PluginDlls { [DispId(170)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700054F RID: 1359
		// (set) Token: 0x06001CD5 RID: 7381
		[DispId(171)]
		string IconFile { [DispId(171)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000550 RID: 1360
		// (set) Token: 0x06001CD6 RID: 7382
		[DispId(172)]
		int IconIndex { [DispId(172)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06001CD8 RID: 7384
		// (set) Token: 0x06001CD7 RID: 7383
		[DispId(173)]
		int ContainerHandledFullScreen { [DispId(173)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(173)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001CDA RID: 7386
		// (set) Token: 0x06001CD9 RID: 7385
		[DispId(174)]
		int DisableRdpdr { [DispId(174)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(174)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
