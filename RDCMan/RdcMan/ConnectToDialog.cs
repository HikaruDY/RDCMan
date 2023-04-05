using System;
using System.Windows.Forms;

namespace RdcMan
{
	public partial class ConnectToDialog : QuickConnectDialog
	{
		private ConnectToDialog(string title, string buttonText, Form parentForm) : base(title, buttonText, parentForm)
		{
		}

		public TemporaryServer Server { get; private set; }

		public static ConnectToDialog NewConnectToDialog(Form parentForm)
		{
			ConnectToDialog connectToDialog = new ConnectToDialog("Connect To", "Connect", parentForm);
			connectToDialog.Server = TemporaryServer.CreateForQuickConnect();
			connectToDialog.CreateControls(true, connectToDialog.Server.LogonCredentials, connectToDialog.Server.ConnectionSettings, null);
			return connectToDialog;
		}
	}
}
