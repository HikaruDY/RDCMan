using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Win32;

namespace RdcMan
{
	// Token: 0x02000021 RID: 33
	public class RdcListView : ListView
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060000A9 RID: 169 RVA: 0x00004BF4 File Offset: 0x00002DF4
		// (remove) Token: 0x060000AA RID: 170 RVA: 0x00004C30 File Offset: 0x00002E30
		public event HeaderColumnClickEventHandler HeaderCheckBoxClick;

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00004C6C File Offset: 0x00002E6C
		// (set) Token: 0x060000AC RID: 172 RVA: 0x00004C74 File Offset: 0x00002E74
		public static bool SupportsHeaderCheckBoxes { get; private set; } = Kernel.MajorVersion >= 6U;

		// Token: 0x060000AE RID: 174 RVA: 0x00004C90 File Offset: 0x00002E90
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
			hditem.mask = 4U;
			Structs.HDITEM* value = &hditem;
			User.SendMessage(headerHandle, 4619U, (IntPtr)index, (IntPtr)((void*)value));
			hditem.fmt |= 320;
			User.SendMessage(headerHandle, 4620U, (IntPtr)index, (IntPtr)((void*)value));
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00004D84 File Offset: 0x00002F84
		public unsafe void SetColumnHeaderChecked(int index, bool isChecked)
		{
			IntPtr headerHandle = this.HeaderHandle;
			Structs.HDITEM hditem;
			hditem.mask = 4U;
			Structs.HDITEM* value = &hditem;
			User.SendMessage(headerHandle, 4619U, (IntPtr)index, (IntPtr)((void*)value));
			if (isChecked)
			{
				hditem.fmt |= 128;
			}
			else
			{
				hditem.fmt &= -129;
			}
			User.SendMessage(headerHandle, 4620U, (IntPtr)index, (IntPtr)((void*)value));
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00004E04 File Offset: 0x00003004
		protected unsafe override void WndProc(ref Message m)
		{
			if ((long)m.Msg == 78L && this.HeaderCheckBoxClick != null)
			{
				Structs.NMHEADER nmheader = (Structs.NMHEADER)Marshal.PtrToStructure(m.LParam, typeof(Structs.NMHEADER));
				if (nmheader.hdr.code == 4294966980U)
				{
					Structs.HDITEM hditem;
					hditem.mask = 4U;
					Structs.HDITEM* value = &hditem;
					User.SendMessage(nmheader.hdr.hwndFrom, 4619U, (IntPtr)nmheader.iItem, (IntPtr)((void*)value));
					hditem.fmt ^= 128;
					User.SendMessage(nmheader.hdr.hwndFrom, 4620U, (IntPtr)nmheader.iItem, (IntPtr)((void*)value));
					bool isChecked = (hditem.fmt & 128) != 0;
					this.HeaderCheckBoxClick(this, new HeaderColumnClickEventArgs(nmheader.iItem, isChecked));
					return;
				}
			}
			base.WndProc(ref m);
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00004EFC File Offset: 0x000030FC
		private IntPtr HeaderHandle
		{
			get
			{
				return User.SendMessage(base.Handle, 4127U, (IntPtr)0, (IntPtr)0);
			}
		}
	}
}
