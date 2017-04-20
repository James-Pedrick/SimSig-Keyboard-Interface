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

		#endregion

		#region Keyboard Interface Controls

		private void KeyboardInterpose_Click(object sender, EventArgs e)
		{
			string[] userInput = userInputString.Text.Split(' ');

			if (userInputString.Text.Contains(' ') == false)
				return; //Not doing anything if the user has not enterd a space after the berth


			var berthHex = _berths.BerthHIdLookup(userInput[0]);

			Connection.SendData(@"BB" + berthHex + userInput[1] + "----|");

		}

		private void KeyboardRouteSet_Click(object sender, EventArgs e)
		{

			string[] userInput = userInputString.Text.Split(' ');

			if (userInputString.Text.Contains(' ') == false)
				return; //Not doing anything if the user has not enterd a space after the berth


			var entrySigHex = _signals.SignalIdLookup(userInput[0]);
			var exitSigHex = _signals.SignalIdLookup(userInput[1]);

			Connection.SendData(@"SA" + entrySigHex + exitSigHex + @"00" + entrySigHex + @"----|");
		}

		private void KeyboardTdCancel_Click(object sender, EventArgs e)
		{
			string[] userInput = userInputString.Text.Split(' ');

			var berthHex = _berths.BerthHIdLookup(userInput[0]);

			Connection.SendData(@"BC" + berthHex + "|");

		}

		private void KeyboardRouteCancel_Click(object sender, EventArgs e)
		{
			string[] userInput = userInputString.Text.Split(' ');

			var entrySigHex = _signals.SignalIdLookup(userInput[0]);
			Connection.SendData(@"zD" + entrySigHex + "|");

		}

		private void KeyboardAutoSet_Click(object sender, EventArgs e)
		{
			string[] userInput = userInputString.Text.Split(' ');

			var entrySigHex = _signals.SignalIdLookup(userInput[0]);
			Connection.SendData(@"SF" + entrySigHex + "|");

		}

		private void KeyboardAutoCancel_Click(object sender, EventArgs e)
		{
			string[] userInput = userInputString.Text.Split(' ');

			var entrySigHex = _signals.SignalIdLookup(userInput[0]);
			Connection.SendData(@"SG" + entrySigHex + "|");


		}

		private void KeyboardSignalRemoveReplacement_Click(object sender, EventArgs e)
		{
			string[] userInput = userInputString.Text.Split(' ');

			var entrySigHex = _signals.SignalIdLookup(userInput[0]);
			Connection.SendData(@"SP" + entrySigHex + "|");


		}

		private void KeyboardSigReplacement_Click(object sender, EventArgs e)
		{

			string[] userInput = userInputString.Text.Split(' ');

			var entrySigHex = _signals.SignalIdLookup(userInput[0]);
			Connection.SendData(@"SQ" + entrySigHex + "|");

		}

		private void KeyboardPointKN_Click(object sender, EventArgs e)
		{


			Thread keyPointsNormal = new Thread(() =>
				{
					string[] points = userInputString.Text.Split(' ');

					string pointId = _points.PointLookup(points[0]);
					if (pointId == null) return;




					if (_points.PointList.SingleOrDefault(p => p.HexId == pointId) == null) return;

					//(PointList.SingleOrDefault(b => b.Number == data) != null

					while (_points.PointsKn(pointId) == false)
					{
						while (_points.PointUpdated(pointId) == false)
							Thread.Sleep(10);
						Thread.Sleep(10);
						if (_points.PointsKn(pointId))
							return;

						if (_points.PointsKn(pointId) == false && _points.PointUpdated(pointId))
						{
							Connection.SendData(@"PB" + pointId + @"|");

							_points.PointList.Single(b => b.HexId == pointId).Updated = false;
						}
					}
				}
			);
			keyPointsNormal.Start();
		}

		private void KeyboardPointKR_Click(object sender, EventArgs e)
		{


			Thread keyPointsReverse = new Thread(() =>
				{
					string[] points = userInputString.Text.Split(' ');

					string pointId = _points.PointLookup(points[0]);
					if (pointId == null) return;




					if (_points.PointList.SingleOrDefault(p => p.HexId == pointId) == null) return;

					//(PointList.SingleOrDefault(b => b.Number == data) != null

					while (_points.PointsKr(pointId) == false)
					{
						while (_points.PointUpdated(pointId) == false)
							Thread.Sleep(10);
						Thread.Sleep(10);
						if (_points.PointsKr(pointId))
							return;

						if (_points.PointsKr(pointId) == false && _points.PointUpdated(pointId))
						{
							Connection.SendData(@"PC" + pointId + @"|");

							_points.PointList.Single(b => b.HexId == pointId).Updated = false;
						}
					}
				}
			);
			keyPointsReverse.Start();
		}

		private void KeyboardPointF_Click(object sender, EventArgs e)
		{
			Thread keyPointsFree = new Thread(() =>
				{
					string[] points = userInputString.Text.Split(' ');

					string pointId = _points.PointLookup(points[0]);
					if (pointId == null) return;




					if (_points.PointList.SingleOrDefault(p => p.HexId == pointId) == null) return;

					//(PointList.SingleOrDefault(b => b.Number == data) != null

					while (_points.PointsKn(pointId) || _points.PointsKr(pointId))
					{
						while (_points.PointUpdated(pointId) == false)
							Thread.Sleep(10);
						Thread.Sleep(10);
						if (_points.PointsKn(pointId) == false && _points.PointsKr(pointId) == false)
							return;

						if ((_points.PointsKn(pointId) || _points.PointsKr(pointId)) &&
							_points.PointUpdated(pointId))
						{
							Connection.SendData(@"PB" + pointId + @"|");

							_points.PointList.Single(b => b.HexId == pointId).Updated = false;
						}
					}
				}
			);
			keyPointsFree.Start();
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
