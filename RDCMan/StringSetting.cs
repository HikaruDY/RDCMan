using System;
using System.Xml;

namespace RdcMan
{
	// Token: 0x0200016C RID: 364
	public class StringSetting : Setting<string>
	{
		// Token: 0x06000979 RID: 2425 RVA: 0x00007F26 File Offset: 0x00006126
		public StringSetting(object o) : base(o)
		{
			if (base.Value == null)
			{
				base.Value = string.Empty;
			}
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x00007F42 File Offset: 0x00006142
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
