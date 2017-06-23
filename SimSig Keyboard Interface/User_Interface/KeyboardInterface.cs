using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Windows.Shapes;
using System.Xml;
using SimSig_Keyboard_Interface.Comms.TCP;


namespace SimSig_Keyboard_Interface.User_Interface
{
	public partial class KeyboardInterface : UserControl
	{
		private string trustString;


		public KeyboardInterface()
		{
			InitializeComponent();
			MainMenu.KeyboardTcpDataReceived += TcpDataReceived;
		}

		private void UserInputString_KeyDown(object sender, KeyEventArgs e)
		{

			if (e.KeyCode == Keys.F1) keyboardSpecFunction.Text = @"REM";
			if (e.KeyCode == Keys.F2) keyboardSpecFunction.Text = @"ISO";
			if (e.KeyCode == Keys.F3) keyboardSpecFunction.Text = @"OVR";

			if (e.KeyCode == Keys.F5) { DataProcess.KeyboardInterface.PointsKeyNorm(userInputString.Text); userInputString.Text = ""; keyboardSpecFunction.Text = ""; }
			if (e.KeyCode == Keys.F6) { DataProcess.KeyboardInterface.PointsCentre(userInputString.Text); userInputString.Text = ""; keyboardSpecFunction.Text = ""; }
			if (e.KeyCode == Keys.F7) { DataProcess.KeyboardInterface.PointsKeyReverse(userInputString.Text); userInputString.Text = ""; keyboardSpecFunction.Text = ""; }
			
			if (e.KeyCode == Keys.F12) MainMenu.TcpConnection.SendData(userInputString.Text + "|");

			if (e.KeyCode == Keys.Enter) //Set
			{
				string[] z = userInputString.Text.Split(' ');
				if (userInputString.Text.Equals("COM")) ComCommandDisplay();
				if (userInputString.Text.Equals("COMMANDS")) CommandList();
				if (userInputString.Text.Equals("CLS")) ttDisplay.Items.Clear();
				if (userInputString.Text.StartsWith("A"))
				{
					if (keyboardSpecFunction.Text == "")
						DataProcess.KeyboardInterface.SignalAutoSet(z[0].Substring(1)); //Auto Set
					if (keyboardSpecFunction.Text == @"REM")
						DataProcess.KeyboardInterface.SignalAutoReminderSet(z[0].Substring(1)); //Auto REM Apply
					if (keyboardSpecFunction.Text == @"ISO")
						DataProcess.KeyboardInterface.SignalAutoIsolationSet(z[0].Substring(1)); //Auto Isolation
				}

				if (userInputString.Text.StartsWith("B"))
					DataProcess.KeyboardInterface.TdInterpose(userInputString.Text);


				if (userInputString.Text.StartsWith("E"))
				{
					if (keyboardSpecFunction.Text == "")
						DataProcess.KeyboardInterface.SignalReplacementSet(z[0].Substring(1)); //Signal Replacement Set
					if (keyboardSpecFunction.Text == @"REM")
						DataProcess.KeyboardInterface.SignalReplacementReminderSet(z[0].Substring(1));
					if (keyboardSpecFunction.Text == @"ISO")
						DataProcess.KeyboardInterface.SignalReplacementIsolationSet(z[0].Substring(1));

				}
				if (userInputString.Text.StartsWith("S"))
				{
					if (keyboardSpecFunction.Text == @"")
					{
						string[] combo = userInputString.Text.Split(' ');
						var x = combo.Length;
						var y = 1;

						while (y != x)
						{
							DataProcess.KeyboardInterface.RouteSet(combo[y - 1].Substring(1), combo[y].Substring(1), "");
							y++;
						}
					} //Route Set (No OverRide)
					if (keyboardSpecFunction.Text == @"OVR")
						DataProcess.KeyboardInterface.RouteSet(z[0].Substring(1), z[1].Substring(1), @"OVR");
					if (keyboardSpecFunction.Text == @"REM")
						DataProcess.KeyboardInterface.SignalReminderSet(z[0].Substring(1));
					if (keyboardSpecFunction.Text == @"ISO")
						DataProcess.KeyboardInterface.SignalIsolationSet(z[0].Substring(1));
				}
				if (userInputString.Text.StartsWith("P"))
				{
					if (keyboardSpecFunction.Text == @"REM")
						DataProcess.KeyboardInterface.PointReminderApply(z[0].Substring(1));
				}


				if (userInputString.Text.StartsWith("TT") && userInputString.Text.Contains(" "))
				{
					MainMenu.TcpConnection.SendData("tO " + z[1] + "|");
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
							MainMenu.TcpConnection.SendData("tO " + match + "|");
						}

						//Connection.SendData("tO " + userInputString.Text + "|");
						userInputString.Text = "";
						keyboardSpecFunction.Text = "";
					}

				}

				if (userInputString.Text.StartsWith("TRJA"))
				{
					trustString = ("TRUST LineUP for " + z[1] + " at " + z[2]);


					MainMenu.TcpConnection.SendData("<?xml version=\"1.0\" encoding=\"utf-8\"?><SimSig><platformDataRequest userTag=\"1\"><id>" + z[1] + "</id><platformCodes>(all)</platformCodes><time>" + z[2] + "</time></platformDataRequest></SimSig>|");//WORK HERE
					userInputString.Text = "";
					keyboardSpecFunction.Text = "";
				}





				userInputString.Text = "";
				keyboardSpecFunction.Text = "";

			}


