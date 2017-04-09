﻿namespace SimSig_Keyboard_Interface.User_Interface
{
	partial class TcpConnect
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
			this.label1 = new System.Windows.Forms.Label();
			this.simulation = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.ipAddress = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.port = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.clientName = new System.Windows.Forms.TextBox();
			this.simVersion = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.loaderVersion = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.cancel = new System.Windows.Forms.Button();
			this.connect = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.port)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(355, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "SimSig Client Connection";
			// 
			// simulation
			// 
			this.simulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.simulation.Location = new System.Drawing.Point(211, 78);
			this.simulation.Margin = new System.Windows.Forms.Padding(4);
			this.simulation.Name = "simulation";
			this.simulation.Size = new System.Drawing.Size(253, 23);
			this.simulation.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 78);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Simulation";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(16, 250);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Port";
			// 
			// ipAddress
			// 
			this.ipAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.ipAddress.Location = new System.Drawing.Point(211, 207);
			this.ipAddress.Margin = new System.Windows.Forms.Padding(4);
			this.ipAddress.Name = "ipAddress";
			this.ipAddress.Size = new System.Drawing.Size(253, 23);
			this.ipAddress.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(16, 207);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 16);
			this.label4.TabIndex = 5;
			this.label4.Text = "IP Address";
			// 
			// port
			// 
			this.port.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.port.Location = new System.Drawing.Point(211, 250);
			this.port.Margin = new System.Windows.Forms.Padding(4);
			this.port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.port.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.port.Name = "port";
			this.port.Size = new System.Drawing.Size(255, 23);
			this.port.TabIndex = 6;
			this.port.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(16, 294);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(81, 16);
			this.label6.TabIndex = 10;
			this.label6.Text = "Client Name";
			// 
			// clientName
			// 
			this.clientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.clientName.Location = new System.Drawing.Point(211, 294);
			this.clientName.Margin = new System.Windows.Forms.Padding(4);
			this.clientName.Name = "clientName";
			this.clientName.Size = new System.Drawing.Size(253, 23);
			this.clientName.TabIndex = 9;
			// 
			// simVersion
			// 
			this.simVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.simVersion.Location = new System.Drawing.Point(211, 119);
			this.simVersion.Margin = new System.Windows.Forms.Padding(4);
			this.simVersion.Name = "simVersion";
			this.simVersion.Size = new System.Drawing.Size(253, 23);
			this.simVersion.TabIndex = 7;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(16, 119);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 16);
			this.label7.TabIndex = 8;
			this.label7.Text = "Sim Version";
			// 
			// loaderVersion
			// 
			this.loaderVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.loaderVersion.Location = new System.Drawing.Point(211, 162);
			this.loaderVersion.Margin = new System.Windows.Forms.Padding(4);
			this.loaderVersion.Name = "loaderVersion";
			this.loaderVersion.Size = new System.Drawing.Size(253, 23);
			this.loaderVersion.TabIndex = 9;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(16, 162);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 16);
			this.label8.TabIndex = 10;
			this.label8.Text = "Loader Version";
			// 
			// cancel
			// 
			this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.cancel.Location = new System.Drawing.Point(8, 337);
			this.cancel.Margin = new System.Windows.Forms.Padding(4);
			this.cancel.Name = "cancel";
			this.cancel.Size = new System.Drawing.Size(217, 54);
			this.cancel.TabIndex = 11;
			this.cancel.Text = "Cancel";
			this.cancel.UseVisualStyleBackColor = true;
			this.cancel.Click += new System.EventHandler(this.cancel_Click);
			// 
			// connect
			// 
			this.connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.connect.Location = new System.Drawing.Point(251, 337);
			this.connect.Margin = new System.Windows.Forms.Padding(4);
			this.connect.Name = "connect";
			this.connect.Size = new System.Drawing.Size(215, 54);
			this.connect.TabIndex = 12;
			this.connect.Text = "Connect";
			this.connect.UseVisualStyleBackColor = true;
			this.connect.Click += new System.EventHandler(this.connect_Click);
			// 
			// TcpConnect
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(481, 450);
			this.Controls.Add(this.connect);
			this.Controls.Add(this.cancel);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.loaderVersion);
			this.Controls.Add(this.clientName);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.simVersion);
			this.Controls.Add(this.port);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.ipAddress);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.simulation);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TcpConnect";
			this.Text = "TCP_Connect";
			this.Load += new System.EventHandler(this.TCP_Connect_Load);
			((System.ComponentModel.ISupportInitialize)(this.port)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox simulation;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox ipAddress;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown port;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox clientName;
		private System.Windows.Forms.TextBox simVersion;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox loaderVersion;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button cancel;
		private System.Windows.Forms.Button connect;
	}
}