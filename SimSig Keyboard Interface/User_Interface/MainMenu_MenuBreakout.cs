using System;
using System.Windows.Forms;
using SimSig_Keyboard_Interface.Client.Berths;
using SimSig_Keyboard_Interface.Client.Points;
using SimSig_Keyboard_Interface.Client.Signals;
using SimSig_Keyboard_Interface.Properties;

// ************************************************************** Load Points config file ^^^



namespace SimSig_Keyboard_Interface.User_Interface
{
    public partial class MainMenu
    {

        #region Misc Menu Items

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Point_List_Reset(object sender, EventArgs e)
        {
            PointContainer.PointList.Clear();
        }

        private void BerthListReset(object sender, EventArgs e)
        {
            BerthContainer.BerthList.Clear();
        }

        private void SignalListReset(object sender, EventArgs e)
        {
            SignalContainer.SignalList.Clear();
        }


        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TcpConnectForm.ShowDialog();

            Connection.Connect(Settings.Default.ipAddress, Settings.Default.clientPort);
        }

        #endregion
    }
}