			if (e.KeyCode == Keys.Delete) //CAN
			{
				string[] z = userInputString.Text.Split(' ');
				if (userInputString.Text.StartsWith("A"))
				{
					if (keyboardSpecFunction.Text == "")
						DataProcess.KeyboardInterface.SignalAutoCancel(z[0].Substring(1));

					if (keyboardSpecFunction.Text == @"REM")
						DataProcess.KeyboardInterface.SignalAutoReminderCancel(z[0].Substring(1));
					if (keyboardSpecFunction.Text == @"ISO")
						DataProcess.KeyboardInterface.SignalAutoIsolationCancel(z[0].Substring(1));
				}
				if (userInputString.Text.StartsWith("B"))
					DataProcess.KeyboardInterface.TdCancel(userInputString.Text);                                          //TD Cancel

				if (userInputString.Text.StartsWith("E"))
				{
					if (keyboardSpecFunction.Text == "")
						DataProcess.KeyboardInterface.SignalReplacementcancel(z[0].Substring(1));
					if (keyboardSpecFunction.Text == @"REM")
						DataProcess.KeyboardInterface.SignalReplacementReminderCancel(z[0].Substring(1));
					if (keyboardSpecFunction.Text == @"ISO")
						DataProcess.KeyboardInterface.SignalReplacementIsolationCancel(z[0].Substring(1));
				}

				if (userInputString.Text.StartsWith("S"))
				{
					if (keyboardSpecFunction.Text == "")
						DataProcess.KeyboardInterface.RouteCancel(userInputString.Text.Substring(1));
					if (keyboardSpecFunction.Text == @"REM")
						DataProcess.KeyboardInterface.SignalReminderCancel(z[0].Substring(1));
					if (keyboardSpecFunction.Text == @"ISO")
						DataProcess.KeyboardInterface.SignalIsolationCancel(z[0].Substring(1));
				}
				if (userInputString.Text.StartsWith("P") && keyboardSpecFunction.Text == @"REM")
					DataProcess.KeyboardInterface.PointReminderCancel(z[0].Substring(1));

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
						if (element.Contains("<platformDataResponse")) Trja(element);
						if (element.StartsWith("tE")) TeMessage(element);
						if (element.StartsWith("tL")) ttDisplay.Items.Clear();
						if (element.StartsWith("tM")) ttDisplay.Items.Add(element.Substring(2));
						if (element.Contains("zA")) TimeUpdate(element);

					}
				}));
			}
		}

		private void TimeUpdate(string element)
		{
			var timeString = element.Substring(2, 8);

			var timeSeconds = int.Parse(timeString, NumberStyles.HexNumber);

			TimeSpan simTime = TimeSpan.FromSeconds(timeSeconds);


			clock.Text = simTime.ToString().Substring(0, 5);

			clock.ForeColor = element.EndsWith("1") ? Color.Magenta : Color.Cyan;
		}

		private void Trja(string element)
		{
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



				if (trustString == null) return;


				ttDisplay.Items.Clear();
				ttDisplay.Items.Add(trustString);
				ttDisplay.Items.Add(" ");
				ttDisplay.Items.Add("TRAIN ARR    DEP  PLT LIN PTH  DELAY");

				if (InvokeRequired)
					Invoke(new MethodInvoker(delegate
					{
						ttDisplay.Items.Clear();
						ttDisplay.Items.Add(trustString);
						ttDisplay.Items.Add(" ");
						ttDisplay.Items.Add("TRAIN ARR    DEP  PLT LIN PTH  DELAY");
					}));

				foreach (XmlNode trainInSimplfier in listOfHeadcodes)
				{


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
					while (platform.Length != 3)
					{
						platform = platform + " ";
					}
					line = trainInSimplfier.SelectSingleNode("line").InnerText;
					while (line.Length != 3)
					{
						line = line + " ";
					}
					path = trainInSimplfier.SelectSingleNode("path").InnerText;
					while (path.Length != 3)
					{
						path = path + " ";
					}
					description = trainInSimplfier.SelectSingleNode("description").InnerText;
					if (trainInSimplfier.SelectSingleNode("delay") != null)
					{
						if (trainInSimplfier.SelectSingleNode("delay").InnerText != "RT")
						{
							if (trainInSimplfier.SelectSingleNode("delay").InnerText.Contains("E"))
							{
								delay = trainInSimplfier.SelectSingleNode("delay").InnerText.Replace("E", "") + " EARLY";
							}
							else
							{
								delay = trainInSimplfier.SelectSingleNode("delay").InnerText.Replace("L", "") + " LATE";
							}
						}
						else
						{
							delay = "RT TIME";
						}
					}
					//stock = trainInSimplfier.SelectSingleNode("stock").InnerText;

					//Check if all of these are null!?

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
					ttDisplay.Items.Add(train.ToString().Substring(14, 4) + train.ToString().Substring(6, 8) + train.ToString().Substring(0, 6) + train.ToString().Substring(18));
					if (InvokeRequired)
						Invoke(new MethodInvoker(delegate
						{
							ttDisplay.Items.Add(train.ToString().Substring(14, 4) + train.ToString().Substring(6, 8) + train.ToString().Substring(0, 6) + train.ToString().Substring(18));
						}));

				}



			}
		}

		private void TeMessage(string element)
		{
			ttDisplay.Items.Clear();
			ttDisplay.Items.Add(element.Substring(2));
		}

		private void TtDisplay_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void UserInputString_TextChanged(object sender, EventArgs e)
		{

		}

		private void CommandList()
		{
			ttDisplay.Items.Clear();

			string[] lines = File.ReadAllLines(@"Notes/Commands.txt");

			foreach (var line in lines)
				ttDisplay.Items.Add(line);
		}
		private void ComCommandDisplay()
		{
			ttDisplay.Items.Clear();

			string[] lines = File.ReadAllLines(@"Notes/ComCommands.txt");

			foreach (var line in lines)
				ttDisplay.Items.Add(line);
		}
	}
}

