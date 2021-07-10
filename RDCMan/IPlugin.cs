using System;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	// Token: 0x02000097 RID: 151
	public interface IPlugin
	{
		// Token: 0x060002EE RID: 750
		void PreLoad(IPluginContext context, XmlNode xmlNode);

		// Token: 0x060002EF RID: 751
		void PostLoad(IPluginContext context);

		// Token: 0x060002F0 RID: 752
		XmlNode SaveSettings();

		// Token: 0x060002F1 RID: 753
		void Shutdown();

		// Token: 0x060002F2 RID: 754
		void OnContextMenu(ContextMenuStrip contextMenuStrip, RdcTreeNode node);

		// Token: 0x060002F3 RID: 755
		void OnUndockServer(IUndockedServerForm form);

		// Token: 0x060002F4 RID: 756
		void OnDockServer(ServerBase server);
	}
}
