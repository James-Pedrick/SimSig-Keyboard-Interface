using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace SimSig_Keyboard_Interface.Client.Signals
{
	public class SignalContainer
	{

		public static BindingList<Signals> SignalList = new BindingList<Signals>();



		public void AddSignalXml(string hId, string sNum)
		{

			if (SignalList.SingleOrDefault(s => s.HexId == hId) == null)
			{
				SignalList.Add(new Signals { HexId = hId, Number = sNum });
			}
			else
			{
				SignalList.Single(s => s.HexId == hId).Number = sNum;
			}
		}

		public void DataUpdateTcp(string data)
		{
			string hId = data.Substring(0, 4);

			//	Signals.DataUpdate(data.Substring(4, 7));

			//Byte 0 - 3 Berths Hex Id
			//Byte 4 -	 Reminder States

			bool[] signalReminders = Signals.SignalUpdateRem(data.Substring(4, 2));
			bool[] signalProving = Signals.SignalUpdateControl(data.Substring(6, 1));
			string singalAspect = Signals.SignalUpdateAspect(data.Substring(7, 1));

			Console.WriteLine(hId + " - " + singalAspect);

			Console.WriteLine(
				hId + " " +
				signalReminders[0] +
				signalReminders[1] +
				signalReminders[2] +
				signalReminders[3] +
				signalReminders[4] +
				signalReminders[5] + " " +
				signalProving[0] +
				signalProving[1] +
				signalProving[2] + " " + singalAspect);


			//		bool[] returnReminders = {isoAppliedReplace, remAppliedReplace, remAppliedAuto, isoAppliedAuto, isoAppliedSignal, remAppliedSignal};

		}




	}
}
