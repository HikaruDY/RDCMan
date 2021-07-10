using System;
using System.Runtime.InteropServices;

namespace Win32
{
	// Token: 0x02000005 RID: 5
	public class Structs
	{
		// Token: 0x02000006 RID: 6
		[StructLayout(LayoutKind.Sequential, Pack = 8)]
		public struct HDITEM
		{
			// Token: 0x04000029 RID: 41
			public uint mask;

			// Token: 0x0400002A RID: 42
			public int cxy;

			// Token: 0x0400002B RID: 43
			public IntPtr pszText;

			// Token: 0x0400002C RID: 44
			public IntPtr hbm;

			// Token: 0x0400002D RID: 45
			public int cchTextMax;

			// Token: 0x0400002E RID: 46
			public int fmt;

			// Token: 0x0400002F RID: 47
			public int lParam;

			// Token: 0x04000030 RID: 48
			public int iImage;

			// Token: 0x04000031 RID: 49
			public int iOrder;

			// Token: 0x04000032 RID: 50
			public uint type;

			// Token: 0x04000033 RID: 51
			public unsafe void* pvFilter;

			// Token: 0x04000034 RID: 52
			public uint state;
		}

		// Token: 0x02000007 RID: 7
		[StructLayout(LayoutKind.Sequential, Pack = 8)]
		public struct NMHDR
		{
			// Token: 0x04000035 RID: 53
			public IntPtr hwndFrom;

			// Token: 0x04000036 RID: 54
			public IntPtr idFrom;

			// Token: 0x04000037 RID: 55
			public uint code;
		}

		// Token: 0x02000008 RID: 8
		[StructLayout(LayoutKind.Sequential, Pack = 8)]
		public struct NMHEADER
		{
			// Token: 0x04000038 RID: 56
			public Structs.NMHDR hdr;

			// Token: 0x04000039 RID: 57
			public int iItem;

			// Token: 0x0400003A RID: 58
			public int iButton;

			// Token: 0x0400003B RID: 59
			private IntPtr pitem;
		}

		// Token: 0x02000009 RID: 9
		public struct RECT
		{
			// Token: 0x0400003C RID: 60
			public int left;

			// Token: 0x0400003D RID: 61
			public int top;

			// Token: 0x0400003E RID: 62
			public int right;

			// Token: 0x0400003F RID: 63
			public int bottom;
		}

		// Token: 0x0200000A RID: 10
		public struct TRACKMOUSEEVENT
		{
			// Token: 0x06000006 RID: 6 RVA: 0x0000208C File Offset: 0x0000028C
			public TRACKMOUSEEVENT(uint dwFlags, IntPtr hWnd, uint dwHoverTime)
			{
				this.cbSize = Marshal.SizeOf(typeof(Structs.TRACKMOUSEEVENT));
				this.dwFlags = dwFlags;
				this.hWnd = hWnd;
				this.dwHoverTime = dwHoverTime;
			}

			// Token: 0x04000040 RID: 64
			public int cbSize;

			// Token: 0x04000041 RID: 65
			public uint dwFlags;

			// Token: 0x04000042 RID: 66
			public IntPtr hWnd;

			// Token: 0x04000043 RID: 67
			public uint dwHoverTime;
		}
	}
}
