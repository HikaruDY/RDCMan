using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000015 RID: 21
	public static class AddNodeDialogHelper
	{
		// Token: 0x06000038 RID: 56 RVA: 0x00002534 File Offset: 0x00000734
		public static void AddServersDialog()
		{
			AddNodeDialogHelper.AddServersDialog(ServerTree.Instance.SelectedNode);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002548 File Offset: 0x00000748
		public static void AddServersDialog(TreeNode suggestedParentNode)
		{
			if (!ServerTree.Instance.AnyOpenedEditableFiles())
			{
				AddNodeDialogHelper.NotifyUserFileNeeded();
				return;
			}
			if (!ServerTree.Instance.Nodes.OfType<FileGroup>().Any<FileGroup>() && FormTools.YesNoDialog("RDCMan does not allow mixing of servers and groups. If you add a server to a top-level file group you will not be able to add any groups to that file. Continue?") != DialogResult.Yes)
			{
				return;
			}
			GroupBase groupBase = AddNodeDialogHelper.GetParentGroupForServerAdd(suggestedParentNode);
			ServerPropertiesDialog dlg = ServerPropertiesDialog.NewAddDialog(groupBase);
			if (dlg == null)
			{
				FormTools.InformationDialog("RDCMan does not allow mixing of servers and groups. In order to add a group to this file you must first remove the servers.");
				return;
			}
			using (dlg)
			{
				if (dlg.ShowDialog() != DialogResult.OK)
				{
					return;
				}
				groupBase = dlg.PropertiesPage.ParentGroup;
				Server server = dlg.AssociatedNode as Server;
				server.UpdateSettings(dlg);
				ServerTree.Instance.Operation(OperationBehavior.SuspendSort | OperationBehavior.SuspendUpdate | OperationBehavior.SuspendGroupChanged, delegate
				{
					List<string> expandedServerNames = (dlg.PropertiesPage as ServerPropertiesTabPage).ExpandedServerNames;
					if (expandedServerNames.Count == 1)
					{
						Server.Create(dlg);
						return;
					}
					foreach (string name in expandedServerNames)
					{
						Server.Create(name, dlg);
					}
				});
			}
			AddNodeDialogHelper.FinishAddServers(groupBase);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002650 File Offset: 0x00000850
		private static void FinishAddServers(GroupBase parentGroup)
		{
			ServerTree.Instance.SortGroup(parentGroup);
			ServerTree.Instance.OnGroupChanged(parentGroup, ChangeType.TreeChanged);
			ServerTree.Instance.SelectedNode = parentGroup;
			parentGroup.Expand();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000267C File Offset: 0x0000087C
		public static void ImportServersDialog()
		{
			AddNodeDialogHelper.ImportServersDialog(ServerTree.Instance.SelectedNode);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002690 File Offset: 0x00000890
		public static void ImportServersDialog(TreeNode parentGroup)
		{
			if (!ServerTree.Instance.AnyOpenedEditableFiles())
			{
				AddNodeDialogHelper.NotifyUserFileNeeded();
				return;
			}
			using (ServerPropertiesDialog dlg = ServerPropertiesDialog.NewImportDialog(AddNodeDialogHelper.GetParentGroupForServerAdd(parentGroup)))
			{
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					GroupBase group = dlg.PropertiesPage.ParentGroup;
					ServerTree.Instance.Operation(OperationBehavior.SuspendSort | OperationBehavior.SuspendUpdate | OperationBehavior.SuspendGroupChanged, delegate
					{
						Server server = dlg.AssociatedNode as Server;
						server.UpdateSettings(dlg);
						using (List<string>.Enumerator enumerator = (dlg.PropertiesPage as ImportServersPropertiesPage).ExpandedServerNames.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								string serverName = enumerator.Current;
								Server server2 = (from s in @group.Nodes.OfType<Server>()
								where s.ServerName == serverName
								select s).FirstOrDefault<Server>();
								if (server2 != null)
								{
									server2.UpdateFromTemplate(server);
								}
								else
								{
									Server.Create(serverName, dlg);
								}
							}
						}
					});
					AddNodeDialogHelper.FinishAddServers(group);
				}
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002744 File Offset: 0x00000944
		public static void AddGroupDialog()
		{
			AddNodeDialogHelper.AddGroupDialog(ServerTree.Instance.SelectedNode);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002758 File Offset: 0x00000958
		public static void AddGroupDialog(TreeNode suggestedParentNode)
		{
			if (!ServerTree.Instance.AnyOpenedEditableFiles())
			{
				AddNodeDialogHelper.NotifyUserFileNeeded();
				return;
			}
			GroupBase parentGroupForGroupAdd = AddNodeDialogHelper.GetParentGroupForGroupAdd(suggestedParentNode);
			GroupPropertiesDialog groupPropertiesDialog = GroupPropertiesDialog.NewAddDialog(parentGroupForGroupAdd);
			if (groupPropertiesDialog == null)
			{
				FormTools.InformationDialog("RDCMan does not allow mixing of servers and groups. In order to add a group to this file you must first remove the servers.");
				return;
			}
			using (groupPropertiesDialog)
			{
				if (groupPropertiesDialog.ShowDialog() == DialogResult.OK)
				{
					ServerTree.Instance.SelectedNode = Group.Create(groupPropertiesDialog);
				}
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000027E0 File Offset: 0x000009E0
		public static void AddSmartGroupDialog()
		{
			AddNodeDialogHelper.AddSmartGroupDialog(ServerTree.Instance.SelectedNode);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000027F4 File Offset: 0x000009F4
		public static void AddSmartGroupDialog(TreeNode suggestedParentNode)
		{
			if (!ServerTree.Instance.AnyOpenedEditableFiles())
			{
				AddNodeDialogHelper.NotifyUserFileNeeded();
				return;
			}
			GroupBase parentGroupForGroupAdd = AddNodeDialogHelper.GetParentGroupForGroupAdd(suggestedParentNode);
			SmartGroupPropertiesDialog smartGroupPropertiesDialog = SmartGroupPropertiesDialog.NewAddDialog(parentGroupForGroupAdd);
			if (smartGroupPropertiesDialog == null)
			{
				FormTools.InformationDialog("RDCMan does not allow mixing of servers and groups. In order to add a group to this file you must first remove the servers.");
				return;
			}
			using (smartGroupPropertiesDialog)
			{
				if (smartGroupPropertiesDialog.ShowDialog() == DialogResult.OK)
				{
					ServerTree.Instance.SelectedNode = SmartGroup.Create(smartGroupPropertiesDialog);
				}
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000287C File Offset: 0x00000A7C
		private static GroupBase GetParentGroupForServerAdd(TreeNode node)
		{
			GroupBase groupBase = null;
			if (node != null)
			{
				groupBase = ((node as GroupBase) ?? (node.Parent as GroupBase));
				while (groupBase != null && !groupBase.CanAddServers())
				{
					groupBase = (groupBase.Parent as GroupBase);
				}
			}
			return groupBase;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000028D0 File Offset: 0x00000AD0
		private static GroupBase GetParentGroupForGroupAdd(TreeNode node)
		{
			GroupBase groupBase = null;
			if (node != null)
			{
				groupBase = ((node as GroupBase) ?? (node.Parent as GroupBase));
				while (groupBase != null && !groupBase.CanAddGroups())
				{
					groupBase = (groupBase.Parent as GroupBase);
				}
			}
			return groupBase;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002924 File Offset: 0x00000B24
		private static void NotifyUserFileNeeded()
		{
			FormTools.InformationDialog("Please open an existing non-read-only file (File.Open) or create a new one (File.New) before adding servers/groups");
		}
	}
}
