using System;

namespace RdcMan
{
	internal class ServerTreeVisibilityMenuItem : EnumMenuItem<ControlVisibility>
	{
		public ServerTreeVisibilityMenuItem(string text, ControlVisibility value) : base(text, value)
		{
		}

		protected override ControlVisibility Value
		{
			get
			{
				return Program.TheForm.ServerTreeVisibility;
			}
			set
			{
				Program.TheForm.ServerTreeVisibility = value;
			}
		}
	}
}
