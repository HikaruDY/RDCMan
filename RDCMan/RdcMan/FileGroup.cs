using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	// Token: 0x02000075 RID: 117
	public class FileGroup : GroupBase
	{
		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000367 RID: 871 RVA: 0x00012F84 File Offset: 0x00011184
		// (set) Token: 0x06000368 RID: 872 RVA: 0x00012F8C File Offset: 0x0001118C
		public override EncryptionSettings EncryptionSettings { get; protected set; }

		// Token: 0x06000369 RID: 873 RVA: 0x00012F98 File Offset: 0x00011198
		static FileGroup()
		{
			FileGroup.NodeActions["credentialsProfiles"] = delegate(XmlNode childNode, RdcTreeNode parent, ICollection<string> errors)
			{
				(parent as FileGroup).CredentialsProfiles.ReadXml(childNode, ProfileScope.File, parent, errors);
			};
			ServerTree.Instance.GroupChanged += FileGroup.OnGroupChanged;
			ServerTree.Instance.ServerChanged += FileGroup.OnServerChanged;
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00013004 File Offset: 0x00011204
		private static void OnServerChanged(ServerChangedEventArgs e)
		{
			if (e.ChangeType.HasFlag(ChangeType.TreeChanged) || e.ChangeType.HasFlag(ChangeType.PropertyChanged))
			{
				FileGroup fileGroup = e.Server.FileGroup;
				if (fileGroup != null)
				{
					fileGroup.HasChangedSinceWrite = true;
				}
			}
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00013064 File Offset: 0x00011264
		private static void OnGroupChanged(GroupChangedEventArgs e)
		{
			if (e.ChangeType.HasFlag(ChangeType.TreeChanged) || e.ChangeType.HasFlag(ChangeType.PropertyChanged))
			{
				FileGroup fileGroup = e.Group.FileGroup;
				if (fileGroup != null)
				{
					fileGroup.HasChangedSinceWrite = true;
				}
			}
		}

		// Token: 0x0600036C RID: 876 RVA: 0x000130C4 File Offset: 0x000112C4
		internal FileGroup(string pathname)
		{
			this.Pathname = Path.GetFullPath(pathname);
			if (File.Exists(this.Pathname))
			{
				base.IsReadOnly = File.GetAttributes(this.Pathname).HasFlag(FileAttributes.ReadOnly);
			}
			else
			{
				base.Properties.GroupName.Value = Path.GetFileNameWithoutExtension(this.Pathname);
				base.Text = base.Properties.GroupName.Value;
			}
			base.ToolTipText = pathname;
			this.ChangeImageIndex(ImageConstants.File);
			this.CredentialsProfiles = new CredentialsStore();
			this.EncryptionSettings = new EncryptionSettings();
			base.AllSettingsGroups.Add(this.EncryptionSettings);
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600036D RID: 877 RVA: 0x00013184 File Offset: 0x00011384
		// (set) Token: 0x0600036E RID: 878 RVA: 0x0001318C File Offset: 0x0001138C
		internal new int SchemaVersion { get; set; }

		// Token: 0x0600036F RID: 879 RVA: 0x00013198 File Offset: 0x00011398
		public string GetFilename()
		{
			return Path.GetFileName(this.Pathname);
		}

		// Token: 0x06000370 RID: 880 RVA: 0x000131A8 File Offset: 0x000113A8
		public string GetDirectory()
		{
			return Path.GetDirectoryName(this.Pathname);
		}

		// Token: 0x06000371 RID: 881 RVA: 0x000131B8 File Offset: 0x000113B8
		protected override void InitSettings()
		{
			base.Properties = new FileGroupSettings();
			base.InitSettings();
		}

		// Token: 0x06000372 RID: 882 RVA: 0x000131CC File Offset: 0x000113CC
		internal override void ReadXml(XmlNode xmlNode, ICollection<string> errors)
		{
			base.ReadXml(FileGroup.NodeActions, xmlNode, errors);
			base.Text = base.Properties.GroupName.Value;
			if (base.IsReadOnly)
			{
				base.Text += " {RO}";
			}
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00013224 File Offset: 0x00011424
		internal override void WriteXml(XmlTextWriter tw)
		{
			tw.WriteStartElement("file");
			this.CredentialsProfiles.WriteXml(tw, this);
			base.WriteXml(tw);
			tw.WriteEndElement();
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0001325C File Offset: 0x0001145C
		public sealed override bool ConfirmRemove(bool askUser)
		{
			FormTools.InformationDialog("Use the File menu to close the " + base.Text + " group");
			return false;
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0001327C File Offset: 0x0001147C
		public override void DoPropertiesDialog(Form parentForm, string activeTabName)
		{
			using (FileGroupPropertiesDialog fileGroupPropertiesDialog = FileGroupPropertiesDialog.NewPropertiesDialog(this, parentForm))
			{
				fileGroupPropertiesDialog.SetActiveTab(activeTabName);
				if (fileGroupPropertiesDialog.ShowDialog() == DialogResult.OK)
				{
					this.UpdateSettings(fileGroupPropertiesDialog);
					ServerTree.Instance.OnNodeChanged(this, ChangeType.PropertyChanged);
				}
			}
		}

		// Token: 0x06000376 RID: 886 RVA: 0x000132E0 File Offset: 0x000114E0
		internal void CheckCredentials()
		{
			Dictionary<string, List<string>> missingProfiles = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);
			this.VisitNodes(delegate(RdcTreeNode node)
			{
				this.CheckCredentials(node, node.LogonCredentials, "Logon Credentials", missingProfiles);
				this.CheckCredentials(node, node.GatewaySettings, "Gateway Settings", missingProfiles);
			});
			if (missingProfiles.Count > 0)
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.AppendLine("Some credential profiles were not found.").AppendLine("Please add the missing profiles before connecting to servers, edit properties, etc. otherwise the reference will be lost.").AppendLine("Click OK to copy the details to the clipboard.").AppendLine();
				foreach (KeyValuePair<string, List<string>> keyValuePair in missingProfiles)
				{
					stringBuilder.AppendLine("Profile name: " + keyValuePair.Key);
					stringBuilder.AppendFormat("Referenced by: ", Array.Empty<object>());
					foreach (string str in keyValuePair.Value)
					{
						stringBuilder.Append(" " + str);
					}
					stringBuilder.AppendLine().AppendLine();
				}
				DialogResult dialogResult = FormTools.ExclamationDialog(stringBuilder.ToString(), MessageBoxButtons.OKCancel);
				if (dialogResult == DialogResult.OK)
				{
					Clipboard.SetText(stringBuilder.ToString());
				}
			}
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00013450 File Offset: 0x00011650
		private void CheckCredentials(RdcTreeNode node, LogonCredentials credentials, string name, Dictionary<string, List<string>> missingProfiles)
		{
			if (credentials != null && credentials.InheritSettingsType.Mode != InheritanceMode.FromParent && !node.ResolveCredentials(credentials))
			{
				string key = LogonCredentials.ConstructQualifiedName(credentials);
				List<string> list;
				if (!missingProfiles.TryGetValue(key, out list))
				{
					list = (missingProfiles[key] = new List<string>());
				}
				list.Add(string.Format("{0}.{1}", node.FullPath, name));
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000378 RID: 888 RVA: 0x000134C4 File Offset: 0x000116C4
		// (set) Token: 0x06000379 RID: 889 RVA: 0x000134CC File Offset: 0x000116CC
		public CredentialsStore CredentialsProfiles { get; private set; }

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600037A RID: 890 RVA: 0x000134D8 File Offset: 0x000116D8
		// (set) Token: 0x0600037B RID: 891 RVA: 0x000134E0 File Offset: 0x000116E0
		public bool HasChangedSinceWrite { get; set; }

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600037C RID: 892 RVA: 0x000134EC File Offset: 0x000116EC
		// (set) Token: 0x0600037D RID: 893 RVA: 0x000134F4 File Offset: 0x000116F4
		public string Pathname { get; set; }

		// Token: 0x0400019A RID: 410
		internal const string XmlNodeName = "file";

		// Token: 0x0400019C RID: 412
		protected new static Dictionary<string, Helpers.ReadXmlDelegate> NodeActions = new Dictionary<string, Helpers.ReadXmlDelegate>(GroupBase.NodeActions);
	}
}
