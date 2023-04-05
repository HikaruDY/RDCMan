using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[Guid("7D54BC4E-1028-45D4-8B0A-B9B6BFFBA176")]
	[TypeLibType(4160)]
	[ComVisible(true)]
	[ComImport]
	public interface IRemoteDesktopClientActions
	{
		[DispId(730)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SuspendScreenUpdates();

		[DispId(731)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ResumeScreenUpdates();

		[DispId(732)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ExecuteRemoteAction([ComAliasName("MSTSCLib.RemoteActionType")] [In] RemoteActionType remoteAction);

		[DispId(733)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string GetSnapshot([ComAliasName("MSTSCLib.SnapshotEncodingType")] [In] SnapshotEncodingType snapshotEncoding, [ComAliasName("MSTSCLib.SnapshotFormatType")] [In] SnapshotFormatType snapshotFormat, [In] uint snapshotWidth, [In] uint snapshotHeight);
	}
}
