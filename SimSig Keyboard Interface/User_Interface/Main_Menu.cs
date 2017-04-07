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
using System.IO;
using System.Threading;
using SimSig_Keyboard_Interface.Client.Points;
// ************************************************************** Load Points config file ^^^



namespace SimSig_Keyboard_Interface
{
	public partial class Main_Menu : Form
	{
        // ******************************************************** Create points container
        public static PointContainer points = new PointContainer();

		public Main_Menu()
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
			var fileFirectoryLoadSavedGameXML = new OpenFileDialog();

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

        private void debugPointView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
