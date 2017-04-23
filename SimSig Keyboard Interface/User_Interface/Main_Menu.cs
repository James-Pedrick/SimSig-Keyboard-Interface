using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using SimSig_Keyboard_Interface.Comms.TCP;
using SimSig_Keyboard_Interface.DataProcess.Berths;
using SimSig_Keyboard_Interface.DataProcess.Calls;
using SimSig_Keyboard_Interface.DataProcess.Points;
using SimSig_Keyboard_Interface.DataProcess.Signals;
using SimSig_Keyboard_Interface.DataProcess.Track;
using SimSig_Keyboard_Interface.Properties;
using SimSig_Keyboard_Interface.Comms.RS2323;
using System.IO.Ports;
using SimSig_Keyboard_Interface.Comms.RS232;
using SimSig_Keyboard_Interface.Data;

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

		public static SerialPort ComReceiver = new SerialPort();


		public static BerthContainer _berths = new BerthContainer();
		public static PointContainer _points = new PointContainer();
		public static SignalContainer _signals = new SignalContainer();
		public static TrackContainer _tracks = new TrackContainer();
		private static CallContainer _calls = new CallContainer();






		public MainMenu()
		{
			InitializeComponent();

			debugBerthView.DataSource = _berths.BerthList;
			debugPointView.DataSource = _points.PointList;
			debugSignalView.DataSource = _signals.SignalList;
			debugTrackView.DataSource = _tracks.TrackList;
			debugCallView.DataSource = _calls.CallList;


			Connection.DataReceived += TcpDataUpdate;

			callers.Items.Clear();



			callers.DisplayMember = "CallerName";
			callers.ValueMember = "CallNumber";


			callers.DataSource = _calls.CallList;



			callResponses.Items.Clear();

			callMessage.Clear();
		}

		private void MenuLoadSaveXml(object sender, EventArgs e)
		{


			if (loadSaveXML != null)
			{
				loadSaveGameXML.Title = @"Open saved XML save game";
				loadSaveGameXML.Filter = @"XML Files | *xml";


				if (loadSaveGameXML.ShowDialog() == DialogResult.OK)
					Settings.Default.wi = loadSaveGameXML.InitialDirectory + loadSaveGameXML.FileName;
				Data.SaveGameParser.Parse(ref _berths, ref _points, ref _signals,
					ref _tracks); //Parse load with ref to points container

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

					Invoke(new MethodInvoker(delegate
					{
						debugRawTcpDisplay.Items.Insert(0, element);
						if (element.StartsWith("sT")) Console.WriteLine(element);
					}));
					try
					{

						if (element.StartsWith("sB"))
							if (InvokeRequired)
								Invoke(new MethodInvoker(delegate
								{
									_berths.DataUpdateTcp(element.Substring(2, 8));
									Refresh();
								}));
						if (element.StartsWith("sP"))
							if (InvokeRequired)
								Invoke(new MethodInvoker(delegate
								{
									_points.AddPointTcp(element.Substring(2, 7));
									Refresh();
								}));
						if (element.StartsWith("sS"))
							if (InvokeRequired)
								Invoke(new MethodInvoker(delegate
								{
									_signals.AddSignalTcp(element.Substring(2, 13));
									Refresh();
								}));
						if (element.StartsWith("sT"))
							if (InvokeRequired)
								Invoke(new MethodInvoker(delegate
								{
									_tracks.AddTrackTcp(element.Substring(2, 6));
									Refresh();
								}));


						if (element.StartsWith("pM"))
							if (InvokeRequired)
								Invoke(new MethodInvoker(delegate
								{
									_calls.NewIncomingCall(element);
									Refresh();
								}));
						if (element.StartsWith("pO"))
							if (InvokeRequired)
								Invoke(new MethodInvoker(delegate
								{
									_calls.EndIncomingCall(element);
									Refresh();
								}));
					}
					catch
					{
						Console.WriteLine(@"A Unhandled String was Received - " + element);
					}
				}
			}
		}

		private void SerialDataReceived()
		{

		}


		#endregion

		#region Keyboard Interface Controls

		private void KeyboardInterpose_Click(object sender, EventArgs e)
		{
			string[] userInput = userInputString.Text.Split(' ');
			if (userInputString.Text.Contains(' ') == false) return; //Not doing anything if the user has not enterd a space after the berth
			Data.SendPrep.Interpose(userInput[0], userInput[1]);
		}

		private void KeyboardRouteSet_Click(object sender, EventArgs e)
		{
			string[] userInput = userInputString.Text.Split(' ');
			if (userInputString.Text.Contains(' ') == false) return; //Not doing anything if the user has not enterd a space after the berth
			SendPrep.RouteSet(userInput[0], userInput[1]);
		}

		private void KeyboardTdCancel_Click(object sender, EventArgs e)
		{
			string[] userInput = userInputString.Text.Split(' ');
			SendPrep.InterposeCancel(userInput[0]);
		}

		private void KeyboardRouteCancel_Click(object sender, EventArgs e)
		{
			string[] userInput = userInputString.Text.Split(' ');
			SendPrep.RouteCan(userInput[0]);
		}

		private void KeyboardAutoSet_Click(object sender, EventArgs e)
		{
			string[] userInput = userInputString.Text.Split(' ');
			SendPrep.SigAutoSet(userInput[0]);
		}

		private void KeyboardAutoCancel_Click(object sender, EventArgs e)
		{
			string[] userInput = userInputString.Text.Split(' ');
			SendPrep.SigAutoCan(userInput[0]);
		}

		private void KeyboardSignalRemoveReplacement_Click(object sender, EventArgs e)
		{
			string[] userInput = userInputString.Text.Split(' ');
			SendPrep.SigReplacementCan(userInput[0]);
		}

		private void KeyboardSigReplacement_Click(object sender, EventArgs e)
		{
			string[] userInput = userInputString.Text.Split(' ');
			SendPrep.SigReplacementSet(userInput[0]);
		}

		private void KeyboardPointKN_Click(object sender, EventArgs e)
		{
			string[] points = userInputString.Text.Split(' ');
			SendPrep.PointsKeyN(points[0]);
		}

		private void KeyboardPointKR_Click(object sender, EventArgs e)
		{
			string[] points = userInputString.Text.Split(' ');
			SendPrep.PointsKeyR(points[0]);
		}

		private void KeyboardPointF_Click(object sender, EventArgs e)
		{
			string[] points = userInputString.Text.Split(' ');
			SendPrep.PointsKeyF(points[0]);
		}

		#endregion

		#region Misc Menu Items

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Environment.Exit(1);
		}

		private void Point_List_Reset(object sender, EventArgs e)
		{
			_points.PointList.Clear();
		}

		private void BerthListReset(object sender, EventArgs e)
		{
			_berths.BerthList.Clear();
		}

		private void SignalListReset(object sender, EventArgs e)
		{
			_signals.SignalList.Clear();
		}


		private void ConnectToolStripMenuItem_Click(object sender, EventArgs e)
		{

			connectToolStripMenuItem.Enabled = false;
			Thread tcpConnectThread = new Thread(() =>
			{
				TcpConnectForm.ShowDialog();


				Connection.Connect(Settings.Default.ipAddress, Settings.Default.clientPort);

			});
			tcpConnectThread.Start();
		}


		private void MenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void SendToSim_Click(object sender, EventArgs e)
		{
			Connection.SendData(userInputString.Text);
		}


		private void CallRespond_Click(object sender, EventArgs e)
		{
			string x = callResponses.SelectedIndex.ToString();

			//"pN" + callid[0] + '\\' + callResponses.SelectedIndex;

			string callId = _calls.CallList.Single(c => c.CallNumber == callers.SelectedValue.ToString()).CallNumber;

			Connection.SendData("pN" + callId + '\\' + x + "|");

			callResponses.Items.Clear();
			callMessage.Clear();
			Refresh();
		}

		private void Callers_SelectedIndexChanged_1(object sender, EventArgs e)
		{

			callResponses.Items.Clear();
			try
			{
				string[] x = _calls.CallList.Single(c => c.CallNumber == callers.SelectedValue.ToString()).CallResponses;

				foreach (var i in x)
					if (i != null)
						callResponses.Items.Add(i.Substring(8).TrimEnd('\\'));

				callMessage.Text = _calls.CallList.Single(c => c.CallNumber == callers.SelectedValue.ToString()).CallerMessage;
			}
			catch
			{
				callResponses.Items.Clear();
			}


		}


		#endregion

		private void ConnectToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			connectToolStripMenuItem.Enabled = false;
			Thread serialReceiver = new Thread(() =>
			{

				Rs232Main.Rs232Receiver();

			});
			serialReceiver.Start();
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
