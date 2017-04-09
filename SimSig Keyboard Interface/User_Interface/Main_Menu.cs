using System;
using System.Windows.Forms;
using SimSig_Keyboard_Interface.Client.Berths;
using SimSig_Keyboard_Interface.Client.Points;
using SimSig_Keyboard_Interface.Client.Signals;
using SimSig_Keyboard_Interface.Properties;

// ************************************************************** Load Points config file ^^^



namespace SimSig_Keyboard_Interface.User_Interface
{
	public partial class MainMenu : Form
	{
		// ******************************************************** Create points container

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
					Settings.Default.saveGameDirectory = loadSaveGameXML.InitialDirectory + loadSaveGameXML.FileName;
                
                

				Data.SaveGameParser.Parse(ref _berths, ref _points, ref _signals);			//Parse load with ref to points container
                Console.WriteLine(_points.PrintPoints());					//Print list of points storerd in container
         
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

		private void MainMenu_Load(object sender, EventArgs e)
		{

		}

		private void Tcp_Connection(object sender, EventArgs e)
		{
			string connectionMessage = "iA" +
			                           Settings.Default.clientName + "C" +
			                           Settings.Default.simVersion + "/" +
			                           Settings.Default.loadverVersion + "/" +
			                           Settings.Default.simulation + "|";


			
		}
	}
	
}
