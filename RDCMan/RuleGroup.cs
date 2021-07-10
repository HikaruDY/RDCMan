using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace RdcMan
{
	// Token: 0x020000D2 RID: 210
	internal class RuleGroup
	{
		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x00004D1B File Offset: 0x00002F1B
		// (set) Token: 0x060004E2 RID: 1250 RVA: 0x00004D23 File Offset: 0x00002F23
		public RuleGroupOperator Operator { get; private set; }

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x00004D2C File Offset: 0x00002F2C
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x00004D34 File Offset: 0x00002F34
		public List<Rule> Rules { get; private set; }

		// Token: 0x060004E5 RID: 1253 RVA: 0x00004D3D File Offset: 0x00002F3D
		public RuleGroup(RuleGroupOperator op, IEnumerable<Rule> rules)
		{
			this.Set(op, rules);
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00002084 File Offset: 0x00000284
		protected RuleGroup()
		{
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00017F78 File Offset: 0x00016178
		public static RuleGroup Create(XmlNode xmlNode, RdcTreeNode node, ICollection<string> errors)
		{
			RuleGroup ruleGroup = new RuleGroup();
			ruleGroup.ReadXml(xmlNode, node, errors);
			return ruleGroup;
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00004D4D File Offset: 0x00002F4D
		public void Set(RuleGroupOperator op, IEnumerable<Rule> rules)
		{
			this.Operator = op;
			this.Rules = rules.ToList<Rule>();
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00017F98 File Offset: 0x00016198
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

		// Token: 0x060004EA RID: 1258 RVA: 0x00018004 File Offset: 0x00016204
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

		// Token: 0x060004EB RID: 1259 RVA: 0x00018094 File Offset: 0x00016294
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

		// Token: 0x04000448 RID: 1096
		public const string XmlNodeName = "ruleGroup";

		// Token: 0x04000449 RID: 1097
		private const string GroupingOperatorXmlNodeName = "operator";

		// Token: 0x0400044A RID: 1098
		private static Dictionary<string, Helpers.ReadXmlDelegate> NodeActions = new Dictionary<string, Helpers.ReadXmlDelegate>();
	}
}
