using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[InterfaceType(2)]
	[TypeLibType(4096)]
	[Guid("336D5562-EFA8-482E-8CB3-C5C0FC7A7DB6")]
	[ComVisible(true)]
	[ComImport]
	public interface IMsTscAxEvents
	{
		[DispId(1)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnConnecting();

		[DispId(2)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnConnected();

		[DispId(3)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnLoginComplete();

		[DispId(4)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnDisconnected([In] int discReason);

		[DispId(5)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnEnterFullScreenMode();

		[DispId(6)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnLeaveFullScreenMode();

		[DispId(7)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnChannelReceivedData([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string data);

		[DispId(8)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnRequestGoFullScreen();

		[DispId(9)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnRequestLeaveFullScreen();

		[DispId(10)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnFatalError([In] int errorCode);

		[DispId(11)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnWarning([In] int warningCode);

		[DispId(12)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnRemoteDesktopSizeChange([In] int width, [In] int height);

		[DispId(13)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnIdleTimeoutNotification();

		[DispId(14)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnRequestContainerMinimize();

		[DispId(15)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnConfirmClose(out bool pfAllowClose);

		[DispId(16)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnReceivedTSPublicKey([MarshalAs(UnmanagedType.BStr)] [In] string publicKey, out bool pfContinueLogon);

		[DispId(17)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnAutoReconnecting([In] int disconnectReason, [In] int attemptCount, [ComAliasName("MSTSCLib.AutoReconnectContinueState")] out AutoReconnectContinueState pArcContinueStatus);

		[DispId(18)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnAuthenticationWarningDisplayed();

		[DispId(19)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnAuthenticationWarningDismissed();

		[DispId(20)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnRemoteProgramResult([MarshalAs(UnmanagedType.BStr)] [In] string bstrRemoteProgram, [ComAliasName("MSTSCLib.RemoteProgramResult")] [In] RemoteProgramResult lError, [In] bool vbIsExecutable);

		[DispId(21)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnRemoteProgramDisplayed([In] bool vbDisplayed, [In] uint uDisplayInformation);

		[DispId(29)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnRemoteWindowDisplayed([In] bool vbDisplayed, [ComAliasName("MSTSCLib.wireHWND")] [In] ref _RemotableHandle hwnd, [ComAliasName("MSTSCLib.RemoteWindowDisplayedAttribute")] [In] RemoteWindowDisplayedAttribute windowAttribute);

		[DispId(22)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnLogonError([In] int lError);

		[DispId(23)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnFocusReleased([In] int iDirection);

		[DispId(24)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnUserNameAcquired([MarshalAs(UnmanagedType.BStr)] [In] string bstrUserName);

		[DispId(26)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnMouseInputModeChanged([In] bool fMouseModeRelative);

		[DispId(28)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnServiceMessageReceived([MarshalAs(UnmanagedType.BStr)] [In] string serviceMessage);

		[DispId(30)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnConnectionBarPullDown();

		[DispId(32)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnNetworkStatusChanged([In] uint qualityLevel, [In] int bandwidth, [In] int rtt);

		[DispId(35)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnDevicesButtonPressed();

		[DispId(33)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnAutoReconnected();

		[DispId(34)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OnAutoReconnecting2([In] int disconnectReason, [In] bool networkAvailable, [In] int attemptCount, [In] int maxAttemptCount);
	}
}
