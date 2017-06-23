namespace SimSig_Keyboard_Interface.User_Interface
{
	partial class IndependentPhoneDisplay
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
			this.phoneUi = new SimSig_Keyboard_Interface.User_Interface.PhoneUi();
			this.SuspendLayout();
			// 
			// phoneUi
			// 
			this.phoneUi.Dock = System.Windows.Forms.DockStyle.Fill;
			this.phoneUi.Location = new System.Drawing.Point(0, 0);
			this.phoneUi.Name = "phoneUi";
			this.phoneUi.Size = new System.Drawing.Size(784, 561);
			this.phoneUi.TabIndex = 0;
			// 
			// IndependentPhoneDisplay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.phoneUi);
			this.Name = "IndependentPhoneDisplay";
			this.Text = "IndependentPhoneDisplay";
			this.ResumeLayout(false);

		}

		#endregion

		private PhoneUi phoneUi;
	}
}