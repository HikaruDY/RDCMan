using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000037 RID: 55
	internal abstract partial class GroupBasePropertiesDialog : NodePropertiesDialog
	{
		// Token: 0x0600014F RID: 335 RVA: 0x00008444 File Offset: 0x00006644
		protected GroupBasePropertiesDialog(GroupBase group, string dialogTitle, string acceptButtonText, Form parentForm) : base(group, dialogTitle, acceptButtonText, parentForm)
		{
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00008454 File Offset: 0x00006654
		protected int CreateProfileManagementTabPage()
		{
			int result = 0;
			TabPage tabPage = FormTools.NewTabPage("Profile Management");
			Label label = FormTools.NewLabel("Profiles", 0, result++);
			this._credentialsListBox = new ListBox
			{
				Location = FormTools.NewLocation(0, result++),
				Size = new Size(340, 200)
			};
			this._credentialsListBox.KeyDown += this.CredentialsListBox_KeyDown;
			this._credentialsListBox.DoubleClick += this.EditButton_Click;
			this._credentialsListBox.VisibleChanged += this.CredentialsListBox_VisibleChanged;
			Button button = new Button
			{
				Text = "&Add",
				Location = new Point(this._credentialsListBox.Right + 20, this._credentialsListBox.Top)
			};
			button.Click += this.AddButton_Click;
			Button button2 = new Button
			{
				Text = "&Edit",
				Location = new Point(this._credentialsListBox.Right + 20, button.Bottom + 4)
			};
			button2.Click += this.EditButton_Click;
			Button button3 = new Button
			{
				Text = "&Delete",
				Location = new Point(this._credentialsListBox.Right + 20, button2.Bottom + 4)
			};
			button3.Click += this.DeleteButton_Click;
			tabPage.Controls.Add(new Control[]
			{
				label,
				this._credentialsListBox,
				button,
				button2,
				button3
			});
			tabPage.ResumeLayout();
			base.AddTabPage(tabPage);
			return result;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00008608 File Offset: 0x00006808
		private void CredentialsListBox_VisibleChanged(object sender, EventArgs e)
		{
			this.PopulateCredentialsListBoxIfChanged();
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00008610 File Offset: 0x00006810
		private void PopulateCredentialsListBoxIfChanged()
		{
			if (this._credentialsStoreChangeId != this._credentialsStore.ChangeId)
			{
				this.PopulateCredentialsListBox();
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00008630 File Offset: 0x00006830
		protected void PopulateCredentialsManagementTab(CredentialsStore store)
		{
			this._credentialsStore = store;
			this.PopulateCredentialsListBox();
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00008640 File Offset: 0x00006840
		private void PopulateCredentialsListBox()
		{
			this._credentialsListBox.Items.Clear();
			foreach (CredentialsProfile item in this._credentialsStore.Profiles)
			{
				this._credentialsListBox.Items.Add(item);
			}
			this._credentialsStoreChangeId = this._credentialsStore.ChangeId;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000086C8 File Offset: 0x000068C8
		private void AddButton_Click(object sender, EventArgs e)
		{
			using (AddCredentialsDialog addCredentialsDialog = new AddCredentialsDialog(base.AssociatedNode))
			{
				if (addCredentialsDialog.ShowDialog() == DialogResult.OK)
				{
					CredentialsProfile credentialsProfile = new CredentialsProfile(addCredentialsDialog.ProfileName, addCredentialsDialog.ProfileScope, addCredentialsDialog.UserName, addCredentialsDialog.Password.Value, addCredentialsDialog.Domain);
					if (!this._credentialsStore.Contains(credentialsProfile.ProfileName))
					{
						this._credentialsListBox.Items.Add(credentialsProfile);
					}
					this._credentialsStore[credentialsProfile.ProfileName] = credentialsProfile;
				}
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00008774 File Offset: 0x00006974
		private void EditButton_Click(object sender, EventArgs e)
		{
			int selectedIndex = this._credentialsListBox.SelectedIndex;
			if (selectedIndex == -1)
			{
				return;
			}
			CredentialsProfile credentialsProfile = this._credentialsListBox.Items[selectedIndex] as CredentialsProfile;
			using (LogonSettingsDialog logonSettingsDialog = LogonSettingsDialog.NewEditCredentialsDialog(credentialsProfile))
			{
				if (logonSettingsDialog.ShowDialog() == DialogResult.OK)
				{
					PasswordSetting password = logonSettingsDialog.PasswordChanged ? logonSettingsDialog.Password : credentialsProfile.Password;
					credentialsProfile = new CredentialsProfile(credentialsProfile.ProfileName, credentialsProfile.ProfileScope, logonSettingsDialog.UserName, password, logonSettingsDialog.Domain);
					this._credentialsStore[credentialsProfile.ProfileName] = credentialsProfile;
					this._credentialsListBox.Items[selectedIndex] = credentialsProfile;
				}
			}
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00008844 File Offset: 0x00006A44
		private void DeleteButton_Click(object sender, EventArgs e)
		{
			this.DeleteCredentials();
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0000884C File Offset: 0x00006A4C
		private void CredentialsListBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				e.Handled = true;
				this.DeleteCredentials();
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00008868 File Offset: 0x00006A68
		private void DeleteCredentials()
		{
			int selectedIndex = this._credentialsListBox.SelectedIndex;
			if (selectedIndex == -1)
			{
				return;
			}
			CredentialsProfile credentialsProfile = this._credentialsListBox.Items[selectedIndex] as CredentialsProfile;
			ICollection<string> credentialsInUseLocations = this.GetCredentialsInUseLocations(credentialsProfile);
			if (credentialsInUseLocations.Count > 0)
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.AppendLine(credentialsProfile.ProfileName + " is in use in these nodes:").AppendLine();
				foreach (string value in credentialsInUseLocations)
				{
					stringBuilder.AppendLine(value);
				}
				stringBuilder.AppendLine().AppendLine("Are you sure you want to delete it?");
				if (FormTools.YesNoDialog(stringBuilder.ToString()) != DialogResult.Yes)
				{
					return;
				}
			}
			this._credentialsStore.Remove(credentialsProfile.ProfileName);
			this._credentialsListBox.Items.RemoveAt(selectedIndex);
			this.RevertDeletedCredentials(credentialsProfile);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00008970 File Offset: 0x00006B70
		private ICollection<string> GetCredentialsInUseLocations(CredentialsProfile credentials)
		{
			HashSet<string> inUseLocations = new HashSet<string>();
			ICollection nodes;
			if (base.AssociatedNode.FileGroup != null)
			{
				nodes = new FileGroup[]
				{
					base.AssociatedNode.FileGroup
				};
			}
			else
			{
				nodes = ServerTree.Instance.Nodes;
			}
			foreach (TabPage tabPage in base.TabPages)
			{
				ICredentialsTabPage credentialsTabPage = tabPage as ICredentialsTabPage;
				if (credentialsTabPage != null && credentialsTabPage.Credentials == credentials)
				{
					inUseLocations.Add("{0}.{1}".InvariantFormat(new object[]
					{
						this.Text,
						tabPage.Text
					}));
				}
			}
			nodes.VisitNodes(delegate(RdcTreeNode node)
			{
				if (node is VirtualGroup)
				{
					return NodeVisitorResult.NoRecurse;
				}
				if (node.LogonCredentials.DirectlyReferences(credentials))
				{
					inUseLocations.Add("{0}.{1}".InvariantFormat(new object[]
					{
						node.FullPath,
						"Logon Credentials"
					}));
				}
				if (node.GatewaySettings.DirectlyReferences(credentials))
				{
					inUseLocations.Add("{0}.{1}".InvariantFormat(new object[]
					{
						node.FullPath,
						"Gateway Settings"
					}));
				}
				return NodeVisitorResult.Continue;
			});
			return inUseLocations;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00008A74 File Offset: 0x00006C74
		private void RevertDeletedCredentials(CredentialsProfile credentials)
		{
			ICollection nodes;
			if (base.AssociatedNode.FileGroup != null)
			{
				nodes = new FileGroup[]
				{
					base.AssociatedNode.FileGroup
				};
			}
			else
			{
				nodes = ServerTree.Instance.Nodes;
			}
			nodes.VisitNodes(delegate(RdcTreeNode node)
			{
				if (node is VirtualGroup)
				{
					return NodeVisitorResult.NoRecurse;
				}
				if (node.LogonCredentials.DirectlyReferences(credentials))
				{
					node.LogonCredentials.ProfileName.Reset();
				}
				if (node.GatewaySettings.DirectlyReferences(credentials))
				{
					node.GatewaySettings.ProfileName.Reset();
				}
				return NodeVisitorResult.Continue;
			});
		}

		// Token: 0x040000E5 RID: 229
		protected ListBox _credentialsListBox;

		// Token: 0x040000E6 RID: 230
		private CredentialsStore _credentialsStore;

		// Token: 0x040000E7 RID: 231
		private int _credentialsStoreChangeId;
	}
}
