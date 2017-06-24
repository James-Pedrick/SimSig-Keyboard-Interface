namespace SimSig_Keyboard_Interface.User_Interface.MainDisplays
{
	partial class IndependentDebugDisplay
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
			this.debugUc1 = new SimSig_Keyboard_Interface.User_Interface.UserControls.DebugUc();
			this.SuspendLayout();
			// 
			// debugUc1
			// 
			this.debugUc1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.debugUc1.Location = new System.Drawing.Point(0, 0);
			this.debugUc1.Name = "debugUc1";
			this.debugUc1.Size = new System.Drawing.Size(784, 561);
			this.debugUc1.TabIndex = 0;
			// 
			// IndependentDebugDisplay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.debugUc1);
			this.Name = "IndependentDebugDisplay";
			this.Text = "IndependentDebugDisplay";
			this.ResumeLayout(false);

		}

		#endregion

		private UserControls.DebugUc debugUc1;
	}
}