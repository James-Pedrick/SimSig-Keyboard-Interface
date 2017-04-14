using System;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Windows.Forms;
using SimSig_Keyboard_Interface.Client.Berths;
using SimSig_Keyboard_Interface.Client.Calls;
using SimSig_Keyboard_Interface.Client.Points;
using SimSig_Keyboard_Interface.Client.Signals;
using SimSig_Keyboard_Interface.Client.TCP;
using SimSig_Keyboard_Interface.Client.Track;
using SimSig_Keyboard_Interface.Properties;

// ************************************************************** Load Points config file ^^^



namespace SimSig_Keyboard_Interface.User_Interface
{
	public partial class MainMenu : Form
	{




		/*************************/
		/*Creating containers    */
		/*************************/
		public static TcpClient Connection = new TcpClient();
		public static TcpConnect TcpConnectForm = new TcpConnect();


		private static BerthContainer _berths = new BerthContainer();
		private static PointContainer _points = new PointContainer();
		private static SignalContainer _signals = new SignalContainer();
		private static TrackContainer _tracks = new TrackContainer();
		private static CallContainer _calls = new CallContainer();






		public MainMenu()
		{
			InitializeComponent();
			
			debugBerthView.DataSource = BerthContainer.BerthList;
			debugPointView.DataSource = PointContainer.PointList;
			debugSignalView.DataSource = SignalContainer.SignalList;
			debugTrackView.DataSource = TrackContainer.TrackList;
			debugCallView.DataSource = CallContainer.CallList;
			
			Connection.DataReceived += TcpDataUpdate;
			
			callers.Items.Clear();



			
		}

		private void MenuLoadSaveXml(object sender, EventArgs e)
		{


			if (loadSaveXML != null)
			{
				loadSaveGameXML.Title = @"Open saved XML save game";
				loadSaveGameXML.Filter = @"XML Files | *xml";


				if (loadSaveGameXML.ShowDialog() == DialogResult.OK)
					Settings.Default.wi = loadSaveGameXML.InitialDirectory + loadSaveGameXML.FileName;
				Data.SaveGameParser.Parse(ref _berths, ref _points, ref _signals, ref _tracks); //Parse load with ref to points container

			}
			Refresh();

		}

		private void MainMenu_Load(object sender, EventArgs e)
		{

		}

		#region DataUpdates
		private void TcpDataUpdate(Object sender, MsgEventArgs e)
		{
			string[] receivedStrings = e.Msg.Split('|');


			foreach (string element in receivedStrings)
			{
				if (InvokeRequired)
				{
					Invoke(new MethodInvoker(delegate { debugRawTcpDisplay.Items.Insert(0, element); if (element.StartsWith("sT")) Console.WriteLine(element); }));


					if (element.StartsWith("sB")) if (InvokeRequired) Invoke(new MethodInvoker(delegate { _berths.DataUpdateTcp(element.Substring(2, 8)); Refresh(); }));
					if (element.StartsWith("sP")) if (InvokeRequired) Invoke(new MethodInvoker(delegate { _points.AddPointTcp(element.Substring(2, 7)); Refresh(); }));
					if (element.StartsWith("sS")) if (InvokeRequired) Invoke(new MethodInvoker(delegate { _signals.AddSignalTcp(element.Substring(2, 13)); Refresh(); }));
					if (element.StartsWith("sT")) if (InvokeRequired) Invoke(new MethodInvoker(delegate { _tracks.AddTrackTcp(element.Substring(2, 6)); Refresh(); }));


					if (element.StartsWith("pM")) if (InvokeRequired) Invoke(new MethodInvoker(delegate { _calls.NewIncomingCall(element); callers.Items.Clear(); foreach (var x in CallContainer.CallList) if (x.CallActive) callers.Items.Add(x.CallerName); Refresh(); }));
					if (element.StartsWith("pO")) if (InvokeRequired) Invoke(new MethodInvoker(delegate { _calls.EndIncomingCall(element); callers.Items.Clear(); foreach (var x in CallContainer.CallList) if (x.CallActive) callers.Items.Add(x.CallerName); Refresh(); }));
				}
			}
		}
		#endregion

		#region Keyboard Interface Controls
		private void keyboardInterpose_Click(object sender, EventArgs e)
		{
			string[] userInput = userInputString.Text.Split(' ');

			if (userInputString.Text.Contains(' ') == false) return;        //Not doing anything if the user has not enterd a space after the berth


			var berthHex = _berths.BerthHIdLookup(userInput[0]);

			Connection.SendData(@"BB" + berthHex + userInput[1] + "|");

		}


		private void keyboardTdCancel_Click(object sender, EventArgs e)
		{
			string[] userInput = userInputString.Text.Split(' ');

			var berthHex = _berths.BerthHIdLookup(userInput[0]);

			Connection.SendData(@"BC" + berthHex + "|");

		}

		#endregion

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

		private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void sendToSim_Click(object sender, EventArgs e)
		{
			Connection.SendData(userInputString.Text);
		}

		private void callers_SelectedIndexChanged(object sender, EventArgs e)
		{
			int position = callers.SelectedIndex;

	//		string [] responses = _calls.

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
