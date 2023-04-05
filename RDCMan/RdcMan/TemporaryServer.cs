using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000086 RID: 134
	public class TemporaryServer : Server
	{
		// Token: 0x06000468 RID: 1128 RVA: 0x000176A0 File Offset: 0x000158A0
		protected TemporaryServer()
		{
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x000176A8 File Offset: 0x000158A8
		public static TemporaryServer CreateForQuickConnect()
		{
			return new TemporaryServer();
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x000176B0 File Offset: 0x000158B0
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

		// Token: 0x0600046B RID: 1131 RVA: 0x00017748 File Offset: 0x00015948
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
