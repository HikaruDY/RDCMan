using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace MSTSCLib
{
	// Token: 0x02000219 RID: 537
	internal sealed class IRemoteDesktopClientEvents_EventProvider : IRemoteDesktopClientEvents_Event, IDisposable
	{
		// Token: 0x0600558A RID: 21898 RVA: 0x0005B488 File Offset: 0x00059688
		private void Init()
		{
			IConnectionPoint connectionPoint = null;
			Guid guid = new Guid(new byte[]
			{
				183,
				99,
				152,
				7,
				71,
				109,
				5,
				65,
				139,
				254,
				12,
				220,
				179,
				96,
				230,
				125
			});
			this.m_ConnectionPointContainer.FindConnectionPoint(ref guid, out connectionPoint);
			this.m_ConnectionPoint = (IConnectionPoint)connectionPoint;
			this.m_aEventSinkHelpers = new ArrayList();
		}

		// Token: 0x0600558B RID: 21899 RVA: 0x0005B53C File Offset: 0x0005973C
		public void add_OnConnecting(IRemoteDesktopClientEvents_OnConnectingEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = new IRemoteDesktopClientEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)remoteDesktopClientEvents_SinkHelper, out dwCookie);
				remoteDesktopClientEvents_SinkHelper.m_dwCookie = dwCookie;
				remoteDesktopClientEvents_SinkHelper.m_OnConnectingDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)remoteDesktopClientEvents_SinkHelper);
			}
			finally
			{
				bool flag;
				if (flag)
				{
					Monitor.Exit(this);
				}
			}
		}

		// Token: 0x0600558C RID: 21900 RVA: 0x0005B5C0 File Offset: 0x000597C0
		public void remove_OnConnecting(IRemoteDesktopClientEvents_OnConnectingEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_aEventSinkHelpers != null)
				{
					int count = this.m_aEventSinkHelpers.Count;
					int num = 0;
					if (0 < count)
					{
						IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper;
						for (;;)
						{
							remoteDesktopClientEvents_SinkHelper = (IRemoteDesktopClientEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (remoteDesktopClientEvents_SinkHelper.m_OnConnectingDelegate != null && ((remoteDesktopClientEvents_SinkHelper.m_OnConnectingDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
							{
								break;
							}
							num++;
							if (num >= count)
							{
								goto IL_B1;
							}
						}
						this.m_aEventSinkHelpers.RemoveAt(num);
						this.m_ConnectionPoint.Unadvise(remoteDesktopClientEvents_SinkHelper.m_dwCookie);
						if (count <= 1)
						{
							Marshal.ReleaseComObject(this.m_ConnectionPoint);
							this.m_ConnectionPoint = null;
							this.m_aEventSinkHelpers = null;
						}
					}
				}
				IL_B1:;
			}
			finally
			{
				bool flag;
				if (flag)
				{
					Monitor.Exit(this);
				}
			}
		}

		// Token: 0x0600558D RID: 21901 RVA: 0x0005B6A0 File Offset: 0x000598A0
		public void add_OnConnected(IRemoteDesktopClientEvents_OnConnectedEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = new IRemoteDesktopClientEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)remoteDesktopClientEvents_SinkHelper, out dwCookie);
				remoteDesktopClientEvents_SinkHelper.m_dwCookie = dwCookie;
				remoteDesktopClientEvents_SinkHelper.m_OnConnectedDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)remoteDesktopClientEvents_SinkHelper);
			}
			finally
			{
				bool flag;
				if (flag)
				{
					Monitor.Exit(this);
				}
			}
		}

		// Token: 0x0600558E RID: 21902 RVA: 0x0005B724 File Offset: 0x00059924
		public void remove_OnConnected(IRemoteDesktopClientEvents_OnConnectedEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_aEventSinkHelpers != null)
				{
					int count = this.m_aEventSinkHelpers.Count;
					int num = 0;
					if (0 < count)
					{
						IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper;
						for (;;)
						{
							remoteDesktopClientEvents_SinkHelper = (IRemoteDesktopClientEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (remoteDesktopClientEvents_SinkHelper.m_OnConnectedDelegate != null && ((remoteDesktopClientEvents_SinkHelper.m_OnConnectedDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
							{
								break;
							}
							num++;
							if (num >= count)
							{
								goto IL_B1;
							}
						}
						this.m_aEventSinkHelpers.RemoveAt(num);
						this.m_ConnectionPoint.Unadvise(remoteDesktopClientEvents_SinkHelper.m_dwCookie);
						if (count <= 1)
						{
							Marshal.ReleaseComObject(this.m_ConnectionPoint);
							this.m_ConnectionPoint = null;
							this.m_aEventSinkHelpers = null;
						}
					}
				}
				IL_B1:;
			}
			finally
			{
				bool flag;
				if (flag)
				{
					Monitor.Exit(this);
				}
			}
		}

		// Token: 0x0600558F RID: 21903 RVA: 0x0005B804 File Offset: 0x00059A04
		public void add_OnLoginCompleted(IRemoteDesktopClientEvents_OnLoginCompletedEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = new IRemoteDesktopClientEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)remoteDesktopClientEvents_SinkHelper, out dwCookie);
				remoteDesktopClientEvents_SinkHelper.m_dwCookie = dwCookie;
				remoteDesktopClientEvents_SinkHelper.m_OnLoginCompletedDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)remoteDesktopClientEvents_SinkHelper);
			}
			finally
			{
				bool flag;
				if (flag)
				{
					Monitor.Exit(this);
				}
			}
		}

		// Token: 0x06005590 RID: 21904 RVA: 0x0005B888 File Offset: 0x00059A88
		public void remove_OnLoginCompleted(IRemoteDesktopClientEvents_OnLoginCompletedEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_aEventSinkHelpers != null)
				{
					int count = this.m_aEventSinkHelpers.Count;
					int num = 0;
					if (0 < count)
					{
						IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper;
						for (;;)
						{
							remoteDesktopClientEvents_SinkHelper = (IRemoteDesktopClientEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (remoteDesktopClientEvents_SinkHelper.m_OnLoginCompletedDelegate != null && ((remoteDesktopClientEvents_SinkHelper.m_OnLoginCompletedDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
							{
								break;
							}
							num++;
							if (num >= count)
							{
								goto IL_B1;
							}
						}
						this.m_aEventSinkHelpers.RemoveAt(num);
						this.m_ConnectionPoint.Unadvise(remoteDesktopClientEvents_SinkHelper.m_dwCookie);
						if (count <= 1)
						{
							Marshal.ReleaseComObject(this.m_ConnectionPoint);
							this.m_ConnectionPoint = null;
							this.m_aEventSinkHelpers = null;
						}
					}
				}
				IL_B1:;
			}
			finally
			{
				bool flag;
				if (flag)
				{
					Monitor.Exit(this);
				}
			}
		}

		// Token: 0x06005591 RID: 21905 RVA: 0x0005B968 File Offset: 0x00059B68
		public void add_OnDisconnected(IRemoteDesktopClientEvents_OnDisconnectedEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = new IRemoteDesktopClientEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)remoteDesktopClientEvents_SinkHelper, out dwCookie);
				remoteDesktopClientEvents_SinkHelper.m_dwCookie = dwCookie;
				remoteDesktopClientEvents_SinkHelper.m_OnDisconnectedDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)remoteDesktopClientEvents_SinkHelper);
			}
			finally
			{
				bool flag;
				if (flag)
				{
					Monitor.Exit(this);
				}
			}
		}

		// Token: 0x06005592 RID: 21906 RVA: 0x0005B9EC File Offset: 0x00059BEC
		public void remove_OnDisconnected(IRemoteDesktopClientEvents_OnDisconnectedEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_aEventSinkHelpers != null)
				{
					int count = this.m_aEventSinkHelpers.Count;
					int num = 0;
					if (0 < count)
					{
						IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper;
						for (;;)
						{
							remoteDesktopClientEvents_SinkHelper = (IRemoteDesktopClientEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (remoteDesktopClientEvents_SinkHelper.m_OnDisconnectedDelegate != null && ((remoteDesktopClientEvents_SinkHelper.m_OnDisconnectedDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
							{
								break;
							}
							num++;
							if (num >= count)
							{
								goto IL_B1;
							}
						}
						this.m_aEventSinkHelpers.RemoveAt(num);
						this.m_ConnectionPoint.Unadvise(remoteDesktopClientEvents_SinkHelper.m_dwCookie);
						if (count <= 1)
						{
							Marshal.ReleaseComObject(this.m_ConnectionPoint);
							this.m_ConnectionPoint = null;
							this.m_aEventSinkHelpers = null;
						}
					}
				}
				IL_B1:;
			}
			finally
			{
				bool flag;
				if (flag)
				{
					Monitor.Exit(this);
				}
			}
		}

		// Token: 0x06005593 RID: 21907 RVA: 0x0005BACC File Offset: 0x00059CCC
		public void add_OnStatusChanged(IRemoteDesktopClientEvents_OnStatusChangedEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = new IRemoteDesktopClientEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)remoteDesktopClientEvents_SinkHelper, out dwCookie);
				remoteDesktopClientEvents_SinkHelper.m_dwCookie = dwCookie;
				remoteDesktopClientEvents_SinkHelper.m_OnStatusChangedDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)remoteDesktopClientEvents_SinkHelper);
			}
			finally
			{
				bool flag;
				if (flag)
				{
					Monitor.Exit(this);
				}
			}
		}

		// Token: 0x06005594 RID: 21908 RVA: 0x0005BB50 File Offset: 0x00059D50
		public void remove_OnStatusChanged(IRemoteDesktopClientEvents_OnStatusChangedEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_aEventSinkHelpers != null)
				{
					int count = this.m_aEventSinkHelpers.Count;
					int num = 0;
					if (0 < count)
					{
						IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper;
						for (;;)
						{
							remoteDesktopClientEvents_SinkHelper = (IRemoteDesktopClientEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (remoteDesktopClientEvents_SinkHelper.m_OnStatusChangedDelegate != null && ((remoteDesktopClientEvents_SinkHelper.m_OnStatusChangedDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
							{
								break;
							}
							num++;
							if (num >= count)
							{
								goto IL_B1;
							}
						}
						this.m_aEventSinkHelpers.RemoveAt(num);
						this.m_ConnectionPoint.Unadvise(remoteDesktopClientEvents_SinkHelper.m_dwCookie);
						if (count <= 1)
						{
							Marshal.ReleaseComObject(this.m_ConnectionPoint);
							this.m_ConnectionPoint = null;
							this.m_aEventSinkHelpers = null;
						}
					}
				}
				IL_B1:;
			}
			finally
			{
				bool flag;
				if (flag)
				{
					Monitor.Exit(this);
				}
			}
		}

		// Token: 0x06005595 RID: 21909 RVA: 0x0005BC30 File Offset: 0x00059E30
		public void add_OnAutoReconnecting(IRemoteDesktopClientEvents_OnAutoReconnectingEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = new IRemoteDesktopClientEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)remoteDesktopClientEvents_SinkHelper, out dwCookie);
				remoteDesktopClientEvents_SinkHelper.m_dwCookie = dwCookie;
				remoteDesktopClientEvents_SinkHelper.m_OnAutoReconnectingDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)remoteDesktopClientEvents_SinkHelper);
			}
			finally
			{
				bool flag;
				if (flag)
				{
					Monitor.Exit(this);
				}
			}
		}

		// Token: 0x06005596 RID: 21910 RVA: 0x0005BCB4 File Offset: 0x00059EB4
		public void remove_OnAutoReconnecting(IRemoteDesktopClientEvents_OnAutoReconnectingEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_aEventSinkHelpers != null)
				{
					int count = this.m_aEventSinkHelpers.Count;
					int num = 0;
					if (0 < count)
					{
						IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper;
						for (;;)
						{
							remoteDesktopClientEvents_SinkHelper = (IRemoteDesktopClientEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (remoteDesktopClientEvents_SinkHelper.m_OnAutoReconnectingDelegate != null && ((remoteDesktopClientEvents_SinkHelper.m_OnAutoReconnectingDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
							{
								break;
							}
							num++;
							if (num >= count)
							{
								goto IL_B1;
							}
						}
						this.m_aEventSinkHelpers.RemoveAt(num);
						this.m_ConnectionPoint.Unadvise(remoteDesktopClientEvents_SinkHelper.m_dwCookie);
						if (count <= 1)
						{
							Marshal.ReleaseComObject(this.m_ConnectionPoint);
							this.m_ConnectionPoint = null;
							this.m_aEventSinkHelpers = null;
						}
					}
				}
				IL_B1:;
			}
			finally
			{
				bool flag;
				if (flag)
				{
					Monitor.Exit(this);
				}
			}
		}

		// Token: 0x06005597 RID: 21911 RVA: 0x0005BD94 File Offset: 0x00059F94
		public void add_OnAutoReconnected(IRemoteDesktopClientEvents_OnAutoReconnectedEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = new IRemoteDesktopClientEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)remoteDesktopClientEvents_SinkHelper, out dwCookie);
				remoteDesktopClientEvents_SinkHelper.m_dwCookie = dwCookie;
				remoteDesktopClientEvents_SinkHelper.m_OnAutoReconnectedDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)remoteDesktopClientEvents_SinkHelper);
			}
			finally
			{
				bool flag;
				if (flag)
				{
					Monitor.Exit(this);
				}
			}
		}

		// Token: 0x06005598 RID: 21912 RVA: 0x0005BE18 File Offset: 0x0005A018
		public void remove_OnAutoReconnected(IRemoteDesktopClientEvents_OnAutoReconnectedEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_aEventSinkHelpers != null)
				{
					int count = this.m_aEventSinkHelpers.Count;
					int num = 0;
					if (0 < count)
					{
						IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper;
						for (;;)
						{
							remoteDesktopClientEvents_SinkHelper = (IRemoteDesktopClientEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (remoteDesktopClientEvents_SinkHelper.m_OnAutoReconnectedDelegate != null && ((remoteDesktopClientEvents_SinkHelper.m_OnAutoReconnectedDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
							{
								break;
							}
							num++;
							if (num >= count)
							{
								goto IL_B1;
							}
						}
						this.m_aEventSinkHelpers.RemoveAt(num);
						this.m_ConnectionPoint.Unadvise(remoteDesktopClientEvents_SinkHelper.m_dwCookie);
						if (count <= 1)
						{
							Marshal.ReleaseComObject(this.m_ConnectionPoint);
							this.m_ConnectionPoint = null;
							this.m_aEventSinkHelpers = null;
						}
					}
				}
				IL_B1:;
			}
			finally
			{
				bool flag;
				if (flag)
				{
					Monitor.Exit(this);
				}
			}
		}

		// Token: 0x06005599 RID: 21913 RVA: 0x0005BEF8 File Offset: 0x0005A0F8
		public void add_OnDialogDisplaying(IRemoteDesktopClientEvents_OnDialogDisplayingEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = new IRemoteDesktopClientEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)remoteDesktopClientEvents_SinkHelper, out dwCookie);
				remoteDesktopClientEvents_SinkHelper.m_dwCookie = dwCookie;
				remoteDesktopClientEvents_SinkHelper.m_OnDialogDisplayingDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)remoteDesktopClientEvents_SinkHelper);
			}
			finally
			{
				bool flag;
				if (flag)
				{
					Monitor.Exit(this);
				}
			}
		}

		// Token: 0x0600559A RID: 21914 RVA: 0x0005BF7C File Offset: 0x0005A17C
		public void remove_OnDialogDisplaying(IRemoteDesktopClientEvents_OnDialogDisplayingEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_aEventSinkHelpers != null)
				{
					int count = this.m_aEventSinkHelpers.Count;
					int num = 0;
					if (0 < count)
					{
						IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper;
						for (;;)
						{
							remoteDesktopClientEvents_SinkHelper = (IRemoteDesktopClientEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (remoteDesktopClientEvents_SinkHelper.m_OnDialogDisplayingDelegate != null && ((remoteDesktopClientEvents_SinkHelper.m_OnDialogDisplayingDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
							{
								break;
							}
							num++;
							if (num >= count)
							{
								goto IL_B1;
							}
						}
						this.m_aEventSinkHelpers.RemoveAt(num);
						this.m_ConnectionPoint.Unadvise(remoteDesktopClientEvents_SinkHelper.m_dwCookie);
						if (count <= 1)
						{
							Marshal.ReleaseComObject(this.m_ConnectionPoint);
							this.m_ConnectionPoint = null;
							this.m_aEventSinkHelpers = null;
						}
					}
				}
				IL_B1:;
			}
			finally
			{
				bool flag;
				if (flag)
				{
					Monitor.Exit(this);
				}
			}
		}

		// Token: 0x0600559B RID: 21915 RVA: 0x0005C05C File Offset: 0x0005A25C
		public void add_OnDialogDismissed(IRemoteDesktopClientEvents_OnDialogDismissedEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = new IRemoteDesktopClientEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)remoteDesktopClientEvents_SinkHelper, out dwCookie);
				remoteDesktopClientEvents_SinkHelper.m_dwCookie = dwCookie;
				remoteDesktopClientEvents_SinkHelper.m_OnDialogDismissedDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)remoteDesktopClientEvents_SinkHelper);
			}
			finally
			{
				bool flag;
				if (flag)
				{
					Monitor.Exit(this);
				}
			}
		}

		// Token: 0x0600559C RID: 21916 RVA: 0x0005C0E0 File Offset: 0x0005A2E0
		public void remove_OnDialogDismissed(IRemoteDesktopClientEvents_OnDialogDismissedEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_aEventSinkHelpers != null)
				{
					int count = this.m_aEventSinkHelpers.Count;
					int num = 0;
					if (0 < count)
					{
						IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper;
						for (;;)
						{
							remoteDesktopClientEvents_SinkHelper = (IRemoteDesktopClientEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (remoteDesktopClientEvents_SinkHelper.m_OnDialogDismissedDelegate != null && ((remoteDesktopClientEvents_SinkHelper.m_OnDialogDismissedDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
							{
								break;
							}
							num++;
							if (num >= count)
							{
								goto IL_B1;
							}
						}
						this.m_aEventSinkHelpers.RemoveAt(num);
						this.m_ConnectionPoint.Unadvise(remoteDesktopClientEvents_SinkHelper.m_dwCookie);
						if (count <= 1)
						{
							Marshal.ReleaseComObject(this.m_ConnectionPoint);
							this.m_ConnectionPoint = null;
							this.m_aEventSinkHelpers = null;
						}
					}
				}
				IL_B1:;
			}
			finally
			{
				bool flag;
				if (flag)
				{
					Monitor.Exit(this);
				}
			}
		}

		// Token: 0x0600559D RID: 21917 RVA: 0x0005C1C0 File Offset: 0x0005A3C0
		public void add_OnNetworkStatusChanged(IRemoteDesktopClientEvents_OnNetworkStatusChangedEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = new IRemoteDesktopClientEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)remoteDesktopClientEvents_SinkHelper, out dwCookie);
				remoteDesktopClientEvents_SinkHelper.m_dwCookie = dwCookie;
				remoteDesktopClientEvents_SinkHelper.m_OnNetworkStatusChangedDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)remoteDesktopClientEvents_SinkHelper);
			}
			finally
			{
				bool flag;
				if (flag)
				{
					Monitor.Exit(this);
				}
			}
		}

		// Token: 0x0600559E RID: 21918 RVA: 0x0005C244 File Offset: 0x0005A444
		public void remove_OnNetworkStatusChanged(IRemoteDesktopClientEvents_OnNetworkStatusChangedEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_aEventSinkHelpers != null)
				{
					int count = this.m_aEventSinkHelpers.Count;
					int num = 0;
					if (0 < count)
					{
						IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper;
						for (;;)
						{
							remoteDesktopClientEvents_SinkHelper = (IRemoteDesktopClientEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (remoteDesktopClientEvents_SinkHelper.m_OnNetworkStatusChangedDelegate != null && ((remoteDesktopClientEvents_SinkHelper.m_OnNetworkStatusChangedDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
							{
								break;
							}
							num++;
							if (num >= count)
							{
								goto IL_B1;
							}
						}
						this.m_aEventSinkHelpers.RemoveAt(num);
						this.m_ConnectionPoint.Unadvise(remoteDesktopClientEvents_SinkHelper.m_dwCookie);
						if (count <= 1)
						{
							Marshal.ReleaseComObject(this.m_ConnectionPoint);
							this.m_ConnectionPoint = null;
							this.m_aEventSinkHelpers = null;
						}
					}
				}
				IL_B1:;
			}
			finally
			{
				bool flag;
				if (flag)
				{
					Monitor.Exit(this);
				}
			}
		}

		// Token: 0x0600559F RID: 21919 RVA: 0x0005C324 File Offset: 0x0005A524
		public void add_OnAdminMessageReceived(IRemoteDesktopClientEvents_OnAdminMessageReceivedEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = new IRemoteDesktopClientEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)remoteDesktopClientEvents_SinkHelper, out dwCookie);
				remoteDesktopClientEvents_SinkHelper.m_dwCookie = dwCookie;
				remoteDesktopClientEvents_SinkHelper.m_OnAdminMessageReceivedDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)remoteDesktopClientEvents_SinkHelper);
			}
			finally
			{
				bool flag;
				if (flag)
				{
					Monitor.Exit(this);
				}
			}
		}

		// Token: 0x060055A0 RID: 21920 RVA: 0x0005C3A8 File Offset: 0x0005A5A8
		public void remove_OnAdminMessageReceived(IRemoteDesktopClientEvents_OnAdminMessageReceivedEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_aEventSinkHelpers != null)
				{
					int count = this.m_aEventSinkHelpers.Count;
					int num = 0;
					if (0 < count)
					{
						IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper;
						for (;;)
						{
							remoteDesktopClientEvents_SinkHelper = (IRemoteDesktopClientEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (remoteDesktopClientEvents_SinkHelper.m_OnAdminMessageReceivedDelegate != null && ((remoteDesktopClientEvents_SinkHelper.m_OnAdminMessageReceivedDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
							{
								break;
							}
							num++;
							if (num >= count)
							{
								goto IL_B1;
							}
						}
						this.m_aEventSinkHelpers.RemoveAt(num);
						this.m_ConnectionPoint.Unadvise(remoteDesktopClientEvents_SinkHelper.m_dwCookie);
						if (count <= 1)
						{
							Marshal.ReleaseComObject(this.m_ConnectionPoint);
							this.m_ConnectionPoint = null;
							this.m_aEventSinkHelpers = null;
						}
					}
				}
				IL_B1:;
			}
			finally
			{
				bool flag;
				if (flag)
				{
					Monitor.Exit(this);
				}
			}
		}

		// Token: 0x060055A1 RID: 21921 RVA: 0x0005C488 File Offset: 0x0005A688
		public void add_OnKeyCombinationPressed(IRemoteDesktopClientEvents_OnKeyCombinationPressedEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = new IRemoteDesktopClientEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)remoteDesktopClientEvents_SinkHelper, out dwCookie);
				remoteDesktopClientEvents_SinkHelper.m_dwCookie = dwCookie;
				remoteDesktopClientEvents_SinkHelper.m_OnKeyCombinationPressedDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)remoteDesktopClientEvents_SinkHelper);
			}
			finally
			{
				bool flag;
				if (flag)
				{
					Monitor.Exit(this);
				}
			}
		}

		// Token: 0x060055A2 RID: 21922 RVA: 0x0005C50C File Offset: 0x0005A70C
		public void remove_OnKeyCombinationPressed(IRemoteDesktopClientEvents_OnKeyCombinationPressedEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_aEventSinkHelpers != null)
				{
					int count = this.m_aEventSinkHelpers.Count;
					int num = 0;
					if (0 < count)
					{
						IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper;
						for (;;)
						{
							remoteDesktopClientEvents_SinkHelper = (IRemoteDesktopClientEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (remoteDesktopClientEvents_SinkHelper.m_OnKeyCombinationPressedDelegate != null && ((remoteDesktopClientEvents_SinkHelper.m_OnKeyCombinationPressedDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
							{
								break;
							}
							num++;
							if (num >= count)
							{
								goto IL_B1;
							}
						}
						this.m_aEventSinkHelpers.RemoveAt(num);
						this.m_ConnectionPoint.Unadvise(remoteDesktopClientEvents_SinkHelper.m_dwCookie);
						if (count <= 1)
						{
							Marshal.ReleaseComObject(this.m_ConnectionPoint);
							this.m_ConnectionPoint = null;
							this.m_aEventSinkHelpers = null;
						}
					}
				}
				IL_B1:;
			}
			finally
			{
				bool flag;
				if (flag)
				{
					Monitor.Exit(this);
				}
			}
		}

		// Token: 0x060055A3 RID: 21923 RVA: 0x0005C5EC File Offset: 0x0005A7EC
		public void add_OnRemoteDesktopSizeChanged(IRemoteDesktopClientEvents_OnRemoteDesktopSizeChangedEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = new IRemoteDesktopClientEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)remoteDesktopClientEvents_SinkHelper, out dwCookie);
				remoteDesktopClientEvents_SinkHelper.m_dwCookie = dwCookie;
				remoteDesktopClientEvents_SinkHelper.m_OnRemoteDesktopSizeChangedDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)remoteDesktopClientEvents_SinkHelper);
			}
			finally
			{
				bool flag;
				if (flag)
				{
					Monitor.Exit(this);
				}
			}
		}

		// Token: 0x060055A4 RID: 21924 RVA: 0x0005C670 File Offset: 0x0005A870
		public void remove_OnRemoteDesktopSizeChanged(IRemoteDesktopClientEvents_OnRemoteDesktopSizeChangedEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_aEventSinkHelpers != null)
				{
					int count = this.m_aEventSinkHelpers.Count;
					int num = 0;
					if (0 < count)
					{
						IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper;
						for (;;)
						{
							remoteDesktopClientEvents_SinkHelper = (IRemoteDesktopClientEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (remoteDesktopClientEvents_SinkHelper.m_OnRemoteDesktopSizeChangedDelegate != null && ((remoteDesktopClientEvents_SinkHelper.m_OnRemoteDesktopSizeChangedDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
							{
								break;
							}
							num++;
							if (num >= count)
							{
								goto IL_B1;
							}
						}
						this.m_aEventSinkHelpers.RemoveAt(num);
						this.m_ConnectionPoint.Unadvise(remoteDesktopClientEvents_SinkHelper.m_dwCookie);
						if (count <= 1)
						{
							Marshal.ReleaseComObject(this.m_ConnectionPoint);
							this.m_ConnectionPoint = null;
							this.m_aEventSinkHelpers = null;
						}
					}
				}
				IL_B1:;
			}
			finally
			{
				bool flag;
				if (flag)
				{
					Monitor.Exit(this);
				}
			}
		}

		// Token: 0x060055A5 RID: 21925 RVA: 0x0005C750 File Offset: 0x0005A950
		public void add_OnTouchPointerCursorMoved(IRemoteDesktopClientEvents_OnTouchPointerCursorMovedEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = new IRemoteDesktopClientEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)remoteDesktopClientEvents_SinkHelper, out dwCookie);
				remoteDesktopClientEvents_SinkHelper.m_dwCookie = dwCookie;
				remoteDesktopClientEvents_SinkHelper.m_OnTouchPointerCursorMovedDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)remoteDesktopClientEvents_SinkHelper);
			}
			finally
			{
				bool flag;
				if (flag)
				{
					Monitor.Exit(this);
				}
			}
		}

		// Token: 0x060055A6 RID: 21926 RVA: 0x0005C7D4 File Offset: 0x0005A9D4
		public void remove_OnTouchPointerCursorMoved(IRemoteDesktopClientEvents_OnTouchPointerCursorMovedEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_aEventSinkHelpers != null)
				{
					int count = this.m_aEventSinkHelpers.Count;
					int num = 0;
					if (0 < count)
					{
						IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper;
						for (;;)
						{
							remoteDesktopClientEvents_SinkHelper = (IRemoteDesktopClientEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (remoteDesktopClientEvents_SinkHelper.m_OnTouchPointerCursorMovedDelegate != null && ((remoteDesktopClientEvents_SinkHelper.m_OnTouchPointerCursorMovedDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
							{
								break;
							}
							num++;
							if (num >= count)
							{
								goto IL_B1;
							}
						}
						this.m_aEventSinkHelpers.RemoveAt(num);
						this.m_ConnectionPoint.Unadvise(remoteDesktopClientEvents_SinkHelper.m_dwCookie);
						if (count <= 1)
						{
							Marshal.ReleaseComObject(this.m_ConnectionPoint);
							this.m_ConnectionPoint = null;
							this.m_aEventSinkHelpers = null;
						}
					}
				}
				IL_B1:;
			}
			finally
			{
				bool flag;
				if (flag)
				{
					Monitor.Exit(this);
				}
			}
		}

		// Token: 0x060055A7 RID: 21927 RVA: 0x0005C8B4 File Offset: 0x0005AAB4
		public IRemoteDesktopClientEvents_EventProvider(object A_1)
		{
			this.m_ConnectionPointContainer = (IConnectionPointContainer)A_1;
		}

		// Token: 0x060055A8 RID: 21928 RVA: 0x0005C8C8 File Offset: 0x0005AAC8
		public override void Finalize()
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint != null)
				{
					int count = this.m_aEventSinkHelpers.Count;
					int num = 0;
					if (0 < count)
					{
						do
						{
							IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = (IRemoteDesktopClientEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							this.m_ConnectionPoint.Unadvise(remoteDesktopClientEvents_SinkHelper.m_dwCookie);
							num++;
						}
						while (num < count);
					}
					Marshal.ReleaseComObject(this.m_ConnectionPoint);
				}
			}
			catch (Exception)
			{
			}
			finally
			{
				bool flag;
				if (flag)
				{
					Monitor.Exit(this);
				}
			}
		}

		// Token: 0x060055A9 RID: 21929 RVA: 0x0005C970 File Offset: 0x0005AB70
		public void Dispose()
		{
			this.Finalize();
			GC.SuppressFinalize(this);
		}

		// Token: 0x0400081A RID: 2074
		private IConnectionPointContainer m_ConnectionPointContainer;

		// Token: 0x0400081B RID: 2075
		private ArrayList m_aEventSinkHelpers;

		// Token: 0x0400081C RID: 2076
		private IConnectionPoint m_ConnectionPoint;
	}
}
