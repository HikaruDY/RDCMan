using System;
using System.Runtime.InteropServices;

namespace MSTSCLib
{
	[Guid("4EB5335B-6429-477D-B922-E06A28ECD8BF")]
	[CoClass(typeof(MsRdpClient5Class))]
	[ComVisible(true)]
	[ComImport]
	public interface MsRdpClient5 : IMsRdpClient5, IMsTscAxEvents_Event
	{
	}
}
