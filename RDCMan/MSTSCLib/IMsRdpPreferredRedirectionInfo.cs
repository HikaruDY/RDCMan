using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001D3 RID: 467
	[Guid("FDD029F9-9574-4DEF-8529-64B521CCCAA4")]
	[InterfaceType(1)]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpPreferredRedirectionInfo
	{
		// Token: 0x170011B8 RID: 4536
		// (get) Token: 0x06003759 RID: 14169
		// (set) Token: 0x06003758 RID: 14168
		[DispId(1)]
		bool UseRedirectionServerName { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
