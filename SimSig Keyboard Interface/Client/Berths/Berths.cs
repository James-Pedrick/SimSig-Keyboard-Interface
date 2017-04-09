using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimSig_Keyboard_Interface.Client.Berths
{
	public class Berths 
	{
		public string HexId { get; set; }
		public string BerthId { get; set; }
		public string BerthContent { get; set; }


		public static void DataUpdate(string data)
		{
			var hexId = data.Substring(0, 4);
			var berthContent = data.Substring(4, 4);



		}



	}
}
