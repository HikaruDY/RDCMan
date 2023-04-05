using System;
using System.Xml;

namespace RdcMan
{
	// Token: 0x020000DA RID: 218
	public class PasswordSetting : BaseSetting<string>, IDeferDecryption
	{
		// Token: 0x060007EB RID: 2027 RVA: 0x00021D1C File Offset: 0x0001FF1C
		public PasswordSetting(object o) : base(o)
		{
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00021D28 File Offset: 0x0001FF28
		public void SetPlainText(string value)
		{
			this.Value = value;
			this.IsDecrypted = true;
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x00021D38 File Offset: 0x0001FF38
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

		// Token: 0x060007EE RID: 2030 RVA: 0x00021DEC File Offset: 0x0001FFEC
		public override void WriteXml(XmlTextWriter tw, RdcTreeNode node)
		{
			string text = this.IsDecrypted ? Encryption.EncryptString(this.Value, node.EncryptionSettings) : this.Value;
			tw.WriteString(text);
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x00021E2C File Offset: 0x0002002C
		public override void Copy(ISetting source)
		{
			base.Copy(source);
			this.IsDecrypted = ((PasswordSetting)source).IsDecrypted;
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060007F0 RID: 2032 RVA: 0x00021E48 File Offset: 0x00020048
		// (set) Token: 0x060007F1 RID: 2033 RVA: 0x00021E50 File Offset: 0x00020050
		public bool IsDecrypted { get; set; }

		// Token: 0x060007F2 RID: 2034 RVA: 0x00021E5C File Offset: 0x0002005C
		public void Decrypt(EncryptionSettings settings)
		{
			this.Value = Encryption.DecryptString(this.Value, settings);
			this.IsDecrypted = true;
		}

		// Token: 0x04000339 RID: 825
		private const string StoreAsClearTextAttribute = "storeAsClearText";
	}
}
