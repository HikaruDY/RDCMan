using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x02000189 RID: 393
	[Guid("C9D65442-A0F9-45B2-8F73-D61D2DB8CBB6")]
	[TypeLibType(4160)]
	[ComVisible(true)]
	[ComImport]
	public interface IMsTscSecuredSettings
	{
		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06001CC8 RID: 7368
		// (set) Token: 0x06001CC7 RID: 7367
		[DispId(1)]
		string StartProgram { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06001CCA RID: 7370
		// (set) Token: 0x06001CC9 RID: 7369
		[DispId(2)]
		string WorkDir { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06001CCC RID: 7372
		// (set) Token: 0x06001CCB RID: 7371
		[DispId(3)]
		int FullScreen { [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
