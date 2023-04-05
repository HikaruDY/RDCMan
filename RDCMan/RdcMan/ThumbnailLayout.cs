using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	internal class ThumbnailLayout : IDisposable, IEquatable<ThumbnailLayout>
	{
		public int FocusedServerIndex { get; set; }

		public int[] TabIndexToServerIndex
		{
			get
			{
				this.EnsureTabIndex();
				return this._tabIndexToServerIndex;
			}
		}

		public bool IsServerPositionComputed(int index)
		{
			return this._isServerPositionComputed[index];
		}

		public int NodeCount
		{
			get
			{
				return this.LabelArray.Length;
			}
		}

		public int LowestTileY { get; private set; }

		public GroupBase Group { get; private set; }

		public ThumbnailLayout(GroupBase group)
		{
			this.Group = group;
		}

		~ThumbnailLayout()
		{
			this.Dispose(false);
		}

		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

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

		public override string ToString()
		{
			return "{0} ({1} servers)".InvariantFormat(new object[]
			{
				this.Group.Text,
				this.NodeCount
			});
		}

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

		public void SetThumbnailIndex()
		{
			int num = 0;
			foreach (ServerLabel serverLabel in this.LabelArray)
			{
				num = (serverLabel.ThumbnailIndex = num + 1);
			}
		}

		public void SetThumbnailAbsoluteBounds(int serverIndex, int x, int y, int width, int height)
		{
			this._thumbnailAbsoluteBounds[serverIndex] = new Rectangle(x, y, width, height);
			this._isServerPositionComputed[serverIndex] = true;
		}

		public Rectangle GetThumbnailAbsoluteBounds(int serverIndex)
		{
			return this._thumbnailAbsoluteBounds[serverIndex];
		}

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

		public int[] ServerTileX;

		public int[] ServerTileY;

		public int[,] ServerLayoutToIndex;

		public ServerLabel[] LabelArray;

		private int[] _tabIndexToServerIndex;

		private Rectangle[] _thumbnailAbsoluteBounds;

		private bool[] _isServerPositionComputed;

		private int _maxNodeIndex;

		private bool _disposed;

		private class LayoutComparer : IComparer<ServerLabel>
		{
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
