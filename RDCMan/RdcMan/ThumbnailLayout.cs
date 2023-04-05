using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x020000E9 RID: 233
	internal class ThumbnailLayout : IDisposable, IEquatable<ThumbnailLayout>
	{
		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000838 RID: 2104 RVA: 0x00022F08 File Offset: 0x00021108
		// (set) Token: 0x06000839 RID: 2105 RVA: 0x00022F10 File Offset: 0x00021110
		public int FocusedServerIndex { get; set; }

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x0600083A RID: 2106 RVA: 0x00022F1C File Offset: 0x0002111C
		public int[] TabIndexToServerIndex
		{
			get
			{
				this.EnsureTabIndex();
				return this._tabIndexToServerIndex;
			}
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x00022F2C File Offset: 0x0002112C
		public bool IsServerPositionComputed(int index)
		{
			return this._isServerPositionComputed[index];
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x0600083C RID: 2108 RVA: 0x00022F38 File Offset: 0x00021138
		public int NodeCount
		{
			get
			{
				return this.LabelArray.Length;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x00022F44 File Offset: 0x00021144
		// (set) Token: 0x0600083E RID: 2110 RVA: 0x00022F4C File Offset: 0x0002114C
		public int LowestTileY { get; private set; }

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x00022F58 File Offset: 0x00021158
		// (set) Token: 0x06000840 RID: 2112 RVA: 0x00022F60 File Offset: 0x00021160
		public GroupBase Group { get; private set; }

		// Token: 0x06000841 RID: 2113 RVA: 0x00022F6C File Offset: 0x0002116C
		public ThumbnailLayout(GroupBase group)
		{
			this.Group = group;
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00022F7C File Offset: 0x0002117C
		~ThumbnailLayout()
		{
			this.Dispose(false);
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x00022FAC File Offset: 0x000211AC
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x00022FBC File Offset: 0x000211BC
		protected virtual void Dispose(bool disposing)
		{
			if (!this._disposed)
			{
				if (disposing)
				{
					this.LabelArray.ForEach(delegate(ServerLabel l)
					{
						l.Dispose();
					});
					this.LabelArray = null;
				}
				this._disposed = true;
			}
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x0002301C File Offset: 0x0002121C
		public override string ToString()
		{
			return "{0} ({1} servers)".InvariantFormat(new object[]
			{
				this.Group.Text,
				this.NodeCount
			});
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x0002305C File Offset: 0x0002125C
		public void Compute(int numAcross)
		{
			using (Helpers.Timer("computing thumbnail layout", Array.Empty<object>()))
			{
				List<ServerLabel> list = this.CreateThumbnailList();
				this.LabelArray = list.ToArray();
			}
			if (this.NodeCount == 0)
			{
				return;
			}
			using (Helpers.Timer("sorting {0} thumbnails", new object[]
			{
				this.NodeCount
			}))
			{
				Array.Sort<ServerLabel>(this.LabelArray, new ThumbnailLayout.LayoutComparer());
			}
			this.SetThumbnailIndex();
			this.FocusedServerIndex = 1;
			this._maxNodeIndex = this.NodeCount + 1;
			int num = 0;
			List<List<ServerLabel>> list2 = new List<List<ServerLabel>>();
			List<ServerLabel> list3 = null;
			int value;
			foreach (ServerLabel serverLabel in this.LabelArray)
			{
				value = serverLabel.Server.DisplaySettings.ThumbnailScale.Value;
				if (list3 != null && num == value)
				{
					list3.Add(serverLabel);
				}
				else
				{
					list3 = new List<ServerLabel>();
					list3.Add(serverLabel);
					list2.Add(list3);
					num = value;
				}
			}
			value = this.LabelArray[0].Server.DisplaySettings.ThumbnailScale.Value;
			this.ServerLayoutToIndex = new int[this.NodeCount * value, Math.Max(numAcross, value)];
			this._isServerPositionComputed = new bool[this._maxNodeIndex];
			this._thumbnailAbsoluteBounds = new Rectangle[this._maxNodeIndex];
			this.ServerTileX = new int[this._maxNodeIndex];
			this.ServerTileY = new int[this._maxNodeIndex];
			using (Helpers.Timer("laying out {0} thumbnails", new object[]
			{
				this.NodeCount
			}))
			{
				int num2 = 0;
				int num3 = 0;
				while (list2.Count > 0)
				{
					bool flag = false;
					int num4 = -1;
					int j = 0;
					while (j < list2.Count)
					{
						list3 = list2[j];
						ServerLabel serverLabel2 = list3[0];
						value = serverLabel2.Server.DisplaySettings.ThumbnailScale.Value;
						if (num4 != -1 && value > num4)
						{
							break;
						}
						bool flag2 = false;
						if (num2 == 0 || num2 + value <= numAcross)
						{
							int num5 = Math.Min(value, numAcross);
							bool flag3 = true;
							for (int k = 0; k < num5; k++)
							{
								for (int l = 0; l < value; l++)
								{
									if (this.ServerLayoutToIndex[num3 + l, num2 + k] != 0)
									{
										num4 = k;
										flag3 = false;
										break;
									}
								}
								if (!flag3)
								{
									break;
								}
							}
							if (flag3)
							{
								flag2 = true;
							}
						}
						if (flag2)
						{
							int thumbnailIndex = serverLabel2.ThumbnailIndex;
							for (int m = 0; m < value; m++)
							{
								for (int n = 0; n < value; n++)
								{
									this.ServerLayoutToIndex[num3 + n, num2 + m] = thumbnailIndex;
								}
							}
							this.ServerTileX[thumbnailIndex] = num2;
							this.ServerTileY[thumbnailIndex] = num3;
							this.LowestTileY = Math.Max(this.LowestTileY, num3 + value - 1);
							flag = true;
							list3.Remove(serverLabel2);
							if (list3.Count == 0)
							{
								list2.Remove(list3);
							}
							num2 += value;
							if (num2 >= numAcross)
							{
								num2 = 0;
								num3++;
								break;
							}
							break;
						}
						else
						{
							j++;
						}
					}
					if (!flag && ++num2 >= numAcross)
					{
						num2 = 0;
						num3++;
					}
				}
			}
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x00023464 File Offset: 0x00021664
		public void SetThumbnailIndex()
		{
			int num = 0;
			foreach (ServerLabel serverLabel in this.LabelArray)
			{
				num = (serverLabel.ThumbnailIndex = num + 1);
			}
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x000234A4 File Offset: 0x000216A4
		public void SetThumbnailAbsoluteBounds(int serverIndex, int x, int y, int width, int height)
		{
			this._thumbnailAbsoluteBounds[serverIndex] = new Rectangle(x, y, width, height);
			this._isServerPositionComputed[serverIndex] = true;
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x000234C8 File Offset: 0x000216C8
		public Rectangle GetThumbnailAbsoluteBounds(int serverIndex)
		{
			return this._thumbnailAbsoluteBounds[serverIndex];
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x000234D8 File Offset: 0x000216D8
		public void EnsureTabIndex()
		{
			if (this._tabIndexToServerIndex != null)
			{
				return;
			}
			int upperBound = this.ServerLayoutToIndex.GetUpperBound(1);
			int lowestTileY = this.LowestTileY;
			int num = 1;
			this._tabIndexToServerIndex = new int[this._maxNodeIndex];
			for (int i = 0; i <= lowestTileY; i++)
			{
				ServerLabel serverLabel;
				for (int j = 0; j <= upperBound; j += serverLabel.Server.DisplaySettings.ThumbnailScale.Value)
				{
					int num2 = this.ServerLayoutToIndex[i, j];
					if (num2 == 0)
					{
						break;
					}
					serverLabel = this.LabelArray[num2 - 1];
					if (this.ServerTileY[num2] == i)
					{
						this._tabIndexToServerIndex[num] = serverLabel.ThumbnailIndex;
						serverLabel.TabIndex = num++;
					}
				}
			}
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x000235A8 File Offset: 0x000217A8
		private List<ServerLabel> CreateThumbnailList()
		{
			List<ServerLabel> labelList = new List<ServerLabel>();
			HashSet<Server> set = new HashSet<Server>();
			bool useActualNode = this.Group is VirtualGroup;
			this.Group.VisitNodes(delegate(RdcTreeNode node)
			{
				GroupBase groupBase = node as GroupBase;
				if (groupBase != null)
				{
					groupBase.InheritSettings();
					return;
				}
				ServerBase serverBase = node as ServerBase;
				Server serverNode = serverBase.ServerNode;
				if (!set.Contains(serverNode))
				{
					groupBase = (serverNode.Parent as GroupBase);
					if (groupBase != null)
					{
						groupBase.InheritSettings();
						if (groupBase.DisplaySettings.ShowDisconnectedThumbnails.Value || serverNode.IsConnected)
						{
							ServerLabel item = new ServerLabel(useActualNode ? serverBase : serverNode);
							labelList.Add(item);
							set.Add(serverNode);
						}
					}
				}
			});
			return labelList;
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x00023608 File Offset: 0x00021808
		public bool Equals(ThumbnailLayout other)
		{
			if (this.Group != other.Group || this.NodeCount != other.NodeCount)
			{
				return false;
			}
			for (int i = 0; i < this.NodeCount; i++)
			{
				if (this.LabelArray[i].AssociatedNode != other.LabelArray[i].AssociatedNode || this.ServerTileX[i] != other.ServerTileX[i] || this.ServerTileY[i] != other.ServerTileY[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0400035A RID: 858
		public int[] ServerTileX;

		// Token: 0x0400035B RID: 859
		public int[] ServerTileY;

		// Token: 0x0400035C RID: 860
		public int[,] ServerLayoutToIndex;

		// Token: 0x0400035D RID: 861
		public ServerLabel[] LabelArray;

		// Token: 0x0400035F RID: 863
		private int[] _tabIndexToServerIndex;

		// Token: 0x04000360 RID: 864
		private Rectangle[] _thumbnailAbsoluteBounds;

		// Token: 0x04000361 RID: 865
		private bool[] _isServerPositionComputed;

		// Token: 0x04000362 RID: 866
		private int _maxNodeIndex;

		// Token: 0x04000365 RID: 869
		private bool _disposed;

		// Token: 0x020002B8 RID: 696
		private class LayoutComparer : IComparer<ServerLabel>
		{
			// Token: 0x06005774 RID: 22388 RVA: 0x00060050 File Offset: 0x0005E250
			public int Compare(ServerLabel label1, ServerLabel label2)
			{
				Server server = label1.Server;
				Server server2 = label2.Server;
				server.InheritSettings();
				server2.InheritSettings();
				int value = server.DisplaySettings.ThumbnailScale.Value;
				int value2 = server2.DisplaySettings.ThumbnailScale.Value;
				int num = value2 - value;
				if (num != 0)
				{
					return num;
				}
				List<TreeNode> path = label1.AssociatedNode.GetPath();
				List<TreeNode> path2 = label2.AssociatedNode.GetPath();
				int num2 = Math.Min(path.Count, path2.Count);
				for (int i = 0; i < num2; i++)
				{
					num = path[i].Index - path2[i].Index;
					if (num != 0)
					{
						return num;
					}
				}
				return num;
			}
		}
	}
}
