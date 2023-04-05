using System;

namespace RdcMan
{
	internal interface IServerRefFactory
	{
		ServerRef Create(Server server);
	}
}
