using System;
using System.Xml;

namespace RdcMan
{
	// Token: 0x02000175 RID: 373
	public class InheritSettingsType
	{
		// Token: 0x0600099D RID: 2461 RVA: 0x00008114 File Offset: 0x00006314
		public InheritSettingsType()
		{
			this.Mode = InheritanceMode.FromParent;
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x00021560 File Offset: 0x0001F760
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

		// Token: 0x0600099F RID: 2463 RVA: 0x000215AC File Offset: 0x0001F7AC
		public void WriteXml(XmlTextWriter tw)
		{
			tw.WriteAttributeString("inherit", this.Mode.ToString());
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060009A0 RID: 2464 RVA: 0x00008123 File Offset: 0x00006323
		// (set) Token: 0x060009A1 RID: 2465 RVA: 0x0000812B File Offset: 0x0000632B
		public InheritanceMode Mode { get; set; }
	}
}
