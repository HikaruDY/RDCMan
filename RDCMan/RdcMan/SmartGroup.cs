﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	internal class SmartGroup : VirtualGroup
	{
		static SmartGroup()
		{
			SmartGroup.NodeActions["ruleGroup"] = delegate(XmlNode childNode, RdcTreeNode node, ICollection<string> errors)
			{
				(node as SmartGroup).RuleGroup = RuleGroup.Create(childNode, node, errors);
			};
			ServerTree.Instance.GroupChanged += SmartGroup.OnGroupChanged;
			ServerTree.Instance.ServerChanged += SmartGroup.OnServerChanged;
		}

		protected SmartGroup()
		{
			SmartGroup.AllSmartGroups.Add(this);
		}

		protected override void InitSettings()
		{
			base.Properties = new SmartGroupSettings();
			base.AllSettingsGroups.Add(this.Properties);
			this.RuleGroup = new RuleGroup(RuleGroupOperator.All, Enumerable.Empty<Rule>());
		}

		public static SmartGroup CreateForAdd()
		{
			return new SmartGroup();
		}

		public static SmartGroup Create(SmartGroupPropertiesDialog dlg)
		{
			SmartGroup smartGroup = dlg.AssociatedNode as SmartGroup;
			smartGroup.UpdateSettings(dlg);
			smartGroup.FinishConstruction(dlg.PropertiesPage.ParentGroup);
			smartGroup.Refresh();
			return smartGroup;
		}

		public static SmartGroup Create(XmlNode xmlNode, GroupBase parent, ICollection<string> errors)
		{
			SmartGroup smartGroup = new SmartGroup();
			smartGroup.FinishConstruction(parent);
			smartGroup.ReadXml(xmlNode, errors);
			smartGroup.Text = smartGroup.Properties.GroupName.Value;
			return smartGroup;
		}

		public new SmartGroupSettings Properties
		{
			get
			{
				return base.Properties as SmartGroupSettings;
			}
		}

		public RuleGroup RuleGroup { get; private set; }

		public sealed override bool CanDropServers()
		{
			return false;
		}

		public override void OnRemoving()
		{
			base.OnRemoving();
			SmartGroup.AllSmartGroups.Remove(this);
		}

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

		public sealed override bool CanRemoveChildren()
		{
			return false;
		}

		internal override void ReadXml(XmlNode xmlNode, ICollection<string> errors)
		{
			base.ReadXml(SmartGroup.NodeActions, xmlNode, errors);
		}

		internal override void WriteXml(XmlTextWriter tw)
		{
			tw.WriteStartElement("smartGroup");
			this.Properties.Expanded.Value = base.IsExpanded;
			base.WriteXmlSettingsGroups(tw);
			this.RuleGroup.WriteXml(tw);
			tw.WriteEndElement();
		}

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

		private void FinishConstruction(GroupBase parent)
		{
			ServerTree.Instance.AddNode(this, parent);
			this.ChangeImageIndex(ImageConstants.SmartGroup);
		}

		internal const string XmlNodeName = "smartGroup";

		private static List<SmartGroup> AllSmartGroups = new List<SmartGroup>();

		protected new static Dictionary<string, Helpers.ReadXmlDelegate> NodeActions = new Dictionary<string, Helpers.ReadXmlDelegate>(GroupBase.NodeActions);
	}
}
