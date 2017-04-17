
using System.Linq;
using System.ComponentModel;

namespace SimSig_Keyboard_Interface.Client.Points
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
				PointList.Add(new Points { HexId = hId });

			PointList.Single(p => p.HexId == hId).PointUpdate(pointStates);

		}
		
		public void AddPointXml(string hId, string pointId)
		{

			if (PointList.SingleOrDefault(b => b.HexId == hId) == null)
				PointList.Add(new Points { HexId = hId, Number = pointId });
			else
				PointList.Single(b => b.HexId == hId).Number = pointId;

		}

		public string PointLookup(string data)
		{


			data = 'P' + data.ToUpper();

			if (PointList.SingleOrDefault(b => b.Number == data) != null)
			{
				var point = PointList.Single(b => b.Number == data);
				return point.HexId;
			}

			return null;
		}
	}
}
