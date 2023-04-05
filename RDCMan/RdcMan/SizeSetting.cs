using System;
using System.Drawing;
using System.Xml;

namespace RdcMan
{
	// Token: 0x020000D7 RID: 215
	public class SizeSetting : Setting<Size>
	{
		// Token: 0x060007E0 RID: 2016 RVA: 0x00021C64 File Offset: 0x0001FE64
		public SizeSetting(object o) : base(o)
		{
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x00021C70 File Offset: 0x0001FE70
		public override void ReadXml(XmlNode xmlNode, RdcTreeNode node)
		{
			base.Value = SizeHelper.Parse(xmlNode.FirstChild.InnerText);
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x00021C88 File Offset: 0x0001FE88
		public override void WriteXml(XmlTextWriter tw, RdcTreeNode node)
		{
			tw.WriteString(base.Value.ToFormattedString());
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x00021C9C File Offset: 0x0001FE9C
		public override string ToString()
		{
			return base.Value.ToFormattedString();
		}
	}
}
