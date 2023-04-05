using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[ClassInterface(0)]
	[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0")]
	[Guid("791FA017-2DE3-492E-ACC5-53C67A2B94D0")]
	[ComVisible(true)]
	[ComImport]
	public class MsRdpClientClass : IMsRdpClient, MsRdpClient, IMsTscAxEvents_Event, IMsTscAx, IMsTscAx_Redist, IMsTscNonScriptable, IMsRdpClientNonScriptable
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern MsRdpClientClass();

		[DispId(1)]
		public virtual extern string Server { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		[DispId(2)]
		public virtual extern string Domain { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		[DispId(3)]
		public virtual extern string UserName { [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		[DispId(4)]
		public virtual extern string DisconnectedText { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		[DispId(5)]
		public virtual extern string ConnectingText { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		[DispId(6)]
		public virtual extern short Connected { [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		[DispId(12)]
		public virtual extern int DesktopWidth { [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(13)]
		public virtual extern int DesktopHeight { [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(16)]
		public virtual extern int StartConnected { [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(17)]
		public virtual extern int HorizontalScrollBarVisible { [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		[DispId(18)]
		public virtual extern int VerticalScrollBarVisible { [DispId(18)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		[DispId(19)]
		public virtual extern string FullScreenTitle { [DispId(19)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		[DispId(20)]
		public virtual extern int CipherStrength { [DispId(20)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		[DispId(21)]
		public virtual extern string Version { [DispId(21)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		[DispId(22)]
		public virtual extern int SecuredSettingsEnabled { [DispId(22)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		[DispId(97)]
		public virtual extern IMsTscSecuredSettings SecuredSettings { [DispId(97)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		[DispId(98)]
		public virtual extern IMsTscAdvancedSettings AdvancedSettings { [DispId(98)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		[DispId(99)]
		public virtual extern IMsTscDebug Debugger { [DispId(99)] [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		[DispId(30)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Connect();

		[DispId(31)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Disconnect();

		[DispId(33)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		[DispId(34)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		[DispId(100)]
		public virtual extern int ColorDepth { [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(101)]
		public virtual extern IMsRdpClientAdvancedSettings AdvancedSettings2 { [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		[DispId(102)]
		public virtual extern IMsRdpClientSecuredSettings SecuredSettings2 { [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		[DispId(103)]
		[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		public virtual extern ExtendedDisconnectReasonCode ExtendedDisconnectReason { [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] [return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")] get; }

		[DispId(104)]
		public virtual extern bool FullScreen { [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		[DispId(35)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [In] int chanOptions);

		[DispId(36)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] [In] string chanName);

		[DispId(37)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
		public virtual extern ControlCloseStatus RequestClose();

		public virtual extern string IMsTscAx_Server { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		public virtual extern string IMsTscAx_Domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		public virtual extern string IMsTscAx_UserName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		public virtual extern string IMsTscAx_DisconnectedText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		public virtual extern string IMsTscAx_ConnectingText { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		public virtual extern short IMsTscAx_Connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		public virtual extern int IMsTscAx_DesktopWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		public virtual extern int IMsTscAx_DesktopHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		public virtual extern int IMsTscAx_StartConnected { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		public virtual extern int IMsTscAx_HorizontalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		public virtual extern int IMsTscAx_VerticalScrollBarVisible { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		public virtual extern string IMsTscAx_FullScreenTitle { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		public virtual extern int IMsTscAx_CipherStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		public virtual extern string IMsTscAx_Version { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		public virtual extern int IMsTscAx_SecuredSettingsEnabled { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		public virtual extern IMsTscSecuredSettings IMsTscAx_SecuredSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		public virtual extern IMsTscAdvancedSettings IMsTscAx_AdvancedSettings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		public virtual extern IMsTscDebug IMsTscAx_Debugger { [TypeLibFunc(64)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_Connect();

		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_Disconnect();

		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsTscAx_SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] [In] string chanName, [MarshalAs(UnmanagedType.BStr)] [In] string ChanData);

		public virtual extern string ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		public virtual extern string PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		public virtual extern string PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		public virtual extern string BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		public virtual extern string BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void ResetPassword();

		public virtual extern string IMsRdpClientNonScriptable_ClearTextPassword { [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		public virtual extern string IMsRdpClientNonScriptable_PortablePassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		public virtual extern string IMsRdpClientNonScriptable_PortableSalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		public virtual extern string IMsRdpClientNonScriptable_BinaryPassword { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		public virtual extern string IMsRdpClientNonScriptable_BinarySalt { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void IMsRdpClientNonScriptable_ResetPassword();

		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void NotifyRedirectDeviceChange([ComAliasName("MSTSCLib.UINT_PTR")] [In] ulong wParam, [ComAliasName("MSTSCLib.LONG_PTR")] [In] long lParam);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

		public virtual extern event IMsTscAxEvents_OnConnectingEventHandler OnConnecting;

		public virtual extern event IMsTscAxEvents_OnConnectedEventHandler OnConnected;

		public virtual extern event IMsTscAxEvents_OnLoginCompleteEventHandler OnLoginComplete;

		public virtual extern event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		public virtual extern event IMsTscAxEvents_OnEnterFullScreenModeEventHandler OnEnterFullScreenMode;

		public virtual extern event IMsTscAxEvents_OnLeaveFullScreenModeEventHandler OnLeaveFullScreenMode;

		public virtual extern event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		public virtual extern event IMsTscAxEvents_OnRequestGoFullScreenEventHandler OnRequestGoFullScreen;

		public virtual extern event IMsTscAxEvents_OnRequestLeaveFullScreenEventHandler OnRequestLeaveFullScreen;

		public virtual extern event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		public virtual extern event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		public virtual extern event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		public virtual extern event IMsTscAxEvents_OnIdleTimeoutNotificationEventHandler OnIdleTimeoutNotification;

		public virtual extern event IMsTscAxEvents_OnRequestContainerMinimizeEventHandler OnRequestContainerMinimize;

		public virtual extern event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		public virtual extern event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		public virtual extern event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		public virtual extern event IMsTscAxEvents_OnAuthenticationWarningDisplayedEventHandler OnAuthenticationWarningDisplayed;

		public virtual extern event IMsTscAxEvents_OnAuthenticationWarningDismissedEventHandler OnAuthenticationWarningDismissed;

		public virtual extern event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		public virtual extern event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		public virtual extern event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		public virtual extern event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		public virtual extern event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		public virtual extern event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		public virtual extern event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		public virtual extern event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		public virtual extern event IMsTscAxEvents_OnConnectionBarPullDownEventHandler OnConnectionBarPullDown;

		public virtual extern event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		public virtual extern event IMsTscAxEvents_OnDevicesButtonPressedEventHandler OnDevicesButtonPressed;

		public virtual extern event IMsTscAxEvents_OnAutoReconnectedEventHandler OnAutoReconnected;

		public virtual extern event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;
	}
}
