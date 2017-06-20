using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimSig_Keyboard_Interface.User_Interface
{
	public partial class ComConnect : UserControl
	{
		public ComConnect()
		{
			InitializeComponent();

			string[] ports = SerialPort.GetPortNames();


			foreach (string port in ports)
				portSelect.Items.Add(port);
		}

		private void comListRefresh_Click(object sender, EventArgs e)
		{
			portSelect.Items.Clear();

			string[] ports = SerialPort.GetPortNames();


			foreach (string port in ports)
				portSelect.Items.Add(port);

		}
	}
}
