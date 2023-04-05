using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	// Token: 0x0200018F RID: 399
	[ComVisible(true)]
	public enum __MIDL___MIDL_itf_mstsax_0000_0000_0001
	{
		// Token: 0x04000779 RID: 1913
		exDiscReasonNoInfo,
		// Token: 0x0400077A RID: 1914
		exDiscReasonAPIInitiatedDisconnect,
		// Token: 0x0400077B RID: 1915
		exDiscReasonAPIInitiatedLogoff,
		// Token: 0x0400077C RID: 1916
		exDiscReasonServerIdleTimeout,
		// Token: 0x0400077D RID: 1917
		exDiscReasonServerLogonTimeout,
		// Token: 0x0400077E RID: 1918
		exDiscReasonReplacedByOtherConnection,
		// Token: 0x0400077F RID: 1919
		exDiscReasonOutOfMemory,
		// Token: 0x04000780 RID: 1920
		exDiscReasonServerDeniedConnection,
		// Token: 0x04000781 RID: 1921
		exDiscReasonServerDeniedConnectionFips,
		// Token: 0x04000782 RID: 1922
		exDiscReasonServerInsufficientPrivileges,
		// Token: 0x04000783 RID: 1923
		exDiscReasonServerFreshCredsRequired,
		// Token: 0x04000784 RID: 1924
		exDiscReasonRpcInitiatedDisconnectByUser,
		// Token: 0x04000785 RID: 1925
		exDiscReasonLogoffByUser,
		// Token: 0x04000786 RID: 1926
		exDiscReasonLicenseInternal = 256,
		// Token: 0x04000787 RID: 1927
		exDiscReasonLicenseNoLicenseServer,
		// Token: 0x04000788 RID: 1928
		exDiscReasonLicenseNoLicense,
		// Token: 0x04000789 RID: 1929
		exDiscReasonLicenseErrClientMsg,
		// Token: 0x0400078A RID: 1930
		exDiscReasonLicenseHwidDoesntMatchLicense,
		// Token: 0x0400078B RID: 1931
		exDiscReasonLicenseErrClientLicense,
		// Token: 0x0400078C RID: 1932
		exDiscReasonLicenseCantFinishProtocol,
		// Token: 0x0400078D RID: 1933
		exDiscReasonLicenseClientEndedProtocol,
		// Token: 0x0400078E RID: 1934
		exDiscReasonLicenseErrClientEncryption,
		// Token: 0x0400078F RID: 1935
		exDiscReasonLicenseCantUpgradeLicense,
		// Token: 0x04000790 RID: 1936
		exDiscReasonLicenseNoRemoteConnections,
		// Token: 0x04000791 RID: 1937
		exDiscReasonLicenseCreatingLicStoreAccDenied,
		// Token: 0x04000792 RID: 1938
		exDiscReasonRdpEncInvalidCredentials = 768,
		// Token: 0x04000793 RID: 1939
		exDiscReasonProtocolRangeStart = 4096,
		// Token: 0x04000794 RID: 1940
		exDiscReasonProtocolRangeEnd = 32767
	}
}
