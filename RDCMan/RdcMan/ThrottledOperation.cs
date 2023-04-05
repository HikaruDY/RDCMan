using System;
using System.Collections.Generic;

namespace RdcMan
{
	// Token: 0x0200006B RID: 107
	internal class ThrottledOperation : IDisposable
	{
		// Token: 0x06000309 RID: 777 RVA: 0x000124F0 File Offset: 0x000106F0
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

		// Token: 0x0600030A RID: 778 RVA: 0x00012580 File Offset: 0x00010780
		~ThrottledOperation()
		{
			this.Dispose(false);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x000125B0 File Offset: 0x000107B0
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600030C RID: 780 RVA: 0x000125C0 File Offset: 0x000107C0
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

		// Token: 0x0600030D RID: 781 RVA: 0x000125F8 File Offset: 0x000107F8
		public void Execute()
		{
			this._throttledAction.Execute();
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00012608 File Offset: 0x00010808
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

		// Token: 0x04000183 RID: 387
		private HashSet<Server> _serversInScope;

		// Token: 0x04000184 RID: 388
		private object _serversInScopeLock = new object();

		// Token: 0x04000185 RID: 389
		private ThrottledAction _throttledAction;

		// Token: 0x04000186 RID: 390
		private HashSet<RdpClient.ConnectionState> _completionStates;

		// Token: 0x04000187 RID: 391
		private bool _disposed;
	}
}
