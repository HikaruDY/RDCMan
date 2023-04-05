using System;

namespace RdcMan
{
	// Token: 0x0200002C RID: 44
	public interface IDeferDecryption
	{
		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000106 RID: 262
		// (set) Token: 0x06000107 RID: 263
		bool IsDecrypted { get; set; }

		// Token: 0x06000108 RID: 264
		void Decrypt(EncryptionSettings settings);
	}
}
