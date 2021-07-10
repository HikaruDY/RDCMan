using System;

namespace RdcMan
{
	// Token: 0x02000047 RID: 71
	public interface IDeferDecryption
	{
		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600011E RID: 286
		// (set) Token: 0x0600011F RID: 287
		bool IsDecrypted { get; set; }

		// Token: 0x06000120 RID: 288
		void Decrypt(EncryptionSettings settings);
	}
}
