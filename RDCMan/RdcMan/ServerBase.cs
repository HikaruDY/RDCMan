using System;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000087 RID: 135
	public abstract class ServerBase : RdcTreeNode
	{
		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x0001779C File Offset: 0x0001599C
		public string ServerName
		{
			get
			{
				return this.ServerNode.Properties.ServerName.Value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x000177C4 File Offset: 0x000159C4
		public string DisplayName
		{
			get
			{
				return this.ServerNode.Properties.DisplayName.Value;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600046E RID: 1134
		public abstract string RemoveTypeDescription { get; }

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600046F RID: 1135
		public abstract bool IsConnected { get; }

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000470 RID: 1136
		public abstract bool IsClientDocked { get; }

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000471 RID: 1137
		public abstract bool IsClientUndocked { get; }

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000472 RID: 1138
		public abstract bool IsClientFullScreen { get; }

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000473 RID: 1139
		public new abstract ServerSettings Properties { get; }

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000474 RID: 1140
		public new abstract CommonDisplaySettings DisplaySettings { get; }

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x000177EC File Offset: 0x000159EC
		public bool IsThumbnail
		{
			get
			{
				return this.DisplayState == ServerBase.DisplayStates.Thumbnail;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000476 RID: 1142
		// (set) Token: 0x06000477 RID: 1143
		public abstract ServerBase.DisplayStates DisplayState { get; set; }

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000478 RID: 1144
		// (set) Token: 0x06000479 RID: 1145
		public abstract Size Size { get; set; }

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600047A RID: 1146
		// (set) Token: 0x0600047B RID: 1147
		public abstract Point Location { get; set; }

		// Token: 0x0600047C RID: 1148 RVA: 0x000177F8 File Offset: 0x000159F8
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

		// Token: 0x0600047D RID: 1149
		internal abstract void Focus();

		// Token: 0x0600047E RID: 1150
		internal abstract void FocusConnectedClient();

		// Token: 0x0600047F RID: 1151
		internal abstract void ScreenCapture();

		// Token: 0x06000480 RID: 1152
		internal abstract void GoFullScreen();

		// Token: 0x06000481 RID: 1153
		internal abstract void LeaveFullScreen();

		// Token: 0x06000482 RID: 1154
		internal abstract void Undock();

		// Token: 0x06000483 RID: 1155
		internal abstract void Dock();

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000484 RID: 1156
		public abstract Server ServerNode { get; }

		// Token: 0x02000275 RID: 629
		public enum DisplayStates
		{
			// Token: 0x04000ABD RID: 2749
			Invalid,
			// Token: 0x04000ABE RID: 2750
			Normal,
			// Token: 0x04000ABF RID: 2751
			Thumbnail
		}
	}
}
