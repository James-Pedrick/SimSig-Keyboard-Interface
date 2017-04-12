using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace SimSig_Keyboard_Interface.Client.Signals
{
	public class Signals
	{
		public string HexId { get; set; }
		public string Number { get; set; }



		public static string SignalUpdateAspect(string data)
		{
			int intVal = Convert.ToInt32(data);
			string aspect = "R";

			if (intVal == 0x00) aspect = "R";
			if (intVal == 0x01) aspect = "C";
			if (intVal == 0x02) aspect = "Y";
			if (intVal == 0x03) aspect = "FY";
			if (intVal == 0x04) aspect = "YY";
			if (intVal == 0x05) aspect = "FYY";
			if (intVal == 0x06) aspect = "G";
			
			return aspect;


		}

		public static bool [] SignalUpdateRem(string data)
		{
			bool isoAppliedSignal = false;
			bool remAppliedSignal = false;
			bool isoAppliedReplace = false;
			bool remAppliedReplace = false;


			int intValue = Convert.ToInt32(data);


			if (intValue >= 0x80) { isoAppliedReplace = true; intValue = intValue - 0x80; }
			if (intValue >= 0x40) { remAppliedReplace = true; intValue = intValue - 0x40; }
			if (intValue >= 0x20) { isoAppliedSignal = true; intValue = intValue - 0x20; }
			if (intValue >= 0x10) { remAppliedSignal = true; }

			bool[] returnReminders = {isoAppliedReplace, remAppliedReplace, isoAppliedSignal, remAppliedSignal};
			return returnReminders;
		}

		public static bool[] SignalUpdateControl(string data)
		{
			var signalOut = false;
			var signalNormal = false;
			var signalAuto = false;

			switch (Convert.ToInt32(data))
			{
				case 0x00:
					signalOut = true;
					signalNormal = false;
					signalAuto = false;
					break;
				case 0x02:
					signalOut = false;
					signalNormal = true;
					signalAuto = false;
					break;
				case 0x03:
					signalOut = false;
					signalNormal = false;
					signalAuto = true;
					break;
			}




			bool[] returnVal = {signalOut,signalNormal,signalAuto};
			return returnVal;
		}

	}
}
