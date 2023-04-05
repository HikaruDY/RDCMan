using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace MSTSCLib
{
	internal sealed class IRemoteDesktopClientEvents_EventProvider : IRemoteDesktopClientEvents_Event, IDisposable
	{
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

		public IRemoteDesktopClientEvents_EventProvider(object A_1)
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
