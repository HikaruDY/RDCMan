using System;
using System.Xml;

namespace RdcMan
{
	// Token: 0x020000D6 RID: 214
	public class StringSetting : Setting<string>
	{
		// Token: 0x060007DE RID: 2014 RVA: 0x00021C1C File Offset: 0x0001FE1C
		public StringSetting(object o) : base(o)
		{
			if (base.Value == null)
			{
				base.Value = string.Empty;
			}
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00021C3C File Offset: 0x0001FE3C
		public override void ReadXml(XmlNode xmlNode, RdcTreeNode node)
		{
			xmlNode = xmlNode.FirstChild;
			if (xmlNode == null)
			{
				base.Value = string.Empty;
				return;
			}
			base.Value = xmlNode.InnerText;
		}
	}
}
