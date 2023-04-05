using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace RdcMan
{
	// Token: 0x020000A9 RID: 169
	internal static class RdgFile
	{
		// Token: 0x060005F9 RID: 1529 RVA: 0x0001B848 File Offset: 0x00019A48
		public static FileGroup NewFile()
		{
			FileGroup result;
			using (SaveFileDialog saveFileDialog = new SaveFileDialog())
			{
				saveFileDialog.Title = "New File";
				saveFileDialog.Filter = "RDCMan Groups (*.rdg)|*.rdg";
				saveFileDialog.AddExtension = true;
				saveFileDialog.CheckPathExists = true;
				saveFileDialog.InitialDirectory = RdgFile.GetWorkingDirectory();
				saveFileDialog.RestoreDirectory = false;
				if (saveFileDialog.ShowDialog() != DialogResult.OK)
				{
					result = null;
				}
				else
				{
					FileGroup fileGroup = new FileGroup(saveFileDialog.FileName);
					ServerTree.Instance.AddNode(fileGroup, ServerTree.Instance.RootNode);
					RdgFile.DoSaveWithRetry(fileGroup);
					result = fileGroup;
				}
			}
			return result;
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x0001B8F4 File Offset: 0x00019AF4
		public static void CloseFileGroup(FileGroup file)
		{
			bool flag;
			bool flag2;
			file.AnyOrAllConnected(out flag, out flag2);
			if (flag)
			{
				DialogResult dialogResult = FormTools.YesNoDialog("There are active connections from " + file.Text + ". Are you sure you want to close it?");
				if (dialogResult == DialogResult.No)
				{
					return;
				}
			}
			if (RdgFile.SaveFileGroup(file) == SaveResult.Cancel)
			{
				return;
			}
			ServerTree.Instance.RemoveNode(file);
			Program.Preferences.NeedToSave = true;
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x0001B95C File Offset: 0x00019B5C
		public static FileGroup OpenFile()
		{
			FileGroup result;
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Title = "Open";
				openFileDialog.DefaultExt = "rdg";
				openFileDialog.AddExtension = true;
				openFileDialog.CheckFileExists = true;
				openFileDialog.InitialDirectory = RdgFile.GetWorkingDirectory();
				openFileDialog.RestoreDirectory = false;
				openFileDialog.Filter = "RDCMan Groups (*.rdg)|*.rdg";
				if (openFileDialog.ShowDialog() != DialogResult.OK)
				{
					result = null;
				}
				else
				{
					RdgFile.CurrentWorkingDirectory = Path.GetDirectoryName(openFileDialog.FileName);
					result = RdgFile.OpenFile(openFileDialog.FileName);
				}
			}
			return result;
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x0001BA04 File Offset: 0x00019C04
		public static FileGroup OpenFile(string filename)
		{
			FileGroup result;
			using (Helpers.Timer("reading {0}", new object[]
			{
				filename
			}))
			{
				XmlDocument xmlDocument = new XmlDocument();
				XmlTextReader xmlTextReader = null;
				XmlNode topNode;
				try
				{
					xmlTextReader = new XmlTextReader(filename)
					{
						DtdProcessing = DtdProcessing.Ignore
					};
					xmlTextReader.WhitespaceHandling = WhitespaceHandling.None;
					xmlTextReader.MoveToContent();
					topNode = xmlDocument.ReadNode(xmlTextReader);
				}
				catch (Exception ex)
				{
					FormTools.ErrorDialog(ex.Message);
					return null;
				}
				finally
				{
					if (xmlTextReader != null)
					{
						xmlTextReader.Close();
					}
				}
				if (topNode == null)
				{
					throw new FileLoadException(filename + ": File format error");
				}
				FileGroup fileGroup = new FileGroup(filename);
				FileGroup fileGroup2 = (from f in ServerTree.Instance.Nodes.OfType<FileGroup>()
				where f.Pathname.Equals(fileGroup.Pathname, StringComparison.OrdinalIgnoreCase)
				select f).FirstOrDefault<FileGroup>();
				if (fileGroup2 != null)
				{
					FormTools.InformationDialog("{0} is already open as '{1}'".CultureFormat(new object[]
					{
						fileGroup.Pathname,
						fileGroup2.Text
					}));
					result = fileGroup2;
				}
				else
				{
					try
					{
						List<string> errors = new List<string>();
						ServerTree.Instance.Operation((OperationBehavior)31, delegate
						{
							ServerTree.Instance.AddNode(fileGroup, ServerTree.Instance.RootNode);
							if (!RdgFile.ReadXml(topNode, fileGroup, errors))
							{
								throw new Exception(string.Empty);
							}
						});
						if (errors.Count > 0)
						{
							StringBuilder stringBuilder = new StringBuilder("The following errors were encountered:").AppendLine().AppendLine();
							foreach (string value in errors)
							{
								stringBuilder.AppendLine(value);
							}
							stringBuilder.AppendLine().Append("The file was not loaded completely. If it is saved it almost certainly means losing information. Continue?");
							DialogResult dialogResult = FormTools.ExclamationDialog(stringBuilder.ToString(), MessageBoxButtons.YesNo);
							if (dialogResult == DialogResult.No)
							{
								throw new Exception(string.Empty);
							}
						}
						using (Helpers.Timer("sorting root, builtin groups and file", Array.Empty<object>()))
						{
							ServerTree.Instance.SortRoot();
							foreach (IBuiltInVirtualGroup builtInVirtualGroup in Program.BuiltInVirtualGroups)
							{
								GroupBase group = (GroupBase)builtInVirtualGroup;
								ServerTree.Instance.SortGroup(group);
								ServerTree.Instance.OnGroupChanged(group, ChangeType.TreeChanged);
							}
							ServerTree.Instance.SortGroup(fileGroup, true);
							ServerTree.Instance.OnGroupChanged(fileGroup, ChangeType.TreeChanged);
						}
						SmartGroup.RefreshAll(fileGroup);
						fileGroup.VisitNodes(delegate(RdcTreeNode node)
						{
							GroupBase groupBase = node as GroupBase;
							if (groupBase != null && groupBase.Properties.Expanded.Value)
							{
								groupBase.Expand();
							}
						});
						Encryption.DecryptPasswords();
						fileGroup.CheckCredentials();
						fileGroup.VisitNodes(delegate(RdcTreeNode n)
						{
							n.ResetInheritance();
						});
						fileGroup.HasChangedSinceWrite = false;
						Program.Preferences.NeedToSave = true;
						result = fileGroup;
					}
					catch (Exception ex2)
					{
						if (!string.IsNullOrEmpty(ex2.Message))
						{
							FormTools.ErrorDialog(ex2.Message);
						}
						ServerTree.Instance.RemoveNode(fileGroup);
						result = null;
					}
				}
			}
			return result;
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x0001BE48 File Offset: 0x0001A048
		private static bool ReadXml(XmlNode topNode, FileGroup fileGroup, ICollection<string> errors)
		{
			string text = "unknown";
			int num = 0;
			try
			{
				XmlNode namedItem = topNode.Attributes.GetNamedItem("programVersion");
				text = namedItem.InnerText;
			}
			catch
			{
			}
			try
			{
				XmlNode namedItem2 = topNode.Attributes.GetNamedItem("schemaVersion");
				num = int.Parse(namedItem2.InnerText);
			}
			catch
			{
			}
			fileGroup.SchemaVersion = num;
			if (num > 3)
			{
				DialogResult dialogResult = FormTools.YesNoDialog("{0} was written by a newer version of RDCMan ({1}). It may not load properly. If it does and is saved by this version, it will revert to the older file schema possibly losing information. Continue?".CultureFormat(new object[]
				{
					fileGroup.GetFilename(),
					text
				}));
				if (dialogResult == DialogResult.No)
				{
					return false;
				}
			}
			GroupBase.SchemaVersion = num;
			if (GroupBase.SchemaVersion <= 2)
			{
				fileGroup.EncryptionSettings.InheritSettingsType.Mode = InheritanceMode.None;
			}
			Dictionary<string, Helpers.ReadXmlDelegate> nodeActions = new Dictionary<string, Helpers.ReadXmlDelegate>();
			nodeActions["file"] = delegate(XmlNode childNode, RdcTreeNode group, ICollection<string> errors2)
			{
				(group as GroupBase).ReadXml(childNode, errors2);
			};
			using (IEnumerator<IBuiltInVirtualGroup> enumerator = (from v in Program.BuiltInVirtualGroups
			where !string.IsNullOrEmpty(v.XmlNodeName)
			select v).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					IBuiltInVirtualGroup virtualGroup = enumerator.Current;
					nodeActions[virtualGroup.XmlNodeName] = delegate(XmlNode childNode, RdcTreeNode group, ICollection<string> errors2)
					{
						virtualGroup.ReadXml(childNode, fileGroup, errors2);
					};
				}
			}
			nodeActions["version"] = delegate(XmlNode childNode, RdcTreeNode group, ICollection<string> errors2)
			{
			};
			LongRunningActionForm.PerformOperation("Opening " + fileGroup.Pathname, false, delegate
			{
				foreach (object obj in topNode.ChildNodes)
				{
					XmlNode xmlNode = (XmlNode)obj;
					Helpers.ReadXmlDelegate readXmlDelegate;
					if (nodeActions.TryGetValue(xmlNode.Name, out readXmlDelegate))
					{
						readXmlDelegate(xmlNode, fileGroup, errors);
					}
					else
					{
						errors.Add("Unexpected Xml node {0} in '{1}'".CultureFormat(new object[]
						{
							xmlNode.GetFullPath(),
							fileGroup.GetFilename()
						}));
					}
				}
			});
			return true;
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x0001C098 File Offset: 0x0001A298
		public static SaveResult SaveFileGroup(FileGroup file)
		{
			if (Interlocked.CompareExchange(ref RdgFile._saveInProgress, 1, 0) == 1)
			{
				return SaveResult.NoSave;
			}
			SaveResult result;
			try
			{
				result = RdgFile.DoSaveWithRetry(file);
			}
			finally
			{
				RdgFile._saveInProgress = 0;
			}
			return result;
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x0001C0E0 File Offset: 0x0001A2E0
		public static SaveResult SaveAll()
		{
			if (Interlocked.CompareExchange(ref RdgFile._saveInProgress, 1, 0) == 1)
			{
				return SaveResult.NoSave;
			}
			SaveResult result;
			try
			{
				result = RdgFile.DoSaveAll(false);
			}
			finally
			{
				RdgFile._saveInProgress = 0;
			}
			return result;
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x0001C128 File Offset: 0x0001A328
		private static SaveResult DoSaveAll(bool conditional)
		{
			foreach (FileGroup fileGroup in ServerTree.Instance.Nodes.OfType<FileGroup>())
			{
				if (!conditional || fileGroup.HasChangedSinceWrite)
				{
					SaveResult saveResult = RdgFile.DoSaveWithRetry(fileGroup);
					if (saveResult == SaveResult.Cancel)
					{
						return saveResult;
					}
				}
			}
			return SaveResult.Save;
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x0001C1A8 File Offset: 0x0001A3A8
		public static SaveResult DoSaveWithRetry(FileGroup file)
		{
			if (!file.AllowEdit(false))
			{
				return SaveResult.NoSave;
			}
			SaveResult saveResult;
			for (;;)
			{
				saveResult = RdgFile.SaveFile(file);
				if (saveResult == SaveResult.Cancel)
				{
					break;
				}
				if (saveResult != SaveResult.Retry)
				{
					return SaveResult.Save;
				}
			}
			return saveResult;
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x0001C1DC File Offset: 0x0001A3DC
		public static SaveResult SaveAs(FileGroup file)
		{
			SaveResult result;
			using (SaveFileDialog saveFileDialog = new SaveFileDialog())
			{
				saveFileDialog.Title = "Save";
				saveFileDialog.Filter = "RDCMan Groups (*.rdg)|*.rdg";
				saveFileDialog.AddExtension = true;
				saveFileDialog.CheckPathExists = true;
				saveFileDialog.FileName = Path.GetFileName(file.Pathname);
				saveFileDialog.InitialDirectory = Path.GetDirectoryName(file.Pathname);
				saveFileDialog.RestoreDirectory = false;
				DialogResult dialogResult;
				SaveResult saveResult;
				for (;;)
				{
					dialogResult = saveFileDialog.ShowDialog();
					if (dialogResult != DialogResult.OK)
					{
						break;
					}
					file.Pathname = Path.Combine(Directory.GetCurrentDirectory(), saveFileDialog.FileName);
					saveResult = RdgFile.SaveFile(file);
					if (saveResult != SaveResult.Retry)
					{
						goto Block_5;
					}
				}
				if (dialogResult == DialogResult.Cancel)
				{
					return SaveResult.Cancel;
				}
				return SaveResult.NoSave;
				Block_5:
				result = saveResult;
			}
			return result;
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x0001C2A8 File Offset: 0x0001A4A8
		private static SaveResult SaveFile(FileGroup fileGroup)
		{
			string temporaryFileName = Helpers.GetTemporaryFileName(fileGroup.Pathname, ".new");
			XmlTextWriter xmlTextWriter = null;
			SaveResult result;
			try
			{
				xmlTextWriter = new XmlTextWriter(temporaryFileName, Encoding.UTF8);
				xmlTextWriter.Formatting = Formatting.Indented;
				xmlTextWriter.Indentation = 2;
				xmlTextWriter.WriteStartDocument();
				xmlTextWriter.WriteStartElement("RDCMan");
				xmlTextWriter.WriteAttributeString("programVersion", Program.TheForm.VersionText);
				xmlTextWriter.WriteAttributeString("schemaVersion", 3.ToString());
				fileGroup.WriteXml(xmlTextWriter);
				foreach (IBuiltInVirtualGroup builtInVirtualGroup in from v in Program.BuiltInVirtualGroups
				where !string.IsNullOrEmpty(v.XmlNodeName)
				select v)
				{
					builtInVirtualGroup.WriteXml(xmlTextWriter, fileGroup);
				}
				xmlTextWriter.WriteEndElement();
				xmlTextWriter.WriteEndDocument();
				xmlTextWriter.Close();
				xmlTextWriter = null;
				Helpers.MoveTemporaryToPermanent(temporaryFileName, fileGroup.Pathname, fileGroup.SchemaVersion != 3);
				fileGroup.SchemaVersion = 3;
				fileGroup.HasChangedSinceWrite = false;
				result = SaveResult.Save;
			}
			catch (Exception ex)
			{
				if (xmlTextWriter != null)
				{
					xmlTextWriter.Close();
				}
				DialogResult dialogResult = FormTools.YesNoCancelDialog(ex.Message + "\n\nTry again? (Selecting Cancel will preserve the original file)");
				if (dialogResult != DialogResult.Cancel)
				{
					if (dialogResult != DialogResult.Yes)
					{
						if (dialogResult != DialogResult.No)
						{
						}
						result = SaveResult.NoSave;
					}
					else
					{
						result = SaveResult.Retry;
					}
				}
				else
				{
					result = SaveResult.Cancel;
				}
			}
			return result;
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x0001C440 File Offset: 0x0001A640
		public static bool AutoSave()
		{
			if (Interlocked.CompareExchange(ref RdgFile._saveInProgress, 1, 0) == 1)
			{
				return false;
			}
			try
			{
				RdgFile.DoSaveAll(true);
			}
			finally
			{
				RdgFile._saveInProgress = 0;
			}
			return true;
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x0001C488 File Offset: 0x0001A688
		public static SaveResult ShouldSaveFile(FileGroup file)
		{
			if (!file.AllowEdit(false))
			{
				return SaveResult.NoSave;
			}
			if (Program.Preferences.AutoSaveFiles)
			{
				return SaveResult.AutoSave;
			}
			if (!file.HasChangedSinceWrite)
			{
				return SaveResult.AutoSave;
			}
			string text = "Save changes to " + file.GetFilename() + "?";
			DialogResult dialogResult = FormTools.YesNoCancelDialog(text, MessageBoxDefaultButton.Button1);
			if (dialogResult == DialogResult.Cancel)
			{
				return SaveResult.Cancel;
			}
			if (dialogResult == DialogResult.No)
			{
				return SaveResult.NoSave;
			}
			return SaveResult.Save;
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x0001C4F8 File Offset: 0x0001A6F8
		private static string GetWorkingDirectory()
		{
			FileGroup selectedFile = ServerTree.Instance.GetSelectedFile();
			if (selectedFile != null)
			{
				return selectedFile.GetDirectory();
			}
			return RdgFile.CurrentWorkingDirectory ?? Environment.GetFolderPath(Environment.SpecialFolder.Personal);
		}

		// Token: 0x04000222 RID: 546
		private const int CurrentSchemaVersion = 3;

		// Token: 0x04000223 RID: 547
		private const string SaveFileFilter = "RDCMan Groups (*.rdg)|*.rdg";

		// Token: 0x04000224 RID: 548
		private const string OpenFileFilter = "RDCMan Groups (*.rdg)|*.rdg";

		// Token: 0x04000225 RID: 549
		private static int _saveInProgress;

		// Token: 0x04000226 RID: 550
		private static string CurrentWorkingDirectory;
	}
}
