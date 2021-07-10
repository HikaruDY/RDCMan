using System;
using System.Collections.Generic;
using System.Xml;

namespace RdcMan
{
	// Token: 0x02000044 RID: 68
	public class CredentialsStore
	{
		// Token: 0x060000F7 RID: 247 RVA: 0x000028A6 File Offset: 0x00000AA6
		public CredentialsStore()
		{
			this._profiles = new Dictionary<string, CredentialsProfile>(StringComparer.OrdinalIgnoreCase);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000AE5C File Offset: 0x0000905C
		public void ReadXml(XmlNode xmlNode, ProfileScope scope, RdcTreeNode node, ICollection<string> errors)
		{
			foreach (object obj in xmlNode.ChildNodes)
			{
				XmlNode xmlNode2 = (XmlNode)obj;
				LogonCredentials logonCredentials = new LogonCredentials("", "credentialsProfile");
				logonCredentials.ReadXml(xmlNode2, node, errors);
				ILogonCredentials logonCredentials2 = logonCredentials;
				CredentialsProfile credentialsProfile = new CredentialsProfile(logonCredentials2.ProfileName, scope, logonCredentials2.UserName, logonCredentials2.Password, logonCredentials2.Domain);
				this[logonCredentials2.ProfileName] = credentialsProfile;
				Encryption.DeferDecryption(credentialsProfile, node, credentialsProfile.QualifiedName);
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000AF0C File Offset: 0x0000910C
		public void WriteXml(XmlTextWriter tw, RdcTreeNode node)
		{
			tw.WriteStartElement("credentialsProfiles");
			foreach (ILogonCredentials logonCredentials in this.Profiles)
			{
				LogonCredentials logonCredentials2 = new LogonCredentials("", "credentialsProfile")
				{
					InheritSettingsType = 
					{
						Mode = InheritanceMode.None
					},
					ProfileName = 
					{
						Value = logonCredentials.ProfileName
					}
				};
				logonCredentials2.UserName.Value = logonCredentials.UserName;
				logonCredentials2.Password.Copy(logonCredentials.Password);
				logonCredentials2.Domain.Value = logonCredentials.Domain;
				logonCredentials2.WriteXml(tw, node);
			}
			tw.WriteEndElement();
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000FA RID: 250 RVA: 0x000028BE File Offset: 0x00000ABE
		// (set) Token: 0x060000FB RID: 251 RVA: 0x000028C6 File Offset: 0x00000AC6
		public int ChangeId { get; private set; }

		// Token: 0x17000022 RID: 34
		public CredentialsProfile this[string name]
		{
			get
			{
				return this._profiles[name];
			}
			set
			{
				this._profiles[name] = value;
				int changeId = this.ChangeId;
				this.ChangeId = changeId + 1;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000FE RID: 254 RVA: 0x000028DD File Offset: 0x00000ADD
		public IEnumerable<CredentialsProfile> Profiles
		{
			get
			{
				return this._profiles.Values;
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000028EA File Offset: 0x00000AEA
		public bool TryGetValue(string name, out CredentialsProfile profile)
		{
			return this._profiles.TryGetValue(name, out profile);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000AFF8 File Offset: 0x000091F8
		public void Remove(string name)
		{
			this._profiles.Remove(name);
			int changeId = this.ChangeId;
			this.ChangeId = changeId + 1;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000028F9 File Offset: 0x00000AF9
		public bool Contains(string name)
		{
			return this._profiles.ContainsKey(name);
		}

		// Token: 0x04000283 RID: 643
		public const string XmlNodeName = "credentialsProfiles";

		// Token: 0x04000284 RID: 644
		public const string ProfileXmlNodeName = "credentialsProfile";

		// Token: 0x04000285 RID: 645
		private readonly Dictionary<string, CredentialsProfile> _profiles;
	}
}
