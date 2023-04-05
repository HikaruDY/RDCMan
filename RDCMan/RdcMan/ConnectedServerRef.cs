using System;

namespace RdcMan
{
	internal class ConnectedServerRef : ServerRef
	{
		public DateTime LastFocusTime { get; set; }

		public ConnectedServerRef(Server server) : base(server)
		{
		}

		public override bool ConfirmRemove(bool askUser)
		{
			FormTools.InformationDialog("Disconnect the server to remove it from the Connected group");
			return false;
		}
	}
}
