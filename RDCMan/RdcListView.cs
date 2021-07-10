using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Win32;

namespace RdcMan
{
	// Token: 0x0200003B RID: 59
	public class RdcListView : ListView
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060000B7 RID: 183 RVA: 0x0000A984 File Offset: 0x00008B84
		// (remove) Token: 0x060000B8 RID: 184 RVA: 0x0000A9BC File Offset: 0x00008BBC
		public event HeaderColumnClickEventHandler HeaderCheckBoxClick;

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x000025AC File Offset: 0x000007AC
		// (set) Token: 0x060000BA RID: 186 RVA: 0x000025B3 File Offset: 0x000007B3
		public static bool SupportsHeaderCheckBoxes { get; private set; } //= Kernel.MajorVersion >= 6u;

		// Token: 0x060000BC RID: 188 RVA: 0x0000A9F4 File Offset: 0x00008BF4
		public unsafe void SetColumnHeaderToCheckBox(int index)
		{
			if (!RdcListView.SupportsHeaderCheckBoxes)
			{
				throw new InvalidOperationException("Header check boxes are not supported on this operating system version");
			}
			if (base.Parent == null)
			{
				throw new InvalidOperationException("Control must have a parent before setting header style");
			}
			if (index < 0 || index >= base.Columns.Count)
			{
				throw new IndexOutOfRangeException("Column index out of range");
			}
			if (!string.IsNullOrEmpty(base.Columns[index].Text))
			{
				throw new InvalidOperationException("Column must have no text");
			}
			IntPtr headerHandle = this.HeaderHandle;
			int windowLong = User.GetWindowLong(headerHandle, -16);
			User.SetWindowLong(headerHandle, -16, windowLong | 1024);
			Structs.HDITEM hditem;
			hditem.mask = 4u;
			Structs.HDITEM* value = &hditem;
			User.SendMessage(headerHandle, 4619u, (IntPtr)index, (IntPtr)((void*)value));
			hditem.fmt |= 320;
			User.SendMessage(headerHandle, 4620u, (IntPtr)index, (IntPtr)((void*)value));
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000AAD4 File Offset: 0x00008CD4
		public unsafe void SetColumnHeaderChecked(int index, bool isChecked)
		{
			IntPtr headerHandle = this.HeaderHandle;
			Structs.HDITEM hditem;
			hditem.mask = 4u;
			Structs.HDITEM* value = &hditem;
			User.SendMessage(headerHandle, 4619u, (IntPtr)index, (IntPtr)((void*)value));
			if (isChecked)
			{
				hditem.fmt |= 128;
			}
			else
			{
				hditem.fmt &= -129;
			}
			User.SendMessage(headerHandle, 4620u, (IntPtr)index, (IntPtr)((void*)value));
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000AB4C File Offset: 0x00008D4C
		protected unsafe override void WndProc(ref Message m)
		{
			if ((long)m.Msg == 78L && this.HeaderCheckBoxClick != null)
			{
				Structs.NMHEADER nmheader = (Structs.NMHEADER)Marshal.PtrToStructure(m.LParam, typeof(Structs.NMHEADER));
				if (nmheader.hdr.code == 4294966980u)
				{
					Structs.HDITEM hditem;
					hditem.mask = 4u;
					Structs.HDITEM* value = &hditem;
					User.SendMessage(nmheader.hdr.hwndFrom, 4619u, (IntPtr)nmheader.iItem, (IntPtr)((void*)value));
					hditem.fmt ^= 128;
					User.SendMessage(nmheader.hdr.hwndFrom, 4620u, (IntPtr)nmheader.iItem, (IntPtr)((void*)value));
					bool isChecked = (hditem.fmt & 128) != 0;
					this.HeaderCheckBoxClick(this, new HeaderColumnClickEventArgs(nmheader.iItem, isChecked));
					return;
				}
			}
			base.WndProc(ref m);
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000BF RID: 191 RVA: 0x000025CD File Offset: 0x000007CD
		private IntPtr HeaderHandle
		{
			get
			{
				return User.SendMessage(base.Handle, 4127u, (IntPtr)0, (IntPtr)0);
			}
		}
	}
}
