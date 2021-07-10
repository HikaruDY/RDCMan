using System;
using System.Xml;

namespace RdcMan
{
	// Token: 0x0200016F RID: 367
	public class XmlSetting : Setting<XmlNode>
	{
		// Token: 0x06000983 RID: 2435 RVA: 0x00007FE9 File Offset: 0x000061E9
		public XmlSetting(object o) : base(o)
		{
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x00007FF2 File Offset: 0x000061F2
		public override void ReadXml(XmlNode xmlNode, RdcTreeNode node)
		{
			base.Value = xmlNode;
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x00007FFB File Offset: 0x000061FB
		public override void WriteXml(XmlTextWriter tw, RdcTreeNode node)
		{
			base.Value.WriteTo(tw);
		}
	}
}
