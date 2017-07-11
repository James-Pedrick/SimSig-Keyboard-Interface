using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimSig_Keyboard_Interface.Properties;


namespace SimSig_Keyboard_Interface.User_Interface.Connetions
{
	public partial class NrConnect : Form
	{
		public NrConnect()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Settings.Default.nrUserName = userName.Text;
			MainDisplays.MainMenu.NrPassword = password.Text;
			
			
		}
	}
}
