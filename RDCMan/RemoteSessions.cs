using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Win32;

namespace RdcMan
{
	// Token: 0x02000137 RID: 311
	internal class RemoteSessions
	{
		// Token: 0x060007AC RID: 1964 RVA: 0x00006D72 File Offset: 0x00004F72
		public RemoteSessions(ServerBase server)
		{
			this._server = server;
			this._hServer = (IntPtr)0;
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00006D8D File Offset: 0x00004F8D
		public bool OpenServer()
		{
			this._hServer = Wts.OpenServer(this._server.ServerName);
			return !(this._hServer == (IntPtr)0);
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00006DBB File Offset: 0x00004FBB
		public void CloseServer()
		{
			if (this._hServer != (IntPtr)0)
			{
				Wts.CloseServer(this._hServer);
				this._hServer = (IntPtr)0;
			}
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x0001EB58 File Offset: 0x0001CD58
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

		// Token: 0x060007B0 RID: 1968 RVA: 0x00006DE7 File Offset: 0x00004FE7
		public bool DisconnectSession(int id)
		{
			return Wts.DisconnectSession(this._hServer, id, true);
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00006DF6 File Offset: 0x00004FF6
		public bool LogOffSession(int id)
		{
			return Wts.LogOffSession(this._hServer, id, true);
		}

		// Token: 0x0400054A RID: 1354
		private IntPtr _hServer;

		// Token: 0x0400054B RID: 1355
		private readonly ServerBase _server;
	}
}
