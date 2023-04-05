using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x0200020E RID: 526
	[Guid("7D54BC4E-1028-45D4-8B0A-B9B6BFFBA176")]
	[TypeLibType(4160)]
	[ComVisible(true)]
	[ComImport]
	public interface IRemoteDesktopClientActions
	{
		// Token: 0x0600550C RID: 21772
		[DispId(730)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SuspendScreenUpdates();

		// Token: 0x0600550D RID: 21773
		[DispId(731)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ResumeScreenUpdates();

		// Token: 0x0600550E RID: 21774
		[DispId(732)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ExecuteRemoteAction([ComAliasName("MSTSCLib.RemoteActionType")] [In] RemoteActionType remoteAction);

		// Token: 0x0600550F RID: 21775
		[DispId(733)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string GetSnapshot([ComAliasName("MSTSCLib.SnapshotEncodingType")] [In] SnapshotEncodingType snapshotEncoding, [ComAliasName("MSTSCLib.SnapshotFormatType")] [In] SnapshotFormatType snapshotFormat, [In] uint snapshotWidth, [In] uint snapshotHeight);
	}
}
