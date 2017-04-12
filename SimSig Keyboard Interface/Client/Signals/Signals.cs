using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimSig_Keyboard_Interface.Client.Signals
{
	public class Signals
	{
		public string HexId { get; set; }
		public string Number { get; set; }



		public static void DataUpdate(string data)
		{

			int Group1 = Convert.ToInt32(data.Substring(1, 1));     //Reminders
			int Group2 = Convert.ToInt32(data.Substring(2, 1));     //Signal Proving
			int Group3 = Convert.ToInt32(data.Substring(3, 1));     //Signal Aspect



			bool isoAppliedSignal = false;
			bool remAppliedSignal = false;
			bool isoAppliedReplace = false;
			bool remAppliedReplace = false;

			switch (Group1)
			{
				case 0x00:
					remAppliedSignal = false;
					isoAppliedSignal = false;
					isoAppliedReplace = false;
					remAppliedReplace = false;
					break;
				case 0x02:
					remAppliedSignal = false;
					isoAppliedSignal = true;
					isoAppliedReplace = false;
					remAppliedReplace = false;
					break;
				case 0x03:
					remAppliedSignal = true;
					isoAppliedSignal = true;
					isoAppliedReplace = false;
					remAppliedReplace = false;
					break;
				case 0x04:
					remAppliedSignal = false;
					isoAppliedSignal = false;
					isoAppliedReplace = false;
					remAppliedReplace = true;
					break;
				case 0x08:
					remAppliedSignal = false;
					isoAppliedSignal = false;
					isoAppliedReplace = true;
					remAppliedReplace = false;
					break;
				case 0x0C:
					remAppliedSignal = false;
					isoAppliedSignal = false;
					isoAppliedReplace = true;
					remAppliedReplace = true;
					break;
			}




			var signalOut = false;
			var signalNormal = false;
			var signalAuto = false;

			switch (Group2)
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



			int aspect = Group3;


			Console.WriteLine(
				isoAppliedReplace.ToString() +
				remAppliedReplace.ToString() +
				isoAppliedSignal +
				remAppliedReplace +" - "+
				signalOut.ToString() +
				signalNormal.ToString() +
				signalAuto+ " - "+
				aspect.ToString()) ;



		}
	}
}
