using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	public abstract class ServerRef : ServerBase
	{
		protected ServerRef(Server server)
		{
			this._server = server;
			this._server.AddServerRef(this);
			base.Text = server.Text;
			this.ChangeImageIndex(ImageConstants.DisconnectedServer);
		}

		protected override void InitSettings()
		{
		}

		public override Server ServerNode
		{
			get
			{
				return this._server;
			}
		}

		public override FileGroup FileGroup
		{
			get
			{
				return this._server.FileGroup;
			}
		}

		public override bool IsClientDocked
		{
			get
			{
				return this._server.IsClientDocked;
			}
		}

		public override bool IsClientUndocked
		{
			get
			{
				return this._server.IsClientUndocked;
			}
		}

		public override bool IsClientFullScreen
		{
			get
			{
				return this._server.IsClientFullScreen;
			}
		}

		public override string ToString()
		{
			return string.Format("{0}: {1}", base.GetType().Name, base.Text);
		}

		internal override void Show()
		{
			this._server.Show();
		}

		internal override void Hide()
		{
			this._server.Hide();
		}

		public override void Connect()
		{
			this._server.Connect();
		}

		public override void ConnectAs(LogonCredentials logonSettings, ConnectionSettings connectionsettings)
		{
			this._server.ConnectAs(logonSettings, connectionsettings);
		}

		public override void Reconnect()
		{
			this._server.Reconnect();
		}

		public override void Disconnect()
		{
			this._server.Disconnect();
		}

		public override void LogOff()
		{
			this._server.LogOff();
		}

		public override void DoPropertiesDialog(Form parentForm, string activeTabName)
		{
			this._server.DoPropertiesDialog(parentForm, activeTabName);
		}

		public override bool CanRemove(bool popUI)
		{
			return false;
		}

		public override bool IsConnected
		{
			get
			{
				return this._server.IsConnected;
			}
		}

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

		public override void CollectNodesToInvalidate(bool recurseChildren, HashSet<RdcTreeNode> set)
		{
			set.Add(this);
			set.Add(base.Parent as RdcTreeNode);
		}

		internal override void WriteXml(XmlTextWriter tw)
		{
			throw new NotImplementedException();
		}

		public override ServerSettings Properties
		{
			get
			{
				return this._server.Properties;
			}
		}

		public override CommonDisplaySettings DisplaySettings
		{
			get
			{
				return this._server.DisplaySettings;
			}
		}

		public sealed override void ChangeImageIndex(ImageConstants index)
		{
			base.ImageIndex = this._server.ImageIndex;
			base.SelectedImageIndex = this._server.SelectedImageIndex;
		}

		public override string RemoveTypeDescription
		{
			get
			{
				return "server reference";
			}
		}

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

		internal override void Focus()
		{
			this._server.Focus();
		}

		internal override void FocusConnectedClient()
		{
			this._server.FocusConnectedClient();
		}

		internal virtual void OnRemoveServer()
		{
			ServerTree.Instance.RemoveNode(this);
		}

		public override void OnRemoving()
		{
			this._server.RemoveServerRef(this);
		}

		internal override void GoFullScreen()
		{
			this._server.GoFullScreen();
		}

		internal override void LeaveFullScreen()
		{
			this._server.LeaveFullScreen();
		}

		internal override void Undock()
		{
			this._server.Undock();
		}

		internal override void Dock()
		{
			this._server.Dock();
		}

		internal override void ScreenCapture()
		{
			this._server.ScreenCapture();
		}

		private Server _server;
	}
}
