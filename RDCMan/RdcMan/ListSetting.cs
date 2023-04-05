using System;
using System.Collections.Generic;
using System.Xml;

namespace RdcMan
{
	// Token: 0x020000DD RID: 221
	public class ListSetting<T> : Setting<List<T>> where T : class
	{
		// Token: 0x060007FF RID: 2047 RVA: 0x0002206C File Offset: 0x0002026C
		public ListSetting(object o) : base(o)
		{
			if (base.Value == null)
			{
				base.Value = new List<T>();
			}
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x0002208C File Offset: 0x0002028C
		public override void ReadXml(XmlNode xmlNode, RdcTreeNode node)
		{
			List<T> list = new List<T>();
			foreach (object obj in xmlNode.ChildNodes)
			{
				XmlNode xmlNode2 = (XmlNode)obj;
				if (xmlNode2.Name != "item")
				{
					throw new Exception();
				}
				list.Add(xmlNode2.InnerText as T);
			}
			base.Value = list;
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x00022128 File Offset: 0x00020328
		public override void WriteXml(XmlTextWriter tw, RdcTreeNode node)
		{
			foreach (T t in base.Value)
			{
				tw.WriteElementString("item", t.ToString());
			}
		}

		// Token: 0x0400033D RID: 829
		private const string XmlNodeName = "item";
	}
}
