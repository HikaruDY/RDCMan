using System;
using System.Collections.Generic;

namespace RdcMan
{
	// Token: 0x020000B3 RID: 179
	internal class ThrottledOperation : IDisposable
	{
		// Token: 0x060003E0 RID: 992 RVA: 0x000168F4 File Offset: 0x00014AF4
		public ThrottledOperation(List<ServerBase> servers, IEnumerable<RdpClient.ConnectionState> completionStates, Action preAction, Action<ServerBase> action, int delayInMilliseconds, Action postAction)
		{
			ThrottledOperation <>4__this = this;
			this._serversInScope = new HashSet<Server>();
			this._completionStates = new HashSet<RdpClient.ConnectionState>(completionStates);
			this._throttledAction = new ThrottledAction(servers, delegate()
			{
				preAction();
				Server.ConnectionStateChanged += <>4__this.ConnectionStateChangeConnectHandler;
			}, delegate(ServerBase server)
			{
				object serversInScopeLock = <>4__this._serversInScopeLock;
				lock (serversInScopeLock)
				{
					<>4__this._serversInScope.Add(server.ServerNode);
				}
				action(server);
			}, delayInMilliseconds, delegate()
			{
				Server.ConnectionStateChanged -= <>4__this.ConnectionStateChangeConnectHandler;
				postAction();
			});
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00016980 File Offset: 0x00014B80
		~ThrottledOperation()
		{
			this.Dispose(false);
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00004274 File Offset: 0x00002474
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00004283 File Offset: 0x00002483
		protected virtual void Dispose(bool disposing)
		{
			if (!this._disposed)
			{
				if (disposing && this._throttledAction != null)
				{
					this._throttledAction.Dispose();
					this._throttledAction = null;
				}
				this._disposed = true;
			}
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x000042B1 File Offset: 0x000024B1
		public void Execute()
		{
			this._throttledAction.Execute();
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x000169B0 File Offset: 0x00014BB0
		private void ConnectionStateChangeConnectHandler(ConnectionStateChangedEventArgs args)
		{
			if (this._completionStates.Contains(args.State))
			{
				object serversInScopeLock = this._serversInScopeLock;
				bool flag2;
				lock (serversInScopeLock)
				{
					flag2 = this._serversInScope.Remove(args.Server);
				}
				if (flag2)
				{
					this._throttledAction.CompleteAction();
				}
			}
		}

		// Token: 0x040003F3 RID: 1011
		private HashSet<Server> _serversInScope;

		// Token: 0x040003F4 RID: 1012
		private object _serversInScopeLock = new object();

		// Token: 0x040003F5 RID: 1013
		private ThrottledAction _throttledAction;

		// Token: 0x040003F6 RID: 1014
		private HashSet<RdpClient.ConnectionState> _completionStates;

		// Token: 0x040003F7 RID: 1015
		private bool _disposed;
	}
}
