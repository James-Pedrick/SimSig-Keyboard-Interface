namespace SimSig_Keyboard_Interface.User_Interface
{
	partial class MainMenu
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadSaveXML = new System.Windows.Forms.ToolStripMenuItem();
			this.tcpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tcpConnect = new System.Windows.Forms.ToolStripMenuItem();
			this.networkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.berthsResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.signalResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.savePointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveSignalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveBerthsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveRawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.debug = new System.Windows.Forms.TabPage();
			this.debugTabs = new System.Windows.Forms.TabControl();
			this.debugBerths = new System.Windows.Forms.TabPage();
			this.debugBerthView = new System.Windows.Forms.DataGridView();
			this.debugSignals = new System.Windows.Forms.TabPage();
			this.debugSignalView = new System.Windows.Forms.DataGridView();
			this.debugPoints = new System.Windows.Forms.TabPage();
			this.debugPointView = new System.Windows.Forms.DataGridView();
			this.debugRaw = new System.Windows.Forms.TabPage();
			this.debugRawTcpDisplay = new System.Windows.Forms.ListBox();
			this.keyboardInterface = new System.Windows.Forms.TabPage();
			this.keyboardInterpose = new System.Windows.Forms.Button();
			this.userInputString = new System.Windows.Forms.TextBox();
			this.loadSaveGameXML = new System.Windows.Forms.OpenFileDialog();
			this.dataSave = new System.Windows.Forms.SaveFileDialog();
			this.debugTracks = new System.Windows.Forms.TabPage();
			this.debugTrackView = new System.Windows.Forms.DataGridView();
			this.menuStrip.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.debug.SuspendLayout();
			this.debugTabs.SuspendLayout();
			this.debugBerths.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.debugBerthView)).BeginInit();
			this.debugSignals.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.debugSignalView)).BeginInit();
			this.debugPoints.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.debugPointView)).BeginInit();
			this.debugRaw.SuspendLayout();
			this.keyboardInterface.SuspendLayout();
			this.debugTracks.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.debugTrackView)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.tcpToolStripMenuItem,
            this.networkToolStripMenuItem,
            this.dataToolStripMenuItem1,
            this.logsToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(803, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "Menu Strip";
			this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// dataToolStripMenuItem
			// 
			this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadSaveXML});
			this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
			this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.dataToolStripMenuItem.Text = "Data";
			// 
			// loadSaveXML
			// 
			this.loadSaveXML.Name = "loadSaveXML";
			this.loadSaveXML.Size = new System.Drawing.Size(188, 22);
			this.loadSaveXML.Text = "Load Save Game XML";
			this.loadSaveXML.Click += new System.EventHandler(this.MenuLoadSaveXml);
			// 
			// tcpToolStripMenuItem
			// 
			this.tcpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tcpConnect});
			this.tcpToolStripMenuItem.Enabled = false;
			this.tcpToolStripMenuItem.Name = "tcpToolStripMenuItem";
			this.tcpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.tcpToolStripMenuItem.Text = "TCP";
			// 
			// tcpConnect
			// 
			this.tcpConnect.Name = "tcpConnect";
			this.tcpConnect.Size = new System.Drawing.Size(119, 22);
			this.tcpConnect.Text = "Connect";
			// 
			// networkToolStripMenuItem
			// 
			this.networkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem});
			this.networkToolStripMenuItem.Name = "networkToolStripMenuItem";
			this.networkToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
			this.networkToolStripMenuItem.Text = "Network";
			// 
			// clientToolStripMenuItem
			// 
			this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem});
			this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
			this.clientToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
			this.clientToolStripMenuItem.Text = "Client";
			// 
			// connectToolStripMenuItem
			// 
			this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
			this.connectToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.connectToolStripMenuItem.Text = "Connect";
			this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
			// 
			// dataToolStripMenuItem1
			// 
			this.dataToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.berthsResetToolStripMenuItem,
            this.pointsToolStripMenuItem,
            this.signalResetToolStripMenuItem});
			this.dataToolStripMenuItem1.Name = "dataToolStripMenuItem1";
			this.dataToolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
			this.dataToolStripMenuItem1.Text = "Data";
			// 
			// berthsResetToolStripMenuItem
			// 
			this.berthsResetToolStripMenuItem.Name = "berthsResetToolStripMenuItem";
			this.berthsResetToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
			this.berthsResetToolStripMenuItem.Text = "Berths Reset";
			this.berthsResetToolStripMenuItem.Click += new System.EventHandler(this.BerthListReset);
			// 
			// pointsToolStripMenuItem
			// 
			this.pointsToolStripMenuItem.Name = "pointsToolStripMenuItem";
			this.pointsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
			this.pointsToolStripMenuItem.Text = "Points Reset";
			this.pointsToolStripMenuItem.Click += new System.EventHandler(this.Point_List_Reset);
			// 
			// signalResetToolStripMenuItem
			// 
			this.signalResetToolStripMenuItem.Name = "signalResetToolStripMenuItem";
			this.signalResetToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
			this.signalResetToolStripMenuItem.Text = "Signals Reset";
			this.signalResetToolStripMenuItem.Click += new System.EventHandler(this.SignalListReset);
			// 
			// logsToolStripMenuItem
			// 
			this.logsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savePointsToolStripMenuItem,
            this.saveSignalsToolStripMenuItem,
            this.saveBerthsToolStripMenuItem,
            this.saveRawToolStripMenuItem});
			this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
			this.logsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.logsToolStripMenuItem.Text = "Logs";
			// 
			// savePointsToolStripMenuItem
			// 
			this.savePointsToolStripMenuItem.Name = "savePointsToolStripMenuItem";
			this.savePointsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.savePointsToolStripMenuItem.Text = "Save Points";
			// 
			// saveSignalsToolStripMenuItem
			// 
			this.saveSignalsToolStripMenuItem.Name = "saveSignalsToolStripMenuItem";
			this.saveSignalsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.saveSignalsToolStripMenuItem.Text = "Save Signals";
			// 
			// saveBerthsToolStripMenuItem
			// 
			this.saveBerthsToolStripMenuItem.Name = "saveBerthsToolStripMenuItem";
			this.saveBerthsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.saveBerthsToolStripMenuItem.Text = "Save Berths";
			// 
			// saveRawToolStripMenuItem
			// 
			this.saveRawToolStripMenuItem.Name = "saveRawToolStripMenuItem";
			this.saveRawToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.saveRawToolStripMenuItem.Text = "Save Raw";
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.debug);
			this.tabControl.Controls.Add(this.keyboardInterface);
			this.tabControl.Cursor = System.Windows.Forms.Cursors.Default;
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 24);
			this.tabControl.Multiline = true;
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(803, 487);
			this.tabControl.TabIndex = 1;
			// 
			// debug
			// 
			this.debug.Controls.Add(this.debugTabs);
			this.debug.Location = new System.Drawing.Point(4, 22);
			this.debug.Name = "debug";
			this.debug.Size = new System.Drawing.Size(795, 461);
			this.debug.TabIndex = 1;
			this.debug.Text = "Debug";
			this.debug.UseVisualStyleBackColor = true;
			// 
			// debugTabs
			// 
			this.debugTabs.Controls.Add(this.debugBerths);
			this.debugTabs.Controls.Add(this.debugSignals);
			this.debugTabs.Controls.Add(this.debugPoints);
			this.debugTabs.Controls.Add(this.debugTracks);
			this.debugTabs.Controls.Add(this.debugRaw);
			this.debugTabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.debugTabs.Location = new System.Drawing.Point(0, 0);
			this.debugTabs.Multiline = true;
			this.debugTabs.Name = "debugTabs";
			this.debugTabs.SelectedIndex = 0;
			this.debugTabs.Size = new System.Drawing.Size(795, 461);
			this.debugTabs.TabIndex = 0;
			// 
			// debugBerths
			// 
			this.debugBerths.Controls.Add(this.debugBerthView);
			this.debugBerths.Location = new System.Drawing.Point(4, 22);
			this.debugBerths.Name = "debugBerths";
			this.debugBerths.Size = new System.Drawing.Size(787, 435);
			this.debugBerths.TabIndex = 2;
			this.debugBerths.Text = "Berths";
			this.debugBerths.UseVisualStyleBackColor = true;
			// 
			// debugBerthView
			// 
			this.debugBerthView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.debugBerthView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.debugBerthView.Location = new System.Drawing.Point(0, 0);
			this.debugBerthView.Name = "debugBerthView";
			this.debugBerthView.ReadOnly = true;
			this.debugBerthView.RowTemplate.ReadOnly = true;
			this.debugBerthView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.debugBerthView.Size = new System.Drawing.Size(787, 435);
			this.debugBerthView.TabIndex = 2;
			// 
			// debugSignals
			// 
			this.debugSignals.Controls.Add(this.debugSignalView);
			this.debugSignals.Location = new System.Drawing.Point(4, 22);
			this.debugSignals.Name = "debugSignals";
			this.debugSignals.Size = new System.Drawing.Size(787, 435);
			this.debugSignals.TabIndex = 1;
			this.debugSignals.Text = "Signals";
			this.debugSignals.UseVisualStyleBackColor = true;
			// 
			// debugSignalView
			// 
			this.debugSignalView.AllowUserToAddRows = false;
			this.debugSignalView.AllowUserToDeleteRows = false;
			this.debugSignalView.AllowUserToOrderColumns = true;
			this.debugSignalView.AllowUserToResizeColumns = false;
			this.debugSignalView.AllowUserToResizeRows = false;
			this.debugSignalView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
			this.debugSignalView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.debugSignalView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.debugSignalView.Location = new System.Drawing.Point(0, 0);
			this.debugSignalView.Name = "debugSignalView";
			this.debugSignalView.ReadOnly = true;
			this.debugSignalView.Size = new System.Drawing.Size(787, 435);
			this.debugSignalView.TabIndex = 1;
			// 
			// debugPoints
			// 
			this.debugPoints.Controls.Add(this.debugPointView);
			this.debugPoints.Location = new System.Drawing.Point(4, 22);
			this.debugPoints.Name = "debugPoints";
			this.debugPoints.Padding = new System.Windows.Forms.Padding(3);
			this.debugPoints.Size = new System.Drawing.Size(787, 435);
			this.debugPoints.TabIndex = 0;
			this.debugPoints.Text = "Points";
			this.debugPoints.UseVisualStyleBackColor = true;
			// 
			// debugPointView
			// 
			this.debugPointView.AllowUserToAddRows = false;
			this.debugPointView.AllowUserToDeleteRows = false;
			this.debugPointView.AllowUserToOrderColumns = true;
			this.debugPointView.AllowUserToResizeColumns = false;
			this.debugPointView.AllowUserToResizeRows = false;
			this.debugPointView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.debugPointView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.debugPointView.Location = new System.Drawing.Point(3, 3);
			this.debugPointView.Name = "debugPointView";
			this.debugPointView.ReadOnly = true;
			this.debugPointView.Size = new System.Drawing.Size(781, 429);
			this.debugPointView.TabIndex = 1;
			// 
			// debugRaw
			// 
			this.debugRaw.Controls.Add(this.debugRawTcpDisplay);
			this.debugRaw.Location = new System.Drawing.Point(4, 22);
			this.debugRaw.Name = "debugRaw";
			this.debugRaw.Size = new System.Drawing.Size(787, 435);
			this.debugRaw.TabIndex = 3;
			this.debugRaw.Text = "Raw";
			this.debugRaw.UseVisualStyleBackColor = true;
			// 
			// debugRawTcpDisplay
			// 
			this.debugRawTcpDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
			this.debugRawTcpDisplay.FormattingEnabled = true;
			this.debugRawTcpDisplay.Location = new System.Drawing.Point(0, 0);
			this.debugRawTcpDisplay.Name = "debugRawTcpDisplay";
			this.debugRawTcpDisplay.Size = new System.Drawing.Size(787, 435);
			this.debugRawTcpDisplay.TabIndex = 4;
			// 
			// keyboardInterface
			// 
			this.keyboardInterface.BackColor = System.Drawing.Color.Black;
			this.keyboardInterface.Controls.Add(this.keyboardInterpose);
			this.keyboardInterface.Controls.Add(this.userInputString);
			this.keyboardInterface.Location = new System.Drawing.Point(4, 22);
			this.keyboardInterface.Name = "keyboardInterface";
			this.keyboardInterface.Padding = new System.Windows.Forms.Padding(3);
			this.keyboardInterface.Size = new System.Drawing.Size(795, 461);
			this.keyboardInterface.TabIndex = 0;
			this.keyboardInterface.Text = "Keyboard Interface";
			// 
			// keyboardInterpose
			// 
			this.keyboardInterpose.Location = new System.Drawing.Point(8, 67);
			this.keyboardInterpose.Name = "keyboardInterpose";
			this.keyboardInterpose.Size = new System.Drawing.Size(123, 23);
			this.keyboardInterpose.TabIndex = 1;
			this.keyboardInterpose.Text = "Interpose";
			this.keyboardInterpose.UseVisualStyleBackColor = true;
			this.keyboardInterpose.Click += new System.EventHandler(this.keyboardInterpose_Click);
			// 
			// userInputString
			// 
			this.userInputString.BackColor = System.Drawing.SystemColors.InfoText;
			this.userInputString.Font = new System.Drawing.Font("Engravers MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.userInputString.ForeColor = System.Drawing.Color.Cyan;
			this.userInputString.Location = new System.Drawing.Point(7, 7);
			this.userInputString.MinimumSize = new System.Drawing.Size(4, 25);
			this.userInputString.Name = "userInputString";
			this.userInputString.Size = new System.Drawing.Size(294, 25);
			this.userInputString.TabIndex = 0;
			this.userInputString.Text = "1212";
			// 
			// loadSaveGameXML
			// 
			this.loadSaveGameXML.FileName = "openFileDialog1";
			// 
			// debugTracks
			// 
			this.debugTracks.Controls.Add(this.debugTrackView);
			this.debugTracks.Location = new System.Drawing.Point(4, 22);
			this.debugTracks.Name = "debugTracks";
			this.debugTracks.Size = new System.Drawing.Size(787, 435);
			this.debugTracks.TabIndex = 4;
			this.debugTracks.Text = "Tracks";
			this.debugTracks.UseVisualStyleBackColor = true;
			// 
			// debugTrackView
			// 
			this.debugTrackView.AllowUserToAddRows = false;
			this.debugTrackView.AllowUserToDeleteRows = false;
			this.debugTrackView.AllowUserToOrderColumns = true;
			this.debugTrackView.AllowUserToResizeColumns = false;
			this.debugTrackView.AllowUserToResizeRows = false;
			this.debugTrackView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
			this.debugTrackView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.debugTrackView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.debugTrackView.Location = new System.Drawing.Point(0, 0);
			this.debugTrackView.Name = "debugTrackView";
			this.debugTrackView.ReadOnly = true;
			this.debugTrackView.Size = new System.Drawing.Size(787, 435);
			this.debugTrackView.TabIndex = 2;
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(803, 511);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.menuStrip);
			this.Name = "MainMenu";
			this.Text = "SimSig Keyboard Interface";
			this.Load += new System.EventHandler(this.MainMenu_Load);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.tabControl.ResumeLayout(false);
			this.debug.ResumeLayout(false);
			this.debugTabs.ResumeLayout(false);
			this.debugBerths.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.debugBerthView)).EndInit();
			this.debugSignals.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.debugSignalView)).EndInit();
			this.debugPoints.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.debugPointView)).EndInit();
			this.debugRaw.ResumeLayout(false);
			this.keyboardInterface.ResumeLayout(false);
			this.keyboardInterface.PerformLayout();
			this.debugTracks.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.debugTrackView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tcpToolStripMenuItem;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage keyboardInterface;
		private System.Windows.Forms.TabPage debug;
		private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadSaveXML;
		private System.Windows.Forms.OpenFileDialog loadSaveGameXML;
		private System.Windows.Forms.ToolStripMenuItem networkToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tcpConnect;
		private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem pointsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem berthsResetToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem signalResetToolStripMenuItem;
		private System.Windows.Forms.TabControl debugTabs;
		private System.Windows.Forms.TabPage debugBerths;
		private System.Windows.Forms.DataGridView debugBerthView;
		private System.Windows.Forms.TabPage debugSignals;
		private System.Windows.Forms.DataGridView debugSignalView;
		private System.Windows.Forms.TabPage debugPoints;
		private System.Windows.Forms.DataGridView debugPointView;
		private System.Windows.Forms.TabPage debugRaw;
		public System.Windows.Forms.ListBox debugRawTcpDisplay;
		private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem savePointsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveSignalsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveBerthsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveRawToolStripMenuItem;
		private System.Windows.Forms.SaveFileDialog dataSave;
		public System.Windows.Forms.TextBox userInputString;
		private System.Windows.Forms.Button keyboardInterpose;
		private System.Windows.Forms.TabPage debugTracks;
		private System.Windows.Forms.DataGridView debugTrackView;
	}
}

