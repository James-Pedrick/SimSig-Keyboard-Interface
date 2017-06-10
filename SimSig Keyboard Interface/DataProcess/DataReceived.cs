using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimSig_Keyboard_Interface.User_Interface;

namespace SimSig_Keyboard_Interface.DataProcess
{
	class DataReceived
	{
		public static void DataProcess(string element)
		{
			try
			{
				if (element.StartsWith("sB"))
					MainMenu._berths.DataUpdateTcp(element.Substring(2, 8));
				if (element.StartsWith("sP"))
					MainMenu._points.AddPointTcp(element.Substring(2, 7));
				if (element.StartsWith("sS"))
					MainMenu._signals.AddSignalTcp(element.Substring(2, 13));
				if (element.StartsWith("sT"))
					MainMenu._tracks.AddTrackTcp(element.Substring(2, 6));

				if(element.StartsWith("iCP"))
					MainMenu._points.AddPointTcp(element.Substring(2, 7));
			}
			catch
			{
				Console.WriteLine(@"A Unhandled String was Received - " + element);
			}

		}
	}
}
