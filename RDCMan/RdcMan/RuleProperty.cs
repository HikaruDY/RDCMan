using System;

namespace RdcMan
{
	// Token: 0x0200007F RID: 127
	public class RuleProperty
	{
		// Token: 0x060003DB RID: 987 RVA: 0x000144D0 File Offset: 0x000126D0
		public RuleProperty(ServerProperty property)
		{
			this.ServerProperty = property;
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060003DC RID: 988 RVA: 0x000144E0 File Offset: 0x000126E0
		// (set) Token: 0x060003DD RID: 989 RVA: 0x000144E8 File Offset: 0x000126E8
		public ServerProperty ServerProperty { get; private set; }

		// Token: 0x060003DE RID: 990 RVA: 0x000144F4 File Offset: 0x000126F4
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
