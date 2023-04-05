using System;
using System.Xml;

namespace RdcMan
{
	public class ProfileSetting : StringSetting
	{
		public ProfileSetting(object o) : base(o)
		{
			this.Reset();
		}

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

		public override void WriteXml(XmlTextWriter tw, RdcTreeNode node)
		{
			tw.WriteAttributeString("scope", this.Scope.ToString());
			tw.WriteString(base.Value);
		}

		public override void Copy(ISetting source)
		{
			base.Copy(source);
			this.Scope = ((ProfileSetting)source).Scope;
		}

		public override string ToString()
		{
			return "{0} ({1})".InvariantFormat(new object[]
			{
				base.Value,
				this.Scope
			});
		}

		public void UpdateValue(string newValue, ProfileScope newScope)
		{
			base.Value = newValue;
			this.Scope = newScope;
		}

		public void Reset()
		{
			this.Scope = ProfileScope.Local;
			base.Value = "Custom";
		}

		public ProfileScope Scope { get; private set; }

		public const string ProfileScopeAttribute = "scope";
	}
}
