using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	// Token: 0x020000E6 RID: 230
	internal class SmartGroup : VirtualGroup
	{
		// Token: 0x060005CB RID: 1483 RVA: 0x0001A588 File Offset: 0x00018788
		static SmartGroup()
		{
			SmartGroup.NodeActions["ruleGroup"] = delegate(XmlNode childNode, RdcTreeNode node, ICollection<string> errors)
			{
				(node as SmartGroup).RuleGroup = RuleGroup.Create(childNode, node, errors);
			};
			ServerTree.Instance.GroupChanged += SmartGroup.OnGroupChanged;
			ServerTree.Instance.ServerChanged += SmartGroup.OnServerChanged;
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x000058A0 File Offset: 0x00003AA0
		protected SmartGroup()
		{
			SmartGroup.AllSmartGroups.Add(this);
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x000058B3 File Offset: 0x00003AB3
		protected override void InitSettings()
		{
			base.Properties = new SmartGroupSettings();
			base.AllSettingsGroups.Add(this.Properties);
			this.RuleGroup = new RuleGroup(RuleGroupOperator.All, Enumerable.Empty<Rule>());
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x000058E2 File Offset: 0x00003AE2
		public static SmartGroup CreateForAdd()
		{
			return new SmartGroup();
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x0001A5FC File Offset: 0x000187FC
		public static SmartGroup Create(SmartGroupPropertiesDialog dlg)
		{
			SmartGroup smartGroup = dlg.AssociatedNode as SmartGroup;
			smartGroup.UpdateSettings(dlg);
			smartGroup.FinishConstruction(dlg.PropertiesPage.ParentGroup);
			smartGroup.Refresh();
			return smartGroup;
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x0001A634 File Offset: 0x00018834
		public static SmartGroup Create(XmlNode xmlNode, GroupBase parent, ICollection<string> errors)
		{
			SmartGroup smartGroup = new SmartGroup();
			smartGroup.FinishConstruction(parent);
			smartGroup.ReadXml(xmlNode, errors);
			smartGroup.Text = smartGroup.Properties.GroupName.Value;
			return smartGroup;
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060005D1 RID: 1489 RVA: 0x000058E9 File Offset: 0x00003AE9
		public new SmartGroupSettings Properties
		{
			get
			{
				return base.Properties as SmartGroupSettings;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060005D2 RID: 1490 RVA: 0x000058F6 File Offset: 0x00003AF6
		// (set) Token: 0x060005D3 RID: 1491 RVA: 0x000058FE File Offset: 0x00003AFE
		public RuleGroup RuleGroup { get; private set; }

		// Token: 0x060005D4 RID: 1492 RVA: 0x00004460 File Offset: 0x00002660
		public sealed override bool CanDropServers()
		{
			return false;
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00005907 File Offset: 0x00003B07
		public override void OnRemoving()
		{
			base.OnRemoving();
			SmartGroup.AllSmartGroups.Remove(this);
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x0001A670 File Offset: 0x00018870
		public static void OnGroupChanged(GroupChangedEventArgs e)
		{
			if (!e.ChangeType.HasFlag(ChangeType.TreeChanged) && !e.ChangeType.HasFlag(ChangeType.PropertyChanged))
			{
				return;
			}
			SmartGroup.RefreshScope(e.Group, delegate(SmartGroup group)
			{
				group.Refresh();
			});
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x0001A6D8 File Offset: 0x000188D8
		public static void OnServerChanged(ServerChangedEventArgs e)
		{
			if (!e.ChangeType.HasFlag(ChangeType.TreeChanged) && !e.ChangeType.HasFlag(ChangeType.PropertyChanged))
			{
				return;
			}
			Server server = e.Server as Server;
			if (server == null)
			{
				return;
			}
			bool dummy = false;
			SmartGroup.RefreshScope(server.Parent as GroupBase, delegate(SmartGroup group)
			{
				group.UpdateForServer(server, ref dummy);
			});
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x0001A760 File Offset: 0x00018960
		public static void RefreshAll(FileGroup fileGroup)
		{
			SmartGroup.AllSmartGroups.ForEach(delegate(SmartGroup group)
			{
				if (group.FileGroup == fileGroup)
				{
					group.Refresh();
				}
			});
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x0001A790 File Offset: 0x00018990
		private static void RefreshScope(GroupBase scope, Action<SmartGroup> process)
		{
			if (scope != null)
			{
				scope.VisitParents(delegate(RdcTreeNode parent)
				{
					foreach (SmartGroup obj in parent.Nodes.OfType<SmartGroup>())
					{
						process(obj);
					}
				});
			}
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x0001A7C0 File Offset: 0x000189C0
		public sealed override void DoPropertiesDialog(Form parentForm, string activeTabName)
		{
			using (SmartGroupPropertiesDialog smartGroupPropertiesDialog = SmartGroupPropertiesDialog.NewPropertiesDialog(this, parentForm))
			{
				smartGroupPropertiesDialog.SetActiveTab(activeTabName);
				if (smartGroupPropertiesDialog.ShowDialog() == DialogResult.OK)
				{
					this.UpdateSettings(smartGroupPropertiesDialog);
					this.Refresh();
				}
			}
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00004460 File Offset: 0x00002660
		public sealed override bool CanRemoveChildren()
		{
			return false;
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x0000591B File Offset: 0x00003B1B
		internal override void ReadXml(XmlNode xmlNode, ICollection<string> errors)
		{
			base.ReadXml(SmartGroup.NodeActions, xmlNode, errors);
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x0000592A File Offset: 0x00003B2A
		internal override void WriteXml(XmlTextWriter tw)
		{
			tw.WriteStartElement("smartGroup");
			this.Properties.Expanded.Value = base.IsExpanded;
			base.WriteXmlSettingsGroups(tw);
			this.RuleGroup.WriteXml(tw);
			tw.WriteEndElement();
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x0001A810 File Offset: 0x00018A10
		public void Refresh()
		{
			bool changed = false;
			using (Helpers.Timer("refreshing smart group {0}", new object[]
			{
				base.Text
			}))
			{
				ServerTree.Instance.Operation(OperationBehavior.SuspendSort | OperationBehavior.SuspendUpdate | OperationBehavior.SuspendGroupChanged, delegate
				{
					HashSet<SmartServerRef> set = new HashSet<SmartServerRef>();
					this.Nodes.ForEach(delegate(TreeNode s)
					{
						set.Add(s as SmartServerRef);
					});
					this.GetParentNodes().VisitNodes(delegate(RdcTreeNode node)
					{
						if (node is VirtualGroup)
						{
							return NodeVisitorResult.NoRecurse;
						}
						Server server = node as Server;
						if (server != null)
						{
							SmartServerRef item = this.UpdateForServer(server, ref changed);
							set.Remove(item);
						}
						return NodeVisitorResult.Continue;
					});
					if (set.Count > 0)
					{
						changed = true;
						set.ForEach(delegate(SmartServerRef s)
						{
							ServerTree.Instance.RemoveNode(s);
						});
					}
				});
			}
			if (changed)
			{
				ServerTree.Instance.SortGroup(this);
				ServerTree.Instance.OnGroupChanged(this, ChangeType.InvalidateUI);
			}
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x0001A8A0 File Offset: 0x00018AA0
		private SmartServerRef UpdateForServer(Server server, ref bool changed)
		{
			SmartServerRef smartServerRef = server.FindServerRef<SmartServerRef>(this);
			bool flag = this.RuleGroup != null && this.RuleGroup.Evaluate(server);
			if (smartServerRef != null != flag)
			{
				changed = true;
				if (flag)
				{
					smartServerRef = new SmartServerRef(server);
					ServerTree.Instance.AddNode(smartServerRef, this);
				}
				else
				{
					ServerTree.Instance.RemoveNode(smartServerRef);
				}
			}
			return smartServerRef;
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00005966 File Offset: 0x00003B66
		private void FinishConstruction(GroupBase parent)
		{
			ServerTree.Instance.AddNode(this, parent);
			this.ChangeImageIndex(ImageConstants.SmartGroup);
		}

		// Token: 0x04000485 RID: 1157
		internal const string XmlNodeName = "smartGroup";

		// Token: 0x04000486 RID: 1158
		private static List<SmartGroup> AllSmartGroups = new List<SmartGroup>();

		// Token: 0x04000487 RID: 1159
		protected new static Dictionary<string, Helpers.ReadXmlDelegate> NodeActions = new Dictionary<string, Helpers.ReadXmlDelegate>(GroupBase.NodeActions);
	}
}
