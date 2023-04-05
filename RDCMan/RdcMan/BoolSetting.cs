using System;
using System.Xml;

namespace RdcMan
{
	// Token: 0x020000D4 RID: 212
	public class BoolSetting : Setting<bool>
	{
		// Token: 0x060007DA RID: 2010 RVA: 0x00021BD4 File Offset: 0x0001FDD4
		public BoolSetting(object o) : base(o)
		{
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00021BE0 File Offset: 0x0001FDE0
		public override void ReadXml(XmlNode xmlNode, RdcTreeNode node)
		{
			base.Value = bool.Parse(xmlNode.FirstChild.InnerText);
		}
	}
}
