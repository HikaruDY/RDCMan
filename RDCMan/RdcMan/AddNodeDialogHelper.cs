using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RdcMan
{
	public static class AddNodeDialogHelper
	{
		public static void AddServersDialog()
		{
			AddNodeDialogHelper.AddServersDialog(ServerTree.Instance.SelectedNode);
		}

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

		private static void FinishAddServers(GroupBase parentGroup)
		{
			ServerTree.Instance.SortGroup(parentGroup);
			ServerTree.Instance.OnGroupChanged(parentGroup, ChangeType.TreeChanged);
			ServerTree.Instance.SelectedNode = parentGroup;
			parentGroup.Expand();
		}

		public static void ImportServersDialog()
		{
			AddNodeDialogHelper.ImportServersDialog(ServerTree.Instance.SelectedNode);
		}

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

		public static void AddGroupDialog()
		{
			AddNodeDialogHelper.AddGroupDialog(ServerTree.Instance.SelectedNode);
		}

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

		public static void AddSmartGroupDialog()
		{
			AddNodeDialogHelper.AddSmartGroupDialog(ServerTree.Instance.SelectedNode);
		}

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

		private static void NotifyUserFileNeeded()
		{
			FormTools.InformationDialog("Please open an existing non-read-only file (File.Open) or create a new one (File.New) before adding servers/groups");
		}
	}
}
