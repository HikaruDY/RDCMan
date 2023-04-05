using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[Guid("2E769EE8-00C7-43DC-AFD9-235D75B72A40")]
	[InterfaceType(1)]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpClipboard
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		bool CanSyncLocalClipboardToRemoteSession();

		[MethodImpl(MethodImplOptions.InternalCall)]
		void SyncLocalClipboardToRemoteSession();

		[MethodImpl(MethodImplOptions.InternalCall)]
		bool CanSyncRemoteClipboardToLocalSession();

		[MethodImpl(MethodImplOptions.InternalCall)]
		void SyncRemoteClipboardToLocalSession();
	}
}
