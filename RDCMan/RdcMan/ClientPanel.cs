using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Win32;

namespace RdcMan
{
	internal class ClientPanel : Control
	{
		public bool Resizing
		{
			get
			{
				return this._resizing;
			}
			set
			{
				this._resizing = value;
				if (this._resizing)
				{
					this._savedBeforeSize = base.ClientSize;
					return;
				}
				this.OnClientSizeChanged(null);
			}
		}

		public ClientPanel()
		{
			base.TabStop = false;
			this._verticalScrollBar = new VScrollBar
			{
				Dock = DockStyle.Right,
				TabStop = false,
				Visible = false
			};
			this._verticalScrollBar.Scroll += this.OnScroll;
			base.Controls.Add(this._verticalScrollBar);
			this.Dock = DockStyle.Fill;
			this.DoubleBuffered = false;
			this._groupScrollPosition = new Dictionary<TreeNode, int>();
			ServerTree.Instance.GroupChanged += this.OnGroupChanged;
			ServerTree.Instance.ServerChanged += this.OnServerChanged;
			this._layoutHash = new Dictionary<TreeNode, ThumbnailLayout>();
		}

		private void OnGroupChanged(GroupChangedEventArgs obj)
		{
			if ((obj.Group == ServerTree.Instance.RootNode && !obj.ChangeType.HasFlag(ChangeType.PropertyChanged)) || (obj.Group != ServerTree.Instance.RootNode && !obj.ChangeType.HasFlag(ChangeType.InvalidateUI)))
			{
				return;
			}
			ThumbnailLayout layout = this._layout;
			GroupBase groupBase = (layout != null) ? layout.Group : null;
			bool flag = false;
			if (layout != null)
			{
				ThumbnailLayout thumbnailLayout = this.CreateThumbnailLayout(groupBase);
				if (!obj.ChangeType.HasFlag(ChangeType.PropertyChanged) && thumbnailLayout.Equals(layout))
				{
					Log.Write("layout unchanged, not redrawing", Array.Empty<object>());
					thumbnailLayout.Dispose();
					this.UpdateNonLayoutSettings(layout);
				}
				else
				{
					this.HideGroup(groupBase);
					layout.Dispose();
					this._layoutHash[groupBase] = thumbnailLayout;
					this.ShowGroup(groupBase);
					flag = true;
				}
			}
			TreeNode treeNode = obj.Group;
			if (treeNode != ServerTree.Instance.RootNode)
			{
				while (treeNode != null)
				{
					ThumbnailLayout thumbnailLayout2;
					if (treeNode == groupBase)
					{
						if (!flag)
						{
							break;
						}
					}
					else if (this._layoutHash.TryGetValue(treeNode, out thumbnailLayout2))
					{
						this._layoutHash.Remove(treeNode);
						thumbnailLayout2.Dispose();
					}
					treeNode = treeNode.Parent;
				}
			}
			else
			{
				this.ResetLayout();
			}
			if (layout == null)
			{
				ServerBase serverBase = ServerTree.Instance.SelectedNode as ServerBase;
				if (serverBase != null)
				{
					this.UpdateNonLayoutSettings(serverBase.ServerNode);
				}
			}
		}

		private void UpdateNonLayoutSettings(ThumbnailLayout shownLayout)
		{
			shownLayout.LabelArray.ForEach(delegate(ServerLabel l)
			{
				this.UpdateNonLayoutSettings(l.Server);
			});
		}

		private void UpdateNonLayoutSettings(Server server)
		{
			server.SetClientSizeProperties();
			server.EnableDisableClient();
		}

		private void OnServerChanged(ServerChangedEventArgs obj)
		{
			if (obj.ChangeType.HasFlag(ChangeType.PropertyChanged))
			{
				using (Helpers.Timer("thumbnail ServerChanged handler", Array.Empty<object>()))
				{
					Server serverNode = obj.Server.ServerNode;
					foreach (ThumbnailLayout thumbnailLayout in this._layoutHash.Values)
					{
						foreach (ServerLabel serverLabel in thumbnailLayout.LabelArray)
						{
							if (serverLabel.Server == serverNode)
							{
								serverLabel.CopyServerData();
							}
						}
					}
				}
			}
		}

		public RdcTreeNode GetSelectedNode(Control active)
		{
			ServerLabel serverLabel = active as ServerLabel;
			if (serverLabel != null)
			{
				return serverLabel.AssociatedNode;
			}
			return null;
		}

