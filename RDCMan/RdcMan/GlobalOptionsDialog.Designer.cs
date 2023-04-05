namespace RdcMan
{
	// Token: 0x02000034 RID: 52
	public partial class GlobalOptionsDialog : global::RdcMan.TabbedSettingsDialog
	{
		// Token: 0x06000138 RID: 312 RVA: 0x00007018 File Offset: 0x00005218
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
