using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x02000192 RID: 402
	[Guid("C1E6743A-41C1-4A74-832A-0DD06C1C7A0E")]
	[InterfaceType(1)]
	[ComVisible(true)]
	[ComImport]
	public interface IMsTscNonScriptable
	{
		// Token: 0x170005AF RID: 1455
		// (set) Token: 0x06001D8A RID: 7562
		[DispId(1)]
		string ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06001D8C RID: 7564
		// (set) Token: 0x06001D8B RID: 7563
		[DispId(2)]
		string PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06001D8E RID: 7566
		// (set) Token: 0x06001D8D RID: 7565
		[DispId(3)]
		string PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06001D90 RID: 7568
		// (set) Token: 0x06001D8F RID: 7567
		[DispId(4)]
		string BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06001D92 RID: 7570
		// (set) Token: 0x06001D91 RID: 7569
		[DispId(5)]
		string BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06001D93 RID: 7571
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ResetPassword();
	}
}
