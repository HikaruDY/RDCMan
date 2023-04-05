using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	// Token: 0x0200006E RID: 110
	internal abstract class BuiltInVirtualGroup<TServerRef> : VirtualGroup, IBuiltInVirtualGroup where TServerRef : ServerRef
	{
		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000320 RID: 800 RVA: 0x00012864 File Offset: 0x00010A64
		string IBuiltInVirtualGroup.Text
		{
			get
			{
				return base.Text;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000321 RID: 801 RVA: 0x0001286C File Offset: 0x00010A6C
		string IBuiltInVirtualGroup.ConfigPropertyName
		{
			get
			{
				return this.ConfigName;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000322 RID: 802 RVA: 0x00012874 File Offset: 0x00010A74
		string IBuiltInVirtualGroup.XmlNodeName
		{
			get
			{
				return this.XmlNodeName;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000323 RID: 803 RVA: 0x0001287C File Offset: 0x00010A7C
		// (set) Token: 0x06000324 RID: 804 RVA: 0x00012888 File Offset: 0x00010A88
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

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000325 RID: 805 RVA: 0x00012894 File Offset: 0x00010A94
		bool IBuiltInVirtualGroup.IsVisibilityConfigurable
		{
			get
			{
				return this.IsVisibilityConfigurable;
			}
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0001289C File Offset: 0x00010A9C
		void IBuiltInVirtualGroup.ReadXml(XmlNode xmlNode, FileGroup fileGroup, ICollection<string> errors)
		{
			this.ReadXml(xmlNode, fileGroup, errors);
		}

		// Token: 0x06000327 RID: 807 RVA: 0x000128A8 File Offset: 0x00010AA8
		void IBuiltInVirtualGroup.WriteXml(XmlTextWriter tw, FileGroup fileGroup)
		{
			this.WriteXml(tw, fileGroup);
		}

		// Token: 0x06000328 RID: 808 RVA: 0x000128B4 File Offset: 0x00010AB4
		bool IBuiltInVirtualGroup.ShouldWriteNode(ServerRef serverRef, FileGroup file)
		{
			return this.ShouldWriteNode(serverRef, file);
		}

		// Token: 0x06000329 RID: 809 RVA: 0x000128C0 File Offset: 0x00010AC0
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

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600032A RID: 810 RVA: 0x000128F0 File Offset: 0x00010AF0
		public virtual string ConfigName
		{
			get
			{
				return base.Text;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600032B RID: 811 RVA: 0x000128F8 File Offset: 0x00010AF8
		// (set) Token: 0x0600032C RID: 812 RVA: 0x00012904 File Offset: 0x00010B04
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

		// Token: 0x0600032D RID: 813 RVA: 0x00012910 File Offset: 0x00010B10
		public override void OnRemoving()
		{
			this.Hide();
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00012918 File Offset: 0x00010B18
		public sealed override bool ConfirmRemove(bool askUser)
		{
			FormTools.InformationDialog("Use the View menu to hide the " + base.Text + " group");
			return false;
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00012938 File Offset: 0x00010B38
		public sealed override bool CanDropOnTarget(RdcTreeNode targetNode)
		{
			return false;
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0001293C File Offset: 0x00010B3C
		public override bool CanDropServers()
		{
			return false;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00012940 File Offset: 0x00010B40
		public sealed override bool CanRemove(bool popUI)
		{
			return false;
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000332 RID: 818 RVA: 0x00012944 File Offset: 0x00010B44
		public override bool HasProperties
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00012948 File Offset: 0x00010B48
		public override void DoPropertiesDialog(Form parentForm, string activeTabName)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00012950 File Offset: 0x00010B50
		internal override void ReadXml(XmlNode xmlNode, ICollection<string> errors)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00012958 File Offset: 0x00010B58
		internal override void WriteXml(XmlTextWriter tw)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00012960 File Offset: 0x00010B60
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

		// Token: 0x06000337 RID: 823 RVA: 0x000129AC File Offset: 0x00010BAC
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

		// Token: 0x06000338 RID: 824 RVA: 0x00012A70 File Offset: 0x00010C70
		protected virtual bool ShouldWriteNode(RdcTreeNode node, FileGroup file)
		{
			return node.FileGroup == file;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00012A7C File Offset: 0x00010C7C
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

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600033A RID: 826 RVA: 0x00012AE0 File Offset: 0x00010CE0
		protected virtual string XmlNodeName
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600033B RID: 827 RVA: 0x00012AE4 File Offset: 0x00010CE4
		protected virtual bool IsVisibilityConfigurable
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00012AE8 File Offset: 0x00010CE8
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

		// Token: 0x04000191 RID: 401
		protected new static Dictionary<string, Helpers.ReadXmlDelegate> NodeActions = new Dictionary<string, Helpers.ReadXmlDelegate>(GroupBase.NodeActions);
	}
}
