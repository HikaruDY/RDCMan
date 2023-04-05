using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace MSTSCLib
{
	internal sealed class IMsTscAxEvents_EventProvider : IMsTscAxEvents_Event, IDisposable
	{
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

		public IMsTscAxEvents_EventProvider(object A_1)
		{
			this.m_ConnectionPointContainer = (IConnectionPointContainer)A_1;
		}

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

		public void Dispose()
		{
			this.Finalize();
			GC.SuppressFinalize(this);
		}

		private IConnectionPointContainer m_ConnectionPointContainer;

		private ArrayList m_aEventSinkHelpers;

		private IConnectionPoint m_ConnectionPoint;
	}
}
