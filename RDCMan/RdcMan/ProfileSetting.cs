using System;
using System.Xml;

namespace RdcMan
{
	// Token: 0x020000DB RID: 219
	public class ProfileSetting : StringSetting
	{
		// Token: 0x060007F3 RID: 2035 RVA: 0x00021E78 File Offset: 0x00020078
		public ProfileSetting(object o) : base(o)
		{
			this.Reset();
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00021E88 File Offset: 0x00020088
		public override void ReadXml(XmlNode xmlNode, RdcTreeNode node)
		{
			base.ReadXml(xmlNode, node);
			try
			{
				XmlNode namedItem = xmlNode.Attributes.GetNamedItem("scope");
				this.Scope = namedItem.InnerText.ParseEnum<ProfileScope>();
			}
			catch
			{
				this.Scope = ProfileScope.Local;
			}
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00021EE4 File Offset: 0x000200E4
		public override void WriteXml(XmlTextWriter tw, RdcTreeNode node)
		{
			tw.WriteAttributeString("scope", this.Scope.ToString());
			tw.WriteString(base.Value);
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00021F20 File Offset: 0x00020120
		public override void Copy(ISetting source)
		{
			base.Copy(source);
			this.Scope = ((ProfileSetting)source).Scope;
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00021F3C File Offset: 0x0002013C
		public override string ToString()
		{
			return "{0} ({1})".InvariantFormat(new object[]
			{
				base.Value,
				this.Scope
			});
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x00021F74 File Offset: 0x00020174
		public void UpdateValue(string newValue, ProfileScope newScope)
		{
			base.Value = newValue;
			this.Scope = newScope;
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00021F84 File Offset: 0x00020184
		public void Reset()
		{
			this.Scope = ProfileScope.Local;
			base.Value = "Custom";
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x00021F98 File Offset: 0x00020198
		// (set) Token: 0x060007FB RID: 2043 RVA: 0x00021FA0 File Offset: 0x000201A0
		public ProfileScope Scope { get; private set; }

		// Token: 0x0400033B RID: 827
		public const string ProfileScopeAttribute = "scope";
	}
}
