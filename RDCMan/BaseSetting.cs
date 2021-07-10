using System;
using System.Xml;

namespace RdcMan
{
	// Token: 0x02000168 RID: 360
	public abstract class BaseSetting<T> : ISetting
	{
		// Token: 0x0600096D RID: 2413 RVA: 0x00021264 File Offset: 0x0001F464
		protected BaseSetting(object o)
		{
			this.Value = ((o != null) ? ((T)((object)o)) : default(T));
		}

		// Token: 0x0600096E RID: 2414
		public abstract void ReadXml(XmlNode xmlNode, RdcTreeNode node);

		// Token: 0x0600096F RID: 2415 RVA: 0x00007E8B File Offset: 0x0000608B
		public virtual void WriteXml(XmlTextWriter tw, RdcTreeNode node)
		{
			tw.WriteString(this.Value.ToString());
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x00007EA4 File Offset: 0x000060A4
		public virtual void Copy(ISetting source)
		{
			this.Value = ((BaseSetting<T>)source).Value;
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x00007EB7 File Offset: 0x000060B7
		public override string ToString()
		{
			return this.Value.ToString();
		}

		// Token: 0x04000655 RID: 1621
		internal T Value;
	}
}
