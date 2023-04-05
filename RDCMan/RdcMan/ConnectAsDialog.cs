﻿using System;
using System.Windows.Forms;

namespace RdcMan
{
	public partial class ConnectAsDialog : QuickConnectDialog
	{
		private ConnectAsDialog(string title, string buttonText, Form parentForm) : base(title, buttonText, parentForm)
		{
		}

		public LogonCredentials LogonCredentials { get; private set; }

		public ConnectionSettings ConnectionSettings { get; private set; }

		public static ConnectAsDialog NewConnectAsDialog(RdcTreeNode node, Form parentForm)
		{
			ConnectAsDialog connectAsDialog = new ConnectAsDialog("Connect " + node.Text + " As", "Connect", parentForm);
			connectAsDialog.LogonCredentials = new LogonCredentials();
			connectAsDialog.ConnectionSettings = new ConnectionSettings();
			if (node.LogonCredentials != null)
			{
				connectAsDialog.LogonCredentials.Copy(node.LogonCredentials);
			}
			if (node.ConnectionSettings != null)
			{
				connectAsDialog.ConnectionSettings.Copy(node.ConnectionSettings);
			}
			connectAsDialog.CreateControls(false, connectAsDialog.LogonCredentials, connectAsDialog.ConnectionSettings, node.FileGroup);
			return connectAsDialog;
		}
	}
}
