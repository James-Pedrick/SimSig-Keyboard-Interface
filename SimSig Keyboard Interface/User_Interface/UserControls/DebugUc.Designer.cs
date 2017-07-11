namespace SimSig_Keyboard_Interface.User_Interface.UserControls
{
	partial class DebugUc
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.debugTabs = new System.Windows.Forms.TabControl();
			this.debugBerths = new System.Windows.Forms.TabPage();
			this.debugBerthView = new System.Windows.Forms.DataGridView();
			this.debugGroundFrames = new System.Windows.Forms.TabPage();
			this.debugCallView = new System.Windows.Forms.DataGridView();
			this.debugPoints = new System.Windows.Forms.TabPage();
			this.debugPointView = new System.Windows.Forms.DataGridView();
			this.debugSignals = new System.Windows.Forms.TabPage();
			this.debugSignalView = new System.Windows.Forms.DataGridView();
			this.debugTracks = new System.Windows.Forms.TabPage();
			this.debugTrackView = new System.Windows.Forms.DataGridView();
			this.debugSlots = new System.Windows.Forms.TabPage();
			this.debugSlotView = new System.Windows.Forms.DataGridView();
			this.debugFrames = new System.Windows.Forms.TabPage();
			this.debugFrameView = new System.Windows.Forms.DataGridView();
			this.debugFlags = new System.Windows.Forms.TabPage();
			this.debugFlagView = new System.Windows.Forms.DataGridView();
			this.debugUlcs = new System.Windows.Forms.TabPage();
			this.ulcView = new System.Windows.Forms.DataGridView();
			this.simLocations = new System.Windows.Forms.TabPage();
			this.simTiplocs = new System.Windows.Forms.DataGridView();
			this.debugTcpRaw = new System.Windows.Forms.TabPage();
			this.debugRawTcpDisplay = new System.Windows.Forms.ListBox();
			this.debugComRaw = new System.Windows.Forms.TabPage();
			this.debugRawComDisplay = new System.Windows.Forms.ListBox();
			this.debugOverlaps = new System.Windows.Forms.TabPage();
			this.overlapView = new System.Windows.Forms.DataGridView();
			this.debugNrRaw = new System.Windows.Forms.TabPage();
			this.NrRawDataFeeds = new System.Windows.Forms.ListBox();
			this.debugTabs.SuspendLayout();
			this.debugBerths.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.debugBerthView)).BeginInit();
			this.debugGroundFrames.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.debugCallView)).BeginInit();
			this.debugPoints.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.debugPointView)).BeginInit();
			this.debugSignals.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.debugSignalView)).BeginInit();
			this.debugTracks.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.debugTrackView)).BeginInit();
			this.debugSlots.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.debugSlotView)).BeginInit();
			this.debugFrames.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.debugFrameView)).BeginInit();
			this.debugFlags.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.debugFlagView)).BeginInit();
			this.debugUlcs.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ulcView)).BeginInit();
			this.simLocations.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.simTiplocs)).BeginInit();
			this.debugTcpRaw.SuspendLayout();
			this.debugComRaw.SuspendLayout();
			this.debugOverlaps.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.overlapView)).BeginInit();
			this.debugNrRaw.SuspendLayout();
			this.SuspendLayout();
			// 
			// debugTabs
			// 
			this.debugTabs.Controls.Add(this.debugBerths);
			this.debugTabs.Controls.Add(this.debugGroundFrames);
			this.debugTabs.Controls.Add(this.debugPoints);
			this.debugTabs.Controls.Add(this.debugSignals);
			this.debugTabs.Controls.Add(this.debugTracks);
			this.debugTabs.Controls.Add(this.debugSlots);
			this.debugTabs.Controls.Add(this.debugFrames);
			this.debugTabs.Controls.Add(this.debugFlags);
			this.debugTabs.Controls.Add(this.debugUlcs);
			this.debugTabs.Controls.Add(this.simLocations);
			this.debugTabs.Controls.Add(this.debugTcpRaw);
			this.debugTabs.Controls.Add(this.debugComRaw);
			this.debugTabs.Controls.Add(this.debugOverlaps);
			this.debugTabs.Controls.Add(this.debugNrRaw);
			this.debugTabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.debugTabs.Location = new System.Drawing.Point(0, 0);
			this.debugTabs.Margin = new System.Windows.Forms.Padding(4);
			this.debugTabs.Multiline = true;
			this.debugTabs.Name = "debugTabs";
			this.debugTabs.SelectedIndex = 0;
			this.debugTabs.Size = new System.Drawing.Size(537, 481);
			this.debugTabs.TabIndex = 1;
			// 
			// debugBerths
			// 
			this.debugBerths.Controls.Add(this.debugBerthView);
			this.debugBerths.Location = new System.Drawing.Point(4, 40);
			this.debugBerths.Margin = new System.Windows.Forms.Padding(4);
			this.debugBerths.Name = "debugBerths";
			this.debugBerths.Size = new System.Drawing.Size(529, 437);
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
			this.debugBerthView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.debugBerthView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.debugBerthView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.debugBerthView.Location = new System.Drawing.Point(0, 0);
			this.debugBerthView.Margin = new System.Windows.Forms.Padding(4);
			this.debugBerthView.Name = "debugBerthView";
			this.debugBerthView.ReadOnly = true;
			this.debugBerthView.Size = new System.Drawing.Size(529, 437);
			this.debugBerthView.TabIndex = 3;
			// 
			// debugGroundFrames
			// 
			this.debugGroundFrames.Controls.Add(this.debugCallView);
			this.debugGroundFrames.Location = new System.Drawing.Point(4, 22);
			this.debugGroundFrames.Margin = new System.Windows.Forms.Padding(4);
			this.debugGroundFrames.Name = "debugGroundFrames";
			this.debugGroundFrames.Size = new System.Drawing.Size(529, 455);
			this.debugGroundFrames.TabIndex = 5;
			this.debugGroundFrames.Text = "Calls";
			this.debugGroundFrames.UseVisualStyleBackColor = true;
			// 
			// debugCallView
			// 
			this.debugCallView.AllowUserToAddRows = false;
			this.debugCallView.AllowUserToDeleteRows = false;
			this.debugCallView.AllowUserToOrderColumns = true;
			this.debugCallView.AllowUserToResizeColumns = false;
			this.debugCallView.AllowUserToResizeRows = false;
			this.debugCallView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.debugCallView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.debugCallView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.debugCallView.Location = new System.Drawing.Point(0, 0);
			this.debugCallView.Margin = new System.Windows.Forms.Padding(4);
			this.debugCallView.Name = "debugCallView";
			this.debugCallView.ReadOnly = true;
			this.debugCallView.Size = new System.Drawing.Size(529, 455);
			this.debugCallView.TabIndex = 3;
			// 
			// debugPoints
			// 
			this.debugPoints.Controls.Add(this.debugPointView);
			this.debugPoints.Location = new System.Drawing.Point(4, 22);
			this.debugPoints.Margin = new System.Windows.Forms.Padding(4);
			this.debugPoints.Name = "debugPoints";
			this.debugPoints.Padding = new System.Windows.Forms.Padding(4);
			this.debugPoints.Size = new System.Drawing.Size(529, 455);
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
			this.debugPointView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.debugPointView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.debugPointView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.debugPointView.Location = new System.Drawing.Point(4, 4);
			this.debugPointView.Margin = new System.Windows.Forms.Padding(4);
			this.debugPointView.Name = "debugPointView";
			this.debugPointView.ReadOnly = true;
			this.debugPointView.Size = new System.Drawing.Size(521, 447);
			this.debugPointView.TabIndex = 3;
			// 
			// debugSignals
			// 
			this.debugSignals.Controls.Add(this.debugSignalView);
			this.debugSignals.Location = new System.Drawing.Point(4, 22);
			this.debugSignals.Margin = new System.Windows.Forms.Padding(4);
			this.debugSignals.Name = "debugSignals";
			this.debugSignals.Size = new System.Drawing.Size(529, 455);
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
			this.debugSignalView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.debugSignalView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.debugSignalView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.debugSignalView.Location = new System.Drawing.Point(0, 0);
			this.debugSignalView.Margin = new System.Windows.Forms.Padding(4);
			this.debugSignalView.Name = "debugSignalView";
			this.debugSignalView.ReadOnly = true;
			this.debugSignalView.Size = new System.Drawing.Size(529, 455);
			this.debugSignalView.TabIndex = 3;
			// 
			// debugTracks
			// 
			this.debugTracks.Controls.Add(this.debugTrackView);
			this.debugTracks.Location = new System.Drawing.Point(4, 22);
			this.debugTracks.Margin = new System.Windows.Forms.Padding(4);
			this.debugTracks.Name = "debugTracks";
			this.debugTracks.Size = new System.Drawing.Size(529, 455);
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
			this.debugTrackView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.debugTrackView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.debugTrackView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.debugTrackView.Location = new System.Drawing.Point(0, 0);
			this.debugTrackView.Margin = new System.Windows.Forms.Padding(4);
			this.debugTrackView.Name = "debugTrackView";
			this.debugTrackView.ReadOnly = true;
			this.debugTrackView.Size = new System.Drawing.Size(529, 455);
			this.debugTrackView.TabIndex = 2;
			// 
			// debugSlots
			// 
			this.debugSlots.Controls.Add(this.debugSlotView);
			this.debugSlots.Location = new System.Drawing.Point(4, 22);
			this.debugSlots.Name = "debugSlots";
			this.debugSlots.Size = new System.Drawing.Size(529, 455);
			this.debugSlots.TabIndex = 6;
			this.debugSlots.Text = "Slots";
			this.debugSlots.UseVisualStyleBackColor = true;
			// 
			// debugSlotView
			// 
			this.debugSlotView.AllowUserToAddRows = false;
			this.debugSlotView.AllowUserToDeleteRows = false;
			this.debugSlotView.AllowUserToOrderColumns = true;
			this.debugSlotView.AllowUserToResizeColumns = false;
			this.debugSlotView.AllowUserToResizeRows = false;
			this.debugSlotView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.debugSlotView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.debugSlotView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.debugSlotView.Location = new System.Drawing.Point(0, 0);
			this.debugSlotView.Margin = new System.Windows.Forms.Padding(4);
			this.debugSlotView.Name = "debugSlotView";
			this.debugSlotView.ReadOnly = true;
			this.debugSlotView.Size = new System.Drawing.Size(529, 455);
			this.debugSlotView.TabIndex = 3;
			// 
			// debugFrames
			// 
			this.debugFrames.Controls.Add(this.debugFrameView);
			this.debugFrames.Location = new System.Drawing.Point(4, 22);
			this.debugFrames.Name = "debugFrames";
			this.debugFrames.Size = new System.Drawing.Size(529, 455);
			this.debugFrames.TabIndex = 7;
			this.debugFrames.Text = "Ground Frames";
			this.debugFrames.UseVisualStyleBackColor = true;
			// 
			// debugFrameView
			// 
			this.debugFrameView.AllowUserToAddRows = false;
			this.debugFrameView.AllowUserToDeleteRows = false;
			this.debugFrameView.AllowUserToOrderColumns = true;
			this.debugFrameView.AllowUserToResizeColumns = false;
			this.debugFrameView.AllowUserToResizeRows = false;
			this.debugFrameView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.debugFrameView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.debugFrameView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.debugFrameView.Location = new System.Drawing.Point(0, 0);
			this.debugFrameView.Margin = new System.Windows.Forms.Padding(4);
			this.debugFrameView.Name = "debugFrameView";
			this.debugFrameView.ReadOnly = true;
			this.debugFrameView.Size = new System.Drawing.Size(529, 455);
			this.debugFrameView.TabIndex = 4;
			// 
			// debugFlags
			// 
			this.debugFlags.Controls.Add(this.debugFlagView);
			this.debugFlags.Location = new System.Drawing.Point(4, 22);
			this.debugFlags.Name = "debugFlags";
			this.debugFlags.Size = new System.Drawing.Size(529, 455);
			this.debugFlags.TabIndex = 8;
			this.debugFlags.Text = "Flags";
			this.debugFlags.UseVisualStyleBackColor = true;
			// 
			// debugFlagView
			// 
			this.debugFlagView.AllowUserToAddRows = false;
			this.debugFlagView.AllowUserToDeleteRows = false;
			this.debugFlagView.AllowUserToOrderColumns = true;
			this.debugFlagView.AllowUserToResizeColumns = false;
			this.debugFlagView.AllowUserToResizeRows = false;
			this.debugFlagView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.debugFlagView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.debugFlagView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.debugFlagView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.debugFlagView.Location = new System.Drawing.Point(0, 0);
			this.debugFlagView.Margin = new System.Windows.Forms.Padding(4);
			this.debugFlagView.Name = "debugFlagView";
			this.debugFlagView.ReadOnly = true;
			this.debugFlagView.Size = new System.Drawing.Size(529, 455);
			this.debugFlagView.TabIndex = 4;
			// 
			// debugUlcs
			// 
			this.debugUlcs.Controls.Add(this.ulcView);
			this.debugUlcs.Location = new System.Drawing.Point(4, 22);
			this.debugUlcs.Name = "debugUlcs";
			this.debugUlcs.Size = new System.Drawing.Size(529, 455);
			this.debugUlcs.TabIndex = 11;
			this.debugUlcs.Text = "ULCs";
			this.debugUlcs.UseVisualStyleBackColor = true;
			// 
			// ulcView
			// 
			this.ulcView.AllowUserToAddRows = false;
			this.ulcView.AllowUserToDeleteRows = false;
			this.ulcView.AllowUserToOrderColumns = true;
			this.ulcView.AllowUserToResizeColumns = false;
			this.ulcView.AllowUserToResizeRows = false;
			this.ulcView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.ulcView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ulcView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ulcView.Location = new System.Drawing.Point(0, 0);
			this.ulcView.Margin = new System.Windows.Forms.Padding(4);
			this.ulcView.Name = "ulcView";
			this.ulcView.ReadOnly = true;
			this.ulcView.Size = new System.Drawing.Size(529, 455);
			this.ulcView.TabIndex = 4;
			// 
			// simLocations
			// 
			this.simLocations.Controls.Add(this.simTiplocs);
			this.simLocations.Location = new System.Drawing.Point(4, 22);
			this.simLocations.Name = "simLocations";
			this.simLocations.Padding = new System.Windows.Forms.Padding(3);
			this.simLocations.Size = new System.Drawing.Size(529, 455);
			this.simLocations.TabIndex = 10;
			this.simLocations.Text = "Locations";
			this.simLocations.UseVisualStyleBackColor = true;
			// 
			// simTiplocs
			// 
			this.simTiplocs.AllowUserToAddRows = false;
			this.simTiplocs.AllowUserToDeleteRows = false;
			this.simTiplocs.AllowUserToOrderColumns = true;
			this.simTiplocs.AllowUserToResizeColumns = false;
			this.simTiplocs.AllowUserToResizeRows = false;
			this.simTiplocs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.simTiplocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.simTiplocs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.simTiplocs.Location = new System.Drawing.Point(3, 3);
			this.simTiplocs.Margin = new System.Windows.Forms.Padding(4);
			this.simTiplocs.Name = "simTiplocs";
			this.simTiplocs.ReadOnly = true;
			this.simTiplocs.Size = new System.Drawing.Size(523, 449);
			this.simTiplocs.TabIndex = 4;
			// 
			// debugTcpRaw
			// 
			this.debugTcpRaw.Controls.Add(this.debugRawTcpDisplay);
			this.debugTcpRaw.Location = new System.Drawing.Point(4, 40);
			this.debugTcpRaw.Margin = new System.Windows.Forms.Padding(4);
			this.debugTcpRaw.Name = "debugTcpRaw";
			this.debugTcpRaw.Size = new System.Drawing.Size(529, 437);
			this.debugTcpRaw.TabIndex = 3;
			this.debugTcpRaw.Text = "TCP Raw";
			this.debugTcpRaw.UseVisualStyleBackColor = true;
			// 
			// debugRawTcpDisplay
			// 
			this.debugRawTcpDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
			this.debugRawTcpDisplay.FormattingEnabled = true;
			this.debugRawTcpDisplay.Location = new System.Drawing.Point(0, 0);
			this.debugRawTcpDisplay.Margin = new System.Windows.Forms.Padding(4);
			this.debugRawTcpDisplay.Name = "debugRawTcpDisplay";
			this.debugRawTcpDisplay.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.debugRawTcpDisplay.Size = new System.Drawing.Size(529, 437);
			this.debugRawTcpDisplay.TabIndex = 4;
			// 
			// debugComRaw
			// 
			this.debugComRaw.Controls.Add(this.debugRawComDisplay);
			this.debugComRaw.Location = new System.Drawing.Point(4, 40);
			this.debugComRaw.Name = "debugComRaw";
			this.debugComRaw.Padding = new System.Windows.Forms.Padding(3);
			this.debugComRaw.Size = new System.Drawing.Size(529, 437);
			this.debugComRaw.TabIndex = 9;
			this.debugComRaw.Text = "COM Raw";
			this.debugComRaw.UseVisualStyleBackColor = true;
			// 
			// debugRawComDisplay
			// 
			this.debugRawComDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
			this.debugRawComDisplay.FormattingEnabled = true;
			this.debugRawComDisplay.Location = new System.Drawing.Point(3, 3);
			this.debugRawComDisplay.Margin = new System.Windows.Forms.Padding(4);
			this.debugRawComDisplay.Name = "debugRawComDisplay";
			this.debugRawComDisplay.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.debugRawComDisplay.Size = new System.Drawing.Size(523, 431);
			this.debugRawComDisplay.TabIndex = 5;
			// 
			// debugOverlaps
			// 
			this.debugOverlaps.Controls.Add(this.overlapView);
			this.debugOverlaps.Location = new System.Drawing.Point(4, 40);
			this.debugOverlaps.Name = "debugOverlaps";
			this.debugOverlaps.Size = new System.Drawing.Size(529, 437);
			this.debugOverlaps.TabIndex = 12;
			this.debugOverlaps.Text = "Overlaps";
			this.debugOverlaps.UseVisualStyleBackColor = true;
			// 
			// overlapView
			// 
			this.overlapView.AllowUserToAddRows = false;
			this.overlapView.AllowUserToDeleteRows = false;
			this.overlapView.AllowUserToOrderColumns = true;
			this.overlapView.AllowUserToResizeColumns = false;
			this.overlapView.AllowUserToResizeRows = false;
			this.overlapView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.overlapView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.overlapView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.overlapView.Location = new System.Drawing.Point(0, 0);
			this.overlapView.Margin = new System.Windows.Forms.Padding(4);
			this.overlapView.Name = "overlapView";
			this.overlapView.ReadOnly = true;
			this.overlapView.Size = new System.Drawing.Size(529, 437);
			this.overlapView.TabIndex = 4;
			// 
			// debugNrRaw
			// 
			this.debugNrRaw.Controls.Add(this.NrRawDataFeeds);
			this.debugNrRaw.Location = new System.Drawing.Point(4, 40);
			this.debugNrRaw.Name = "debugNrRaw";
			this.debugNrRaw.Size = new System.Drawing.Size(529, 437);
			this.debugNrRaw.TabIndex = 13;
			this.debugNrRaw.Text = "NR RAW";
			this.debugNrRaw.UseVisualStyleBackColor = true;
			// 
			// NrRawDataFeeds
			// 
			this.NrRawDataFeeds.Dock = System.Windows.Forms.DockStyle.Fill;
			this.NrRawDataFeeds.FormattingEnabled = true;
			this.NrRawDataFeeds.Location = new System.Drawing.Point(0, 0);
			this.NrRawDataFeeds.Margin = new System.Windows.Forms.Padding(4);
			this.NrRawDataFeeds.Name = "NrRawDataFeeds";
			this.NrRawDataFeeds.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.NrRawDataFeeds.Size = new System.Drawing.Size(529, 437);
			this.NrRawDataFeeds.TabIndex = 5;
			// 
			// DebugUc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.debugTabs);
			this.Name = "DebugUc";
			this.Size = new System.Drawing.Size(537, 481);
			this.debugTabs.ResumeLayout(false);
			this.debugBerths.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.debugBerthView)).EndInit();
			this.debugGroundFrames.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.debugCallView)).EndInit();
			this.debugPoints.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.debugPointView)).EndInit();
			this.debugSignals.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.debugSignalView)).EndInit();
			this.debugTracks.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.debugTrackView)).EndInit();
			this.debugSlots.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.debugSlotView)).EndInit();
			this.debugFrames.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.debugFrameView)).EndInit();
			this.debugFlags.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.debugFlagView)).EndInit();
			this.debugUlcs.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ulcView)).EndInit();
			this.simLocations.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.simTiplocs)).EndInit();
			this.debugTcpRaw.ResumeLayout(false);
			this.debugComRaw.ResumeLayout(false);
			this.debugOverlaps.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.overlapView)).EndInit();
			this.debugNrRaw.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl debugTabs;
		private System.Windows.Forms.TabPage debugBerths;
		private System.Windows.Forms.TabPage debugGroundFrames;
		private System.Windows.Forms.DataGridView debugCallView;
		private System.Windows.Forms.TabPage debugPoints;
		private System.Windows.Forms.DataGridView debugPointView;
		private System.Windows.Forms.TabPage debugSignals;
		private System.Windows.Forms.DataGridView debugSignalView;
		private System.Windows.Forms.TabPage debugTracks;
		private System.Windows.Forms.DataGridView debugTrackView;
		private System.Windows.Forms.TabPage debugSlots;
		private System.Windows.Forms.DataGridView debugSlotView;
		private System.Windows.Forms.TabPage debugFrames;
		private System.Windows.Forms.DataGridView debugFrameView;
		private System.Windows.Forms.TabPage debugFlags;
		private System.Windows.Forms.DataGridView debugFlagView;
		private System.Windows.Forms.TabPage debugTcpRaw;
		public System.Windows.Forms.ListBox debugRawTcpDisplay;
		public System.Windows.Forms.DataGridView debugBerthView;
		private System.Windows.Forms.TabPage debugComRaw;
		public System.Windows.Forms.ListBox debugRawComDisplay;
		private System.Windows.Forms.TabPage simLocations;
		private System.Windows.Forms.DataGridView simTiplocs;
		private System.Windows.Forms.TabPage debugUlcs;
		private System.Windows.Forms.DataGridView ulcView;
		private System.Windows.Forms.TabPage debugOverlaps;
		private System.Windows.Forms.DataGridView overlapView;
		private System.Windows.Forms.TabPage debugNrRaw;
		public System.Windows.Forms.ListBox NrRawDataFeeds;
	}
}
