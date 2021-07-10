using System;
using System.Xml;

namespace RdcMan
{
	// Token: 0x02000167 RID: 359
	public interface ISetting
	{
		// Token: 0x0600096A RID: 2410
		void ReadXml(XmlNode xmlNode, RdcTreeNode node);

		// Token: 0x0600096B RID: 2411
		void WriteXml(XmlTextWriter tw, RdcTreeNode node);

		// Token: 0x0600096C RID: 2412
		void Copy(ISetting source);
	}
}
