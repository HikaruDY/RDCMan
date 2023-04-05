using System;

namespace RdcMan
{
	// Token: 0x0200005E RID: 94
	public interface ILogonCredentials
	{
		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000267 RID: 615
		string ProfileName { get; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000268 RID: 616
		ProfileScope ProfileScope { get; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000269 RID: 617
		string UserName { get; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600026A RID: 618
		PasswordSetting Password { get; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600026B RID: 619
		string Domain { get; }
	}
}
