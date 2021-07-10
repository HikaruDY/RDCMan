using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	// Token: 0x020000E5 RID: 229
	public abstract class ServerRef : ServerBase
	{
		// Token: 0x060005A3 RID: 1443 RVA: 0x00005678 File Offset: 0x00003878
		protected ServerRef(Server server)
		{
			this._server = server;
			this._server.AddServerRef(this);
			base.Text = server.Text;
			this.ChangeImageIndex(ImageConstants.DisconnectedServer);
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00002EFA File Offset: 0x000010FA
		protected override void InitSettings()
		{
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x000056A6 File Offset: 0x000038A6
		public override Server ServerNode
		{
			get
			{
				return this._server;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060005A6 RID: 1446 RVA: 0x000056AE File Offset: 0x000038AE
		public override FileGroup FileGroup
		{
			get
			{
				return this._server.FileGroup;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x000056BB File Offset: 0x000038BB
		public override bool IsClientDocked
		{
			get
			{
				return this._server.IsClientDocked;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x000056C8 File Offset: 0x000038C8
		public override bool IsClientUndocked
		{
			get
			{
				return this._server.IsClientUndocked;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x000056D5 File Offset: 0x000038D5
		public override bool IsClientFullScreen
		{
			get
			{
				return this._server.IsClientFullScreen;
			}
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x000056E2 File Offset: 0x000038E2
		public override string ToString()
		{
			return string.Format("{0}: {1}", base.GetType().Name, base.Text);
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x000056FF File Offset: 0x000038FF
		internal override void Show()
		{
			this._server.Show();
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x0000570C File Offset: 0x0000390C
		internal override void Hide()
		{
			this._server.Hide();
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00005719 File Offset: 0x00003919
		public override void Connect()
		{
			this._server.Connect();
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00005726 File Offset: 0x00003926
		public override void ConnectAs(LogonCredentials logonSettings, ConnectionSettings connectionsettings)
		{
			this._server.ConnectAs(logonSettings, connectionsettings);
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00005735 File Offset: 0x00003935
		public override void Reconnect()
		{
			this._server.Reconnect();
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00005742 File Offset: 0x00003942
		public override void Disconnect()
		{
			this._server.Disconnect();
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x0000574F File Offset: 0x0000394F
		public override void LogOff()
		{
			this._server.LogOff();
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x0000575C File Offset: 0x0000395C
		public override void DoPropertiesDialog(Form parentForm, string activeTabName)
		{
			this._server.DoPropertiesDialog(parentForm, activeTabName);
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00004460 File Offset: 0x00002660
		public override bool CanRemove(bool popUI)
		{
			return false;
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x0000576B File Offset: 0x0000396B
		public override bool IsConnected
		{
			get
			{
				return this._server.IsConnected;
			}
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x0001A538 File Offset: 0x00018738
		public override bool CanDropOnTarget(RdcTreeNode targetNode)
		{
			GroupBase groupBase = (targetNode as GroupBase) ?? (targetNode.Parent as GroupBase);
			DragDropEffects dragDropEffects = groupBase.DropBehavior();
			if (dragDropEffects != DragDropEffects.Copy)
			{
				return dragDropEffects == DragDropEffects.Link && groupBase.CanDropServers() && this.AllowEdit(false);
			}
			return groupBase.CanDropServers();
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00005778 File Offset: 0x00003978
		public override void CollectNodesToInvalidate(bool recurseChildren, HashSet<RdcTreeNode> set)
		{
			set.Add(this);
			set.Add(base.Parent as RdcTreeNode);
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x0000358A File Offset: 0x0000178A
		internal override void WriteXml(XmlTextWriter tw)
		{
			throw new NotImplementedException();
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060005B8 RID: 1464 RVA: 0x00005794 File Offset: 0x00003994
		public override ServerSettings Properties
		{
			get
			{
				return this._server.Properties;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x000057A1 File Offset: 0x000039A1
		public override CommonDisplaySettings DisplaySettings
		{
			get
			{
				return this._server.DisplaySettings;
			}
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x000057AE File Offset: 0x000039AE
		public sealed override void ChangeImageIndex(ImageConstants index)
		{
			base.ImageIndex = this._server.ImageIndex;
			base.SelectedImageIndex = this._server.SelectedImageIndex;
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x000057D2 File Offset: 0x000039D2
		public override string RemoveTypeDescription
		{
			get
			{
				return "server reference";
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060005BC RID: 1468 RVA: 0x000057D9 File Offset: 0x000039D9
		// (set) Token: 0x060005BD RID: 1469 RVA: 0x000057E6 File Offset: 0x000039E6
		public override ServerBase.DisplayStates DisplayState
		{
			get
			{
				return this._server.DisplayState;
			}
			set
			{
				this._server.DisplayState = value;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060005BE RID: 1470 RVA: 0x000057F4 File Offset: 0x000039F4
		// (set) Token: 0x060005BF RID: 1471 RVA: 0x00005801 File Offset: 0x00003A01
		public override Size Size
		{
			get
			{
				return this._server.Size;
			}
			set
			{
				this._server.Size = value;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x0000580F File Offset: 0x00003A0F
		// (set) Token: 0x060005C1 RID: 1473 RVA: 0x0000581C File Offset: 0x00003A1C
		public override Point Location
		{
			get
			{
				return this._server.Location;
			}
			set
			{
				this._server.Location = value;
			}
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x0000582A File Offset: 0x00003A2A
		internal override void Focus()
		{
			this._server.Focus();
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00005837 File Offset: 0x00003A37
		internal override void FocusConnectedClient()
		{
			this._server.FocusConnectedClient();
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00005844 File Offset: 0x00003A44
		internal virtual void OnRemoveServer()
		{
			ServerTree.Instance.RemoveNode(this);
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00005851 File Offset: 0x00003A51
		public override void OnRemoving()
		{
			this._server.RemoveServerRef(this);
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x0000585F File Offset: 0x00003A5F
		internal override void GoFullScreen()
		{
			this._server.GoFullScreen();
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x0000586C File Offset: 0x00003A6C
		internal override void LeaveFullScreen()
		{
			this._server.LeaveFullScreen();
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00005879 File Offset: 0x00003A79
		internal override void Undock()
		{
			this._server.Undock();
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00005886 File Offset: 0x00003A86
		internal override void Dock()
		{
			this._server.Dock();
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00005893 File Offset: 0x00003A93
		internal override void ScreenCapture()
		{
			this._server.ScreenCapture();
		}

		// Token: 0x04000484 RID: 1156
		private Server _server;
	}
}
