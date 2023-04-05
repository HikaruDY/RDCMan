using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	// Token: 0x02000088 RID: 136
	public abstract class ServerRef : ServerBase
	{
		// Token: 0x06000486 RID: 1158 RVA: 0x00017870 File Offset: 0x00015A70
		protected ServerRef(Server server)
		{
			this._server = server;
			this._server.AddServerRef(this);
			base.Text = server.Text;
			this.ChangeImageIndex(ImageConstants.DisconnectedServer);
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x000178B0 File Offset: 0x00015AB0
		protected override void InitSettings()
		{
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000488 RID: 1160 RVA: 0x000178B4 File Offset: 0x00015AB4
		public override Server ServerNode
		{
			get
			{
				return this._server;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x000178BC File Offset: 0x00015ABC
		public override FileGroup FileGroup
		{
			get
			{
				return this._server.FileGroup;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600048A RID: 1162 RVA: 0x000178CC File Offset: 0x00015ACC
		public override bool IsClientDocked
		{
			get
			{
				return this._server.IsClientDocked;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x000178DC File Offset: 0x00015ADC
		public override bool IsClientUndocked
		{
			get
			{
				return this._server.IsClientUndocked;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x000178EC File Offset: 0x00015AEC
		public override bool IsClientFullScreen
		{
			get
			{
				return this._server.IsClientFullScreen;
			}
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x000178FC File Offset: 0x00015AFC
		public override string ToString()
		{
			return string.Format("{0}: {1}", base.GetType().Name, base.Text);
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00017928 File Offset: 0x00015B28
		internal override void Show()
		{
			this._server.Show();
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00017938 File Offset: 0x00015B38
		internal override void Hide()
		{
			this._server.Hide();
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00017948 File Offset: 0x00015B48
		public override void Connect()
		{
			this._server.Connect();
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00017958 File Offset: 0x00015B58
		public override void ConnectAs(LogonCredentials logonSettings, ConnectionSettings connectionsettings)
		{
			this._server.ConnectAs(logonSettings, connectionsettings);
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00017968 File Offset: 0x00015B68
		public override void Reconnect()
		{
			this._server.Reconnect();
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00017978 File Offset: 0x00015B78
		public override void Disconnect()
		{
			this._server.Disconnect();
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00017988 File Offset: 0x00015B88
		public override void LogOff()
		{
			this._server.LogOff();
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00017998 File Offset: 0x00015B98
		public override void DoPropertiesDialog(Form parentForm, string activeTabName)
		{
			this._server.DoPropertiesDialog(parentForm, activeTabName);
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x000179A8 File Offset: 0x00015BA8
		public override bool CanRemove(bool popUI)
		{
			return false;
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x000179AC File Offset: 0x00015BAC
		public override bool IsConnected
		{
			get
			{
				return this._server.IsConnected;
			}
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x000179BC File Offset: 0x00015BBC
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

		// Token: 0x06000499 RID: 1177 RVA: 0x00017A20 File Offset: 0x00015C20
		public override void CollectNodesToInvalidate(bool recurseChildren, HashSet<RdcTreeNode> set)
		{
			set.Add(this);
			set.Add(base.Parent as RdcTreeNode);
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00017A3C File Offset: 0x00015C3C
		internal override void WriteXml(XmlTextWriter tw)
		{
			throw new NotImplementedException();
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x00017A44 File Offset: 0x00015C44
		public override ServerSettings Properties
		{
			get
			{
				return this._server.Properties;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x00017A54 File Offset: 0x00015C54
		public override CommonDisplaySettings DisplaySettings
		{
			get
			{
				return this._server.DisplaySettings;
			}
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00017A64 File Offset: 0x00015C64
		public sealed override void ChangeImageIndex(ImageConstants index)
		{
			base.ImageIndex = this._server.ImageIndex;
			base.SelectedImageIndex = this._server.SelectedImageIndex;
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x00017A98 File Offset: 0x00015C98
		public override string RemoveTypeDescription
		{
			get
			{
				return "server reference";
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x00017AA0 File Offset: 0x00015CA0
		// (set) Token: 0x060004A0 RID: 1184 RVA: 0x00017AB0 File Offset: 0x00015CB0
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

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x00017AC0 File Offset: 0x00015CC0
		// (set) Token: 0x060004A2 RID: 1186 RVA: 0x00017AD0 File Offset: 0x00015CD0
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

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x00017AE0 File Offset: 0x00015CE0
		// (set) Token: 0x060004A4 RID: 1188 RVA: 0x00017AF0 File Offset: 0x00015CF0
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

		// Token: 0x060004A5 RID: 1189 RVA: 0x00017B00 File Offset: 0x00015D00
		internal override void Focus()
		{
			this._server.Focus();
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00017B10 File Offset: 0x00015D10
		internal override void FocusConnectedClient()
		{
			this._server.FocusConnectedClient();
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00017B20 File Offset: 0x00015D20
		internal virtual void OnRemoveServer()
		{
			ServerTree.Instance.RemoveNode(this);
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00017B30 File Offset: 0x00015D30
		public override void OnRemoving()
		{
			this._server.RemoveServerRef(this);
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00017B40 File Offset: 0x00015D40
		internal override void GoFullScreen()
		{
			this._server.GoFullScreen();
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00017B50 File Offset: 0x00015D50
		internal override void LeaveFullScreen()
		{
			this._server.LeaveFullScreen();
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00017B60 File Offset: 0x00015D60
		internal override void Undock()
		{
			this._server.Undock();
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00017B70 File Offset: 0x00015D70
		internal override void Dock()
		{
			this._server.Dock();
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00017B80 File Offset: 0x00015D80
		internal override void ScreenCapture()
		{
			this._server.ScreenCapture();
		}

		// Token: 0x040001E2 RID: 482
		private Server _server;
	}
}
