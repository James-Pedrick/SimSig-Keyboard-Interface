using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimSig_Keyboard_Interface.User_Interface.MainDisplays;
using System.Threading;
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


namespace SimSig_Keyboard_Interface.User_Interface.Ars
{
	public partial class NorthWalesCoast : UserControl
	{
		public NorthWalesCoast()
		{
			InitializeComponent();




			Thread arsThread = new Thread(() =>
			{
				while (true)
				{
					if (rockcliffeHall.Checked.Equals(true)) Rh();

					Thread.Sleep(500);
				}

			});
			arsThread.Start();


		}

		private void Rh()
		{
			var srh1 = MainDisplays.MainMenu.Signals.SignalList.SingleOrDefault(s => s.Number == "SRH1");
			var srh3 = MainDisplays.MainMenu.Signals.SignalList.SingleOrDefault(s => s.Number == "SRH3");
			var srh8 = MainDisplays.MainMenu.Signals.SignalList.SingleOrDefault(s => s.Number == "SRH8");

			var b0rh1 = MainDisplays.MainMenu.Berths.BerthList.SingleOrDefault(b => b.BerthId == "B0RH1");
			var b0rh3 = MainDisplays.MainMenu.Berths.BerthList.SingleOrDefault(b => b.BerthId == "B0RH3");
			var b0rh8 = MainDisplays.MainMenu.Berths.BerthList.SingleOrDefault(b => b.BerthId == "B0RH8");
			var bc213 = MainDisplays.MainMenu.Berths.BerthList.SingleOrDefault(b => b.BerthId == "BC213");

			var trh8S = MainDisplays.MainMenu.Tracks.TrackList.SingleOrDefault(t => t.TrackId == "TRH8S");
			var trh8 = MainDisplays.MainMenu.Tracks.TrackList.SingleOrDefault(t => t.TrackId == "TRH8");
			var trh8A = MainDisplays.MainMenu.Tracks.TrackList.SingleOrDefault(t => t.TrackId == "TRH8A");
			var trh9 = MainDisplays.MainMenu.Tracks.TrackList.SingleOrDefault(t => t.TrackId == "TRH9");

			var prh101 = MainDisplays.MainMenu.Points.PointList.SingleOrDefault(p => p.Number == "PRH101A");
			var prh102 = MainDisplays.MainMenu.Points.PointList.SingleOrDefault(p => p.Number == "PRH102A");


			var trh1b = MainDisplays.MainMenu.Tracks.TrackList.SingleOrDefault(t => t.TrackId == "TRH1B");
			var trh1a = MainDisplays.MainMenu.Tracks.TrackList.SingleOrDefault(t => t.TrackId == "TRH1A");
			var trh2 = MainDisplays.MainMenu.Tracks.TrackList.SingleOrDefault(t => t.TrackId == "TRH2");




			if ((prh101 != null && prh102 != null) && prh101.Kr != true && prh102.Kr != true)
			{
				if (b0rh8?.BerthContent != null && b0rh8.BerthContent != "    ")
				{
					if (srh8 != null && srh8.RouteSet == false)
						if (trh8 != null && trh8.Occupied == false && trh8A != null && trh8A.Occupied == false && trh8S != null &&
							trh8S.Occupied == false)
							SendPrep.RouteSet("RH8", "CR214");
				}

				if (b0rh1?.BerthContent != null && b0rh1.BerthContent != "    ")
					if (srh1 != null && srh1.RouteSet == false)
						if (trh1b.Occupied == false && trh1a.Occupied == false && trh2.Occupied == false)
							SendPrep.RouteSet("RH1", "RH3");

			}

			if(srh3!=null && srh3.RouteSet == false)
				if ((b0rh3.BerthContent != null && b0rh3.BerthContent != "    ") ||
				    (b0rh1.BerthContent != null && b0rh1.BerthContent != "    " && srh1.RouteSet && srh1.Aspect!="R"))
					SendPrep.RouteSet("RH3", "HJ2");




		}





	}
}
