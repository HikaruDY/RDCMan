using System;
using System.Configuration;
using System.Drawing;

namespace RdcMan.Configuration
{
	// Token: 0x0200018C RID: 396
	public static class Current
	{
		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000A12 RID: 2578 RVA: 0x00008483 File Offset: 0x00006683
		// (set) Token: 0x06000A13 RID: 2579 RVA: 0x0000848A File Offset: 0x0000668A
		public static RdcManSection RdcManSection { get; private set; }

		// Token: 0x06000A14 RID: 2580 RVA: 0x00022F04 File Offset: 0x00021104
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
