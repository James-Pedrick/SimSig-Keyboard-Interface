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
	public partial class Shrewsbury : UserControl
	{
		public Shrewsbury()
		{
			InitializeComponent();
		}

		private void Nantwich()
		{
			var swy15 = MainDisplays.MainMenu.Signals.SignalList.SingleOrDefault(s => s.Number == "SNWY15");
			var swy14 = MainDisplays.MainMenu.Signals.SignalList.SingleOrDefault(s => s.Number == "SNWY14");




			var twy1 = MainDisplays.MainMenu.Tracks.TrackList.SingleOrDefault(s => s.TrackId == "TWY1");
			var twy2 = MainDisplays.MainMenu.Tracks.TrackList.SingleOrDefault(s => s.TrackId == "TWY2");
			var twy2929 = MainDisplays.MainMenu.Tracks.TrackList.SingleOrDefault(s => s.TrackId == "TWY2929");
			var twy3 = MainDisplays.MainMenu.Tracks.TrackList.SingleOrDefault(s => s.TrackId == "TWY3");
			var twy4 = MainDisplays.MainMenu.Tracks.TrackList.SingleOrDefault(s => s.TrackId == "TWY4");
			var twy4A = MainDisplays.MainMenu.Tracks.TrackList.SingleOrDefault(s => s.TrackId == "TWY4A");
			var twy5 = MainDisplays.MainMenu.Tracks.TrackList.SingleOrDefault(s => s.TrackId == "TWY5");
			var twy6 = MainDisplays.MainMenu.Tracks.TrackList.SingleOrDefault(s => s.TrackId == "TWY6");

			var bwy15 = MainDisplays.MainMenu.Berths.BerthList.SingleOrDefault(s => s.BerthContent == "BWY15");




			if (bwy15 != null && bwy15.BerthContent != null && bwy15.BerthContent != "    ")
			{
				if (bwy15.BerthContent == "    " || bwy15.BerthContent == null)
				{
					if (twy3.Occupied == false && twy2.Occupied == false &&
					    swy14.RouteSet == false && swy15.RouteSet == false)
					{
						SendPrep.RouteSet("WY14", "WY15");
						SendPrep.RouteSet("WY15", "WH3");
					}
				}
				if (twy5.Occupied == true && twy3.Occupied == false && twy2.Occupied == false)
					SendPrep.RouteSet("WY14", "WY15");

			}

			


		}
	}
}
