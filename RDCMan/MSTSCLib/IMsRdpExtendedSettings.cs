using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001D4 RID: 468
	[Guid("302D8188-0052-4807-806A-362B628F9AC5")]
	[InterfaceType(1)]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpExtendedSettings
	{
		// Token: 0x170011B9 RID: 4537
		// (get) Token: 0x0600375B RID: 14171
		// (set) Token: 0x0600375A RID: 14170
		[DispId(1)]
		object Property { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Struct)] [param: In] set; }
	}
}
