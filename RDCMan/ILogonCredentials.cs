using System;

namespace RdcMan
{
	// Token: 0x02000094 RID: 148
	public interface ILogonCredentials
	{
		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060002E4 RID: 740
		string ProfileName { get; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060002E5 RID: 741
		ProfileScope ProfileScope { get; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060002E6 RID: 742
		string UserName { get; }

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060002E7 RID: 743
		PasswordSetting Password { get; }

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060002E8 RID: 744
		string Domain { get; }
	}
}
