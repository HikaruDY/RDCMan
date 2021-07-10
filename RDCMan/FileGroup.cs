using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	// Token: 0x020000BF RID: 191
	public class FileGroup : GroupBase
	{
		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x00004652 File Offset: 0x00002852
		// (set) Token: 0x06000447 RID: 1095 RVA: 0x0000465A File Offset: 0x0000285A
		public override EncryptionSettings EncryptionSettings { get; protected set; }

		// Token: 0x06000448 RID: 1096 RVA: 0x00016F4C File Offset: 0x0001514C
		static FileGroup()
		{
			FileGroup.NodeActions["credentialsProfiles"] = delegate(XmlNode childNode, RdcTreeNode parent, ICollection<string> errors)
			{
				(parent as FileGroup).CredentialsProfiles.ReadXml(childNode, ProfileScope.File, parent, errors);
			};
			ServerTree.Instance.GroupChanged += FileGroup.OnGroupChanged;
			ServerTree.Instance.ServerChanged += FileGroup.OnServerChanged;
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00016FB4 File Offset: 0x000151B4
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

		// Token: 0x0600044A RID: 1098 RVA: 0x00017008 File Offset: 0x00015208
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

		// Token: 0x0600044B RID: 1099 RVA: 0x0001705C File Offset: 0x0001525C
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

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x00004663 File Offset: 0x00002863
		// (set) Token: 0x0600044D RID: 1101 RVA: 0x0000466B File Offset: 0x0000286B
		internal new int SchemaVersion { get; set; }

		// Token: 0x0600044E RID: 1102 RVA: 0x00004674 File Offset: 0x00002874
		public string GetFilename()
		{
			return Path.GetFileName(this.Pathname);
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00004681 File Offset: 0x00002881
		public string GetDirectory()
		{
			return Path.GetDirectoryName(this.Pathname);
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0000468E File Offset: 0x0000288E
		protected override void InitSettings()
		{
			base.Properties = new FileGroupSettings();
			base.InitSettings();
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00017114 File Offset: 0x00015314
		internal override void ReadXml(XmlNode xmlNode, ICollection<string> errors)
		{
			base.ReadXml(FileGroup.NodeActions, xmlNode, errors);
			base.Text = base.Properties.GroupName.Value;
			if (base.IsReadOnly)
			{
				base.Text += " {RO}";
			}
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x000046A1 File Offset: 0x000028A1
		internal override void WriteXml(XmlTextWriter tw)
		{
			tw.WriteStartElement("file");
			this.CredentialsProfiles.WriteXml(tw, this);
			base.WriteXml(tw);
			tw.WriteEndElement();
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x000046C8 File Offset: 0x000028C8
		public sealed override bool ConfirmRemove(bool askUser)
		{
			FormTools.InformationDialog("Use the File menu to close the " + base.Text + " group");
			return false;
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00017164 File Offset: 0x00015364
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

		// Token: 0x06000455 RID: 1109 RVA: 0x000171BC File Offset: 0x000153BC
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

		// Token: 0x06000456 RID: 1110 RVA: 0x0001731C File Offset: 0x0001551C
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

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x000046E5 File Offset: 0x000028E5
		// (set) Token: 0x06000458 RID: 1112 RVA: 0x000046ED File Offset: 0x000028ED
		public CredentialsStore CredentialsProfiles { get; private set; }

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x000046F6 File Offset: 0x000028F6
		// (set) Token: 0x0600045A RID: 1114 RVA: 0x000046FE File Offset: 0x000028FE
		public bool HasChangedSinceWrite { get; set; }

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x00004707 File Offset: 0x00002907
		// (set) Token: 0x0600045C RID: 1116 RVA: 0x0000470F File Offset: 0x0000290F
		public string Pathname { get; set; }

		// Token: 0x04000410 RID: 1040
		internal const string XmlNodeName = "file";

		// Token: 0x04000412 RID: 1042
		protected new static Dictionary<string, Helpers.ReadXmlDelegate> NodeActions = new Dictionary<string, Helpers.ReadXmlDelegate>(GroupBase.NodeActions);
	}
}
