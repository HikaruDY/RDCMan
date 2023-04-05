using System;
using System.Collections.Generic;
using System.Xml;

namespace RdcMan
{
	// Token: 0x02000029 RID: 41
	public class CredentialsStore
	{
		// Token: 0x060000DF RID: 223 RVA: 0x000051E8 File Offset: 0x000033E8
		public CredentialsStore()
		{
			this._profiles = new Dictionary<string, CredentialsProfile>(StringComparer.OrdinalIgnoreCase);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00005200 File Offset: 0x00003400
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

		// Token: 0x060000E1 RID: 225 RVA: 0x000052B8 File Offset: 0x000034B8
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

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00005380 File Offset: 0x00003580
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x00005388 File Offset: 0x00003588
		public int ChangeId { get; private set; }

		// Token: 0x17000020 RID: 32
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

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x000053D4 File Offset: 0x000035D4
		public IEnumerable<CredentialsProfile> Profiles
		{
			get
			{
				return this._profiles.Values;
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000053E4 File Offset: 0x000035E4
		public bool TryGetValue(string name, out CredentialsProfile profile)
		{
			return this._profiles.TryGetValue(name, out profile);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000053F4 File Offset: 0x000035F4
		public void Remove(string name)
		{
			this._profiles.Remove(name);
			int changeId = this.ChangeId;
			this.ChangeId = changeId + 1;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00005424 File Offset: 0x00003624
		public bool Contains(string name)
		{
			return this._profiles.ContainsKey(name);
		}

		// Token: 0x040000A8 RID: 168
		public const string XmlNodeName = "credentialsProfiles";

		// Token: 0x040000A9 RID: 169
		public const string ProfileXmlNodeName = "credentialsProfile";

		// Token: 0x040000AA RID: 170
		private readonly Dictionary<string, CredentialsProfile> _profiles;
	}
}
