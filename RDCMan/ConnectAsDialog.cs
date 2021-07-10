using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000050 RID: 80
	public partial class ConnectAsDialog : QuickConnectDialog
	{
		// Token: 0x06000148 RID: 328 RVA: 0x00002B09 File Offset: 0x00000D09
		private ConnectAsDialog(string title, string buttonText, Form parentForm) : base(title, buttonText, parentForm)
		{
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00002B25 File Offset: 0x00000D25
		// (set) Token: 0x0600014A RID: 330 RVA: 0x00002B2D File Offset: 0x00000D2D
		public LogonCredentials LogonCredentials { get; private set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00002B36 File Offset: 0x00000D36
		// (set) Token: 0x0600014C RID: 332 RVA: 0x00002B3E File Offset: 0x00000D3E
		public ConnectionSettings ConnectionSettings { get; private set; }

		// Token: 0x0600014D RID: 333 RVA: 0x0000C000 File Offset: 0x0000A200
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
