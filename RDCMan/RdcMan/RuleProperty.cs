using System;

namespace RdcMan
{
	public class RuleProperty
	{
		public RuleProperty(ServerProperty property)
		{
			this.ServerProperty = property;
		}

		public ServerProperty ServerProperty { get; private set; }

		public object GetValue(Server server, out bool isString)
		{
			switch (this.ServerProperty)
			{
			case ServerProperty.DisplayName:
				isString = true;
				return server.DisplayName;
			case ServerProperty.ServerName:
				isString = true;
				return server.ServerName;
			case ServerProperty.Parent:
				isString = true;
				return server.ParentPath;
			case ServerProperty.Comment:
				isString = true;
				return server.Properties.Comment.Value;
			default:
				throw new NotImplementedException();
			}
		}
	}
}
