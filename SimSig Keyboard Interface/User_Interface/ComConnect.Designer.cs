namespace SimSig_Keyboard_Interface.User_Interface
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.portSelect = new System.Windows.Forms.ComboBox();
			this.baudRate = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.baudRate)).BeginInit();
			this.SuspendLayout();
			// 
			// portSelect
			// 
			this.portSelect.FormattingEnabled = true;
			this.portSelect.Location = new System.Drawing.Point(91, 60);
			this.portSelect.Name = "portSelect";
			this.portSelect.Size = new System.Drawing.Size(121, 21);
			this.portSelect.Sorted = true;
			this.portSelect.TabIndex = 0;
			// 
			// baudRate
			// 
			this.baudRate.Location = new System.Drawing.Point(91, 104);
			this.baudRate.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.baudRate.Name = "baudRate";
			this.baudRate.Size = new System.Drawing.Size(120, 20);
			this.baudRate.TabIndex = 1;
			this.baudRate.Value = new decimal(new int[] {
            9600,
            0,
            0,
            0});
			// 
			// ComConnect
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.baudRate);
			this.Controls.Add(this.portSelect);
			this.Name = "ComConnect";
			this.Size = new System.Drawing.Size(371, 455);
			((System.ComponentModel.ISupportInitialize)(this.baudRate)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox portSelect;
		private System.Windows.Forms.NumericUpDown baudRate;
	}
}
