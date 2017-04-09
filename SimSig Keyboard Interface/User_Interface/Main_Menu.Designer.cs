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
			this.tabControl = new System.Windows.Forms.TabControl();
			this.debug = new System.Windows.Forms.TabPage();
			this.debugTabs = new System.Windows.Forms.TabControl();
			this.debugBerths = new System.Windows.Forms.TabPage();
			this.debugBerthView = new System.Windows.Forms.DataGridView();
			this.debugSignals = new System.Windows.Forms.TabPage();
			this.debugSignalView = new System.Windows.Forms.DataGridView();
			this.debugPoints = new System.Windows.Forms.TabPage();
			this.debugPointView = new System.Windows.Forms.DataGridView();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.loadSaveGameXML = new System.Windows.Forms.OpenFileDialog();
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
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.tcpToolStripMenuItem,
            this.networkToolStripMenuItem,
            this.dataToolStripMenuItem1});
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
			this.loadSaveXML.Click += new System.EventHandler(this.loadSaveGameXMLToolStripMenuItem_Click);
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
			// tabControl
			// 
			this.tabControl.Controls.Add(this.debug);
			this.tabControl.Controls.Add(this.tabPage1);
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
			this.debugBerthView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.debugBerthView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.debugBerthView.Location = new System.Drawing.Point(3, 3);
			this.debugBerthView.Name = "debugBerthView";
			this.debugBerthView.ReadOnly = true;
			this.debugBerthView.Size = new System.Drawing.Size(781, 429);
			this.debugBerthView.TabIndex = 2;
			// 
			// debugSignals
			// 
			this.debugSignals.Controls.Add(this.debugSignalView);
			this.debugSignals.Location = new System.Drawing.Point(4, 22);
			this.debugSignals.Name = "debugSignals";
			this.debugSignals.Size = new System.Drawing.Size(787, 459);
			this.debugSignals.TabIndex = 1;
			this.debugSignals.Text = "Signals";
			this.debugSignals.UseVisualStyleBackColor = true;
			// 
			// debugSignalView
			// 
			this.debugSignalView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.debugSignalView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.debugSignalView.Location = new System.Drawing.Point(3, 3);
			this.debugSignalView.Name = "debugSignalView";
			this.debugSignalView.ReadOnly = true;
			this.debugSignalView.Size = new System.Drawing.Size(781, 453);
			this.debugSignalView.TabIndex = 1;
			// 
			// debugPoints
			// 
			this.debugPoints.Controls.Add(this.debugPointView);
			this.debugPoints.Location = new System.Drawing.Point(4, 22);
			this.debugPoints.Name = "debugPoints";
			this.debugPoints.Padding = new System.Windows.Forms.Padding(3);
			this.debugPoints.Size = new System.Drawing.Size(787, 459);
			this.debugPoints.TabIndex = 0;
			this.debugPoints.Text = "Points";
			this.debugPoints.UseVisualStyleBackColor = true;
			// 
			// debugPointView
			// 
			this.debugPointView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.debugPointView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.debugPointView.Location = new System.Drawing.Point(3, 3);
			this.debugPointView.Name = "debugPointView";
			this.debugPointView.ReadOnly = true;
			this.debugPointView.Size = new System.Drawing.Size(781, 453);
			this.debugPointView.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(795, 461);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// loadSaveGameXML
			// 
			this.loadSaveGameXML.FileName = "openFileDialog1";
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
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tcpToolStripMenuItem;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage debug;
		private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadSaveXML;
		private System.Windows.Forms.OpenFileDialog loadSaveGameXML;
		private System.Windows.Forms.ToolStripMenuItem networkToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
		private System.Windows.Forms.TabControl debugTabs;
		private System.Windows.Forms.TabPage debugPoints;
		private System.Windows.Forms.DataGridView debugPointView;
		private System.Windows.Forms.ToolStripMenuItem tcpConnect;
		private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem pointsToolStripMenuItem;
		private System.Windows.Forms.TabPage debugSignals;
		private System.Windows.Forms.DataGridView debugSignalView;
		private System.Windows.Forms.TabPage debugBerths;
		private System.Windows.Forms.DataGridView debugBerthView;
		private System.Windows.Forms.ToolStripMenuItem berthsResetToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem signalResetToolStripMenuItem;
	}
}

