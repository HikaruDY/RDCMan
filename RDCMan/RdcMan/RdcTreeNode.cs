using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	public abstract class RdcTreeNode : TreeNode, ILogonCredentials
	{
		public string ProfileName
		{
			get
			{
				return this.LogonCredentials.ProfileName.Value;
			}
		}

		public ProfileScope ProfileScope
		{
			get
			{
				return this.LogonCredentials.ProfileName.Scope;
			}
		}

		public string UserName
		{
			get
			{
				return this.LogonCredentials.UserName.Value;
			}
		}

		public PasswordSetting Password
		{
			get
			{
				return this.LogonCredentials.Password;
			}
		}

		public string Domain
		{
			get
			{
				return this.LogonCredentials.Domain.Value;
			}
		}

		public virtual RdcBaseForm ParentForm
		{
			get
			{
				return Program.TheForm;
			}
		}

		public CommonNodeSettings Properties { get; set; }

		public LogonCredentials LogonCredentials { get; private set; }

		public ConnectionSettings ConnectionSettings { get; private set; }

		public GatewaySettings GatewaySettings { get; private set; }

		public RemoteDesktopSettings RemoteDesktopSettings { get; private set; }

		public LocalResourcesSettings LocalResourceSettings { get; private set; }

		public CommonDisplaySettings DisplaySettings { get; set; }

		public SecuritySettings SecuritySettings { get; private set; }

		public virtual EncryptionSettings EncryptionSettings
		{
			get
			{
				return this.FileGroup.EncryptionSettings;
			}
			protected set
			{
				throw new NotImplementedException();
			}
		}

		internal GroupBase GetReadOnlyParent()
		{
			TreeNode treeNode = this;
			GroupBase groupBase;
			for (;;)
			{
				groupBase = (treeNode as GroupBase);
				if (groupBase != null && groupBase.IsReadOnly)
				{
					break;
				}
				treeNode = treeNode.Parent;
				if (treeNode == null)
				{
					goto Block_3;
				}
			}
			return groupBase;
			Block_3:
			return null;
		}

		private protected List<SettingsGroup> AllSettingsGroups { protected get; private set; }

		public virtual FileGroup FileGroup
		{
			get
			{
				TreeNode treeNode = this;
				while (treeNode.Parent != null)
				{
					treeNode = treeNode.Parent;
				}
				return treeNode as FileGroup;
			}
		}

		public List<TreeNode> GetPath()
		{
			List<TreeNode> list = new List<TreeNode>();
			this.VisitNodeAndParents(delegate(RdcTreeNode node)
			{
				list.Insert(0, node);
			});
			return list;
		}

		public int GetPathLength()
		{
			int len = 0;
			this.VisitNodeAndParents(delegate(RdcTreeNode n)
			{
				int len = len;
				len++;
			});
			return len;
		}

		public string ParentPath
		{
			get
			{
				if (base.Parent == null)
				{
					return ServerTree.Instance.RootNode.Text;
				}
				return base.Parent.FullPath;
			}
		}

		protected RdcTreeNode()
		{
			this.AllSettingsGroups = new List<SettingsGroup>();
			this.InitSettings();
		}

		protected virtual void InitSettings()
		{
			this.LogonCredentials = new LogonCredentials();
			this.ConnectionSettings = new ConnectionSettings();
			this.GatewaySettings = new GatewaySettings();
			this.RemoteDesktopSettings = new RemoteDesktopSettings();
			this.LocalResourceSettings = new LocalResourcesSettings();
			this.SecuritySettings = new SecuritySettings();
			if (this.Properties != null)
			{
				this.AllSettingsGroups.Add(this.Properties);
			}
			this.AllSettingsGroups.AddRange(new SettingsGroup[]
			{
				this.LogonCredentials,
				this.ConnectionSettings,
				this.GatewaySettings,
				this.RemoteDesktopSettings,
				this.LocalResourceSettings,
				this.DisplaySettings,
				this.SecuritySettings
			});
		}

		internal void CopySettings(RdcTreeNode node, Type excludeType)
		{
			for (int i = 0; i < this.AllSettingsGroups.Count; i++)
			{
				SettingsGroup settingsGroup = this.AllSettingsGroups[i];
				if (!(settingsGroup.GetType() == excludeType))
				{
					this.AllSettingsGroups[i].InheritSettingsType.Mode = node.AllSettingsGroups[i].InheritSettingsType.Mode;
					this.AllSettingsGroups[i].Copy(node.AllSettingsGroups[i]);
				}
			}
		}

		internal SettingsGroup GetSettingsGroupByName(string name)
		{
			return (from sg in this.AllSettingsGroups
			where sg.Name.Equals(name)
			select sg).FirstOrDefault<SettingsGroup>();
		}

		internal abstract void WriteXml(XmlTextWriter tw);

		protected void WriteXmlSettingsGroups(XmlTextWriter tw)
		{
			foreach (SettingsGroup settingsGroup in this.AllSettingsGroups)
			{
				settingsGroup.WriteXml(tw, this);
			}
		}

		protected void ReadXml(Dictionary<string, Helpers.ReadXmlDelegate> nodeActions, XmlNode xmlNode, ICollection<string> errors)
		{
			foreach (object obj in xmlNode.ChildNodes)
			{
				XmlNode xmlNode2 = (XmlNode)obj;
				Helpers.ReadXmlDelegate readXmlDelegate;
				nodeActions.TryGetValue(xmlNode2.Name, out readXmlDelegate);
				try
				{
					if (readXmlDelegate != null)
					{
						readXmlDelegate(xmlNode2, this, errors);
					}
					else
					{
						this.ReadXmlSettingsGroup(xmlNode2, errors);
					}
				}
				catch (Exception ex)
				{
					errors.Add("Exception reading Xml node {0} in '{1}': {2}".InvariantFormat(new object[]
					{
						xmlNode2.GetFullPath(),
						base.Text,
						ex.Message
					}));
				}
			}
		}

		protected void ReadXmlSettingsGroup(XmlNode xmlNode, ICollection<string> errors)
		{
			SettingsGroup settingsGroup = (from i in this.AllSettingsGroups
			where xmlNode.Name == i.XmlNodeName
			select i).FirstOrDefault<SettingsGroup>();
			if (settingsGroup != null)
			{
				settingsGroup.ReadXml(xmlNode, this, errors);
				return;
			}
			errors.Add("Unexpected Xml node {0} in '{1}'".InvariantFormat(new object[]
			{
				xmlNode.GetFullPath(),
				base.Text
			}));
		}

		internal virtual void UpdateSettings(NodePropertiesDialog dlg)
		{
			if (dlg == null)
			{
				return;
			}
			dlg.UpdateSettings();
			if (base.TreeView != null && dlg.PropertiesPage.ParentGroup != null && base.Parent != dlg.PropertiesPage.ParentGroup)
			{
				ServerTree.Instance.MoveNode(this, dlg.PropertiesPage.ParentGroup);
			}
		}

		internal abstract void Show();

		internal abstract void Hide();

		public abstract void Connect();

		public abstract void ConnectAs(LogonCredentials logonSettings, ConnectionSettings connectionSettings);

		public abstract void Reconnect();

		public abstract void Disconnect();

		public abstract void LogOff();

		public abstract void OnRemoving();

		public void DoPropertiesDialog()
		{
			this.DoPropertiesDialog(null, null);
		}

		public abstract void DoPropertiesDialog(Form parentForm, string activeTabName);

		public virtual bool CanRemove(bool popUI)
		{
			return this.AllowEdit(popUI);
		}

		public abstract bool ConfirmRemove(bool askUser);

		public abstract bool CanDropOnTarget(RdcTreeNode targetNode);

		public virtual bool HasProperties
		{
			get
			{
				return true;
			}
		}

		public virtual bool HandleMove(RdcTreeNode childNode)
		{
			return false;
		}

		public virtual void ChangeImageIndex(ImageConstants index)
		{
			base.ImageIndex = (int)index;
			base.SelectedImageIndex = (int)ServerTree.TranslateImage(index, true);
		}

		public virtual void CollectNodesToInvalidate(bool recurseChildren, HashSet<RdcTreeNode> set)
		{
			if (recurseChildren)
			{
				foreach (object obj in base.Nodes)
				{
					RdcTreeNode rdcTreeNode = (RdcTreeNode)obj;
					rdcTreeNode.CollectNodesToInvalidate(recurseChildren, set);
				}
			}
			set.Add(this);
		}

		public void ResetInheritance()
		{
			this._needToUpdateInheritedSettings = true;
		}

		public virtual void InvalidateNode()
		{
			this._needToUpdateInheritedSettings = true;
		}

		public bool InheritSettings()
		{
			bool result = false;
			if (!this._needToUpdateInheritedSettings)
			{
				return result;
			}
			foreach (SettingsGroup settingsGroup in this.AllSettingsGroups)
			{
				settingsGroup.InheritSettings(this, ref result);
			}
			this._needToUpdateInheritedSettings = false;
			return result;
		}

		public void DoConnectAs()
		{
			RdcTreeNode rdcTreeNode = this;
			ServerRef serverRef = rdcTreeNode as ServerRef;
			if (serverRef != null)
			{
				rdcTreeNode = serverRef.ServerNode;
			}
			using (ConnectAsDialog connectAsDialog = ConnectAsDialog.NewConnectAsDialog(rdcTreeNode, Program.TheForm))
			{
				if (connectAsDialog.ShowDialog() == DialogResult.OK)
				{
					connectAsDialog.UpdateSettings();
					this.ConnectAs(connectAsDialog.LogonCredentials, connectAsDialog.ConnectionSettings);
				}
			}
		}

		public virtual bool AllowEdit(bool popUI)
		{
			GroupBase readOnlyParent = this.GetReadOnlyParent();
			if (readOnlyParent != null)
			{
				if (popUI)
				{
					FormTools.InformationDialog("{0} '{1}' is read-only and cannot be edited".CultureFormat(new object[]
					{
						(readOnlyParent == this) ? "Group" : "Parent group",
						readOnlyParent.Text
					}));
				}
				return false;
			}
			return true;
		}

		public CredentialsProfile LookupCredentialsProfile(ILogonCredentials logonCredentials)
		{
			CredentialsStore credentialsProfiles = Program.CredentialsProfiles;
			if (logonCredentials.ProfileScope == ProfileScope.File)
			{
				credentialsProfiles = this.FileGroup.CredentialsProfiles;
			}
			CredentialsProfile result;
			credentialsProfiles.TryGetValue(logonCredentials.ProfileName, out result);
			return result;
		}

		internal void ResolveCredentials()
		{
			this.ResolveAndFixCredentials(this.LogonCredentials);
			this.ResolveAndFixCredentials(this.GatewaySettings);
		}

		internal bool ResolveCredentials(LogonCredentials logonCredentials)
		{
			if (logonCredentials.ProfileName.Scope == ProfileScope.Local)
			{
				if (!LogonCredentials.IsCustomProfile(logonCredentials.ProfileName.Value))
				{
					logonCredentials.ProfileName.Value = "Custom";
				}
				return true;
			}
			CredentialsProfile credentialsProfile = this.LookupCredentialsProfile(logonCredentials);
			if (credentialsProfile != null)
			{
				logonCredentials.UserName.Value = credentialsProfile.UserName;
				logonCredentials.Domain.Value = credentialsProfile.Domain;
				if (credentialsProfile.IsDecrypted)
				{
					logonCredentials.Password.SetPlainText(credentialsProfile.Password.Value);
				}
				return true;
			}
			return false;
		}

		private void ResolveAndFixCredentials(LogonCredentials logonCredentials)
		{
			if (logonCredentials != null && !this.ResolveCredentials(logonCredentials))
			{
				logonCredentials.ProfileName.Reset();
			}
		}

		public const string PropertiesXmlNodeName = "properties";

		private bool _needToUpdateInheritedSettings = true;
	}
}
