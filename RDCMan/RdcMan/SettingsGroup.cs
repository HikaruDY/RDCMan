using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	// Token: 0x020000E3 RID: 227
	public abstract class SettingsGroup
	{
		// Token: 0x06000810 RID: 2064 RVA: 0x00022324 File Offset: 0x00020524
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

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000811 RID: 2065 RVA: 0x000223D4 File Offset: 0x000205D4
		// (set) Token: 0x06000812 RID: 2066 RVA: 0x000223DC File Offset: 0x000205DC
		public string Name { get; private set; }

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000813 RID: 2067 RVA: 0x000223E8 File Offset: 0x000205E8
		// (set) Token: 0x06000814 RID: 2068 RVA: 0x000223F0 File Offset: 0x000205F0
		public string XmlNodeName { get; private set; }

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000815 RID: 2069 RVA: 0x000223FC File Offset: 0x000205FC
		// (set) Token: 0x06000816 RID: 2070 RVA: 0x00022404 File Offset: 0x00020604
		public InheritSettingsType InheritSettingsType { get; private set; }

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000817 RID: 2071
		protected abstract Dictionary<string, SettingProperty> SettingProperties { get; }

		// Token: 0x06000818 RID: 2072
		public abstract TabPage CreateTabPage(TabbedSettingsDialog dialog);

		// Token: 0x06000819 RID: 2073 RVA: 0x00022410 File Offset: 0x00020610
		public override string ToString()
		{
			return this.Name;
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x00022418 File Offset: 0x00020618
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

		// Token: 0x0600081B RID: 2075 RVA: 0x00022608 File Offset: 0x00020808
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

		// Token: 0x0600081C RID: 2076 RVA: 0x00022664 File Offset: 0x00020864
		protected virtual void WriteSettings(XmlTextWriter tw, RdcTreeNode node)
		{
			this.WriteSettings(tw, node, null);
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x00022670 File Offset: 0x00020870
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

		// Token: 0x0600081E RID: 2078 RVA: 0x0002271C File Offset: 0x0002091C
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

		// Token: 0x0600081F RID: 2079 RVA: 0x00022754 File Offset: 0x00020954
		protected virtual void Copy(RdcTreeNode node)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x0002275C File Offset: 0x0002095C
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
