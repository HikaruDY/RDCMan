using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Win32;

namespace RdcMan
{
	// Token: 0x0200006A RID: 106
	internal static class NodeHelper
	{
		// Token: 0x060002F7 RID: 759 RVA: 0x00011FB4 File Offset: 0x000101B4
		public static TreeNodeCollection GetParentNodes(this TreeNode node)
		{
			TreeNode parent = node.Parent;
			if (parent != null)
			{
				return parent.Nodes;
			}
			return node.TreeView.Nodes;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00011FE4 File Offset: 0x000101E4
		public static void VisitNodes(this RdcTreeNode node, Action<RdcTreeNode> callback)
		{
			callback(node);
			node.Nodes.VisitNodes(callback);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00011FFC File Offset: 0x000101FC
		public static void VisitNodes(this ICollection nodes, Action<RdcTreeNode> callback)
		{
			foreach (object obj in nodes)
			{
				RdcTreeNode node = (RdcTreeNode)obj;
				node.VisitNodes(callback);
			}
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0001205C File Offset: 0x0001025C
		public static bool VisitNodes(this RdcTreeNode node, Func<RdcTreeNode, NodeVisitorResult> callback)
		{
			NodeVisitorResult nodeVisitorResult = callback(node);
			return nodeVisitorResult == NodeVisitorResult.NoRecurse || (nodeVisitorResult != NodeVisitorResult.Break && node.Nodes.VisitNodes(callback));
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00012094 File Offset: 0x00010294
		public static bool VisitNodes(this ICollection nodes, Func<RdcTreeNode, NodeVisitorResult> callback)
		{
			foreach (object obj in nodes)
			{
				RdcTreeNode node = (RdcTreeNode)obj;
				if (!node.VisitNodes(callback))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00012100 File Offset: 0x00010300
		public static void VisitNodeAndParents(this RdcTreeNode node, Action<RdcTreeNode> callback)
		{
			callback(node);
			node.VisitParents(callback);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00012110 File Offset: 0x00010310
		public static void VisitParents(this RdcTreeNode node, Action<RdcTreeNode> callback)
		{
			for (RdcTreeNode rdcTreeNode = node.Parent as RdcTreeNode; rdcTreeNode != null; rdcTreeNode = (rdcTreeNode.Parent as RdcTreeNode))
			{
				callback(rdcTreeNode);
			}
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00012148 File Offset: 0x00010348
		public static void VisitNodeAndParents(this RdcTreeNode node, Func<RdcTreeNode, NodeVisitorResult> callback)
		{
			if (callback(node) == NodeVisitorResult.Continue)
			{
				node.VisitParents(callback);
			}
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00012170 File Offset: 0x00010370
		public static void VisitParents(this RdcTreeNode node, Func<RdcTreeNode, NodeVisitorResult> callback)
		{
			RdcTreeNode rdcTreeNode = node.Parent as RdcTreeNode;
			while (rdcTreeNode != null && callback(rdcTreeNode) == NodeVisitorResult.Continue)
			{
				rdcTreeNode = (rdcTreeNode.Parent as RdcTreeNode);
			}
		}

		// Token: 0x06000300 RID: 768 RVA: 0x000121B0 File Offset: 0x000103B0
		public static List<TNode> GetAllChildren<TNode>(this RdcTreeNode parent, Predicate<TNode> predicate) where TNode : RdcTreeNode
		{
			List<TNode> children = new List<TNode>(parent.Nodes.Count);
			parent.VisitNodes(delegate(RdcTreeNode child)
			{
				TNode tnode = child as TNode;
				if (tnode != null && predicate(tnode))
				{
					children.Add(tnode);
				}
			});
			return children;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x000121FC File Offset: 0x000103FC
		public static void AnyOrAllConnected(IEnumerable<ServerBase> servers, out bool anyConnected, out bool allConnected)
		{
			anyConnected = false;
			allConnected = true;
			foreach (ServerBase serverBase in servers)
			{
				if (serverBase.IsConnected)
				{
					anyConnected = true;
				}
				else
				{
					allConnected = false;
				}
			}
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00012264 File Offset: 0x00010464
		public static void SelectNewActiveConnection(bool selectPrevious)
		{
			List<ServerBase> connectedServers = new List<ServerBase>();
			ConnectedGroup.Instance.Nodes.VisitNodes(delegate(RdcTreeNode node)
			{
				connectedServers.Add(node as ServerBase);
			});
			connectedServers.Sort((ServerBase a, ServerBase b) => (b as ConnectedServerRef).LastFocusTime.CompareTo((a as ConnectedServerRef).LastFocusTime));
			ServerBase serverBase = null;
			if (selectPrevious)
			{
				serverBase = connectedServers[Math.Min(1, connectedServers.Count - 1)];
			}
			else
			{
				using (SelectActiveServerForm selectActiveServerForm = new SelectActiveServerForm(connectedServers))
				{
					if (selectActiveServerForm.ShowDialog() == DialogResult.OK)
					{
						SelectActiveServerForm.SelectedObject selected = selectActiveServerForm.Selected;
						switch (selected.Operation)
						{
						case SelectActiveServerForm.Operation.SelectServer:
							serverBase = selected.Server;
							break;
						case SelectActiveServerForm.Operation.SelectTree:
							Program.TheForm.GoToServerTree();
							break;
						case SelectActiveServerForm.Operation.MinimizeWindow:
						{
							IntPtr window = User.GetWindow(Program.TheForm.Handle, 2U);
							User.SetForegroundWindow(window);
							Program.TheForm.WindowState = FormWindowState.Minimized;
							break;
						}
						}
					}
				}
			}
			if (serverBase != null)
			{
				Program.TheForm.SwitchFullScreenClient(serverBase.ServerNode);
				ServerTree.Instance.SelectedNode = serverBase;
				serverBase.Focus();
			}
		}

		// Token: 0x06000303 RID: 771 RVA: 0x000123C0 File Offset: 0x000105C0
		public static void ThrottledConnect(IEnumerable<ServerBase> servers)
		{
			NodeHelper.ThrottledConnectAs(servers, null, null);
		}

		// Token: 0x06000304 RID: 772 RVA: 0x000123CC File Offset: 0x000105CC
		public static void ThrottledConnect(IEnumerable<ServerBase> servers, Action<ServerBase> postConnectAction)
		{
			NodeHelper.ThrottledConnectAs(servers, null, null, postConnectAction);
		}

		// Token: 0x06000305 RID: 773 RVA: 0x000123D8 File Offset: 0x000105D8
		public static void ThrottledConnectAs(IEnumerable<ServerBase> servers, LogonCredentials logonCredentials, ConnectionSettings connectionSettings)
		{
			NodeHelper.ThrottledConnectAs(servers, logonCredentials, connectionSettings, delegate(ServerBase s)
			{
			});
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00012414 File Offset: 0x00010614
		public static void ThrottledConnectAs(IEnumerable<ServerBase> servers, LogonCredentials logonCredentials, ConnectionSettings connectionSettings, Action<ServerBase> postConnectAction)
		{
			RdpClient.ConnectionState[] array = new RdpClient.ConnectionState[2];
			array[0] = RdpClient.ConnectionState.Connected;
			NodeHelper.ThrottledOperation(servers, array, delegate(ServerBase server)
			{
				server.ConnectAs(logonCredentials, connectionSettings);
				postConnectAction(server);
			}, 125);
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00012460 File Offset: 0x00010660
		public static void ThrottledDisconnect(IEnumerable<ServerBase> servers)
		{
			NodeHelper.ThrottledOperation(servers, new RdpClient.ConnectionState[1], delegate(ServerBase server)
			{
				server.Disconnect();
			}, 25);
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00012494 File Offset: 0x00010694
		private static void ThrottledOperation(IEnumerable<ServerBase> servers, IEnumerable<RdpClient.ConnectionState> completionStates, Action<ServerBase> operation, int delayInMilliseconds)
		{
			List<ServerBase> serversList = servers.ToList<ServerBase>();
			if (serversList.Count == 0)
			{
				return;
			}
			Action<ServerBase> <>9__2;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				List<ServerBase> serversList = serversList;
				IEnumerable<RdpClient.ConnectionState> completionStates2 = completionStates;
				Action preAction = delegate()
				{
					ServerTree.Instance.SuspendSort();
				};
				Action<ServerBase> action;
				if ((action = <>9__2) == null)
				{
					action = (<>9__2 = delegate(ServerBase server)
					{
						Program.TheForm.Invoke(new MethodInvoker(delegate()
						{
							operation(server);
						}));
					});
				}
				using (ThrottledOperation throttledOperation = new ThrottledOperation(serversList, completionStates2, preAction, action, delayInMilliseconds, delegate()
				{
					Program.TheForm.Invoke(new MethodInvoker(delegate()
					{
						ServerTree.Instance.ResumeSort();
						ServerTree.Instance.SortAllNodes();
					}));
				}))
				{
					throttledOperation.Execute();
				}
			});
		}

		// Token: 0x04000181 RID: 385
		private const int ThrottledConnectDelayInMilliseconds = 125;

		// Token: 0x04000182 RID: 386
		private const int ThrottledDisconnectDelayInMilliseconds = 25;
	}
}
