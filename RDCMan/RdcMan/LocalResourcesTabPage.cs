using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MSTSCLib;

namespace RdcMan
{
	// Token: 0x02000056 RID: 86
	public class LocalResourcesTabPage : SettingsTabPage<LocalResourcesSettings>
	{
		// Token: 0x06000217 RID: 535 RVA: 0x0000C5C0 File Offset: 0x0000A7C0
		public LocalResourcesTabPage(TabbedSettingsDialog dialog, LocalResourcesSettings settings) : base(dialog, settings)
		{
			int num = 0;
			int rowIndex = 0;
			base.CreateInheritanceControl(ref rowIndex, ref num);
			FormTools.AddLabeledEnumDropDown<RdpClient.AudioRedirectionMode>(this, "Remote &sound", base.Settings.AudioRedirectionMode, ref rowIndex, ref num, new Func<RdpClient.AudioRedirectionMode, string>(RdpClient.AudioRedirectionModeToString));
			if (RdpClient.SupportsAdvancedAudioVideoRedirection)
			{
				FormTools.AddLabeledEnumDropDown<RdpClient.AudioRedirectionQuality>(this, "Sound &quality", base.Settings.AudioRedirectionQuality, ref rowIndex, ref num, new Func<RdpClient.AudioRedirectionQuality, string>(RdpClient.AudioRedirectionQualityToString));
				FormTools.AddLabeledEnumDropDown<RdpClient.AudioCaptureRedirectionMode>(this, "Remote &recording", base.Settings.AudioCaptureRedirectionMode, ref rowIndex, ref num, new Func<RdpClient.AudioCaptureRedirectionMode, string>(RdpClient.AudioCaptureRedirectionModeToString));
			}
			FormTools.AddLabeledEnumDropDown<RdpClient.KeyboardHookMode>(this, "&Windows key combos", base.Settings.KeyboardHookMode, ref rowIndex, ref num, new Func<RdpClient.KeyboardHookMode, string>(RdpClient.KeyboardHookModeToString));
			Label value = FormTools.NewLabel("Redirect options", 0, rowIndex);
			TreeView treeView = new TreeView
			{
				Location = FormTools.NewLocation(1, rowIndex),
				Size = new Size(340, 140),
				CheckBoxes = true,
				Scrollable = true,
				ShowLines = false
			};
			treeView.AfterCheck += this.RedirectView_AfterCheck;
			this._redirectClipboardCheckBox = treeView.Nodes.Add("Clipboard");
			this._redirectPrintersCheckBox = treeView.Nodes.Add("Printers");
			this._redirectSmartCardsCheckBox = treeView.Nodes.Add("Smart cards");
			this._redirectPortsCheckBox = treeView.Nodes.Add("Ports");
			this._redirectDrivesCheckBox = treeView.Nodes.Add("Drives");
			this._redirectPnpDevicesCheckBox = treeView.Nodes.Add("PnP devices");
			if (RdpClient.SupportsFineGrainedRedirection)
			{
				IMsRdpDriveCollection driveCollection = RdpClient.DriveCollection;
				for (uint num2 = 0U; num2 < driveCollection.DriveCount; num2 += 1U)
				{
					IMsRdpDrive msRdpDrive = driveCollection.get_DriveByIndex(num2);
					this._redirectDrivesCheckBox.Nodes.Add(msRdpDrive.Name.Substring(0, msRdpDrive.Name.Length - 1));
				}
			}
			base.Controls.Add(value);
			base.Controls.Add(treeView);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0000C7E8 File Offset: 0x0000A9E8
		protected override void UpdateControls()
		{
			base.UpdateControls();
			this._redirectDrivesCheckBox.Checked = base.Settings.RedirectDrives.Value;
			this._redirectPortsCheckBox.Checked = base.Settings.RedirectPorts.Value;
			this._redirectPrintersCheckBox.Checked = base.Settings.RedirectPrinters.Value;
			this._redirectSmartCardsCheckBox.Checked = base.Settings.RedirectSmartCards.Value;
			this._redirectClipboardCheckBox.Checked = base.Settings.RedirectClipboard.Value;
			this._redirectPnpDevicesCheckBox.Checked = base.Settings.RedirectPnpDevices.Value;
			foreach (string b in base.Settings.RedirectDrivesList.Value)
			{
				foreach (object obj in this._redirectDrivesCheckBox.Nodes)
				{
					TreeNode treeNode = (TreeNode)obj;
					if (treeNode.Text == b)
					{
						this._redirectDrivesCheckBox.Expand();
						treeNode.Checked = true;
					}
				}
			}
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000C964 File Offset: 0x0000AB64
		protected override void UpdateSettings()
		{
			base.UpdateSettings();
			base.Settings.RedirectDrives.Value = this._redirectDrivesCheckBox.Checked;
			List<string> list = new List<string>();
			foreach (object obj in this._redirectDrivesCheckBox.Nodes)
			{
				TreeNode treeNode = (TreeNode)obj;
				if (treeNode.Checked)
				{
					list.Add(treeNode.Text);
				}
			}
			base.Settings.RedirectDrivesList.Value = list;
			base.Settings.RedirectPorts.Value = this._redirectPortsCheckBox.Checked;
			base.Settings.RedirectPrinters.Value = this._redirectPrintersCheckBox.Checked;
			base.Settings.RedirectSmartCards.Value = this._redirectSmartCardsCheckBox.Checked;
			base.Settings.RedirectClipboard.Value = this._redirectClipboardCheckBox.Checked;
			base.Settings.RedirectPnpDevices.Value = this._redirectPnpDevicesCheckBox.Checked;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0000CA9C File Offset: 0x0000AC9C
		private void RedirectView_AfterCheck(object sender, TreeViewEventArgs e)
		{
			if (this._processingAfterCheck)
			{
				return;
			}
			this._processingAfterCheck = true;
			if (e.Node.Nodes.Count == 0 && e.Node.Parent != null)
			{
				e.Node.Parent.Checked = e.Node.Parent.Nodes.Cast<TreeNode>().All((TreeNode node) => node.Checked);
			}
			else
			{
				foreach (object obj in e.Node.Nodes)
				{
					TreeNode treeNode = (TreeNode)obj;
					treeNode.Checked = e.Node.Checked;
				}
			}
			this._processingAfterCheck = false;
		}

		// Token: 0x04000123 RID: 291
		private bool _processingAfterCheck;

		// Token: 0x04000124 RID: 292
		private TreeNode _redirectDrivesCheckBox;

		// Token: 0x04000125 RID: 293
		private TreeNode _redirectPrintersCheckBox;

		// Token: 0x04000126 RID: 294
		private TreeNode _redirectPortsCheckBox;

		// Token: 0x04000127 RID: 295
		private TreeNode _redirectSmartCardsCheckBox;

		// Token: 0x04000128 RID: 296
		private TreeNode _redirectClipboardCheckBox;

		// Token: 0x04000129 RID: 297
		private TreeNode _redirectPnpDevicesCheckBox;
	}
}
