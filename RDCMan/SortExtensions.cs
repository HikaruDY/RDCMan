using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x0200017F RID: 383
	internal static class SortExtensions
	{
		// Token: 0x060009C9 RID: 2505 RVA: 0x00021D10 File Offset: 0x0001FF10
		public static void SortBuiltinGroups(this ServerTree tree)
		{
			if (tree.SuppressSorting)
			{
				return;
			}
			List<TreeNode> list = tree.Nodes.OfType<IBuiltInVirtualGroup>().Cast<TreeNode>().ToList<TreeNode>();
			tree.Nodes.SortAndRebuildNodeList(list, SortOrder.ByName);
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x00021D4C File Offset: 0x0001FF4C
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

		// Token: 0x060009CB RID: 2507 RVA: 0x00021DAC File Offset: 0x0001FFAC
		public static void SortRoot(this ServerTree tree)
		{
			tree.Operation((OperationBehavior)21, delegate
			{
				tree.SortHelper(tree.Nodes, false);
				tree.SortBuiltinGroups();
			});
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x0000820F File Offset: 0x0000640F
		public static bool SortGroup(this ServerTree tree, GroupBase group)
		{
			return tree.SortGroup(group, false);
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x00021DE0 File Offset: 0x0001FFE0
		public static bool SortGroup(this ServerTree tree, GroupBase group, bool recurse)
		{
			bool result = false;
			if (group.AllowSort)
			{
				result = tree.SortHelper(group.Nodes, recurse);
			}
			return result;
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x00021E08 File Offset: 0x00020008
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

		// Token: 0x060009CF RID: 2511 RVA: 0x00021E3C File Offset: 0x0002003C
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

		// Token: 0x060009D0 RID: 2512 RVA: 0x00021E9C File Offset: 0x0002009C
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

		// Token: 0x060009D1 RID: 2513 RVA: 0x00021FC0 File Offset: 0x000201C0
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

		// Token: 0x02000180 RID: 384
		private class ServerTreeSortComparer : IComparer<TreeNode>
		{
			// Token: 0x060009D2 RID: 2514 RVA: 0x00008219 File Offset: 0x00006419
			public ServerTreeSortComparer(SortOrder sortOrder)
			{
				this._sortOrder = sortOrder;
			}

			// Token: 0x060009D3 RID: 2515 RVA: 0x00022050 File Offset: 0x00020250
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

			// Token: 0x04000673 RID: 1651
			private SortOrder _sortOrder;
		}
	}
}
