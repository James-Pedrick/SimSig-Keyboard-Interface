using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using SimSig_Keyboard_Interface.Data;
using SimSig_Keyboard_Interface.User_Interface;

namespace SimSig_Keyboard_Interface.Comms.RS232
{
	class Rs232Main
	{

		private static bool _firstSignal = true;
		private static string _signalEnt;
		private static string _signalExit;

		public static void Rs232Receiver()
		{
			int i = 1;
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
					Console.WriteLine(receivedData[0] + " - " + receivedData[1]);

					if (receivedData[0].Contains("SS")) SerialSignalSet(receivedData[1]);
					if (receivedData[0].Contains("SC")) SendPrep.RouteCan(receivedData[1]);

					if (receivedData[0].Contains("SA")) SendPrep.SigAutoSet(receivedData[1]);
					if (receivedData[0].Contains("SB")) SendPrep.SigAutoCan(receivedData[1]);

					if (receivedData[0].Contains("SR")) SendPrep.SigReplacementSet(receivedData[1]);
					if (receivedData[0].Contains("SP")) SendPrep.SigReplacementCan(receivedData[1]);

					if (receivedData[0].Contains("PF")) SendPrep.PointsKeyF(receivedData[1]);
					if (receivedData[0].Contains("PN")) SendPrep.PointsKeyN(receivedData[1]);
					if (receivedData[0].Contains("PR")) SendPrep.PointsKeyR(receivedData[1]);

				}
				//Console.WriteLine(Main.Program.Received_Data);
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



	}
}
