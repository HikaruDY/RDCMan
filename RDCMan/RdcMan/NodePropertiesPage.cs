using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000058 RID: 88
	public abstract class NodePropertiesPage<TSettingsGroup> : SettingsTabPage<TSettingsGroup>, INodePropertiesPage where TSettingsGroup : SettingsGroup
	{
		// Token: 0x06000220 RID: 544 RVA: 0x0000CBA0 File Offset: 0x0000ADA0
		protected NodePropertiesPage(TabbedSettingsDialog dialog, TSettingsGroup settings, string name) : base(dialog, settings, name)
		{
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000221 RID: 545 RVA: 0x0000CBAC File Offset: 0x0000ADAC
		// (remove) Token: 0x06000222 RID: 546 RVA: 0x0000CBE8 File Offset: 0x0000ADE8
		public event Action<GroupBase> ParentGroupChanged;

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000223 RID: 547 RVA: 0x0000CC24 File Offset: 0x0000AE24
		public GroupBase ParentGroup
		{
			get
			{
				if (this._parentComboBox == null || !this._parentComboBox.Enabled)
				{
					return null;
				}
				return this._parentComboBox.SelectedValue;
			}
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0000CC50 File Offset: 0x0000AE50
		public bool PopulateParentDropDown(GroupBase excludeGroup, GroupBase defaultParent)
		{
			this.PopulateParentDropDown(excludeGroup);
			if (defaultParent != null && this.CanBeParent(defaultParent))
			{
				this._parentComboBox.SelectedValue = defaultParent;
			}
			else
			{
				if (this._parentComboBox.ItemCount == 0)
				{
					return false;
				}
				this._parentComboBox.SelectedIndex = 0;
			}
			return true;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000CCAC File Offset: 0x0000AEAC
		public void SetParentDropDown(GroupBase group)
		{
			this._parentComboBox.AddItem(group.FullPath, group);
			this._parentComboBox.SelectedIndex = 0;
		}

		// Token: 0x06000226 RID: 550
		protected abstract bool CanBeParent(GroupBase group);

		// Token: 0x06000227 RID: 551 RVA: 0x0000CCCC File Offset: 0x0000AECC
		private void PopulateParentDropDown(GroupBase excludeGroup)
		{
			ServerTree.Instance.Nodes.VisitNodes(delegate(RdcTreeNode node)
			{
				if (node == excludeGroup)
				{
					return NodeVisitorResult.NoRecurse;
				}
				GroupBase groupBase = node as GroupBase;
				if (groupBase != null && this.CanBeParent(groupBase))
				{
					this._parentComboBox.AddItem(groupBase.FullPath, groupBase);
				}
				return NodeVisitorResult.Continue;
			});
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0000CD10 File Offset: 0x0000AF10
		protected void AddParentCombo(ref int rowIndex, ref int tabIndex)
		{
			this._parentComboBox = FormTools.AddLabeledValueDropDown<GroupBase>(this, "&Parent:", ref rowIndex, ref tabIndex, null, null);
			this._parentComboBox.SelectedIndexChanged += this.ParentGroupChangedHandler;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0000CD40 File Offset: 0x0000AF40
		protected RdcTextBox AddComment(ref int rowIndex, ref int tabIndex)
		{
			Label label = FormTools.NewLabel("&Comment:", 0, rowIndex);
			int colIndex = 1;
			int num = rowIndex;
			rowIndex = num + 1;
			int rowIndex2 = num;
			num = tabIndex;
			tabIndex = num + 1;
			RdcTextBox rdcTextBox = FormTools.NewTextBox(colIndex, rowIndex2, num, 7);
			rdcTextBox.Enabled = true;
			base.Controls.Add(new Control[]
			{
				label,
				rdcTextBox
			});
			return rdcTextBox;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000CD9C File Offset: 0x0000AF9C
		protected virtual void ParentGroupChangedHandler(object sender, EventArgs e)
		{
			GroupBase selectedValue = this._parentComboBox.SelectedValue;
			this.ParentGroupChanged(selectedValue);
		}

		// Token: 0x0400012B RID: 299
		protected ValueComboBox<GroupBase> _parentComboBox;
	}
}
