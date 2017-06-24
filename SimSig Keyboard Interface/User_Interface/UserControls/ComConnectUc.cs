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
using SimSig_Keyboard_Interface.Properties;

namespace SimSig_Keyboard_Interface.User_Interface
{
	public partial class ComConnectUc : UserControl
	{
		public ComConnectUc()
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

		private void connect_Click(object sender, EventArgs e)
		{
			Settings.Default.comDataBits = Convert.ToInt32(comDataBits.Value);
			Settings.Default.comBaudRate = Convert.ToInt32(baudRate.Value);
			Settings.Default.comPortName = portSelect.Text;
		}
	}
}
