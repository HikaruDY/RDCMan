using System;
using System.Xml;

namespace RdcMan
{
	public class PasswordSetting : BaseSetting<string>, IDeferDecryption
	{
		public PasswordSetting(object o) : base(o)
		{
		}

		public void SetPlainText(string value)
		{
			this.Value = value;
			this.IsDecrypted = true;
		}

		public override void ReadXml(XmlNode xmlNode, RdcTreeNode node)
		{
			XmlNode firstChild = xmlNode.FirstChild;
			if (firstChild == null)
			{
				this.Value = string.Empty;
			}
			else
			{
				this.Value = firstChild.InnerText;
			}
			try
			{
				XmlNode xmlNode2 = xmlNode.Attributes["storeAsClearText"];
				if (xmlNode2 != null && bool.Parse(xmlNode2.InnerText))
				{
					node.Password.IsDecrypted = true;
				}
				else if (xmlNode.ParentNode.Name != "credentialsProfile")
				{
					Encryption.DeferDecryption(this, node, xmlNode.GetFullPath());
				}
			}
			catch
			{
			}
		}

		public override void WriteXml(XmlTextWriter tw, RdcTreeNode node)
		{
			string text = this.IsDecrypted ? Encryption.EncryptString(this.Value, node.EncryptionSettings) : this.Value;
			tw.WriteString(text);
		}

		public override void Copy(ISetting source)
		{
			base.Copy(source);
			this.IsDecrypted = ((PasswordSetting)source).IsDecrypted;
		}

		public bool IsDecrypted { get; set; }

		public void Decrypt(EncryptionSettings settings)
		{
			this.Value = Encryption.DecryptString(this.Value, settings);
			this.IsDecrypted = true;
		}

		private const string StoreAsClearTextAttribute = "storeAsClearText";
	}
}
