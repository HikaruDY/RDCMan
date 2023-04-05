using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x0200018E RID: 398
	[ComVisible(true)]
	public enum ExtendedDisconnectReasonCode
	{
		// Token: 0x0400075C RID: 1884
		exDiscReasonNoInfo,
		// Token: 0x0400075D RID: 1885
		exDiscReasonAPIInitiatedDisconnect,
		// Token: 0x0400075E RID: 1886
		exDiscReasonAPIInitiatedLogoff,
		// Token: 0x0400075F RID: 1887
		exDiscReasonServerIdleTimeout,
		// Token: 0x04000760 RID: 1888
		exDiscReasonServerLogonTimeout,
		// Token: 0x04000761 RID: 1889
		exDiscReasonReplacedByOtherConnection,
		// Token: 0x04000762 RID: 1890
		exDiscReasonOutOfMemory,
		// Token: 0x04000763 RID: 1891
		exDiscReasonServerDeniedConnection,
		// Token: 0x04000764 RID: 1892
		exDiscReasonServerDeniedConnectionFips,
		// Token: 0x04000765 RID: 1893
		exDiscReasonServerInsufficientPrivileges,
		// Token: 0x04000766 RID: 1894
		exDiscReasonServerFreshCredsRequired,
		// Token: 0x04000767 RID: 1895
		exDiscReasonRpcInitiatedDisconnectByUser,
		// Token: 0x04000768 RID: 1896
		exDiscReasonLogoffByUser,
		// Token: 0x04000769 RID: 1897
		exDiscReasonLicenseInternal = 256,
		// Token: 0x0400076A RID: 1898
		exDiscReasonLicenseNoLicenseServer,
		// Token: 0x0400076B RID: 1899
		exDiscReasonLicenseNoLicense,
		// Token: 0x0400076C RID: 1900
		exDiscReasonLicenseErrClientMsg,
		// Token: 0x0400076D RID: 1901
		exDiscReasonLicenseHwidDoesntMatchLicense,
		// Token: 0x0400076E RID: 1902
		exDiscReasonLicenseErrClientLicense,
		// Token: 0x0400076F RID: 1903
		exDiscReasonLicenseCantFinishProtocol,
		// Token: 0x04000770 RID: 1904
		exDiscReasonLicenseClientEndedProtocol,
		// Token: 0x04000771 RID: 1905
		exDiscReasonLicenseErrClientEncryption,
		// Token: 0x04000772 RID: 1906
		exDiscReasonLicenseCantUpgradeLicense,
		// Token: 0x04000773 RID: 1907
		exDiscReasonLicenseNoRemoteConnections,
		// Token: 0x04000774 RID: 1908
		exDiscReasonLicenseCreatingLicStoreAccDenied,
		// Token: 0x04000775 RID: 1909
		exDiscReasonRdpEncInvalidCredentials = 768,
		// Token: 0x04000776 RID: 1910
		exDiscReasonProtocolRangeStart = 4096,
		// Token: 0x04000777 RID: 1911
		exDiscReasonProtocolRangeEnd = 32767
	}
}
