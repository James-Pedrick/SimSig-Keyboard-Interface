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

			Signals.DataUpdate(data.Substring(4,7));


		}




	}
}
