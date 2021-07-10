using System;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000089 RID: 137
	public abstract class NodePropertiesPage<TSettingsGroup> : SettingsTabPage<TSettingsGroup>, INodePropertiesPage where TSettingsGroup : SettingsGroup
	{
		// Token: 0x0600028F RID: 655 RVA: 0x00003693 File Offset: 0x00001893
		protected NodePropertiesPage(TabbedSettingsDialog dialog, TSettingsGroup settings, string name) : base(dialog, settings, name)
		{
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000290 RID: 656 RVA: 0x00011BA4 File Offset: 0x0000FDA4
		// (remove) Token: 0x06000291 RID: 657 RVA: 0x00011BDC File Offset: 0x0000FDDC
		public event Action<GroupBase> ParentGroupChanged;

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000292 RID: 658 RVA: 0x0000369E File Offset: 0x0000189E
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

		// Token: 0x06000293 RID: 659 RVA: 0x000036C2 File Offset: 0x000018C2
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

		// Token: 0x06000294 RID: 660 RVA: 0x00003701 File Offset: 0x00001901
		public void SetParentDropDown(GroupBase group)
		{
			this._parentComboBox.AddItem(group.FullPath, group);
			this._parentComboBox.SelectedIndex = 0;
		}

		// Token: 0x06000295 RID: 661
		protected abstract bool CanBeParent(GroupBase group);

		// Token: 0x06000296 RID: 662 RVA: 0x00011C14 File Offset: 0x0000FE14
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

		// Token: 0x06000297 RID: 663 RVA: 0x00003721 File Offset: 0x00001921
		protected void AddParentCombo(ref int rowIndex, ref int tabIndex)
		{
			this._parentComboBox = FormTools.AddLabeledValueDropDown<GroupBase>(this, "&Parent:", ref rowIndex, ref tabIndex, null, null);
			this._parentComboBox.SelectedIndexChanged += this.ParentGroupChangedHandler;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00011C54 File Offset: 0x0000FE54
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

		// Token: 0x06000299 RID: 665 RVA: 0x00011CAC File Offset: 0x0000FEAC
		protected virtual void ParentGroupChangedHandler(object sender, EventArgs e)
		{
			GroupBase selectedValue = this._parentComboBox.SelectedValue;
			this.ParentGroupChanged(selectedValue);
		}

		// Token: 0x04000345 RID: 837
		protected ValueComboBox<GroupBase> _parentComboBox;
	}
}
