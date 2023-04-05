using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x0200015A RID: 346
	[InterfaceType(2)]
	[TypeLibType(4096)]
	[Guid("336D5562-EFA8-482E-8CB3-C5C0FC7A7DB6")]
	[ComVisible(true)]
	[ComImport]
	public interface IMsTscAxEvents
	{
		// Token: 0x06001B44 RID: 6980
		[DispId(1)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnConnecting();

		// Token: 0x06001B45 RID: 6981
		[DispId(2)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnConnected();

		// Token: 0x06001B46 RID: 6982
		[DispId(3)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnLoginComplete();

		// Token: 0x06001B47 RID: 6983
		[DispId(4)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnDisconnected([In] int discReason);

		// Token: 0x06001B48 RID: 6984
		[DispId(5)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnEnterFullScreenMode();

		// Token: 0x06001B49 RID: 6985
		[DispId(6)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnLeaveFullScreenMode();

		// Token: 0x06001B4A RID: 6986
		[DispId(7)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnChannelReceivedData([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string data);

		// Token: 0x06001B4B RID: 6987
		[DispId(8)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnRequestGoFullScreen();

		// Token: 0x06001B4C RID: 6988
		[DispId(9)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnRequestLeaveFullScreen();

		// Token: 0x06001B4D RID: 6989
		[DispId(10)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnFatalError([In] int errorCode);

		// Token: 0x06001B4E RID: 6990
		[DispId(11)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnWarning([In] int warningCode);

		// Token: 0x06001B4F RID: 6991
		[DispId(12)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnRemoteDesktopSizeChange([In] int width, [In] int height);

		// Token: 0x06001B50 RID: 6992
		[DispId(13)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnIdleTimeoutNotification();

		// Token: 0x06001B51 RID: 6993
		[DispId(14)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnRequestContainerMinimize();

		// Token: 0x06001B52 RID: 6994
		[DispId(15)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnConfirmClose(out bool pfAllowClose);

		// Token: 0x06001B53 RID: 6995
		[DispId(16)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnReceivedTSPublicKey([MarshalAs(UnmanagedType.BStr)] [In] string publicKey, out bool pfContinueLogon);

		// Token: 0x06001B54 RID: 6996
		[DispId(17)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnAutoReconnecting([In] int disconnectReason, [In] int attemptCount, [ComAliasName("MSTSCLib.AutoReconnectContinueState")] out AutoReconnectContinueState pArcContinueStatus);

		// Token: 0x06001B55 RID: 6997
		[DispId(18)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnAuthenticationWarningDisplayed();

		// Token: 0x06001B56 RID: 6998
		[DispId(19)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnAuthenticationWarningDismissed();

		// Token: 0x06001B57 RID: 6999
		[DispId(20)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnRemoteProgramResult([MarshalAs(UnmanagedType.BStr)] [In] string bstrRemoteProgram, [ComAliasName("MSTSCLib.RemoteProgramResult")] [In] RemoteProgramResult lError, [In] bool vbIsExecutable);

		// Token: 0x06001B58 RID: 7000
		[DispId(21)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnRemoteProgramDisplayed([In] bool vbDisplayed, [In] uint uDisplayInformation);

		// Token: 0x06001B59 RID: 7001
		[DispId(29)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnRemoteWindowDisplayed([In] bool vbDisplayed, [ComAliasName("MSTSCLib.wireHWND")] [In] ref _RemotableHandle hwnd, [ComAliasName("MSTSCLib.RemoteWindowDisplayedAttribute")] [In] RemoteWindowDisplayedAttribute windowAttribute);

		// Token: 0x06001B5A RID: 7002
		[DispId(22)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnLogonError([In] int lError);

		// Token: 0x06001B5B RID: 7003
		[DispId(23)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnFocusReleased([In] int iDirection);

		// Token: 0x06001B5C RID: 7004
		[DispId(24)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnUserNameAcquired([MarshalAs(UnmanagedType.BStr)] [In] string bstrUserName);

		// Token: 0x06001B5D RID: 7005
		[DispId(26)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnMouseInputModeChanged([In] bool fMouseModeRelative);

		// Token: 0x06001B5E RID: 7006
		[DispId(28)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnServiceMessageReceived([MarshalAs(UnmanagedType.BStr)] [In] string serviceMessage);

		// Token: 0x06001B5F RID: 7007
		[DispId(30)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnConnectionBarPullDown();

		// Token: 0x06001B60 RID: 7008
		[DispId(32)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnNetworkStatusChanged([In] uint qualityLevel, [In] int bandwidth, [In] int rtt);

		// Token: 0x06001B61 RID: 7009
		[DispId(35)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnDevicesButtonPressed();

		// Token: 0x06001B62 RID: 7010
		[DispId(33)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnAutoReconnected();

		// Token: 0x06001B63 RID: 7011
		[DispId(34)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnAutoReconnecting2([In] int disconnectReason, [In] bool networkAvailable, [In] int attemptCount, [In] int maxAttemptCount);
	}
}
