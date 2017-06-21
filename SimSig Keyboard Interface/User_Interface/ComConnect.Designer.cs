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
			this.comListRefresh = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.connect = new System.Windows.Forms.Button();
			this.cancel = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.comDataBits = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.baudRate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.comDataBits)).BeginInit();
			this.SuspendLayout();
			// 
			// portSelect
			// 
			this.portSelect.Font = new System.Drawing.Font("Consolas", 11F);
			this.portSelect.FormattingEnabled = true;
			this.portSelect.Location = new System.Drawing.Point(108, 3);
			this.portSelect.Name = "portSelect";
			this.portSelect.Size = new System.Drawing.Size(121, 26);
			this.portSelect.Sorted = true;
			this.portSelect.TabIndex = 0;
			// 
			// baudRate
			// 
			this.baudRate.Font = new System.Drawing.Font("Consolas", 11F);
			this.baudRate.Location = new System.Drawing.Point(109, 38);
			this.baudRate.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.baudRate.Name = "baudRate";
			this.baudRate.Size = new System.Drawing.Size(120, 25);
			this.baudRate.TabIndex = 1;
			this.baudRate.Value = new decimal(new int[] {
            9600,
            0,
            0,
            0});
			// 
			// comListRefresh
			// 
			this.comListRefresh.Font = new System.Drawing.Font("Consolas", 11F);
			this.comListRefresh.Location = new System.Drawing.Point(235, 6);
			this.comListRefresh.Name = "comListRefresh";
			this.comListRefresh.Size = new System.Drawing.Size(75, 23);
			this.comListRefresh.TabIndex = 2;
			this.comListRefresh.Text = "Refresh";
			this.comListRefresh.UseVisualStyleBackColor = true;
			this.comListRefresh.Click += new System.EventHandler(this.comListRefresh_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Consolas", 11F);
			this.label1.Location = new System.Drawing.Point(10, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 18);
			this.label1.TabIndex = 3;
			this.label1.Text = "COM Port";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Consolas", 11F);
			this.label2.Location = new System.Drawing.Point(10, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 18);
			this.label2.TabIndex = 4;
			this.label2.Text = "Baud Rate";
			// 
			// connect
			// 
			this.connect.Location = new System.Drawing.Point(219, 137);
			this.connect.Name = "connect";
			this.connect.Size = new System.Drawing.Size(75, 23);
			this.connect.TabIndex = 5;
			this.connect.Text = "Connect";
			this.connect.UseVisualStyleBackColor = true;
			this.connect.Click += new System.EventHandler(this.connect_Click);
			// 
			// cancel
			// 
			this.cancel.Location = new System.Drawing.Point(24, 137);
			this.cancel.Name = "cancel";
			this.cancel.Size = new System.Drawing.Size(75, 23);
			this.cancel.TabIndex = 6;
			this.cancel.Text = "Cancel";
			this.cancel.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Consolas", 11F);
			this.label3.Location = new System.Drawing.Point(10, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 18);
			this.label3.TabIndex = 8;
			this.label3.Text = "Data Bits";
			// 
			// comDataBits
			// 
			this.comDataBits.Font = new System.Drawing.Font("Consolas", 11F);
			this.comDataBits.Location = new System.Drawing.Point(109, 72);
			this.comDataBits.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.comDataBits.Name = "comDataBits";
			this.comDataBits.Size = new System.Drawing.Size(120, 25);
			this.comDataBits.TabIndex = 7;
			this.comDataBits.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
			// 
			// ComConnect
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comDataBits);
			this.Controls.Add(this.cancel);
			this.Controls.Add(this.connect);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comListRefresh);
			this.Controls.Add(this.baudRate);
			this.Controls.Add(this.portSelect);
			this.Name = "ComConnect";
			this.Size = new System.Drawing.Size(322, 186);
			((System.ComponentModel.ISupportInitialize)(this.baudRate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.comDataBits)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox portSelect;
		private System.Windows.Forms.NumericUpDown baudRate;
		private System.Windows.Forms.Button comListRefresh;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button connect;
		private System.Windows.Forms.Button cancel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown comDataBits;
	}
}
