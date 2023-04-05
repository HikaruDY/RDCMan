using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x02000164 RID: 356
	[ComVisible(false)]
	[TypeLibType(16)]
	[ComEventInterface(typeof(IMsTscAxEvents), typeof(IMsTscAxEvents_EventProvider))]
	public interface IMsTscAxEvents_Event
	{
		// Token: 0x14000357 RID: 855
		// (add) Token: 0x06001C01 RID: 7169
		// (remove) Token: 0x06001C02 RID: 7170
		event IMsTscAxEvents_OnConnectingEventHandler OnConnecting;

		// Token: 0x14000358 RID: 856
		// (add) Token: 0x06001C03 RID: 7171
		// (remove) Token: 0x06001C04 RID: 7172
		event IMsTscAxEvents_OnConnectedEventHandler OnConnected;

		// Token: 0x14000359 RID: 857
		// (add) Token: 0x06001C05 RID: 7173
		// (remove) Token: 0x06001C06 RID: 7174
		event IMsTscAxEvents_OnLoginCompleteEventHandler OnLoginComplete;

		// Token: 0x1400035A RID: 858
		// (add) Token: 0x06001C07 RID: 7175
		// (remove) Token: 0x06001C08 RID: 7176
		event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		// Token: 0x1400035B RID: 859
		// (add) Token: 0x06001C09 RID: 7177
		// (remove) Token: 0x06001C0A RID: 7178
		event IMsTscAxEvents_OnEnterFullScreenModeEventHandler OnEnterFullScreenMode;

		// Token: 0x1400035C RID: 860
		// (add) Token: 0x06001C0B RID: 7179
		// (remove) Token: 0x06001C0C RID: 7180
		event IMsTscAxEvents_OnLeaveFullScreenModeEventHandler OnLeaveFullScreenMode;

		// Token: 0x1400035D RID: 861
		// (add) Token: 0x06001C0D RID: 7181
		// (remove) Token: 0x06001C0E RID: 7182
		event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

		// Token: 0x1400035E RID: 862
		// (add) Token: 0x06001C0F RID: 7183
		// (remove) Token: 0x06001C10 RID: 7184
		event IMsTscAxEvents_OnRequestGoFullScreenEventHandler OnRequestGoFullScreen;

		// Token: 0x1400035F RID: 863
		// (add) Token: 0x06001C11 RID: 7185
		// (remove) Token: 0x06001C12 RID: 7186
		event IMsTscAxEvents_OnRequestLeaveFullScreenEventHandler OnRequestLeaveFullScreen;

		// Token: 0x14000360 RID: 864
		// (add) Token: 0x06001C13 RID: 7187
		// (remove) Token: 0x06001C14 RID: 7188
		event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		// Token: 0x14000361 RID: 865
		// (add) Token: 0x06001C15 RID: 7189
		// (remove) Token: 0x06001C16 RID: 7190
		event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		// Token: 0x14000362 RID: 866
		// (add) Token: 0x06001C17 RID: 7191
		// (remove) Token: 0x06001C18 RID: 7192
		event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

		// Token: 0x14000363 RID: 867
		// (add) Token: 0x06001C19 RID: 7193
		// (remove) Token: 0x06001C1A RID: 7194
		event IMsTscAxEvents_OnIdleTimeoutNotificationEventHandler OnIdleTimeoutNotification;

		// Token: 0x14000364 RID: 868
		// (add) Token: 0x06001C1B RID: 7195
		// (remove) Token: 0x06001C1C RID: 7196
		event IMsTscAxEvents_OnRequestContainerMinimizeEventHandler OnRequestContainerMinimize;

		// Token: 0x14000365 RID: 869
		// (add) Token: 0x06001C1D RID: 7197
		// (remove) Token: 0x06001C1E RID: 7198
		event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

		// Token: 0x14000366 RID: 870
		// (add) Token: 0x06001C1F RID: 7199
		// (remove) Token: 0x06001C20 RID: 7200
		event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

		// Token: 0x14000367 RID: 871
		// (add) Token: 0x06001C21 RID: 7201
		// (remove) Token: 0x06001C22 RID: 7202
		event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

		// Token: 0x14000368 RID: 872
		// (add) Token: 0x06001C23 RID: 7203
		// (remove) Token: 0x06001C24 RID: 7204
		event IMsTscAxEvents_OnAuthenticationWarningDisplayedEventHandler OnAuthenticationWarningDisplayed;

		// Token: 0x14000369 RID: 873
		// (add) Token: 0x06001C25 RID: 7205
		// (remove) Token: 0x06001C26 RID: 7206
		event IMsTscAxEvents_OnAuthenticationWarningDismissedEventHandler OnAuthenticationWarningDismissed;

		// Token: 0x1400036A RID: 874
		// (add) Token: 0x06001C27 RID: 7207
		// (remove) Token: 0x06001C28 RID: 7208
		event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

		// Token: 0x1400036B RID: 875
		// (add) Token: 0x06001C29 RID: 7209
		// (remove) Token: 0x06001C2A RID: 7210
		event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

		// Token: 0x1400036C RID: 876
		// (add) Token: 0x06001C2B RID: 7211
		// (remove) Token: 0x06001C2C RID: 7212
		event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

		// Token: 0x1400036D RID: 877
		// (add) Token: 0x06001C2D RID: 7213
		// (remove) Token: 0x06001C2E RID: 7214
		event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

		// Token: 0x1400036E RID: 878
		// (add) Token: 0x06001C2F RID: 7215
		// (remove) Token: 0x06001C30 RID: 7216
		event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

		// Token: 0x1400036F RID: 879
		// (add) Token: 0x06001C31 RID: 7217
		// (remove) Token: 0x06001C32 RID: 7218
		event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

		// Token: 0x14000370 RID: 880
		// (add) Token: 0x06001C33 RID: 7219
		// (remove) Token: 0x06001C34 RID: 7220
		event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

		// Token: 0x14000371 RID: 881
		// (add) Token: 0x06001C35 RID: 7221
		// (remove) Token: 0x06001C36 RID: 7222
		event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

		// Token: 0x14000372 RID: 882
		// (add) Token: 0x06001C37 RID: 7223
		// (remove) Token: 0x06001C38 RID: 7224
		event IMsTscAxEvents_OnConnectionBarPullDownEventHandler OnConnectionBarPullDown;

		// Token: 0x14000373 RID: 883
		// (add) Token: 0x06001C39 RID: 7225
		// (remove) Token: 0x06001C3A RID: 7226
		event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

		// Token: 0x14000374 RID: 884
		// (add) Token: 0x06001C3B RID: 7227
		// (remove) Token: 0x06001C3C RID: 7228
		event IMsTscAxEvents_OnDevicesButtonPressedEventHandler OnDevicesButtonPressed;

		// Token: 0x14000375 RID: 885
		// (add) Token: 0x06001C3D RID: 7229
		// (remove) Token: 0x06001C3E RID: 7230
		event IMsTscAxEvents_OnAutoReconnectedEventHandler OnAutoReconnected;

		// Token: 0x14000376 RID: 886
		// (add) Token: 0x06001C3F RID: 7231
		// (remove) Token: 0x06001C40 RID: 7232
		event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;
	}
}
