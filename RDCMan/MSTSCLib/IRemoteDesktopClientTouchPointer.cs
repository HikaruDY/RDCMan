using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[TypeLibType(4160)]
	[Guid("260EC22D-8CBC-44B5-9E88-2A37F6C93AE9")]
	[ComVisible(true)]
	[ComImport]
	public interface IRemoteDesktopClientTouchPointer
	{
		[DispId(740)]
		bool Enabled { [DispId(740)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(740)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(741)]
		bool EventsEnabled { [DispId(741)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(741)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(742)]
		uint PointerSpeed { [DispId(742)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(742)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
