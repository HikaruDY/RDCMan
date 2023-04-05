using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[Guid("FDD029F9-9574-4DEF-8529-64B521CCCAA4")]
	[InterfaceType(1)]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpPreferredRedirectionInfo
	{
		[DispId(1)]
		bool UseRedirectionServerName { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
