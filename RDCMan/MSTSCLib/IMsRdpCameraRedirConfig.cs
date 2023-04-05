using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[InterfaceType(1)]
	[Guid("09750604-D625-47C1-9FCD-F09F735705D7")]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpCameraRedirConfig
	{
		[DispId(1)]
		string FriendlyName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		[DispId(2)]
		string SymbolicLink { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		[DispId(3)]
		string InstanceId { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		[DispId(4)]
		string ParentInstanceId { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		[DispId(5)]
		bool Redirected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(6)]
		bool DeviceExists { [MethodImpl(MethodImplOptions.InternalCall)] get; }
	}
}
