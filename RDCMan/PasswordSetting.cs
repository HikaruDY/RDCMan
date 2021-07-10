using System;
using System.Xml;

namespace RdcMan
{
	// Token: 0x02000170 RID: 368
	public class PasswordSetting : BaseSetting<string>, IDeferDecryption
	{
		// Token: 0x06000986 RID: 2438 RVA: 0x00008009 File Offset: 0x00006209
		public PasswordSetting(object o) : base(o)
		{
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x00008012 File Offset: 0x00006212
		public void SetPlainText(string value)
		{
			this.Value = value;
			this.IsDecrypted = true;
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x00021294 File Offset: 0x0001F494
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

		// Token: 0x06000989 RID: 2441 RVA: 0x00021330 File Offset: 0x0001F530
		public override void WriteXml(XmlTextWriter tw, RdcTreeNode node)
		{
			string text = this.IsDecrypted ? Encryption.EncryptString(this.Value, node.EncryptionSettings) : this.Value;
			tw.WriteString(text);
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x00008022 File Offset: 0x00006222
		public override void Copy(ISetting source)
		{
			base.Copy(source);
			this.IsDecrypted = ((PasswordSetting)source).IsDecrypted;
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x0600098B RID: 2443 RVA: 0x0000803C File Offset: 0x0000623C
		// (set) Token: 0x0600098C RID: 2444 RVA: 0x00008044 File Offset: 0x00006244
		public bool IsDecrypted { get; set; }

		// Token: 0x0600098D RID: 2445 RVA: 0x0000804D File Offset: 0x0000624D
		public void Decrypt(EncryptionSettings settings)
		{
			this.Value = Encryption.DecryptString(this.Value, settings);
			this.IsDecrypted = true;
		}

		// Token: 0x04000656 RID: 1622
		private const string StoreAsClearTextAttribute = "storeAsClearText";
	}
}
