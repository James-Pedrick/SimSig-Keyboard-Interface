using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimSig_Keyboard_Interface.User_Interface;
using System.Threading;

namespace SimSig_Keyboard_Interface.Data
{

	class SendPrep
	{


		public static void Interpose(string berth, string descrition)
		{
			var berthHex = MainMenu._berths.BerthHIdLookup(berth);

			MainMenu.Connection.SendData(@"BB" + berthHex + berth + "|");
		}

		public static void InterposeCancel(string berth)
		{
			var berthHex = MainMenu._berths.BerthHIdLookup(berth);
			MainMenu.Connection.SendData(@"BC" + berth + "|");
		}

		public static void RouteSet(string entry, string exit)
		{
			var entrySigHex = MainMenu._signals.SignalIdLookup(entry);
			var exitSigHex = MainMenu._signals.SignalIdLookup(exit);

			if (entrySigHex == null || exitSigHex == null) return;

			MainMenu.Connection.SendData(@"SA" + entrySigHex + exitSigHex + @"00" + entrySigHex + @"----|");

		}

		public static void RouteCan(string entry)
		{
			var entrySigHex = MainMenu._signals.SignalIdLookup(entry);
			MainMenu.Connection.SendData(@"zD" + entrySigHex + "|");

		}

		public static void SigAutoSet(string entry)
		{
			var entrySigHex = MainMenu._signals.SignalIdLookup(entry);
			MainMenu.Connection.SendData(@"SF" + entrySigHex + "|");
		}

		public static void SigAutoCan(string entry)
		{
			var entrySigHex = MainMenu._signals.SignalIdLookup(entry);
			MainMenu.Connection.SendData(@"SG" + entrySigHex + "|");
		}

		public static void SigReplacementCan(string entry)
		{
			var entrySigHex = MainMenu._signals.SignalIdLookup(entry);
			MainMenu.Connection.SendData(@"SP" + entrySigHex + "|");
		}

		public static void SigReplacementSet(string entry)
		{
			var entrySigHex = MainMenu._signals.SignalIdLookup(entry);
			MainMenu.Connection.SendData(@"SQ" + entrySigHex + "|");
		}

		public static void PointsKeyN(string points)
		{
			Thread keyPointsNormal = new Thread(() =>
				{

					string pointId = MainMenu._points.PointLookup(points);
					if (pointId == null) return;

					if (MainMenu._points.PointList.SingleOrDefault(p => p.HexId == pointId) == null) return;

					//(PointList.SingleOrDefault(b => b.Number == data) != null

					while (MainMenu._points.PointsKn(pointId) == false)
					{
						while (MainMenu._points.PointUpdated(pointId) == false)
							Thread.Sleep(10);
						Thread.Sleep(10);
						if (MainMenu._points.PointsKn(pointId))
							return;

						if (MainMenu._points.PointsKn(pointId) == false && MainMenu._points.PointUpdated(pointId))
						{
							MainMenu.Connection.SendData(@"PB" + pointId + @"|");

							MainMenu._points.PointList.Single(b => b.HexId == pointId).Updated = false;
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

					string pointId = MainMenu._points.PointLookup(points);
					if (pointId == null) return;

					if (MainMenu._points.PointList.SingleOrDefault(p => p.HexId == pointId) == null) return;

					//(PointList.SingleOrDefault(b => b.Number == data) != null

					while (MainMenu._points.PointsKr(pointId) == false)
					{
						while (MainMenu._points.PointUpdated(pointId) == false)
							Thread.Sleep(10);
						Thread.Sleep(10);
						if (MainMenu._points.PointsKr(pointId))
							return;

						if (MainMenu._points.PointsKr(pointId) == false && MainMenu._points.PointUpdated(pointId))
						{
							MainMenu.Connection.SendData(@"PC" + pointId + @"|");

							MainMenu._points.PointList.Single(b => b.HexId == pointId).Updated = false;
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

					string pointId = MainMenu._points.PointLookup(points);
					if (pointId == null) return;




					if (MainMenu._points.PointList.SingleOrDefault(p => p.HexId == pointId) == null) return;

					//(PointList.SingleOrDefault(b => b.Number == data) != null

					while (MainMenu._points.PointsKn(pointId) || MainMenu._points.PointsKr(pointId))
					{
						while (MainMenu._points.PointUpdated(pointId) == false)
							Thread.Sleep(10);
						Thread.Sleep(10);
						if (MainMenu._points.PointsKn(pointId) == false && MainMenu._points.PointsKr(pointId) == false)
							return;

						if ((MainMenu._points.PointsKn(pointId) || MainMenu._points.PointsKr(pointId)) &&
						    MainMenu._points.PointUpdated(pointId))
						{
							MainMenu.Connection.SendData(@"PB" + pointId + @"|");

							MainMenu._points.PointList.Single(b => b.HexId == pointId).Updated = false;
						}
					}
				}
			);
			keyPointsFree.Start();
		}







}
}
