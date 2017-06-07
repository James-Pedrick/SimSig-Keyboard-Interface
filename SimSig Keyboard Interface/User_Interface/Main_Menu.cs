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
						{
							if (InvokeRequired)
								Invoke(new MethodInvoker(delegate
								{
									_berths.DataUpdateTcp(element.Substring(2, 8));
									Refresh();
								}));
						}
						if (element.StartsWith("sP"))
						{
							if (InvokeRequired)
								Invoke(new MethodInvoker(delegate
								{
									_points.AddPointTcp(element.Substring(2, 7));
									Refresh();
								}));
						}

						if (element.StartsWith("sS"))
						{
							if (InvokeRequired)
								Invoke(new MethodInvoker(delegate
								{
									_signals.AddSignalTcp(element.Substring(2, 13));
									Refresh();
								}));
						}
						if (element.StartsWith("sT"))
						{
							if (InvokeRequired)
								Invoke(new MethodInvoker(delegate
								{
									_tracks.AddTrackTcp(element.Substring(2, 6));
									Refresh();
								}));
						}
						if (element.StartsWith("pM"))
						{
							if (InvokeRequired)
								Invoke(new MethodInvoker(delegate
								{
									_calls.NewIncomingCall(element);
									Refresh();
								}));
						}//New Phone Call
						if (element.StartsWith("pO"))
						{
							if (InvokeRequired)
								Invoke(new MethodInvoker(delegate
								{
									_calls.EndIncomingCall(element);
									Refresh();
								}));
						}//End Phone Call

						if (element.StartsWith("iCB"))
						{
							if (InvokeRequired)
								Invoke(new MethodInvoker(delegate
								{
									_berths.AddBerthTcp(element.Substring(7, 4), element.Substring(11, 4));
									Refresh();
								}));
						}//Berth Request State Feedback
						if (element.StartsWith("iCP"))
						{
							if (InvokeRequired)
								Invoke(new MethodInvoker(delegate
								{
									_points.AddPointTcp(element.Substring(7));
									Refresh();
								}));
						}//Point Request State Feedback
						if (element.StartsWith("iCS"))
						{
							if (InvokeRequired)
								Invoke(new MethodInvoker(delegate
								{
									_signals.AddSignalTcp(element.Substring(7));
									Refresh();
								}));
						}//Signal Request State Feedback
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



		#region Keyboard Interface Controls

		private void UserInputString_KeyDown(object sender, KeyEventArgs e)
		{


			if (e.KeyCode == Keys.F1) { DataProcess.KeyboardInterface.KeyboardTdInt(userInputString.Text); userInputString.Text = ""; return; }

			if (e.KeyCode == Keys.F2)
			{
				if (userInputString.Text.StartsWith("A")) { DataProcess.KeyboardInterface.KeyboardAutSet(userInputString.Text.Substring(1)); userInputString.Text = ""; return; }
				if (userInputString.Text.StartsWith("R")) { DataProcess.KeyboardInterface.KeyboardRepSet(userInputString.Text.Substring(1)); userInputString.Text = ""; return; }
				if (userInputString.Text.StartsWith("S"))
				{
					if (userInputString.Text.Contains(' '))
					{
						string[] z = userInputString.Text.Split(' ');
						DataProcess.KeyboardInterface.KeyboardRouSet(z[0].Substring(1), z[1].Substring(1));
					}
					userInputString.Text = "";
					return;
				}
			}
			if (e.KeyCode == Keys.Delete)
			{
				if (userInputString.Text.StartsWith("A")) { DataProcess.KeyboardInterface.KeyboardAutCan(userInputString.Text.Substring(1)); userInputString.Text = ""; return; }
				if (userInputString.Text.StartsWith("B")) { DataProcess.KeyboardInterface.KeyboardTdCan(userInputString.Text); userInputString.Text = ""; return; }
				if (userInputString.Text.StartsWith("R")) { DataProcess.KeyboardInterface.KeyboardRepCan(userInputString.Text.Substring(1)); userInputString.Text = ""; return; }
				if (userInputString.Text.StartsWith("S")) { DataProcess.KeyboardInterface.KeyboardRouCan(userInputString.Text.Substring(1)); userInputString.Text = ""; return; }
			}


			if (e.KeyCode == Keys.F5) { DataProcess.KeyboardInterface.KeyboardPointNorm(userInputString.Text.Substring(1)); userInputString.Text = ""; return; }           //Key Point Normal
			if (e.KeyCode == Keys.F6) { DataProcess.KeyboardInterface.KeyboardPointFree(userInputString.Text.Substring(1)); userInputString.Text = ""; return; }           //Free Point
			if (e.KeyCode == Keys.F7) { DataProcess.KeyboardInterface.KeyboardPointRev(userInputString.Text.Substring(1)); userInputString.Text = ""; return; }           //Key Point Free
			if (e.KeyCode == Keys.F9) { Connection.SendData(userInputString.Text); userInputString.Text = ""; return; }           //Send direct to simulation.

			if (e.KeyCode == Keys.F11)
			{
				string[] combo = userInputString.Text.Split(' ');
				foreach (var x in combo)
				{
					var y = x.Substring(1);
					DataProcess.KeyboardInterface.KeyboardRouCan(y);
				}

				userInputString.Text = "";
			}

			if (e.KeyCode == Keys.F12)
			{
				string[] combo = userInputString.Text.Split(' ');
				var x = combo.Length;

				int y = 1;

				while (y != x)
				{
					DataProcess.KeyboardInterface.KeyboardRouSet(combo[y - 1].Substring(1), combo[y].Substring(1));
					y++;
				}

				userInputString.Text = "";


			}
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

			if (userInputString.Text.Contains(' '))
			{
				string[] z = userInputString.Text.Split(' ');
				DataProcess.KeyboardInterface.KeyboardRouSet(z[0], z[1]);
			}
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
				}
			);
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





		private void berthListResetToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_berths.BerthList.Clear();

		}

		private void signalListResetToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_signals.SignalList.Clear();

		}

		private void pointsListResetToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_points.PointList.Clear();

		}

		private void requestDataToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			_berths.BerthStatusRequest();
			_points.PointStatusRequest();
			_signals.SignalStatusRequest();
		}

		private void MainMenu_Load(object sender, EventArgs e)
		{

		}
	}
}


