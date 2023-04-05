using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001BD RID: 445
	[Guid("7FF17599-DA2C-4677-AD35-F60C04FE1585")]
	[InterfaceType(1)]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpDriveCollection
	{
		// Token: 0x06002D00 RID: 11520
		[MethodImpl(MethodImplOptions.InternalCall)]
		void RescanDrives(bool vboolDynRedir);

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x06002D01 RID: 11521
		[DispId(231)]
		IMsRdpDrive DriveByIndex { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x06002D02 RID: 11522
		[DispId(233)]
		uint DriveCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }
	}
}
