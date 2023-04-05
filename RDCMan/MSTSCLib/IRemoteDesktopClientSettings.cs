using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[Guid("48A0F2A7-2713-431F-BBAC-6F4558E7D64D")]
	[TypeLibType(4160)]
	[ComVisible(true)]
	[ComImport]
	public interface IRemoteDesktopClientSettings
	{
		[DispId(722)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ApplySettings([MarshalAs(UnmanagedType.BStr)] [In] string RdpFileContents);

		[DispId(723)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string RetrieveSettings();

		[DispId(721)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Struct)]
		object GetRdpProperty([MarshalAs(UnmanagedType.BStr)] [In] string propertyName);

		[DispId(720)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetRdpProperty([MarshalAs(UnmanagedType.BStr)] [In] string propertyName, [MarshalAs(UnmanagedType.Struct)] [In] object Value);
	}
}
