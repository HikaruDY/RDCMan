using System;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	// Token: 0x020000A6 RID: 166
	public class RdcSettingsProvider : SettingsProvider
	{
		// Token: 0x060005B0 RID: 1456 RVA: 0x0001AD80 File Offset: 0x00018F80
		public override void Initialize(string name, NameValueCollection values)
		{
			base.Initialize(this.ApplicationName, values);
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x0001AD90 File Offset: 0x00018F90
		// (set) Token: 0x060005B2 RID: 1458 RVA: 0x0001AD98 File Offset: 0x00018F98
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

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x0001AD9C File Offset: 0x00018F9C
		private string SettingsDirectory
		{
			get
			{
				return new FileInfo(Application.LocalUserAppDataPath).DirectoryName;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x0001ADB0 File Offset: 0x00018FB0
		private string SettingsFilename
		{
			get
			{
				return Path.Combine(this.SettingsDirectory, this.ApplicationName + ".settings");
			}
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x0001ADD0 File Offset: 0x00018FD0
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

		// Token: 0x060005B6 RID: 1462 RVA: 0x0001AF04 File Offset: 0x00019104
		public override void SetPropertyValues(SettingsContext context, SettingsPropertyValueCollection values)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x04000210 RID: 528
		private const string SettingsRoot = "Settings";
	}
}
