using System;
using System.Xml;

namespace RdcMan
{
	// Token: 0x020000D5 RID: 213
	public class IntSetting : Setting<int>
	{
		// Token: 0x060007DC RID: 2012 RVA: 0x00021BF8 File Offset: 0x0001FDF8
		public IntSetting(object o) : base(o)
		{
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00021C04 File Offset: 0x0001FE04
		public override void ReadXml(XmlNode xmlNode, RdcTreeNode node)
		{
			base.Value = int.Parse(xmlNode.FirstChild.InnerText);
		}
	}
}
