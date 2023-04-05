using System;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	public abstract class ServerBase : RdcTreeNode
	{
		public string ServerName
		{
			get
			{
				return this.ServerNode.Properties.ServerName.Value;
			}
		}

		public string DisplayName
		{
			get
			{
				return this.ServerNode.Properties.DisplayName.Value;
			}
		}

		public abstract string RemoveTypeDescription { get; }

		public abstract bool IsConnected { get; }

		public abstract bool IsClientDocked { get; }

		public abstract bool IsClientUndocked { get; }

		public abstract bool IsClientFullScreen { get; }

		public new abstract ServerSettings Properties { get; }

		public new abstract CommonDisplaySettings DisplaySettings { get; }

		public bool IsThumbnail
		{
			get
			{
				return this.DisplayState == ServerBase.DisplayStates.Thumbnail;
			}
		}

		public abstract ServerBase.DisplayStates DisplayState { get; set; }

		public abstract Size Size { get; set; }

		public abstract Point Location { get; set; }

		public override bool ConfirmRemove(bool askUser)
		{
			if (!this.CanRemove(true))
			{
				return false;
			}
			if (askUser)
			{
				string text = "Remove '{0}' {1} from '{2}'?".InvariantFormat(new object[]
				{
					base.Text,
					this.RemoveTypeDescription,
					base.Parent.Text
				});
				DialogResult dialogResult = FormTools.YesNoDialog(this.ParentForm, text, MessageBoxDefaultButton.Button1);
				if (dialogResult != DialogResult.Yes)
				{
					return false;
				}
			}
			return true;
		}

		internal abstract void Focus();

		internal abstract void FocusConnectedClient();

		internal abstract void ScreenCapture();

		internal abstract void GoFullScreen();

		internal abstract void LeaveFullScreen();

		internal abstract void Undock();

		internal abstract void Dock();

		public abstract Server ServerNode { get; }

		public enum DisplayStates
		{
			Invalid,
			Normal,
			Thumbnail
		}
	}
}
