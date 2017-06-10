namespace SimSig_Keyboard_Interface.User_Interface
{
	partial class MainMenu
	{
        //random comment to unbreak git
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSaveXML = new System.Windows.Forms.ToolStripMenuItem();
            this.requestDataToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.berthListResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signalListResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointsListResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.networkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.label2 = new System.Windows.Forms.Label();
            this.keyboardSpecFunction = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userInputString = new System.Windows.Forms.TextBox();
            this.phoneCalls = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.callers = new System.Windows.Forms.ListBox();
            this.callRespond = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.callMsg = new System.Windows.Forms.Label();
            this.callResponses = new System.Windows.Forms.ListBox();
            this.loadSaveGameXML = new System.Windows.Forms.OpenFileDialog();
            this.dataSave = new System.Windows.Forms.SaveFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.networkToolStripMenuItem,
            this.logsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(598, 24);
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
            this.loadSaveXML,
            this.requestDataToolStripMenuItem1,
            this.toolStripSeparator1,
            this.berthListResetToolStripMenuItem,
            this.signalListResetToolStripMenuItem,
            this.pointsListResetToolStripMenuItem});
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
            // requestDataToolStripMenuItem1
            // 
            this.requestDataToolStripMenuItem1.Name = "requestDataToolStripMenuItem1";
            this.requestDataToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.requestDataToolStripMenuItem1.Text = "Request Data";
            this.requestDataToolStripMenuItem1.Click += new System.EventHandler(this.requestDataToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // berthListResetToolStripMenuItem
            // 
            this.berthListResetToolStripMenuItem.Name = "berthListResetToolStripMenuItem";
            this.berthListResetToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.berthListResetToolStripMenuItem.Text = "Berth List Reset";
            this.berthListResetToolStripMenuItem.Click += new System.EventHandler(this.berthListResetToolStripMenuItem_Click);
            // 
            // signalListResetToolStripMenuItem
            // 
            this.signalListResetToolStripMenuItem.Name = "signalListResetToolStripMenuItem";
            this.signalListResetToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.signalListResetToolStripMenuItem.Text = "Signal List Reset";
            this.signalListResetToolStripMenuItem.Click += new System.EventHandler(this.signalListResetToolStripMenuItem_Click);
            // 
            // pointsListResetToolStripMenuItem
            // 
            this.pointsListResetToolStripMenuItem.Name = "pointsListResetToolStripMenuItem";
            this.pointsListResetToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.pointsListResetToolStripMenuItem.Text = "Points List Reset";
            this.pointsListResetToolStripMenuItem.Click += new System.EventHandler(this.pointsListResetToolStripMenuItem_Click);
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
            this.connectToolStripMenuItem,
            this.requestDataToolStripMenuItem});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.ConnectToolStripMenuItem_Click);
            // 
            // requestDataToolStripMenuItem
            // 
            this.requestDataToolStripMenuItem.Name = "requestDataToolStripMenuItem";
            this.requestDataToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.requestDataToolStripMenuItem.Text = "Request Data";
            // 
            // serialToolStripMenuItem
            // 
            this.serialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem1});
            this.serialToolStripMenuItem.Name = "serialToolStripMenuItem";
            this.serialToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.serialToolStripMenuItem.Text = "Serial";
            // 
            // connectToolStripMenuItem1
            // 
            this.connectToolStripMenuItem1.Name = "connectToolStripMenuItem1";
            this.connectToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.connectToolStripMenuItem1.Text = "Connect";
            this.connectToolStripMenuItem1.Click += new System.EventHandler(this.ConnectToolStripMenuItem1_Click);
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
            this.tabControl.Size = new System.Drawing.Size(598, 503);
            this.tabControl.TabIndex = 1;
            // 
            // debug
            // 
            this.debug.Controls.Add(this.debugTabs);
            this.debug.Location = new System.Drawing.Point(4, 22);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(590, 477);
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
            this.debugTabs.Size = new System.Drawing.Size(590, 477);
            this.debugTabs.TabIndex = 0;
            // 
            // debugBerths
            // 
            this.debugBerths.Controls.Add(this.debugBerthView);
            this.debugBerths.Location = new System.Drawing.Point(4, 22);
            this.debugBerths.Name = "debugBerths";
            this.debugBerths.Size = new System.Drawing.Size(582, 451);
            this.debugBerths.TabIndex = 2;
            this.debugBerths.Text = "Berths";
            this.debugBerths.UseVisualStyleBackColor = true;
            // 
            // debugBerthView
            // 
            this.debugBerthView.AllowUserToAddRows = false;
            this.debugBerthView.AllowUserToDeleteRows = false;
            this.debugBerthView.AllowUserToOrderColumns = true;
            this.debugBerthView.AllowUserToResizeColumns = false;
            this.debugBerthView.AllowUserToResizeRows = false;
            this.debugBerthView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.debugBerthView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.debugBerthView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debugBerthView.Location = new System.Drawing.Point(0, 0);
            this.debugBerthView.Name = "debugBerthView";
            this.debugBerthView.ReadOnly = true;
            this.debugBerthView.Size = new System.Drawing.Size(582, 451);
            this.debugBerthView.TabIndex = 3;
            // 
            // debugCalls
            // 
            this.debugCalls.Controls.Add(this.debugCallView);
            this.debugCalls.Location = new System.Drawing.Point(4, 22);
            this.debugCalls.Name = "debugCalls";
            this.debugCalls.Size = new System.Drawing.Size(582, 451);
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
            this.debugCallView.Size = new System.Drawing.Size(582, 451);
            this.debugCallView.TabIndex = 3;
            // 
            // debugPoints
            // 
            this.debugPoints.Controls.Add(this.debugPointView);
            this.debugPoints.Location = new System.Drawing.Point(4, 22);
            this.debugPoints.Name = "debugPoints";
            this.debugPoints.Padding = new System.Windows.Forms.Padding(3);
            this.debugPoints.Size = new System.Drawing.Size(582, 451);
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
            this.debugPointView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.debugPointView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.debugPointView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debugPointView.Location = new System.Drawing.Point(3, 3);
            this.debugPointView.Name = "debugPointView";
            this.debugPointView.ReadOnly = true;
            this.debugPointView.Size = new System.Drawing.Size(576, 445);
            this.debugPointView.TabIndex = 3;
            // 
            // debugSignals
            // 
            this.debugSignals.Controls.Add(this.debugSignalView);
            this.debugSignals.Location = new System.Drawing.Point(4, 22);
            this.debugSignals.Name = "debugSignals";
            this.debugSignals.Size = new System.Drawing.Size(582, 397);
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
            this.debugSignalView.Size = new System.Drawing.Size(582, 397);
            this.debugSignalView.TabIndex = 3;
            // 
            // debugTracks
            // 
            this.debugTracks.Controls.Add(this.debugTrackView);
            this.debugTracks.Location = new System.Drawing.Point(4, 22);
            this.debugTracks.Name = "debugTracks";
            this.debugTracks.Size = new System.Drawing.Size(582, 397);
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
            this.debugTrackView.Size = new System.Drawing.Size(582, 397);
            this.debugTrackView.TabIndex = 2;
            // 
            // debugTcpRaw
            // 
            this.debugTcpRaw.Controls.Add(this.debugRawTcpDisplay);
            this.debugTcpRaw.Location = new System.Drawing.Point(4, 22);
            this.debugTcpRaw.Name = "debugTcpRaw";
            this.debugTcpRaw.Size = new System.Drawing.Size(582, 397);
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
            this.debugRawTcpDisplay.Size = new System.Drawing.Size(582, 397);
            this.debugRawTcpDisplay.TabIndex = 4;
            // 
            // keyboardInterface
            // 
            this.keyboardInterface.BackColor = System.Drawing.Color.Black;
            this.keyboardInterface.Controls.Add(this.label2);
            this.keyboardInterface.Controls.Add(this.keyboardSpecFunction);
            this.keyboardInterface.Controls.Add(this.label1);
            this.keyboardInterface.Controls.Add(this.userInputString);
            this.keyboardInterface.Location = new System.Drawing.Point(4, 22);
            this.keyboardInterface.Name = "keyboardInterface";
            this.keyboardInterface.Padding = new System.Windows.Forms.Padding(3);
            this.keyboardInterface.Size = new System.Drawing.Size(590, 477);
            this.keyboardInterface.TabIndex = 0;
            this.keyboardInterface.Text = "Keyboard Interface";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(360, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 65);
            this.label2.TabIndex = 15;
            this.label2.Text = "A - Auto\r\nB - Berth\r\nE - Replacement\r\nS - Signal\r\nP - Point";
            // 
            // keyboardSpecFunction
            // 
            this.keyboardSpecFunction.BackColor = System.Drawing.Color.Black;
            this.keyboardSpecFunction.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.keyboardSpecFunction.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F);
            this.keyboardSpecFunction.ForeColor = System.Drawing.Color.Cyan;
            this.keyboardSpecFunction.Location = new System.Drawing.Point(9, 16);
            this.keyboardSpecFunction.MaxLength = 3;
            this.keyboardSpecFunction.Name = "keyboardSpecFunction";
            this.keyboardSpecFunction.ReadOnly = true;
            this.keyboardSpecFunction.Size = new System.Drawing.Size(52, 25);
            this.keyboardSpecFunction.TabIndex = 14;
            this.keyboardSpecFunction.TabStop = false;
            this.keyboardSpecFunction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(242, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 130);
            this.label1.TabIndex = 13;
            this.label1.Text = "DEL - Cancel\r\nEnter - Set\r\n\r\nF1 - REM\r\nF2 - ISO\r\nF3 - OVR\r\n\r\nF5 - Key Norm\r\nF6 - " +
    "Centre\r\nF7 - Key Rev";
            // 
            // userInputString
            // 
            this.userInputString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userInputString.BackColor = System.Drawing.SystemColors.InfoText;
            this.userInputString.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.userInputString.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInputString.ForeColor = System.Drawing.Color.Cyan;
            this.userInputString.Location = new System.Drawing.Point(67, 16);
            this.userInputString.MinimumSize = new System.Drawing.Size(4, 25);
            this.userInputString.Name = "userInputString";
            this.userInputString.Size = new System.Drawing.Size(515, 25);
            this.userInputString.TabIndex = 0;
            this.userInputString.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserInputString_KeyDown);
            // 
            // phoneCalls
            // 
            this.phoneCalls.BackColor = System.Drawing.Color.Black;
            this.phoneCalls.Controls.Add(this.splitContainer2);
            this.phoneCalls.Location = new System.Drawing.Point(4, 22);
            this.phoneCalls.Name = "phoneCalls";
            this.phoneCalls.Size = new System.Drawing.Size(590, 477);
            this.phoneCalls.TabIndex = 2;
            this.phoneCalls.Text = "Phone";
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(590, 477);
            this.splitContainer2.SplitterDistance = 198;
            this.splitContainer2.TabIndex = 8;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.callers);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.callRespond);
            this.splitContainer4.Size = new System.Drawing.Size(194, 473);
            this.splitContainer4.SplitterDistance = 444;
            this.splitContainer4.TabIndex = 9;
            // 
            // callers
            // 
            this.callers.BackColor = System.Drawing.Color.Black;
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
            this.callers.Size = new System.Drawing.Size(194, 444);
            this.callers.TabIndex = 4;
            this.callers.SelectedIndexChanged += new System.EventHandler(this.Callers_SelectedIndexChanged_1);
            // 
            // callRespond
            // 
            this.callRespond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.callRespond.Location = new System.Drawing.Point(0, 0);
            this.callRespond.Name = "callRespond";
            this.callRespond.Size = new System.Drawing.Size(194, 25);
            this.callRespond.TabIndex = 5;
            this.callRespond.Text = "Respond";
            this.callRespond.UseVisualStyleBackColor = true;
            this.callRespond.Click += new System.EventHandler(this.CallRespond_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.callMsg);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.callResponses);
            this.splitContainer3.Size = new System.Drawing.Size(384, 473);
            this.splitContainer3.SplitterDistance = 239;
            this.splitContainer3.TabIndex = 0;
            // 
            // callMsg
            // 
            this.callMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.callMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.callMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.callMsg.ForeColor = System.Drawing.Color.Cyan;
            this.callMsg.Location = new System.Drawing.Point(0, 0);
            this.callMsg.Name = "callMsg";
            this.callMsg.Size = new System.Drawing.Size(384, 239);
            this.callMsg.TabIndex = 7;
            this.callMsg.Text = "callMsg";
            // 
            // callResponses
            // 
            this.callResponses.BackColor = System.Drawing.Color.Black;
            this.callResponses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.callResponses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.callResponses.ForeColor = System.Drawing.Color.Cyan;
            this.callResponses.FormattingEnabled = true;
            this.callResponses.ItemHeight = 24;
            this.callResponses.Location = new System.Drawing.Point(0, 0);
            this.callResponses.Name = "callResponses";
            this.callResponses.Size = new System.Drawing.Size(384, 230);
            this.callResponses.TabIndex = 0;
            // 
            // loadSaveGameXML
            // 
            this.loadSaveGameXML.FileName = "openFileDialog1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(20, 18);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainer1.Size = new System.Drawing.Size(150, 100);
            this.splitContainer1.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 527);
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
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage keyboardInterface;
		private System.Windows.Forms.TabPage debug;
		private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadSaveXML;
		private System.Windows.Forms.OpenFileDialog loadSaveGameXML;
		private System.Windows.Forms.ToolStripMenuItem networkToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
		private System.Windows.Forms.TabControl debugTabs;
		private System.Windows.Forms.TabPage debugBerths;
		private System.Windows.Forms.TabPage debugSignals;
		private System.Windows.Forms.TabPage debugPoints;
		private System.Windows.Forms.TabPage debugTcpRaw;
		public System.Windows.Forms.ListBox debugRawTcpDisplay;
		private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem savePointsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveSignalsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveBerthsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveRawToolStripMenuItem;
		private System.Windows.Forms.SaveFileDialog dataSave;
		public System.Windows.Forms.TextBox userInputString;
		private System.Windows.Forms.TabPage debugTracks;
		private System.Windows.Forms.DataGridView debugTrackView;
		private System.Windows.Forms.TabPage debugCalls;
		private System.Windows.Forms.TabPage phoneCalls;
		private System.Windows.Forms.Button callRespond;
		private System.Windows.Forms.ListBox callers;
		private System.Windows.Forms.ToolStripMenuItem serialToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem1;
		private System.Windows.Forms.Label callMsg;
		private System.Windows.Forms.DataGridView debugSignalView;
		private System.Windows.Forms.DataGridView debugBerthView;
		private System.Windows.Forms.DataGridView debugCallView;
		private System.Windows.Forms.DataGridView debugPointView;
//		private System.Windows.Forms.ListBox callResponses;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.SplitContainer splitContainer3;
		private System.Windows.Forms.SplitContainer splitContainer4;
		private System.Windows.Forms.ListBox callResponses;
		private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
		private System.Windows.Forms.ToolStripMenuItem berthListResetToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem signalListResetToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pointsListResetToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem requestDataToolStripMenuItem;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem requestDataToolStripMenuItem1;
		private System.Windows.Forms.TextBox keyboardSpecFunction;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

