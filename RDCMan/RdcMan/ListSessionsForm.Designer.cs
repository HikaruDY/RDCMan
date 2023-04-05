namespace RdcMan
{
	// Token: 0x02000062 RID: 98
	internal partial class ListSessionsForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000278 RID: 632 RVA: 0x0000DFB4 File Offset: 0x0000C1B4
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000DFDC File Offset: 0x0000C1DC
		private void InitializeComponent()
		{
			this.StatusLabel = new global::System.Windows.Forms.Label();
			this.SessionListView = new global::System.Windows.Forms.ListView();
			this.idHeader1 = new global::System.Windows.Forms.ColumnHeader();
			this.stateHeader1 = new global::System.Windows.Forms.ColumnHeader();
			this.userHeader1 = new global::System.Windows.Forms.ColumnHeader();
			this.clientHeader1 = new global::System.Windows.Forms.ColumnHeader();
			this.RefreshButton = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.StatusLabel.Location = new global::System.Drawing.Point(12, 9);
			this.StatusLabel.Name = "StatusLabel";
			this.StatusLabel.Size = new global::System.Drawing.Size(238, 24);
			this.StatusLabel.TabIndex = 0;
			this.StatusLabel.Text = "Querying sessions...";
			this.SessionListView.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.idHeader1,
				this.stateHeader1,
				this.userHeader1,
				this.clientHeader1
			});
			this.SessionListView.FullRowSelect = true;
			this.SessionListView.Location = new global::System.Drawing.Point(10, 42);
			this.SessionListView.MultiSelect = false;
			this.SessionListView.Name = "SessionListView";
			this.SessionListView.Size = new global::System.Drawing.Size(345, 154);
			this.SessionListView.TabIndex = 1;
			this.SessionListView.UseCompatibleStateImageBehavior = false;
			this.SessionListView.View = global::System.Windows.Forms.View.Details;
			this.SessionListView.ColumnClick += new global::System.Windows.Forms.ColumnClickEventHandler(this.SessionListView_ColumnClick);
			this.idHeader1.Text = "Id";
			this.idHeader1.Width = 30;
			this.stateHeader1.Text = "State";
			this.stateHeader1.Width = 80;
			this.userHeader1.Text = "User";
			this.userHeader1.Width = 135;
			this.clientHeader1.Text = "Client";
			this.clientHeader1.Width = 96;
			this.RefreshButton.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.RefreshButton.Location = new global::System.Drawing.Point(256, 9);
			this.RefreshButton.Name = "RefreshButton";
			this.RefreshButton.Size = new global::System.Drawing.Size(100, 24);
			this.RefreshButton.TabIndex = 2;
			this.RefreshButton.Text = "Refresh";
			this.RefreshButton.UseVisualStyleBackColor = true;
			this.RefreshButton.Click += new global::System.EventHandler(this.RefreshButton_Click);
			base.ClientSize = new global::System.Drawing.Size(366, 206);
			base.Controls.Add(this.RefreshButton);
			base.Controls.Add(this.SessionListView);
			base.Controls.Add(this.StatusLabel);
			base.Name = "ListSessionsForm";
			base.Load += new global::System.EventHandler(this.ListSessionsForm_Load);
			base.SizeChanged += new global::System.EventHandler(this.ListSessionsForm_SizeChanged);
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.ListSessionsForm_FormClosed);
			base.Resize += new global::System.EventHandler(this.ListSessionsForm_Resize);
			base.ResumeLayout(false);
		}

		// Token: 0x04000144 RID: 324
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000145 RID: 325
		public global::System.Windows.Forms.Label StatusLabel;

		// Token: 0x04000146 RID: 326
		public global::System.Windows.Forms.ListView SessionListView;

		// Token: 0x04000147 RID: 327
		private global::System.Windows.Forms.ColumnHeader idHeader1;

		// Token: 0x04000148 RID: 328
		private global::System.Windows.Forms.ColumnHeader stateHeader1;

		// Token: 0x04000149 RID: 329
		private global::System.Windows.Forms.ColumnHeader userHeader1;

		// Token: 0x0400014A RID: 330
		private global::System.Windows.Forms.ColumnHeader clientHeader1;

		// Token: 0x0400014B RID: 331
		private global::System.Windows.Forms.Button RefreshButton;
	}
}