		private void ResetLayout()
		{
			foreach (ThumbnailLayout thumbnailLayout in (from l in this._layoutHash.Values
			where l != this._layout
			select l).ToList<ThumbnailLayout>())
			{
				thumbnailLayout.Dispose();
				this._layoutHash.Remove(thumbnailLayout.Group);
			}
		}

		[Conditional("DEBUG")]
		private void AssertValid()
		{
			foreach (object obj in base.Controls)
			{
				Control control = (Control)obj;
			}
		}

		public void ShowGroup(GroupBase group)
		{
			bool flag = true;
			if (this._layout != null && this._layout.Group == group)
			{
				flag = false;
			}
			if (!this._layoutHash.TryGetValue(group, out this._layout))
			{
				this._layout = this.CreateThumbnailLayout(group);
				this._layoutHash.Add(group, this._layout);
			}
			this.ComputeScrollBarLimits();
			if (flag)
			{
				int scrollPosition;
				if (!this._groupScrollPosition.TryGetValue(group, out scrollPosition))
				{
					scrollPosition = 0;
				}
				this.SetScrollPosition(scrollPosition);
			}
			this._thumbnailDrawn = new bool[this._layout.NodeCount];
			this.DrawThumbnails(group);
		}

		private ThumbnailLayout CreateThumbnailLayout(GroupBase group)
		{
			ThumbnailLayout thumbnailLayout;
			using (Helpers.Timer("creating thumbnail layout for {0}", new object[]
			{
				group.Text
			}))
			{
				thumbnailLayout = new ThumbnailLayout(group);
				int num;
				if (Program.Preferences.ThumbnailSizeIsInPixels)
				{
					Size thumbnailSize = Program.Preferences.ThumbnailSize;
					this._thumbnailUnitWidth = thumbnailSize.Width;
					this._thumbnailUnitHeight = thumbnailSize.Height;
					num = this.ComputeNumAcross(base.ClientSize.Width, this._thumbnailUnitWidth);
				}
				else
				{
					num = 100 / Program.Preferences.ThumbnailPercentage;
					this._thumbnailUnitWidth = (base.ClientSize.Width - this._verticalScrollBar.Width - 8) / num - 8;
					this._thumbnailUnitHeight = (base.ClientSize.Height - 6) / num - ClientPanel.ThumbnailLabelHeight - 6;
					Program.Preferences.ThumbnailSize = new Size(this._thumbnailUnitWidth, this._thumbnailUnitHeight);
				}
				thumbnailLayout.Compute(num);
			}
			return thumbnailLayout;
		}

		public void HideGroup(GroupBase group)
		{
			if (this._layout != null)
			{
				if (this._layout.Group != group)
				{
					return;
				}
				this._groupScrollPosition[group] = this._verticalScrollBar.Value;
				try
				{
					ServerLabel serverLabel = Program.TheForm.ActiveControl as ServerLabel;
					foreach (ServerLabel serverLabel2 in this._layout.LabelArray)
					{
						if (serverLabel == serverLabel2)
						{
							Program.TheForm.ActiveControl = this;
						}
						serverLabel2.Server.Hide();
						base.Controls.Remove(serverLabel2);
					}
				}
				finally
				{
					this._layout = null;
				}
			}
			this._verticalScrollBar.Hide();
		}

		public void ScrollServerIntoView(ServerLabel label)
		{
			int thumbnailIndex = label.ThumbnailIndex;
			if (!this._layout.IsServerPositionComputed(thumbnailIndex))
			{
				this.ComputeThumbnailPosition(label);
			}
			Rectangle thumbnailAbsoluteBounds = this._layout.GetThumbnailAbsoluteBounds(thumbnailIndex);
			int num = thumbnailAbsoluteBounds.Bottom + ServerLabel.Height;
			int height = base.ClientSize.Height;
			if (thumbnailAbsoluteBounds.Top < this._verticalScrollBar.Value || num > this._verticalScrollBar.Value + height - 1)
			{
				int value = this._verticalScrollBar.Value;
				int scrollPosition;
				if (value < thumbnailAbsoluteBounds.Top)
				{
					scrollPosition = num - height + 1;
				}
				else
				{
					scrollPosition = thumbnailAbsoluteBounds.Top;
				}
				this.SetScrollPosition(scrollPosition);
				this.DrawAndScroll(value, this._verticalScrollBar.Value);
			}
		}

