using System;

namespace RdcMan
{
	// Token: 0x020000D1 RID: 209
	public class RuleProperty
	{
		// Token: 0x060004DD RID: 1245 RVA: 0x00004CFB File Offset: 0x00002EFB
		public RuleProperty(ServerProperty property)
		{
			this.ServerProperty = property;
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x00004D0A File Offset: 0x00002F0A
		// (set) Token: 0x060004DF RID: 1247 RVA: 0x00004D12 File Offset: 0x00002F12
		public ServerProperty ServerProperty { get; private set; }

		// Token: 0x060004E0 RID: 1248 RVA: 0x00017F14 File Offset: 0x00016114
		public object GetValue(Server server, out bool isString)
		{
			switch (this.ServerProperty)
			{
			case ServerProperty.DisplayName:
				isString = true;
				return server.DisplayName;
			case ServerProperty.ServerName:
				isString = true;
				return server.ServerName;
			case ServerProperty.Parent:
				isString = true;
				return server.ParentPath;
			case ServerProperty.Comment:
				isString = true;
				return server.Properties.Comment.Value;
			default:
				throw new NotImplementedException();
			}
		}
	}
}
