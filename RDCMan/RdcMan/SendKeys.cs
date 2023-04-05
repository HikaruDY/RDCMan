using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MSTSCLib;
using Win32;

namespace RdcMan
{
	internal class SendKeys
	{
		public unsafe static void Send(Keys[] keyCodes, ServerBase serverBase)
		{
			Server serverNode = serverBase.ServerNode;
			RdpClient client = serverNode.Client;
			IMsRdpClientNonScriptable msRdpClientNonScriptable = (IMsRdpClientNonScriptable)client.GetOcx();
			int num = keyCodes.Length;
			try
			{
				SendKeys.SendKeysData sendKeysData;
				bool* pbArrayKeyUp = (bool*)(&sendKeysData.keyUp.FixedElementField);
				int* plKeyData = &sendKeysData.keyData.FixedElementField;
				int num2 = 0;
				int num3 = 0;
				while (num3 < num && num3 < 10)
				{
					int num4 = (int)Util.MapVirtualKey((uint)keyCodes[num3], 0U);
					*(ref sendKeysData.keyData.FixedElementField + (IntPtr)num2 * 4) = num4;
					*(ref sendKeysData.keyUp.FixedElementField + (IntPtr)(num2++) * 2) = 0;
					if (!SendKeys.IsModifier(keyCodes[num3]))
					{
						for (int i = num2 - 1; i >= 0; i--)
						{
							*(ref sendKeysData.keyData.FixedElementField + (IntPtr)num2 * 4) = *(ref sendKeysData.keyData.FixedElementField + (IntPtr)i * 4);
							*(ref sendKeysData.keyUp.FixedElementField + (IntPtr)(num2++) * 2) = 1;
						}
						msRdpClientNonScriptable.SendKeys(num2, ref *pbArrayKeyUp, ref *plKeyData);
						num2 = 0;
					}
					num3++;
				}
			}
			catch
			{
			}
		}

		private static bool IsModifier(Keys key)
		{
			return key - Keys.ShiftKey <= 2 || key - Keys.LWin <= 1 || key - Keys.LControlKey <= 1;
		}

		private struct SendKeysData
		{
			public const int MaxKeys = 20;

			[FixedBuffer(typeof(short), 20)]
			public SendKeys.SendKeysData.<keyUp>e__FixedBuffer keyUp;

			[FixedBuffer(typeof(int), 20)]
			public SendKeys.SendKeysData.<keyData>e__FixedBuffer keyData;

			[CompilerGenerated]
			[UnsafeValueType]
			[StructLayout(LayoutKind.Sequential, Size = 80)]
			public struct <keyData>e__FixedBuffer
			{
				public int FixedElementField;
			}

			[CompilerGenerated]
			[UnsafeValueType]
			[StructLayout(LayoutKind.Sequential, Size = 40)]
			public struct <keyUp>e__FixedBuffer
			{
				public short FixedElementField;
			}
		}
	}
}
