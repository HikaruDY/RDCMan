using System;
using System.Xml;

namespace RdcMan
{
	// Token: 0x020000D1 RID: 209
	public interface ISetting
	{
		// Token: 0x060007CF RID: 1999
		void ReadXml(XmlNode xmlNode, RdcTreeNode node);

		// Token: 0x060007D0 RID: 2000
		void WriteXml(XmlTextWriter tw, RdcTreeNode node);

		// Token: 0x060007D1 RID: 2001
		void Copy(ISetting source);
	}
}
