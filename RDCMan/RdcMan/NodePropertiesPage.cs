using System;
using System.Windows.Forms;

namespace RdcMan
{
	public abstract class NodePropertiesPage<TSettingsGroup> : SettingsTabPage<TSettingsGroup>, INodePropertiesPage where TSettingsGroup : SettingsGroup
	{
		protected NodePropertiesPage(TabbedSettingsDialog dialog, TSettingsGroup settings, string name) : base(dialog, settings, name)
		{
		}

		public event Action<GroupBase> ParentGroupChanged;

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

		public void SetParentDropDown(GroupBase group)
		{
			this._parentComboBox.AddItem(group.FullPath, group);
			this._parentComboBox.SelectedIndex = 0;
		}

		protected abstract bool CanBeParent(GroupBase group);

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

		protected void AddParentCombo(ref int rowIndex, ref int tabIndex)
		{
			this._parentComboBox = FormTools.AddLabeledValueDropDown<GroupBase>(this, "&Parent:", ref rowIndex, ref tabIndex, null, null);
			this._parentComboBox.SelectedIndexChanged += this.ParentGroupChangedHandler;
		}

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

		protected virtual void ParentGroupChangedHandler(object sender, EventArgs e)
		{
			GroupBase selectedValue = this._parentComboBox.SelectedValue;
			this.ParentGroupChanged(selectedValue);
		}

		protected ValueComboBox<GroupBase> _parentComboBox;
	}
}
