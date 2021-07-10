using System;
using System.Xml;

namespace RdcMan
{
	// Token: 0x02000171 RID: 369
	public class ProfileSetting : StringSetting
	{
		// Token: 0x0600098E RID: 2446 RVA: 0x00008068 File Offset: 0x00006268
		public ProfileSetting(object o) : base(o)
		{
			this.Reset();
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x00021368 File Offset: 0x0001F568
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

		// Token: 0x06000990 RID: 2448 RVA: 0x000213BC File Offset: 0x0001F5BC
		public override void WriteXml(XmlTextWriter tw, RdcTreeNode node)
		{
			tw.WriteAttributeString("scope", this.Scope.ToString());
			tw.WriteString(base.Value);
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x00008077 File Offset: 0x00006277
		public override void Copy(ISetting source)
		{
			base.Copy(source);
			this.Scope = ((ProfileSetting)source).Scope;
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x00008091 File Offset: 0x00006291
		public override string ToString()
		{
			return "{0} ({1})".InvariantFormat(new object[]
			{
				base.Value,
				this.Scope
			});
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x000080BA File Offset: 0x000062BA
		public void UpdateValue(string newValue, ProfileScope newScope)
		{
			base.Value = newValue;
			this.Scope = newScope;
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x000080CA File Offset: 0x000062CA
		public void Reset()
		{
			this.Scope = ProfileScope.Local;
			base.Value = "Custom";
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000995 RID: 2453 RVA: 0x000080DE File Offset: 0x000062DE
		// (set) Token: 0x06000996 RID: 2454 RVA: 0x000080E6 File Offset: 0x000062E6
		public ProfileScope Scope { get; private set; }

		// Token: 0x04000658 RID: 1624
		public const string ProfileScopeAttribute = "scope";
	}
}
