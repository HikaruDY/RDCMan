using System;

namespace RdcMan
{
	public class ConnectionStateChangedEventArgs : EventArgs
	{
		public ConnectionStateChangedEventArgs(Server server, RdpClient.ConnectionState state)
		{
			this.Server = server;
			this.State = state;
		}

		public Server Server { get; private set; }

		public RdpClient.ConnectionState State { get; private set; }
	}
}
