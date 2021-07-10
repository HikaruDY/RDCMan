using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using RdcMan.Configuration;

namespace RdcMan
{
	// Token: 0x020000C3 RID: 195
	public abstract class GroupBase : RdcTreeNode
	{
		// Token: 0x0600046B RID: 1131 RVA: 0x0001745C File Offset: 0x0001565C
		static GroupBase()
		{
			Server.ConnectionStateChanged += GroupBase.Server_ConnectionStateChanged;
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x0001754C File Offset: 0x0001574C
		private static void Server_ConnectionStateChanged(ConnectionStateChangedEventArgs args)
		{
			(args.Server.Parent as GroupBase).OnConnectionStateChange(args.Server);
			args.Server.VisitServerRefs(delegate(ServerRef r)
			{
				(r.Parent as GroupBase).OnConnectionStateChange(r);
			});
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x000047DD File Offset: 0x000029DD
		// (set) Token: 0x0600046E RID: 1134 RVA: 0x000047E5 File Offset: 0x000029E5
		public bool IsReadOnly { get; protected set; }

		// Token: 0x0600046F RID: 1135 RVA: 0x000047EE File Offset: 0x000029EE
		public virtual bool CanRemoveChildren()
		{
			return base.Nodes.Count > 0 && this.AllowEdit(false);
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x00004807 File Offset: 0x00002A07
		public new GroupDisplaySettings DisplaySettings
		{
			get
			{
				return base.DisplaySettings as GroupDisplaySettings;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x00004814 File Offset: 0x00002A14
		// (set) Token: 0x06000472 RID: 1138 RVA: 0x00004821 File Offset: 0x00002A21
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

		// Token: 0x06000474 RID: 1140 RVA: 0x00004840 File Offset: 0x00002A40
		protected override void InitSettings()
		{
			base.DisplaySettings = new GroupDisplaySettings();
			base.InitSettings();
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00004853 File Offset: 0x00002A53
		internal override void UpdateSettings(NodePropertiesDialog dlg)
		{
			base.UpdateSettings(dlg);
			base.Text = this.Properties.GroupName.Value;
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x00004872 File Offset: 0x00002A72
		internal bool HasServers
		{
			get
			{
				return base.Nodes.Count != 0 && base.Nodes[0] is ServerBase;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x000175A0 File Offset: 0x000157A0
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

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x00017638 File Offset: 0x00015838
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

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x000044A3 File Offset: 0x000026A3
		public virtual bool AllowSort
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00004897 File Offset: 0x00002A97
		public override void InvalidateNode()
		{
			this._numberOfServers = -1;
			GroupBase.ResetConnectionStatistics(this);
			base.InvalidateNode();
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x000048AC File Offset: 0x00002AAC
		internal void ResetConnectionStatistics()
		{
			this.VisitNodeAndParents(delegate(RdcTreeNode group)
			{
				GroupBase.ResetConnectionStatistics((GroupBase)group);
			});
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x000048D3 File Offset: 0x00002AD3
		private static void ResetConnectionStatistics(GroupBase group)
		{
			group._numberOfConnectedServers = -1;
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x000048DC File Offset: 0x00002ADC
		public virtual bool CanAddServers()
		{
			return this.CanDropServers();
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x000048E4 File Offset: 0x00002AE4
		public virtual bool CanAddGroups()
		{
			return this.CanDropGroups();
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x000048EC File Offset: 0x00002AEC
		public virtual bool CanDropServers()
		{
			return !this.HasGroups && this.AllowEdit(false);
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x000048FF File Offset: 0x00002AFF
		public virtual bool CanDropGroups()
		{
			return !this.HasServers && this.AllowEdit(false);
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00004912 File Offset: 0x00002B12
		public virtual DragDropEffects DropBehavior()
		{
			return DragDropEffects.Move;
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x00004915 File Offset: 0x00002B15
		public bool HasGroups
		{
			get
			{
				return base.Nodes.Count > 0 && base.Nodes[0] is GroupBase;
			}
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0000493B File Offset: 0x00002B3B
		internal override void Show()
		{
			Program.TheForm.ShowGroup(this);
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00004948 File Offset: 0x00002B48
		internal override void Hide()
		{
			Program.TheForm.HideGroup(this);
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x000176DC File Offset: 0x000158DC
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

		// Token: 0x06000486 RID: 1158 RVA: 0x00004955 File Offset: 0x00002B55
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

		// Token: 0x06000487 RID: 1159 RVA: 0x0000497B File Offset: 0x00002B7B
		public override void OnRemoving()
		{
			this.Hide();
			this.RemoveChildren();
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00004989 File Offset: 0x00002B89
		public override void Connect()
		{
			this.ConnectAs(null, null);
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00017754 File Offset: 0x00015954
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

		// Token: 0x0600048A RID: 1162 RVA: 0x000177D0 File Offset: 0x000159D0
		public override void Reconnect()
		{
			this.GetAllChildren((ServerBase s) => s.IsConnected).ForEach(delegate(ServerBase server)
			{
				server.Reconnect();
			});
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00004993 File Offset: 0x00002B93
		public override void Disconnect()
		{
			NodeHelper.ThrottledDisconnect(this.GetAllChildren((ServerBase s) => s.IsConnected));
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00017828 File Offset: 0x00015A28
		public override void LogOff()
		{
			foreach (ServerBase serverBase in this.GetAllChildren((ServerBase s) => s.IsConnected))
			{
				serverBase.LogOff();
				Thread.Sleep(25);
			}
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x000178A0 File Offset: 0x00015AA0
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

		// Token: 0x0600048E RID: 1166 RVA: 0x00017924 File Offset: 0x00015B24
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

		// Token: 0x0600048F RID: 1167 RVA: 0x00017974 File Offset: 0x00015B74
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

		// Token: 0x06000490 RID: 1168 RVA: 0x000179E8 File Offset: 0x00015BE8
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

		// Token: 0x06000491 RID: 1169 RVA: 0x000049BF File Offset: 0x00002BBF
		internal virtual void ReadXml(XmlNode xmlNode, ICollection<string> errors)
		{
			base.ReadXml(GroupBase.NodeActions, xmlNode, errors);
		}

		// Token: 0x0400041B RID: 1051
		internal const string XmlGroupNameTag = "name";

		// Token: 0x0400041C RID: 1052
		internal const string XmlExpandedTag = "expanded";

		// Token: 0x0400041D RID: 1053
		internal const string XmlCommentTag = "comment";

		// Token: 0x0400041E RID: 1054
		internal static int SchemaVersion;

		// Token: 0x0400041F RID: 1055
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

		// Token: 0x04000420 RID: 1056
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

		// Token: 0x04000421 RID: 1057
		private int _numberOfConnectedServers = -1;

		// Token: 0x04000422 RID: 1058
		private int _numberOfServers = -1;
	}
}