		private void ComputeScrollBarLimits()
		{
			int unitHeight = this.UnitHeight;
			int num = (this._layout.LowestTileY + 1) * unitHeight;
			int height = base.ClientSize.Height;
			int num2 = num - height;
			if (this._verticalScrollBar.Visible = (num2 > 0))
			{
				this._verticalScrollBar.LargeChange = height;
				this._verticalScrollBar.SmallChange = unitHeight;
				this._verticalScrollBar.Maximum = num;
				this.SetScrollPosition(this._verticalScrollBar.Value);
			}
		}

		private int UnitHeight
		{
			get
			{
				return Math.Max(this._thumbnailUnitHeight + ClientPanel.ThumbnailLabelHeight + 6, 1);
			}
		}

		private int GetServerHeight(int serverScale)
		{
			return this._thumbnailUnitHeight * serverScale + (ClientPanel.ThumbnailLabelHeight + 6) * (serverScale - 1);
		}

		private void SetScrollPosition(int value)
		{
			this._verticalScrollBar.Value = Math.Min(value, this._verticalScrollBar.Maximum - this._verticalScrollBar.LargeChange + 1);
		}

		private void DrawThumbnails(GroupBase group)
		{
			if (this._layout.NodeCount == 0)
			{
				return;
			}
			using (Helpers.Timer("drawing {0} ({1} thumbnails)", new object[]
			{
				group.Text,
				this._layout.NodeCount
			}))
			{
				this.DrawThumbnails(this._verticalScrollBar.Value, this._verticalScrollBar.Value, base.ClientSize.Height);
			}
		}

		private void DrawThumbnails(int oldValue, int newValue, int height)
		{
			foreach (int num in this.GetUndrawnServersInViewport(newValue, height))
			{
				this._thumbnailDrawn[num - 1] = true;
				ServerLabel label = this._layout.LabelArray[num - 1];
				if (!this._layout.IsServerPositionComputed(num))
				{
					this.ComputeThumbnailPosition(label);
				}
				this.DrawThumbnail(label, oldValue);
			}
		}

		private void DrawThumbnail(ServerLabel label, int windowTop)
		{
			Rectangle thumbnailAbsoluteBounds = this._layout.GetThumbnailAbsoluteBounds(label.ThumbnailIndex);
			int num = thumbnailAbsoluteBounds.Top - windowTop;
			int top = num + ClientPanel.ThumbnailLabelHeight - 1;
			Server server = label.Server;
			server.SetThumbnailView(thumbnailAbsoluteBounds.X, top, thumbnailAbsoluteBounds.Width, thumbnailAbsoluteBounds.Height);
			label.Size = new Size(thumbnailAbsoluteBounds.Width, ClientPanel.ThumbnailLabelHeight);
			label.Location = new Point(thumbnailAbsoluteBounds.X, num);
			base.Controls.Add(label);
			label.Show();
			server.Show();
			if (Program.TheForm.ActiveControl == this && label.ThumbnailIndex == this._layout.FocusedServerIndex)
			{
				label.Focus();
				this._layout.FocusedServerIndex = 0;
			}
		}

		private unsafe void DrawAndScroll(int oldValue, int newValue)
		{
			using (Helpers.Timer("scrolling thumbnails {0} => {1}", new object[]
			{
				oldValue,
				newValue
			}))
			{
				Size clientSize = base.ClientSize;
				int height = clientSize.Height;
				this.DrawThumbnails(oldValue, newValue, height);
				if (oldValue != newValue)
				{
					Structs.RECT rect = new Structs.RECT
					{
						top = 0,
						bottom = clientSize.Height,
						left = 0,
						right = this._verticalScrollBar.Left - 1
					};
					Structs.RECT rect2 = new Structs.RECT
					{
						top = 0 - oldValue,
						bottom = this._verticalScrollBar.Maximum - oldValue,
						left = 0,
						right = this._verticalScrollBar.Left - 1
					};
					Structs.RECT* value = &rect;
					Structs.RECT* value2 = &rect2;
					User.ScrollWindowEx(base.Handle, 0, oldValue - newValue, (IntPtr)((void*)value2), (IntPtr)((void*)value), (IntPtr)null, (IntPtr)null, 7U);
				}
			}
		}

