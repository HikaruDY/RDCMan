using System;
using System.Windows.Forms;

namespace RdcMan
{
	public class TemporaryServer : Server
	{
		protected TemporaryServer()
		{
		}

		public static TemporaryServer CreateForQuickConnect()
		{
			return new TemporaryServer();
		}

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
