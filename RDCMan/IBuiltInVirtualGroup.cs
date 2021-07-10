using System;
using System.Collections.Generic;
using System.Xml;

namespace RdcMan
{
	// Token: 0x020000B6 RID: 182
	internal interface IBuiltInVirtualGroup
	{
		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060003F2 RID: 1010
		string XmlNodeName { get; }

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060003F3 RID: 1011
		string Text { get; }

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060003F4 RID: 1012
		string ConfigPropertyName { get; }

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060003F5 RID: 1013
		// (set) Token: 0x060003F6 RID: 1014
		bool IsInTree { get; set; }

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060003F7 RID: 1015
		bool IsVisibilityConfigurable { get; }

		// Token: 0x060003F8 RID: 1016
		void ReadXml(XmlNode xmlNode, FileGroup fileGroup, ICollection<string> errors);

		// Token: 0x060003F9 RID: 1017
		void WriteXml(XmlTextWriter tw, FileGroup fileGroup);

		// Token: 0x060003FA RID: 1018
		bool ShouldWriteNode(ServerRef serverRef, FileGroup file);
	}
}
