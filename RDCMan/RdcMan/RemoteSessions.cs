using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Win32;

namespace RdcMan
{
	// Token: 0x020000B3 RID: 179
	internal class RemoteSessions
	{
		// Token: 0x06000637 RID: 1591 RVA: 0x0001DFA4 File Offset: 0x0001C1A4
		public RemoteSessions(ServerBase server)
		{
			this._server = server;
			this._hServer = (IntPtr)0;
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0001DFC0 File Offset: 0x0001C1C0
		public bool OpenServer()
		{
			this._hServer = Wts.OpenServer(this._server.ServerName);
			return !(this._hServer == (IntPtr)0);
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x0001DFF4 File Offset: 0x0001C1F4
		public void CloseServer()
		{
			if (this._hServer != (IntPtr)0)
			{
				Wts.CloseServer(this._hServer);
				this._hServer = (IntPtr)0;
			}
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x0001E024 File Offset: 0x0001C224
		public IList<RemoteSessionInfo> QuerySessions()
		{
			if (this._hServer == (IntPtr)0)
			{
				throw new Exception("QuerySessions called before OpenServer succeeded");
			}
			IntPtr intPtr;
			int num;
			if (!Wts.EnumerateSessions(this._hServer, 0, 1, out intPtr, out num))
			{
				return null;
			}
			List<RemoteSessionInfo> list = new List<RemoteSessionInfo>();
			Wts.SessionInfo sessionInfo = new Wts.SessionInfo();
			try
			{
				IntPtr intPtr2 = intPtr;
				for (int i = 0; i < num; i++)
				{
					Marshal.PtrToStructure<Wts.SessionInfo>(intPtr2, sessionInfo);
					intPtr2 = (IntPtr)((long)intPtr2 + (long)Marshal.SizeOf<Wts.SessionInfo>(sessionInfo));
					IntPtr ptr;
					int num2;
					Wts.QuerySessionInformation(this._hServer, sessionInfo.SessionId, Wts.InfoClass.UserName, out ptr, out num2);
					string text = Marshal.PtrToStringAuto(ptr);
					if (text.Length != 0)
					{
						Wts.QuerySessionInformation(this._hServer, sessionInfo.SessionId, Wts.InfoClass.DomainName, out ptr, out num2);
						string domainName = Marshal.PtrToStringAuto(ptr);
						Wts.QuerySessionInformation(this._hServer, sessionInfo.SessionId, Wts.InfoClass.ClientName, out ptr, out num2);
						string clientName = Marshal.PtrToStringAuto(ptr);
						list.Add(new RemoteSessionInfo
						{
							ClientName = clientName,
							DomainName = domainName,
							SessionId = sessionInfo.SessionId,
							UserName = text,
							State = sessionInfo.State
						});
					}
				}
			}
			finally
			{
				Wts.FreeMemory(intPtr);
			}
			return list;
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x0001E188 File Offset: 0x0001C388
		public bool DisconnectSession(int id)
		{
			return Wts.DisconnectSession(this._hServer, id, true);
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x0001E198 File Offset: 0x0001C398
		public bool LogOffSession(int id)
		{
			return Wts.LogOffSession(this._hServer, id, true);
		}

		// Token: 0x0400024B RID: 587
		private IntPtr _hServer;

		// Token: 0x0400024C RID: 588
		private readonly ServerBase _server;
	}
}
