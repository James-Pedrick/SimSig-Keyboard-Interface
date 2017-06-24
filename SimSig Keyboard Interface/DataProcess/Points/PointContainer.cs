using System.ComponentModel;
using System.Linq;
using SimSig_Keyboard_Interface.Comms.TCP;
using SimSig_Keyboard_Interface.User_Interface.MainDisplays;

namespace SimSig_Keyboard_Interface.DataProcess.Points
{
	public class PointContainer
	{
		public BindingList<Points> PointList = new BindingList<Points>();




		private static Points _points = new Points();


		public void AddPointTcp(string data)
		{
			var hId = data.Substring(0, 4);
			var pointStates = data.Substring(4, 3);

			if (PointList.SingleOrDefault(p => p.HexId == hId) == null)
				PointList.Add(new Points {HexId = hId});

			PointList.Single(p => p.HexId == hId).PointUpdate(pointStates);

		}

		public void AddPointXml(string hId, string pointId)
		{

			if (PointList.SingleOrDefault(b => b.HexId == hId) == null)
				PointList.Add(new Points {HexId = hId, Number = pointId});
			else
				PointList.Single(b => b.HexId == hId).Number = pointId;

		}

		public string PointLookup(string data)
		{

//			data = 'P' + data.ToUpper();

			if (PointList.SingleOrDefault(b => b.Number == data) != null)
			{
				var point = PointList.Single(b => b.Number == data);
				return point.HexId;
			}

			return null;
		}

		public bool PointUpdated(string data)
		{
			if (PointList.SingleOrDefault(p => p.HexId == data) != null)
			{
				var returnVal = PointList.Single(p => p.HexId == data);

				return returnVal.Updated;

			}
			return true; //This line should not be reachable
		}

		public bool PointsKn(string data)
		{
			if (PointList.SingleOrDefault(p => p.HexId == data) != null)
			{
				var returnVal = PointList.Single(p => p.HexId == data);

				return returnVal.Kn;

			}
			return true; //This line should not be reachable

		}

		public bool PointsKr(string data)
		{
			if (PointList.SingleOrDefault(p => p.HexId == data) != null)
			{
				var returnVal = PointList.Single(p => p.HexId == data);

				return returnVal.Kr;

			}
			return true; //This line should not be reachable

		}

		public void PointStatusConnectionRequest()
		{
			foreach (var x in PointList)
			{
				var pointRequest = "iBP" + x.HexId + x.HexId + "|";

				MainMenu.TcpConnection.SendData(pointRequest);
			}
		}

		public bool[] PointStatusKeyRequest(string pointId)
		{

			{
				if (PointList.SingleOrDefault(p => p.Number == pointId) != null)
				{
					var itemLookup = PointList.Single(p => p.Number == pointId);

					bool[] returnval =
					{
						false,
						itemLookup.Cn, //1
						itemLookup.Cr, //2
						itemLookup.Dn, //3
						itemLookup.Dr, //4
						itemLookup.Fn, //5
						itemLookup.Fr, //6
						itemLookup.Kn, //7
						itemLookup.Kr, //8
						itemLookup.Lock, //9
						itemLookup.Iso //10
					};

					return returnval;



				}

				bool[] error = {true};
				return error; //This line should not be reachable
			}
		}
	}
}
