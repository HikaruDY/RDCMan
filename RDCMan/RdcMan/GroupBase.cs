using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using RdcMan.Configuration;

namespace RdcMan
{
	public abstract class GroupBase : RdcTreeNode
	{
		static GroupBase()
		{
			Server.ConnectionStateChanged += GroupBase.Server_ConnectionStateChanged;
		}

		private static void Server_ConnectionStateChanged(ConnectionStateChangedEventArgs args)
		{
			(args.Server.Parent as GroupBase).OnConnectionStateChange(args.Server);
			args.Server.VisitServerRefs(delegate(ServerRef r)
			{
				(r.Parent as GroupBase).OnConnectionStateChange(r);
			});
		}

		public bool IsReadOnly { get; protected set; }

		public virtual bool CanRemoveChildren()
		{
			return base.Nodes.Count > 0 && this.AllowEdit(false);
		}

		public new GroupDisplaySettings DisplaySettings
		{
			get
			{
				return base.DisplaySettings as GroupDisplaySettings;
			}
		}

		public new GroupSettings Properties
		{
			get
			{
				return base.Properties as GroupSettings;
			}
			set
			{
				base.Properties = value;
			}
		}

		protected override void InitSettings()
		{
			base.DisplaySettings = new GroupDisplaySettings();
			base.InitSettings();
		}

		internal override void UpdateSettings(NodePropertiesDialog dlg)
		{
			base.UpdateSettings(dlg);
			base.Text = this.Properties.GroupName.Value;
		}

		internal bool HasServers
		{
			get
			{
				return base.Nodes.Count != 0 && base.Nodes[0] is ServerBase;
			}
		}

		internal int NumberOfServers
		{
			get
			{
				if (this._numberOfServers == -1)
				{
					this._numberOfServers = 0;
					foreach (object obj in base.Nodes)
					{
						TreeNode treeNode = (TreeNode)obj;
						GroupBase groupBase = treeNode as GroupBase;
						if (groupBase != null)
						{
							this._numberOfServers += groupBase.NumberOfServers;
						}
						else
						{
							this._numberOfServers++;
						}
					}
				}
				return this._numberOfServers;
			}
		}

		internal int NumberOfConnectedServers
		{
			get
			{
				if (this._numberOfConnectedServers == -1)
				{
					this._numberOfConnectedServers = 0;
					foreach (object obj in base.Nodes)
					{
						TreeNode treeNode = (TreeNode)obj;
						GroupBase groupBase = treeNode as GroupBase;
						if (groupBase != null)
						{
							this._numberOfConnectedServers += groupBase.NumberOfConnectedServers;
						}
						else if ((treeNode as ServerBase).IsConnected)
						{
							this._numberOfConnectedServers++;
						}
					}
				}
				return this._numberOfConnectedServers;
			}
		}

		public virtual bool AllowSort
		{
			get
			{
				return true;
			}
		}

		public override void InvalidateNode()
		{
			this._numberOfServers = -1;
			GroupBase.ResetConnectionStatistics(this);
			base.InvalidateNode();
		}

		internal void ResetConnectionStatistics()
		{
			this.VisitNodeAndParents(delegate(RdcTreeNode group)
			{
				GroupBase.ResetConnectionStatistics((GroupBase)group);
			});
		}

		private static void ResetConnectionStatistics(GroupBase group)
		{
			group._numberOfConnectedServers = -1;
		}

		public virtual bool CanAddServers()
		{
			return this.CanDropServers();
		}

		public virtual bool CanAddGroups()
		{
			return this.CanDropGroups();
		}

		public virtual bool CanDropServers()
		{
			return !this.HasGroups && this.AllowEdit(false);
		}

		public virtual bool CanDropGroups()
		{
			return !this.HasServers && this.AllowEdit(false);
		}

		public virtual DragDropEffects DropBehavior()
		{
			return DragDropEffects.Move;
		}

		public bool HasGroups
		{
			get
			{
				return base.Nodes.Count > 0 && base.Nodes[0] is GroupBase;
			}
		}

