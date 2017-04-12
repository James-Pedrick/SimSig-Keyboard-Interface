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



		public void AddSignal(string hId, string sNum)
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
            var hexId = data.Substring(0, 4);
            var berthContent = data.Substring(4, 4);

            AddSignal(hexId, berthContent);
        }


        public string PrintSignals()
		{
			var done = @"";

			foreach (Signals x in SignalList)
			{
				done = done + x.HexId.PadRight(6) + x.Number + "\n";
			}
			return done;
		}



	}
}
