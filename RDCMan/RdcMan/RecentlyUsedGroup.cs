using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000078 RID: 120
	[Export(typeof(IBuiltInVirtualGroup))]
	internal class RecentlyUsedGroup : BuiltInVirtualGroup<RecentlyUsedServerRef>, IServerRefFactory
	{
		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060003AF RID: 943 RVA: 0x00013F60 File Offset: 0x00012160
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x00013F68 File Offset: 0x00012168
		public static RecentlyUsedGroup Instance { get; private set; }

		// Token: 0x060003B1 RID: 945 RVA: 0x00013F70 File Offset: 0x00012170
		static RecentlyUsedGroup()
		{
			Server.ConnectionStateChanged += RecentlyUsedGroup.Server_ConnectionStateChanged;
			Server.FocusReceived += RecentlyUsedGroup.Server_FocusReceived;
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00013F94 File Offset: 0x00012194
		private static void Server_FocusReceived(Server server)
		{
			if (server.ConnectionState == RdpClient.ConnectionState.Connected)
			{
				RecentlyUsedGroup.Instance.MoveToTop(server);
			}
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00013FB0 File Offset: 0x000121B0
		private static void Server_ConnectionStateChanged(ConnectionStateChangedEventArgs args)
		{
			if (args.State == RdpClient.ConnectionState.Connected)
			{
				RecentlyUsedGroup.Instance.MoveToTop(args.Server);
			}
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00013FD0 File Offset: 0x000121D0
		public override RecentlyUsedServerRef AddReference(ServerBase serverBase)
		{
			Server server = serverBase.ServerNode;
			RecentlyUsedServerRef serverRef = server.FindServerRef<RecentlyUsedServerRef>();
			if (serverRef == null)
			{
				ServerTree.Instance.Operation(OperationBehavior.SuspendUpdate | OperationBehavior.SuspendGroupChanged, delegate
				{
					serverRef = (this.ServerRefFactory.Create(server) as RecentlyUsedServerRef);
					this.Nodes.Insert(0, serverRef);
					this.RemoveExtra();
				});
				ServerTree.Instance.OnGroupChanged(RecentlyUsedGroup.Instance, ChangeType.TreeChanged);
			}
			return serverRef;
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00014044 File Offset: 0x00012244
		private void RemoveExtra()
		{
			ServerTree.Instance.Operation(OperationBehavior.SuspendUpdate | OperationBehavior.SuspendGroupChanged, delegate
			{
				int value = (base.Properties as RecentlyUsedGroup.RecentlyUsedSettings).MaxNumberOfServers.Value;
				while (base.Nodes.Count > value)
				{
					ServerTree.Instance.RemoveNode(base.Nodes[value] as RdcTreeNode);
				}
			});
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00014060 File Offset: 0x00012260
		private void MoveToTop(Server server)
		{
			ServerRef serverRef = this.AddReference(server);
			if (serverRef.Index > 0)
			{
				ServerTree.Instance.Operation(OperationBehavior.RestoreSelected, delegate
				{
					this.Nodes.Remove(serverRef);
					this.Nodes.Insert(0, serverRef);
				});
				ServerTree.Instance.OnGroupChanged(RecentlyUsedGroup.Instance, ChangeType.InvalidateUI);
			}
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x000140C4 File Offset: 0x000122C4
		private RecentlyUsedGroup()
		{
			base.Text = "Recent";
			RecentlyUsedGroup.Instance = this;
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x000140E0 File Offset: 0x000122E0
		protected override void InitSettings()
		{
			base.Properties = new RecentlyUsedGroup.RecentlyUsedSettings();
			base.AllSettingsGroups.Add(base.Properties);
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x00014110 File Offset: 0x00012310
		public override string ConfigName
		{
			get
			{
				return "RecentlyUsed";
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060003BA RID: 954 RVA: 0x00014118 File Offset: 0x00012318
		public override bool AllowSort
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0001411C File Offset: 0x0001231C
		public override bool CanRemoveChildren()
		{
			return false;
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060003BC RID: 956 RVA: 0x00014120 File Offset: 0x00012320
		public override bool HasProperties
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00014124 File Offset: 0x00012324
		public override void DoPropertiesDialog(Form parentForm, string activeTabName)
		{
			using (TabbedSettingsDialog tabbedSettingsDialog = new TabbedSettingsDialog("Recently Used Group Settings", "OK", parentForm))
			{
				tabbedSettingsDialog.AddTabPage(base.Properties.CreateTabPage(tabbedSettingsDialog));
				tabbedSettingsDialog.InitButtons();
				if (tabbedSettingsDialog.ShowDialog(parentForm) == DialogResult.OK)
				{
					tabbedSettingsDialog.UpdateSettings();
					this.RemoveExtra();
					ServerTree.Instance.OnGroupChanged(this, ChangeType.PropertyChanged);
				}
			}
		}

		// Token: 0x060003BE RID: 958 RVA: 0x000141A4 File Offset: 0x000123A4
		public ServerRef Create(Server server)
		{
			return new RecentlyUsedServerRef(server);
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060003BF RID: 959 RVA: 0x000141AC File Offset: 0x000123AC
		protected override string XmlNodeName
		{
			get
			{
				return "recentlyUsed";
			}
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x000141B4 File Offset: 0x000123B4
		protected override bool ShouldWriteNode(RdcTreeNode node, FileGroup file)
		{
			return file == null;
		}

		// Token: 0x02000268 RID: 616
		private class RecentlyUsedSettings : GroupSettings
		{
			// Token: 0x060056A4 RID: 22180 RVA: 0x0005E61C File Offset: 0x0005C81C
			static RecentlyUsedSettings()
			{
				typeof(RecentlyUsedGroup.RecentlyUsedSettings).GetSettingProperties(out RecentlyUsedGroup.RecentlyUsedSettings._settingProperties);
			}

			// Token: 0x060056A5 RID: 22181 RVA: 0x0005E634 File Offset: 0x0005C834
			public RecentlyUsedSettings() : base("Properties")
			{
				base.InheritSettingsType.Mode = InheritanceMode.Disabled;
			}

			// Token: 0x060056A6 RID: 22182 RVA: 0x0005E650 File Offset: 0x0005C850
			public override TabPage CreateTabPage(TabbedSettingsDialog dialog)
			{
				return new RecentlyUsedGroup.RecentlyUsedSettings.RecentlyUsedSettingsTabPage(dialog, this);
			}

			// Token: 0x17002142 RID: 8514
			// (get) Token: 0x060056A7 RID: 22183 RVA: 0x0005E65C File Offset: 0x0005C85C
			protected override Dictionary<string, SettingProperty> SettingProperties
			{
				get
				{
					return RecentlyUsedGroup.RecentlyUsedSettings._settingProperties;
				}
			}

			// Token: 0x17002143 RID: 8515
			// (get) Token: 0x060056A8 RID: 22184 RVA: 0x0005E664 File Offset: 0x0005C864
			// (set) Token: 0x060056A9 RID: 22185 RVA: 0x0005E66C File Offset: 0x0005C86C
			[Setting("maxNumberOfServers", DefaultValue = 10)]
			public IntSetting MaxNumberOfServers { get; private set; }

			// Token: 0x04000AA2 RID: 2722
			private new const string TabName = "Properties";

			// Token: 0x04000AA3 RID: 2723
			private static Dictionary<string, SettingProperty> _settingProperties;

			// Token: 0x020002BE RID: 702
			private class RecentlyUsedSettingsTabPage : SettingsTabPage<RecentlyUsedGroup.RecentlyUsedSettings>
			{
				// Token: 0x0600577F RID: 22399 RVA: 0x0006022C File Offset: 0x0005E42C
				public RecentlyUsedSettingsTabPage(TabbedSettingsDialog dialog, RecentlyUsedGroup.RecentlyUsedSettings settings) : base(dialog, settings)
				{
					int rowIndex = 0;
					int num = 0;
					Label label = FormTools.NewLabel("Number of entries", 0, rowIndex);
					NumericTextBox numericTextBox = new NumericTextBox(1, 20, "Number of entries must be 1 to 20")
					{
						Location = FormTools.NewLocation(1, rowIndex++),
						TabIndex = num++,
						TabStop = true,
						Setting = base.Settings.MaxNumberOfServers,
						Size = new Size(20, 20)
					};
					base.Controls.Add(new Control[]
					{
						label,
						numericTextBox
					});
					base.FocusControl = numericTextBox;
				}
			}
		}
	}
}
