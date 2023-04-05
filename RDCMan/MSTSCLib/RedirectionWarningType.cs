using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x020001C7 RID: 455
	[ComVisible(true)]
	public enum RedirectionWarningType
	{
		// Token: 0x0400079C RID: 1948
		RedirectionWarningTypeDefault,
		// Token: 0x0400079D RID: 1949
		RedirectionWarningTypeUnsigned,
		// Token: 0x0400079E RID: 1950
		RedirectionWarningTypeUnknown,
		// Token: 0x0400079F RID: 1951
		RedirectionWarningTypeUser,
		// Token: 0x040007A0 RID: 1952
		RedirectionWarningTypeThirdPartySigned,
		// Token: 0x040007A1 RID: 1953
		RedirectionWarningTypeTrusted,
		// Token: 0x040007A2 RID: 1954
		RedirectionWarningTypeMax = 5
	}
}
