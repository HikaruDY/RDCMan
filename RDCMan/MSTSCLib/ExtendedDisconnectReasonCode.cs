using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[ComVisible(true)]
	public enum ExtendedDisconnectReasonCode
	{
		exDiscReasonNoInfo,
		exDiscReasonAPIInitiatedDisconnect,
		exDiscReasonAPIInitiatedLogoff,
		exDiscReasonServerIdleTimeout,
		exDiscReasonServerLogonTimeout,
		exDiscReasonReplacedByOtherConnection,
		exDiscReasonOutOfMemory,
		exDiscReasonServerDeniedConnection,
		exDiscReasonServerDeniedConnectionFips,
		exDiscReasonServerInsufficientPrivileges,
		exDiscReasonServerFreshCredsRequired,
		exDiscReasonRpcInitiatedDisconnectByUser,
		exDiscReasonLogoffByUser,
		exDiscReasonLicenseInternal = 256,
		exDiscReasonLicenseNoLicenseServer,
		exDiscReasonLicenseNoLicense,
		exDiscReasonLicenseErrClientMsg,
		exDiscReasonLicenseHwidDoesntMatchLicense,
		exDiscReasonLicenseErrClientLicense,
		exDiscReasonLicenseCantFinishProtocol,
		exDiscReasonLicenseClientEndedProtocol,
		exDiscReasonLicenseErrClientEncryption,
		exDiscReasonLicenseCantUpgradeLicense,
		exDiscReasonLicenseNoRemoteConnections,
		exDiscReasonLicenseCreatingLicStoreAccDenied,
		exDiscReasonRdpEncInvalidCredentials = 768,
		exDiscReasonProtocolRangeStart = 4096,
		exDiscReasonProtocolRangeEnd = 32767
	}
}
