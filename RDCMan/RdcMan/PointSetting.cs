using System;
using System.Drawing;
using System.Xml;

namespace RdcMan
{
	// Token: 0x020000D8 RID: 216
	public class PointSetting : Setting<Point>
	{
		// Token: 0x060007E4 RID: 2020 RVA: 0x00021CAC File Offset: 0x0001FEAC
		public PointSetting(object o) : base(o)
		{
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00021CB8 File Offset: 0x0001FEB8
		public override void ReadXml(XmlNode xmlNode, RdcTreeNode node)
		{
			base.Value = PointHelper.Parse(xmlNode.FirstChild.InnerText);
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x00021CD0 File Offset: 0x0001FED0
		public override void WriteXml(XmlTextWriter tw, RdcTreeNode node)
		{
			tw.WriteString(base.Value.ToFormattedString());
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00021CE4 File Offset: 0x0001FEE4
		public override string ToString()
		{
			return base.Value.ToFormattedString();
		}
	}
}
