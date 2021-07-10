namespace RdcMan
{
	// Token: 0x02000052 RID: 82
	public partial class GlobalOptionsDialog : global::RdcMan.TabbedSettingsDialog
	{
		// Token: 0x06000159 RID: 345 RVA: 0x00002B61 File Offset: 0x00000D61
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
