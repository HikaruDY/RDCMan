using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x020000E2 RID: 226
	public class TemporaryServer : Server
	{
		// Token: 0x06000585 RID: 1413 RVA: 0x00005628 File Offset: 0x00003828
		protected TemporaryServer()
		{
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00005630 File Offset: 0x00003830
		public static TemporaryServer CreateForQuickConnect()
		{
			return new TemporaryServer();
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x0001A3FC File Offset: 0x000185FC
		public static TemporaryServer Create(ConnectToDialog dlg)
		{
			TemporaryServer server = dlg.Server;
			dlg.UpdateSettings();
			server.Properties.ServerName.Value = dlg.QuickConnectTabPage.ServerNameTextBox.Text;
			server.Properties.DisplayName.Value = dlg.QuickConnectTabPage.ServerNameTextBox.Text;
			server.LogonCredentials.InheritSettingsType.Mode = InheritanceMode.None;
			server.ConnectionSettings.InheritSettingsType.Mode = InheritanceMode.None;
			server.FinishConstruction(ConnectToGroup.Instance);
			ConnectToGroup.Instance.IsInTree = true;
			return server;
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x0001A490 File Offset: 0x00018690
		public override bool CanDropOnTarget(RdcTreeNode targetNode)
		{
			if (this.FileGroup == null)
			{
				GroupBase groupBase = (targetNode as GroupBase) ?? (targetNode.Parent as GroupBase);
				return groupBase.DropBehavior() != DragDropEffects.Link && groupBase.CanDropServers();
			}
			return base.CanDropOnTarget(targetNode);
		}
	}
}
