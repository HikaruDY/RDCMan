using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x0200005B RID: 91
	internal abstract partial class GroupBasePropertiesDialog : NodePropertiesDialog
	{
		// Token: 0x06000182 RID: 386 RVA: 0x00002CE9 File Offset: 0x00000EE9
		protected GroupBasePropertiesDialog(GroupBase group, string dialogTitle, string acceptButtonText, Form parentForm) : base(group, dialogTitle, acceptButtonText, parentForm)
		{
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000DB3C File Offset: 0x0000BD3C
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

		// Token: 0x06000184 RID: 388 RVA: 0x00002CF6 File Offset: 0x00000EF6
		private void CredentialsListBox_VisibleChanged(object sender, EventArgs e)
		{
			this.PopulateCredentialsListBoxIfChanged();
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00002CFE File Offset: 0x00000EFE
		private void PopulateCredentialsListBoxIfChanged()
		{
			if (this._credentialsStoreChangeId != this._credentialsStore.ChangeId)
			{
				this.PopulateCredentialsListBox();
			}
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00002D19 File Offset: 0x00000F19
		protected void PopulateCredentialsManagementTab(CredentialsStore store)
		{
			this._credentialsStore = store;
			this.PopulateCredentialsListBox();
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0000DCEC File Offset: 0x0000BEEC
		private void PopulateCredentialsListBox()
		{
			this._credentialsListBox.Items.Clear();
			foreach (CredentialsProfile item in this._credentialsStore.Profiles)
			{
				this._credentialsListBox.Items.Add(item);
			}
			this._credentialsStoreChangeId = this._credentialsStore.ChangeId;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000DD6C File Offset: 0x0000BF6C
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

		// Token: 0x06000189 RID: 393 RVA: 0x0000DE0C File Offset: 0x0000C00C
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

		// Token: 0x0600018A RID: 394 RVA: 0x00002D28 File Offset: 0x00000F28
		private void DeleteButton_Click(object sender, EventArgs e)
		{
			this.DeleteCredentials();
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002D30 File Offset: 0x00000F30
		private void CredentialsListBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				e.Handled = true;
				this.DeleteCredentials();
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000DEC8 File Offset: 0x0000C0C8
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

		// Token: 0x0600018D RID: 397 RVA: 0x0000DFBC File Offset: 0x0000C1BC
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

		// Token: 0x0600018E RID: 398 RVA: 0x0000E0AC File Offset: 0x0000C2AC
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

		// Token: 0x040002D8 RID: 728
		protected ListBox _credentialsListBox;

		// Token: 0x040002D9 RID: 729
		private CredentialsStore _credentialsStore;

		// Token: 0x040002DA RID: 730
		private int _credentialsStoreChangeId;
	}
}
