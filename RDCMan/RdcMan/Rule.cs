using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Xml;

namespace RdcMan
{
	// Token: 0x02000081 RID: 129
	public class Rule
	{
		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x00014774 File Offset: 0x00012974
		// (set) Token: 0x060003EC RID: 1004 RVA: 0x0001477C File Offset: 0x0001297C
		public RuleProperty Property { get; private set; }

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x00014788 File Offset: 0x00012988
		// (set) Token: 0x060003EE RID: 1006 RVA: 0x00014790 File Offset: 0x00012990
		public RuleOperator Operator { get; private set; }

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x0001479C File Offset: 0x0001299C
		// (set) Token: 0x060003F0 RID: 1008 RVA: 0x000147A4 File Offset: 0x000129A4
		public object Value { get; private set; }

		// Token: 0x060003F1 RID: 1009 RVA: 0x000147B0 File Offset: 0x000129B0
		public Rule(RuleProperty property, RuleOperator operation, object value)
		{
			this.Property = property;
			this.Operator = operation;
			this.Value = value;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x000147DC File Offset: 0x000129DC
		protected Rule()
		{
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x000147E4 File Offset: 0x000129E4
		public static Rule Create(XmlNode xmlNode, RdcTreeNode node, ICollection<string> errors)
		{
			Rule rule = new Rule();
			rule.ReadXml(xmlNode, node, errors);
			return rule;
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00014808 File Offset: 0x00012A08
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

		// Token: 0x060003F5 RID: 1013 RVA: 0x00014858 File Offset: 0x00012A58
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

		// Token: 0x060003F6 RID: 1014 RVA: 0x0001493C File Offset: 0x00012B3C
		public void WriteXml(XmlTextWriter tw)
		{
			tw.WriteStartElement("rule");
			tw.WriteElementString("property", this.Property.ServerProperty.ToString());
			tw.WriteElementString("operator", this.Operator.ToString());
			tw.WriteElementString("value", this.Value.ToString());
			tw.WriteEndElement();
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x000149B8 File Offset: 0x00012BB8
		public override string ToString()
		{
			return "{0} {1} {2}".InvariantFormat(new object[]
			{
				this.Property.ServerProperty,
				this.Operator,
				this.Value
			});
		}

		// Token: 0x040001C1 RID: 449
		public const string XmlNodeName = "rule";

		// Token: 0x040001C2 RID: 450
		private const string PropertyXmlNodeName = "property";

		// Token: 0x040001C3 RID: 451
		private const string OperatorXmlNodeName = "operator";

		// Token: 0x040001C4 RID: 452
		private const string ValueXmlNodeName = "value";
	}
}
