using System;
using System.Diagnostics;
using System.Windows.Forms;
using SimSig_Keyboard_Interface.Client.Berths;
using SimSig_Keyboard_Interface.Client.Points;
using SimSig_Keyboard_Interface.Client.Signals;
using SimSig_Keyboard_Interface.Client.TCP;
using SimSig_Keyboard_Interface.Properties;

// ************************************************************** Load Points config file ^^^



namespace SimSig_Keyboard_Interface.User_Interface
{
	public partial class MainMenu : Form
	{


		public static TcpClient Connection = new TcpClient();
		public static TcpConnect TcpConnectForm = new TcpConnect();

        

		/*************************/
		/*Creating containers    */
		/*************************/
		private static BerthContainer _berths = new BerthContainer();
		private static PointContainer _points = new PointContainer();
		private static SignalContainer _signals = new SignalContainer();

		public MainMenu()
		{
			InitializeComponent();
			debugBerthView.DataSource = BerthContainer.BerthList;
			debugPointView.DataSource = PointContainer.PointList;
			debugSignalView.DataSource = SignalContainer.SignalList;
            Connection.DataReceived += Connection_DataReceived;
        }

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void loadSaveGameXMLToolStripMenuItem_Click(object sender, EventArgs e)
		{


			if (loadSaveXML != null)
			{
				loadSaveGameXML.Title = @"Open saved XML save game";
				loadSaveGameXML.Filter = @"XML Files | *xml";


				if (loadSaveGameXML.ShowDialog() == DialogResult.OK)
					Settings.Default.wi = loadSaveGameXML.InitialDirectory + loadSaveGameXML.FileName;



				Data.SaveGameParser.Parse(ref _berths, ref _points, ref _signals);          //Parse load with ref to points container
				Console.WriteLine(_points.PrintPoints());                   //Print list of points storerd in container

			}
			Refresh();

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

		private void MainMenu_Load(object sender, EventArgs e)
		{

		}

        private void Connection_DataReceived(Object sender, MsgEventArgs e)
        {
            System.Console.WriteLine("Testing Data transmission : " + e.Msg);
        }
	}

}
