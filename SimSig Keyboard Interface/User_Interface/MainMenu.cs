using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimSig_Keyboard_Interface
{
	public partial class MainMenu : Form
	{
		public MainMenu()
		{
			
			InitializeComponent();
		}

		private void MainMenu_Load(object sender, EventArgs e)
		{
			
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
