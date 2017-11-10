using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;
using SimSig_Keyboard_Interface.Data;
using SimSig_Keyboard_Interface.DataProcess.Berths;
using SimSig_Keyboard_Interface.DataProcess.Signals;
using SimSig_Keyboard_Interface.User_Interface.MainDisplays;
using static SimSig_Keyboard_Interface.User_Interface.MainDisplays.MainMenu;

namespace SimSig_Keyboard_Interface.SimSpecific.NorthWalesCoast
{
	public static class Ars
	{


		public static void NwcArs()
		{

			while (true)
			{

				RockcliffHall();


				Thread.Sleep(100);

			}
			//	if()

		}

		private static void RockcliffHall()
		{
			var srh8 = MainMenu.Signals.SignalList.SingleOrDefault(s => s.Number == "SRH8");
			var srh1 = MainMenu.Signals.SignalList.SingleOrDefault(s => s.Number == "SRH1");

			var b0rh8 = MainMenu.Berths.BerthList.SingleOrDefault(b => b.BerthId == "B0RH8");
			var b0rh1 = MainMenu.Berths.BerthList.SingleOrDefault(b => b.BerthId == "B0RH1");
			var bc213 = MainMenu.Berths.BerthList.SingleOrDefault(b => b.BerthId == "BC213");

			var trh8S = MainMenu.Tracks.TrackList.SingleOrDefault(t => t.TrackId == "TRH8S");
			var trh8 = MainMenu.Tracks.TrackList.SingleOrDefault(t => t.TrackId == "TRH8");
			var trh8A = MainMenu.Tracks.TrackList.SingleOrDefault(t => t.TrackId == "TRH8A");
			var trh9 = MainMenu.Tracks.TrackList.SingleOrDefault(t => t.TrackId == "TRH9");

			var prh101 = MainMenu.Points.PointList.SingleOrDefault(p => p.Number == "PRH101A");
			var prh102 = MainMenu.Points.PointList.SingleOrDefault(p => p.Number == "PRH102A");


			var trh1b = MainMenu.Tracks.TrackList.SingleOrDefault(t => t.TrackId == "TRH1B");
			var trh1a = MainMenu.Tracks.TrackList.SingleOrDefault(t => t.TrackId == "TRH1A");
			var trh2 = MainMenu.Tracks.TrackList.SingleOrDefault(t => t.TrackId == "TRH2");
			



			if ((prh101 != null && prh102 != null) && prh101.Kr != true && prh102.Kr != true)
			{
				if (b0rh8 != null && (b0rh8.BerthContent != null && b0rh8.BerthContent != "    "))
				{
					if (srh8 != null && srh8.RouteSet == false)
						if (trh8 != null && trh8.Occupied == false && trh8A != null && trh8A.Occupied == false && trh8S != null &&
							trh8S.Occupied == false)
							SendPrep.RouteSet("RH8", "CR214");
				}

				if (b0rh1 != null && (b0rh1.BerthContent != null && b0rh1.BerthContent != "    "))
					if (srh1 != null && srh1.RouteSet == false)
						if (trh1b.Occupied == false && trh1a.Occupied == false && trh2.Occupied == false)
							SendPrep.RouteSet("RH1","RH3");

			}




		}


		private static void PrestatynUp()
		{

		}

	}
}
