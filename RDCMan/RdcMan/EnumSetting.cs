using System;
using System.Xml;

namespace RdcMan
{
	// Token: 0x020000DC RID: 220
	public class EnumSetting<TEnum> : Setting<TEnum> where TEnum : struct
	{
		// Token: 0x060007FC RID: 2044 RVA: 0x00021FAC File Offset: 0x000201AC
		public EnumSetting(object o) : base(o)
		{
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00021FB8 File Offset: 0x000201B8
		public override void ReadXml(XmlNode xmlNode, RdcTreeNode node)
		{
			int num;
			if (int.TryParse(xmlNode.InnerText, out num))
			{
				base.Value = (TEnum)((object)num);
				return;
			}
			bool flag;
			if (bool.TryParse(xmlNode.InnerText, out flag))
			{
				base.Value = (TEnum)((object)(flag ? 1 : 0));
				return;
			}
			base.Value = (TEnum)((object)Enum.Parse(typeof(TEnum), xmlNode.InnerText));
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x00022040 File Offset: 0x00020240
		public override void WriteXml(XmlTextWriter tw, RdcTreeNode node)
		{
			TEnum value = base.Value;
			tw.WriteString(value.ToString());
		}
	}
}
