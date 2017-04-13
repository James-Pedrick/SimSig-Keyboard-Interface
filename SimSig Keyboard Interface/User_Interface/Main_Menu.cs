using System;
using System.IO;
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

			Connection.DataReceived += TcpDataUpdate;

		}

		private void MenuLoadSaveXml(object sender, EventArgs e)
		{


			if (loadSaveXML != null)
			{
				loadSaveGameXML.Title = @"Open saved XML save game";
				loadSaveGameXML.Filter = @"XML Files | *xml";


				if (loadSaveGameXML.ShowDialog() == DialogResult.OK)
					Settings.Default.wi = loadSaveGameXML.InitialDirectory + loadSaveGameXML.FileName;
				Data.SaveGameParser.Parse(ref _berths, ref _points, ref _signals); //Parse load with ref to points container

			}
			Refresh();

		}

		private void MainMenu_Load(object sender, EventArgs e)
		{

		}

		private void TcpDataUpdate(Object sender, MsgEventArgs e)
		{
			string[] receivedStrings = e.Msg.Split('|');


			foreach (string element in receivedStrings)
			{


				if (InvokeRequired)
				{
					Invoke(new MethodInvoker(delegate
					{
						debugRawTcpDisplay.Items.Insert(0, element);
						//Console.WriteLine(element);

					}));


					if (element.StartsWith("sB"))
					{
						if (InvokeRequired)
						{
							Invoke(new MethodInvoker(delegate
							{
								var z = element.Substring(2, 8);
								_berths.DataUpdateTcp(z);
								Refresh();

							}));
						}
					}
					if (element.StartsWith("sP"))
					{
						if (InvokeRequired)
							Invoke(new MethodInvoker(delegate
							{
								var z = element.Substring(2, 7);
								_points.AddPointTcp(z);
								Refresh();

							}));
					}
					if (element.StartsWith("sS"))
					{
						if (InvokeRequired)
							Invoke(new MethodInvoker(delegate
							{
								var z = element.Substring(2, 13);
								_signals.AddSignalTcp(z);
								Refresh();

							}));
					}
				}
			}
		}

		private void SaveRawToolStripMenuItem_Click(object sender, EventArgs e)
		{


			

		}

		private void loadSaveGameXML_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{

		}
	}

}





/*



		        //			if (element.StartsWith("sB")) { element = element.Substring(2, 8); TDs.Td(element); }							//Berth
		        //			if (element.StartsWith("sP")) { element = element.Substring(2, 8); Points.Point_Update_Received(element); }		//Points
		        //			if (element.StartsWith("pM")) { Phone.New_Call(element); }														//Phone Call Start
		        //			if (element.StartsWith("pO")) { Phone.End_Call(element);}														//Phone Call End
		        //			if (element.StartsWith("mA") && !element.StartsWith("mA13"))													//Client Message
		        //			if (element.StartsWith("iCB")) { string berthId = element.Substring(3, 4); string berthDescr = element.Substring(11, 4); TDs.Td(berthId + berthDescr);}							//Berth Connection
		        //			if (element.StartsWith("iCP")) { string pointId = element.Substring(3, 4); string pointState = element.Substring(11, 3); Points.Point_Update_Received(pointId, pointState);}	//Point Connection

	        }

	*/
