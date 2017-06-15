using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimSig_Keyboard_Interface.Comms.RS232;
using SimSig_Keyboard_Interface.Data;
using System.Text.RegularExpressions;
using SimSig_Keyboard_Interface.DataProcess.Flags;
using SimSig_Keyboard_Interface.DataProcess.GroundFrames;
using SimSig_Keyboard_Interface.DataProcess.Slots;
using System.Xml;
using SimSig_Keyboard_Interface.Comms.TCP;


namespace SimSig_Keyboard_Interface.User_Interface
{
	public partial class KeyboardInterface : UserControl
	{
		public string trustString;

		public KeyboardInterface()
		{
			InitializeComponent();
			MainMenu.KeyboardTcpDataReceived += TcpDataReceived;
		}

		private void Header_Paint(object sender, PaintEventArgs e)
		{

		}

		private void userInputString_KeyDown(object sender, KeyEventArgs e)
		{

			if (e.KeyCode == Keys.F1) keyboardSpecFunction.Text = @"REM";
			if (e.KeyCode == Keys.F2) keyboardSpecFunction.Text = @"ISO";
			if (e.KeyCode == Keys.F3) keyboardSpecFunction.Text = @"OVR";


			if (e.KeyCode == Keys.F5)

			{
				DataProcess.KeyboardInterface.PointsKeyNorm(userInputString.Text);
				userInputString.Text = "";
				keyboardSpecFunction.Text = "";
			}
			if (e.KeyCode == Keys.F6)
			{
				DataProcess.KeyboardInterface.PointsCentre(userInputString.Text);
				userInputString.Text = "";
				keyboardSpecFunction.Text = "";
			}
			if (e.KeyCode == Keys.F7)
			{
				DataProcess.KeyboardInterface.PointsKeyReverse(userInputString.Text);
				userInputString.Text = "";
				keyboardSpecFunction.Text = "";
			}

			if (e.KeyCode == Keys.F11)      //Interpose
			{
				if (userInputString.Text.Contains(' ') == false) return;

				DataProcess.KeyboardInterface.TdInterpose(userInputString.Text);

				userInputString.Text = "";
				keyboardSpecFunction.Text = "";
			}

			if (e.KeyCode == Keys.F12)
			{
				MainMenu.Connection.SendData(userInputString.Text + "|");
			}

			if (e.KeyCode == Keys.Enter)      //Set
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

				if (userInputString.Text.StartsWith("B"))
				{
					if (userInputString.Text.Contains(' ') == false) return;

					DataProcess.KeyboardInterface.TdInterpose(userInputString.Text);
				}


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

					string[] combo = userInputString.Text.Split(' ');
					var x = combo.Length;
					var y = 1;

					while (y != x)
					{
						DataProcess.KeyboardInterface.RouteSet(combo[y - 1].Substring(1), combo[y].Substring(1), "");
						y++;
					}



				}             //Route Set (No OverRide)
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


				if (userInputString.Text.StartsWith("TT") && userInputString.Text.Contains(" "))
				{
					string[] z = userInputString.Text.Split(' ');
					MainMenu.Connection.SendData("tO " + z[1] + "|");
					userInputString.Text = "";
					keyboardSpecFunction.Text = "";
				}


				Regex ttrgx = new Regex(@"[0-9]+[A-Z]+[0-9]+[0-9]");

				//Match headcode using regex and pull TT
				if (ttrgx.IsMatch(userInputString.Text))
				{
					string[] substrings = userInputString.Text.Split(' ');

					foreach (string match in substrings)
					{
						if (ttrgx.IsMatch(match))
						{
							MainMenu.Connection.SendData("tO " + match + "|");
						}

						//Connection.SendData("tO " + userInputString.Text + "|");
						userInputString.Text = "";
						keyboardSpecFunction.Text = "";
					}

				}

				if (userInputString.Text.StartsWith("TRJA"))
				{
					string[] z = userInputString.Text.Split(' ');
					trustString = ("TRUST LineUP for " + z[1] + " at " + z[2]);


					MainMenu.Connection.SendData("<?xml version=\"1.0\" encoding=\"utf-8\"?><SimSig><platformDataRequest userTag=\"1\"><id>" + z[1] + "</id><platformCodes>(all)</platformCodes><time>" + z[2] + "</time></platformDataRequest></SimSig>|");//WORK HERE
					userInputString.Text = "";
					keyboardSpecFunction.Text = "";
				}

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

		private void TcpDataReceived(object sener, MsgEventArgs e)
		{
			string element = e.Msg;

			if (InvokeRequired)
			{
				Invoke(new MethodInvoker(delegate
				{
					if (element != null)
					{
						if (element.Contains("<platformDataResponse"))
							Trja(element);
						if(element.Contains("zA"))
							TimeUpdate(element);

					}
				}));
			}
		}

		private void TimeUpdate(string element)
		{
			var timeString = element.Substring(6, 4);

			var timeSeconds = int.Parse(timeString, NumberStyles.HexNumber);

			TimeSpan simTime = TimeSpan.FromSeconds(timeSeconds);


			clock.Text = simTime.ToString().Substring(0,5);

			if(element.EndsWith("1")) clock.ForeColor = Color.Magenta;
			else clock.ForeColor = Color.Cyan;
		}

		private void Trja(string element)
		{
			if (element.Contains("<platformDataResponse"))
			{
				ttDisplay.Items.Clear();


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
					/*		if (InvokeRequired)
								Invoke(new MethodInvoker(delegate
								{
									consoleWindow.Items.Add(train.ToString().Substring(14, 4) + train.ToString().Substring(6, 8) + train.ToString().Substring(0, 6) + train.ToString().Substring(18));
								}));*/


						ttDisplay.Items.Add(train.ToString().Substring(14, 4) + train.ToString().Substring(6, 8) +
						                        train.ToString().Substring(0, 6) + train.ToString().Substring(18));


				}

				ttDisplay.Refresh();



			}

		}

	}
}

