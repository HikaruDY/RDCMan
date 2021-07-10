using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x0200017A RID: 378
	public partial class TabbedSettingsDialog : RdcDialog
	{
		// Token: 0x060009BC RID: 2492 RVA: 0x00021A60 File Offset: 0x0001FC60
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

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060009BD RID: 2493 RVA: 0x000081BC File Offset: 0x000063BC
		public IEnumerable<TabPage> TabPages
		{
			get
			{
				return this._tabControl.TabPages.Cast<TabPage>();
			}
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x000081CE File Offset: 0x000063CE
		public void AddTabPage(TabPage page)
		{
			this._tabControl.TabPages.Add(page);
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x00021ACC File Offset: 0x0001FCCC
		public void SetActiveTab(string name)
		{
			this._initiallyActiveTab = (from p in this.TabPages
			where p.Text == name
			select p).FirstOrDefault<TabPage>();
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x00021B08 File Offset: 0x0001FD08
		public void UpdateSettings()
		{
			foreach (ISettingsTabPage settingsTabPage in this.TabPages.OfType<ISettingsTabPage>())
			{
				settingsTabPage.UpdateSettings();
			}
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00021B5C File Offset: 0x0001FD5C
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

		// Token: 0x060009C2 RID: 2498 RVA: 0x00021BE8 File Offset: 0x0001FDE8
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

		// Token: 0x060009C3 RID: 2499 RVA: 0x00021C88 File Offset: 0x0001FE88
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

		// Token: 0x04000668 RID: 1640
		private TabPage _initiallyActiveTab;

		// Token: 0x04000669 RID: 1641
		private readonly TabControl _tabControl;
	}
}
