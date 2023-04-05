using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[Guid("209D0EB9-6254-47B1-9033-A98DAE55BB27")]
	[TypeLibType(4176)]
	[ComVisible(true)]
	[ComImport]
	public interface IMsTscDebug
	{
		[DispId(200)]
		int HatchBitmapPDU { [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(201)]
		int HatchSSBOrder { [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(202)]
		int HatchMembltOrder { [DispId(202)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(202)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(203)]
		int HatchIndexPDU { [DispId(203)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(203)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(204)]
		int LabelMemblt { [DispId(204)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(204)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(205)]
		int BitmapCacheMonitor { [DispId(205)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(205)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(206)]
		int MallocFailuresPercent { [DispId(206)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(206)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(207)]
		int MallocHugeFailuresPercent { [DispId(207)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(207)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(208)]
		int NetThroughput { [DispId(208)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(208)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(209)]
		string CLXCmdLine { [DispId(209)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(209)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		[DispId(210)]
		string CLXDll { [DispId(210)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(210)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		[DispId(211)]
		int RemoteProgramsHatchVisibleRegion { [DispId(211)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(211)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(212)]
		int RemoteProgramsHatchVisibleNoDataRegion { [DispId(212)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(212)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(213)]
		int RemoteProgramsHatchNonVisibleRegion { [DispId(213)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(213)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(214)]
		int RemoteProgramsHatchWindow { [DispId(214)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(214)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(215)]
		int RemoteProgramsStayConnectOnBadCaps { [DispId(215)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(215)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(216)]
		uint ControlType { [DispId(216)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		[DispId(217)]
		bool DecodeGfx { [DispId(217)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
