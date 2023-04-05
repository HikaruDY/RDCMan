using System;
using System.Xml;

namespace RdcMan
{
	// Token: 0x020000D9 RID: 217
	public class XmlSetting : Setting<XmlNode>
	{
		// Token: 0x060007E8 RID: 2024 RVA: 0x00021CF4 File Offset: 0x0001FEF4
		public XmlSetting(object o) : base(o)
		{
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00021D00 File Offset: 0x0001FF00
		public override void ReadXml(XmlNode xmlNode, RdcTreeNode node)
		{
			base.Value = xmlNode;
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x00021D0C File Offset: 0x0001FF0C
		public override void WriteXml(XmlTextWriter tw, RdcTreeNode node)
		{
			base.Value.WriteTo(tw);
		}
	}
}
