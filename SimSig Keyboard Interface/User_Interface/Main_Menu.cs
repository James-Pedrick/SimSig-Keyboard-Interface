using System;
using System.Windows.Forms;
using SimSig_Keyboard_Interface.Client.Points;
using SimSig_Keyboard_Interface.Client.Signals;
using SimSig_Keyboard_Interface.Properties;

// ************************************************************** Load Points config file ^^^



namespace SimSig_Keyboard_Interface.User_Interface
{
	public partial class MainMenu : Form
	{
        // ******************************************************** Create points container
        public static PointContainer Points = new PointContainer();
		public static SignalContainer Signals = new SignalContainer();

		public MainMenu()
		{
			
			InitializeComponent();
            debugPointView.DataSource = PointContainer.PointList;
			debugSignalView.DataSource = SignalContainer.SignalList;




		}

		private void MainMenu_Load(object sender, EventArgs e)
		{
			
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void loadSaveGameXMLToolStripMenuItem_Click(object sender, EventArgs e)
		{
	//		var fileDirectoryLoadSavedGameXml = new OpenFileDialog();

			if (loadSaveXML != null)
			{
				loadSaveGameXML.Title = @"Open saved XML save game";
				loadSaveGameXML.Filter = @"XML Files | *xml";


				if (loadSaveGameXML.ShowDialog() == DialogResult.OK)
					Settings.Default.saveGameDirectory = loadSaveGameXML.InitialDirectory + loadSaveGameXML.FileName;
                
                

				Data.SaveGameParser.Parse(ref Points, ref Signals);					//Parse load with ref to points container
                Console.WriteLine(Points.PrintPoints());				//Print list of points storerd in container
          
				
				
				
				
				
				//		Client.XML_Parsers.Data_Parsers.Parse();
         
			}
            Refresh();

        }

        private void Point_List_Reset(object sender, EventArgs e)
        {
            PointContainer.PointList.Clear();
        }
    }
}