		internal override void Show()
		{
			Program.TheForm.ShowGroup(this);
		}

		internal override void Hide()
		{
			Program.TheForm.HideGroup(this);
		}

		internal override void WriteXml(XmlTextWriter tw)
		{
			this.Properties.Expanded.Value = base.IsExpanded;
			base.WriteXmlSettingsGroups(tw);
			foreach (object obj in base.Nodes)
			{
				RdcTreeNode rdcTreeNode = (RdcTreeNode)obj;
				rdcTreeNode.WriteXml(tw);
			}
		}

		public void RemoveChildren()
		{
			ServerTree.Instance.Operation(OperationBehavior.SuspendSelect | OperationBehavior.SuspendSort | OperationBehavior.SuspendUpdate | OperationBehavior.SuspendGroupChanged, delegate
			{
				base.Nodes.ForEach(delegate(TreeNode node)
				{
					(node as RdcTreeNode).OnRemoving();
				});
				base.Nodes.Clear();
			});
			ServerTree.Instance.OnGroupChanged(this, ChangeType.TreeChanged);
		}

		public override void OnRemoving()
		{
			this.Hide();
			this.RemoveChildren();
		}

		public override void Connect()
		{
			this.ConnectAs(null, null);
		}

		public override void ConnectAs(LogonCredentials logonSettings, ConnectionSettings connectionSettings)
		{
			List<ServerBase> allChildren = this.GetAllChildren((ServerBase s) => !s.IsConnected);
			int count = allChildren.Count;
			if (count >= Current.RdcManSection.WarningThresholds.Connect)
			{
				DialogResult dialogResult = FormTools.YesNoDialog(base.Text + " group contains " + count.ToString() + " disconnected servers. Are you sure?");
				if (dialogResult != DialogResult.Yes)
				{
					return;
				}
			}
			NodeHelper.ThrottledConnectAs(allChildren, logonSettings, connectionSettings);
		}

		public override void Reconnect()
		{
			this.GetAllChildren((ServerBase s) => s.IsConnected).ForEach(delegate(ServerBase server)
			{
				server.Reconnect();
			});
		}

		public override void Disconnect()
		{
			NodeHelper.ThrottledDisconnect(this.GetAllChildren((ServerBase s) => s.IsConnected));
		}

		public override void LogOff()
		{
			foreach (ServerBase serverBase in this.GetAllChildren((ServerBase s) => s.IsConnected))
			{
				serverBase.LogOff();
				Thread.Sleep(25);
			}
		}

		private void OnConnectionStateChange(ServerBase server)
		{
			base.InheritSettings();
			if (!server.IsConnected)
			{
				ReconnectServerRef reconnectServerRef = server.ServerNode.FindServerRef<ReconnectServerRef>();
				if (reconnectServerRef != null && reconnectServerRef.NeedToReconnect)
				{
					return;
				}
			}
			bool flag = false;
			if (Program.Preferences.ServerSortOrder == SortOrder.ByStatus)
			{
				flag |= ServerTree.Instance.SortNode(server);
			}
			flag |= !(server.ServerNode.Parent as GroupBase).DisplaySettings.ShowDisconnectedThumbnails.Value;
			if (flag)
			{
				ServerTree.Instance.OnGroupChanged(this, ChangeType.InvalidateUI);
			}
		}

		public override bool CanDropOnTarget(RdcTreeNode targetNode)
		{
			if (targetNode == this)
			{
				return true;
			}
			GroupBase groupBase = targetNode as GroupBase;
			if (groupBase == null)
			{
				return false;
			}
			if (!groupBase.CanDropGroups())
			{
				return false;
			}
			if (!this.AllowEdit(false))
			{
				return false;
			}
			while (groupBase != null)
			{
				if (groupBase.Parent == this)
				{
					return false;
				}
				groupBase = (groupBase.Parent as GroupBase);
			}
			return true;
		}

