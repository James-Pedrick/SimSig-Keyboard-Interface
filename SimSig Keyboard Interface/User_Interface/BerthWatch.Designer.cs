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
			this.addWatch = new System.Windows.Forms.Button();
			this.removeWatch = new System.Windows.Forms.Button();
			this.userInput = new System.Windows.Forms.TextBox();
			this.watchList = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// addWatch
			// 
			this.addWatch.Font = new System.Drawing.Font("Consolas", 9F);
			this.addWatch.Location = new System.Drawing.Point(10, 36);
			this.addWatch.Name = "addWatch";
			this.addWatch.Size = new System.Drawing.Size(127, 23);
			this.addWatch.TabIndex = 1;
			this.addWatch.Text = "Add Watch Berth";
			this.addWatch.UseVisualStyleBackColor = true;
			this.addWatch.Click += new System.EventHandler(this.AddWatch_Click);
			// 
			// removeWatch
			// 
			this.removeWatch.Font = new System.Drawing.Font("Consolas", 9F);
			this.removeWatch.Location = new System.Drawing.Point(143, 36);
			this.removeWatch.Name = "removeWatch";
			this.removeWatch.Size = new System.Drawing.Size(127, 23);
			this.removeWatch.TabIndex = 2;
			this.removeWatch.Text = "Remove Watch Berth";
			this.removeWatch.UseVisualStyleBackColor = true;
			// 
			// userInput
			// 
			this.userInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.userInput.Location = new System.Drawing.Point(10, 10);
			this.userInput.Name = "userInput";
			this.userInput.Size = new System.Drawing.Size(345, 20);
			this.userInput.TabIndex = 3;
			// 
			// watchList
			// 
			this.watchList.FormattingEnabled = true;
			this.watchList.Location = new System.Drawing.Point(10, 65);
			this.watchList.Name = "watchList";
			this.watchList.Size = new System.Drawing.Size(345, 238);
			this.watchList.TabIndex = 5;
			// 
			// BerthWatch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.watchList);
			this.Controls.Add(this.userInput);
			this.Controls.Add(this.removeWatch);
			this.Controls.Add(this.addWatch);
			this.Name = "BerthWatch";
			this.Size = new System.Drawing.Size(365, 310);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button addWatch;
		private System.Windows.Forms.Button removeWatch;
		private System.Windows.Forms.TextBox userInput;
		private System.Windows.Forms.ListBox watchList;
	}
}
