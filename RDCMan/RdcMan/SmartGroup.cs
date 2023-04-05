using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	// Token: 0x02000089 RID: 137
	internal class SmartGroup : VirtualGroup
	{
		// Token: 0x060004AE RID: 1198 RVA: 0x00017B90 File Offset: 0x00015D90
		static SmartGroup()
		{
			SmartGroup.NodeActions["ruleGroup"] = delegate(XmlNode childNode, RdcTreeNode node, ICollection<string> errors)
			{
				(node as SmartGroup).RuleGroup = RuleGroup.Create(childNode, node, errors);
			};
			ServerTree.Instance.GroupChanged += SmartGroup.OnGroupChanged;
			ServerTree.Instance.ServerChanged += SmartGroup.OnServerChanged;
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00017C08 File Offset: 0x00015E08
		protected SmartGroup()
		{
			SmartGroup.AllSmartGroups.Add(this);
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00017C1C File Offset: 0x00015E1C
		protected override void InitSettings()
		{
			base.Properties = new SmartGroupSettings();
			base.AllSettingsGroups.Add(this.Properties);
			this.RuleGroup = new RuleGroup(RuleGroupOperator.All, Enumerable.Empty<Rule>());
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00017C5C File Offset: 0x00015E5C
		public static SmartGroup CreateForAdd()
		{
			return new SmartGroup();
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00017C64 File Offset: 0x00015E64
		public static SmartGroup Create(SmartGroupPropertiesDialog dlg)
		{
			SmartGroup smartGroup = dlg.AssociatedNode as SmartGroup;
			smartGroup.UpdateSettings(dlg);
			smartGroup.FinishConstruction(dlg.PropertiesPage.ParentGroup);
			smartGroup.Refresh();
			return smartGroup;
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00017CA0 File Offset: 0x00015EA0
		public static SmartGroup Create(XmlNode xmlNode, GroupBase parent, ICollection<string> errors)
		{
			SmartGroup smartGroup = new SmartGroup();
			smartGroup.FinishConstruction(parent);
			smartGroup.ReadXml(xmlNode, errors);
			smartGroup.Text = smartGroup.Properties.GroupName.Value;
			return smartGroup;
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x00017CE0 File Offset: 0x00015EE0
		public new SmartGroupSettings Properties
		{
			get
			{
				return base.Properties as SmartGroupSettings;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x00017CF0 File Offset: 0x00015EF0
		// (set) Token: 0x060004B6 RID: 1206 RVA: 0x00017CF8 File Offset: 0x00015EF8
		public RuleGroup RuleGroup { get; private set; }

		// Token: 0x060004B7 RID: 1207 RVA: 0x00017D04 File Offset: 0x00015F04
		public sealed override bool CanDropServers()
		{
			return false;
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00017D08 File Offset: 0x00015F08
		public override void OnRemoving()
		{
			base.OnRemoving();
			SmartGroup.AllSmartGroups.Remove(this);
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00017D1C File Offset: 0x00015F1C
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

		// Token: 0x060004BA RID: 1210 RVA: 0x00017D94 File Offset: 0x00015F94
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

		// Token: 0x060004BB RID: 1211 RVA: 0x00017E28 File Offset: 0x00016028
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

		// Token: 0x060004BC RID: 1212 RVA: 0x00017E5C File Offset: 0x0001605C
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

		// Token: 0x060004BD RID: 1213 RVA: 0x00017E94 File Offset: 0x00016094
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

		// Token: 0x060004BE RID: 1214 RVA: 0x00017EF0 File Offset: 0x000160F0
		public sealed override bool CanRemoveChildren()
		{
			return false;
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00017EF4 File Offset: 0x000160F4
		internal override void ReadXml(XmlNode xmlNode, ICollection<string> errors)
		{
			base.ReadXml(SmartGroup.NodeActions, xmlNode, errors);
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00017F04 File Offset: 0x00016104
		internal override void WriteXml(XmlTextWriter tw)
		{
			tw.WriteStartElement("smartGroup");
			this.Properties.Expanded.Value = base.IsExpanded;
			base.WriteXmlSettingsGroups(tw);
			this.RuleGroup.WriteXml(tw);
			tw.WriteEndElement();
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00017F50 File Offset: 0x00016150
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

		// Token: 0x060004C2 RID: 1218 RVA: 0x00017FE8 File Offset: 0x000161E8
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

		// Token: 0x060004C3 RID: 1219 RVA: 0x00018058 File Offset: 0x00016258
		private void FinishConstruction(GroupBase parent)
		{
			ServerTree.Instance.AddNode(this, parent);
			this.ChangeImageIndex(ImageConstants.SmartGroup);
		}

		// Token: 0x040001E3 RID: 483
		internal const string XmlNodeName = "smartGroup";

		// Token: 0x040001E4 RID: 484
		private static List<SmartGroup> AllSmartGroups = new List<SmartGroup>();

		// Token: 0x040001E5 RID: 485
		protected new static Dictionary<string, Helpers.ReadXmlDelegate> NodeActions = new Dictionary<string, Helpers.ReadXmlDelegate>(GroupBase.NodeActions);
	}
}
