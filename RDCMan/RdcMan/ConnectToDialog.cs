using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000031 RID: 49
	public partial class ConnectToDialog : QuickConnectDialog
	{
		// Token: 0x06000123 RID: 291 RVA: 0x00006684 File Offset: 0x00004884
		private ConnectToDialog(string title, string buttonText, Form parentForm) : base(title, buttonText, parentForm)
		{
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00006690 File Offset: 0x00004890
		// (set) Token: 0x06000125 RID: 293 RVA: 0x00006698 File Offset: 0x00004898
		public TemporaryServer Server { get; private set; }

		// Token: 0x06000126 RID: 294 RVA: 0x000066A4 File Offset: 0x000048A4
		public static ConnectToDialog NewConnectToDialog(Form parentForm)
		{
			ConnectToDialog connectToDialog = new ConnectToDialog("Connect To", "Connect", parentForm);
			connectToDialog.Server = TemporaryServer.CreateForQuickConnect();
			connectToDialog.CreateControls(true, connectToDialog.Server.LogonCredentials, connectToDialog.Server.ConnectionSettings, null);
			return connectToDialog;
		}
	}
}
