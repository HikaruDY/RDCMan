using System;
using System.Xml;

namespace RdcMan
{
	// Token: 0x0200016B RID: 363
	public class IntSetting : Setting<int>
	{
		// Token: 0x06000977 RID: 2423 RVA: 0x00007F05 File Offset: 0x00006105
		public IntSetting(object o) : base(o)
		{
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x00007F0E File Offset: 0x0000610E
		public override void ReadXml(XmlNode xmlNode, RdcTreeNode node)
		{
			base.Value = int.Parse(xmlNode.FirstChild.InnerText);
		}
	}
}
