using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x020000C6 RID: 198
	[Export(typeof(IBuiltInVirtualGroup))]
	internal class RecentlyUsedGroup : BuiltInVirtualGroup<RecentlyUsedServerRef>, IServerRefFactory
	{
		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x00004AB5 File Offset: 0x00002CB5
		// (set) Token: 0x060004A7 RID: 1191 RVA: 0x00004ABC File Offset: 0x00002CBC
		public static RecentlyUsedGroup Instance { get; private set; }

		// Token: 0x060004A8 RID: 1192 RVA: 0x00004AC4 File Offset: 0x00002CC4
		static RecentlyUsedGroup()
		{
			Server.ConnectionStateChanged += RecentlyUsedGroup.Server_ConnectionStateChanged;
			Server.FocusReceived += RecentlyUsedGroup.Server_FocusReceived;
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00004AE8 File Offset: 0x00002CE8
		private static void Server_FocusReceived(Server server)
		{
			if (server.ConnectionState == RdpClient.ConnectionState.Connected)
			{
				RecentlyUsedGroup.Instance.MoveToTop(server);
			}
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00004AFE File Offset: 0x00002CFE
		private static void Server_ConnectionStateChanged(ConnectionStateChangedEventArgs args)
		{
			if (args.State == RdpClient.ConnectionState.Connected)
			{
				RecentlyUsedGroup.Instance.MoveToTop(args.Server);
			}
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00017B3C File Offset: 0x00015D3C
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

		// Token: 0x060004AC RID: 1196 RVA: 0x00004B19 File Offset: 0x00002D19
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

		// Token: 0x060004AD RID: 1197 RVA: 0x00017BAC File Offset: 0x00015DAC
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

		// Token: 0x060004AE RID: 1198 RVA: 0x00004B33 File Offset: 0x00002D33
		private RecentlyUsedGroup()
		{
			base.Text = "Recent";
			RecentlyUsedGroup.Instance = this;
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00004B4C File Offset: 0x00002D4C
		protected override void InitSettings()
		{
			base.Properties = new RecentlyUsedGroup.RecentlyUsedSettings();
			base.AllSettingsGroups.Add(base.Properties);
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x00004B6A File Offset: 0x00002D6A
		public override string ConfigName
		{
			get
			{
				return "RecentlyUsed";
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060004B1 RID: 1201 RVA: 0x00004460 File Offset: 0x00002660
		public override bool AllowSort
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00004460 File Offset: 0x00002660
		public override bool CanRemoveChildren()
		{
			return false;
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x000044A3 File Offset: 0x000026A3
		public override bool HasProperties
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00017C0C File Offset: 0x00015E0C
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

		// Token: 0x060004B5 RID: 1205 RVA: 0x00004B71 File Offset: 0x00002D71
		public ServerRef Create(Server server)
		{
			return new RecentlyUsedServerRef(server);
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x00004B79 File Offset: 0x00002D79
		protected override string XmlNodeName
		{
			get
			{
				return "recentlyUsed";
			}
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00004562 File Offset: 0x00002762
		protected override bool ShouldWriteNode(RdcTreeNode node, FileGroup file)
		{
			return file == null;
		}

		// Token: 0x020000C7 RID: 199
		private class RecentlyUsedSettings : GroupSettings
		{
			// Token: 0x060004B9 RID: 1209 RVA: 0x00004B80 File Offset: 0x00002D80
			static RecentlyUsedSettings()
			{
				typeof(RecentlyUsedGroup.RecentlyUsedSettings).GetSettingProperties(out RecentlyUsedGroup.RecentlyUsedSettings._settingProperties);
			}

			// Token: 0x060004BA RID: 1210 RVA: 0x00004B96 File Offset: 0x00002D96
			public RecentlyUsedSettings() : base("Properties")
			{
				base.InheritSettingsType.Mode = InheritanceMode.Disabled;
			}

			// Token: 0x060004BB RID: 1211 RVA: 0x00004BAF File Offset: 0x00002DAF
			public override TabPage CreateTabPage(TabbedSettingsDialog dialog)
			{
				return new RecentlyUsedGroup.RecentlyUsedSettings.RecentlyUsedSettingsTabPage(dialog, this);
			}

			// Token: 0x17000096 RID: 150
			// (get) Token: 0x060004BC RID: 1212 RVA: 0x00004BB8 File Offset: 0x00002DB8
			protected override Dictionary<string, SettingProperty> SettingProperties
			{
				get
				{
					return RecentlyUsedGroup.RecentlyUsedSettings._settingProperties;
				}
			}

			// Token: 0x17000097 RID: 151
			// (get) Token: 0x060004BD RID: 1213 RVA: 0x00004BBF File Offset: 0x00002DBF
			// (set) Token: 0x060004BE RID: 1214 RVA: 0x00004BC7 File Offset: 0x00002DC7
			[Setting("maxNumberOfServers", DefaultValue = 10)]
			public IntSetting MaxNumberOfServers { get; private set; }

			// Token: 0x04000430 RID: 1072
			private new const string TabName = "Properties";

			// Token: 0x04000431 RID: 1073
			private static Dictionary<string, SettingProperty> _settingProperties;

			// Token: 0x020000C8 RID: 200
			private class RecentlyUsedSettingsTabPage : SettingsTabPage<RecentlyUsedGroup.RecentlyUsedSettings>
			{
				// Token: 0x060004BF RID: 1215 RVA: 0x00017CD0 File Offset: 0x00015ED0
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
