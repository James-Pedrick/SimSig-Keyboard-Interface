using System;
using System.ComponentModel;
using System.Linq;
using SimSig_Keyboard_Interface.User_Interface.MainDisplays;

namespace SimSig_Keyboard_Interface.DataProcess.Signals
{
	public class SignalContainer
	{
		public BindingList<Signals> SignalList = new BindingList<Signals>();


		private Signals _signalDataUpdate = new Signals();


		public void AddSignalXml(string hId, string sNum)
		{

			if (SignalList.SingleOrDefault(s => s.HexId == hId) == null)
				SignalList.Add(new Signals {HexId = hId, Number = sNum});
			else
				SignalList.Single(s => s.HexId == hId).Number = sNum;

		}

		public void AddSignalTcp(string data)
		{
			string hId = data.Substring(0, 4);

			if (SignalList.SingleOrDefault(s => s.HexId == hId) == null)
				SignalList.Add(new Signals { HexId = hId });

			//Byte 0 - 3 Berths Hex Id
			//Byte 4 -	 Reminder States'
			//Byte 6 -   Controls
			//Byte 7 -   Aspect
			try
			{
				SignalList.Single(s => s.HexId == hId).SignalUpdateRem(data.Substring(4, 2)); //Two Nibble

				SignalList.Single(s => s.HexId == hId).SignalUpdateControls(data.Substring(6, 1)); //One Nibble
				SignalList.Single(s => s.HexId == hId).SignalUpdateAspect(data.Substring(7, 1)); //One Nibble

				SignalList.Single(s => s.HexId == hId).RouteSet = !data.Substring(8, 4).Equals("FFFF");

				//8,4
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}


		}
		public string SignalIdLookup(string data)
		{
			data = 'S' + data.ToUpper();

			if (SignalList.SingleOrDefault(b => b.Number == data) != null)
			{
				var signal = SignalList.Single(b => b.Number == data);
				return signal.HexId;
			}

			return null;
		}

		public void SignalStatusRequest()
		{

			var signalRequest = "";

			foreach (var x in SignalList)
			{
				signalRequest = signalRequest + "iBS" + x.HexId + x.HexId + "|";

			}
			MainMenu.TcpConnection.SendData(signalRequest);
		}

		public void QueryRouteSet(string signal)
		{
			string hId = SignalIdLookup(signal);

			if (SignalList.SingleOrDefault(s => s.HexId == hId) != null)
			{
				
			}

		}
	}
}
