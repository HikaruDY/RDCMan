using System;
using System.Drawing;
using System.Xml;

namespace RdcMan
{
	// Token: 0x0200016D RID: 365
	public class SizeSetting : Setting<Size>
	{
		// Token: 0x0600097B RID: 2427 RVA: 0x00007F67 File Offset: 0x00006167
		public SizeSetting(object o) : base(o)
		{
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00007F70 File Offset: 0x00006170
		public override void ReadXml(XmlNode xmlNode, RdcTreeNode node)
		{
			base.Value = SizeHelper.Parse(xmlNode.FirstChild.InnerText);
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x00007F88 File Offset: 0x00006188
		public override void WriteXml(XmlTextWriter tw, RdcTreeNode node)
		{
			tw.WriteString(base.Value.ToFormattedString());
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x00007F9B File Offset: 0x0000619B
		public override string ToString()
		{
			return base.Value.ToFormattedString();
		}
	}
}
