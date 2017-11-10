using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using SimSig_Keyboard_Interface.User_Interface.MainDisplays;


namespace SimSig_Keyboard_Interface.NrData
{
	public static class NrDataProcess
	{
		private const string BerthStpMsg = "\"msg_type\":\"CA\"";
		private const string BerthCanMsg = "\"msg_type\":\"CB\"";
		private const string BerthIntMsg = "\"msg_type\":\"CC\"";

		private const string AreaName = "\"area_id\":\"BN\"";






		public static void DataProcess(string data)
		{

			data = data.TrimEnd(']').TrimStart('[');

			string[] elementStrings = Regex.Split(data, "},{");


			foreach (string element in elementStrings)
			{
				if (element.Contains(BerthStpMsg)) BerthStp(element);
				if (element.Contains(BerthCanMsg)) BerthCan(element);
				if (element.Contains(BerthIntMsg)) BerthInt(element);
			}
		}

		private static void BerthStp(string data)
		{
			//	{ "CA_MSG":{ "time":"1349696911000", "area_id":"SK", "msg_type":"CA", "from":"3647", "to":"3649", "descr":"1F42"} }

			string time;


			string[] berthElement = data.Split(',');

			var areaId = berthElement[2].Substring(11).TrimEnd('\"');
			var from = berthElement[4].Substring(8, 4);
			var to = berthElement[0].Substring(16, 4);
			var descr = berthElement[5].Substring(9, 4);


			Console.WriteLine(areaId + ' ' + from + ' ' + to + ' ' + descr);

			if (User_Interface.MainDisplays.MainMenu.TcpConnected.Equals(true))
			{
				Data.SendPrep.InterposeCancel('B' + from);
				Data.SendPrep.Interpose('B' + to, descr);
			}

			NrSave(areaId, from, to, descr);

		}

		private static void BerthCan(string data)
		{
			//	{"CB_MSG":{"time":"1349696911000", "area_id":"G1", "msg_type":"CB", "from":"G669", "descr":"2J01"}}

			string[] berthElement = data.Split(',');

			var areaId = berthElement[1].Substring(11).TrimEnd('\"');
			var from = berthElement[3].Substring(8, 4);

			if (User_Interface.MainDisplays.MainMenu.TcpConnected.Equals(true))
				Data.SendPrep.InterposeCancel('B' + from);

			Console.WriteLine(areaId + ' ' + from);
			NrSave(areaId, from, null, null);
		}

		private static void BerthInt(string data)
		{
			//"\"CC_MSG\":{\"to\":\"0166\",\"time\":\"1499783943000\",\"area_id\":\"BN\",\"msg_type\":\"CC\",\"descr\":\"1K21\"}"

			string[] berthElement = data.Split(',');

			var areaId = berthElement[2].Substring(11).TrimEnd('\"');
			var to = berthElement[0].Substring(16, 4);
			var descr = berthElement[4].Substring(9, 4);

			if (User_Interface.MainDisplays.MainMenu.TcpConnected.Equals(true))
				Data.SendPrep.Interpose('B' + to, descr);

			Console.WriteLine(areaId + ' ' + "     " + to + " " + descr);
			NrSave(areaId, null, to, descr);
		}


		private static void NrSave(string areaId, string from, string to, string descr)
		{
			using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\\nr.csv", true))
			{
				file.WriteLine(areaId + ',' + from + ',' + to + ',' + descr);
			}
		}

	}
}
