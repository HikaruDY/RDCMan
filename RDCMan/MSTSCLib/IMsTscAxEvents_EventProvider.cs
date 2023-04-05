using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace MSTSCLib
{
	// Token: 0x02000217 RID: 535
	internal sealed class IMsTscAxEvents_EventProvider : IMsTscAxEvents_Event, IDisposable
	{
		// Token: 0x06005537 RID: 21815 RVA: 0x00058474 File Offset: 0x00056674
		private void Init()
		{
			IConnectionPoint connectionPoint = null;
			Guid guid = new Guid(new byte[]
			{
				98,
				85,
				109,
				51,
				168,
				239,
				46,
				72,
				140,
				179,
				197,
				192,
				252,
				122,
				125,
				182
			});
			this.m_ConnectionPointContainer.FindConnectionPoint(ref guid, out connectionPoint);
			this.m_ConnectionPoint = (IConnectionPoint)connectionPoint;
			this.m_aEventSinkHelpers = new ArrayList();
		}

		// Token: 0x06005538 RID: 21816 RVA: 0x0005852C File Offset: 0x0005672C
		public void add_OnConnecting(IMsTscAxEvents_OnConnectingEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)msTscAxEvents_SinkHelper, out dwCookie);
				msTscAxEvents_SinkHelper.m_dwCookie = dwCookie;
				msTscAxEvents_SinkHelper.m_OnConnectingDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)msTscAxEvents_SinkHelper);
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

		// Token: 0x06005539 RID: 21817 RVA: 0x000585B0 File Offset: 0x000567B0
		public void remove_OnConnecting(IMsTscAxEvents_OnConnectingEventHandler A_1)
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
						IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper;
						for (;;)
						{
							msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (msTscAxEvents_SinkHelper.m_OnConnectingDelegate != null && ((msTscAxEvents_SinkHelper.m_OnConnectingDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
						this.m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x0600553A RID: 21818 RVA: 0x00058690 File Offset: 0x00056890
		public void add_OnConnected(IMsTscAxEvents_OnConnectedEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)msTscAxEvents_SinkHelper, out dwCookie);
				msTscAxEvents_SinkHelper.m_dwCookie = dwCookie;
				msTscAxEvents_SinkHelper.m_OnConnectedDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)msTscAxEvents_SinkHelper);
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

		// Token: 0x0600553B RID: 21819 RVA: 0x00058714 File Offset: 0x00056914
		public void remove_OnConnected(IMsTscAxEvents_OnConnectedEventHandler A_1)
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
						IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper;
						for (;;)
						{
							msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (msTscAxEvents_SinkHelper.m_OnConnectedDelegate != null && ((msTscAxEvents_SinkHelper.m_OnConnectedDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
						this.m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x0600553C RID: 21820 RVA: 0x000587F4 File Offset: 0x000569F4
		public void add_OnLoginComplete(IMsTscAxEvents_OnLoginCompleteEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)msTscAxEvents_SinkHelper, out dwCookie);
				msTscAxEvents_SinkHelper.m_dwCookie = dwCookie;
				msTscAxEvents_SinkHelper.m_OnLoginCompleteDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)msTscAxEvents_SinkHelper);
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

		// Token: 0x0600553D RID: 21821 RVA: 0x00058878 File Offset: 0x00056A78
		public void remove_OnLoginComplete(IMsTscAxEvents_OnLoginCompleteEventHandler A_1)
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
						IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper;
						for (;;)
						{
							msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (msTscAxEvents_SinkHelper.m_OnLoginCompleteDelegate != null && ((msTscAxEvents_SinkHelper.m_OnLoginCompleteDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
						this.m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x0600553E RID: 21822 RVA: 0x00058958 File Offset: 0x00056B58
		public void add_OnDisconnected(IMsTscAxEvents_OnDisconnectedEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)msTscAxEvents_SinkHelper, out dwCookie);
				msTscAxEvents_SinkHelper.m_dwCookie = dwCookie;
				msTscAxEvents_SinkHelper.m_OnDisconnectedDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)msTscAxEvents_SinkHelper);
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

		// Token: 0x0600553F RID: 21823 RVA: 0x000589DC File Offset: 0x00056BDC
		public void remove_OnDisconnected(IMsTscAxEvents_OnDisconnectedEventHandler A_1)
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
						IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper;
						for (;;)
						{
							msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (msTscAxEvents_SinkHelper.m_OnDisconnectedDelegate != null && ((msTscAxEvents_SinkHelper.m_OnDisconnectedDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
						this.m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x06005540 RID: 21824 RVA: 0x00058ABC File Offset: 0x00056CBC
		public void add_OnEnterFullScreenMode(IMsTscAxEvents_OnEnterFullScreenModeEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)msTscAxEvents_SinkHelper, out dwCookie);
				msTscAxEvents_SinkHelper.m_dwCookie = dwCookie;
				msTscAxEvents_SinkHelper.m_OnEnterFullScreenModeDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)msTscAxEvents_SinkHelper);
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

		// Token: 0x06005541 RID: 21825 RVA: 0x00058B40 File Offset: 0x00056D40
		public void remove_OnEnterFullScreenMode(IMsTscAxEvents_OnEnterFullScreenModeEventHandler A_1)
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
						IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper;
						for (;;)
						{
							msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (msTscAxEvents_SinkHelper.m_OnEnterFullScreenModeDelegate != null && ((msTscAxEvents_SinkHelper.m_OnEnterFullScreenModeDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
						this.m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x06005542 RID: 21826 RVA: 0x00058C20 File Offset: 0x00056E20
		public void add_OnLeaveFullScreenMode(IMsTscAxEvents_OnLeaveFullScreenModeEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)msTscAxEvents_SinkHelper, out dwCookie);
				msTscAxEvents_SinkHelper.m_dwCookie = dwCookie;
				msTscAxEvents_SinkHelper.m_OnLeaveFullScreenModeDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)msTscAxEvents_SinkHelper);
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

		// Token: 0x06005543 RID: 21827 RVA: 0x00058CA4 File Offset: 0x00056EA4
		public void remove_OnLeaveFullScreenMode(IMsTscAxEvents_OnLeaveFullScreenModeEventHandler A_1)
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
						IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper;
						for (;;)
						{
							msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (msTscAxEvents_SinkHelper.m_OnLeaveFullScreenModeDelegate != null && ((msTscAxEvents_SinkHelper.m_OnLeaveFullScreenModeDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
						this.m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x06005544 RID: 21828 RVA: 0x00058D84 File Offset: 0x00056F84
		public void add_OnChannelReceivedData(IMsTscAxEvents_OnChannelReceivedDataEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)msTscAxEvents_SinkHelper, out dwCookie);
				msTscAxEvents_SinkHelper.m_dwCookie = dwCookie;
				msTscAxEvents_SinkHelper.m_OnChannelReceivedDataDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)msTscAxEvents_SinkHelper);
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

		// Token: 0x06005545 RID: 21829 RVA: 0x00058E08 File Offset: 0x00057008
		public void remove_OnChannelReceivedData(IMsTscAxEvents_OnChannelReceivedDataEventHandler A_1)
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
						IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper;
						for (;;)
						{
							msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (msTscAxEvents_SinkHelper.m_OnChannelReceivedDataDelegate != null && ((msTscAxEvents_SinkHelper.m_OnChannelReceivedDataDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
						this.m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x06005546 RID: 21830 RVA: 0x00058EE8 File Offset: 0x000570E8
		public void add_OnRequestGoFullScreen(IMsTscAxEvents_OnRequestGoFullScreenEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)msTscAxEvents_SinkHelper, out dwCookie);
				msTscAxEvents_SinkHelper.m_dwCookie = dwCookie;
				msTscAxEvents_SinkHelper.m_OnRequestGoFullScreenDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)msTscAxEvents_SinkHelper);
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

		// Token: 0x06005547 RID: 21831 RVA: 0x00058F6C File Offset: 0x0005716C
		public void remove_OnRequestGoFullScreen(IMsTscAxEvents_OnRequestGoFullScreenEventHandler A_1)
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
						IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper;
						for (;;)
						{
							msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (msTscAxEvents_SinkHelper.m_OnRequestGoFullScreenDelegate != null && ((msTscAxEvents_SinkHelper.m_OnRequestGoFullScreenDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
						this.m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x06005548 RID: 21832 RVA: 0x0005904C File Offset: 0x0005724C
		public void add_OnRequestLeaveFullScreen(IMsTscAxEvents_OnRequestLeaveFullScreenEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)msTscAxEvents_SinkHelper, out dwCookie);
				msTscAxEvents_SinkHelper.m_dwCookie = dwCookie;
				msTscAxEvents_SinkHelper.m_OnRequestLeaveFullScreenDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)msTscAxEvents_SinkHelper);
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

		// Token: 0x06005549 RID: 21833 RVA: 0x000590D0 File Offset: 0x000572D0
		public void remove_OnRequestLeaveFullScreen(IMsTscAxEvents_OnRequestLeaveFullScreenEventHandler A_1)
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
						IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper;
						for (;;)
						{
							msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (msTscAxEvents_SinkHelper.m_OnRequestLeaveFullScreenDelegate != null && ((msTscAxEvents_SinkHelper.m_OnRequestLeaveFullScreenDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
						this.m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x0600554A RID: 21834 RVA: 0x000591B0 File Offset: 0x000573B0
		public void add_OnFatalError(IMsTscAxEvents_OnFatalErrorEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)msTscAxEvents_SinkHelper, out dwCookie);
				msTscAxEvents_SinkHelper.m_dwCookie = dwCookie;
				msTscAxEvents_SinkHelper.m_OnFatalErrorDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)msTscAxEvents_SinkHelper);
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

		// Token: 0x0600554B RID: 21835 RVA: 0x00059234 File Offset: 0x00057434
		public void remove_OnFatalError(IMsTscAxEvents_OnFatalErrorEventHandler A_1)
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
						IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper;
						for (;;)
						{
							msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (msTscAxEvents_SinkHelper.m_OnFatalErrorDelegate != null && ((msTscAxEvents_SinkHelper.m_OnFatalErrorDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
						this.m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x0600554C RID: 21836 RVA: 0x00059314 File Offset: 0x00057514
		public void add_OnWarning(IMsTscAxEvents_OnWarningEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)msTscAxEvents_SinkHelper, out dwCookie);
				msTscAxEvents_SinkHelper.m_dwCookie = dwCookie;
				msTscAxEvents_SinkHelper.m_OnWarningDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)msTscAxEvents_SinkHelper);
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

		// Token: 0x0600554D RID: 21837 RVA: 0x00059398 File Offset: 0x00057598
		public void remove_OnWarning(IMsTscAxEvents_OnWarningEventHandler A_1)
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
						IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper;
						for (;;)
						{
							msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (msTscAxEvents_SinkHelper.m_OnWarningDelegate != null && ((msTscAxEvents_SinkHelper.m_OnWarningDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
						this.m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x0600554E RID: 21838 RVA: 0x00059478 File Offset: 0x00057678
		public void add_OnRemoteDesktopSizeChange(IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)msTscAxEvents_SinkHelper, out dwCookie);
				msTscAxEvents_SinkHelper.m_dwCookie = dwCookie;
				msTscAxEvents_SinkHelper.m_OnRemoteDesktopSizeChangeDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)msTscAxEvents_SinkHelper);
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

		// Token: 0x0600554F RID: 21839 RVA: 0x000594FC File Offset: 0x000576FC
		public void remove_OnRemoteDesktopSizeChange(IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler A_1)
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
						IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper;
						for (;;)
						{
							msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (msTscAxEvents_SinkHelper.m_OnRemoteDesktopSizeChangeDelegate != null && ((msTscAxEvents_SinkHelper.m_OnRemoteDesktopSizeChangeDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
						this.m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x06005550 RID: 21840 RVA: 0x000595DC File Offset: 0x000577DC
		public void add_OnIdleTimeoutNotification(IMsTscAxEvents_OnIdleTimeoutNotificationEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)msTscAxEvents_SinkHelper, out dwCookie);
				msTscAxEvents_SinkHelper.m_dwCookie = dwCookie;
				msTscAxEvents_SinkHelper.m_OnIdleTimeoutNotificationDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)msTscAxEvents_SinkHelper);
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

		// Token: 0x06005551 RID: 21841 RVA: 0x00059660 File Offset: 0x00057860
		public void remove_OnIdleTimeoutNotification(IMsTscAxEvents_OnIdleTimeoutNotificationEventHandler A_1)
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
						IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper;
						for (;;)
						{
							msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (msTscAxEvents_SinkHelper.m_OnIdleTimeoutNotificationDelegate != null && ((msTscAxEvents_SinkHelper.m_OnIdleTimeoutNotificationDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
						this.m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x06005552 RID: 21842 RVA: 0x00059740 File Offset: 0x00057940
		public void add_OnRequestContainerMinimize(IMsTscAxEvents_OnRequestContainerMinimizeEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)msTscAxEvents_SinkHelper, out dwCookie);
				msTscAxEvents_SinkHelper.m_dwCookie = dwCookie;
				msTscAxEvents_SinkHelper.m_OnRequestContainerMinimizeDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)msTscAxEvents_SinkHelper);
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

		// Token: 0x06005553 RID: 21843 RVA: 0x000597C4 File Offset: 0x000579C4
		public void remove_OnRequestContainerMinimize(IMsTscAxEvents_OnRequestContainerMinimizeEventHandler A_1)
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
						IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper;
						for (;;)
						{
							msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (msTscAxEvents_SinkHelper.m_OnRequestContainerMinimizeDelegate != null && ((msTscAxEvents_SinkHelper.m_OnRequestContainerMinimizeDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
						this.m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x06005554 RID: 21844 RVA: 0x000598A4 File Offset: 0x00057AA4
		public void add_OnConfirmClose(IMsTscAxEvents_OnConfirmCloseEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)msTscAxEvents_SinkHelper, out dwCookie);
				msTscAxEvents_SinkHelper.m_dwCookie = dwCookie;
				msTscAxEvents_SinkHelper.m_OnConfirmCloseDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)msTscAxEvents_SinkHelper);
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

		// Token: 0x06005555 RID: 21845 RVA: 0x00059928 File Offset: 0x00057B28
		public void remove_OnConfirmClose(IMsTscAxEvents_OnConfirmCloseEventHandler A_1)
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
						IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper;
						for (;;)
						{
							msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (msTscAxEvents_SinkHelper.m_OnConfirmCloseDelegate != null && ((msTscAxEvents_SinkHelper.m_OnConfirmCloseDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
						this.m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x06005556 RID: 21846 RVA: 0x00059A08 File Offset: 0x00057C08
		public void add_OnReceivedTSPublicKey(IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)msTscAxEvents_SinkHelper, out dwCookie);
				msTscAxEvents_SinkHelper.m_dwCookie = dwCookie;
				msTscAxEvents_SinkHelper.m_OnReceivedTSPublicKeyDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)msTscAxEvents_SinkHelper);
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

		// Token: 0x06005557 RID: 21847 RVA: 0x00059A8C File Offset: 0x00057C8C
		public void remove_OnReceivedTSPublicKey(IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler A_1)
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
						IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper;
						for (;;)
						{
							msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (msTscAxEvents_SinkHelper.m_OnReceivedTSPublicKeyDelegate != null && ((msTscAxEvents_SinkHelper.m_OnReceivedTSPublicKeyDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
						this.m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x06005558 RID: 21848 RVA: 0x00059B6C File Offset: 0x00057D6C
		public void add_OnAutoReconnecting(IMsTscAxEvents_OnAutoReconnectingEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)msTscAxEvents_SinkHelper, out dwCookie);
				msTscAxEvents_SinkHelper.m_dwCookie = dwCookie;
				msTscAxEvents_SinkHelper.m_OnAutoReconnectingDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)msTscAxEvents_SinkHelper);
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

		// Token: 0x06005559 RID: 21849 RVA: 0x00059BF0 File Offset: 0x00057DF0
		public void remove_OnAutoReconnecting(IMsTscAxEvents_OnAutoReconnectingEventHandler A_1)
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
						IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper;
						for (;;)
						{
							msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (msTscAxEvents_SinkHelper.m_OnAutoReconnectingDelegate != null && ((msTscAxEvents_SinkHelper.m_OnAutoReconnectingDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
						this.m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x0600555A RID: 21850 RVA: 0x00059CD0 File Offset: 0x00057ED0
		public void add_OnAuthenticationWarningDisplayed(IMsTscAxEvents_OnAuthenticationWarningDisplayedEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)msTscAxEvents_SinkHelper, out dwCookie);
				msTscAxEvents_SinkHelper.m_dwCookie = dwCookie;
				msTscAxEvents_SinkHelper.m_OnAuthenticationWarningDisplayedDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)msTscAxEvents_SinkHelper);
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

		// Token: 0x0600555B RID: 21851 RVA: 0x00059D54 File Offset: 0x00057F54
		public void remove_OnAuthenticationWarningDisplayed(IMsTscAxEvents_OnAuthenticationWarningDisplayedEventHandler A_1)
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
						IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper;
						for (;;)
						{
							msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (msTscAxEvents_SinkHelper.m_OnAuthenticationWarningDisplayedDelegate != null && ((msTscAxEvents_SinkHelper.m_OnAuthenticationWarningDisplayedDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
						this.m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x0600555C RID: 21852 RVA: 0x00059E34 File Offset: 0x00058034
		public void add_OnAuthenticationWarningDismissed(IMsTscAxEvents_OnAuthenticationWarningDismissedEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)msTscAxEvents_SinkHelper, out dwCookie);
				msTscAxEvents_SinkHelper.m_dwCookie = dwCookie;
				msTscAxEvents_SinkHelper.m_OnAuthenticationWarningDismissedDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)msTscAxEvents_SinkHelper);
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

		// Token: 0x0600555D RID: 21853 RVA: 0x00059EB8 File Offset: 0x000580B8
		public void remove_OnAuthenticationWarningDismissed(IMsTscAxEvents_OnAuthenticationWarningDismissedEventHandler A_1)
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
						IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper;
						for (;;)
						{
							msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (msTscAxEvents_SinkHelper.m_OnAuthenticationWarningDismissedDelegate != null && ((msTscAxEvents_SinkHelper.m_OnAuthenticationWarningDismissedDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
						this.m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x0600555E RID: 21854 RVA: 0x00059F98 File Offset: 0x00058198
		public void add_OnRemoteProgramResult(IMsTscAxEvents_OnRemoteProgramResultEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)msTscAxEvents_SinkHelper, out dwCookie);
				msTscAxEvents_SinkHelper.m_dwCookie = dwCookie;
				msTscAxEvents_SinkHelper.m_OnRemoteProgramResultDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)msTscAxEvents_SinkHelper);
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

		// Token: 0x0600555F RID: 21855 RVA: 0x0005A01C File Offset: 0x0005821C
		public void remove_OnRemoteProgramResult(IMsTscAxEvents_OnRemoteProgramResultEventHandler A_1)
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
						IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper;
						for (;;)
						{
							msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (msTscAxEvents_SinkHelper.m_OnRemoteProgramResultDelegate != null && ((msTscAxEvents_SinkHelper.m_OnRemoteProgramResultDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
						this.m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x06005560 RID: 21856 RVA: 0x0005A0FC File Offset: 0x000582FC
		public void add_OnRemoteProgramDisplayed(IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)msTscAxEvents_SinkHelper, out dwCookie);
				msTscAxEvents_SinkHelper.m_dwCookie = dwCookie;
				msTscAxEvents_SinkHelper.m_OnRemoteProgramDisplayedDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)msTscAxEvents_SinkHelper);
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

		// Token: 0x06005561 RID: 21857 RVA: 0x0005A180 File Offset: 0x00058380
		public void remove_OnRemoteProgramDisplayed(IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler A_1)
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
						IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper;
						for (;;)
						{
							msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (msTscAxEvents_SinkHelper.m_OnRemoteProgramDisplayedDelegate != null && ((msTscAxEvents_SinkHelper.m_OnRemoteProgramDisplayedDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
						this.m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x06005562 RID: 21858 RVA: 0x0005A260 File Offset: 0x00058460
		public void add_OnRemoteWindowDisplayed(IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)msTscAxEvents_SinkHelper, out dwCookie);
				msTscAxEvents_SinkHelper.m_dwCookie = dwCookie;
				msTscAxEvents_SinkHelper.m_OnRemoteWindowDisplayedDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)msTscAxEvents_SinkHelper);
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

		// Token: 0x06005563 RID: 21859 RVA: 0x0005A2E4 File Offset: 0x000584E4
		public void remove_OnRemoteWindowDisplayed(IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler A_1)
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
						IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper;
						for (;;)
						{
							msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (msTscAxEvents_SinkHelper.m_OnRemoteWindowDisplayedDelegate != null && ((msTscAxEvents_SinkHelper.m_OnRemoteWindowDisplayedDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
						this.m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x06005564 RID: 21860 RVA: 0x0005A3C4 File Offset: 0x000585C4
		public void add_OnLogonError(IMsTscAxEvents_OnLogonErrorEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)msTscAxEvents_SinkHelper, out dwCookie);
				msTscAxEvents_SinkHelper.m_dwCookie = dwCookie;
				msTscAxEvents_SinkHelper.m_OnLogonErrorDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)msTscAxEvents_SinkHelper);
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

		// Token: 0x06005565 RID: 21861 RVA: 0x0005A448 File Offset: 0x00058648
		public void remove_OnLogonError(IMsTscAxEvents_OnLogonErrorEventHandler A_1)
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
						IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper;
						for (;;)
						{
							msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (msTscAxEvents_SinkHelper.m_OnLogonErrorDelegate != null && ((msTscAxEvents_SinkHelper.m_OnLogonErrorDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
						this.m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x06005566 RID: 21862 RVA: 0x0005A528 File Offset: 0x00058728
		public void add_OnFocusReleased(IMsTscAxEvents_OnFocusReleasedEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)msTscAxEvents_SinkHelper, out dwCookie);
				msTscAxEvents_SinkHelper.m_dwCookie = dwCookie;
				msTscAxEvents_SinkHelper.m_OnFocusReleasedDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)msTscAxEvents_SinkHelper);
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

		// Token: 0x06005567 RID: 21863 RVA: 0x0005A5AC File Offset: 0x000587AC
		public void remove_OnFocusReleased(IMsTscAxEvents_OnFocusReleasedEventHandler A_1)
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
						IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper;
						for (;;)
						{
							msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (msTscAxEvents_SinkHelper.m_OnFocusReleasedDelegate != null && ((msTscAxEvents_SinkHelper.m_OnFocusReleasedDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
						this.m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x06005568 RID: 21864 RVA: 0x0005A68C File Offset: 0x0005888C
		public void add_OnUserNameAcquired(IMsTscAxEvents_OnUserNameAcquiredEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)msTscAxEvents_SinkHelper, out dwCookie);
				msTscAxEvents_SinkHelper.m_dwCookie = dwCookie;
				msTscAxEvents_SinkHelper.m_OnUserNameAcquiredDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)msTscAxEvents_SinkHelper);
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

		// Token: 0x06005569 RID: 21865 RVA: 0x0005A710 File Offset: 0x00058910
		public void remove_OnUserNameAcquired(IMsTscAxEvents_OnUserNameAcquiredEventHandler A_1)
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
						IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper;
						for (;;)
						{
							msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (msTscAxEvents_SinkHelper.m_OnUserNameAcquiredDelegate != null && ((msTscAxEvents_SinkHelper.m_OnUserNameAcquiredDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
						this.m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x0600556A RID: 21866 RVA: 0x0005A7F0 File Offset: 0x000589F0
		public void add_OnMouseInputModeChanged(IMsTscAxEvents_OnMouseInputModeChangedEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)msTscAxEvents_SinkHelper, out dwCookie);
				msTscAxEvents_SinkHelper.m_dwCookie = dwCookie;
				msTscAxEvents_SinkHelper.m_OnMouseInputModeChangedDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)msTscAxEvents_SinkHelper);
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

		// Token: 0x0600556B RID: 21867 RVA: 0x0005A874 File Offset: 0x00058A74
		public void remove_OnMouseInputModeChanged(IMsTscAxEvents_OnMouseInputModeChangedEventHandler A_1)
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
						IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper;
						for (;;)
						{
							msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (msTscAxEvents_SinkHelper.m_OnMouseInputModeChangedDelegate != null && ((msTscAxEvents_SinkHelper.m_OnMouseInputModeChangedDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
						this.m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x0600556C RID: 21868 RVA: 0x0005A954 File Offset: 0x00058B54
		public void add_OnServiceMessageReceived(IMsTscAxEvents_OnServiceMessageReceivedEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)msTscAxEvents_SinkHelper, out dwCookie);
				msTscAxEvents_SinkHelper.m_dwCookie = dwCookie;
				msTscAxEvents_SinkHelper.m_OnServiceMessageReceivedDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)msTscAxEvents_SinkHelper);
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

		// Token: 0x0600556D RID: 21869 RVA: 0x0005A9D8 File Offset: 0x00058BD8
		public void remove_OnServiceMessageReceived(IMsTscAxEvents_OnServiceMessageReceivedEventHandler A_1)
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
						IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper;
						for (;;)
						{
							msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (msTscAxEvents_SinkHelper.m_OnServiceMessageReceivedDelegate != null && ((msTscAxEvents_SinkHelper.m_OnServiceMessageReceivedDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
						this.m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x0600556E RID: 21870 RVA: 0x0005AAB8 File Offset: 0x00058CB8
		public void add_OnConnectionBarPullDown(IMsTscAxEvents_OnConnectionBarPullDownEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)msTscAxEvents_SinkHelper, out dwCookie);
				msTscAxEvents_SinkHelper.m_dwCookie = dwCookie;
				msTscAxEvents_SinkHelper.m_OnConnectionBarPullDownDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)msTscAxEvents_SinkHelper);
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

		// Token: 0x0600556F RID: 21871 RVA: 0x0005AB3C File Offset: 0x00058D3C
		public void remove_OnConnectionBarPullDown(IMsTscAxEvents_OnConnectionBarPullDownEventHandler A_1)
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
						IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper;
						for (;;)
						{
							msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (msTscAxEvents_SinkHelper.m_OnConnectionBarPullDownDelegate != null && ((msTscAxEvents_SinkHelper.m_OnConnectionBarPullDownDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
						this.m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x06005570 RID: 21872 RVA: 0x0005AC1C File Offset: 0x00058E1C
		public void add_OnNetworkStatusChanged(IMsTscAxEvents_OnNetworkStatusChangedEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)msTscAxEvents_SinkHelper, out dwCookie);
				msTscAxEvents_SinkHelper.m_dwCookie = dwCookie;
				msTscAxEvents_SinkHelper.m_OnNetworkStatusChangedDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)msTscAxEvents_SinkHelper);
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

		// Token: 0x06005571 RID: 21873 RVA: 0x0005ACA0 File Offset: 0x00058EA0
		public void remove_OnNetworkStatusChanged(IMsTscAxEvents_OnNetworkStatusChangedEventHandler A_1)
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
						IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper;
						for (;;)
						{
							msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (msTscAxEvents_SinkHelper.m_OnNetworkStatusChangedDelegate != null && ((msTscAxEvents_SinkHelper.m_OnNetworkStatusChangedDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
						this.m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x06005572 RID: 21874 RVA: 0x0005AD80 File Offset: 0x00058F80
		public void add_OnDevicesButtonPressed(IMsTscAxEvents_OnDevicesButtonPressedEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)msTscAxEvents_SinkHelper, out dwCookie);
				msTscAxEvents_SinkHelper.m_dwCookie = dwCookie;
				msTscAxEvents_SinkHelper.m_OnDevicesButtonPressedDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)msTscAxEvents_SinkHelper);
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

		// Token: 0x06005573 RID: 21875 RVA: 0x0005AE04 File Offset: 0x00059004
		public void remove_OnDevicesButtonPressed(IMsTscAxEvents_OnDevicesButtonPressedEventHandler A_1)
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
						IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper;
						for (;;)
						{
							msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (msTscAxEvents_SinkHelper.m_OnDevicesButtonPressedDelegate != null && ((msTscAxEvents_SinkHelper.m_OnDevicesButtonPressedDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
						this.m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x06005574 RID: 21876 RVA: 0x0005AEE4 File Offset: 0x000590E4
		public void add_OnAutoReconnected(IMsTscAxEvents_OnAutoReconnectedEventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)msTscAxEvents_SinkHelper, out dwCookie);
				msTscAxEvents_SinkHelper.m_dwCookie = dwCookie;
				msTscAxEvents_SinkHelper.m_OnAutoReconnectedDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)msTscAxEvents_SinkHelper);
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

		// Token: 0x06005575 RID: 21877 RVA: 0x0005AF68 File Offset: 0x00059168
		public void remove_OnAutoReconnected(IMsTscAxEvents_OnAutoReconnectedEventHandler A_1)
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
						IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper;
						for (;;)
						{
							msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (msTscAxEvents_SinkHelper.m_OnAutoReconnectedDelegate != null && ((msTscAxEvents_SinkHelper.m_OnAutoReconnectedDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
						this.m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x06005576 RID: 21878 RVA: 0x0005B048 File Offset: 0x00059248
		public void add_OnAutoReconnecting2(IMsTscAxEvents_OnAutoReconnecting2EventHandler A_1)
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)msTscAxEvents_SinkHelper, out dwCookie);
				msTscAxEvents_SinkHelper.m_dwCookie = dwCookie;
				msTscAxEvents_SinkHelper.m_OnAutoReconnecting2Delegate = A_1;
				this.m_aEventSinkHelpers.Add((object)msTscAxEvents_SinkHelper);
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

		// Token: 0x06005577 RID: 21879 RVA: 0x0005B0CC File Offset: 0x000592CC
		public void remove_OnAutoReconnecting2(IMsTscAxEvents_OnAutoReconnecting2EventHandler A_1)
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
						IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper;
						for (;;)
						{
							msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							if (msTscAxEvents_SinkHelper.m_OnAutoReconnecting2Delegate != null && ((msTscAxEvents_SinkHelper.m_OnAutoReconnecting2Delegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
						this.m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x06005578 RID: 21880 RVA: 0x0005B1AC File Offset: 0x000593AC
		public IMsTscAxEvents_EventProvider(object A_1)
		{
			this.m_ConnectionPointContainer = (IConnectionPointContainer)A_1;
		}

		// Token: 0x06005579 RID: 21881 RVA: 0x0005B1C0 File Offset: 0x000593C0
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
							IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							this.m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x0600557A RID: 21882 RVA: 0x0005B268 File Offset: 0x00059468
		public void Dispose()
		{
			this.Finalize();
			GC.SuppressFinalize(this);
		}

		// Token: 0x04000808 RID: 2056
		private IConnectionPointContainer m_ConnectionPointContainer;

		// Token: 0x04000809 RID: 2057
		private ArrayList m_aEventSinkHelpers;

		// Token: 0x0400080A RID: 2058
		private IConnectionPoint m_ConnectionPoint;
	}
}
