using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[Guid("D012AE6D-C19A-4BFE-B367-201F8911F134")]
	[TypeLibType(4160)]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpClientShell
	{
		[DispId(201)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Launch();

		[DispId(202)]
		string RdpFileContents { [DispId(202)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(202)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		[DispId(203)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetRdpProperty([MarshalAs(UnmanagedType.BStr)] [In] string szProperty, [MarshalAs(UnmanagedType.Struct)] [In] object Value);

		[DispId(204)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Struct)]
		object GetRdpProperty([MarshalAs(UnmanagedType.BStr)] [In] string szProperty);

		[DispId(205)]
		bool IsRemoteProgramClientInstalled { [DispId(205)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		[DispId(211)]
		bool PublicMode { [DispId(211)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(211)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(212)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ShowTrustedSitesManagementDialog();
	}
}
