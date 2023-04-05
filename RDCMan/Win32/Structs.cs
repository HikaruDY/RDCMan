using System;
using System.Runtime.InteropServices;

namespace Win32
{
	// Token: 0x02000005 RID: 5
	public class Structs
	{
		// Token: 0x0200021A RID: 538
		[StructLayout(LayoutKind.Sequential, Pack = 8)]
		public struct HDITEM
		{
			// Token: 0x0400081D RID: 2077
			public uint mask;

			// Token: 0x0400081E RID: 2078
			public int cxy;

			// Token: 0x0400081F RID: 2079
			public IntPtr pszText;

			// Token: 0x04000820 RID: 2080
			public IntPtr hbm;

			// Token: 0x04000821 RID: 2081
			public int cchTextMax;

			// Token: 0x04000822 RID: 2082
			public int fmt;

			// Token: 0x04000823 RID: 2083
			public int lParam;

			// Token: 0x04000824 RID: 2084
			public int iImage;

			// Token: 0x04000825 RID: 2085
			public int iOrder;

			// Token: 0x04000826 RID: 2086
			public uint type;

			// Token: 0x04000827 RID: 2087
			public unsafe void* pvFilter;

			// Token: 0x04000828 RID: 2088
			public uint state;
		}

		// Token: 0x0200021B RID: 539
		[StructLayout(LayoutKind.Sequential, Pack = 8)]
		public struct NMHDR
		{
			// Token: 0x04000829 RID: 2089
			public IntPtr hwndFrom;

			// Token: 0x0400082A RID: 2090
			public IntPtr idFrom;

			// Token: 0x0400082B RID: 2091
			public uint code;
		}

		// Token: 0x0200021C RID: 540
		[StructLayout(LayoutKind.Sequential, Pack = 8)]
		public struct NMHEADER
		{
			// Token: 0x0400082C RID: 2092
			public Structs.NMHDR hdr;

			// Token: 0x0400082D RID: 2093
			public int iItem;

			// Token: 0x0400082E RID: 2094
			public int iButton;

			// Token: 0x0400082F RID: 2095
			private IntPtr pitem;
		}

		// Token: 0x0200021D RID: 541
		public struct RECT
		{
			// Token: 0x04000830 RID: 2096
			public int left;

			// Token: 0x04000831 RID: 2097
			public int top;

			// Token: 0x04000832 RID: 2098
			public int right;

			// Token: 0x04000833 RID: 2099
			public int bottom;
		}

		// Token: 0x0200021E RID: 542
		public struct TRACKMOUSEEVENT
		{
			// Token: 0x060055AA RID: 21930 RVA: 0x0005C980 File Offset: 0x0005AB80
			public TRACKMOUSEEVENT(uint dwFlags, IntPtr hWnd, uint dwHoverTime)
			{
				this.cbSize = Marshal.SizeOf(typeof(Structs.TRACKMOUSEEVENT));
				this.dwFlags = dwFlags;
				this.hWnd = hWnd;
				this.dwHoverTime = dwHoverTime;
			}

			// Token: 0x04000834 RID: 2100
			public int cbSize;

			// Token: 0x04000835 RID: 2101
			public uint dwFlags;

			// Token: 0x04000836 RID: 2102
			public IntPtr hWnd;

			// Token: 0x04000837 RID: 2103
			public uint dwHoverTime;
		}
	}
}
