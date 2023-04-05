using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	internal abstract class BuiltInVirtualGroup<TServerRef> : VirtualGroup, IBuiltInVirtualGroup where TServerRef : ServerRef
	{
		string IBuiltInVirtualGroup.Text
		{
			get
			{
				return base.Text;
			}
		}

		string IBuiltInVirtualGroup.ConfigPropertyName
		{
			get
			{
				return this.ConfigName;
			}
		}

		string IBuiltInVirtualGroup.XmlNodeName
		{
			get
			{
				return this.XmlNodeName;
			}
		}

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

		bool IBuiltInVirtualGroup.IsVisibilityConfigurable
		{
			get
			{
				return this.IsVisibilityConfigurable;
			}
		}

		void IBuiltInVirtualGroup.ReadXml(XmlNode xmlNode, FileGroup fileGroup, ICollection<string> errors)
		{
			this.ReadXml(xmlNode, fileGroup, errors);
		}

		void IBuiltInVirtualGroup.WriteXml(XmlTextWriter tw, FileGroup fileGroup)
		{
			this.WriteXml(tw, fileGroup);
		}

		bool IBuiltInVirtualGroup.ShouldWriteNode(ServerRef serverRef, FileGroup file)
		{
			return this.ShouldWriteNode(serverRef, file);
		}

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

		public virtual string ConfigName
		{
			get
			{
				return base.Text;
			}
		}

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

		public override void OnRemoving()
		{
			this.Hide();
		}

		public sealed override bool ConfirmRemove(bool askUser)
		{
			FormTools.InformationDialog("Use the View menu to hide the " + base.Text + " group");
			return false;
		}

		public sealed override bool CanDropOnTarget(RdcTreeNode targetNode)
		{
			return false;
		}

		public override bool CanDropServers()
		{
			return false;
		}

		public sealed override bool CanRemove(bool popUI)
		{
			return false;
		}

		public override bool HasProperties
		{
			get
			{
				return false;
			}
		}

		public override void DoPropertiesDialog(Form parentForm, string activeTabName)
		{
			throw new NotImplementedException();
		}

		internal override void ReadXml(XmlNode xmlNode, ICollection<string> errors)
		{
			throw new NotImplementedException();
		}

		internal override void WriteXml(XmlTextWriter tw)
		{
			throw new NotImplementedException();
		}

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

		protected virtual bool ShouldWriteNode(RdcTreeNode node, FileGroup file)
		{
			return node.FileGroup == file;
		}

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

		protected virtual string XmlNodeName
		{
			get
			{
				return null;
			}
		}

		protected virtual bool IsVisibilityConfigurable
		{
			get
			{
				return true;
			}
		}

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

		protected new static Dictionary<string, Helpers.ReadXmlDelegate> NodeActions = new Dictionary<string, Helpers.ReadXmlDelegate>(GroupBase.NodeActions);
	}
}
