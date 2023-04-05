using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	public class FileGroup : GroupBase
	{
		public override EncryptionSettings EncryptionSettings { get; protected set; }

		static FileGroup()
		{
			FileGroup.NodeActions["credentialsProfiles"] = delegate(XmlNode childNode, RdcTreeNode parent, ICollection<string> errors)
			{
				(parent as FileGroup).CredentialsProfiles.ReadXml(childNode, ProfileScope.File, parent, errors);
			};
			ServerTree.Instance.GroupChanged += FileGroup.OnGroupChanged;
			ServerTree.Instance.ServerChanged += FileGroup.OnServerChanged;
		}

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

		internal new int SchemaVersion { get; set; }

		public string GetFilename()
		{
			return Path.GetFileName(this.Pathname);
		}

		public string GetDirectory()
		{
			return Path.GetDirectoryName(this.Pathname);
		}

		protected override void InitSettings()
		{
			base.Properties = new FileGroupSettings();
			base.InitSettings();
		}

		internal override void ReadXml(XmlNode xmlNode, ICollection<string> errors)
		{
			base.ReadXml(FileGroup.NodeActions, xmlNode, errors);
			base.Text = base.Properties.GroupName.Value;
			if (base.IsReadOnly)
			{
				base.Text += " {RO}";
			}
		}

		internal override void WriteXml(XmlTextWriter tw)
		{
			tw.WriteStartElement("file");
			this.CredentialsProfiles.WriteXml(tw, this);
			base.WriteXml(tw);
			tw.WriteEndElement();
		}

		public sealed override bool ConfirmRemove(bool askUser)
		{
			FormTools.InformationDialog("Use the File menu to close the " + base.Text + " group");
			return false;
		}

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

		public CredentialsStore CredentialsProfiles { get; private set; }

		public bool HasChangedSinceWrite { get; set; }

		public string Pathname { get; set; }

		internal const string XmlNodeName = "file";

		protected new static Dictionary<string, Helpers.ReadXmlDelegate> NodeActions = new Dictionary<string, Helpers.ReadXmlDelegate>(GroupBase.NodeActions);
	}
}
