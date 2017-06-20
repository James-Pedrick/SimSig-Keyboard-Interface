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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Header.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // 
            // keyboardSpecFunction
            // 
            this.keyboardSpecFunction.BackColor = System.Drawing.Color.Black;
            this.keyboardSpecFunction.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.keyboardSpecFunction.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.keyboardSpecFunction.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.userInputString.BackColor = System.Drawing.SystemColors.InfoText;
            this.userInputString.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.userInputString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userInputString.Font = new System.Drawing.Font("Consolas", 11F);
            this.userInputString.ForeColor = System.Drawing.Color.Cyan;
            this.userInputString.Location = new System.Drawing.Point(79, 4);
            this.userInputString.Margin = new System.Windows.Forms.Padding(4);
            this.userInputString.MinimumSize = new System.Drawing.Size(4, 25);
            this.userInputString.Name = "userInputString";
            this.userInputString.Size = new System.Drawing.Size(424, 25);
            this.userInputString.TabIndex = 1;
            this.userInputString.TextChanged += new System.EventHandler(this.UserInputString_TextChanged);
            this.userInputString.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserInputString_KeyDown);
            // 
            // clock
            // 
            this.clock.BackColor = System.Drawing.Color.Black;
            this.clock.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.clock.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.clock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clock.Font = new System.Drawing.Font("Consolas", 11F);
            this.clock.ForeColor = System.Drawing.Color.Cyan;
            this.clock.Location = new System.Drawing.Point(510, 3);
            this.clock.Name = "clock";
            this.clock.ReadOnly = true;
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
            this.ttDisplay.Location = new System.Drawing.Point(10, 43);
            this.ttDisplay.Margin = new System.Windows.Forms.Padding(10);
            this.ttDisplay.Name = "ttDisplay";
            this.ttDisplay.Size = new System.Drawing.Size(562, 436);
            this.ttDisplay.TabIndex = 17;
            this.ttDisplay.SelectedIndexChanged += new System.EventHandler(this.TtDisplay_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ttDisplay);
            this.panel1.Controls.Add(this.Header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 495);
            this.panel1.TabIndex = 18;
            // 
            // KeyboardInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "KeyboardInterface";
            this.Size = new System.Drawing.Size(582, 495);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.TableLayoutPanel Header;
		public System.Windows.Forms.TextBox userInputString;
		private System.Windows.Forms.TextBox keyboardSpecFunction;
		private System.Windows.Forms.ListBox ttDisplay;
		private System.Windows.Forms.TextBox clock;
		private System.Windows.Forms.Panel panel1;
	}
}
