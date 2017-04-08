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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.debug = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.debugPoints = new System.Windows.Forms.TabPage();
            this.debugPointView = new System.Windows.Forms.DataGridView();
            this.loadSaveGameXML = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.debug.SuspendLayout();
            this.tabControl1.SuspendLayout();
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
            this.networkToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(803, 24);
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
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.debug);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(803, 487);
            this.tabControl.TabIndex = 1;
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
            // debug
            // 
            this.debug.Controls.Add(this.tabControl1);
            this.debug.Location = new System.Drawing.Point(4, 22);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(795, 461);
            this.debug.TabIndex = 1;
            this.debug.Text = "Debug";
            this.debug.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.debugPoints);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 461);
            this.tabControl1.TabIndex = 0;
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
            this.debugPointView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.debugPointView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debugPointView.Location = new System.Drawing.Point(3, 3);
            this.debugPointView.Name = "debugPointView";
            this.debugPointView.ReadOnly = true;
            this.debugPointView.Size = new System.Drawing.Size(781, 429);
            this.debugPointView.TabIndex = 1;
            // 
            // loadSaveGameXML
            // 
            this.loadSaveGameXML.FileName = "openFileDialog1";
            // 
            // Main_Menu
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
            this.tabControl1.ResumeLayout(false);
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
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage debugPoints;
		private System.Windows.Forms.DataGridView debugPointView;
		private System.Windows.Forms.ToolStripMenuItem tcpConnect;
	}
}

