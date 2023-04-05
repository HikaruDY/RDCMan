using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace RdcMan
{
	internal class RuleGroup
	{
		public RuleGroupOperator Operator { get; private set; }

		public List<Rule> Rules { get; private set; }

		public RuleGroup(RuleGroupOperator op, IEnumerable<Rule> rules)
		{
			this.Set(op, rules);
		}

		protected RuleGroup()
		{
		}

		public static RuleGroup Create(XmlNode xmlNode, RdcTreeNode node, ICollection<string> errors)
		{
			RuleGroup ruleGroup = new RuleGroup();
			ruleGroup.ReadXml(xmlNode, node, errors);
			return ruleGroup;
		}

		public void Set(RuleGroupOperator op, IEnumerable<Rule> rules)
		{
			this.Operator = op;
			this.Rules = rules.ToList<Rule>();
		}

		public bool Evaluate(Server server)
		{
			bool result = false;
			bool result2 = true;
			foreach (Rule rule in this.Rules)
			{
				if (rule.Evaluate(server))
				{
					result = true;
				}
				else
				{
					result2 = false;
				}
			}
			if (this.Operator != RuleGroupOperator.Any)
			{
				return result2;
			}
			return result;
		}

		public void ReadXml(XmlNode xmlNode, RdcTreeNode node, ICollection<string> errors)
		{
			this.Operator = xmlNode.Attributes["operator"].Value.ParseEnum<RuleGroupOperator>();
			this.Rules = new List<Rule>();
			foreach (object obj in xmlNode.ChildNodes)
			{
				XmlNode xmlNode2 = (XmlNode)obj;
				this.Rules.Add(Rule.Create(xmlNode2, node, errors));
			}
		}

		public void WriteXml(XmlTextWriter tw)
		{
			tw.WriteStartElement("ruleGroup");
			tw.WriteAttributeString("operator", this.Operator.ToString());
			this.Rules.ForEach(delegate(Rule r)
			{
				r.WriteXml(tw);
			});
			tw.WriteEndElement();
		}

		public const string XmlNodeName = "ruleGroup";

		private const string GroupingOperatorXmlNodeName = "operator";

		private static Dictionary<string, Helpers.ReadXmlDelegate> NodeActions = new Dictionary<string, Helpers.ReadXmlDelegate>();
	}
}
