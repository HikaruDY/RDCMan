using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Win32;

namespace RdcMan
{
	public class RdcListView : ListView
	{
		public event HeaderColumnClickEventHandler HeaderCheckBoxClick;

		public static bool SupportsHeaderCheckBoxes { get; private set; } = Kernel.MajorVersion >= 6U;

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

		private IntPtr HeaderHandle
		{
			get
			{
				return User.SendMessage(base.Handle, 4127U, (IntPtr)0, (IntPtr)0);
			}
		}
	}
}
