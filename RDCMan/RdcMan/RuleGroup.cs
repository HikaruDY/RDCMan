using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace RdcMan
{
	// Token: 0x02000080 RID: 128
	internal class RuleGroup
	{
		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060003DF RID: 991 RVA: 0x00014560 File Offset: 0x00012760
		// (set) Token: 0x060003E0 RID: 992 RVA: 0x00014568 File Offset: 0x00012768
		public RuleGroupOperator Operator { get; private set; }

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x00014574 File Offset: 0x00012774
		// (set) Token: 0x060003E2 RID: 994 RVA: 0x0001457C File Offset: 0x0001277C
		public List<Rule> Rules { get; private set; }

		// Token: 0x060003E3 RID: 995 RVA: 0x00014588 File Offset: 0x00012788
		public RuleGroup(RuleGroupOperator op, IEnumerable<Rule> rules)
		{
			this.Set(op, rules);
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00014598 File Offset: 0x00012798
		protected RuleGroup()
		{
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x000145A0 File Offset: 0x000127A0
		public static RuleGroup Create(XmlNode xmlNode, RdcTreeNode node, ICollection<string> errors)
		{
			RuleGroup ruleGroup = new RuleGroup();
			ruleGroup.ReadXml(xmlNode, node, errors);
			return ruleGroup;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x000145C4 File Offset: 0x000127C4
		public void Set(RuleGroupOperator op, IEnumerable<Rule> rules)
		{
			this.Operator = op;
			this.Rules = rules.ToList<Rule>();
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x000145DC File Offset: 0x000127DC
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

		// Token: 0x060003E8 RID: 1000 RVA: 0x00014658 File Offset: 0x00012858
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

		// Token: 0x060003E9 RID: 1001 RVA: 0x000146F4 File Offset: 0x000128F4
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

		// Token: 0x040001BC RID: 444
		public const string XmlNodeName = "ruleGroup";

		// Token: 0x040001BD RID: 445
		private const string GroupingOperatorXmlNodeName = "operator";

		// Token: 0x040001BE RID: 446
		private static Dictionary<string, Helpers.ReadXmlDelegate> NodeActions = new Dictionary<string, Helpers.ReadXmlDelegate>();
	}
}
