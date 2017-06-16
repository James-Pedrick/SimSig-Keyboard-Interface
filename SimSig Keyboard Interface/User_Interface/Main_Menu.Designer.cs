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
			this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.serialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.connectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.savePointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveSignalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveBerthsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveRawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadSaveGameXML = new System.Windows.Forms.OpenFileDialog();
			this.dataSave = new System.Windows.Forms.SaveFileDialog();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.phone = new System.Windows.Forms.TabPage();
			this.phoneUi = new SimSig_Keyboard_Interface.User_Interface.PhoneUi();
			this.keyboardInterface = new System.Windows.Forms.TabPage();
			this.debug = new System.Windows.Forms.TabPage();
			this.debugUc1 = new SimSig_Keyboard_Interface.User_Interface.DebugUc();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.keyboardInterface2 = new SimSig_Keyboard_Interface.User_Interface.KeyboardInterface();
			this.menuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.SuspendLayout();
			this.phone.SuspendLayout();
			this.keyboardInterface.SuspendLayout();
			this.debug.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.networkToolStripMenuItem,
            this.logsToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
			this.menuStrip.Size = new System.Drawing.Size(794, 25);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "Menu Strip";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ProgramExit);
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
			this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 19);
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
			this.requestDataToolStripMenuItem1.Click += new System.EventHandler(this.RequestDataToolStripMenuItem1_Click);
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
			this.berthListResetToolStripMenuItem.Click += new System.EventHandler(this.BerthListReset);
			// 
			// signalListResetToolStripMenuItem
			// 
			this.signalListResetToolStripMenuItem.Name = "signalListResetToolStripMenuItem";
			this.signalListResetToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
			this.signalListResetToolStripMenuItem.Text = "Signal List Reset";
			this.signalListResetToolStripMenuItem.Click += new System.EventHandler(this.SignalListResetToolStripMenuItem_Click);
			// 
			// pointsListResetToolStripMenuItem
			// 
			this.pointsListResetToolStripMenuItem.Name = "pointsListResetToolStripMenuItem";
			this.pointsListResetToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
			this.pointsListResetToolStripMenuItem.Text = "Points List Reset";
			this.pointsListResetToolStripMenuItem.Click += new System.EventHandler(this.PointListRest);
			// 
			// networkToolStripMenuItem
			// 
			this.networkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.serialToolStripMenuItem});
			this.networkToolStripMenuItem.Name = "networkToolStripMenuItem";
			this.networkToolStripMenuItem.Size = new System.Drawing.Size(64, 19);
			this.networkToolStripMenuItem.Text = "Network";
			// 
			// clientToolStripMenuItem
			// 
			this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.requestDataToolStripMenuItem,
            this.disconnectToolStripMenuItem});
			this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
			this.clientToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
			this.clientToolStripMenuItem.Text = "Client";
			// 
			// connectToolStripMenuItem
			// 
			this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
			this.connectToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.connectToolStripMenuItem.Text = "Connect";
			this.connectToolStripMenuItem.Click += new System.EventHandler(this.ConnectToolStripMenuItem_Click);
			// 
			// requestDataToolStripMenuItem
			// 
			this.requestDataToolStripMenuItem.Name = "requestDataToolStripMenuItem";
			this.requestDataToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.requestDataToolStripMenuItem.Text = "Request Data";
			// 
			// disconnectToolStripMenuItem
			// 
			this.disconnectToolStripMenuItem.Enabled = false;
			this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
			this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.disconnectToolStripMenuItem.Text = "Disconnect";
			this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.DisconnectToolStripMenuItem_Click);
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
			// logsToolStripMenuItem
			// 
			this.logsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savePointsToolStripMenuItem,
            this.saveSignalsToolStripMenuItem,
            this.saveBerthsToolStripMenuItem,
            this.saveRawToolStripMenuItem});
			this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
			this.logsToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
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
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.aboutToolStripMenuItem.Text = "About";
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
			// phone
			// 
			this.phone.BackColor = System.Drawing.Color.Black;
			this.phone.Controls.Add(this.phoneUi);
			this.phone.Location = new System.Drawing.Point(4, 23);
			this.phone.Name = "phone";
			this.phone.Size = new System.Drawing.Size(786, 484);
			this.phone.TabIndex = 3;
			this.phone.Text = "Calls";
			// 
			// phoneUi
			// 
			this.phoneUi.Dock = System.Windows.Forms.DockStyle.Fill;
			this.phoneUi.Location = new System.Drawing.Point(0, 0);
			this.phoneUi.Name = "phoneUi";
			this.phoneUi.Size = new System.Drawing.Size(786, 484);
			this.phoneUi.TabIndex = 0;
			// 
			// keyboardInterface
			// 
			this.keyboardInterface.BackColor = System.Drawing.Color.Black;
			this.keyboardInterface.Controls.Add(this.keyboardInterface2);
			this.keyboardInterface.Location = new System.Drawing.Point(4, 23);
			this.keyboardInterface.Margin = new System.Windows.Forms.Padding(4);
			this.keyboardInterface.Name = "keyboardInterface";
			this.keyboardInterface.Padding = new System.Windows.Forms.Padding(4);
			this.keyboardInterface.Size = new System.Drawing.Size(786, 484);
			this.keyboardInterface.TabIndex = 0;
			this.keyboardInterface.Text = "Keyboard Interface";
			// 
			// debug
			// 
			this.debug.Controls.Add(this.debugUc1);
			this.debug.Location = new System.Drawing.Point(4, 23);
			this.debug.Margin = new System.Windows.Forms.Padding(4);
			this.debug.Name = "debug";
			this.debug.Size = new System.Drawing.Size(786, 484);
			this.debug.TabIndex = 1;
			this.debug.Text = "Debug";
			this.debug.UseVisualStyleBackColor = true;
			// 
			// debugUc1
			// 
			this.debugUc1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.debugUc1.Location = new System.Drawing.Point(0, 0);
			this.debugUc1.Name = "debugUc1";
			this.debugUc1.Size = new System.Drawing.Size(786, 484);
			this.debugUc1.TabIndex = 0;
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.debug);
			this.tabControl.Controls.Add(this.keyboardInterface);
			this.tabControl.Controls.Add(this.phone);
			this.tabControl.Controls.Add(this.tabPage1);
			this.tabControl.Cursor = System.Windows.Forms.Cursors.Default;
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Font = new System.Drawing.Font("Consolas", 9F);
			this.tabControl.Location = new System.Drawing.Point(0, 25);
			this.tabControl.Margin = new System.Windows.Forms.Padding(4);
			this.tabControl.Multiline = true;
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(794, 511);
			this.tabControl.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Location = new System.Drawing.Point(4, 23);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(786, 484);
			this.tabPage1.TabIndex = 4;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// keyboardInterface2
			// 
			this.keyboardInterface2.BackColor = System.Drawing.Color.Black;
			this.keyboardInterface2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.keyboardInterface2.ForeColor = System.Drawing.Color.Cyan;
			this.keyboardInterface2.Location = new System.Drawing.Point(4, 4);
			this.keyboardInterface2.Name = "keyboardInterface2";
			this.keyboardInterface2.Size = new System.Drawing.Size(778, 476);
			this.keyboardInterface2.TabIndex = 1;
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(794, 536);
			this.ControlBox = false;
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.menuStrip);
			this.Font = new System.Drawing.Font("Consolas", 11F);
			this.KeyPreview = true;
			this.MainMenuStrip = this.menuStrip;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainMenu";
			this.Text = "SimSig Keyboard Interface";
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.phone.ResumeLayout(false);
			this.keyboardInterface.ResumeLayout(false);
			this.debug.ResumeLayout(false);
			this.tabControl.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadSaveXML;
		private System.Windows.Forms.OpenFileDialog loadSaveGameXML;
		private System.Windows.Forms.ToolStripMenuItem networkToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem savePointsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveSignalsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveBerthsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveRawToolStripMenuItem;
		private System.Windows.Forms.SaveFileDialog dataSave;
		private System.Windows.Forms.ToolStripMenuItem serialToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem1;
//		private System.Windows.Forms.ListBox callResponses;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
		private System.Windows.Forms.ToolStripMenuItem berthListResetToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem signalListResetToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pointsListResetToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem requestDataToolStripMenuItem;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem requestDataToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
		private System.Windows.Forms.TabPage phone;
		private PhoneUi phoneUi;
		private System.Windows.Forms.TabPage keyboardInterface;
		private System.Windows.Forms.TabPage debug;
		private DebugUc debugUc1;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private KeyboardInterface keyboardInterface2;
	}
}

