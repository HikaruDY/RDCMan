using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	public abstract class SettingsGroup
	{
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

		public string Name { get; private set; }

		public string XmlNodeName { get; private set; }

		public InheritSettingsType InheritSettingsType { get; private set; }

		protected abstract Dictionary<string, SettingProperty> SettingProperties { get; }

		public abstract TabPage CreateTabPage(TabbedSettingsDialog dialog);

		public override string ToString()
		{
			return this.Name;
		}

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

		protected virtual void WriteSettings(XmlTextWriter tw, RdcTreeNode node)
		{
			this.WriteSettings(tw, node, null);
		}

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

		protected virtual void Copy(RdcTreeNode node)
		{
			throw new NotImplementedException();
		}

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
