using System;

namespace RdcMan
{
	public abstract class CommonNodeSettings : SettingsGroup
	{
		protected CommonNodeSettings(string name) : base(name, "properties")
		{
			base.InheritSettingsType.Mode = InheritanceMode.Disabled;
		}

		protected override void Copy(RdcTreeNode node)
		{
			base.Copy(node.Properties);
		}

		[Setting("name")]
		protected StringSetting NodeName { get; set; }

		[Setting("comment")]
		public StringSetting Comment { get; protected set; }
	}
}
