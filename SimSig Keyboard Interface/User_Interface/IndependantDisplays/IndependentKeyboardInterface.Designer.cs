namespace SimSig_Keyboard_Interface.User_Interface.IndependantDisplays
{
	partial class IndependentKeyboardInterface
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
			this.keyboardInterface1 = new SimSig_Keyboard_Interface.User_Interface.KeyboardInterface();
			this.SuspendLayout();
			// 
			// keyboardInterface1
			// 
			this.keyboardInterface1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.keyboardInterface1.Location = new System.Drawing.Point(0, 0);
			this.keyboardInterface1.Name = "keyboardInterface1";
			this.keyboardInterface1.Size = new System.Drawing.Size(784, 561);
			this.keyboardInterface1.TabIndex = 0;
			// 
			// IndependentKeyboardInterface
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.ControlBox = false;
			this.Controls.Add(this.keyboardInterface1);
			this.IsMdiContainer = true;
			this.Name = "IndependentKeyboardInterface";
			this.ShowInTaskbar = false;
			this.Text = "Keyboard Interace";
			this.Load += new System.EventHandler(this.IndependentKeyboardInterface_Load);
			this.ResumeLayout(false);

		}

		#endregion


			
		private KeyboardInterface keyboardInterface1;
	}
}