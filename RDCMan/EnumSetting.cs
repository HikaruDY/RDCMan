using System;
using System.Xml;

namespace RdcMan
{
	// Token: 0x02000172 RID: 370
	public class EnumSetting<TEnum> : Setting<TEnum> where TEnum : struct
	{
		// Token: 0x06000997 RID: 2455 RVA: 0x000080EF File Offset: 0x000062EF
		public EnumSetting(object o) : base(o)
		{
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x000213F4 File Offset: 0x0001F5F4
		public override void ReadXml(XmlNode xmlNode, RdcTreeNode node)
		{
			int num;
			if (int.TryParse(xmlNode.InnerText, out num))
			{
				base.Value = (TEnum)((object)num);
				return;
			}
			base.Value = (TEnum)((object)Enum.Parse(typeof(TEnum), xmlNode.InnerText));
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x00021444 File Offset: 0x0001F644
		public override void WriteXml(XmlTextWriter tw, RdcTreeNode node)
		{
			TEnum value = base.Value;
			tw.WriteString(value.ToString());
		}
	}
}
