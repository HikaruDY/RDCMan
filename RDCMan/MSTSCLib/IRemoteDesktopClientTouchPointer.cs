using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x02000215 RID: 533
	[TypeLibType(4160)]
	[Guid("260EC22D-8CBC-44B5-9E88-2A37F6C93AE9")]
	[ComVisible(true)]
	[ComImport]
	public interface IRemoteDesktopClientTouchPointer
	{
		// Token: 0x17002133 RID: 8499
		// (get) Token: 0x06005511 RID: 21777
		// (set) Token: 0x06005510 RID: 21776
		[DispId(740)]
		bool Enabled { [DispId(740)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(740)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17002134 RID: 8500
		// (get) Token: 0x06005513 RID: 21779
		// (set) Token: 0x06005512 RID: 21778
		[DispId(741)]
		bool EventsEnabled { [DispId(741)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(741)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17002135 RID: 8501
		// (get) Token: 0x06005515 RID: 21781
		// (set) Token: 0x06005514 RID: 21780
		[DispId(742)]
		uint PointerSpeed { [DispId(742)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(742)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
