﻿using System;
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

            string element = e.Msg;

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

		private void SerialDataReceived()
		{

		}



		#region Keyboard Interface Controls

		private void UserInputString_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F1) keyboardSpecFunction.Text = @"REM";
			if (e.KeyCode == Keys.F2) keyboardSpecFunction.Text = @"ISO";
			if (e.KeyCode == Keys.F3) keyboardSpecFunction.Text = @"OVR";



			if (e.KeyCode == Keys.F11)      //Interpose
			{
				if (userInputString.Text.Contains(' ') == false) return;

				DataProcess.KeyboardInterface.TdInterpose(userInputString.Text);

				userInputString.Text = "";
				keyboardSpecFunction.Text = "";
			}

			if (e.KeyCode == Keys.F12)      //Set
			{
				if (userInputString.Text.StartsWith("A") && keyboardSpecFunction.Text == "")
				{
					string[] z = userInputString.Text.Split(' ');
					DataProcess.KeyboardInterface.SignalAutoSet(z[0].Substring(1));
				}               //Auto Set
				if (userInputString.Text.StartsWith("A") && keyboardSpecFunction.Text == @"REM")
				{
					string[] z = userInputString.Text.Split(' ');
					DataProcess.KeyboardInterface.SignalAutoReminderSet(z[0].Substring(1));
				}           //Auto Reminder Set
				if (userInputString.Text.StartsWith("A") && keyboardSpecFunction.Text == @"ISO")
				{
					string[] z = userInputString.Text.Split(' ');
					DataProcess.KeyboardInterface.SignalAutoIsolationSet(z[0].Substring(1));
				}           //Auto Reminder Set


				if (userInputString.Text.StartsWith("E") && keyboardSpecFunction.Text == "")
				{
					string[] z = userInputString.Text.Split(' ');
					DataProcess.KeyboardInterface.SignalReplacementSet(z[0].Substring(1));
				}               //Signal Replacement Set

				if (userInputString.Text.StartsWith("E") && keyboardSpecFunction.Text == @"REM")
				{
					string[] z = userInputString.Text.Split(' ');
					DataProcess.KeyboardInterface.SignalReplacementReminderSet(z[0].Substring(1));
				}           //Signal Replacement Reminder Set
				if (userInputString.Text.StartsWith("E") && keyboardSpecFunction.Text == @"ISO")
				{
					string[] z = userInputString.Text.Split(' ');
					DataProcess.KeyboardInterface.SignalReplacementIsolationSet(z[0].Substring(1));
				}           //Signal Replacement Isolation Set

				if (userInputString.Text.StartsWith("S") && keyboardSpecFunction.Text == @"")
				{
					if (userInputString.Text.Contains(' ') == false) return;

					string[] z = userInputString.Text.Split(' ');

					DataProcess.KeyboardInterface.RouteSet(z[0].Substring(1), z[1].Substring(1), "");
				}           //Route Set (No OverRide)
				if (userInputString.Text.StartsWith("S") && keyboardSpecFunction.Text == @"OVR")
				{
					if (userInputString.Text.Contains(' ') == false) return;

					string[] z = userInputString.Text.Split(' ');

					DataProcess.KeyboardInterface.RouteSet(z[0].Substring(1), z[1].Substring(1), @"OVR");
				}           //Route Set (With OverRide)
				if (userInputString.Text.StartsWith("S") && keyboardSpecFunction.Text == @"REM")
				{
					string[] z = userInputString.Text.Split(' ');

					DataProcess.KeyboardInterface.SignalReminderSet(z[0].Substring(1));
				}           //Signal Reminder Set
				if (userInputString.Text.StartsWith("S") && keyboardSpecFunction.Text == @"ISO")
				{
					string[] z = userInputString.Text.Split(' ');

					DataProcess.KeyboardInterface.SignalIsolationSet(z[0].Substring(1));
				}           //Signal Reminder Set

				if (userInputString.Text.StartsWith("P") && keyboardSpecFunction.Text == @"REM")
				{

					string[] z = userInputString.Text.Split(' ');

					DataProcess.KeyboardInterface.PointReminderApply(z[0].Substring(1));
				}           //PointReminderApply


				userInputString.Text = "";
				keyboardSpecFunction.Text = "";
			}


			if (e.KeyCode == Keys.Delete)   //CAN
			{


				if (userInputString.Text.StartsWith("A") && keyboardSpecFunction.Text == "")
				{
					string[] z = userInputString.Text.Split(' ');
					DataProcess.KeyboardInterface.SignalAutoCancel(z[0].Substring(1));
				}           //Auto Cancel
				if (userInputString.Text.StartsWith("A") && keyboardSpecFunction.Text == @"REM")
				{
					string[] z = userInputString.Text.Split(' ');
					DataProcess.KeyboardInterface.SignalAutoReminderCancel(z[0].Substring(1));
				}       //Auto Reminder Set
				if (userInputString.Text.StartsWith("A") && keyboardSpecFunction.Text == @"ISO")
				{
					string[] z = userInputString.Text.Split(' ');
					DataProcess.KeyboardInterface.SignalAutoIsolationCancel(z[0].Substring(1));
				}       //Auto Reminder Set

				if (userInputString.Text.StartsWith("B"))
				{
					DataProcess.KeyboardInterface.TdCancel(userInputString.Text);
				}                                           //TD Cancel

				if (userInputString.Text.StartsWith("E") && keyboardSpecFunction.Text == "")
				{
					string[] z = userInputString.Text.Split(' ');
					DataProcess.KeyboardInterface.SignalReplacementcancel(z[0].Substring(1));
				}           //Replacement Cancel
				if (userInputString.Text.StartsWith("E") && keyboardSpecFunction.Text == @"REM")
				{
					string[] z = userInputString.Text.Split(' ');
					DataProcess.KeyboardInterface.SignalReplacementReminderCancel(z[0].Substring(1));
				}       //Reminder Cancel
				if (userInputString.Text.StartsWith("E") && keyboardSpecFunction.Text == @"ISO")
				{
					string[] z = userInputString.Text.Split(' ');
					DataProcess.KeyboardInterface.SignalReplacementIsolationCancel(z[0].Substring(1));
				}       //Isolation Cancel

				if (userInputString.Text.StartsWith("S") && keyboardSpecFunction.Text == "")
				{
					DataProcess.KeyboardInterface.RouteCancel(userInputString.Text.Substring(1));
				}           //Route Cancel
				if (userInputString.Text.StartsWith("S") && keyboardSpecFunction.Text == @"REM")
				{
					string[] z = userInputString.Text.Split(' ');

					DataProcess.KeyboardInterface.SignalReminderCancel(z[0].Substring(1));
				}       //Signal Reminder Set
				if (userInputString.Text.StartsWith("S") && keyboardSpecFunction.Text == @"ISO")
				{
					string[] z = userInputString.Text.Split(' ');

					DataProcess.KeyboardInterface.SignalIsolationCancel(z[0].Substring(1));
				}

				if (userInputString.Text.StartsWith("P") && keyboardSpecFunction.Text == @"REM")
				{

					string[] z = userInputString.Text.Split(' ');

					DataProcess.KeyboardInterface.PointReminderCancel(z[0].Substring(1));
				}           //PointReminderCancel

				userInputString.Text = "";
				keyboardSpecFunction.Text = "";
			}




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


