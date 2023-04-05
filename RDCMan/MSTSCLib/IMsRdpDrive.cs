using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001BE RID: 446
	[InterfaceType(1)]
	[Guid("D28B5458-F694-47A8-8E61-40356A767E46")]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpDrive
	{
		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x06002D03 RID: 11523
		[DispId(229)]
		string Name { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x06002D05 RID: 11525
		// (set) Token: 0x06002D04 RID: 11524
		[DispId(230)]
		bool RedirectionState { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
