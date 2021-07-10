using System;
using System.Xml;

namespace RdcMan
{
	// Token: 0x0200016A RID: 362
	public class BoolSetting : Setting<bool>
	{
		// Token: 0x06000975 RID: 2421 RVA: 0x00007EE4 File Offset: 0x000060E4
		public BoolSetting(object o) : base(o)
		{
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x00007EED File Offset: 0x000060ED
		public override void ReadXml(XmlNode xmlNode, RdcTreeNode node)
		{
			base.Value = bool.Parse(xmlNode.FirstChild.InnerText);
		}
	}
}
