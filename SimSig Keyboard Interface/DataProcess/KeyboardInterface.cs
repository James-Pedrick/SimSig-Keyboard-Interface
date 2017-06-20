using System.Linq;
using SimSig_Keyboard_Interface.User_Interface;
using System.Threading;


namespace SimSig_Keyboard_Interface.DataProcess
{
	class KeyboardInterface
	{




		public static void RouteSet(string entry, string exit, string function)
		{
			var entrySigHex = MainMenu.Signals.SignalIdLookup(entry);
			var exitSigHex = MainMenu.Signals.SignalIdLookup(exit);


			if (entrySigHex == null || exitSigHex == null) return;

			var ovr = @"00";

			if (function == @"OVR") ovr = @"01";
			else ovr = @"00";

			var toSend = @"SA" + entrySigHex + exitSigHex + ovr + entrySigHex + @"----|";

			MainMenu.Connection.SendData(toSend);
		}
		public static void RouteCancel(string data)
		{
			string[] entry = data.Split(' ');

			var entrySigHex = MainMenu.Signals.SignalIdLookup(entry[0]);

			var toSend = @"zD" + entrySigHex + '|';

			MainMenu.Connection.SendData(toSend);
		}

		public static void TdInterpose(string data)
		{
			if (data.Contains(' ') == false) return;

			string[] userInput = data.Split(' ');

			var berthHex = MainMenu.Berths.BerthHIdLookup(userInput[0]);

			var toSend = @"BB" + berthHex + userInput[1] + "|";

			MainMenu.Connection.SendData(toSend);
		}
		public static void TdCancel(string data)
		{
			string[] userInput = data.Split(' ');

			var berthHex = MainMenu.Berths.BerthHIdLookup(userInput[0]);

			var toSend = @"BC" + berthHex + "|";

			MainMenu.Connection.SendData(toSend);
		}

		public static void SignalReplacementSet(string data)
		{
			var signalHex = MainMenu.Signals.SignalIdLookup(data);

			var toSend = @"SQ" + signalHex + "|";
			MainMenu.Connection.SendData(toSend);
		}
		public static void SignalReplacementcancel(string data)
		{
			var signalHex = MainMenu.Signals.SignalIdLookup(data);

			var toSend = @"SP" + signalHex + "|";
			MainMenu.Connection.SendData(toSend);
		}
		public static void SignalReplacementReminderSet(string data)
		{
			var signalHex = MainMenu.Signals.SignalIdLookup(data);

			var toSend = @"SS" + signalHex + "|";
			MainMenu.Connection.SendData(toSend);
		}
		public static void SignalReplacementIsolationSet(string data)
		{
			var signalHex = MainMenu.Signals.SignalIdLookup(data);

			var toSend = @"SR" + signalHex + "|";
			MainMenu.Connection.SendData(toSend);
		}
		public static void SignalReplacementReminderCancel(string data)
		{
			var signalHex = MainMenu.Signals.SignalIdLookup(data);

			var toSend = @"SU" + signalHex + "|";
			MainMenu.Connection.SendData(toSend);
		}
		public static void SignalReplacementIsolationCancel(string data)
		{
			var signalHex = MainMenu.Signals.SignalIdLookup(data);

			var toSend = @"ST" + signalHex + "|";
			MainMenu.Connection.SendData(toSend);
		}

		public static void SignalAutoSet(string data)
		{
			var signalHex = MainMenu.Signals.SignalIdLookup(data);

			var toSend = @"SF" + signalHex + "|";
			MainMenu.Connection.SendData(toSend);
		}
		public static void SignalAutoCancel(string data)
		{
			var signalHex = MainMenu.Signals.SignalIdLookup(data);

			var toSend = @"SG" + signalHex + "|";
			MainMenu.Connection.SendData(toSend);
		}
		public static void SignalAutoReminderSet(string data)
		{
			var signalHex = MainMenu.Signals.SignalIdLookup(data);

			var toSend = @"SI" + signalHex + "|";
			MainMenu.Connection.SendData(toSend);
		}
		public static void SignalAutoReminderCancel(string data)
		{
			var signalHex = MainMenu.Signals.SignalIdLookup(data);

			var toSend = @"SK" + signalHex + "|";
			MainMenu.Connection.SendData(toSend);
		}
		public static void SignalAutoIsolationSet(string data)
		{
			var signalHex = MainMenu.Signals.SignalIdLookup(data);

			var toSend = @"SH" + signalHex + "|";
			MainMenu.Connection.SendData(toSend);
		}
		public static void SignalAutoIsolationCancel(string data)
		{
			var signalHex = MainMenu.Signals.SignalIdLookup(data);

			var toSend = @"SJ" + signalHex + "|";
			MainMenu.Connection.SendData(toSend);
		}

