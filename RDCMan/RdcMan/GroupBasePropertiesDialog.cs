using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RdcMan
{
	internal abstract partial class GroupBasePropertiesDialog : NodePropertiesDialog
	{
		protected GroupBasePropertiesDialog(GroupBase group, string dialogTitle, string acceptButtonText, Form parentForm) : base(group, dialogTitle, acceptButtonText, parentForm)
		{
		}

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

		private void CredentialsListBox_VisibleChanged(object sender, EventArgs e)
		{
			this.PopulateCredentialsListBoxIfChanged();
		}

		private void PopulateCredentialsListBoxIfChanged()
		{
			if (this._credentialsStoreChangeId != this._credentialsStore.ChangeId)
			{
				this.PopulateCredentialsListBox();
			}
		}

		protected void PopulateCredentialsManagementTab(CredentialsStore store)
		{
			this._credentialsStore = store;
			this.PopulateCredentialsListBox();
		}

		private void PopulateCredentialsListBox()
		{
			this._credentialsListBox.Items.Clear();
			foreach (CredentialsProfile item in this._credentialsStore.Profiles)
			{
				this._credentialsListBox.Items.Add(item);
			}
			this._credentialsStoreChangeId = this._credentialsStore.ChangeId;
		}

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

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			this.DeleteCredentials();
		}

		private void CredentialsListBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				e.Handled = true;
				this.DeleteCredentials();
			}
		}

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

		protected ListBox _credentialsListBox;

		private CredentialsStore _credentialsStore;

		private int _credentialsStoreChangeId;
	}
}
