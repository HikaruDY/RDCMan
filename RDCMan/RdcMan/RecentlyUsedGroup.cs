using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	[Export(typeof(IBuiltInVirtualGroup))]
	internal class RecentlyUsedGroup : BuiltInVirtualGroup<RecentlyUsedServerRef>, IServerRefFactory
	{
		public static RecentlyUsedGroup Instance { get; private set; }

		static RecentlyUsedGroup()
		{
			Server.ConnectionStateChanged += RecentlyUsedGroup.Server_ConnectionStateChanged;
			Server.FocusReceived += RecentlyUsedGroup.Server_FocusReceived;
		}

		private static void Server_FocusReceived(Server server)
		{
			if (server.ConnectionState == RdpClient.ConnectionState.Connected)
			{
				RecentlyUsedGroup.Instance.MoveToTop(server);
			}
		}

		private static void Server_ConnectionStateChanged(ConnectionStateChangedEventArgs args)
		{
			if (args.State == RdpClient.ConnectionState.Connected)
			{
				RecentlyUsedGroup.Instance.MoveToTop(args.Server);
			}
		}

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

		private RecentlyUsedGroup()
		{
			base.Text = "Recent";
			RecentlyUsedGroup.Instance = this;
		}

		protected override void InitSettings()
		{
			base.Properties = new RecentlyUsedGroup.RecentlyUsedSettings();
			base.AllSettingsGroups.Add(base.Properties);
		}

		public override string ConfigName
		{
			get
			{
				return "RecentlyUsed";
			}
		}

		public override bool AllowSort
		{
			get
			{
				return false;
			}
		}

		public override bool CanRemoveChildren()
		{
			return false;
		}

		public override bool HasProperties
		{
			get
			{
				return true;
			}
		}

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

		public ServerRef Create(Server server)
		{
			return new RecentlyUsedServerRef(server);
		}

		protected override string XmlNodeName
		{
			get
			{
				return "recentlyUsed";
			}
		}

		protected override bool ShouldWriteNode(RdcTreeNode node, FileGroup file)
		{
			return file == null;
		}

		private class RecentlyUsedSettings : GroupSettings
		{
			static RecentlyUsedSettings()
			{
				typeof(RecentlyUsedGroup.RecentlyUsedSettings).GetSettingProperties(out RecentlyUsedGroup.RecentlyUsedSettings._settingProperties);
			}

			public RecentlyUsedSettings() : base("Properties")
			{
				base.InheritSettingsType.Mode = InheritanceMode.Disabled;
			}

			public override TabPage CreateTabPage(TabbedSettingsDialog dialog)
			{
				return new RecentlyUsedGroup.RecentlyUsedSettings.RecentlyUsedSettingsTabPage(dialog, this);
			}

			protected override Dictionary<string, SettingProperty> SettingProperties
			{
				get
				{
					return RecentlyUsedGroup.RecentlyUsedSettings._settingProperties;
				}
			}

			[Setting("maxNumberOfServers", DefaultValue = 10)]
			public IntSetting MaxNumberOfServers { get; private set; }

			private new const string TabName = "Properties";

			private static Dictionary<string, SettingProperty> _settingProperties;

			private class RecentlyUsedSettingsTabPage : SettingsTabPage<RecentlyUsedGroup.RecentlyUsedSettings>
			{
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
