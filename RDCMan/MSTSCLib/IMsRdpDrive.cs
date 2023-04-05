using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[InterfaceType(1)]
	[Guid("D28B5458-F694-47A8-8E61-40356A767E46")]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpDrive
	{
		[DispId(229)]
		string Name { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		[DispId(230)]
		bool RedirectionState { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
