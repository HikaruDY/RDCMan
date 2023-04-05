using System;
using System.Configuration;
using System.Drawing;

namespace RdcMan.Configuration
{
	// Token: 0x020000EA RID: 234
	public static class Current
	{
		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x000236A8 File Offset: 0x000218A8
		// (set) Token: 0x0600084E RID: 2126 RVA: 0x000236B0 File Offset: 0x000218B0
		public static RdcManSection RdcManSection { get; private set; }

		// Token: 0x0600084F RID: 2127 RVA: 0x000236B8 File Offset: 0x000218B8
		public static void Read()
		{
			Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			Current.RdcManSection = (configuration.GetSection("rdcman") as RdcManSection);
			if (Current.RdcManSection != null)
			{
				DisplaySizeElementCollection displaySizes = Current.RdcManSection.DisplaySizes;
				int num = Math.Min(10, displaySizes.Count);
				SizeHelper.StockSizes = new Size[num];
				for (int i = 0; i < num; i++)
				{
					SizeHelper.StockSizes[i] = SizeHelper.Parse(displaySizes.GetDisplaySize(i).Size);
				}
				return;
			}
			Current.RdcManSection = new RdcManSection();
			SizeHelper.StockSizes = new Size[7];
			SizeHelper.StockSizes[0] = new Size(800, 600);
			SizeHelper.StockSizes[1] = new Size(1024, 768);
			SizeHelper.StockSizes[2] = new Size(1280, 1024);
			SizeHelper.StockSizes[3] = new Size(1366, 768);
			SizeHelper.StockSizes[4] = new Size(1440, 900);
			SizeHelper.StockSizes[5] = new Size(1600, 1200);
			SizeHelper.StockSizes[6] = new Size(1920, 1200);
		}
	}
}
