using System;
using System.Collections.Generic;
using System.Xml;

namespace RdcMan
{
	public class CredentialsStore
	{
		public CredentialsStore()
		{
			this._profiles = new Dictionary<string, CredentialsProfile>(StringComparer.OrdinalIgnoreCase);
		}

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

		public int ChangeId { get; private set; }

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

		public IEnumerable<CredentialsProfile> Profiles
		{
			get
			{
				return this._profiles.Values;
			}
		}

		public bool TryGetValue(string name, out CredentialsProfile profile)
		{
			return this._profiles.TryGetValue(name, out profile);
		}

		public void Remove(string name)
		{
			this._profiles.Remove(name);
			int changeId = this.ChangeId;
			this.ChangeId = changeId + 1;
		}

		public bool Contains(string name)
		{
			return this._profiles.ContainsKey(name);
		}

		public const string XmlNodeName = "credentialsProfiles";

		public const string ProfileXmlNodeName = "credentialsProfile";

		private readonly Dictionary<string, CredentialsProfile> _profiles;
	}
}
