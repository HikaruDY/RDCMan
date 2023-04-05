using System;
using System.Xml;

namespace RdcMan
{
	public abstract class BaseSetting<T> : ISetting
	{
		protected BaseSetting(object o)
		{
			this.Value = ((o != null) ? ((T)((object)o)) : default(T));
		}

		public abstract void ReadXml(XmlNode xmlNode, RdcTreeNode node);

		public virtual void WriteXml(XmlTextWriter tw, RdcTreeNode node)
		{
			tw.WriteString(this.Value.ToString());
		}

		public virtual void Copy(ISetting source)
		{
			this.Value = ((BaseSetting<T>)source).Value;
		}

		public override string ToString()
		{
			return this.Value.ToString();
		}

		internal T Value;
	}
}
