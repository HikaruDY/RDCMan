using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	// Token: 0x020000B7 RID: 183
	internal abstract class BuiltInVirtualGroup<TServerRef> : VirtualGroup, IBuiltInVirtualGroup where TServerRef : ServerRef
	{
		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x000043B8 File Offset: 0x000025B8
		string IBuiltInVirtualGroup.Text
		{
			get
			{
				return base.Text;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x000043C0 File Offset: 0x000025C0
		string IBuiltInVirtualGroup.ConfigPropertyName
		{
			get
			{
				return this.ConfigName;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x000043C8 File Offset: 0x000025C8
		string IBuiltInVirtualGroup.XmlNodeName
		{
			get
			{
				return this.XmlNodeName;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x000043D0 File Offset: 0x000025D0
		// (set) Token: 0x060003FF RID: 1023 RVA: 0x000043DB File Offset: 0x000025DB
		bool IBuiltInVirtualGroup.IsInTree
		{
			get
			{
				return base.TreeView != null;
			}
			set
			{
				this.UpdateVisibleInTree(value);
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x000043E4 File Offset: 0x000025E4
		bool IBuiltInVirtualGroup.IsVisibilityConfigurable
		{
			get
			{
				return this.IsVisibilityConfigurable;
			}
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x000043EC File Offset: 0x000025EC
		void IBuiltInVirtualGroup.ReadXml(XmlNode xmlNode, FileGroup fileGroup, ICollection<string> errors)
		{
			this.ReadXml(xmlNode, fileGroup, errors);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x000043F7 File Offset: 0x000025F7
		void IBuiltInVirtualGroup.WriteXml(XmlTextWriter tw, FileGroup fileGroup)
		{
			this.WriteXml(tw, fileGroup);
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00004401 File Offset: 0x00002601
		bool IBuiltInVirtualGroup.ShouldWriteNode(ServerRef serverRef, FileGroup file)
		{
			return this.ShouldWriteNode(serverRef, file);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0000440B File Offset: 0x0000260B
		static BuiltInVirtualGroup()
		{
			BuiltInVirtualGroup<TServerRef>.NodeActions["server"] = delegate(XmlNode childNode, RdcTreeNode parent, ICollection<string> errors)
			{
				TreeNode treeNode = ServerTree.Instance.FindNodeByName(childNode.InnerText);
				if (treeNode != null)
				{
					Server server = treeNode as Server;
					if (server != null)
					{
						(parent as BuiltInVirtualGroup<TServerRef>).AddReference(server);
					}
				}
			};
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x000043B8 File Offset: 0x000025B8
		public virtual string ConfigName
		{
			get
			{
				return base.Text;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x000043D0 File Offset: 0x000025D0
		// (set) Token: 0x06000407 RID: 1031 RVA: 0x000043DB File Offset: 0x000025DB
		public bool IsInTree
		{
			get
			{
				return base.TreeView != null;
			}
			set
			{
				this.UpdateVisibleInTree(value);
			}
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x0000443B File Offset: 0x0000263B
		public override void OnRemoving()
		{
			this.Hide();
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00004443 File Offset: 0x00002643
		public sealed override bool ConfirmRemove(bool askUser)
		{
			FormTools.InformationDialog("Use the View menu to hide the " + base.Text + " group");
			return false;
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00004460 File Offset: 0x00002660
		public sealed override bool CanDropOnTarget(RdcTreeNode targetNode)
		{
			return false;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00004460 File Offset: 0x00002660
		public override bool CanDropServers()
		{
			return false;
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00004460 File Offset: 0x00002660
		public sealed override bool CanRemove(bool popUI)
		{
			return false;
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x00004460 File Offset: 0x00002660
		public override bool HasProperties
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0000358A File Offset: 0x0000178A
		public override void DoPropertiesDialog(Form parentForm, string activeTabName)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x0000358A File Offset: 0x0000178A
		internal override void ReadXml(XmlNode xmlNode, ICollection<string> errors)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0000358A File Offset: 0x0000178A
		internal override void WriteXml(XmlTextWriter tw)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00004463 File Offset: 0x00002663
		protected virtual void ReadXml(XmlNode xmlNode, FileGroup fileGroup, ICollection<string> errors)
		{
			if (string.IsNullOrEmpty(this.XmlNodeName))
			{
				return;
			}
			base.ReadXml(BuiltInVirtualGroup<TServerRef>.NodeActions, xmlNode, errors);
			if (base.Properties.Expanded.Value)
			{
				base.Expand();
			}
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00016B90 File Offset: 0x00014D90
		protected virtual void WriteXml(XmlTextWriter tw, FileGroup file)
		{
			if (string.IsNullOrEmpty(this.XmlNodeName))
			{
				return;
			}
			tw.WriteStartElement(this.XmlNodeName);
			if (file == null)
			{
				base.WriteXmlSettingsGroups(tw);
			}
			foreach (object obj in base.Nodes)
			{
				TreeNode treeNode = (TreeNode)obj;
				TServerRef tserverRef = treeNode as TServerRef;
				if (this.ShouldWriteNode(tserverRef, file))
				{
					tw.WriteElementString("server", tserverRef.ServerNode.FullPath);
				}
			}
			tw.WriteEndElement();
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00004498 File Offset: 0x00002698
		protected virtual bool ShouldWriteNode(RdcTreeNode node, FileGroup file)
		{
			return node.FileGroup == file;
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00016C44 File Offset: 0x00014E44
		public virtual TServerRef AddReference(ServerBase serverBase)
		{
			if (serverBase == null)
			{
				return default(TServerRef);
			}
			Server serverNode = serverBase.ServerNode;
			TServerRef tserverRef = serverNode.FindServerRef<TServerRef>();
			if (tserverRef == null)
			{
				tserverRef = (base.ServerRefFactory.Create(serverNode) as TServerRef);
				ServerTree.Instance.AddNode(tserverRef, this);
			}
			return tserverRef;
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x0000241A File Offset: 0x0000061A
		protected virtual string XmlNodeName
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x000044A3 File Offset: 0x000026A3
		protected virtual bool IsVisibilityConfigurable
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00016CA0 File Offset: 0x00014EA0
		protected void UpdateVisibleInTree(bool isVisible)
		{
			if (isVisible)
			{
				if (base.TreeView == null)
				{
					ServerTree.Instance.AddNode(this, ServerTree.Instance.RootNode);
					base.Expand();
					ServerTree.Instance.Operation(OperationBehavior.RestoreSelected, delegate
					{
						ServerTree.Instance.SortBuiltinGroups();
					});
				}
			}
			else if (base.TreeView != null)
			{
				ServerTree.Instance.RemoveNode(this);
			}
			if (this.IsVisibilityConfigurable)
			{
				Program.Preferences.SetBuiltInGroupVisibility(this, isVisible);
			}
		}

		// Token: 0x04000405 RID: 1029
		protected new static Dictionary<string, Helpers.ReadXmlDelegate> NodeActions = new Dictionary<string, Helpers.ReadXmlDelegate>(GroupBase.NodeActions);
	}
}
