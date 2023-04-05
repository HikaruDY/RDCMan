using System;
using System.Xml;

namespace RdcMan
{
	public class InheritSettingsType
	{
		public InheritSettingsType()
		{
			this.Mode = InheritanceMode.FromParent;
		}

		public GroupBase GetInheritedSettingsNode(RdcTreeNode node)
		{
			InheritanceMode mode = this.Mode;
			GroupBase result;
			if (mode != InheritanceMode.FromParent)
			{
				if (mode - InheritanceMode.None > 1)
				{
					throw new Exception("Unexpected inheritance kind");
				}
				result = null;
			}
			else if (node.Parent != null)
			{
				result = (node.Parent as GroupBase);
			}
			else
			{
				result = DefaultSettingsGroup.Instance;
			}
			return result;
		}

		public void WriteXml(XmlTextWriter tw)
		{
			tw.WriteAttributeString("inherit", this.Mode.ToString());
		}

		public InheritanceMode Mode { get; set; }
	}
}
