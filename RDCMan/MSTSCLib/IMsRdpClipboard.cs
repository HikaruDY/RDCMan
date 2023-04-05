using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001F7 RID: 503
	[Guid("2E769EE8-00C7-43DC-AFD9-235D75B72A40")]
	[InterfaceType(1)]
	[ComVisible(true)]
	[ComImport]
	public interface IMsRdpClipboard
	{
		// Token: 0x060050E9 RID: 20713
		[MethodImpl(MethodImplOptions.InternalCall)]
		bool CanSyncLocalClipboardToRemoteSession();

		// Token: 0x060050EA RID: 20714
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SyncLocalClipboardToRemoteSession();

		// Token: 0x060050EB RID: 20715
		[MethodImpl(MethodImplOptions.InternalCall)]
		bool CanSyncRemoteClipboardToLocalSession();

		// Token: 0x060050EC RID: 20716
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SyncRemoteClipboardToLocalSession();
	}
}
