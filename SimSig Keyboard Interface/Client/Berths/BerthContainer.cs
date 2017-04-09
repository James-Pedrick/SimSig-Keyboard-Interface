using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SimSig_Keyboard_Interface.Client.Berths
{
	public class BerthContainer 
	{
		public static BindingList<Berths> BerthList = new BindingList<Berths>();



		public void AddBerthXml(string hId, string bId)
		{
			if (BerthList.SingleOrDefault(b => b.HexId == hId) == null)
			{
				BerthList.Add(new Berths{HexId = hId, BerthId = bId });
			}
			else
			{
				BerthList.Single(b => b.HexId == hId).BerthId = bId;
			}
		}

		public void AddBerthTcp(string hId, string bContent)
		{
			if (BerthList.SingleOrDefault(b => b.HexId == hId) == null)
			{
				BerthList.Add(new Berths { HexId = hId, BerthContent = bContent });
			}
			else
			{
				BerthList.Single(b => b.HexId == hId).BerthContent = bContent;
			}
		}






		public string PrintBerths()
		{
			string done = "";

			foreach (Berths x in BerthList)
				done = done + x.HexId.PadRight(6) + x.BerthId + @"\n";


			return done;
		}




	}
}
