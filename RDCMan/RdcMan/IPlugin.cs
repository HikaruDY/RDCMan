using System;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	// Token: 0x02000061 RID: 97
	public interface IPlugin
	{
		// Token: 0x06000271 RID: 625
		void PreLoad(IPluginContext context, XmlNode xmlNode);

		// Token: 0x06000272 RID: 626
		void PostLoad(IPluginContext context);

		// Token: 0x06000273 RID: 627
		XmlNode SaveSettings();

		// Token: 0x06000274 RID: 628
		void Shutdown();

		// Token: 0x06000275 RID: 629
		void OnContextMenu(ContextMenuStrip contextMenuStrip, RdcTreeNode node);

		// Token: 0x06000276 RID: 630
		void OnUndockServer(IUndockedServerForm form);

		// Token: 0x06000277 RID: 631
		void OnDockServer(ServerBase server);
	}
}
