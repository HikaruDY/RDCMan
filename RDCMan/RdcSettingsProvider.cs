using System;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	// Token: 0x02000119 RID: 281
	public class RdcSettingsProvider : SettingsProvider
	{
		// Token: 0x0600070D RID: 1805 RVA: 0x00006837 File Offset: 0x00004A37
		public override void Initialize(string name, NameValueCollection values)
		{
			base.Initialize(this.ApplicationName, values);
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x00006846 File Offset: 0x00004A46
		// (set) Token: 0x0600070F RID: 1807 RVA: 0x00002EFA File Offset: 0x000010FA
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

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x0000684D File Offset: 0x00004A4D
		private string SettingsDirectory
		{
			get
			{
				return new FileInfo(Application.LocalUserAppDataPath).DirectoryName;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000711 RID: 1809 RVA: 0x0000685E File Offset: 0x00004A5E
		private string SettingsFilename
		{
			get
			{
				return Path.Combine(this.SettingsDirectory, this.ApplicationName + ".settings");
			}
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x0001C8F0 File Offset: 0x0001AAF0
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

		// Token: 0x06000713 RID: 1811 RVA: 0x00002515 File Offset: 0x00000715
		public override void SetPropertyValues(SettingsContext context, SettingsPropertyValueCollection values)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x040004D7 RID: 1239
		private const string SettingsRoot = "Settings";
	}
}
