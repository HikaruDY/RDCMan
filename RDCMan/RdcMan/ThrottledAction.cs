using System;
using System.Collections.Generic;
using System.Threading;

namespace RdcMan
{
	internal class ThrottledAction : IDisposable
	{
		public ThrottledAction(List<ServerBase> servers, Action preAction, Action<ServerBase> action, int delayInMilliseconds, Action postAction)
		{
			this._servers = servers;
			this._preAction = preAction;
			this._action = action;
			this._delayInMilliseconds = delayInMilliseconds;
			this._postAction = postAction;
		}

		~ThrottledAction()
		{
			this.Dispose(false);
		}

		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		public void Execute()
		{
			this._numActive = 0;
			using (this._actionSemaphore = new Semaphore(3, 3))
			{
				try
				{
					this._preAction();
					foreach (ServerBase state in this._servers)
					{
						this._actionSemaphore.WaitOne();
						Interlocked.Increment(ref this._numActive);
						ThreadPool.QueueUserWorkItem(delegate(object s)
						{
							this._action(s as ServerBase);
						}, state);
						Thread.Sleep(this._delayInMilliseconds);
					}
					this.WaitForCompletion();
				}
				finally
				{
					this._postAction();
				}
			}
		}

		public void CompleteAction()
		{
			this._actionSemaphore.Release();
			Interlocked.Decrement(ref this._numActive);
		}

		private void WaitForCompletion()
		{
			while (Thread.VolatileRead(ref this._numActive) > 0)
			{
				Thread.Sleep(this._delayInMilliseconds);
			}
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!this._disposed)
			{
				if (disposing && this._actionSemaphore != null)
				{
					this._actionSemaphore.Close();
					this._actionSemaphore = null;
				}
				this._disposed = true;
			}
		}

		private const int Max = 3;

		private int _numActive;

		private bool _disposed;

		private Semaphore _actionSemaphore;

		private List<ServerBase> _servers;

		private Action _preAction;

		private Action<ServerBase> _action;

		private int _delayInMilliseconds;

		private Action _postAction;
	}
}
