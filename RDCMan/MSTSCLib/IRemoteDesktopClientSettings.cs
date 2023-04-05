using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x0200020D RID: 525
	[Guid("48A0F2A7-2713-431F-BBAC-6F4558E7D64D")]
	[TypeLibType(4160)]
	[ComVisible(true)]
	[ComImport]
	public interface IRemoteDesktopClientSettings
	{
		// Token: 0x06005508 RID: 21768
		[DispId(722)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ApplySettings([MarshalAs(UnmanagedType.BStr)] [In] string RdpFileContents);

		// Token: 0x06005509 RID: 21769
		[DispId(723)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string RetrieveSettings();

		// Token: 0x0600550A RID: 21770
		[DispId(721)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Struct)]
		object GetRdpProperty([MarshalAs(UnmanagedType.BStr)] [In] string propertyName);

		// Token: 0x0600550B RID: 21771
		[DispId(720)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetRdpProperty([MarshalAs(UnmanagedType.BStr)] [In] string propertyName, [MarshalAs(UnmanagedType.Struct)] [In] object Value);
	}
}
