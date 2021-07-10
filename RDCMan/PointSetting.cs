using System;
using System.Drawing;
using System.Xml;

namespace RdcMan
{
	// Token: 0x0200016E RID: 366
	public class PointSetting : Setting<Point>
	{
		// Token: 0x0600097F RID: 2431 RVA: 0x00007FA8 File Offset: 0x000061A8
		public PointSetting(object o) : base(o)
		{
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x00007FB1 File Offset: 0x000061B1
		public override void ReadXml(XmlNode xmlNode, RdcTreeNode node)
		{
			base.Value = PointHelper.Parse(xmlNode.FirstChild.InnerText);
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00007FC9 File Offset: 0x000061C9
		public override void WriteXml(XmlTextWriter tw, RdcTreeNode node)
		{
			tw.WriteString(base.Value.ToFormattedString());
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x00007FDC File Offset: 0x000061DC
		public override string ToString()
		{
			return base.Value.ToFormattedString();
		}
	}
}
