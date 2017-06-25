
using System.Linq;
using SimSig_Keyboard_Interface.User_Interface;
using System.Threading;
using SimSig_Keyboard_Interface.User_Interface.MainDisplays;

namespace SimSig_Keyboard_Interface.Data
{

	public static class SendPrep
	{


		public static void Interpose(string berth, string descrition)
		{
			var berthHex = MainMenu.Berths.BerthHIdLookup(berth);

			MainMenu.TcpConnection.SendData(@"BB" + berthHex + descrition + "|");
		}

		public static void InterposeCancel(string berth)
		{
			var berthHex = MainMenu.Berths.BerthHIdLookup(berth);
			MainMenu.TcpConnection.SendData(@"BC" + berthHex+ "|");
		}

		public static void RouteSet(string entry, string exit)
		{
			var entrySigHex = MainMenu.Signals.SignalIdLookup(entry);
			var exitSigHex = MainMenu.Signals.SignalIdLookup(exit);

			if (entrySigHex == null || exitSigHex == null) return;

			MainMenu.TcpConnection.SendData(@"SA" + entrySigHex + exitSigHex + @"00" + entrySigHex + @"----|");

		}

		public static void RouteCan(string entry)
		{
			var entrySigHex = MainMenu.Signals.SignalIdLookup(entry);
			MainMenu.TcpConnection.SendData(@"zD" + entrySigHex + "|");

		}

		public static void SigAutoSet(string entry)
		{
			var entrySigHex = MainMenu.Signals.SignalIdLookup(entry);
			MainMenu.TcpConnection.SendData(@"SF" + entrySigHex + "|");
		}

		public static void SigAutoCan(string entry)
		{
			var entrySigHex = MainMenu.Signals.SignalIdLookup(entry);
			MainMenu.TcpConnection.SendData(@"SG" + entrySigHex + "|");
		}

		public static void SigReplacementCan(string entry)
		{
			var entrySigHex = MainMenu.Signals.SignalIdLookup(entry);
			MainMenu.TcpConnection.SendData(@"SP" + entrySigHex + "|");
		}

		public static void SigReplacementSet(string entry)
		{
			var entrySigHex = MainMenu.Signals.SignalIdLookup(entry);
			MainMenu.TcpConnection.SendData(@"SQ" + entrySigHex + "|");
		}

		public static void PointsKeyN(string points)
		{
			Thread keyPointsNormal = new Thread(() =>
				{

					string pointId = MainMenu.Points.PointLookup(points);
					if (pointId == null) return;

					if (MainMenu.Points.PointList.SingleOrDefault(p => p.HexId == pointId) == null) return;

					//(PointList.SingleOrDefault(b => b.Number == data) != null

					while (MainMenu.Points.PointsKn(pointId) == false)
					{
						while (MainMenu.Points.PointUpdated(pointId) == false)
							Thread.Sleep(10);
						Thread.Sleep(10);
						if (MainMenu.Points.PointsKn(pointId))
							return;

						if (MainMenu.Points.PointsKn(pointId) == false && MainMenu.Points.PointUpdated(pointId))
						{
							MainMenu.TcpConnection.SendData(@"PB" + pointId + @"|");

							MainMenu.Points.PointList.Single(b => b.HexId == pointId).Updated = false;
						}
					}
				}
			);
			keyPointsNormal.Start();
		}

		public static void PointsKeyR(string points)
		{

			Thread keyPointsReverse = new Thread(() =>
				{

					string pointId = MainMenu.Points.PointLookup(points);
					if (pointId == null) return;

					if (MainMenu.Points.PointList.SingleOrDefault(p => p.HexId == pointId) == null) return;

					//(PointList.SingleOrDefault(b => b.Number == data) != null

					while (MainMenu.Points.PointsKr(pointId) == false)
					{
						while (MainMenu.Points.PointUpdated(pointId) == false)
							Thread.Sleep(10);
						Thread.Sleep(10);
						if (MainMenu.Points.PointsKr(pointId))
							return;

						if (MainMenu.Points.PointsKr(pointId) == false && MainMenu.Points.PointUpdated(pointId))
						{
							MainMenu.TcpConnection.SendData(@"PC" + pointId + @"|");

							MainMenu.Points.PointList.Single(b => b.HexId == pointId).Updated = false;
						}
					}
				}
			);
			keyPointsReverse.Start();
		}

		public static void PointsKeyF(string points)
		{
			Thread keyPointsFree = new Thread(() =>
				{

					string pointId = MainMenu.Points.PointLookup(points);
					if (pointId == null) return;




					if (MainMenu.Points.PointList.SingleOrDefault(p => p.HexId == pointId) == null) return;

					//(PointList.SingleOrDefault(b => b.Number == data) != null

					while (MainMenu.Points.PointsKn(pointId) || MainMenu.Points.PointsKr(pointId))
					{
						while (MainMenu.Points.PointUpdated(pointId) == false)
							Thread.Sleep(10);
						Thread.Sleep(10);
						if (MainMenu.Points.PointsKn(pointId) == false && MainMenu.Points.PointsKr(pointId) == false)
							return;

						if ((MainMenu.Points.PointsKn(pointId) || MainMenu.Points.PointsKr(pointId)) &&
						    MainMenu.Points.PointUpdated(pointId))
						{
							MainMenu.TcpConnection.SendData(@"PB" + pointId + @"|");

							MainMenu.Points.PointList.Single(b => b.HexId == pointId).Updated = false;
						}
					}
				}
			);
			keyPointsFree.Start();
		}







}
}
