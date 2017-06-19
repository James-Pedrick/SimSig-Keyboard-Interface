namespace SimSig_Keyboard_Interface.User_Interface
{
	partial class BerthWatch
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
			this.userInput = new System.Windows.Forms.TextBox();
			this.watchList = new System.Windows.Forms.ListBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.addWatch = new System.Windows.Forms.Button();
			this.removeWatch = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// userInput
			// 
			this.userInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.userInput.Location = new System.Drawing.Point(3, 3);
			this.userInput.Name = "userInput";
			this.userInput.Size = new System.Drawing.Size(359, 20);
			this.userInput.TabIndex = 3;
			// 
			// watchList
			// 
			this.watchList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.watchList.Font = new System.Drawing.Font("Consolas", 9F);
			this.watchList.FormattingEnabled = true;
			this.watchList.ItemHeight = 14;
			this.watchList.Location = new System.Drawing.Point(3, 73);
			this.watchList.MultiColumn = true;
			this.watchList.Name = "watchList";
			this.watchList.Size = new System.Drawing.Size(359, 234);
			this.watchList.TabIndex = 5;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.userInput, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.watchList, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(365, 310);
			this.tableLayoutPanel1.TabIndex = 7;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.removeWatch, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.addWatch, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 33);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(359, 34);
			this.tableLayoutPanel2.TabIndex = 4;
			// 
			// addWatch
			// 
			this.addWatch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.addWatch.Font = new System.Drawing.Font("Consolas", 9F);
			this.addWatch.Location = new System.Drawing.Point(3, 3);
			this.addWatch.Name = "addWatch";
			this.addWatch.Size = new System.Drawing.Size(173, 28);
			this.addWatch.TabIndex = 9;
			this.addWatch.Text = "Add Watch Berth";
			this.addWatch.UseVisualStyleBackColor = true;
			// 
			// removeWatch
			// 
			this.removeWatch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.removeWatch.Font = new System.Drawing.Font("Consolas", 9F);
			this.removeWatch.Location = new System.Drawing.Point(182, 3);
			this.removeWatch.Name = "removeWatch";
			this.removeWatch.Size = new System.Drawing.Size(174, 28);
			this.removeWatch.TabIndex = 10;
			this.removeWatch.Text = "Remove Watch Berth";
			this.removeWatch.UseVisualStyleBackColor = true;
			// 
			// BerthWatch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "BerthWatch";
			this.Size = new System.Drawing.Size(365, 310);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TextBox userInput;
		private System.Windows.Forms.ListBox watchList;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button removeWatch;
		private System.Windows.Forms.Button addWatch;
	}
}
