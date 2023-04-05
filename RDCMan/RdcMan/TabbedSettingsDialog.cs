using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x020000E4 RID: 228
	public partial class TabbedSettingsDialog : RdcDialog
	{
		// Token: 0x06000821 RID: 2081 RVA: 0x000227E0 File Offset: 0x000209E0
		public TabbedSettingsDialog(string dialogTitle, string acceptButtonText, Form parentForm) : base(dialogTitle, acceptButtonText, parentForm)
		{
			this._tabControl = new TabControl
			{
				Location = new Point(8, 8),
				SelectedIndex = 0,
				Size = new Size(520, 350),
				Appearance = TabAppearance.Normal,
				Multiline = true
			};
			base.Controls.Add(this._tabControl);
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000822 RID: 2082 RVA: 0x00022850 File Offset: 0x00020A50
		public IEnumerable<TabPage> TabPages
		{
			get
			{
				return this._tabControl.TabPages.Cast<TabPage>();
			}
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00022864 File Offset: 0x00020A64
		public void AddTabPage(TabPage page)
		{
			this._tabControl.TabPages.Add(page);
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00022878 File Offset: 0x00020A78
		public void SetActiveTab(string name)
		{
			this._initiallyActiveTab = (from p in this.TabPages
			where p.Text == name
			select p).FirstOrDefault<TabPage>();
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x000228B8 File Offset: 0x00020AB8
		public void UpdateSettings()
		{
			foreach (ISettingsTabPage settingsTabPage in this.TabPages.OfType<ISettingsTabPage>())
			{
				settingsTabPage.UpdateSettings();
			}
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x00022914 File Offset: 0x00020B14
		public void EnableTabs(EnableTabsEventArgs args)
		{
			using (IEnumerator<string> enumerator = args.TabNames.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					string name = enumerator.Current;
					TabPage tabPage = (from p in this.TabPages
					where p.Text.Equals(name)
					select p).First<TabPage>();
					ISettingsTabPage settingsTabPage = tabPage as ISettingsTabPage;
					settingsTabPage.InheritanceControl.Enable(args.Enabled, args.Reason);
				}
			}
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x000229AC File Offset: 0x00020BAC
		protected override void ShownCallback(object sender, EventArgs args)
		{
			foreach (TabPage tabPage in this.TabPages)
			{
				tabPage.Enabled = this._acceptButton.Enabled;
				ISettingsTabPage settingsTabPage = tabPage as ISettingsTabPage;
				if (settingsTabPage != null)
				{
					settingsTabPage.UpdateControls();
					if (settingsTabPage.FocusControl != null)
					{
						this._tabControl.SelectedTab = tabPage;
						settingsTabPage.FocusControl.Focus();
					}
				}
			}
			if (this._initiallyActiveTab != null)
			{
				this._tabControl.SelectedTab = this._initiallyActiveTab;
			}
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x00022A60 File Offset: 0x00020C60
		protected override void AcceptIfValid(object sender, EventArgs e)
		{
			TabPage tabPage = null;
			foreach (TabPage tabPage2 in this.TabPages)
			{
				ISettingsTabPage settingsTabPage = tabPage2 as ISettingsTabPage;
				if (settingsTabPage != null && !settingsTabPage.Validate() && (tabPage == null || tabPage2 == this._tabControl.SelectedTab))
				{
					tabPage = tabPage2;
				}
			}
			if (tabPage == null)
			{
				base.AcceptIfValid(sender, e);
				return;
			}
			this._tabControl.SelectedTab = tabPage;
		}

		// Token: 0x0400034B RID: 843
		private TabPage _initiallyActiveTab;

		// Token: 0x0400034C RID: 844
		private readonly TabControl _tabControl;
	}
}
