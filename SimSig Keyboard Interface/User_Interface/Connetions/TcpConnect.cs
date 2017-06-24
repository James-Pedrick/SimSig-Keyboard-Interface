using System;
using System.Windows.Forms;
using SimSig_Keyboard_Interface.Properties;

namespace SimSig_Keyboard_Interface.User_Interface.Connetions
{
	public partial class TcpConnect : Form
	{
		public TcpConnect()
		{
			InitializeComponent();


			simulation.Text = Settings.Default.simulation;
			simVersion.Text = Settings.Default.simVersion;
			loaderVersion.Text = Settings.Default.loadverVersion;
			ipAddress.Text = Settings.Default.ipAddress;
			port.Value = Settings.Default.clientPort;
			clientName.Text = Settings.Default.clientName;

		}

		private void TCP_Connect_Load(object sender, EventArgs e)
		{

		}

		private void cancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void connect_Click(object sender, EventArgs e)
		{
			Settings.Default.simulation = simulation.Text;
			Settings.Default.simVersion = simVersion.Text;
			Settings.Default.loadverVersion = loaderVersion.Text;
			Settings.Default.ipAddress = ipAddress.Text;
			Settings.Default.clientPort = (int)port.Value;
			Settings.Default.clientName = clientName.Text.PadRight(4, ' ');

			Close();


		}
	}
}
