using System;
using System.IO.Ports;
using SimSig_Keyboard_Interface.Data;

namespace SimSig_Keyboard_Interface.Comms.RS232
{
	class Rs232Main
	{

		private static bool _firstSignal = true;
		private static string _signalEnt;
		private static string _signalExit;

		public static void Rs232Receiver()
		{
			//OPEN THE SERIAL PORT
			try
			{
				SerialPort receive = new SerialPort();
				receive.BaudRate = 9600;
				receive.PortName = "COM2";
				receive.Open();
				receive.DataBits = 8;

				while (true)
				{
					string[] receivedData = receive.ReadTo("|").Split('-');
					Console.WriteLine(receivedData[0] + @" - " + receivedData[1]);

					if (receivedData[0].Contains("SS")) SerialSignalSet(receivedData[1]);               //Generic NX Button Press
					if (receivedData[0].Contains("SC")) SendPrep.RouteCan(receivedData[1]);             //Route Cancel (Route Pull)
					if (receivedData[0].Contains("SN")) EntryButtonPress(receivedData[1]);				//Signal Entry Only button press
					if (receivedData[0].Contains("SX")) ExitButtonPress(receivedData[1]);				//Signal Exit Only button press

					if (receivedData[0].Contains("SA")) SendPrep.SigAutoSet(receivedData[1]);           //Auto button set
					if (receivedData[0].Contains("SB")) SendPrep.SigAutoCan(receivedData[1]);           //Auto button cancel

					if (receivedData[0].Contains("SR")) SendPrep.SigReplacementSet(receivedData[1]);    //Signal Replacement Set
					if (receivedData[0].Contains("SP")) SendPrep.SigReplacementCan(receivedData[1]);    //Signal Replacement Cancel

					

					if (receivedData[0].Contains("PF")) SendPrep.PointsKeyF(receivedData[1]);			//Points Keyed Free
					if (receivedData[0].Contains("PN")) SendPrep.PointsKeyN(receivedData[1]);			//Points Keyed Normal
					if (receivedData[0].Contains("PR")) SendPrep.PointsKeyR(receivedData[1]);			//Points Keyed Reverse



				}
			}
			catch (Exception e) { Console.WriteLine(e); }
		}

		private static void SerialSignalSet(string data)
		{
			if (_firstSignal.Equals(true))
			{
				_signalEnt = data;
				_firstSignal = false;
			}

			else
			{
				_signalExit = data;
				//				var entry = MainMenu._signals.SignalIdLookup(_signalEnt);
				//			var exit = MainMenu._signals.SignalIdLookup(_signalExit);

				SendPrep.RouteSet(_signalEnt, _signalExit);
				_firstSignal = true;

				//MainMenu.Connection;


			}
		}

		private static void ExitButtonPress(string data)
		{

			if (_firstSignal)
				return;

			_signalExit = data;
			SendPrep.RouteSet(_signalEnt, _signalExit);
			_firstSignal = true;
		}

		private static void EntryButtonPress(string data)
		{
			_signalEnt = data;
			_firstSignal = false;
		}

	}
}
