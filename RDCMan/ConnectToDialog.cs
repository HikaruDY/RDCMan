using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x0200004F RID: 79
	public partial class ConnectToDialog : QuickConnectDialog
	{
		// Token: 0x06000144 RID: 324 RVA: 0x00002B09 File Offset: 0x00000D09
		private ConnectToDialog(string title, string buttonText, Form parentForm) : base(title, buttonText, parentForm)
		{
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00002B14 File Offset: 0x00000D14
		// (set) Token: 0x06000146 RID: 326 RVA: 0x00002B1C File Offset: 0x00000D1C
		public TemporaryServer Server { get; private set; }

		// Token: 0x06000147 RID: 327 RVA: 0x0000BFB8 File Offset: 0x0000A1B8
		public static ConnectToDialog NewConnectToDialog(Form parentForm)
		{
			ConnectToDialog connectToDialog = new ConnectToDialog("Connect To", "Connect", parentForm);
			connectToDialog.Server = TemporaryServer.CreateForQuickConnect();
			connectToDialog.CreateControls(true, connectToDialog.Server.LogonCredentials, connectToDialog.Server.ConnectionSettings, null);
			return connectToDialog;
		}
	}
}
