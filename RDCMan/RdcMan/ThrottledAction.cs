using System;
using System.Collections.Generic;
using System.Threading;

namespace RdcMan
{
	// Token: 0x0200006C RID: 108
	internal class ThrottledAction : IDisposable
	{
		// Token: 0x0600030F RID: 783 RVA: 0x00012684 File Offset: 0x00010884
		public ThrottledAction(List<ServerBase> servers, Action preAction, Action<ServerBase> action, int delayInMilliseconds, Action postAction)
		{
			this._servers = servers;
			this._preAction = preAction;
			this._action = action;
			this._delayInMilliseconds = delayInMilliseconds;
			this._postAction = postAction;
		}

		// Token: 0x06000310 RID: 784 RVA: 0x000126B4 File Offset: 0x000108B4
		~ThrottledAction()
		{
			this.Dispose(false);
		}

		// Token: 0x06000311 RID: 785 RVA: 0x000126E4 File Offset: 0x000108E4
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000312 RID: 786 RVA: 0x000126F4 File Offset: 0x000108F4
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

		// Token: 0x06000313 RID: 787 RVA: 0x000127DC File Offset: 0x000109DC
		public void CompleteAction()
		{
			this._actionSemaphore.Release();
			Interlocked.Decrement(ref this._numActive);
		}

		// Token: 0x06000314 RID: 788 RVA: 0x000127F8 File Offset: 0x000109F8
		private void WaitForCompletion()
		{
			while (Thread.VolatileRead(ref this._numActive) > 0)
			{
				Thread.Sleep(this._delayInMilliseconds);
			}
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00012818 File Offset: 0x00010A18
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

		// Token: 0x04000188 RID: 392
		private const int Max = 3;

		// Token: 0x04000189 RID: 393
		private int _numActive;

		// Token: 0x0400018A RID: 394
		private bool _disposed;

		// Token: 0x0400018B RID: 395
		private Semaphore _actionSemaphore;

		// Token: 0x0400018C RID: 396
		private List<ServerBase> _servers;

		// Token: 0x0400018D RID: 397
		private Action _preAction;

		// Token: 0x0400018E RID: 398
		private Action<ServerBase> _action;

		// Token: 0x0400018F RID: 399
		private int _delayInMilliseconds;

		// Token: 0x04000190 RID: 400
		private Action _postAction;
	}
}
