using System;
using System.Xml;

namespace RdcMan
{
	// Token: 0x020000D2 RID: 210
	public abstract class BaseSetting<T> : ISetting
	{
		// Token: 0x060007D2 RID: 2002 RVA: 0x00021B38 File Offset: 0x0001FD38
		protected BaseSetting(object o)
		{
			this.Value = ((o != null) ? ((T)((object)o)) : default(T));
		}

		// Token: 0x060007D3 RID: 2003
		public abstract void ReadXml(XmlNode xmlNode, RdcTreeNode node);

		// Token: 0x060007D4 RID: 2004 RVA: 0x00021B70 File Offset: 0x0001FD70
		public virtual void WriteXml(XmlTextWriter tw, RdcTreeNode node)
		{
			tw.WriteString(this.Value.ToString());
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00021B8C File Offset: 0x0001FD8C
		public virtual void Copy(ISetting source)
		{
			this.Value = ((BaseSetting<T>)source).Value;
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x00021BA0 File Offset: 0x0001FDA0
		public override string ToString()
		{
			return this.Value.ToString();
		}

		// Token: 0x04000338 RID: 824
		internal T Value;
	}
}
