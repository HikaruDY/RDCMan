using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RdcMan
{
	public partial class TabbedSettingsDialog : RdcDialog
	{
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

		public IEnumerable<TabPage> TabPages
		{
			get
			{
				return this._tabControl.TabPages.Cast<TabPage>();
			}
		}

		public void AddTabPage(TabPage page)
		{
			this._tabControl.TabPages.Add(page);
		}

		public void SetActiveTab(string name)
		{
			this._initiallyActiveTab = (from p in this.TabPages
			where p.Text == name
			select p).FirstOrDefault<TabPage>();
		}

		public void UpdateSettings()
		{
			foreach (ISettingsTabPage settingsTabPage in this.TabPages.OfType<ISettingsTabPage>())
			{
				settingsTabPage.UpdateSettings();
			}
		}

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

		private TabPage _initiallyActiveTab;

		private readonly TabControl _tabControl;
	}
}
