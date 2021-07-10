using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Xml;

namespace RdcMan
{
	// Token: 0x020000D4 RID: 212
	public class Rule
	{
		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x00004D7C File Offset: 0x00002F7C
		// (set) Token: 0x060004F0 RID: 1264 RVA: 0x00004D84 File Offset: 0x00002F84
		public RuleProperty Property { get; private set; }

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x00004D8D File Offset: 0x00002F8D
		// (set) Token: 0x060004F2 RID: 1266 RVA: 0x00004D95 File Offset: 0x00002F95
		public RuleOperator Operator { get; private set; }

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x00004D9E File Offset: 0x00002F9E
		// (set) Token: 0x060004F4 RID: 1268 RVA: 0x00004DA6 File Offset: 0x00002FA6
		public object Value { get; private set; }

		// Token: 0x060004F5 RID: 1269 RVA: 0x00004DAF File Offset: 0x00002FAF
		public Rule(RuleProperty property, RuleOperator operation, object value)
		{
			this.Property = property;
			this.Operator = operation;
			this.Value = value;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00002084 File Offset: 0x00000284
		protected Rule()
		{
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00018104 File Offset: 0x00016304
		public static Rule Create(XmlNode xmlNode, RdcTreeNode node, ICollection<string> errors)
		{
			Rule rule = new Rule();
			rule.ReadXml(xmlNode, node, errors);
			return rule;
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00018124 File Offset: 0x00016324
		public bool Evaluate(Server server)
		{
			bool flag;
			object obj = this.Property.GetValue(server, out flag);
			if (obj == null)
			{
				obj = string.Empty;
			}
			return Regex.IsMatch((string)obj, (string)this.Value, RegexOptions.IgnoreCase) ^ this.Operator == RuleOperator.DoesNotMatch;
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0001816C File Offset: 0x0001636C
		public void ReadXml(XmlNode xmlNode, RdcTreeNode node, ICollection<string> errors)
		{
			foreach (object obj in xmlNode.ChildNodes)
			{
				XmlNode xmlNode2 = (XmlNode)obj;
				string name = xmlNode2.Name;
				if (!(name == "property"))
				{
					if (!(name == "operator"))
					{
						if (!(name == "value"))
						{
							throw new NotImplementedException();
						}
						this.Value = xmlNode2.InnerText;
					}
					else
					{
						this.Operator = xmlNode2.InnerText.ParseEnum<RuleOperator>();
					}
				}
				else
				{
					this.Property = new RuleProperty(xmlNode2.InnerText.ParseEnum<ServerProperty>());
				}
			}
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00018230 File Offset: 0x00016430
		public void WriteXml(XmlTextWriter tw)
		{
			tw.WriteStartElement("rule");
			tw.WriteElementString("property", this.Property.ServerProperty.ToString());
			tw.WriteElementString("operator", this.Operator.ToString());
			tw.WriteElementString("value", this.Value.ToString());
			tw.WriteEndElement();
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00004DCC File Offset: 0x00002FCC
		public override string ToString()
		{
			return "{0} {1} {2}".InvariantFormat(new object[]
			{
				this.Property.ServerProperty,
				this.Operator,
				this.Value
			});
		}

		// Token: 0x0400044E RID: 1102
		public const string XmlNodeName = "rule";

		// Token: 0x0400044F RID: 1103
		private const string PropertyXmlNodeName = "property";

		// Token: 0x04000450 RID: 1104
		private const string OperatorXmlNodeName = "operator";

		// Token: 0x04000451 RID: 1105
		private const string ValueXmlNodeName = "value";
	}
}
