using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MSTSCLib;
using Win32;

namespace RdcMan
{
	// Token: 0x0200013D RID: 317
	internal class SendKeys
	{
		// Token: 0x060007BC RID: 1980 RVA: 0x0001EFFC File Offset: 0x0001D1FC
		public unsafe static void Send(Keys[] keyCodes, ServerBase serverBase)
		{
			Server serverNode = serverBase.ServerNode;
			RdpClient client = serverNode.Client;
			IMsRdpClientNonScriptable msRdpClientNonScriptable = (IMsRdpClientNonScriptable)client.GetOcx();
			int num = keyCodes.Length;
			try
			{
				SendKeys.SendKeysData sendKeysData;
				bool* ptr = (bool*)(&sendKeysData.keyUp.FixedElementField);
				int* ptr2 = &sendKeysData.keyData.FixedElementField;
				int num2 = 0;
				int num3 = 0;
				while (num3 < num && num3 < 10)
				{
					int num4 = (int)Util.MapVirtualKey((uint)keyCodes[num3], 0u);
					*(ref sendKeysData.keyData.FixedElementField + (IntPtr)num2 * 4) = num4;
					*(ref sendKeysData.keyUp.FixedElementField + (IntPtr)(num2++) * 2) = 0;
					if (!SendKeys.IsModifier(keyCodes[num3]))
					{
						for (int i = num2 - 1; i >= 0; i--)
						{
							*(ref sendKeysData.keyData.FixedElementField + (IntPtr)num2 * 4) = *(ref sendKeysData.keyData.FixedElementField + (IntPtr)i * 4);
							*(ref sendKeysData.keyUp.FixedElementField + (IntPtr)(num2++) * 2) = 1;
						}
						msRdpClientNonScriptable.SendKeys(num2, ref *ptr, ref *ptr2);
						num2 = 0;
					}
					num3++;
				}
			}
			catch
			{
			}
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00006E3E File Offset: 0x0000503E
		private static bool IsModifier(Keys key)
		{
			return key - Keys.ShiftKey <= 2 || key - Keys.LWin <= 1 || key - Keys.LControlKey <= 1;
		}

		// Token: 0x0200013E RID: 318
		private struct SendKeysData
		{
			// Token: 0x04000586 RID: 1414
			public const int MaxKeys = 20;

			// Token: 0x04000587 RID: 1415
			[FixedBuffer(typeof(short), 20)]
			public SendKeys.SendKeysData.<keyUp>e__FixedBuffer keyUp;

			// Token: 0x04000588 RID: 1416
			[FixedBuffer(typeof(int), 20)]
			public SendKeys.SendKeysData.<keyData>e__FixedBuffer keyData;

			// Token: 0x0200013F RID: 319
			[CompilerGenerated]
			[UnsafeValueType]
			[StructLayout(LayoutKind.Sequential, Size = 40)]
			public struct <keyUp>e__FixedBuffer
			{
				// Token: 0x04000589 RID: 1417
				public short FixedElementField;
			}

			// Token: 0x02000140 RID: 320
			[CompilerGenerated]
			[UnsafeValueType]
			[StructLayout(LayoutKind.Sequential, Size = 80)]
			public struct <keyData>e__FixedBuffer
			{
				// Token: 0x0400058A RID: 1418
				public int FixedElementField;
			}
		}
	}
}
