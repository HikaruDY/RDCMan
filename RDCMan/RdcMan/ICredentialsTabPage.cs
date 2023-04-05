using System;

namespace RdcMan
{
	// Token: 0x0200004A RID: 74
	public interface ICredentialsTabPage
	{
		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060001D2 RID: 466
		CredentialsProfile Credentials { get; }

		// Token: 0x060001D3 RID: 467
		void PopulateCredentialsProfiles(FileGroup file);
	}
}
