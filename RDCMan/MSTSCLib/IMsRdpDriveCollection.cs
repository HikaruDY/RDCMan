using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[Guid("7FF17599-DA2C-4677-AD35-F60C04FE1585")]
	[InterfaceType(1)]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpDriveCollection
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void RescanDrives(bool vboolDynRedir);

		[DispId(231)]
		IMsRdpDrive DriveByIndex { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		[DispId(233)]
		uint DriveCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }
	}
}
