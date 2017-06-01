﻿namespace SimSig_Keyboard_Interface.User_Interface
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
			this.serialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.connectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
			this.debugCalls = new System.Windows.Forms.TabPage();
			this.debugCallView = new System.Windows.Forms.DataGridView();
			this.debugPoints = new System.Windows.Forms.TabPage();
			this.debugPointView = new System.Windows.Forms.DataGridView();
			this.debugSignals = new System.Windows.Forms.TabPage();
			this.debugSignalView = new System.Windows.Forms.DataGridView();
			this.debugTracks = new System.Windows.Forms.TabPage();
			this.debugTrackView = new System.Windows.Forms.DataGridView();
			this.debugTcpRaw = new System.Windows.Forms.TabPage();
			this.debugRawTcpDisplay = new System.Windows.Forms.ListBox();
			this.keyboardInterface = new System.Windows.Forms.TabPage();
			this.keyboardPointKR = new System.Windows.Forms.Button();
			this.keyboardPointF = new System.Windows.Forms.Button();
			this.keyboardPointKN = new System.Windows.Forms.Button();
			this.keyboardSignalRemoveReplacement = new System.Windows.Forms.Button();
			this.keyboardSigReplacement = new System.Windows.Forms.Button();
			this.keyboardAutoCancel = new System.Windows.Forms.Button();
			this.keyboardAutoSet = new System.Windows.Forms.Button();
			this.keyboardRouteCancel = new System.Windows.Forms.Button();
			this.keyboardRouteSet = new System.Windows.Forms.Button();
			this.keyboardSendToSim = new System.Windows.Forms.Button();
			this.keyboardTdCancel = new System.Windows.Forms.Button();
			this.keyboardInterpose = new System.Windows.Forms.Button();
			this.userInputString = new System.Windows.Forms.TextBox();
			this.phoneCalls = new System.Windows.Forms.TabPage();
			this.callResponses = new System.Windows.Forms.ListBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.callRespond = new System.Windows.Forms.Button();
			this.callers = new System.Windows.Forms.ListBox();
			this.callMessage = new System.Windows.Forms.RichTextBox();
			this.loadSaveGameXML = new System.Windows.Forms.OpenFileDialog();
			this.dataSave = new System.Windows.Forms.SaveFileDialog();
			this.menuStrip.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.debug.SuspendLayout();
			this.debugTabs.SuspendLayout();
			this.debugBerths.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.debugBerthView)).BeginInit();
			this.debugCalls.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.debugCallView)).BeginInit();
			this.debugPoints.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.debugPointView)).BeginInit();
			this.debugSignals.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.debugSignalView)).BeginInit();
			this.debugTracks.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.debugTrackView)).BeginInit();
			this.debugTcpRaw.SuspendLayout();
			this.keyboardInterface.SuspendLayout();
			this.phoneCalls.SuspendLayout();
			this.panel1.SuspendLayout();
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
			this.menuStrip.Size = new System.Drawing.Size(789, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "Menu Strip";
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
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
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
            this.clientToolStripMenuItem,
            this.serialToolStripMenuItem});
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
			this.connectToolStripMenuItem.Click += new System.EventHandler(this.ConnectToolStripMenuItem_Click);
			// 
			// serialToolStripMenuItem
			// 
			this.serialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem1});
			this.serialToolStripMenuItem.Name = "serialToolStripMenuItem";
			this.serialToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
			this.serialToolStripMenuItem.Text = "Serial";
			// 
			// connectToolStripMenuItem1
			// 
			this.connectToolStripMenuItem1.Name = "connectToolStripMenuItem1";
			this.connectToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
			this.connectToolStripMenuItem1.Text = "Connect";
			this.connectToolStripMenuItem1.Click += new System.EventHandler(this.ConnectToolStripMenuItem1_Click);
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
			this.tabControl.Controls.Add(this.phoneCalls);
			this.tabControl.Cursor = System.Windows.Forms.Cursors.Default;
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 24);
			this.tabControl.Multiline = true;
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(789, 433);
			this.tabControl.TabIndex = 1;
			// 
			// debug
			// 
			this.debug.Controls.Add(this.debugTabs);
			this.debug.Location = new System.Drawing.Point(4, 22);
			this.debug.Name = "debug";
			this.debug.Size = new System.Drawing.Size(781, 407);
			this.debug.TabIndex = 1;
			this.debug.Text = "Debug";
			this.debug.UseVisualStyleBackColor = true;
			// 
			// debugTabs
			// 
			this.debugTabs.Controls.Add(this.debugBerths);
			this.debugTabs.Controls.Add(this.debugCalls);
			this.debugTabs.Controls.Add(this.debugPoints);
			this.debugTabs.Controls.Add(this.debugSignals);
			this.debugTabs.Controls.Add(this.debugTracks);
			this.debugTabs.Controls.Add(this.debugTcpRaw);
			this.debugTabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.debugTabs.Location = new System.Drawing.Point(0, 0);
			this.debugTabs.Multiline = true;
			this.debugTabs.Name = "debugTabs";
			this.debugTabs.SelectedIndex = 0;
			this.debugTabs.Size = new System.Drawing.Size(781, 407);
			this.debugTabs.TabIndex = 0;
			// 
			// debugBerths
			// 
			this.debugBerths.Controls.Add(this.debugBerthView);
			this.debugBerths.Location = new System.Drawing.Point(4, 22);
			this.debugBerths.Name = "debugBerths";
			this.debugBerths.Size = new System.Drawing.Size(773, 381);
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
			this.debugBerthView.Size = new System.Drawing.Size(773, 381);
			this.debugBerthView.TabIndex = 2;
			// 
			// debugCalls
			// 
			this.debugCalls.Controls.Add(this.debugCallView);
			this.debugCalls.Location = new System.Drawing.Point(4, 22);
			this.debugCalls.Name = "debugCalls";
			this.debugCalls.Size = new System.Drawing.Size(773, 381);
			this.debugCalls.TabIndex = 5;
			this.debugCalls.Text = "Calls";
			this.debugCalls.UseVisualStyleBackColor = true;
			// 
			// debugCallView
			// 
			this.debugCallView.AllowUserToAddRows = false;
			this.debugCallView.AllowUserToDeleteRows = false;
			this.debugCallView.AllowUserToOrderColumns = true;
			this.debugCallView.AllowUserToResizeColumns = false;
			this.debugCallView.AllowUserToResizeRows = false;
			this.debugCallView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
			this.debugCallView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.debugCallView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.debugCallView.Location = new System.Drawing.Point(0, 0);
			this.debugCallView.Name = "debugCallView";
			this.debugCallView.ReadOnly = true;
			this.debugCallView.Size = new System.Drawing.Size(773, 381);
			this.debugCallView.TabIndex = 2;
			// 
			// debugPoints
			// 
			this.debugPoints.Controls.Add(this.debugPointView);
			this.debugPoints.Location = new System.Drawing.Point(4, 22);
			this.debugPoints.Name = "debugPoints";
			this.debugPoints.Padding = new System.Windows.Forms.Padding(3);
			this.debugPoints.Size = new System.Drawing.Size(773, 381);
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
			this.debugPointView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.debugPointView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.debugPointView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.debugPointView.Location = new System.Drawing.Point(3, 3);
			this.debugPointView.Name = "debugPointView";
			this.debugPointView.ReadOnly = true;
			this.debugPointView.Size = new System.Drawing.Size(767, 375);
			this.debugPointView.TabIndex = 1;
			// 
			// debugSignals
			// 
			this.debugSignals.Controls.Add(this.debugSignalView);
			this.debugSignals.Location = new System.Drawing.Point(4, 22);
			this.debugSignals.Name = "debugSignals";
			this.debugSignals.Size = new System.Drawing.Size(773, 381);
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
			this.debugSignalView.Size = new System.Drawing.Size(773, 381);
			this.debugSignalView.TabIndex = 1;
			// 
			// debugTracks
			// 
			this.debugTracks.Controls.Add(this.debugTrackView);
			this.debugTracks.Location = new System.Drawing.Point(4, 22);
			this.debugTracks.Name = "debugTracks";
			this.debugTracks.Size = new System.Drawing.Size(773, 381);
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
			this.debugTrackView.Size = new System.Drawing.Size(773, 381);
			this.debugTrackView.TabIndex = 2;
			// 
			// debugTcpRaw
			// 
			this.debugTcpRaw.Controls.Add(this.debugRawTcpDisplay);
			this.debugTcpRaw.Location = new System.Drawing.Point(4, 22);
			this.debugTcpRaw.Name = "debugTcpRaw";
			this.debugTcpRaw.Size = new System.Drawing.Size(773, 381);
			this.debugTcpRaw.TabIndex = 3;
			this.debugTcpRaw.Text = "TCP Raw";
			this.debugTcpRaw.UseVisualStyleBackColor = true;
			// 
			// debugRawTcpDisplay
			// 
			this.debugRawTcpDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
			this.debugRawTcpDisplay.FormattingEnabled = true;
			this.debugRawTcpDisplay.Location = new System.Drawing.Point(0, 0);
			this.debugRawTcpDisplay.Name = "debugRawTcpDisplay";
			this.debugRawTcpDisplay.Size = new System.Drawing.Size(773, 381);
			this.debugRawTcpDisplay.TabIndex = 4;
			// 
			// keyboardInterface
			// 
			this.keyboardInterface.BackColor = System.Drawing.Color.Black;
			this.keyboardInterface.Controls.Add(this.keyboardPointKR);
			this.keyboardInterface.Controls.Add(this.keyboardPointF);
			this.keyboardInterface.Controls.Add(this.keyboardPointKN);
			this.keyboardInterface.Controls.Add(this.keyboardSignalRemoveReplacement);
			this.keyboardInterface.Controls.Add(this.keyboardSigReplacement);
			this.keyboardInterface.Controls.Add(this.keyboardAutoCancel);
			this.keyboardInterface.Controls.Add(this.keyboardAutoSet);
			this.keyboardInterface.Controls.Add(this.keyboardRouteCancel);
			this.keyboardInterface.Controls.Add(this.keyboardRouteSet);
			this.keyboardInterface.Controls.Add(this.keyboardSendToSim);
			this.keyboardInterface.Controls.Add(this.keyboardTdCancel);
			this.keyboardInterface.Controls.Add(this.keyboardInterpose);
			this.keyboardInterface.Controls.Add(this.userInputString);
			this.keyboardInterface.Location = new System.Drawing.Point(4, 22);
			this.keyboardInterface.Name = "keyboardInterface";
			this.keyboardInterface.Padding = new System.Windows.Forms.Padding(3);
			this.keyboardInterface.Size = new System.Drawing.Size(781, 407);
			this.keyboardInterface.TabIndex = 0;
			this.keyboardInterface.Text = "Keyboard Interface";
			// 
			// keyboardPointKR
			// 
			this.keyboardPointKR.AutoSize = true;
			this.keyboardPointKR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.keyboardPointKR.Location = new System.Drawing.Point(476, 243);
			this.keyboardPointKR.Name = "keyboardPointKR";
			this.keyboardPointKR.Size = new System.Drawing.Size(228, 38);
			this.keyboardPointKR.TabIndex = 12;
			this.keyboardPointKR.Text = "Key Point Reverse [ F11 ]";
			this.keyboardPointKR.UseVisualStyleBackColor = true;
			this.keyboardPointKR.Click += new System.EventHandler(this.KeyboardPointKR_Click);
			// 
			// keyboardPointF
			// 
			this.keyboardPointF.AutoSize = true;
			this.keyboardPointF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.keyboardPointF.Location = new System.Drawing.Point(242, 243);
			this.keyboardPointF.Name = "keyboardPointF";
			this.keyboardPointF.Size = new System.Drawing.Size(228, 38);
			this.keyboardPointF.TabIndex = 11;
			this.keyboardPointF.Text = "Unlock Point [ F10 ]";
			this.keyboardPointF.UseVisualStyleBackColor = true;
			this.keyboardPointF.Click += new System.EventHandler(this.KeyboardPointF_Click);
			// 
			// keyboardPointKN
			// 
			this.keyboardPointKN.AutoSize = true;
			this.keyboardPointKN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.keyboardPointKN.Location = new System.Drawing.Point(8, 243);
			this.keyboardPointKN.Name = "keyboardPointKN";
			this.keyboardPointKN.Size = new System.Drawing.Size(228, 38);
			this.keyboardPointKN.TabIndex = 10;
			this.keyboardPointKN.Text = "Key Point Normal [ F9 ]";
			this.keyboardPointKN.UseVisualStyleBackColor = true;
			this.keyboardPointKN.Click += new System.EventHandler(this.KeyboardPointKN_Click);
			// 
			// keyboardSignalRemoveReplacement
			// 
			this.keyboardSignalRemoveReplacement.AutoSize = true;
			this.keyboardSignalRemoveReplacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.keyboardSignalRemoveReplacement.Location = new System.Drawing.Point(242, 199);
			this.keyboardSignalRemoveReplacement.Name = "keyboardSignalRemoveReplacement";
			this.keyboardSignalRemoveReplacement.Size = new System.Drawing.Size(228, 38);
			this.keyboardSignalRemoveReplacement.TabIndex = 9;
			this.keyboardSignalRemoveReplacement.Text = "Remove Replacement [ F8 ]";
			this.keyboardSignalRemoveReplacement.UseVisualStyleBackColor = true;
			this.keyboardSignalRemoveReplacement.Click += new System.EventHandler(this.KeyboardSigRemoveReplacement_Click);
			// 
			// keyboardSigReplacement
			// 
			this.keyboardSigReplacement.AutoSize = true;
			this.keyboardSigReplacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.keyboardSigReplacement.Location = new System.Drawing.Point(8, 199);
			this.keyboardSigReplacement.Name = "keyboardSigReplacement";
			this.keyboardSigReplacement.Size = new System.Drawing.Size(228, 38);
			this.keyboardSigReplacement.TabIndex = 8;
			this.keyboardSigReplacement.Text = "Signal Replacement [ F7 ]";
			this.keyboardSigReplacement.UseVisualStyleBackColor = true;
			this.keyboardSigReplacement.Click += new System.EventHandler(this.KeyboardSigReplacement_Click);
			// 
			// keyboardAutoCancel
			// 
			this.keyboardAutoCancel.AutoSize = true;
			this.keyboardAutoCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.keyboardAutoCancel.Location = new System.Drawing.Point(242, 155);
			this.keyboardAutoCancel.Name = "keyboardAutoCancel";
			this.keyboardAutoCancel.Size = new System.Drawing.Size(228, 38);
			this.keyboardAutoCancel.TabIndex = 7;
			this.keyboardAutoCancel.Text = "Auto Cancel [ F6 ]";
			this.keyboardAutoCancel.UseVisualStyleBackColor = true;
			this.keyboardAutoCancel.Click += new System.EventHandler(this.KeyboardAutoCancel_Click);
			// 
			// keyboardAutoSet
			// 
			this.keyboardAutoSet.AutoSize = true;
			this.keyboardAutoSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.keyboardAutoSet.Location = new System.Drawing.Point(8, 155);
			this.keyboardAutoSet.Name = "keyboardAutoSet";
			this.keyboardAutoSet.Size = new System.Drawing.Size(228, 38);
			this.keyboardAutoSet.TabIndex = 6;
			this.keyboardAutoSet.Text = "Auto Set [ F5 ]";
			this.keyboardAutoSet.UseVisualStyleBackColor = true;
			this.keyboardAutoSet.Click += new System.EventHandler(this.KeyboardAutoSet_Click);
			// 
			// keyboardRouteCancel
			// 
			this.keyboardRouteCancel.AutoSize = true;
			this.keyboardRouteCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.keyboardRouteCancel.Location = new System.Drawing.Point(242, 111);
			this.keyboardRouteCancel.Name = "keyboardRouteCancel";
			this.keyboardRouteCancel.Size = new System.Drawing.Size(228, 38);
			this.keyboardRouteCancel.TabIndex = 5;
			this.keyboardRouteCancel.Text = "Route Cancel [ F4 ]";
			this.keyboardRouteCancel.UseVisualStyleBackColor = true;
			this.keyboardRouteCancel.Click += new System.EventHandler(this.KeyboardRouteCancel_Click);
			// 
			// keyboardRouteSet
			// 
			this.keyboardRouteSet.AutoSize = true;
			this.keyboardRouteSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.keyboardRouteSet.Location = new System.Drawing.Point(8, 111);
			this.keyboardRouteSet.Name = "keyboardRouteSet";
			this.keyboardRouteSet.Size = new System.Drawing.Size(228, 38);
			this.keyboardRouteSet.TabIndex = 4;
			this.keyboardRouteSet.Text = "Route Set [ F3 ]";
			this.keyboardRouteSet.UseVisualStyleBackColor = true;
			this.keyboardRouteSet.Click += new System.EventHandler(this.KeyboardRouteSet_Click);
			// 
			// keyboardSendToSim
			// 
			this.keyboardSendToSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.keyboardSendToSim.Location = new System.Drawing.Point(476, 67);
			this.keyboardSendToSim.Name = "keyboardSendToSim";
			this.keyboardSendToSim.Size = new System.Drawing.Size(228, 38);
			this.keyboardSendToSim.TabIndex = 3;
			this.keyboardSendToSim.Text = "Send Direct to Sim [ F12 ]";
			this.keyboardSendToSim.UseVisualStyleBackColor = true;
			this.keyboardSendToSim.Click += new System.EventHandler(this.SendToSim_Click);
			// 
			// keyboardTdCancel
			// 
			this.keyboardTdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.keyboardTdCancel.Location = new System.Drawing.Point(242, 67);
			this.keyboardTdCancel.Name = "keyboardTdCancel";
			this.keyboardTdCancel.Size = new System.Drawing.Size(228, 38);
			this.keyboardTdCancel.TabIndex = 2;
			this.keyboardTdCancel.Text = "TD Cancel [ F2 ]";
			this.keyboardTdCancel.UseVisualStyleBackColor = true;
			this.keyboardTdCancel.Click += new System.EventHandler(this.KeyboardTdCancel_Click);
			// 
			// keyboardInterpose
			// 
			this.keyboardInterpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.keyboardInterpose.Location = new System.Drawing.Point(8, 67);
			this.keyboardInterpose.Name = "keyboardInterpose";
			this.keyboardInterpose.Size = new System.Drawing.Size(228, 38);
			this.keyboardInterpose.TabIndex = 1;
			this.keyboardInterpose.Text = "TD Interpose [ F1 ]";
			this.keyboardInterpose.UseVisualStyleBackColor = true;
			this.keyboardInterpose.Click += new System.EventHandler(this.KeyboardInterpose_Click);
			// 
			// userInputString
			// 
			this.userInputString.BackColor = System.Drawing.SystemColors.InfoText;
			this.userInputString.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.userInputString.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.userInputString.ForeColor = System.Drawing.Color.Cyan;
			this.userInputString.Location = new System.Drawing.Point(7, 7);
			this.userInputString.MinimumSize = new System.Drawing.Size(4, 25);
			this.userInputString.Name = "userInputString";
			this.userInputString.Size = new System.Drawing.Size(294, 25);
			this.userInputString.TabIndex = 0;
			this.userInputString.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserInputString_KeyDown);
			// 
			// phoneCalls
			// 
			this.phoneCalls.BackColor = System.Drawing.Color.Black;
			this.phoneCalls.Controls.Add(this.callResponses);
			this.phoneCalls.Controls.Add(this.panel1);
			this.phoneCalls.Controls.Add(this.callMessage);
			this.phoneCalls.Location = new System.Drawing.Point(4, 22);
			this.phoneCalls.Name = "phoneCalls";
			this.phoneCalls.Size = new System.Drawing.Size(781, 407);
			this.phoneCalls.TabIndex = 2;
			this.phoneCalls.Text = "Phone";
			// 
			// callResponses
			// 
			this.callResponses.BackColor = System.Drawing.SystemColors.WindowText;
			this.callResponses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.callResponses.Dock = System.Windows.Forms.DockStyle.Fill;
			this.callResponses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.callResponses.ForeColor = System.Drawing.Color.Cyan;
			this.callResponses.FormattingEnabled = true;
			this.callResponses.ItemHeight = 24;
			this.callResponses.Items.AddRange(new object[] {
            "Sample Item"});
			this.callResponses.Location = new System.Drawing.Point(200, 109);
			this.callResponses.Margin = new System.Windows.Forms.Padding(0);
			this.callResponses.Name = "callResponses";
			this.callResponses.Size = new System.Drawing.Size(581, 298);
			this.callResponses.TabIndex = 5;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.callRespond);
			this.panel1.Controls.Add(this.callers);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 109);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 298);
			this.panel1.TabIndex = 4;
			// 
			// callRespond
			// 
			this.callRespond.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.callRespond.Location = new System.Drawing.Point(0, 249);
			this.callRespond.Name = "callRespond";
			this.callRespond.Size = new System.Drawing.Size(200, 49);
			this.callRespond.TabIndex = 5;
			this.callRespond.Text = "Respond";
			this.callRespond.UseVisualStyleBackColor = true;
			this.callRespond.Click += new System.EventHandler(this.CallRespond_Click);
			// 
			// callers
			// 
			this.callers.BackColor = System.Drawing.Color.Black;
			this.callers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.callers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.callers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.callers.ForeColor = System.Drawing.Color.Cyan;
			this.callers.FormattingEnabled = true;
			this.callers.ItemHeight = 24;
			this.callers.Items.AddRange(new object[] {
            "Train 1A01"});
			this.callers.Location = new System.Drawing.Point(0, 0);
			this.callers.Margin = new System.Windows.Forms.Padding(0);
			this.callers.Name = "callers";
			this.callers.Size = new System.Drawing.Size(200, 298);
			this.callers.TabIndex = 4;
			this.callers.SelectedIndexChanged += new System.EventHandler(this.Callers_SelectedIndexChanged_1);
			// 
			// callMessage
			// 
			this.callMessage.BackColor = System.Drawing.Color.Black;
			this.callMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.callMessage.Dock = System.Windows.Forms.DockStyle.Top;
			this.callMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.callMessage.ForeColor = System.Drawing.Color.Cyan;
			this.callMessage.Location = new System.Drawing.Point(0, 0);
			this.callMessage.Margin = new System.Windows.Forms.Padding(0);
			this.callMessage.Name = "callMessage";
			this.callMessage.ReadOnly = true;
			this.callMessage.Size = new System.Drawing.Size(781, 109);
			this.callMessage.TabIndex = 0;
			this.callMessage.Text = "PHONE CALL MESSAGE TEXT BOX";
			// 
			// loadSaveGameXML
			// 
			this.loadSaveGameXML.FileName = "openFileDialog1";
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(789, 457);
			this.ControlBox = false;
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.menuStrip);
			this.KeyPreview = true;
			this.MainMenuStrip = this.menuStrip;
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
			this.debugCalls.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.debugCallView)).EndInit();
			this.debugPoints.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.debugPointView)).EndInit();
			this.debugSignals.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.debugSignalView)).EndInit();
			this.debugTracks.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.debugTrackView)).EndInit();
			this.debugTcpRaw.ResumeLayout(false);
			this.keyboardInterface.ResumeLayout(false);
			this.keyboardInterface.PerformLayout();
			this.phoneCalls.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
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
		private System.Windows.Forms.TabPage debugTcpRaw;
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
		private System.Windows.Forms.Button keyboardTdCancel;
		private System.Windows.Forms.TabPage debugCalls;
		private System.Windows.Forms.Button keyboardSendToSim;
		private System.Windows.Forms.DataGridView debugCallView;
		private System.Windows.Forms.TabPage phoneCalls;
		private System.Windows.Forms.RichTextBox callMessage;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button callRespond;
		private System.Windows.Forms.ListBox callers;
		private System.Windows.Forms.ListBox callResponses;
		private System.Windows.Forms.Button keyboardRouteSet;
		private System.Windows.Forms.Button keyboardRouteCancel;
		private System.Windows.Forms.Button keyboardAutoCancel;
		private System.Windows.Forms.Button keyboardAutoSet;
		private System.Windows.Forms.Button keyboardSignalRemoveReplacement;
		private System.Windows.Forms.Button keyboardSigReplacement;
		private System.Windows.Forms.Button keyboardPointKR;
		private System.Windows.Forms.Button keyboardPointF;
		private System.Windows.Forms.Button keyboardPointKN;
		private System.Windows.Forms.ToolStripMenuItem serialToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem1;
	}
}

