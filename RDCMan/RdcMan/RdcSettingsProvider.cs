using System;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	public class RdcSettingsProvider : SettingsProvider
	{
		public override void Initialize(string name, NameValueCollection values)
		{
			base.Initialize(this.ApplicationName, values);
		}

		public override string ApplicationName
		{
			get
			{
				return "RDCMan";
			}
			set
			{
			}
		}

		private string SettingsDirectory
		{
			get
			{
				return new FileInfo(Application.LocalUserAppDataPath).DirectoryName;
			}
		}

		private string SettingsFilename
		{
			get
			{
				return Path.Combine(this.SettingsDirectory, this.ApplicationName + ".settings");
			}
		}

		public override SettingsPropertyValueCollection GetPropertyValues(SettingsContext context, SettingsPropertyCollection properties)
		{
			SettingsPropertyValueCollection settingsPropertyValueCollection = new SettingsPropertyValueCollection();
			XmlDocument xmlDocument = new XmlDocument();
			XmlNode xmlNode = null;
			try
			{
				if (!Program.ResetPreferences)
				{
					xmlDocument.Load(this.SettingsFilename);
					xmlNode = xmlDocument.SelectSingleNode("Settings");
				}
			}
			catch
			{
			}
			if (xmlNode == null)
			{
				xmlNode = xmlDocument.CreateNode(XmlNodeType.Element, "root", "");
			}
			foreach (object obj in properties)
			{
				SettingsProperty settingsProperty = (SettingsProperty)obj;
				SettingsPropertyValue settingsPropertyValue = new SettingsPropertyValue(settingsProperty);
				XmlNode xmlNode2 = xmlNode.SelectSingleNode(settingsProperty.Name);
				if (xmlNode2 != null)
				{
					if (settingsProperty.PropertyType == typeof(XmlDocument))
					{
						settingsPropertyValue.SerializedValue = xmlNode2.InnerXml;
					}
					else
					{
						settingsPropertyValue.SerializedValue = xmlNode2.InnerText;
					}
				}
				else
				{
					settingsPropertyValue.SerializedValue = settingsProperty.DefaultValue;
				}
				settingsPropertyValueCollection.Add(settingsPropertyValue);
			}
			return settingsPropertyValueCollection;
		}

		public override void SetPropertyValues(SettingsContext context, SettingsPropertyValueCollection values)
		{
			throw new InvalidOperationException();
		}

		private const string SettingsRoot = "Settings";
	}
}
