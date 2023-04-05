using System;
using System.Collections.Generic;
using System.Xml;

namespace RdcMan
{
	// Token: 0x0200006D RID: 109
	internal interface IBuiltInVirtualGroup
	{
		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000317 RID: 791
		string XmlNodeName { get; }

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000318 RID: 792
		string Text { get; }

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000319 RID: 793
		string ConfigPropertyName { get; }

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600031A RID: 794
		// (set) Token: 0x0600031B RID: 795
		bool IsInTree { get; set; }

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600031C RID: 796
		bool IsVisibilityConfigurable { get; }

		// Token: 0x0600031D RID: 797
		void ReadXml(XmlNode xmlNode, FileGroup fileGroup, ICollection<string> errors);

		// Token: 0x0600031E RID: 798
		void WriteXml(XmlTextWriter tw, FileGroup fileGroup);

		// Token: 0x0600031F RID: 799
		bool ShouldWriteNode(ServerRef serverRef, FileGroup file);
	}
}
