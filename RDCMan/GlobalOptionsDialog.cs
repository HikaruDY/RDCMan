using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RdcMan
{
	// Token: 0x02000052 RID: 82
	public partial class GlobalOptionsDialog : TabbedSettingsDialog
	{
		// Token: 0x06000155 RID: 341 RVA: 0x0000C418 File Offset: 0x0000A618
		protected GlobalOptionsDialog(Form parentForm) : base("Options", "OK", parentForm)
		{
			this._bandwidthItems = new GlobalOptionsDialog.BandwidthItem[]
			{
				new GlobalOptionsDialog.BandwidthItem("Modem (28.8 Kbps)", 15),
				new GlobalOptionsDialog.BandwidthItem("Modem (56 Kbps)", 7),
				new GlobalOptionsDialog.BandwidthItem("Broadband (128 Kpbs - 1.5 Mbps)", 257),
				new GlobalOptionsDialog.BandwidthItem("LAN (10 Mbps or higher)", 384),
				new GlobalOptionsDialog.BandwidthItem("Custom", 0)
			};
			this.InitializeComponent();
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000C498 File Offset: 0x0000A698
		public static GlobalOptionsDialog New()
		{
			GlobalOptionsDialog globalOptionsDialog = new GlobalOptionsDialog(Program.TheForm);
			globalOptionsDialog.InitializeControlsFromPreferences();
			return globalOptionsDialog;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0000C4B8 File Offset: 0x0000A6B8
		private void InitializeControlsFromPreferences()
		{
			MainForm theForm = Program.TheForm;
			foreach (object obj in this._virtualGroupsGroup.Controls)
			{
				CheckBox checkBox = (CheckBox)obj;
				checkBox.Checked = (checkBox.Tag as IBuiltInVirtualGroup).IsInTree;
			}
			this._treeLocationCombo.SelectedValue = Program.TheForm.ServerTreeLocation;
			this._treeVisibilityCombo.SelectedValue = Program.TheForm.ServerTreeVisibility;
			this._connectionBarEnabledCheckBox.Checked = (Program.Preferences.ConnectionBarState != RdpClient.ConnectionBarState.Off);
			this._connectionBarAutoHiddenCheckBox.Checked = (Program.Preferences.ConnectionBarState == RdpClient.ConnectionBarState.AutoHide);
			this._connectionBarAutoHiddenCheckBox.Enabled = this._connectionBarEnabledCheckBox.Enabled;
			if (RdpClient.SupportsPanning)
			{
				this._panningAccelerationUpDown.Enabled = Program.Preferences.EnablePanning;
			}
			Size clientSize = theForm.GetClientSize();
			RadioButton radioButton = this._casSizeGroup.Controls.OfType<RadioButton>().Where(delegate(RadioButton r)
			{
				Size? size = (Size?)r.Tag;
				Size clientSize = clientSize;
				return size != null && (size == null || size.GetValueOrDefault() == clientSize);
			}).FirstOrDefault<RadioButton>();
			if (radioButton != null)
			{
				radioButton.Checked = true;
			}
			else
			{
				this._casCustomRadio.Checked = true;
			}
			this._casCustomButton.Text = clientSize.ToFormattedString();
			this._thumbnailPixelsButton.Text = Program.Preferences.ThumbnailSize.ToFormattedString();
			this._thumbnailPercentageTextBox.Text = Program.Preferences.ThumbnailPercentage.ToString();
			if (Program.Preferences.ThumbnailSizeIsInPixels)
			{
				this._thumbnailPixelsRadio.Checked = true;
			}
			else
			{
				this._thumbnailPercentageRadio.Checked = true;
			}
			this.SetBandwidthCheckBoxes(Program.Preferences.PerformanceFlags);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0000C698 File Offset: 0x0000A898
		public void UpdatePreferences()
		{
			base.UpdateSettings();
			MainForm theForm = Program.TheForm;
			foreach (object obj in this._virtualGroupsGroup.Controls)
			{
				CheckBox checkBox = (CheckBox)obj;
				(checkBox.Tag as IBuiltInVirtualGroup).IsInTree = checkBox.Checked;
			}
			Program.TheForm.ServerTreeLocation = this._treeLocationCombo.SelectedValue;
			Program.TheForm.ServerTreeVisibility = this._treeVisibilityCombo.SelectedValue;
			RdpClient.ConnectionBarState connectionBarState;
			if (!this._connectionBarEnabledCheckBox.Checked)
			{
				connectionBarState = RdpClient.ConnectionBarState.Off;
			}
			else
			{
				connectionBarState = (this._connectionBarAutoHiddenCheckBox.Checked ? RdpClient.ConnectionBarState.AutoHide : RdpClient.ConnectionBarState.Pinned);
			}
			Program.Preferences.ConnectionBarState = connectionBarState;
			Program.Preferences.PerformanceFlags = this.ComputeFlagsFromCheckBoxes();
			string text = this._casCustomButton.Text;
			if (!this._casCustomRadio.Checked)
			{
				text = (from r in this._casSizeGroup.Controls.OfType<RadioButton>()
				where r.Checked
				select r).First<RadioButton>().Text;
			}
			Size size = SizeHelper.Parse(text);
			Size clientSize = theForm.GetClientSize();
			if (clientSize != size)
			{
				theForm.SetClientSize(size);
			}
			size = SizeHelper.Parse(this._thumbnailPixelsButton.Text);
			Program.Preferences.ThumbnailSize = size;
			Program.Preferences.ThumbnailSizeIsInPixels = this._thumbnailPixelsRadio.Checked;
			int thumbnailPercentage = int.Parse(this._thumbnailPercentageTextBox.Text);
			Program.Preferences.ThumbnailPercentage = thumbnailPercentage;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0000C84C File Offset: 0x0000AA4C
		private TabPage NewTabPage(string name)
		{
			TabPage tabPage = new SettingsTabPage
			{
				Location = FormTools.TopLeftLocation(),
				Size = new Size(512, 334),
				Text = name
			};
			base.AddTabPage(tabPage);
			return tabPage;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000C890 File Offset: 0x0000AA90
		private TabPage CreateFullScreenPage()
		{
			int rowIndex = 0;
			int num = 0;
			TabPage tabPage = this.NewTabPage("Full Screen");
			this._connectionBarEnabledCheckBox = FormTools.NewCheckBox("Show full screen connection bar", 0, rowIndex++, num++);
			this._connectionBarEnabledCheckBox.CheckedChanged += this.ConnectionBarEnabledCheckedChanged;
			this._connectionBarAutoHiddenCheckBox = FormTools.NewCheckBox("Auto-hide connection bar", 0, rowIndex++, num++);
			this._connectionBarAutoHiddenCheckBox.Location = new Point(this._connectionBarEnabledCheckBox.Left + 24, this._connectionBarAutoHiddenCheckBox.Top);
			FormTools.AddCheckBox(tabPage, "Full screen window is always on top", Program.Preferences.Settings.FullScreenWindowIsTopMost, 0, ref rowIndex, ref num);
			if (RdpClient.SupportsMonitorSpanning)
			{
				FormTools.AddCheckBox(tabPage, "Use multiple monitors when necessary", Program.Preferences.Settings.UseMultipleMonitors, 0, ref rowIndex, ref num);
			}
			if (RdpClient.SupportsPanning)
			{
				this._enablePanningCheckBox = FormTools.NewCheckBox("Use panning instead of scroll bars", 0, rowIndex++, num++);
				this._enablePanningCheckBox.Setting = Program.Preferences.Settings.EnablePanning;
				this._enablePanningCheckBox.CheckedChanged += this.EnablePanningCheckedChanged;
				Label label = FormTools.NewLabel("Panning speed", 0, rowIndex);
				label.Size = new Size(116, 20);
				label.Location = new Point(this._enablePanningCheckBox.Left + 24, label.Top);
				this._panningAccelerationUpDown = new RdcNumericUpDown();
				this._panningAccelerationUpDown.Location = FormTools.NewLocation(1, rowIndex++);
				this._panningAccelerationUpDown.Minimum = 1m;
				this._panningAccelerationUpDown.Maximum = 9m;
				this._panningAccelerationUpDown.Size = new Size(40, 20);
				this._panningAccelerationUpDown.TabIndex = num++;
				this._panningAccelerationUpDown.Setting = Program.Preferences.Settings.PanningAcceleration;
				tabPage.Controls.Add(new Control[]
				{
					this._enablePanningCheckBox,
					label,
					this._panningAccelerationUpDown
				});
			}
			tabPage.Controls.Add(new Control[]
			{
				this._connectionBarEnabledCheckBox,
				this._connectionBarAutoHiddenCheckBox
			});
			return tabPage;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000CAC8 File Offset: 0x0000ACC8
		private TabPage CreateExperiencePage()
		{
			TabPage tabPage = this.NewTabPage("Experience");
			int rowIndex = 0;
			int num = 0;
			this._bandwidthComboBox = FormTools.AddLabeledValueDropDown<GlobalOptionsDialog.BandwidthItem>(tabPage, "Connection &speed", ref rowIndex, ref num, (GlobalOptionsDialog.BandwidthItem v) => v.Text, this._bandwidthItems);
			this._bandwidthComboBox.SelectedIndexChanged += this.BandwidthCombo_ControlChanged;
			Label label = FormTools.NewLabel("Allow the following:", 0, rowIndex);
			this._desktopBackgroundCheckBox = FormTools.NewCheckBox("Desktop background", 1, rowIndex++, num++);
			this._desktopBackgroundCheckBox.CheckedChanged += this.PerfCheckBox_CheckedChanged;
			this._fontSmoothingCheckBox = FormTools.NewCheckBox("Font smoothing", 1, rowIndex++, num++);
			this._fontSmoothingCheckBox.CheckedChanged += this.PerfCheckBox_CheckedChanged;
			this._desktopCompositionCheckBox = FormTools.NewCheckBox("Desktop composition", 1, rowIndex++, num++);
			this._desktopCompositionCheckBox.CheckedChanged += this.PerfCheckBox_CheckedChanged;
			this._windowDragCheckBox = FormTools.NewCheckBox("Show contents of window while dragging", 1, rowIndex++, num++);
			this._windowDragCheckBox.CheckedChanged += this.PerfCheckBox_CheckedChanged;
			this._menuAnimationCheckBox = FormTools.NewCheckBox("Menu and window animation", 1, rowIndex++, num++);
			this._menuAnimationCheckBox.CheckedChanged += this.PerfCheckBox_CheckedChanged;
			this._themesCheckBox = FormTools.NewCheckBox("Themes", 1, rowIndex++, num++);
			this._themesCheckBox.CheckedChanged += this.PerfCheckBox_CheckedChanged;
			tabPage.Controls.Add(new Control[]
			{
				label,
				this._desktopBackgroundCheckBox,
				this._fontSmoothingCheckBox,
				this._desktopCompositionCheckBox,
				this._windowDragCheckBox,
				this._menuAnimationCheckBox,
				this._themesCheckBox
			});
			return tabPage;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000CCBC File Offset: 0x0000AEBC
		private TabPage CreateHotKeysPage()
		{
			GlobalSettings settings = Program.Preferences.Settings;
			TabPage tabPage = this.NewTabPage("Hot Keys");
			GroupBox groupBox = new GroupBox
			{
				Text = "ALT hot keys (only effective when Windows key combos are not redirected)"
			};
			int num = 0;
			int num2 = 0;
			this.AddHotKeyBox(groupBox, "ALT+TAB", "ALT+", settings.HotKeyAltTab, ref num, ref num2);
			this.AddHotKeyBox(groupBox, "ALT+SHIFT+TAB", "ALT+", settings.HotKeyAltShiftTab, ref num, ref num2);
			this.AddHotKeyBox(groupBox, "ALT+ESC", "ALT+", settings.HotKeyAltEsc, ref num, ref num2);
			this.AddHotKeyBox(groupBox, "ALT+SPACE", "ALT+", settings.HotKeyAltSpace, ref num, ref num2);
			this.AddHotKeyBox(groupBox, "CTRL+ESC", "ALT+", settings.HotKeyCtrlEsc, ref num, ref num2);
			groupBox.SizeAndLocate(null);
			GroupBox groupBox2 = new GroupBox
			{
				Text = "CTRL+ALT hot keys (always effective)"
			};
			num = 0;
			num2 = 0;
			this.AddHotKeyBox(groupBox2, "CTRL+ALT+DEL", "CTRL+ALT+", settings.HotKeyCtrlAltDel, ref num, ref num2);
			this.AddHotKeyBox(groupBox2, "Full screen", "CTRL+ALT+", settings.HotKeyFullScreen, ref num, ref num2);
			this.AddHotKeyBox(groupBox2, "Previous session", "CTRL+ALT+", settings.HotKeyFocusReleaseLeft, ref num, ref num2);
			this.AddHotKeyBox(groupBox2, "Select session", "CTRL+ALT+", settings.HotKeyFocusReleaseRight, ref num, ref num2);
			groupBox2.SizeAndLocate(groupBox);
			tabPage.Controls.Add(new Control[]
			{
				groupBox,
				groupBox2
			});
			return tabPage;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000CE30 File Offset: 0x0000B030
		private void AddHotKeyBox(Control parent, string label, string prefix, EnumSetting<Keys> setting, ref int rowIndex, ref int tabIndex)
		{
			parent.Controls.Add(FormTools.NewLabel(label, 0, rowIndex));
			HotKeyBox hotKeyBox = new HotKeyBox();
			hotKeyBox.Prefix = prefix;
			int colIndex = 1;
			int num = rowIndex;
			rowIndex = num + 1;
			hotKeyBox.Location = FormTools.NewLocation(colIndex, num);
			hotKeyBox.Size = new Size(340, 20);
			num = tabIndex;
			tabIndex = num + 1;
			hotKeyBox.TabIndex = num;
			hotKeyBox.Setting = setting;
			HotKeyBox value = hotKeyBox;
			parent.Controls.Add(value);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000CEB0 File Offset: 0x0000B0B0
		private TabPage CreateClientAreaPage()
		{
			this._casCustomButton = new Button();
			this._casCustomRadio = new RadioButton();
			this._thumbnailPercentageRadio = new RadioButton();
			this._thumbnailPixelsRadio = new RadioButton();
			this._thumbnailPixelsButton = new Button();
			TabPage tabPage = this.NewTabPage("Client Area");
			this._casSizeGroup = new GroupBox
			{
				Text = "Client Area Size"
			};
			this._casSizeGroup.Controls.AddRange(FormTools.NewSizeRadios());
			this._casCustomRadio.Size = new Size(72, 24);
			this._casCustomRadio.Text = "&Custom";
			this._casSizeGroup.Controls.Add(this._casCustomRadio);
			FormTools.LayoutGroupBox(this._casSizeGroup, 2, null, 1, 1);
			RdcCheckBox value = new RdcCheckBox
			{
				Size = new Size(480, 24),
				Text = "&Lock window size",
				Location = FormTools.NewLocation(0, 0),
				TabIndex = 0,
				TabStop = true,
				Setting = Program.Preferences.Settings.LockWindowSize
			};
			this._casSizeGroup.Controls.Add(value);
			this._casCustomButton.Location = new Point(this._casCustomRadio.Right + 10, this._casCustomRadio.Location.Y);
			this._casCustomButton.TabIndex = this._casCustomRadio.TabIndex + 1;
			this._casCustomButton.Click += this.CustomSizeClick;
			this._casSizeGroup.Controls.Add(this._casCustomButton);
			GroupBox groupBox = new GroupBox
			{
				Size = new Size(512, 72),
				Text = "Thumbnail Unit Size"
			};
			groupBox.Controls.Add(new Control[]
			{
				this._thumbnailPixelsRadio,
				this._thumbnailPercentageRadio
			});
			this._thumbnailPixelsRadio.Size = new Size(80, 24);
			this._thumbnailPixelsRadio.Text = "Pi&xels";
			this._thumbnailPercentageRadio.Size = new Size(88, 24);
			this._thumbnailPercentageRadio.Text = "Pe&rcentage";
			this._thumbnailPercentageRadio.CheckedChanged += this.ThumbnailPercentageRadioCheckedChanged;
			FormTools.LayoutGroupBox(groupBox, 1, this._casSizeGroup);
			int num = Math.Max(this._thumbnailPixelsRadio.Right, this._thumbnailPercentageRadio.Right);
			this._thumbnailPixelsButton.Location = new Point(num + 10, this._thumbnailPixelsRadio.Location.Y);
			this._thumbnailPixelsButton.TabIndex = this._thumbnailPercentageRadio.TabIndex + 1;
			this._thumbnailPixelsButton.Click += this.CustomSizeClick;
			this._thumbnailPercentageTextBox = new NumericTextBox(1, 100, "Percentage must be between 1 and 100 inclusive");
			this._thumbnailPercentageTextBox.Enabled = false;
			this._thumbnailPercentageTextBox.Location = new Point(num + 11, this._thumbnailPercentageRadio.Location.Y + 2);
			this._thumbnailPercentageTextBox.Size = new Size(72, 20);
			this._thumbnailPercentageTextBox.TabIndex = this._thumbnailPercentageRadio.TabIndex + 1;
			groupBox.Controls.Add(new Control[]
			{
				this._thumbnailPixelsButton,
				this._thumbnailPercentageTextBox
			});
			tabPage.Controls.Add(new Control[]
			{
				this._casSizeGroup,
				groupBox
			});
			return tabPage;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000D22C File Offset: 0x0000B42C
		private TabPage CreateServerTreePage()
		{
			int num = 0;
			int num2 = 0;
			TabPage tabPage = this.NewTabPage("Tree");
			GroupBox groupBox = new GroupBox
			{
				Text = "Server Tree"
			};
			FormTools.AddCheckBox(groupBox, "Click to select gives focus to remote client", Program.Preferences.Settings.FocusOnClick, 0, ref num, ref num2);
			FormTools.AddCheckBox(groupBox, "Dim nodes when tree control is inactive", Program.Preferences.Settings.DimNodesWhenInactive, 0, ref num, ref num2);
			this._treeLocationCombo = FormTools.AddLabeledValueDropDown<DockStyle>(groupBox, "Location", ref num, ref num2, (DockStyle v) => v.ToString(), new DockStyle[]
			{
				DockStyle.Left,
				DockStyle.Right
			});
			this._treeVisibilityCombo = FormTools.AddLabeledValueDropDown<ControlVisibility>(groupBox, "Visibility", ref num, ref num2, (ControlVisibility v) => v.ToString(), new ControlVisibility[]
			{
				ControlVisibility.Dock,
				ControlVisibility.AutoHide,
				ControlVisibility.Hide
			});
			Label label = FormTools.NewLabel("Pop up delay:", 0, num++);
			label.Left += 24;
			label.Size = new Size(80, label.Height);
			NumericTextBox serverTreeAutoHidePopUpDelay = new NumericTextBox(0, 1000, "Auto hide pop-up delay must be 0 to 1000 milliseconds")
			{
				Enabled = false,
				Location = new Point(label.Right, label.Top),
				Size = new Size(40, 24),
				Setting = Program.Preferences.Settings.ServerTreeAutoHidePopUpDelay,
				TabStop = true,
				TabIndex = num2++
			};
			this._treeVisibilityCombo.SelectedIndexChanged += delegate(object s, EventArgs e)
			{
				serverTreeAutoHidePopUpDelay.Enabled = (this._treeVisibilityCombo.SelectedValue == ControlVisibility.AutoHide);
			};
			groupBox.AddControlsAndSizeGroup(new Control[]
			{
				label
			});
			Label label2 = new Label
			{
				Location = new Point(serverTreeAutoHidePopUpDelay.Right + 3, label.Top),
				Size = new Size(80, 24),
				Text = "millisecond(s)"
			};
			groupBox.Controls.Add(new Control[]
			{
				serverTreeAutoHidePopUpDelay,
				label2
			});
			groupBox.SizeAndLocate(null);
			this._virtualGroupsGroup = new GroupBox
			{
				Text = "Virtual Groups"
			};
			foreach (IBuiltInVirtualGroup builtInVirtualGroup in from @group in Program.BuiltInVirtualGroups
			where @group.IsVisibilityConfigurable
			select @group)
			{
				this._virtualGroupsGroup.Controls.Add(new CheckBox
				{
					Size = new Size(112, 24),
					Tag = builtInVirtualGroup,
					Text = builtInVirtualGroup.Text
				});
			}
			FormTools.LayoutGroupBox(this._virtualGroupsGroup, 2, groupBox);
			num = 0;
			num2 = 0;
			GroupBox groupBox2 = new GroupBox();
			FormTools.AddLabeledValueDropDown<SortOrder>(groupBox2, "Group sort order", Program.Preferences.Settings.GroupSortOrder, ref num, ref num2, new Func<SortOrder, string>(Helpers.SortOrderToString), new SortOrder[]
			{
				SortOrder.ByName,
				SortOrder.None
			});
			FormTools.AddLabeledEnumDropDown<SortOrder>(groupBox2, "Server sort order", Program.Preferences.Settings.ServerSortOrder, ref num, ref num2, new Func<SortOrder, string>(Helpers.SortOrderToString));
			groupBox2.Text = "Sort Order";
			FormTools.LayoutGroupBox(groupBox2, 2, this._virtualGroupsGroup);
			tabPage.Controls.Add(new Control[]
			{
				groupBox,
				groupBox2,
				this._virtualGroupsGroup
			});
			return tabPage;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000D5D4 File Offset: 0x0000B7D4
		private TabPage CreateGeneralPage()
		{
			int num = 0;
			int num2 = 0;
			TabPage tabPage = this.NewTabPage("General");
			FormTools.AddCheckBox(tabPage, "Hide main menu until ALT pressed", Program.Preferences.Settings.HideMainMenu, 0, ref num, ref num2);
			RdcCheckBox autoSaveCheckBox = FormTools.AddCheckBox(tabPage, "Auto save interval:", Program.Preferences.Settings.AutoSaveFiles, 0, ref num, ref num2);
			autoSaveCheckBox.Size = new Size(120, 24);
			NumericTextBox autoSaveInterval = new NumericTextBox(0, 60, "Auto save interval must 0 to 60 minutes inclusive")
			{
				Location = new Point(autoSaveCheckBox.Right + 1, autoSaveCheckBox.Top + 2),
				Size = new Size(20, 24),
				TabIndex = num2++,
				TabStop = true,
				Enabled = false
			};
			autoSaveInterval.Setting = Program.Preferences.Settings.AutoSaveInterval;
			autoSaveCheckBox.CheckedChanged += delegate(object s, EventArgs e)
			{
				autoSaveInterval.Enabled = autoSaveCheckBox.Checked;
			};
			Label label = new Label
			{
				Location = new Point(autoSaveInterval.Right + 3, autoSaveCheckBox.Top + 4),
				Size = new Size(60, 24),
				Text = "minute(s)"
			};
			RdcCheckBox rdcCheckBox = FormTools.AddCheckBox(tabPage, "Prompt to reconnect connected servers on startup", Program.Preferences.Settings.ReconnectOnStartup, 0, ref num, ref num2);
			Button button = new Button
			{
				Location = new Point(8, rdcCheckBox.Bottom + 8),
				TabIndex = num2++,
				Text = "Default group settings...",
				Width = 140
			};
			button.Click += delegate(object s, EventArgs e)
			{
				DefaultSettingsGroup.Instance.DoPropertiesDialog();
			};
			tabPage.Controls.Add(new Control[]
			{
				autoSaveCheckBox,
				autoSaveInterval,
				label,
				button
			});
			return tabPage;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002B99 File Offset: 0x00000D99
		private void EnablePanningCheckedChanged(object sender, EventArgs e)
		{
			this._panningAccelerationUpDown.Enabled = this._enablePanningCheckBox.Checked;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00002BB1 File Offset: 0x00000DB1
		private void ConnectionBarEnabledCheckedChanged(object sender, EventArgs e)
		{
			this._connectionBarAutoHiddenCheckBox.Enabled = this._connectionBarEnabledCheckBox.Checked;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000D7DC File Offset: 0x0000B9DC
		private void CustomSizeClick(object sender, EventArgs e)
		{
			Button button = sender as Button;
			Size size = SizeHelper.Parse(button.Text);
			using (CustomSizeDialog customSizeDialog = new CustomSizeDialog(size))
			{
				if (customSizeDialog.ShowDialog() == DialogResult.OK)
				{
					button.Text = customSizeDialog.WidthText + SizeHelper.Separator + customSizeDialog.HeightText;
					this._thumbnailPixelsRadio.Checked = true;
				}
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002BC9 File Offset: 0x00000DC9
		private void ThumbnailPercentageRadioCheckedChanged(object sender, EventArgs e)
		{
			this._thumbnailPercentageTextBox.Enabled = (sender as RadioButton).Checked;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002BE1 File Offset: 0x00000DE1
		private void BandwidthCombo_ControlChanged(object sender, EventArgs e)
		{
			this.BandwidthSettingsChanged();
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002BE9 File Offset: 0x00000DE9
		private void BandwidthSettingsChanged()
		{
			if (this._inHandler)
			{
				return;
			}
			this._inHandler = true;
			this.SetBandwidthCheckBoxes(this._bandwidthComboBox.SelectedValue.Flags);
			this._inHandler = false;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0000D850 File Offset: 0x0000BA50
		private void SetBandwidthCheckBoxes(int flags)
		{
			this._desktopBackgroundCheckBox.Checked = ((flags & 1) == 0);
			this._fontSmoothingCheckBox.Checked = ((flags & 128) != 0);
			this._desktopCompositionCheckBox.Checked = ((flags & 256) != 0);
			this._windowDragCheckBox.Checked = ((flags & 2) == 0);
			this._menuAnimationCheckBox.Checked = ((flags & 4) == 0);
			this._themesCheckBox.Checked = ((flags & 8) == 0);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000D8CC File Offset: 0x0000BACC
		private void PerfCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (this._inHandler)
			{
				return;
			}
			this._inHandler = true;
			int flags = this.ComputeFlagsFromCheckBoxes();
			GlobalOptionsDialog.BandwidthItem bandwidthItem;
			if ((bandwidthItem = (from i in this._bandwidthItems
			where i.Flags == flags
			select i).FirstOrDefault<GlobalOptionsDialog.BandwidthItem>()) == null)
			{
				bandwidthItem = this._bandwidthItems.First((GlobalOptionsDialog.BandwidthItem i) => i.Text.Equals("Custom"));
			}
			GlobalOptionsDialog.BandwidthItem selectedValue = bandwidthItem;
			this._bandwidthComboBox.SelectedValue = selectedValue;
			this._inHandler = false;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0000D95C File Offset: 0x0000BB5C
		private int ComputeFlagsFromCheckBoxes()
		{
			int num = 0;
			if (!this._desktopBackgroundCheckBox.Checked)
			{
				num |= 1;
			}
			if (this._fontSmoothingCheckBox.Checked)
			{
				num |= 128;
			}
			if (this._desktopCompositionCheckBox.Checked)
			{
				num |= 256;
			}
			if (!this._windowDragCheckBox.Checked)
			{
				num |= 2;
			}
			if (!this._menuAnimationCheckBox.Checked)
			{
				num |= 4;
			}
			if (!this._themesCheckBox.Checked)
			{
				num |= 8;
			}
			return num;
		}

		// Token: 0x040002B0 RID: 688
		private GroupBox _virtualGroupsGroup;

		// Token: 0x040002B1 RID: 689
		private ValueComboBox<ControlVisibility> _treeVisibilityCombo;

		// Token: 0x040002B2 RID: 690
		private ValueComboBox<DockStyle> _treeLocationCombo;

		// Token: 0x040002B3 RID: 691
		private CheckBox _connectionBarEnabledCheckBox;

		// Token: 0x040002B4 RID: 692
		private CheckBox _connectionBarAutoHiddenCheckBox;

		// Token: 0x040002B5 RID: 693
		private RdcCheckBox _enablePanningCheckBox;

		// Token: 0x040002B6 RID: 694
		private RdcNumericUpDown _panningAccelerationUpDown;

		// Token: 0x040002B7 RID: 695
		private GroupBox _casSizeGroup;

		// Token: 0x040002B8 RID: 696
		private RadioButton _casCustomRadio;

		// Token: 0x040002B9 RID: 697
		private RadioButton _thumbnailPixelsRadio;

		// Token: 0x040002BA RID: 698
		private RadioButton _thumbnailPercentageRadio;

		// Token: 0x040002BB RID: 699
		private TextBox _thumbnailPercentageTextBox;

		// Token: 0x040002BC RID: 700
		private Button _casCustomButton;

		// Token: 0x040002BD RID: 701
		private Button _thumbnailPixelsButton;

		// Token: 0x040002BE RID: 702
		private ValueComboBox<GlobalOptionsDialog.BandwidthItem> _bandwidthComboBox;

		// Token: 0x040002BF RID: 703
		private CheckBox _desktopBackgroundCheckBox;

		// Token: 0x040002C0 RID: 704
		private CheckBox _fontSmoothingCheckBox;

		// Token: 0x040002C1 RID: 705
		private CheckBox _desktopCompositionCheckBox;

		// Token: 0x040002C2 RID: 706
		private CheckBox _windowDragCheckBox;

		// Token: 0x040002C3 RID: 707
		private CheckBox _menuAnimationCheckBox;

		// Token: 0x040002C4 RID: 708
		private CheckBox _themesCheckBox;

		// Token: 0x040002C5 RID: 709
		private bool _inHandler;

		// Token: 0x040002C6 RID: 710
		private readonly GlobalOptionsDialog.BandwidthItem[] _bandwidthItems;

		// Token: 0x02000053 RID: 83
		private class BandwidthItem
		{
			// Token: 0x0600016B RID: 363 RVA: 0x00002C18 File Offset: 0x00000E18
			public BandwidthItem(string text, int flags)
			{
				this.Text = text;
				this.Flags = flags;
			}

			// Token: 0x040002C7 RID: 711
			public string Text;

			// Token: 0x040002C8 RID: 712
			public int Flags;
		}
	}
}
