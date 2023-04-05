using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public class Kernel
	{
		public static uint MajorVersion { get; private set; }

		public static uint MinorVersion { get; private set; }

		public static uint Build { get; private set; }

		static Kernel()
		{
			uint version = Kernel.GetVersion();
			Kernel.MajorVersion = (version & 255U);
			Kernel.MinorVersion = (version & 65280U) >> 8;
			Kernel.Build = (version & 4294901760U) >> 16;
		}

		[DllImport("kernel32.dll")]
		public static extern int GetLastError();

		[DllImport("kernel32")]
		public static extern uint GetVersion();
	}
}
