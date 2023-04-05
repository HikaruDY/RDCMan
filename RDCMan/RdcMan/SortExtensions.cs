using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RdcMan
{
	internal static class SortExtensions
	{
		public static void SortBuiltinGroups(this ServerTree tree)
		{
			if (tree.SuppressSorting)
			{
				return;
			}
			List<TreeNode> list = tree.Nodes.OfType<IBuiltInVirtualGroup>().Cast<TreeNode>().ToList<TreeNode>();
			tree.Nodes.SortAndRebuildNodeList(list, SortOrder.ByName);
		}

		public static void SortAllNodes(this ServerTree tree)
		{
			using (Helpers.Timer("sorting all nodes", Array.Empty<object>()))
			{
				tree.Operation(OperationBehavior.RestoreSelected, delegate
				{
					tree.SortHelper(tree.Nodes, true);
					tree.SortBuiltinGroups();
				});
			}
		}

		public static void SortRoot(this ServerTree tree)
		{
			tree.Operation((OperationBehavior)21, delegate
			{
				tree.SortHelper(tree.Nodes, false);
				tree.SortBuiltinGroups();
			});
		}

		public static bool SortGroup(this ServerTree tree, GroupBase group)
		{
			return tree.SortGroup(group, false);
		}

		public static bool SortGroup(this ServerTree tree, GroupBase group, bool recurse)
		{
			bool result = false;
			if (group.AllowSort)
			{
				result = tree.SortHelper(group.Nodes, recurse);
			}
			return result;
		}

		public static bool SortNode(this ServerTree tree, RdcTreeNode node)
		{
			GroupBase groupBase = node.Parent as GroupBase;
			if (groupBase != null)
			{
				return tree.SortGroup(groupBase);
			}
			if (node.Parent == null)
			{
				tree.SortRoot();
			}
			return false;
		}

		private static bool SortHelper(this ServerTree tree, TreeNodeCollection nodes, bool recurse)
		{
			if (tree.SuppressSorting)
			{
				return false;
			}
			bool anyChanged = false;
			tree.Operation((OperationBehavior)21, delegate
			{
				anyChanged = tree.SortNodes(nodes, recurse);
			});
			return anyChanged;
		}

		private static bool SortNodes(this ServerTree tree, TreeNodeCollection nodes, bool recurse)
		{
			List<TreeNode> list = new List<TreeNode>(nodes.Count);
			List<TreeNode> list2 = new List<TreeNode>(nodes.Count);
			foreach (object obj in nodes)
			{
				TreeNode treeNode = (TreeNode)obj;
				if (treeNode is ServerBase)
				{
					list2.Add(treeNode);
				}
				else
				{
					list.Add(treeNode);
				}
			}
			bool flag = false;
			if (recurse)
			{
				foreach (GroupBase groupBase in from g in list.OfType<GroupBase>()
				where g.AllowSort
				select g)
				{
					flag |= tree.SortNodes(groupBase.Nodes, true);
				}
			}
			flag |= nodes.SortAndRebuildNodeList(list, Program.Preferences.GroupSortOrder);
			flag |= nodes.SortAndRebuildNodeList(list2, Program.Preferences.ServerSortOrder);
			return flag;
		}

		private static bool SortAndRebuildNodeList(this TreeNodeCollection nodes, List<TreeNode> list, SortOrder sortOrder)
		{
			if (list.Count == 0 || sortOrder == SortOrder.None)
			{
				return false;
			}
			list.Sort(new SortExtensions.ServerTreeSortComparer(sortOrder));
			TreeNode treeNode = nodes[0];
			bool result = false;
			foreach (TreeNode treeNode2 in list)
			{
				if (treeNode2 == treeNode)
				{
					treeNode = treeNode.NextNode;
				}
				else
				{
					result = true;
					nodes.Remove(treeNode2);
					nodes.Insert(treeNode.Index, treeNode2);
				}
			}
			return result;
		}

		private class ServerTreeSortComparer : IComparer<TreeNode>
		{
			public ServerTreeSortComparer(SortOrder sortOrder)
			{
				this._sortOrder = sortOrder;
			}

			public int Compare(TreeNode treeNode1, TreeNode treeNode2)
			{
				if (this._sortOrder == SortOrder.ByStatus)
				{
					ImageConstants imageConstants = ServerTree.TranslateImage((ImageConstants)treeNode1.ImageIndex, false);
					ImageConstants imageConstants2 = ServerTree.TranslateImage((ImageConstants)treeNode2.ImageIndex, false);
					int num = imageConstants2 - imageConstants;
					if (num != 0)
					{
						return num;
					}
				}
				return Helpers.NaturalCompare(treeNode1.Text, treeNode2.Text);
			}

			private SortOrder _sortOrder;
		}
	}
}
