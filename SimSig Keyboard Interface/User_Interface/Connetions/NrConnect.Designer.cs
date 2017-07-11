namespace SimSig_Keyboard_Interface.User_Interface.Connetions
{
	partial class NrConnect
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
			this.userName = new System.Windows.Forms.TextBox();
			this.password = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// userName
			// 
			this.userName.Location = new System.Drawing.Point(61, 33);
			this.userName.Name = "userName";
			this.userName.Size = new System.Drawing.Size(100, 20);
			this.userName.TabIndex = 0;
			// 
			// password
			// 
			this.password.Location = new System.Drawing.Point(51, 112);
			this.password.Name = "password";
			this.password.PasswordChar = '*';
			this.password.Size = new System.Drawing.Size(100, 20);
			this.password.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(94, 183);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// NrConnect
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.password);
			this.Controls.Add(this.userName);
			this.Name = "NrConnect";
			this.Text = "NrConnect";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox userName;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.Button button1;
	}
}