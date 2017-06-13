namespace SimSig_Keyboard_Interface.User_Interface
{
	partial class PhoneUi
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
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.splitContainer4 = new System.Windows.Forms.SplitContainer();
			this.callers = new System.Windows.Forms.ListBox();
			this.callRespond = new System.Windows.Forms.Button();
			this.splitContainer3 = new System.Windows.Forms.SplitContainer();
			this.callMsg = new System.Windows.Forms.Label();
			this.callResponses = new System.Windows.Forms.ListBox();
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
			this.SuspendLayout();
			// 
			// splitContainer2
			// 
			this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer2.IsSplitterFixed = true;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.splitContainer4);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
			this.splitContainer2.Size = new System.Drawing.Size(1086, 695);
			this.splitContainer2.SplitterDistance = 198;
			this.splitContainer2.SplitterWidth = 5;
			this.splitContainer2.TabIndex = 9;
			// 
			// splitContainer4
			// 
			this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer4.Location = new System.Drawing.Point(0, 0);
			this.splitContainer4.Margin = new System.Windows.Forms.Padding(4);
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
			this.splitContainer4.Size = new System.Drawing.Size(194, 691);
			this.splitContainer4.SplitterDistance = 599;
			this.splitContainer4.SplitterWidth = 6;
			this.splitContainer4.TabIndex = 9;
			// 
			// callers
			// 
			this.callers.BackColor = System.Drawing.Color.Black;
			this.callers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.callers.Font = new System.Drawing.Font("Consolas", 13F);
			this.callers.ForeColor = System.Drawing.Color.Cyan;
			this.callers.FormattingEnabled = true;
			this.callers.ItemHeight = 20;
			this.callers.Items.AddRange(new object[] {
            "Train 1A01"});
			this.callers.Location = new System.Drawing.Point(0, 0);
			this.callers.Margin = new System.Windows.Forms.Padding(0);
			this.callers.Name = "callers";
			this.callers.Size = new System.Drawing.Size(194, 599);
			this.callers.TabIndex = 4;
			this.callers.SelectedIndexChanged += new System.EventHandler(this.callers_SelectedIndexChanged);
			// 
			// callRespond
			// 
			this.callRespond.Dock = System.Windows.Forms.DockStyle.Fill;
			this.callRespond.Font = new System.Drawing.Font("Consolas", 13F);
			this.callRespond.Location = new System.Drawing.Point(0, 0);
			this.callRespond.Margin = new System.Windows.Forms.Padding(4);
			this.callRespond.Name = "callRespond";
			this.callRespond.Size = new System.Drawing.Size(194, 86);
			this.callRespond.TabIndex = 5;
			this.callRespond.Text = "Respond";
			this.callRespond.UseVisualStyleBackColor = true;
			this.callRespond.Click += new System.EventHandler(this.callRespond_Click);
			// 
			// splitContainer3
			// 
			this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer3.IsSplitterFixed = true;
			this.splitContainer3.Location = new System.Drawing.Point(0, 0);
			this.splitContainer3.Margin = new System.Windows.Forms.Padding(4);
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
			this.splitContainer3.Size = new System.Drawing.Size(879, 691);
			this.splitContainer3.SplitterDistance = 239;
			this.splitContainer3.SplitterWidth = 6;
			this.splitContainer3.TabIndex = 0;
			// 
			// callMsg
			// 
			this.callMsg.BackColor = System.Drawing.Color.Black;
			this.callMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.callMsg.Dock = System.Windows.Forms.DockStyle.Fill;
			this.callMsg.Font = new System.Drawing.Font("Consolas", 13F);
			this.callMsg.ForeColor = System.Drawing.Color.Cyan;
			this.callMsg.Location = new System.Drawing.Point(0, 0);
			this.callMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.callMsg.Name = "callMsg";
			this.callMsg.Size = new System.Drawing.Size(879, 239);
			this.callMsg.TabIndex = 7;
			this.callMsg.Text = "callMsg";
			this.callMsg.Click += new System.EventHandler(this.callMsg_Click);
			// 
			// callResponses
			// 
			this.callResponses.BackColor = System.Drawing.Color.Black;
			this.callResponses.Dock = System.Windows.Forms.DockStyle.Fill;
			this.callResponses.Font = new System.Drawing.Font("Consolas", 13F);
			this.callResponses.ForeColor = System.Drawing.Color.Cyan;
			this.callResponses.FormattingEnabled = true;
			this.callResponses.ItemHeight = 20;
			this.callResponses.Location = new System.Drawing.Point(0, 0);
			this.callResponses.Margin = new System.Windows.Forms.Padding(4);
			this.callResponses.Name = "callResponses";
			this.callResponses.Size = new System.Drawing.Size(879, 446);
			this.callResponses.TabIndex = 0;
			// 
			// PhoneUi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer2);
			this.Name = "PhoneUi";
			this.Size = new System.Drawing.Size(1086, 695);
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
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.SplitContainer splitContainer4;
		private System.Windows.Forms.ListBox callers;
		private System.Windows.Forms.Button callRespond;
		private System.Windows.Forms.SplitContainer splitContainer3;
		private System.Windows.Forms.Label callMsg;
		private System.Windows.Forms.ListBox callResponses;
	}
}