		protected override void OnClientSizeChanged(EventArgs e)
		{
			if (Program.TheForm.IsFullScreen)
			{
				return;
			}
			Size clientSize = base.ClientSize;
			try
			{
				TreeNode selectedNode = ServerTree.Instance.SelectedNode;
				GroupBase groupBase = selectedNode as GroupBase;
				if (groupBase == null)
				{
					ServerBase serverBase = selectedNode as ServerBase;
					if (serverBase != null)
					{
						if (serverBase.IsThumbnail)
						{
							throw new InvalidOperationException("Selected server is a thumbnail");
						}
						serverBase.ServerNode.SetNormalView();
						if (!this.Resizing && (this._savedBeforeSize.Width != this._savedSize.Width || this._savedBeforeSize.Height != this._savedSize.Height))
						{
							serverBase.ServerNode.Resize();
						}
					}
					this.ResetLayout();
				}
				else if (this._layout != null && this._layout.Group == groupBase)
				{
					if (Program.Preferences.ThumbnailSizeIsInPixels)
					{
						int width = Program.Preferences.ThumbnailSize.Width;
						if (this.ComputeNumAcross(clientSize.Width, width) == this.ComputeNumAcross(this._savedSize.Width, width))
						{
							if (this._savedSize.Height != clientSize.Height)
							{
								int value = this._verticalScrollBar.Value;
								this.ComputeScrollBarLimits();
								this.DrawAndScroll(value, this._verticalScrollBar.Value);
							}
							return;
						}
					}
					this.HideGroup(groupBase);
					this.ResetLayout();
					this.ShowGroup(groupBase);
				}
			}
			finally
			{
				this._savedSize = clientSize;
			}
		}

		protected override void OnMouseWheel(MouseEventArgs e)
		{
			if (!(ServerTree.Instance.SelectedNode is GroupBase))
			{
				return;
			}
			int value = this._verticalScrollBar.Value;
			int val = value - Math.Sign(e.Delta) * this._verticalScrollBar.SmallChange;
			this.SetScrollPosition(Math.Max(0, val));
			this.DrawAndScroll(value, this._verticalScrollBar.Value);
		}

		private int ComputeNumAcross(int totalWidth, int unitWidth)
		{
			totalWidth -= this._verticalScrollBar.Width;
			totalWidth -= 8;
			return totalWidth / (unitWidth + 8);
		}

		private void ComputeThumbnailPosition(ServerLabel label)
		{
			int value = label.Server.DisplaySettings.ThumbnailScale.Value;
			int width = this._thumbnailUnitWidth * value + 8 * (value - 1);
			int serverHeight = this.GetServerHeight(value);
			int thumbnailIndex = label.ThumbnailIndex;
			int num = this._layout.ServerTileY[thumbnailIndex];
			int num2 = this._layout.ServerTileX[thumbnailIndex];
			int x = (num2 + 1) * 8 + num2 * this._thumbnailUnitWidth;
			int y = (num + 1) * 6 + num * (this._thumbnailUnitHeight + ClientPanel.ThumbnailLabelHeight);
			this._layout.SetThumbnailAbsoluteBounds(thumbnailIndex, x, y, width, serverHeight);
		}

		private IEnumerable<int> GetUndrawnServersInViewport(int position, int height)
		{
			HashSet<int> hashSet = new HashSet<int>();
			if (this._layout.NodeCount == 0)
			{
				return hashSet;
			}
			int upperBound = this._layout.ServerLayoutToIndex.GetUpperBound(1);
			int unitHeight = this.UnitHeight;
			int num = position / unitHeight;
			int num2 = (position + height - 1) / unitHeight;
			num2 = Math.Min(num2, this._layout.ServerLayoutToIndex.GetUpperBound(0));
			for (int i = num; i <= num2; i++)
			{
				ServerLabel serverLabel;
				for (int j = 0; j <= upperBound; j += serverLabel.Server.DisplaySettings.ThumbnailScale.Value)
				{
					int num3 = this._layout.ServerLayoutToIndex[i, j];
					if (num3 == 0)
					{
						break;
					}
					if (!this._thumbnailDrawn[num3 - 1])
					{
						hashSet.Add(num3);
					}
					serverLabel = this._layout.LabelArray[num3 - 1];
				}
			}
			return hashSet;
		}

		private void OnScroll(object sender, ScrollEventArgs e)
		{
			this.DrawAndScroll(e.OldValue, e.NewValue);
		}

		public void RecordLastFocusedServerLabel(ServerLabel label)
		{
			this._layout.FocusedServerIndex = label.ThumbnailIndex;
		}

