using System.Linq;
using SimSig_Keyboard_Interface.User_Interface;

namespace SimSig_Keyboard_Interface.DataProcess
{
	class KeyboardInterface
	{


		#region New Shit

		public static void RouteSet(string entry, string exit, string function)
		{
			var entrySigHex = MainMenu._signals.SignalIdLookup(entry);
			var exitSigHex = MainMenu._signals.SignalIdLookup(exit);


			if (entrySigHex == null || exitSigHex == null) return;

			var ovr = "00";
			if (function == @"OVR") ovr = @"01";
			else ovr = @"00";

			var toSend = @"SA" + entrySigHex + exitSigHex + ovr + entrySigHex + @"----|";

			MainMenu.Connection.SendData(toSend);
		}
		public static void RouteCancel(string data)
		{
			string[] entry = data.Split(' ');

			var entrySigHex = MainMenu._signals.SignalIdLookup(entry[0]);

			var toSend = @"zD" + entrySigHex + '|';

			MainMenu.Connection.SendData(toSend);
		}

		public static void TdInterpose(string data)
		{
			if (data.Contains(' ') == false) return;

			string[] userInput = data.Split(' ');

			var berthHex = MainMenu._berths.BerthHIdLookup(userInput[0]);

			var toSend = @"BB" + berthHex + userInput[1] + "|";

			MainMenu.Connection.SendData(toSend);
		}
		public static void TdCancel(string data)
		{
			string[] userInput = data.Split(' ');

			var berthHex = MainMenu._berths.BerthHIdLookup(userInput[0]);

			var toSend = @"BC" + berthHex + "|";

			MainMenu.Connection.SendData(toSend);
		}

		public static void SignalReplacementSet(string data)
		{
			var signalHex = MainMenu._signals.SignalIdLookup(data);

			var toSend = @"SQ" + signalHex + "|";
			MainMenu.Connection.SendData(toSend);
		}
		public static void SignalReplacementcancel(string data)
		{
			var signalHex = MainMenu._signals.SignalIdLookup(data);

			var toSend = @"SP" + signalHex + "|";
			MainMenu.Connection.SendData(toSend);
		}
		public static void SignalReplacementReminderSet(string data)
		{
			var signalHex = MainMenu._signals.SignalIdLookup(data);

			var toSend = @"SS" + signalHex + "|";
			MainMenu.Connection.SendData(toSend);
		}
		public static void SignalReplacementIsolationSet(string data)
		{
			var signalHex = MainMenu._signals.SignalIdLookup(data);

			var toSend = @"SR" + signalHex + "|";
			MainMenu.Connection.SendData(toSend);
		}
		public static void SignalReplacementReminderCancel(string data)
		{
			var signalHex = MainMenu._signals.SignalIdLookup(data);

			var toSend = @"SU" + signalHex + "|";
			MainMenu.Connection.SendData(toSend);
		}
		public static void SignalReplacementIsolationCancel(string data)
		{
			var signalHex = MainMenu._signals.SignalIdLookup(data);

			var toSend = @"ST" + signalHex + "|";
			MainMenu.Connection.SendData(toSend);
		}

		public static void SignalAutoSet(string data)
		{
			var signalHex = MainMenu._signals.SignalIdLookup(data);

			var toSend = @"SF" + signalHex + "|";
			MainMenu.Connection.SendData(toSend);
		}
		public static void SignalAutoCancel(string data)
		{
			var signalHex = MainMenu._signals.SignalIdLookup(data);

			var toSend = @"SG" + signalHex + "|";
			MainMenu.Connection.SendData(toSend);
		}
		public static void SignalAutoReminderSet(string data)
		{
			var signalHex = MainMenu._signals.SignalIdLookup(data);

			var toSend = @"SI" + signalHex + "|";
			MainMenu.Connection.SendData(toSend);
		}
		public static void SignalAutoReminderCancel(string data)
		{
			var signalHex = MainMenu._signals.SignalIdLookup(data);

			var toSend = @"SK" + signalHex + "|";
			MainMenu.Connection.SendData(toSend);
		}
		public static void SignalAutoIsolationSet(string data)
		{
			var signalHex = MainMenu._signals.SignalIdLookup(data);

			var toSend = @"SH" + signalHex + "|";
			MainMenu.Connection.SendData(toSend);
		}
		public static void SignalAutoIsolationCancel(string data)
		{
			var signalHex = MainMenu._signals.SignalIdLookup(data);

			var toSend = @"SJ" + signalHex + "|";
			MainMenu.Connection.SendData(toSend);
		}

		public static void SignalReminderSet(string data)
		{
			var signalHex = MainMenu._signals.SignalIdLookup(data);

			var toSend = @"SD" + signalHex + "|";
			MainMenu.Connection.SendData(toSend);
		}
		public static void SignalIsolationSet(string data)
		{
			var signalHex = MainMenu._signals.SignalIdLookup(data);

			var toSend = @"SB" + signalHex + "|";
			MainMenu.Connection.SendData(toSend);
		}
		public static void SignalReminderCancel(string data)
		{
			var signalHex = MainMenu._signals.SignalIdLookup(data);

			var toSend = @"SE" + signalHex + "|";
			MainMenu.Connection.SendData(toSend);
		}
		public static void SignalIsolationCancel(string data)
		{
			var signalHex = MainMenu._signals.SignalIdLookup(data);

			var toSend = @"SC" + signalHex + "|";
			MainMenu.Connection.SendData(toSend);
		}

		public static void PointReminderApply(string data)
		{
			var pointHex = MainMenu._points.PointLookup(data);

			var toSend = @"PD" + pointHex + "|";
			MainMenu.Connection.SendData(toSend);
		}
		public static void PointReminderCancel(string data)
		{
			var pointHex = MainMenu._points.PointLookup(data);

			var toSend = @"PE" + pointHex + "|";
			MainMenu.Connection.SendData(toSend);
		}


		#endregion


		public static void KeyboardPointNorm(string data)
		{
			string[] points = data.Split(' ');
			Data.SendPrep.PointsKeyN(points[0].Substring(1));
		}

		public static void KeyboardPointFree(string data)
		{
			string[] points = data.Split(' ');
			Data.SendPrep.PointsKeyF(points[0].Substring(1));
		}

		public static void KeyboardPointRev(string data)
		{
			string[] points = data.Split(' ');
			Data.SendPrep.PointsKeyR(points[0].Substring(1));
		}

	}
}
