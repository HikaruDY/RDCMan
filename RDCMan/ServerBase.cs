using System;
using System.Drawing;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x020000E3 RID: 227
	public abstract class ServerBase : RdcTreeNode
	{
		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x00005637 File Offset: 0x00003837
		public string ServerName
		{
			get
			{
				return this.ServerNode.Properties.ServerName.Value;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x0000564E File Offset: 0x0000384E
		public string DisplayName
		{
			get
			{
				return this.ServerNode.Properties.DisplayName.Value;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600058B RID: 1419
		public abstract string RemoveTypeDescription { get; }

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600058C RID: 1420
		public abstract bool IsConnected { get; }

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600058D RID: 1421
		public abstract bool IsClientDocked { get; }

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600058E RID: 1422
		public abstract bool IsClientUndocked { get; }

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600058F RID: 1423
		public abstract bool IsClientFullScreen { get; }

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000590 RID: 1424
		public new abstract ServerSettings Properties { get; }

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000591 RID: 1425
		public new abstract CommonDisplaySettings DisplaySettings { get; }

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x00005665 File Offset: 0x00003865
		public bool IsThumbnail
		{
			get
			{
				return this.DisplayState == ServerBase.DisplayStates.Thumbnail;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000593 RID: 1427
		// (set) Token: 0x06000594 RID: 1428
		public abstract ServerBase.DisplayStates DisplayState { get; set; }

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000595 RID: 1429
		// (set) Token: 0x06000596 RID: 1430
		public abstract Size Size { get; set; }

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000597 RID: 1431
		// (set) Token: 0x06000598 RID: 1432
		public abstract Point Location { get; set; }

		// Token: 0x06000599 RID: 1433 RVA: 0x0001A4D4 File Offset: 0x000186D4
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

		// Token: 0x0600059A RID: 1434
		internal abstract void Focus();

		// Token: 0x0600059B RID: 1435
		internal abstract void FocusConnectedClient();

		// Token: 0x0600059C RID: 1436
		internal abstract void ScreenCapture();

		// Token: 0x0600059D RID: 1437
		internal abstract void GoFullScreen();

		// Token: 0x0600059E RID: 1438
		internal abstract void LeaveFullScreen();

		// Token: 0x0600059F RID: 1439
		internal abstract void Undock();

		// Token: 0x060005A0 RID: 1440
		internal abstract void Dock();

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060005A1 RID: 1441
		public abstract Server ServerNode { get; }

		// Token: 0x020000E4 RID: 228
		public enum DisplayStates
		{
			// Token: 0x04000481 RID: 1153
			Invalid,
			// Token: 0x04000482 RID: 1154
			Normal,
			// Token: 0x04000483 RID: 1155
			Thumbnail
		}
	}
}
