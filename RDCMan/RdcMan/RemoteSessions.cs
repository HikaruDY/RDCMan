using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Win32;

namespace RdcMan
{
	internal class RemoteSessions
	{
		public RemoteSessions(ServerBase server)
		{
			this._server = server;
			this._hServer = (IntPtr)0;
		}

		public bool OpenServer()
		{
			this._hServer = Wts.OpenServer(this._server.ServerName);
			return !(this._hServer == (IntPtr)0);
		}

		public void CloseServer()
		{
			if (this._hServer != (IntPtr)0)
			{
				Wts.CloseServer(this._hServer);
				this._hServer = (IntPtr)0;
			}
		}

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

		public bool DisconnectSession(int id)
		{
			return Wts.DisconnectSession(this._hServer, id, true);
		}

		public bool LogOffSession(int id)
		{
			return Wts.LogOffSession(this._hServer, id, true);
		}

		private IntPtr _hServer;

		private readonly ServerBase _server;
	}
}
