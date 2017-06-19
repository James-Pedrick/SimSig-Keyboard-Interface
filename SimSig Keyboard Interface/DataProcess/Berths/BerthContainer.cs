using System.ComponentModel;
using System.Linq;
using SimSig_Keyboard_Interface.User_Interface;

namespace SimSig_Keyboard_Interface.DataProcess.Berths
{
	public class BerthContainer
	{
		public readonly BindingList<Berths> BerthList = new BindingList<Berths>();



		public void AddBerthXml(string hId, string bId)
		{
			if (BerthList.SingleOrDefault(b => b.HexId == hId) == null)
			{
				BerthList.Add(new Berths { HexId = hId, BerthId = bId, WatchBerth = false });
			}
			else
			{
				BerthList.Single(b => b.HexId == hId).BerthId = bId;
			}
		}

		public void AddBerthTcp(string hId, string bContent)
		{
			if (BerthList.SingleOrDefault(b => b.HexId == hId) == null)
				BerthList.Add(new Berths {HexId = hId, BerthContent = bContent, WatchBerth = false});
			else
				BerthList.Single(b => b.HexId == hId).BerthContent = bContent;


			if (BerthList.SingleOrDefault(b => b.HexId == hId && b.WatchBerth) == null) return;

			var z = BerthList.Single(b => b.HexId == hId).BerthContent;
			if (z != "    ")
				MainMenu.Connection.SendData("tO " + z + "|");
		}

		public void BerthWatch(string berthId, bool watchState)
		{
			if (BerthList.Single(b => b.BerthId == berthId) != null)
				BerthList.Single(b => b.BerthId == berthId).WatchBerth = watchState;
		}

		public void DataUpdateTcp(string data)
		{
			var hexId = data.Substring(0, 4);
			var berthContent = data.Substring(4, 4);
			
			AddBerthTcp(hexId, berthContent);
		}

		public string BerthHIdLookup(string data)
		{
			data = data.ToUpper();

			if (BerthList.SingleOrDefault(b => b.BerthId == data) != null)
			{
				var berth = BerthList.Single(b => b.BerthId == data);
				return berth.HexId;
			}

			return null;
		}

		public void BerthStatusRequest()
		{
			foreach (var x in BerthList)
			{
				var berthRequest = "iBB" + x.HexId + x.HexId + "|";

				MainMenu.Connection.SendData(berthRequest);
			}
		}

	}
}
