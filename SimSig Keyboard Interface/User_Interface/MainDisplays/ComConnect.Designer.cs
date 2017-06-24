namespace SimSig_Keyboard_Interface.User_Interface.MainDisplays
{
	partial class ComConnect
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
			this.comConnect1 = new SimSig_Keyboard_Interface.User_Interface.ComConnectUc();
			this.comConnectUc1 = new SimSig_Keyboard_Interface.User_Interface.ComConnectUc();
			this.SuspendLayout();
			// 
			// comConnect1
			// 
			this.comConnect1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comConnect1.Location = new System.Drawing.Point(0, 0);
			this.comConnect1.Name = "comConnect1";
			this.comConnect1.Size = new System.Drawing.Size(320, 317);
			this.comConnect1.TabIndex = 1;
			// 
			// comConnectUc1
			// 
			this.comConnectUc1.Location = new System.Drawing.Point(12, 12);
			this.comConnectUc1.Name = "comConnectUc1";
			this.comConnectUc1.Size = new System.Drawing.Size(322, 231);
			this.comConnectUc1.TabIndex = 0;
			// 
			// ComConnect
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(342, 238);
			this.Controls.Add(this.comConnectUc1);
			this.Name = "ComConnect";
			this.Text = "ComConnect";
			this.ResumeLayout(false);

		}

		#endregion

		private User_Interface.ComConnectUc comConnect1;
		private ComConnectUc comConnectUc1;
	}
}