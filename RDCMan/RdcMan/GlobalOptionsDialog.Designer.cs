namespace RdcMan
{
	public partial class GlobalOptionsDialog : global::RdcMan.TabbedSettingsDialog
	{
		private void InitializeComponent()
		{
			this.CreateGeneralPage();
			this.CreateServerTreePage();
			this.CreateClientAreaPage();
			this.CreateHotKeysPage();
			this.CreateExperiencePage();
			this.CreateFullScreenPage();
			this.InitButtons();
			this.ScaleAndLayout();
		}
	}
}
