using System;
using System.Xml;

namespace RdcMan
{
	// Token: 0x020000DF RID: 223
	public class InheritSettingsType
	{
		// Token: 0x06000802 RID: 2050 RVA: 0x00022190 File Offset: 0x00020390
		public InheritSettingsType()
		{
			this.Mode = InheritanceMode.FromParent;
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x000221A0 File Offset: 0x000203A0
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

		// Token: 0x06000804 RID: 2052 RVA: 0x00022204 File Offset: 0x00020404
		public void WriteXml(XmlTextWriter tw)
		{
			tw.WriteAttributeString("inherit", this.Mode.ToString());
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000805 RID: 2053 RVA: 0x00022234 File Offset: 0x00020434
		// (set) Token: 0x06000806 RID: 2054 RVA: 0x0002223C File Offset: 0x0002043C
		public InheritanceMode Mode { get; set; }
	}
}
