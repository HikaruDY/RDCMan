using System;

namespace RdcMan
{
	public class ServerChangedEventArgs : EventArgs
	{
		public ServerChangedEventArgs(ServerBase server, ChangeType changeType)
		{
			this.Server = server;
			this.ChangeType = changeType;
		}

		public ServerBase Server { get; private set; }

		public ChangeType ChangeType { get; private set; }
	}
}
