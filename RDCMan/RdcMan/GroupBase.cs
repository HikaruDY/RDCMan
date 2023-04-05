using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using RdcMan.Configuration;

namespace RdcMan
{
	// Token: 0x02000077 RID: 119
	public abstract class GroupBase : RdcTreeNode
	{
		// Token: 0x06000387 RID: 903 RVA: 0x00013670 File Offset: 0x00011870
		static GroupBase()
		{
			Server.ConnectionStateChanged += GroupBase.Server_ConnectionStateChanged;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00013764 File Offset: 0x00011964
		private static void Server_ConnectionStateChanged(ConnectionStateChangedEventArgs args)
		{
			(args.Server.Parent as GroupBase).OnConnectionStateChange(args.Server);
			args.Server.VisitServerRefs(delegate(ServerRef r)
			{
				(r.Parent as GroupBase).OnConnectionStateChange(r);
			});
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000389 RID: 905 RVA: 0x000137C0 File Offset: 0x000119C0
		// (set) Token: 0x0600038A RID: 906 RVA: 0x000137C8 File Offset: 0x000119C8
		public bool IsReadOnly { get; protected set; }

		// Token: 0x0600038B RID: 907 RVA: 0x000137D4 File Offset: 0x000119D4
		public virtual bool CanRemoveChildren()
		{
			return base.Nodes.Count > 0 && this.AllowEdit(false);
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600038C RID: 908 RVA: 0x000137F0 File Offset: 0x000119F0
		public new GroupDisplaySettings DisplaySettings
		{
			get
			{
				return base.DisplaySettings as GroupDisplaySettings;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600038D RID: 909 RVA: 0x00013800 File Offset: 0x00011A00
		// (set) Token: 0x0600038E RID: 910 RVA: 0x00013810 File Offset: 0x00011A10
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

		// Token: 0x06000390 RID: 912 RVA: 0x00013834 File Offset: 0x00011A34
		protected override void InitSettings()
		{
			base.DisplaySettings = new GroupDisplaySettings();
			base.InitSettings();
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00013848 File Offset: 0x00011A48
		internal override void UpdateSettings(NodePropertiesDialog dlg)
		{
			base.UpdateSettings(dlg);
			base.Text = this.Properties.GroupName.Value;
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000392 RID: 914 RVA: 0x00013878 File Offset: 0x00011A78
		internal bool HasServers
		{
			get
			{
				return base.Nodes.Count != 0 && base.Nodes[0] is ServerBase;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000393 RID: 915 RVA: 0x000138A0 File Offset: 0x00011AA0
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

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000394 RID: 916 RVA: 0x00013948 File Offset: 0x00011B48
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

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000395 RID: 917 RVA: 0x00013A00 File Offset: 0x00011C00
		public virtual bool AllowSort
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00013A04 File Offset: 0x00011C04
		public override void InvalidateNode()
		{
			this._numberOfServers = -1;
			GroupBase.ResetConnectionStatistics(this);
			base.InvalidateNode();
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00013A1C File Offset: 0x00011C1C
		internal void ResetConnectionStatistics()
		{
			this.VisitNodeAndParents(delegate(RdcTreeNode group)
			{
				GroupBase.ResetConnectionStatistics((GroupBase)group);
			});
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00013A48 File Offset: 0x00011C48
		private static void ResetConnectionStatistics(GroupBase group)
		{
			group._numberOfConnectedServers = -1;
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00013A54 File Offset: 0x00011C54
		public virtual bool CanAddServers()
		{
			return this.CanDropServers();
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00013A5C File Offset: 0x00011C5C
		public virtual bool CanAddGroups()
		{
			return this.CanDropGroups();
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00013A64 File Offset: 0x00011C64
		public virtual bool CanDropServers()
		{
			return !this.HasGroups && this.AllowEdit(false);
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00013A7C File Offset: 0x00011C7C
		public virtual bool CanDropGroups()
		{
			return !this.HasServers && this.AllowEdit(false);
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00013A94 File Offset: 0x00011C94
		public virtual DragDropEffects DropBehavior()
		{
			return DragDropEffects.Move;
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600039E RID: 926 RVA: 0x00013A98 File Offset: 0x00011C98
		public bool HasGroups
		{
			get
			{
				return base.Nodes.Count > 0 && base.Nodes[0] is GroupBase;
			}
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00013AC4 File Offset: 0x00011CC4
		internal override void Show()
		{
			Program.TheForm.ShowGroup(this);
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00013AD4 File Offset: 0x00011CD4
		internal override void Hide()
		{
			Program.TheForm.HideGroup(this);
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00013AE4 File Offset: 0x00011CE4
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

		// Token: 0x060003A2 RID: 930 RVA: 0x00013B64 File Offset: 0x00011D64
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

		// Token: 0x060003A3 RID: 931 RVA: 0x00013B8C File Offset: 0x00011D8C
		public override void OnRemoving()
		{
			this.Hide();
			this.RemoveChildren();
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00013B9C File Offset: 0x00011D9C
		public override void Connect()
		{
			this.ConnectAs(null, null);
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00013BA8 File Offset: 0x00011DA8
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

		// Token: 0x060003A6 RID: 934 RVA: 0x00013C30 File Offset: 0x00011E30
		public override void Reconnect()
		{
			this.GetAllChildren((ServerBase s) => s.IsConnected).ForEach(delegate(ServerBase server)
			{
				server.Reconnect();
			});
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00013C90 File Offset: 0x00011E90
		public override void Disconnect()
		{
			NodeHelper.ThrottledDisconnect(this.GetAllChildren((ServerBase s) => s.IsConnected));
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00013CC0 File Offset: 0x00011EC0
		public override void LogOff()
		{
			foreach (ServerBase serverBase in this.GetAllChildren((ServerBase s) => s.IsConnected))
			{
				serverBase.LogOff();
				Thread.Sleep(25);
			}
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00013D44 File Offset: 0x00011F44
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

		// Token: 0x060003AA RID: 938 RVA: 0x00013DDC File Offset: 0x00011FDC
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

		// Token: 0x060003AB RID: 939 RVA: 0x00013E40 File Offset: 0x00012040
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

		// Token: 0x060003AC RID: 940 RVA: 0x00013EC8 File Offset: 0x000120C8
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

		// Token: 0x060003AD RID: 941 RVA: 0x00013F14 File Offset: 0x00012114
		internal virtual void ReadXml(XmlNode xmlNode, ICollection<string> errors)
		{
			base.ReadXml(GroupBase.NodeActions, xmlNode, errors);
		}

		// Token: 0x040001A2 RID: 418
		internal const string XmlGroupNameTag = "name";

		// Token: 0x040001A3 RID: 419
		internal const string XmlExpandedTag = "expanded";

		// Token: 0x040001A4 RID: 420
		internal const string XmlCommentTag = "comment";

		// Token: 0x040001A5 RID: 421
		internal static int SchemaVersion;

		// Token: 0x040001A6 RID: 422
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

		// Token: 0x040001A7 RID: 423
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

		// Token: 0x040001A8 RID: 424
		private int _numberOfConnectedServers = -1;

		// Token: 0x040001A9 RID: 425
		private int _numberOfServers = -1;
	}
}
