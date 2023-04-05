using System;
using System.Windows.Forms;

namespace RdcMan
{
	internal class ServerTreeLocationMenuItem : EnumMenuItem<DockStyle>
	{
		public ServerTreeLocationMenuItem(string text, DockStyle value) : base(text, value)
		{
		}

		protected override DockStyle Value
		{
			get
			{
				return Program.TheForm.ServerTreeLocation;
			}
			set
			{
				Program.TheForm.ServerTreeLocation = value;
			}
		}
	}
}
