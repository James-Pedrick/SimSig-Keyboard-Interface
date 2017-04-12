using System.ComponentModel;
using System.Linq;

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





        public void DataUpdateXml(string data)
        {
            var hexId = data.Substring(0, 4);
            var berthContent = data.Substring(4, 4);

            AddBerthXml(hexId, berthContent);
        }


        public void DataUpdateTcp(string data)
        {
            var hexId = data.Substring(0, 4);
            var berthContent = data.Substring(4, 4);




            AddBerthTcp(hexId, berthContent);
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
