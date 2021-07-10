using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	// Token: 0x0200011A RID: 282
	public abstract class RdcTreeNode : TreeNode, ILogonCredentials
	{
		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x0000687B File Offset: 0x00004A7B
		public string ProfileName
		{
			get
			{
				return this.LogonCredentials.ProfileName.Value;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000715 RID: 1813 RVA: 0x0000688D File Offset: 0x00004A8D
		public ProfileScope ProfileScope
		{
			get
			{
				return this.LogonCredentials.ProfileName.Scope;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x0000689F File Offset: 0x00004A9F
		public string UserName
		{
			get
			{
				return this.LogonCredentials.UserName.Value;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000717 RID: 1815 RVA: 0x000068B1 File Offset: 0x00004AB1
		public PasswordSetting Password
		{
			get
			{
				return this.LogonCredentials.Password;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x000068BE File Offset: 0x00004ABE
		public string Domain
		{
			get
			{
				return this.LogonCredentials.Domain.Value;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000719 RID: 1817 RVA: 0x00005A27 File Offset: 0x00003C27
		public virtual RdcBaseForm ParentForm
		{
			get
			{
				return Program.TheForm;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x000068D0 File Offset: 0x00004AD0
		// (set) Token: 0x0600071B RID: 1819 RVA: 0x000068D8 File Offset: 0x00004AD8
		public CommonNodeSettings Properties { get; set; }

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x000068E1 File Offset: 0x00004AE1
		// (set) Token: 0x0600071D RID: 1821 RVA: 0x000068E9 File Offset: 0x00004AE9
		public LogonCredentials LogonCredentials { get; private set; }

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x000068F2 File Offset: 0x00004AF2
		// (set) Token: 0x0600071F RID: 1823 RVA: 0x000068FA File Offset: 0x00004AFA
		public ConnectionSettings ConnectionSettings { get; private set; }

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x00006903 File Offset: 0x00004B03
		// (set) Token: 0x06000721 RID: 1825 RVA: 0x0000690B File Offset: 0x00004B0B
		public GatewaySettings GatewaySettings { get; private set; }

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x00006914 File Offset: 0x00004B14
		// (set) Token: 0x06000723 RID: 1827 RVA: 0x0000691C File Offset: 0x00004B1C
		public RemoteDesktopSettings RemoteDesktopSettings { get; private set; }

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x00006925 File Offset: 0x00004B25
		// (set) Token: 0x06000725 RID: 1829 RVA: 0x0000692D File Offset: 0x00004B2D
		public LocalResourcesSettings LocalResourceSettings { get; private set; }

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x00006936 File Offset: 0x00004B36
		// (set) Token: 0x06000727 RID: 1831 RVA: 0x0000693E File Offset: 0x00004B3E
		public CommonDisplaySettings DisplaySettings { get; set; }

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000728 RID: 1832 RVA: 0x00006947 File Offset: 0x00004B47
		// (set) Token: 0x06000729 RID: 1833 RVA: 0x0000694F File Offset: 0x00004B4F
		public SecuritySettings SecuritySettings { get; private set; }

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600072A RID: 1834 RVA: 0x00006958 File Offset: 0x00004B58
		// (set) Token: 0x0600072B RID: 1835 RVA: 0x0000358A File Offset: 0x0000178A
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

		// Token: 0x0600072C RID: 1836 RVA: 0x0001CA00 File Offset: 0x0001AC00
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

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600072D RID: 1837 RVA: 0x00006965 File Offset: 0x00004B65
		// (set) Token: 0x0600072E RID: 1838 RVA: 0x0000696D File Offset: 0x00004B6D
		protected List<SettingsGroup> AllSettingsGroups { protected get; private set; }

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600072F RID: 1839 RVA: 0x0001CA30 File Offset: 0x0001AC30
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

		// Token: 0x06000730 RID: 1840 RVA: 0x0001CA58 File Offset: 0x0001AC58
		public List<TreeNode> GetPath()
		{
			List<TreeNode> list = new List<TreeNode>();
			this.VisitNodeAndParents(delegate(RdcTreeNode node)
			{
				list.Insert(0, node);
			});
			return list;
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x0001CA90 File Offset: 0x0001AC90
		public int GetPathLength()
		{
			int len = 0;
			this.VisitNodeAndParents(delegate(RdcTreeNode n)
			{
				int len2 = len;
				len2++;
			});
			return len;
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x00006976 File Offset: 0x00004B76
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

		// Token: 0x06000733 RID: 1843 RVA: 0x0000699B File Offset: 0x00004B9B
		protected RdcTreeNode()
		{
			this.AllSettingsGroups = new List<SettingsGroup>();
			this.InitSettings();
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x0001CAC4 File Offset: 0x0001ACC4
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

		// Token: 0x06000735 RID: 1845 RVA: 0x0001CB7C File Offset: 0x0001AD7C
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

		// Token: 0x06000736 RID: 1846 RVA: 0x0001CC04 File Offset: 0x0001AE04
		internal SettingsGroup GetSettingsGroupByName(string name)
		{
			return (from sg in this.AllSettingsGroups
			where sg.Name.Equals(name)
			select sg).FirstOrDefault<SettingsGroup>();
		}

		// Token: 0x06000737 RID: 1847
		internal abstract void WriteXml(XmlTextWriter tw);

		// Token: 0x06000738 RID: 1848 RVA: 0x0001CC3C File Offset: 0x0001AE3C
		protected void WriteXmlSettingsGroups(XmlTextWriter tw)
		{
			foreach (SettingsGroup settingsGroup in this.AllSettingsGroups)
			{
				settingsGroup.WriteXml(tw, this);
			}
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x0001CC90 File Offset: 0x0001AE90
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

		// Token: 0x0600073A RID: 1850 RVA: 0x0001CD4C File Offset: 0x0001AF4C
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

		// Token: 0x0600073B RID: 1851 RVA: 0x0001CDC4 File Offset: 0x0001AFC4
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

		// Token: 0x0600073C RID: 1852
		internal abstract void Show();

		// Token: 0x0600073D RID: 1853
		internal abstract void Hide();

		// Token: 0x0600073E RID: 1854
		public abstract void Connect();

		// Token: 0x0600073F RID: 1855
		public abstract void ConnectAs(LogonCredentials logonSettings, ConnectionSettings connectionSettings);

		// Token: 0x06000740 RID: 1856
		public abstract void Reconnect();

		// Token: 0x06000741 RID: 1857
		public abstract void Disconnect();

		// Token: 0x06000742 RID: 1858
		public abstract void LogOff();

		// Token: 0x06000743 RID: 1859
		public abstract void OnRemoving();

		// Token: 0x06000744 RID: 1860 RVA: 0x000069BB File Offset: 0x00004BBB
		public void DoPropertiesDialog()
		{
			this.DoPropertiesDialog(null, null);
		}

		// Token: 0x06000745 RID: 1861
		public abstract void DoPropertiesDialog(Form parentForm, string activeTabName);

		// Token: 0x06000746 RID: 1862 RVA: 0x000045F2 File Offset: 0x000027F2
		public virtual bool CanRemove(bool popUI)
		{
			return this.AllowEdit(popUI);
		}

		// Token: 0x06000747 RID: 1863
		public abstract bool ConfirmRemove(bool askUser);

		// Token: 0x06000748 RID: 1864
		public abstract bool CanDropOnTarget(RdcTreeNode targetNode);

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000749 RID: 1865 RVA: 0x000044A3 File Offset: 0x000026A3
		public virtual bool HasProperties
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00004460 File Offset: 0x00002660
		public virtual bool HandleMove(RdcTreeNode childNode)
		{
			return false;
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x000069C5 File Offset: 0x00004BC5
		public virtual void ChangeImageIndex(ImageConstants index)
		{
			base.ImageIndex = (int)index;
			base.SelectedImageIndex = (int)ServerTree.TranslateImage(index, true);
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x0001CE1C File Offset: 0x0001B01C
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

		// Token: 0x0600074D RID: 1869 RVA: 0x000069DB File Offset: 0x00004BDB
		public void ResetInheritance()
		{
			this._needToUpdateInheritedSettings = true;
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x000069DB File Offset: 0x00004BDB
		public virtual void InvalidateNode()
		{
			this._needToUpdateInheritedSettings = true;
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x0001CE84 File Offset: 0x0001B084
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

		// Token: 0x06000750 RID: 1872 RVA: 0x0001CEF0 File Offset: 0x0001B0F0
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

		// Token: 0x06000751 RID: 1873 RVA: 0x0001CF5C File Offset: 0x0001B15C
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

		// Token: 0x06000752 RID: 1874 RVA: 0x0001CFAC File Offset: 0x0001B1AC
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

		// Token: 0x06000753 RID: 1875 RVA: 0x000069E4 File Offset: 0x00004BE4
		internal void ResolveCredentials()
		{
			this.ResolveAndFixCredentials(this.LogonCredentials);
			this.ResolveAndFixCredentials(this.GatewaySettings);
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x0001CFE4 File Offset: 0x0001B1E4
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

		// Token: 0x06000755 RID: 1877 RVA: 0x000069FE File Offset: 0x00004BFE
		private void ResolveAndFixCredentials(LogonCredentials logonCredentials)
		{
			if (logonCredentials != null && !this.ResolveCredentials(logonCredentials))
			{
				logonCredentials.ProfileName.Reset();
			}
		}

		// Token: 0x040004D8 RID: 1240
		public const string PropertiesXmlNodeName = "properties";

		// Token: 0x040004E2 RID: 1250
		private bool _needToUpdateInheritedSettings = true;
	}
}
