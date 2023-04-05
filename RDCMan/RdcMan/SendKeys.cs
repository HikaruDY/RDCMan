using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MSTSCLib;
using Win32;

namespace RdcMan
{
	// Token: 0x020000B7 RID: 183
	internal class SendKeys
	{
		// Token: 0x06000646 RID: 1606 RVA: 0x0001E58C File Offset: 0x0001C78C
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

		// Token: 0x06000647 RID: 1607 RVA: 0x0001E6C0 File Offset: 0x0001C8C0
		private static bool IsModifier(Keys key)
		{
			return key - Keys.ShiftKey <= 2 || key - Keys.LWin <= 1 || key - Keys.LControlKey <= 1;
		}

		// Token: 0x020002A1 RID: 673
		private struct SendKeysData
		{
			// Token: 0x04000B28 RID: 2856
			public const int MaxKeys = 20;

			// Token: 0x04000B29 RID: 2857
			[FixedBuffer(typeof(short), 20)]
			public SendKeys.SendKeysData.<keyUp>e__FixedBuffer keyUp;

			// Token: 0x04000B2A RID: 2858
			[FixedBuffer(typeof(int), 20)]
			public SendKeys.SendKeysData.<keyData>e__FixedBuffer keyData;

			// Token: 0x020002BF RID: 703
			[CompilerGenerated]
			[UnsafeValueType]
			[StructLayout(LayoutKind.Sequential, Size = 80)]
			public struct <keyData>e__FixedBuffer
			{
				// Token: 0x04000B66 RID: 2918
				public int FixedElementField;
			}

			// Token: 0x020002C0 RID: 704
			[CompilerGenerated]
			[UnsafeValueType]
			[StructLayout(LayoutKind.Sequential, Size = 40)]
			public struct <keyUp>e__FixedBuffer
			{
				// Token: 0x04000B67 RID: 2919
				public short FixedElementField;
			}
		}
	}
}
