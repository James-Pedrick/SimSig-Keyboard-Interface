using System;
using System.Threading;
using System.Windows.Forms;
using SimSig_Keyboard_Interface.Comms.RS232;
using SimSig_Keyboard_Interface.Comms.TCP;
using SimSig_Keyboard_Interface.Data;
using SimSig_Keyboard_Interface.DataProcess.Berths;
using SimSig_Keyboard_Interface.DataProcess.Calls;
using SimSig_Keyboard_Interface.DataProcess.Flags;
using SimSig_Keyboard_Interface.DataProcess.GroundFrames;
using SimSig_Keyboard_Interface.DataProcess.Points;
using SimSig_Keyboard_Interface.DataProcess.Signals;
using SimSig_Keyboard_Interface.DataProcess.Slots;
using SimSig_Keyboard_Interface.DataProcess.Track;
using SimSig_Keyboard_Interface.Properties;
using SimSig_Keyboard_Interface.User_Interface.Connetions;
using SimSig_Keyboard_Interface.User_Interface.UserControls;

// ************************************************************** Load Points config file ^^^



namespace SimSig_Keyboard_Interface.User_Interface.MainDisplays
{
	public partial class MainMenu : Form
	{



		/*************************/
		/*Creating containers    */
		/*************************/
		public static TcpClient TcpConnection = new TcpClient();
		public static SerialClient ComConnection = new SerialClient();
		public static FlagContainer Flags = new FlagContainer();
		public static FrameContainer Frames = new FrameContainer();

		public static TcpConnect TcpConnectForm = new TcpConnect();
		public static ComConnect ComConnectForm = new ComConnect();


		public static BerthContainer Berths = new BerthContainer();
		public static PointContainer Points = new PointContainer();
		public static SignalContainer Signals = new SignalContainer();
		public static SlotContainer Slots = new SlotContainer();
		public static TrackContainer Tracks = new TrackContainer();
		public static readonly CallContainer Calls = new CallContainer();

		public static DebugUc Debug = new DebugUc();
		public static KeyboardInterfaceUc Keyboard = new KeyboardInterfaceUc();


		/*******************************/
		/* Creating Events             */
		/*******************************/

		public static event EventHandler<MsgEventArgs> DebugComDataReceived;
		public static event EventHandler<MsgEventArgs> DebugTcpDataReceived;
		public static event EventHandler<MsgEventArgs> KeyboardTcpDataReceived;
		public static event EventHandler<MsgEventArgs> BerthWatch;



		public static bool TcpConnected = false;
		public static bool SerialConnected = false;

		public MainMenu()
		{
			InitializeComponent();

			TcpConnection.DataReceived += TcpDataUpdate;
			ComConnection.DataReceived += ComDataUpdate;




		}


		private void MenuLoadSaveXml(object sender, EventArgs e)
		{


			if (loadSaveXML != null)
			{
				loadSaveGameXML.Title = @"Open saved XML save game";
				loadSaveGameXML.Filter = @"XML Files | *xml";


				if (loadSaveGameXML.ShowDialog() == DialogResult.OK)
					Settings.Default.wi = loadSaveGameXML.InitialDirectory + loadSaveGameXML.FileName;
				SaveGameParser.Parse(ref Berths, ref Points, ref Signals,
					ref Tracks, ref Slots, ref Frames, ref Flags); //Parse load with ref to points container

			}
			Refresh();

		}
		private void ComDataUpdate(object sender, MsgEventArgs e)
		{
			string element = e.Msg;
			if (element != null && InvokeRequired)
				try
				{
					{
						MsgEventArgs m = new MsgEventArgs() { Msg = element };
						var handler = DebugComDataReceived;
						if (handler != null) DebugComDataReceived?.Invoke(this, m);
					}
				}
				catch
				{
					Console.WriteLine(@"A Unhandled String was Received - " + element);
				}

		}


