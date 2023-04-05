using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x020000E7 RID: 231
	internal static class SortExtensions
	{
		// Token: 0x0600082A RID: 2090 RVA: 0x00022B08 File Offset: 0x00020D08
		public static void SortBuiltinGroups(this ServerTree tree)
		{
			if (tree.SuppressSorting)
			{
				return;
			}
			List<TreeNode> list = tree.Nodes.OfType<IBuiltInVirtualGroup>().Cast<TreeNode>().ToList<TreeNode>();
			tree.Nodes.SortAndRebuildNodeList(list, SortOrder.ByName);
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x00022B4C File Offset: 0x00020D4C
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

		// Token: 0x0600082C RID: 2092 RVA: 0x00022BB4 File Offset: 0x00020DB4
		public static void SortRoot(this ServerTree tree)
		{
			tree.Operation((OperationBehavior)21, delegate
			{
				tree.SortHelper(tree.Nodes, false);
				tree.SortBuiltinGroups();
			});
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x00022BEC File Offset: 0x00020DEC
		public static bool SortGroup(this ServerTree tree, GroupBase group)
		{
			return tree.SortGroup(group, false);
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x00022BF8 File Offset: 0x00020DF8
		public static bool SortGroup(this ServerTree tree, GroupBase group, bool recurse)
		{
			bool result = false;
			if (group.AllowSort)
			{
				result = tree.SortHelper(group.Nodes, recurse);
			}
			return result;
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x00022C28 File Offset: 0x00020E28
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

		// Token: 0x06000830 RID: 2096 RVA: 0x00022C68 File Offset: 0x00020E68
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

		// Token: 0x06000831 RID: 2097 RVA: 0x00022CCC File Offset: 0x00020ECC
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

		// Token: 0x06000832 RID: 2098 RVA: 0x00022E10 File Offset: 0x00021010
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

		// Token: 0x020002B1 RID: 689
		private class ServerTreeSortComparer : IComparer<TreeNode>
		{
			// Token: 0x06005755 RID: 22357 RVA: 0x0005F690 File Offset: 0x0005D890
			public ServerTreeSortComparer(SortOrder sortOrder)
			{
				this._sortOrder = sortOrder;
			}

			// Token: 0x06005756 RID: 22358 RVA: 0x0005F6A0 File Offset: 0x0005D8A0
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

			// Token: 0x04000B43 RID: 2883
			private SortOrder _sortOrder;
		}
	}
}
