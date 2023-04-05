using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x0200020C RID: 524
	[TypeLibType(4160)]
	[Guid("57D25668-625A-4905-BE4E-304CAA13F89C")]
	[ComVisible(true)]
	[ComImport]
	public interface IRemoteDesktopClient
	{
		// Token: 0x060054FE RID: 21758
		[DispId(701)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Connect();

		// Token: 0x060054FF RID: 21759
		[DispId(702)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Disconnect();

		// Token: 0x06005500 RID: 21760
		[DispId(703)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Reconnect([In] uint width, [In] uint height);

		// Token: 0x17002130 RID: 8496
		// (get) Token: 0x06005501 RID: 21761
		[DispId(710)]
		IRemoteDesktopClientSettings Settings { [DispId(710)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17002131 RID: 8497
		// (get) Token: 0x06005502 RID: 21762
		[DispId(711)]
		IRemoteDesktopClientActions Actions { [DispId(711)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17002132 RID: 8498
		// (get) Token: 0x06005503 RID: 21763
		[DispId(712)]
		IRemoteDesktopClientTouchPointer TouchPointer { [DispId(712)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06005504 RID: 21764
		[DispId(704)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void DeleteSavedCredentials([MarshalAs(UnmanagedType.BStr)] [In] string serverName);

		// Token: 0x06005505 RID: 21765
		[DispId(705)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void UpdateSessionDisplaySettings([In] uint width, [In] uint height);

		// Token: 0x06005506 RID: 21766
		[DispId(706)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void attachEvent([MarshalAs(UnmanagedType.BStr)] [In] string eventName, [MarshalAs(UnmanagedType.IDispatch)] [In] object callback);

		// Token: 0x06005507 RID: 21767
		[DispId(707)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void detachEvent([MarshalAs(UnmanagedType.BStr)] [In] string eventName, [MarshalAs(UnmanagedType.IDispatch)] [In] object callback);
	}
}
