using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	// Token: 0x020000A7 RID: 167
	public abstract class RdcTreeNode : TreeNode, ILogonCredentials
	{
		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x0001AF0C File Offset: 0x0001910C
		public string ProfileName
		{
			get
			{
				return this.LogonCredentials.ProfileName.Value;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060005B8 RID: 1464 RVA: 0x0001AF20 File Offset: 0x00019120
		public ProfileScope ProfileScope
		{
			get
			{
				return this.LogonCredentials.ProfileName.Scope;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x0001AF34 File Offset: 0x00019134
		public string UserName
		{
			get
			{
				return this.LogonCredentials.UserName.Value;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060005BA RID: 1466 RVA: 0x0001AF48 File Offset: 0x00019148
		public PasswordSetting Password
		{
			get
			{
				return this.LogonCredentials.Password;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x0001AF58 File Offset: 0x00019158
		public string Domain
		{
			get
			{
				return this.LogonCredentials.Domain.Value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060005BC RID: 1468 RVA: 0x0001AF6C File Offset: 0x0001916C
		public virtual RdcBaseForm ParentForm
		{
			get
			{
				return Program.TheForm;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060005BD RID: 1469 RVA: 0x0001AF74 File Offset: 0x00019174
		// (set) Token: 0x060005BE RID: 1470 RVA: 0x0001AF7C File Offset: 0x0001917C
		public CommonNodeSettings Properties { get; set; }

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060005BF RID: 1471 RVA: 0x0001AF88 File Offset: 0x00019188
		// (set) Token: 0x060005C0 RID: 1472 RVA: 0x0001AF90 File Offset: 0x00019190
		public LogonCredentials LogonCredentials { get; private set; }

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x0001AF9C File Offset: 0x0001919C
		// (set) Token: 0x060005C2 RID: 1474 RVA: 0x0001AFA4 File Offset: 0x000191A4
		public ConnectionSettings ConnectionSettings { get; private set; }

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x0001AFB0 File Offset: 0x000191B0
		// (set) Token: 0x060005C4 RID: 1476 RVA: 0x0001AFB8 File Offset: 0x000191B8
		public GatewaySettings GatewaySettings { get; private set; }

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060005C5 RID: 1477 RVA: 0x0001AFC4 File Offset: 0x000191C4
		// (set) Token: 0x060005C6 RID: 1478 RVA: 0x0001AFCC File Offset: 0x000191CC
		public RemoteDesktopSettings RemoteDesktopSettings { get; private set; }

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x0001AFD8 File Offset: 0x000191D8
		// (set) Token: 0x060005C8 RID: 1480 RVA: 0x0001AFE0 File Offset: 0x000191E0
		public LocalResourcesSettings LocalResourceSettings { get; private set; }

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x0001AFEC File Offset: 0x000191EC
		// (set) Token: 0x060005CA RID: 1482 RVA: 0x0001AFF4 File Offset: 0x000191F4
		public CommonDisplaySettings DisplaySettings { get; set; }

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x0001B000 File Offset: 0x00019200
		// (set) Token: 0x060005CC RID: 1484 RVA: 0x0001B008 File Offset: 0x00019208
		public SecuritySettings SecuritySettings { get; private set; }

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x0001B014 File Offset: 0x00019214
		// (set) Token: 0x060005CE RID: 1486 RVA: 0x0001B024 File Offset: 0x00019224
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

		// Token: 0x060005CF RID: 1487 RVA: 0x0001B02C File Offset: 0x0001922C
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

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x0001B064 File Offset: 0x00019264
		// (set) Token: 0x060005D1 RID: 1489 RVA: 0x0001B06C File Offset: 0x0001926C
		private protected List<SettingsGroup> AllSettingsGroups { protected get; private set; }

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060005D2 RID: 1490 RVA: 0x0001B078 File Offset: 0x00019278
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

		// Token: 0x060005D3 RID: 1491 RVA: 0x0001B0A8 File Offset: 0x000192A8
		public List<TreeNode> GetPath()
		{
			List<TreeNode> list = new List<TreeNode>();
			this.VisitNodeAndParents(delegate(RdcTreeNode node)
			{
				list.Insert(0, node);
			});
			return list;
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x0001B0E4 File Offset: 0x000192E4
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

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060005D5 RID: 1493 RVA: 0x0001B11C File Offset: 0x0001931C
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

		// Token: 0x060005D6 RID: 1494 RVA: 0x0001B144 File Offset: 0x00019344
		protected RdcTreeNode()
		{
			this.AllSettingsGroups = new List<SettingsGroup>();
			this.InitSettings();
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x0001B164 File Offset: 0x00019364
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

		// Token: 0x060005D8 RID: 1496 RVA: 0x0001B224 File Offset: 0x00019424
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

		// Token: 0x060005D9 RID: 1497 RVA: 0x0001B2B8 File Offset: 0x000194B8
		internal SettingsGroup GetSettingsGroupByName(string name)
		{
			return (from sg in this.AllSettingsGroups
			where sg.Name.Equals(name)
			select sg).FirstOrDefault<SettingsGroup>();
		}

		// Token: 0x060005DA RID: 1498
		internal abstract void WriteXml(XmlTextWriter tw);

		// Token: 0x060005DB RID: 1499 RVA: 0x0001B2F4 File Offset: 0x000194F4
		protected void WriteXmlSettingsGroups(XmlTextWriter tw)
		{
			foreach (SettingsGroup settingsGroup in this.AllSettingsGroups)
			{
				settingsGroup.WriteXml(tw, this);
			}
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x0001B350 File Offset: 0x00019550
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

		// Token: 0x060005DD RID: 1501 RVA: 0x0001B424 File Offset: 0x00019624
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

		// Token: 0x060005DE RID: 1502 RVA: 0x0001B4A4 File Offset: 0x000196A4
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

		// Token: 0x060005DF RID: 1503
		internal abstract void Show();

		// Token: 0x060005E0 RID: 1504
		internal abstract void Hide();

		// Token: 0x060005E1 RID: 1505
		public abstract void Connect();

		// Token: 0x060005E2 RID: 1506
		public abstract void ConnectAs(LogonCredentials logonSettings, ConnectionSettings connectionSettings);

		// Token: 0x060005E3 RID: 1507
		public abstract void Reconnect();

		// Token: 0x060005E4 RID: 1508
		public abstract void Disconnect();

		// Token: 0x060005E5 RID: 1509
		public abstract void LogOff();

		// Token: 0x060005E6 RID: 1510
		public abstract void OnRemoving();

		// Token: 0x060005E7 RID: 1511 RVA: 0x0001B50C File Offset: 0x0001970C
		public void DoPropertiesDialog()
		{
			this.DoPropertiesDialog(null, null);
		}

		// Token: 0x060005E8 RID: 1512
		public abstract void DoPropertiesDialog(Form parentForm, string activeTabName);

		// Token: 0x060005E9 RID: 1513 RVA: 0x0001B518 File Offset: 0x00019718
		public virtual bool CanRemove(bool popUI)
		{
			return this.AllowEdit(popUI);
		}

		// Token: 0x060005EA RID: 1514
		public abstract bool ConfirmRemove(bool askUser);

		// Token: 0x060005EB RID: 1515
		public abstract bool CanDropOnTarget(RdcTreeNode targetNode);

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x0001B524 File Offset: 0x00019724
		public virtual bool HasProperties
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x0001B528 File Offset: 0x00019728
		public virtual bool HandleMove(RdcTreeNode childNode)
		{
			return false;
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x0001B52C File Offset: 0x0001972C
		public virtual void ChangeImageIndex(ImageConstants index)
		{
			base.ImageIndex = (int)index;
			base.SelectedImageIndex = (int)ServerTree.TranslateImage(index, true);
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x0001B544 File Offset: 0x00019744
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

		// Token: 0x060005F0 RID: 1520 RVA: 0x0001B5B8 File Offset: 0x000197B8
		public void ResetInheritance()
		{
			this._needToUpdateInheritedSettings = true;
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x0001B5C4 File Offset: 0x000197C4
		public virtual void InvalidateNode()
		{
			this._needToUpdateInheritedSettings = true;
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x0001B5D0 File Offset: 0x000197D0
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

		// Token: 0x060005F3 RID: 1523 RVA: 0x0001B644 File Offset: 0x00019844
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

		// Token: 0x060005F4 RID: 1524 RVA: 0x0001B6BC File Offset: 0x000198BC
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

		// Token: 0x060005F5 RID: 1525 RVA: 0x0001B71C File Offset: 0x0001991C
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

		// Token: 0x060005F6 RID: 1526 RVA: 0x0001B75C File Offset: 0x0001995C
		internal void ResolveCredentials()
		{
			this.ResolveAndFixCredentials(this.LogonCredentials);
			this.ResolveAndFixCredentials(this.GatewaySettings);
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x0001B788 File Offset: 0x00019988
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

		// Token: 0x060005F8 RID: 1528 RVA: 0x0001B828 File Offset: 0x00019A28
		private void ResolveAndFixCredentials(LogonCredentials logonCredentials)
		{
			if (logonCredentials != null && !this.ResolveCredentials(logonCredentials))
			{
				logonCredentials.ProfileName.Reset();
			}
		}

		// Token: 0x04000211 RID: 529
		public const string PropertiesXmlNodeName = "properties";

		// Token: 0x0400021B RID: 539
		private bool _needToUpdateInheritedSettings = true;
	}
}
