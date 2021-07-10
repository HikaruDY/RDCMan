using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	// Token: 0x02000179 RID: 377
	public abstract class SettingsGroup
	{
		// Token: 0x060009AB RID: 2475 RVA: 0x00021650 File Offset: 0x0001F850
		internal SettingsGroup(string name, string xmlNodeName)
		{
			this.XmlNodeName = xmlNodeName;
			this.Name = name;
			this.InheritSettingsType = new InheritSettingsType();
			foreach (SettingProperty settingProperty in this.SettingProperties.Values)
			{
				ISetting value = (ISetting)Activator.CreateInstance(settingProperty.Property.PropertyType, new object[]
				{
					settingProperty.Attribute.DefaultValue
				});
				settingProperty.Property.SetValue(this, value, null);
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x00008176 File Offset: 0x00006376
		// (set) Token: 0x060009AD RID: 2477 RVA: 0x0000817E File Offset: 0x0000637E
		public string Name { get; private set; }

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060009AE RID: 2478 RVA: 0x00008187 File Offset: 0x00006387
		// (set) Token: 0x060009AF RID: 2479 RVA: 0x0000818F File Offset: 0x0000638F
		public string XmlNodeName { get; private set; }

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060009B0 RID: 2480 RVA: 0x00008198 File Offset: 0x00006398
		// (set) Token: 0x060009B1 RID: 2481 RVA: 0x000081A0 File Offset: 0x000063A0
		public InheritSettingsType InheritSettingsType { get; private set; }

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060009B2 RID: 2482
		protected abstract Dictionary<string, SettingProperty> SettingProperties { get; }

		// Token: 0x060009B3 RID: 2483
		public abstract TabPage CreateTabPage(TabbedSettingsDialog dialog);

		// Token: 0x060009B4 RID: 2484 RVA: 0x000081A9 File Offset: 0x000063A9
		public override string ToString()
		{
			return this.Name;
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x000216F8 File Offset: 0x0001F8F8
		internal void ReadXml(XmlNode xmlNode, RdcTreeNode node, ICollection<string> errors)
		{
			InheritanceMode inheritanceMode = this.InheritSettingsType.Mode;
			if (inheritanceMode != InheritanceMode.Disabled)
			{
				try
				{
					string value = xmlNode.Attributes["inherit"].Value;
					if (!Enum.TryParse<InheritanceMode>(value, out inheritanceMode))
					{
						errors.Add("Unexpected inheritance mode '{0}' in {1}".InvariantFormat(new object[]
						{
							value,
							xmlNode.GetFullPath()
						}));
						inheritanceMode = InheritanceMode.None;
					}
				}
				catch
				{
					errors.Add("No inheritance mode specified in {0}".InvariantFormat(new object[]
					{
						xmlNode.GetFullPath()
					}));
					inheritanceMode = InheritanceMode.None;
				}
				this.InheritSettingsType.Mode = inheritanceMode;
			}
			if (inheritanceMode != InheritanceMode.FromParent)
			{
				if (inheritanceMode - InheritanceMode.None <= 1)
				{
					using (IEnumerator enumerator = xmlNode.ChildNodes.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							XmlNode xmlNode2 = (XmlNode)obj;
							try
							{
								ISetting setting = (ISetting)this.SettingProperties[xmlNode2.Name].Property.GetValue(this, null);
								try
								{
									setting.ReadXml(xmlNode2, node);
								}
								catch
								{
									errors.Add("Error processing Xml node {0}".InvariantFormat(new object[]
									{
										xmlNode2.GetFullPath()
									}));
								}
							}
							catch
							{
								errors.Add("Unexpected Xml node {0}".InvariantFormat(new object[]
								{
									xmlNode2.GetFullPath()
								}));
							}
						}
						return;
					}
				}
				errors.Add("Unexpected inheritance mode '{0}' in {1}".InvariantFormat(new object[]
				{
					inheritanceMode.ToString(),
					xmlNode.GetFullPath()
				}));
				return;
			}
			bool flag = false;
			this.InheritSettings(node, ref flag);
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x000218C4 File Offset: 0x0001FAC4
		internal void WriteXml(XmlTextWriter tw, RdcTreeNode node)
		{
			if (this.InheritSettingsType.Mode == InheritanceMode.FromParent)
			{
				return;
			}
			tw.WriteStartElement(this.XmlNodeName);
			if (this.InheritSettingsType.Mode != InheritanceMode.Disabled)
			{
				this.InheritSettingsType.WriteXml(tw);
			}
			this.WriteSettings(tw, node);
			tw.WriteEndElement();
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x000081B1 File Offset: 0x000063B1
		protected virtual void WriteSettings(XmlTextWriter tw, RdcTreeNode node)
		{
			this.WriteSettings(tw, node, null);
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x00021914 File Offset: 0x0001FB14
		protected virtual void WriteSettings(XmlTextWriter tw, RdcTreeNode node, HashSet<ISetting> exclusionSet)
		{
			foreach (SettingProperty settingProperty in this.SettingProperties.Values)
			{
				ISetting setting = (ISetting)settingProperty.Property.GetValue(this, null);
				if ((exclusionSet == null || !exclusionSet.Contains(setting)) && !settingProperty.Attribute.IsObsolete)
				{
					tw.WriteStartElement(settingProperty.Attribute.XmlName);
					setting.WriteXml(tw, node);
					tw.WriteEndElement();
				}
			}
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x000219B0 File Offset: 0x0001FBB0
		internal void InheritSettings(RdcTreeNode node, ref bool anyInherited)
		{
			GroupBase inheritedSettingsNode = this.InheritSettingsType.GetInheritedSettingsNode(node);
			if (inheritedSettingsNode == null)
			{
				return;
			}
			inheritedSettingsNode.InheritSettings();
			this.Copy(inheritedSettingsNode);
			anyInherited = true;
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x0000358A File Offset: 0x0000178A
		protected virtual void Copy(RdcTreeNode node)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x000219E0 File Offset: 0x0001FBE0
		internal void Copy(SettingsGroup source)
		{
			foreach (SettingProperty settingProperty in this.SettingProperties.Values)
			{
				ISetting setting = (ISetting)settingProperty.Property.GetValue(this, null);
				ISetting source2 = (ISetting)settingProperty.Property.GetValue(source, null);
				setting.Copy(source2);
			}
		}
	}
}