		protected override void OnEnter(EventArgs e)
		{
			bool flag = true;
			base.OnEnter(e);
			if (this._layout != null)
			{
				if (this._layout.NodeCount > 0)
				{
					ServerLabel serverLabel = this._layout.LabelArray[this._layout.FocusedServerIndex - 1];
					if (serverLabel.Parent == this)
					{
						serverLabel.Focus();
						flag = false;
					}
				}
			}
			else
			{
				ServerBase serverBase = ServerTree.Instance.SelectedNode as ServerBase;
				if (serverBase != null)
				{
					serverBase.Focus();
					flag = false;
				}
			}
			if (flag)
			{
				base.Focus();
			}
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			ServerLabel serverLabel = Program.TheForm.ActiveControl as ServerLabel;
			if (serverLabel == null)
			{
				if (this._layout == null || Program.TheForm.ActiveControl != this)
				{
					return base.ProcessCmdKey(ref msg, keyData);
				}
				serverLabel = this._layout.LabelArray[this._layout.FocusedServerIndex - 1];
			}
			this._layout.EnsureTabIndex();
			int value = serverLabel.Server.DisplaySettings.ThumbnailScale.Value;
			int num = serverLabel.ThumbnailIndex;
			int num2 = this._layout.ServerTileX[num];
			int num3 = this._layout.ServerTileY[num];
			int num4 = serverLabel.TabIndex;
			if (keyData != Keys.Tab)
			{
				switch (keyData)
				{
				case Keys.Prior:
				{
					if (num3 == 0)
					{
						return true;
					}
					int val = (int)Math.Floor((double)serverLabel.Top / (double)this.UnitHeight);
					int val2 = base.Height / this.UnitHeight;
					int num5 = Math.Max(val, val2);
					num3 = Math.Max(0, num3 - num5);
					break;
				}
				case Keys.Next:
				{
					if (num3 == this._layout.LowestTileY)
					{
						return true;
					}
					int val3 = (int)Math.Floor((double)(serverLabel.Top + this.GetServerHeight(value)) / (double)this.UnitHeight);
					int val4 = base.Height / this.UnitHeight;
					int num6 = Math.Max(val3, val4);
					num3 = Math.Min(this._layout.LowestTileY, num3 + num6);
					break;
				}
				case Keys.End:
					num2 = this._layout.ServerLayoutToIndex.GetUpperBound(1);
					num3 = this._layout.LowestTileY;
					break;
				case Keys.Home:
					num2 = 0;
					num3 = 0;
					break;
				case Keys.Left:
					if (--num4 == 0)
					{
						return true;
					}
					num = this._layout.TabIndexToServerIndex[num4];
					num2 = this._layout.ServerTileX[num];
					num3 = this._layout.ServerTileY[num];
					break;
				case Keys.Up:
					if (--num3 < 0)
					{
						return true;
					}
					break;
				case Keys.Right:
					if (++num4 > this._layout.NodeCount)
					{
						return true;
					}
					num = this._layout.TabIndexToServerIndex[num4];
					num2 = this._layout.ServerTileX[num];
					num3 = this._layout.ServerTileY[num];
					break;
				case Keys.Down:
					num3 += value;
					if (num3 > this._layout.LowestTileY)
					{
						return true;
					}
					break;
				default:
					if (keyData == (Keys.LButton | Keys.Back | Keys.Shift))
					{
						goto IL_E1;
					}
					return base.ProcessCmdKey(ref msg, keyData);
				}
				for (;;)
				{
					num = this._layout.ServerLayoutToIndex[num3, num2];
					if (num != 0)
					{
						break;
					}
					num2--;
				}
				serverLabel = this._layout.LabelArray[num - 1];
				this.ScrollServerIntoView(serverLabel);
				serverLabel.Focus();
				return true;
			}
			IL_E1:
			ServerTree.Instance.Focus();
			return true;
		}

		private static readonly int ThumbnailLabelHeight = ServerLabel.Height;

		private const int ThumbnailHorzSpace = 8;

		private const int ThumbnailVertSpace = 6;

		private Dictionary<TreeNode, ThumbnailLayout> _layoutHash;

		private readonly Dictionary<TreeNode, int> _groupScrollPosition;

		private ThumbnailLayout _layout;

		private Size _savedSize;

		private Size _savedBeforeSize;

		private int _thumbnailUnitWidth;

		private int _thumbnailUnitHeight;

		private bool[] _thumbnailDrawn;

		private readonly VScrollBar _verticalScrollBar;

		private bool _resizing;
	}
}
