using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Win32;

namespace RdcMan
{
	// Token: 0x020000AC RID: 172
	internal static class NodeHelper
	{
		// Token: 0x060003BB RID: 955 RVA: 0x00016398 File Offset: 0x00014598
		public static TreeNodeCollection GetParentNodes(this TreeNode node)
		{
			TreeNode parent = node.Parent;
			if (parent != null)
			{
				return parent.Nodes;
			}
			return node.TreeView.Nodes;
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0000413D File Offset: 0x0000233D
		public static void VisitNodes(this RdcTreeNode node, Action<RdcTreeNode> callback)
		{
			callback(node);
			node.Nodes.VisitNodes(callback);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x000163C4 File Offset: 0x000145C4
		public static void VisitNodes(this ICollection nodes, Action<RdcTreeNode> callback)
		{
			foreach (object obj in nodes)
			{
				RdcTreeNode node = (RdcTreeNode)obj;
				node.VisitNodes(callback);
			}
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00016418 File Offset: 0x00014618
		public static bool VisitNodes(this RdcTreeNode node, Func<RdcTreeNode, NodeVisitorResult> callback)
		{
			NodeVisitorResult nodeVisitorResult = callback(node);
			return nodeVisitorResult == NodeVisitorResult.NoRecurse || (nodeVisitorResult != NodeVisitorResult.Break && node.Nodes.VisitNodes(callback));
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00016448 File Offset: 0x00014648
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

		// Token: 0x060003C0 RID: 960 RVA: 0x00004152 File Offset: 0x00002352
		public static void VisitNodeAndParents(this RdcTreeNode node, Action<RdcTreeNode> callback)
		{
			callback(node);
			node.VisitParents(callback);
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x000164A8 File Offset: 0x000146A8
		public static void VisitParents(this RdcTreeNode node, Action<RdcTreeNode> callback)
		{
			for (RdcTreeNode rdcTreeNode = node.Parent as RdcTreeNode; rdcTreeNode != null; rdcTreeNode = (rdcTreeNode.Parent as RdcTreeNode))
			{
				callback(rdcTreeNode);
			}
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x000164DC File Offset: 0x000146DC
		public static void VisitNodeAndParents(this RdcTreeNode node, Func<RdcTreeNode, NodeVisitorResult> callback)
		{
			if (callback(node) == NodeVisitorResult.Continue)
			{
				node.VisitParents(callback);
			}
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x000164FC File Offset: 0x000146FC
		public static void VisitParents(this RdcTreeNode node, Func<RdcTreeNode, NodeVisitorResult> callback)
		{
			RdcTreeNode rdcTreeNode = node.Parent as RdcTreeNode;
			while (rdcTreeNode != null && callback(rdcTreeNode) == NodeVisitorResult.Continue)
			{
				rdcTreeNode = (rdcTreeNode.Parent as RdcTreeNode);
			}
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00016534 File Offset: 0x00014734
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

		// Token: 0x060003C5 RID: 965 RVA: 0x0001657C File Offset: 0x0001477C
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

		// Token: 0x060003C6 RID: 966 RVA: 0x000165D4 File Offset: 0x000147D4
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
							IntPtr window = User.GetWindow(Program.TheForm.Handle, 2u);
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

		// Token: 0x060003C7 RID: 967 RVA: 0x00004162 File Offset: 0x00002362
		public static void ThrottledConnect(IEnumerable<ServerBase> servers)
		{
			NodeHelper.ThrottledConnectAs(servers, null, null);
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0000416C File Offset: 0x0000236C
		public static void ThrottledConnect(IEnumerable<ServerBase> servers, Action<ServerBase> postConnectAction)
		{
			NodeHelper.ThrottledConnectAs(servers, null, null, postConnectAction);
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00004177 File Offset: 0x00002377
		public static void ThrottledConnectAs(IEnumerable<ServerBase> servers, LogonCredentials logonCredentials, ConnectionSettings connectionSettings)
		{
			NodeHelper.ThrottledConnectAs(servers, logonCredentials, connectionSettings, delegate(ServerBase s)
			{
			});
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00016714 File Offset: 0x00014914
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

		// Token: 0x060003CB RID: 971 RVA: 0x000041A0 File Offset: 0x000023A0
		public static void ThrottledDisconnect(IEnumerable<ServerBase> servers)
		{
			NodeHelper.ThrottledOperation(servers, new RdpClient.ConnectionState[1], delegate(ServerBase server)
			{
				server.Disconnect();
			}, 25);
		}

		// Token: 0x060003CC RID: 972 RVA: 0x0001675C File Offset: 0x0001495C
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

		// Token: 0x040003DD RID: 989
		private const int ThrottledConnectDelayInMilliseconds = 125;

		// Token: 0x040003DE RID: 990
		private const int ThrottledDisconnectDelayInMilliseconds = 25;
	}
}
