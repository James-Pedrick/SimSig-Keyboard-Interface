using System;
using System.Windows.Forms;
using SimSig_Keyboard_Interface.Client.Points;
using SimSig_Keyboard_Interface.Properties;

// ************************************************************** Load Points config file ^^^



namespace SimSig_Keyboard_Interface.User_Interface
{
	public partial class MainMenu : Form
	{
        // ******************************************************** Create points container
        public static PointContainer points = new PointContainer();

		public MainMenu()
		{
			
			InitializeComponent();
            debugPointView.DataSource = PointContainer.PointList;

            
            
            
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
			var fileDirectoryLoadSavedGameXml = new OpenFileDialog();

			if (loadSaveXML != null)
			{
				loadSaveGameXML.Title = "Open saved XML save game";
				loadSaveGameXML.Filter = "XML Files | *xml";


				if (loadSaveGameXML.ShowDialog() == DialogResult.OK)
					Settings.Default.saveGameDirectory = loadSaveGameXML.InitialDirectory + loadSaveGameXML.FileName;
                
                
                // **************************************************** Parse load woith ref to points container
				Data.SaveGameParser.Parse(ref points);

                // **************************************************** Debug print list of points stored in container
                Console.WriteLine(points.PrintPoints());
                //		Client.XML_Parsers.Data_Parsers.Parse();
         
			}
            Refresh();

        }

    }
}
