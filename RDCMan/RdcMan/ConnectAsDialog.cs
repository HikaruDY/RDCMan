using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000032 RID: 50
	public partial class ConnectAsDialog : QuickConnectDialog
	{
		// Token: 0x06000127 RID: 295 RVA: 0x000066F0 File Offset: 0x000048F0
		private ConnectAsDialog(string title, string buttonText, Form parentForm) : base(title, buttonText, parentForm)
		{
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000128 RID: 296 RVA: 0x000066FC File Offset: 0x000048FC
		// (set) Token: 0x06000129 RID: 297 RVA: 0x00006704 File Offset: 0x00004904
		public LogonCredentials LogonCredentials { get; private set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00006710 File Offset: 0x00004910
		// (set) Token: 0x0600012B RID: 299 RVA: 0x00006718 File Offset: 0x00004918
		public ConnectionSettings ConnectionSettings { get; private set; }

		// Token: 0x0600012C RID: 300 RVA: 0x00006724 File Offset: 0x00004924
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
