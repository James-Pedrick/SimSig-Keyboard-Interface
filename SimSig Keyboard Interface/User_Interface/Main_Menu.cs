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
using System.IO.Ports;
using SimSig_Keyboard_Interface.Comms.RS232;
using SimSig_Keyboard_Interface.Data;
using System.Text.RegularExpressions;
using SimSig_Keyboard_Interface.DataProcess.Flags;
using SimSig_Keyboard_Interface.DataProcess.GroundFrames;
using SimSig_Keyboard_Interface.DataProcess.Slots;


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
		public static FlagContainer _flags = new FlagContainer();
		public static FrameContainer _frames = new FrameContainer();
		public static PointContainer _points = new PointContainer();
		public static SignalContainer _signals = new SignalContainer();
		public static SlotContainer _slots = new SlotContainer();
		public static TrackContainer _tracks = new TrackContainer();
		public static CallContainer _calls = new CallContainer();

		public static DebugUc _debug = new DebugUc();
		public static KeyboardInterface _keyboard = new KeyboardInterface();

		public string trustString;

		/*******************************/
		/* Creating Events             */
		/*******************************/

		public static event EventHandler<MsgEventArgs> DebugTcpDataReceived;
		public static event EventHandler<MsgEventArgs> KeyboardTcpDataReceived;
		public static event EventHandler<MsgEventArgs> BerthWatch;





		public static bool TcpConnected = false;

		public MainMenu()
		{
			InitializeComponent();

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
				SaveGameParser.Parse(ref _berths, ref _points, ref _signals,
					ref _tracks, ref _slots, ref _frames, ref _flags); //Parse load with ref to points container

			}
			Refresh();

		}


		private void TcpDataUpdate(Object sender, MsgEventArgs e)
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
								_calls.NewIncomingCall(element);
								Refresh();
							}));
					} //New Phone Call
					if (element.StartsWith("pO"))
					{
						if (InvokeRequired)
							Invoke(new MethodInvoker(delegate
							{
								_calls.EndIncomingCall(element);
								Refresh();
							}));
					} //End Phone Call

					if (element.StartsWith("sB"))
					{
						if (InvokeRequired)
							Invoke(new MethodInvoker(delegate
							{
								_berths.DataUpdateTcp(element.Substring(2, 8));
								Refresh();
							}));
					}
					if (element.StartsWith("sL"))
					{
						if (InvokeRequired)
							Invoke(new MethodInvoker(delegate
							{
								_flags.AddFlagTcp(element.Substring(2));
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
								_berths.AddBerthTcp(element.Substring(7, 4), element.Substring(11, 4));
								Refresh();
							}));
					} //Berth Request State Feedback
					if (element.StartsWith("iCP"))
					{
						if (InvokeRequired)
							Invoke(new MethodInvoker(delegate
							{
								_points.AddPointTcp(element.Substring(7));
								Refresh();
							}));
					} //Point Request State Feedback
					if (element.StartsWith("iCS"))
					{
						if (InvokeRequired)
							Invoke(new MethodInvoker(delegate
							{
								_signals.AddSignalTcp(element.Substring(7));
								Refresh();
							}));
					} //Signal Request State Feedback

					if (element.Contains("<platformDataResponse"))
					{
						MsgEventArgs m = new MsgEventArgs() { Msg = element };

						var handler = KeyboardTcpDataReceived;
						if (handler != null) KeyboardTcpDataReceived?.Invoke(this, m);
					}
					

					#region PlatformDataResponse Main

					/*
						if (element.Contains("<platformDataResponse"))
						{
	
							string headcode = null;
							string platform = "   ";
							string line = "   ";
							string path = "   ";
							string description = null;
							string arrival = "--:-- ";
							string departure = "--:-- ";
							string delay = "       ";
							string stock = null;
	
							List<string> simplfierList = new List<string>();
	
							XmlDocument simplifier = new XmlDocument();
	
							simplifier.LoadXml(element.ToString());
	
							XmlNodeList listOfHeadcodes = simplifier.SelectNodes("/SimSig/platformDataResponse/headcode");
	
							foreach (XmlNode trainInSimplfier in listOfHeadcodes)
							{
								if (InvokeRequired)
									Invoke(new MethodInvoker(delegate
									{
										ttDisplay.Items.Clear();
										ttDisplay.Items.Add(trustString);
										ttDisplay.Items.Add(" ");
										ttDisplay.Items.Add("TRAIN ARR    DEP  PLT LIN PTH  DELAY");
									}));
	
								headcode = null;
								platform = "   ";
								line = "   ";
								path = "   ";
								description = null;
								arrival = "--:-- ";
								departure = "--:-- ";
								delay = "       ";
								stock = null;
	
								headcode = trainInSimplfier.Attributes["id"].Value;
								platform = trainInSimplfier.SelectSingleNode("platform").InnerText;
								do
								{
									platform = platform + " ";
								} while (platform.Length != 3);
								line = trainInSimplfier.SelectSingleNode("line").InnerText;
								do
								{
									line = line + " ";
								} while (line.Length != 3);
								path = trainInSimplfier.SelectSingleNode("path").InnerText;
								do
								{
									path = path + " ";
								} while (path.Length != 3);
								description = trainInSimplfier.SelectSingleNode("description").InnerText;
								if (trainInSimplfier.SelectSingleNode("delay") != null)
								{
									if (trainInSimplfier.SelectSingleNode("delay").InnerText != "RT")
									{
										delay = trainInSimplfier.SelectSingleNode("delay").InnerText.Replace("L", "") + " LATE";
									}
									else
									{
										delay = "RT TIME";
									}
								}
								stock = trainInSimplfier.SelectSingleNode("stock").InnerText;
	
								XmlNodeList listOfTimes = trainInSimplfier.SelectNodes("time");
	
								foreach (XmlNode time in listOfTimes)
								{
									if (time.Attributes != null)
									{
										if (time.Attributes["timeType"] != null)
										{
											if (time.Attributes["timeType"].Value == "arrival")
											{
												arrival = time.InnerText;
												if (arrival.Length != 6)
												{
													arrival = arrival + " ";
												}
											}
											else if (time.Attributes["timeType"].Value == "departure")
											{
												departure = time.InnerText;
												if (departure.Length != 6)
												{
													departure = departure + " ";
												}
											}
											else if (time.Attributes["timeType"].Value == "passing")
											{
												departure = time.InnerText;
												arrival = "PASS  ";
												departure = time.InnerText;
												if (departure.Length != 6)
												{
													departure = departure + " ";
												}
											}
										}
									}
								}
	
								if (departure == "--:-- ")
								{
									departure = arrival;
								}
	
								String simplifierString = departure + " " + arrival + " " + headcode + " " + platform + " " + line + " " + path + " " + delay;
								Console.WriteLine(simplifierString);
								simplfierList.Add(simplifierString);
	
							}
	
							//The simplfier needs to be sorted
							Console.WriteLine("*************************");
	
							simplfierList.Sort();
							foreach (string train in simplfierList)
							{
								//Console.WriteLine(train.ToString());
	
								Console.WriteLine(train.ToString().Substring(14, 4) + train.ToString().Substring(6, 8) + train.ToString().Substring(0, 6) + train.ToString().Substring(18));
								if (InvokeRequired)
									Invoke(new MethodInvoker(delegate
									{
										ttDisplay.Items.Add(train.ToString().Substring(14, 4) + train.ToString().Substring(6, 8) + train.ToString().Substring(0, 6) + train.ToString().Substring(18));
									}));
	
							}
	
	
	
						}
						
	*/

					#endregion
				}
				catch
				{
					Console.WriteLine(@"A Unhandled String was Received - " + element);
				}
		}

		private void SerialDataReceived()
		{

		}



		#region Misc Menu Items

		private void ProgramExit(object sender, EventArgs e)
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
			disconnectToolStripMenuItem.Enabled = true;
			TcpConnected = true;
		}
		private void DisconnectToolStripMenuItem_Click(object sender, EventArgs e)
		{

			connectToolStripMenuItem.Enabled = true;
			Connection.Disconnect();
			disconnectToolStripMenuItem.Enabled = false;
			TcpConnected = false;

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


		private void BerthListReset(object sender, EventArgs e)
		{
			_berths.BerthList.Clear();
		}

		private void SignalListResetToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_signals.SignalList.Clear();
		}

		private void PointListRest(object sender, EventArgs e)
		{
			_points.PointList.Clear();

		}

		private void RequestDataToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			_berths.BerthStatusRequest();
			_points.PointStatusConnectionRequest();
			_signals.SignalStatusRequest();
		}

		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{

		}
	}
}


