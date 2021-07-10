using System;
using System.Collections.Generic;
using System.Threading;

namespace RdcMan
{
	// Token: 0x020000B5 RID: 181
	internal class ThrottledAction : IDisposable
	{
		// Token: 0x060003EA RID: 1002 RVA: 0x00004304 File Offset: 0x00002504
		public ThrottledAction(List<ServerBase> servers, Action preAction, Action<ServerBase> action, int delayInMilliseconds, Action postAction)
		{
			this._servers = servers;
			this._preAction = preAction;
			this._action = action;
			this._delayInMilliseconds = delayInMilliseconds;
			this._postAction = postAction;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00016A84 File Offset: 0x00014C84
		~ThrottledAction()
		{
			this.Dispose(false);
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00004331 File Offset: 0x00002531
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00016AB4 File Offset: 0x00014CB4
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

		// Token: 0x060003EE RID: 1006 RVA: 0x00004340 File Offset: 0x00002540
		public void CompleteAction()
		{
			this._actionSemaphore.Release();
			Interlocked.Decrement(ref this._numActive);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0000435A File Offset: 0x0000255A
		private void WaitForCompletion()
		{
			while (Thread.VolatileRead(ref this._numActive) > 0)
			{
				Thread.Sleep(this._delayInMilliseconds);
			}
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00004377 File Offset: 0x00002577
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

		// Token: 0x040003FC RID: 1020
		private const int Max = 3;

		// Token: 0x040003FD RID: 1021
		private int _numActive;

		// Token: 0x040003FE RID: 1022
		private bool _disposed;

		// Token: 0x040003FF RID: 1023
		private Semaphore _actionSemaphore;

		// Token: 0x04000400 RID: 1024
		private List<ServerBase> _servers;

		// Token: 0x04000401 RID: 1025
		private Action _preAction;

		// Token: 0x04000402 RID: 1026
		private Action<ServerBase> _action;

		// Token: 0x04000403 RID: 1027
		private int _delayInMilliseconds;

		// Token: 0x04000404 RID: 1028
		private Action _postAction;
	}
}
