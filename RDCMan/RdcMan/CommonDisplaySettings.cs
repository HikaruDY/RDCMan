using System;

namespace RdcMan
{
	public abstract class CommonDisplaySettings : SettingsGroup
	{
		protected CommonDisplaySettings() : base("Display Settings", "displaySettings")
		{
		}

		protected override void Copy(RdcTreeNode node)
		{
			base.Copy(node.DisplaySettings);
		}

		[Setting("thumbnailScale", DefaultValue = 1)]
		public IntSetting ThumbnailScale { get; protected set; }

		[Setting("smartSizeDockedWindows", DefaultValue = RdpClient.SmartSizeMethod.None)]
		public EnumSetting<RdpClient.SmartSizeMethod> SmartSizeDockedWindow { get; protected set; }

		[Setting("smartSizeUndockedWindows", DefaultValue = RdpClient.SmartSizeMethod.None)]
		public EnumSetting<RdpClient.SmartSizeMethod> SmartSizeUndockedWindow { get; protected set; }

		public const string TabName = "Display Settings";
	}
}
