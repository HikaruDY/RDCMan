using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Xml;

namespace RdcMan
{
	public class Rule
	{
		public RuleProperty Property { get; private set; }

		public RuleOperator Operator { get; private set; }

		public object Value { get; private set; }

		public Rule(RuleProperty property, RuleOperator operation, object value)
		{
			this.Property = property;
			this.Operator = operation;
			this.Value = value;
		}

		protected Rule()
		{
		}

		public static Rule Create(XmlNode xmlNode, RdcTreeNode node, ICollection<string> errors)
		{
			Rule rule = new Rule();
			rule.ReadXml(xmlNode, node, errors);
			return rule;
		}

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

		public void WriteXml(XmlTextWriter tw)
		{
			tw.WriteStartElement("rule");
			tw.WriteElementString("property", this.Property.ServerProperty.ToString());
			tw.WriteElementString("operator", this.Operator.ToString());
			tw.WriteElementString("value", this.Value.ToString());
			tw.WriteEndElement();
		}

		public override string ToString()
		{
			return "{0} {1} {2}".InvariantFormat(new object[]
			{
				this.Property.ServerProperty,
				this.Operator,
				this.Value
			});
		}

		public const string XmlNodeName = "rule";

		private const string PropertyXmlNodeName = "property";

		private const string OperatorXmlNodeName = "operator";

		private const string ValueXmlNodeName = "value";
	}
}
