using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[Guid("302D8188-0052-4807-806A-362B628F9AC5")]
	[InterfaceType(1)]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpExtendedSettings
	{
		[DispId(1)]
		object Property { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Struct)] [param: In] set; }
	}
}
