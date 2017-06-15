﻿namespace SimSig_Keyboard_Interface.User_Interface
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
			this.debugTcpRaw = new System.Windows.Forms.TabPage();
			this.debugRawTcpDisplay = new System.Windows.Forms.ListBox();
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
			this.debugTcpRaw.SuspendLayout();
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
			this.debugTabs.Controls.Add(this.debugTcpRaw);
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
			this.debugBerths.Location = new System.Drawing.Point(4, 22);
			this.debugBerths.Margin = new System.Windows.Forms.Padding(4);
			this.debugBerths.Name = "debugBerths";
			this.debugBerths.Size = new System.Drawing.Size(529, 455);
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
			this.debugBerthView.Size = new System.Drawing.Size(529, 455);
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
			// debugTcpRaw
			// 
			this.debugTcpRaw.Controls.Add(this.debugRawTcpDisplay);
			this.debugTcpRaw.Location = new System.Drawing.Point(4, 22);
			this.debugTcpRaw.Margin = new System.Windows.Forms.Padding(4);
			this.debugTcpRaw.Name = "debugTcpRaw";
			this.debugTcpRaw.Size = new System.Drawing.Size(529, 455);
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
			this.debugRawTcpDisplay.Size = new System.Drawing.Size(529, 455);
			this.debugRawTcpDisplay.TabIndex = 4;
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
			this.debugTcpRaw.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl debugTabs;
		private System.Windows.Forms.TabPage debugBerths;
		private System.Windows.Forms.DataGridView debugBerthView;
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
	}
}