		public override bool ConfirmRemove(bool askUser)
		{
			if (!this.CanRemove(true))
			{
				return false;
			}
			bool flag;
			bool flag2;
			this.AnyOrAllConnected(out flag, out flag2);
			if (flag)
			{
				FormTools.InformationDialog("There are active sessions in the " + base.Text + " group. Disconnect them before removing the group.");
				return false;
			}
			if (askUser && base.Nodes.Count > 0)
			{
				DialogResult dialogResult = FormTools.YesNoDialog("Remove " + base.Text + " group?");
				if (dialogResult != DialogResult.Yes)
				{
					return false;
				}
			}
			return true;
		}

		public void AnyOrAllConnected(out bool anyConnected, out bool allConnected)
		{
			bool any = false;
			bool all = true;
			base.Nodes.VisitNodes(delegate(RdcTreeNode node)
			{
				ServerBase serverBase = node as ServerBase;
				if (serverBase != null)
				{
					if (serverBase.IsConnected)
					{
						any = true;
						return;
					}
					all = false;
				}
			});
			anyConnected = any;
			allConnected = all;
		}

		internal virtual void ReadXml(XmlNode xmlNode, ICollection<string> errors)
		{
			base.ReadXml(GroupBase.NodeActions, xmlNode, errors);
		}

		internal const string XmlGroupNameTag = "name";

		internal const string XmlExpandedTag = "expanded";

		internal const string XmlCommentTag = "comment";

		internal static int SchemaVersion;

		protected static Dictionary<string, Helpers.ReadXmlDelegate> NodeActions = new Dictionary<string, Helpers.ReadXmlDelegate>
		{
			{
				"properties",
				delegate(XmlNode childNode, RdcTreeNode parent, ICollection<string> errors)
				{
					if (GroupBase.SchemaVersion <= 2)
					{
						(parent as GroupBase).ReadXml(GroupBase.PropertyActions, childNode, errors);
						return;
					}
					(parent as GroupBase).ReadXmlSettingsGroup(childNode, errors);
				}
			},
			{
				"server",
				delegate(XmlNode childNode, RdcTreeNode parent, ICollection<string> errors)
				{
					Server server = Server.Create(childNode, parent as GroupBase, errors);
					LongRunningActionForm.Instance.UpdateStatus(server.Properties.DisplayName.Value);
				}
			},
			{
				"group",
				delegate(XmlNode childNode, RdcTreeNode parent, ICollection<string> errors)
				{
					GroupBase groupBase = Group.Create(childNode, parent as GroupBase, errors);
					LongRunningActionForm.Instance.UpdateStatus(groupBase.Properties.GroupName.Value);
				}
			},
			{
				"smartGroup",
				delegate(XmlNode childNode, RdcTreeNode parent, ICollection<string> errors)
				{
					GroupBase groupBase = SmartGroup.Create(childNode, parent as GroupBase, errors);
					LongRunningActionForm.Instance.UpdateStatus(groupBase.Properties.GroupName.Value);
				}
			}
		};

		protected static Dictionary<string, Helpers.ReadXmlDelegate> PropertyActions = new Dictionary<string, Helpers.ReadXmlDelegate>
		{
			{
				"name",
				delegate(XmlNode childNode, RdcTreeNode node, ICollection<string> errors)
				{
					(node as GroupBase).Properties.GroupName.Value = childNode.InnerText;
				}
			},
			{
				"expanded",
				delegate(XmlNode childNode, RdcTreeNode node, ICollection<string> errors)
				{
					bool value;
					bool.TryParse(childNode.InnerText, out value);
					(node as GroupBase).Properties.Expanded.Value = value;
				}
			},
			{
				"comment",
				delegate(XmlNode childNode, RdcTreeNode node, ICollection<string> errors)
				{
					(node as GroupBase).Properties.Comment.Value = childNode.InnerText;
				}
			}
		};

		private int _numberOfConnectedServers = -1;

		private int _numberOfServers = -1;
	}
}
