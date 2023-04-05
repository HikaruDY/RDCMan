using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[ComVisible(true)]
	public enum RedirectionWarningType
	{
		RedirectionWarningTypeDefault,
		RedirectionWarningTypeUnsigned,
		RedirectionWarningTypeUnknown,
		RedirectionWarningTypeUser,
		RedirectionWarningTypeThirdPartySigned,
		RedirectionWarningTypeTrusted,
		RedirectionWarningTypeMax = 5
	}
}