		public static void SignalReminderSet(string data)
		{
			var signalHex = MainMenu.Signals.SignalIdLookup(data);

			var toSend = @"SD" + signalHex + "|";
			MainMenu.Connection.SendData(toSend);
		}
		public static void SignalIsolationSet(string data)
		{
			var signalHex = MainMenu.Signals.SignalIdLookup(data);

			var toSend = @"SB" + signalHex + "|";
			MainMenu.Connection.SendData(toSend);
		}
		public static void SignalReminderCancel(string data)
		{
			var signalHex = MainMenu.Signals.SignalIdLookup(data);

			var toSend = @"SE" + signalHex + "|";
			MainMenu.Connection.SendData(toSend);
		}
		public static void SignalIsolationCancel(string data)
		{
			var signalHex = MainMenu.Signals.SignalIdLookup(data);

			var toSend = @"SC" + signalHex + "|";
			MainMenu.Connection.SendData(toSend);
		}

		public static void PointReminderApply(string data)
		{
			var pointHex = MainMenu.Points.PointLookup(data);

			var toSend = @"PD" + pointHex + "|";
			MainMenu.Connection.SendData(toSend);
		}
		public static void PointReminderCancel(string data)
		{
			var pointHex = MainMenu.Points.PointLookup(data);

			var toSend = @"PE" + pointHex + "|";
			MainMenu.Connection.SendData(toSend);
		}

		


		public static void PointsKeyNorm(string data)
		{
			string pointHex = MainMenu.Points.PointLookup(data);

			if (pointHex == "") return;

			bool[] pointStates = MainMenu.Points.PointStatusKeyRequest(data);

			if (pointStates[0] || pointStates[7])
				return;

			if (pointStates[1] && pointStates[8] == false)
			{
				MainMenu.Connection.SendData(@"PB" + pointHex + @"|");
				return;
			}
			if (pointStates[2] && pointStates[8] == false)
			{
				MainMenu.Connection.SendData(@"PB" + pointHex + @"|");
				return;
			}
			if (pointStates[8] == true)
			{
				MainMenu.Connection.SendData(@"PB" + pointHex + @"|" + @"PB" + pointHex + @"|");
				return;
			}

		}

		public static void PointsCentre(string data)
		{
			string pointHex = MainMenu.Points.PointLookup(data);

			if (pointHex == "") return;

			bool[] pointStates = MainMenu.Points.PointStatusKeyRequest(data);


			if (pointStates[0]) return;
			if (pointStates[7] == false && pointStates[8] == false) return;


			MainMenu.Connection.SendData(@"PC" + pointHex + @"|");
		}

		public static void PointsKeyReverse(string data)
		{
			string pointHex = MainMenu.Points.PointLookup(data);

			if (pointHex == "") return;

			bool[] pointStates = MainMenu.Points.PointStatusKeyRequest(data);

			if (pointStates[0] || pointStates[8])
				return;

			if (pointStates[1] && pointStates[7] == false)
			{
				MainMenu.Connection.SendData(@"PC" + pointHex + @"|");
				return;
			}
			if (pointStates[2] && pointStates[7] == false)
			{
				MainMenu.Connection.SendData(@"PC" + pointHex + @"|");
				return;
			}
			if (pointStates[7])
			{
				MainMenu.Connection.SendData(@"PC" + pointHex + @"|" + @"PC" + pointHex + @"|");
				return;
			}

		}

	}
}
