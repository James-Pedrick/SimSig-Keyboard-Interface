using System;
using System.Collections.Generic;
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
				receive.PortName = "COM3";
				receive.Open();
				receive.DataBits = 8;

				while (true)
				{
					var receivedData = receive.ReadTo("|");
					Console.WriteLine(receivedData);


					if (receivedData.StartsWith("SS")) SerialSS(receivedData);


				}

				//Console.WriteLine(Main.Program.Received_Data);


			}
			catch (Exception e)
			{
				throw;
			}
		}

		private static void SerialSS(string data)
		{
			if (_firstSignal.Equals(true))
			{
				_signalEnt = data.Substring(2);
				_firstSignal = false;
			}

			else
			{
				_signalExit = data.Substring(2);
//				var entry = MainMenu._signals.SignalIdLookup(_signalEnt);
	//			var exit = MainMenu._signals.SignalIdLookup(_signalExit);

				SendPrep.RouteSet(_signalEnt,_signalExit);
				_firstSignal = true;

				//MainMenu.Connection;


			}


			




		}
	
	
	}
}
