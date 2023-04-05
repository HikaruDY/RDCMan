using System;
using System.Collections.Generic;

namespace RdcMan
{
	internal class ThrottledOperation : IDisposable
	{
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

		~ThrottledOperation()
		{
			this.Dispose(false);
		}

		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

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

		public void Execute()
		{
			this._throttledAction.Execute();
		}

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

		private HashSet<Server> _serversInScope;

		private object _serversInScopeLock = new object();

		private ThrottledAction _throttledAction;

		private HashSet<RdpClient.ConnectionState> _completionStates;

		private bool _disposed;
	}
}
