namespace SimSig_Keyboard_Interface.User_Interface
{
    partial class KeyboardInterface
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
			this.Header = new System.Windows.Forms.TableLayoutPanel();
			this.keyboardSpecFunction = new System.Windows.Forms.TextBox();
			this.userInputString = new System.Windows.Forms.TextBox();
			this.clock = new System.Windows.Forms.TextBox();
			this.ttDisplay = new System.Windows.Forms.ListBox();
			this.Header.SuspendLayout();
			this.SuspendLayout();
			// 
			// Header
			// 
			this.Header.ColumnCount = 3;
			this.Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
			this.Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
			this.Header.Controls.Add(this.keyboardSpecFunction, 0, 0);
			this.Header.Controls.Add(this.userInputString, 1, 0);
			this.Header.Controls.Add(this.clock, 2, 0);
			this.Header.Dock = System.Windows.Forms.DockStyle.Top;
			this.Header.Location = new System.Drawing.Point(0, 0);
			this.Header.Name = "Header";
			this.Header.RowCount = 1;
			this.Header.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.Header.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
			this.Header.Size = new System.Drawing.Size(582, 37);
			this.Header.TabIndex = 0;
			this.Header.Paint += new System.Windows.Forms.PaintEventHandler(this.Header_Paint);
			// 
			// keyboardSpecFunction
			// 
			this.keyboardSpecFunction.BackColor = System.Drawing.Color.Black;
			this.keyboardSpecFunction.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.keyboardSpecFunction.Font = new System.Drawing.Font("Consolas", 11F);
			this.keyboardSpecFunction.ForeColor = System.Drawing.Color.Cyan;
			this.keyboardSpecFunction.Location = new System.Drawing.Point(4, 4);
			this.keyboardSpecFunction.Margin = new System.Windows.Forms.Padding(4);
			this.keyboardSpecFunction.MaxLength = 3;
			this.keyboardSpecFunction.Name = "keyboardSpecFunction";
			this.keyboardSpecFunction.ReadOnly = true;
			this.keyboardSpecFunction.Size = new System.Drawing.Size(67, 25);
			this.keyboardSpecFunction.TabIndex = 15;
			this.keyboardSpecFunction.TabStop = false;
			this.keyboardSpecFunction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// userInputString
			// 
			this.userInputString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.userInputString.BackColor = System.Drawing.SystemColors.InfoText;
			this.userInputString.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.userInputString.Font = new System.Drawing.Font("Consolas", 11F);
			this.userInputString.ForeColor = System.Drawing.Color.Cyan;
			this.userInputString.Location = new System.Drawing.Point(79, 4);
			this.userInputString.Margin = new System.Windows.Forms.Padding(4);
			this.userInputString.MinimumSize = new System.Drawing.Size(4, 25);
			this.userInputString.Name = "userInputString";
			this.userInputString.Size = new System.Drawing.Size(424, 25);
			this.userInputString.TabIndex = 1;
			this.userInputString.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userInputString_KeyDown);
			// 
			// clock
			// 
			this.clock.BackColor = System.Drawing.Color.Black;
			this.clock.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.clock.Dock = System.Windows.Forms.DockStyle.Fill;
			this.clock.Font = new System.Drawing.Font("Consolas", 11F);
			this.clock.ForeColor = System.Drawing.Color.Cyan;
			this.clock.Location = new System.Drawing.Point(510, 3);
			this.clock.Name = "clock";
			this.clock.Size = new System.Drawing.Size(69, 25);
			this.clock.TabIndex = 16;
			this.clock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ttDisplay
			// 
			this.ttDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ttDisplay.BackColor = System.Drawing.SystemColors.WindowText;
			this.ttDisplay.Cursor = System.Windows.Forms.Cursors.AppStarting;
			this.ttDisplay.Font = new System.Drawing.Font("Consolas", 11F);
			this.ttDisplay.ForeColor = System.Drawing.Color.Cyan;
			this.ttDisplay.FormattingEnabled = true;
			this.ttDisplay.ItemHeight = 18;
			this.ttDisplay.Location = new System.Drawing.Point(4, 44);
			this.ttDisplay.Margin = new System.Windows.Forms.Padding(4);
			this.ttDisplay.Name = "ttDisplay";
			this.ttDisplay.Size = new System.Drawing.Size(574, 436);
			this.ttDisplay.TabIndex = 17;
			this.ttDisplay.SelectedIndexChanged += new System.EventHandler(this.ttDisplay_SelectedIndexChanged);
			// 
			// KeyboardInterface
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ttDisplay);
			this.Controls.Add(this.Header);
			this.Name = "KeyboardInterface";
			this.Size = new System.Drawing.Size(582, 495);
			this.Header.ResumeLayout(false);
			this.Header.PerformLayout();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.TableLayoutPanel Header;
		public System.Windows.Forms.TextBox userInputString;
		private System.Windows.Forms.TextBox keyboardSpecFunction;
		private System.Windows.Forms.ListBox ttDisplay;
		private System.Windows.Forms.TextBox clock;
	}
}
