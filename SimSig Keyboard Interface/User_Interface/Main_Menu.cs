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
using System.Runtime.CompilerServices;
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


			callMsg.Text = "";
			callResponses.Items.Clear();

		}

		private void MenuLoadSaveXml(object sender, EventArgs e)
		{


			if (loadSaveXML != null)
			{
				loadSaveGameXML.Title = @"Open saved XML save game";
				loadSaveGameXML.Filter = @"XML Files | *xml";


				if (loadSaveGameXML.ShowDialog() == DialogResult.OK)
					Settings.Default.wi = loadSaveGameXML.InitialDirectory + loadSaveGameXML.FileName;
				SaveGameParser.Parse(ref _berths, ref _points, ref _signals,
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

		private void UserInputString_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F1)   //Interpose
			{
				DataProcess.KeyboardInterface.KeyboardTdInt(userInputString.Text);
				userInputString.Text = "";
			}
			if (e.KeyCode == Keys.F2)   //Cancel
			{
				DataProcess.KeyboardInterface.KeyboardTdCan(userInputString.Text);
				userInputString.Text = "";
			}
			if (e.KeyCode == Keys.F3)   //Route Set
			{
				DataProcess.KeyboardInterface.KeyboardRouSet(userInputString.Text);
				userInputString.Text = "";
			}
			if (e.KeyCode == Keys.F4)   //Route Cancel
			{
				DataProcess.KeyboardInterface.KeyboardRouCan(userInputString.Text);
				userInputString.Text = "";
			}
			if (e.KeyCode == Keys.F5)   //Signal Auto Set
			{
				DataProcess.KeyboardInterface.KeyboardAutSet(userInputString.Text);
				userInputString.Text = "";
			}
			if (e.KeyCode == Keys.F6)
			{
				DataProcess.KeyboardInterface.KeyboardAutCan(userInputString.Text);
				userInputString.Text = "";
			}           //Signal Auto Cancel
			if (e.KeyCode == Keys.F7)
			{
				DataProcess.KeyboardInterface.KeyboardRepSet(userInputString.Text);
				userInputString.Text = "";
			}           //Signal Replacement Set
			if (e.KeyCode == Keys.F8)
			{
				DataProcess.KeyboardInterface.KeyboardRepCan(userInputString.Text);
				userInputString.Text = "";
			}           //Signal Replacement 
			if (e.KeyCode == Keys.F9)
			{

				DataProcess.KeyboardInterface.KeyboardPointNorm(userInputString.Text);
				userInputString.Text = "";
			}           //Key Point Normal
			if (e.KeyCode == Keys.F10)
			{
				DataProcess.KeyboardInterface.KeyboardPointFree(userInputString.Text);
				userInputString.Text = "";
			}           //Free Point
			if (e.KeyCode == Keys.F11)
			{
				DataProcess.KeyboardInterface.KeyboardPointRev(userInputString.Text);
				userInputString.Text = "";
			}           //Key Point Free
			if (e.KeyCode == Keys.F12)
			{
				Connection.SendData(userInputString.Text);  //Send direct to Sim
			}           //Send direct to simulation.

			if (e.KeyCode == Keys.Enter)
			{
				string[] combo = userInputString.Text.Split(' ');
				var x = combo.Length;

				int y = 1;

				while (y != x)
				{
					DataProcess.KeyboardInterface.KeyboardRouSet(combo[y - 1] + ' ' + combo[y]);
					y++;
				}
				

			}


			Console.WriteLine(e.KeyCode);

		}

		private void KeyboardInterpose_Click(object sender, EventArgs e)
		{
			DataProcess.KeyboardInterface.KeyboardTdInt(userInputString.Text);
			userInputString.Text = "";
		}
		private void KeyboardTdCancel_Click(object sender, EventArgs e)
		{
			DataProcess.KeyboardInterface.KeyboardTdCan(userInputString.Text);
			userInputString.Text = "";
		}
		private void KeyboardRouteSet_Click(object sender, EventArgs e)
		{
			DataProcess.KeyboardInterface.KeyboardRouSet(userInputString.Text);
			userInputString.Text = "";
		}
		private void KeyboardRouteCancel_Click(object sender, EventArgs e)
		{
			DataProcess.KeyboardInterface.KeyboardRouCan(userInputString.Text);
			userInputString.Text = "";
		}
		private void KeyboardAutoSet_Click(object sender, EventArgs e)
		{
			DataProcess.KeyboardInterface.KeyboardAutSet(userInputString.Text);
			userInputString.Text = "";
		}
		private void KeyboardAutoCancel_Click(object sender, EventArgs e)
		{
			DataProcess.KeyboardInterface.KeyboardAutCan(userInputString.Text);
			userInputString.Text = "";
		}
		private void KeyboardSigRemoveReplacement_Click(object sender, EventArgs e)
		{
			DataProcess.KeyboardInterface.KeyboardAutCan(userInputString.Text);
			userInputString.Text = "";
		}
		private void KeyboardSigReplacement_Click(object sender, EventArgs e)
		{
			DataProcess.KeyboardInterface.KeyboardRepSet(userInputString.Text);
			userInputString.Text = "";
		}
		private void KeyboardPointKN_Click(object sender, EventArgs e)
		{
			DataProcess.KeyboardInterface.KeyboardPointNorm(userInputString.Text);
			userInputString.Text = "";
		}
		private void KeyboardPointKR_Click(object sender, EventArgs e)
		{
			DataProcess.KeyboardInterface.KeyboardPointRev(userInputString.Text);
			userInputString.Text = "";
		}
		private void KeyboardPointF_Click(object sender, EventArgs e)
		{
			DataProcess.KeyboardInterface.KeyboardPointFree(userInputString.Text);
			userInputString.Text = "";
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


				callMsg.Text = _calls.CallList.Single(c => c.CallNumber == callers.SelectedValue.ToString()).CallerMessage;

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

		private void phoneCalls_Click(object sender, EventArgs e)
		{

		}

		private void callResponses_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void debugBerthView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void fileToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void dataToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void tcpToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void tcpConnect_Click(object sender, EventArgs e)
		{

		}

		private void networkToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void clientToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void serialToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void dataToolStripMenuItem1_Click(object sender, EventArgs e)
		{

		}

		private void logsToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void savePointsToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void saveSignalsToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void saveBerthsToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void saveRawToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void debug_Click(object sender, EventArgs e)
		{

		}

		private void debugTabs_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void debugBerths_Click(object sender, EventArgs e)
		{

		}

		private void debugBerthView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void debugCalls_Click(object sender, EventArgs e)
		{

		}

		private void debugCallView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void debugPoints_Click(object sender, EventArgs e)
		{

		}

		private void debugPointView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void debugSignals_Click(object sender, EventArgs e)
		{

		}

		private void debugSignalView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void debugTracks_Click(object sender, EventArgs e)
		{

		}

		private void debugTrackView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void debugTcpRaw_Click(object sender, EventArgs e)
		{

		}

		private void debugRawTcpDisplay_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void keyboardInterface_Click(object sender, EventArgs e)
		{

		}

		private void userInputString_TextChanged(object sender, EventArgs e)
		{

		}

		private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
		{

		}

		private void splitContainer4_SplitterMoved(object sender, SplitterEventArgs e)
		{

		}

		private void splitContainer3_SplitterMoved(object sender, SplitterEventArgs e)
		{

		}

		private void callMsg_Click(object sender, EventArgs e)
		{

		}

		private void loadSaveGameXML_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{

		}

		private void dataSave_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{

		}

		private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
		{

		}

		private void callResponses_SelectedIndexChanged_1(object sender, EventArgs e)
		{

		}

		private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
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