		private void TcpDataUpdate(object sender, MsgEventArgs e)
		{
			string element = e.Msg;
			if (element != null && InvokeRequired)
				try
				{
					{
						MsgEventArgs m = new MsgEventArgs() { Msg = element };

						var handler = DebugTcpDataReceived;
						if (handler != null) DebugTcpDataReceived?.Invoke(this, m);
					}

					if (element.StartsWith("pM"))
					{
						if (InvokeRequired)
							Invoke(new MethodInvoker(delegate
							{
								Calls.NewIncomingCall(element);
								Refresh();
							}));
					} //New Phone Call
					if (element.StartsWith("pO"))
					{
						if (InvokeRequired)
							Invoke(new MethodInvoker(delegate
							{
								Calls.EndIncomingCall(element);
								Refresh();
							}));
					} //End Phone Call

					if (element.StartsWith("sB"))
					{
						if (InvokeRequired)
							Invoke(new MethodInvoker(delegate
							{
								Berths.DataUpdateTcp(element.Substring(2, 8));
								Refresh();
							}));
					}
					if (element.StartsWith("sL"))
					{
						if (InvokeRequired)
							Invoke(new MethodInvoker(delegate
							{
								Flags.AddFlagTcp(element.Substring(2));
								Refresh();
							}));
					}
					if (element.StartsWith("sP"))
					{
						if (InvokeRequired)
							Invoke(new MethodInvoker(delegate
							{
								Points.AddPointTcp(element.Substring(2, 7));
								Refresh();
							}));
					}
					if (element.StartsWith("sS"))
					{
						if (InvokeRequired)
							Invoke(new MethodInvoker(delegate
							{
								Signals.AddSignalTcp(element.Substring(2, 13));
								Refresh();
							}));
					}
					if (element.StartsWith("sT"))
					{
						if (InvokeRequired)
							Invoke(new MethodInvoker(delegate
							{
								Tracks.AddTrackTcp(element.Substring(2, 6));
								Refresh();
							}));
					}

					if (element.StartsWith("tE") || element.StartsWith("tL") || element.StartsWith("tM"))
					{
						MsgEventArgs m = new MsgEventArgs() { Msg = element };

						var handler = KeyboardTcpDataReceived;
						if (handler != null) KeyboardTcpDataReceived?.Invoke(this, m);
					}
					if (element.StartsWith("zA"))
					{
						MsgEventArgs m = new MsgEventArgs() { Msg = element };

						var handler = KeyboardTcpDataReceived;
						if (handler != null) KeyboardTcpDataReceived?.Invoke(this, m);

						handler = BerthWatch;
						if (handler != null) BerthWatch?.Invoke(this, m);




					}

					if (element.StartsWith("iCB"))
					{
						if (InvokeRequired)
							Invoke(new MethodInvoker(delegate
							{
								Berths.AddBerthTcp(element.Substring(7, 4), element.Substring(11, 4));
								Refresh();
							}));
					} //Berth Request State Feedback
					if (element.StartsWith("iCP"))
					{
						if (InvokeRequired)
							Invoke(new MethodInvoker(delegate
							{
								Points.AddPointTcp(element.Substring(7));
								Refresh();
							}));
					} //Point Request State Feedback
					if (element.StartsWith("iCS"))
					{
						if (InvokeRequired)
							Invoke(new MethodInvoker(delegate
							{
								Signals.AddSignalTcp(element.Substring(7));
								Refresh();
							}));
					} //Signal Request State Feedback

					if (element.Contains("<platformDataResponse"))
					{
						MsgEventArgs m = new MsgEventArgs() { Msg = element };

						var handler = KeyboardTcpDataReceived;
						if (handler != null) KeyboardTcpDataReceived?.Invoke(this, m);
					}



				}
				catch
				{
					Console.WriteLine(@"A Unhandled String was Received - " + element);
				}
		}




		#region Misc Menu Items

		private void ProgramExit(object sender, EventArgs e)
		{
			Environment.Exit(1);
		}
		private void Point_List_Reset(object sender, EventArgs e)
		{
			Points.PointList.Clear();
		}
		private void SignalListReset(object sender, EventArgs e)
		{
			Signals.SignalList.Clear();
		}
		private void ConnectToolStripMenuItem_Click(object sender, EventArgs e)
		{

			connectToolStripMenuItem.Enabled = false;
			Thread tcpConnectThread = new Thread(() =>
				{
					TcpConnectForm.ShowDialog();
					TcpConnection.Connect(Settings.Default.ipAddress, Settings.Default.clientPort);
				}
			);
			tcpConnectThread.Start();
			disconnectToolStripMenuItem.Enabled = true;
			TcpConnected = true;
		}
		private void DisconnectToolStripMenuItem_Click(object sender, EventArgs e)
		{

			connectToolStripMenuItem.Enabled = true;
			TcpConnection.Disconnect();
			disconnectToolStripMenuItem.Enabled = false;
			TcpConnected = false;

		}



		#endregion

		private void ConnectToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			connectToolStripMenuItem1.Enabled = false;
			Thread serialReceiver = new Thread(() =>
			{
				ComConnectForm.ShowDialog();
				ComConnection.Connect();

			});
			serialReceiver.Start();
			disconnectToolStripMenuItem1.Enabled = true;
			SerialConnected = true;
		}

		private void DisconnectToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			connectToolStripMenuItem1.Enabled = true;
			ComConnection.Disconnect();
			disconnectToolStripMenuItem1.Enabled = false;
			SerialConnected = false;
		}

		private void BerthListReset(object sender, EventArgs e)
		{
			Berths.BerthList.Clear();
		}

		private void SignalListResetToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Signals.SignalList.Clear();
		}

		private void PointListRest(object sender, EventArgs e)
		{
			Points.PointList.Clear();

		}

		private void RequestDataToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Berths.BerthStatusRequest();
			Points.PointStatusConnectionRequest();
			Signals.SignalStatusRequest();
		}

		private void MainMenu_NewPhone(object sender, EventArgs e)
		{
			var additionalPhone = new Thread(() =>
			{
				IndependentPhoneDisplay phoneDisplayExternal = new IndependentPhoneDisplay();
				if (InvokeRequired)
					Invoke(new MethodInvoker(delegate
					{
						phoneDisplayExternal.Show();
					}));
			});
			additionalPhone.Start();
		}

		private void MainMenu_NewKeyboard(object sender, EventArgs e)
		{

			var additionalKeyboard = new Thread(() =>
			{
				IndependentKeyboardInterface keyboardInterfaceExternal = new IndependentKeyboardInterface();

				if (InvokeRequired)
					Invoke(new MethodInvoker(delegate
					{
						keyboardInterfaceExternal.Show();
					}));
			});
			additionalKeyboard.Start();


		}


	}
}


