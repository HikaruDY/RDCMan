using System;
using System.Collections.Generic;
using System.Xml;

namespace RdcMan
{
	// Token: 0x02000173 RID: 371
	public class ListSetting<T> : Setting<List<T>> where T : class
	{
		// Token: 0x0600099A RID: 2458 RVA: 0x000080F8 File Offset: 0x000062F8
		public ListSetting(object o) : base(o)
		{
			if (base.Value == null)
			{
				base.Value = new List<T>();
			}
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x0002146C File Offset: 0x0001F66C
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

		// Token: 0x0600099C RID: 2460 RVA: 0x000214FC File Offset: 0x0001F6FC
		public override void WriteXml(XmlTextWriter tw, RdcTreeNode node)
		{
			foreach (T t in base.Value)
			{
				tw.WriteElementString("item", t.ToString());
			}
		}

		// Token: 0x0400065A RID: 1626
		private const string XmlNodeName = "item";
	}
}
