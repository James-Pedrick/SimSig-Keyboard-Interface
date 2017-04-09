using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimSig_Keyboard_Interface.Properties;
using SimSig_Keyboard_Interface.Data;
using SimSig_Keyboard_Interface.User_Interface;
using System.Windows.Forms;

namespace SimSig_Keyboard_Interface.User_Interface
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
            //        Settings.Default.clientPort = port
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
            //        Settings.Default.clientPort = port
            Settings.Default.clientName = clientName.Text;

            Close();


        }
    }
}
