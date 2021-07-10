using System;

namespace RdcMan
{
	// Token: 0x0200007A RID: 122
	public interface ICredentialsTabPage
	{
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600023E RID: 574
		CredentialsProfile Credentials { get; }

		// Token: 0x0600023F RID: 575
		void PopulateCredentialsProfiles(FileGroup file);
	}
}
