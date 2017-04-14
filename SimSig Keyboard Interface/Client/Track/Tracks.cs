using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimSig_Keyboard_Interface.Client.Track
{
	public class Tracks
	{
		public string HexId { get; set; }
		public string TrackId { get; set; }
		public bool Occupied { get; set; }
		public bool Eng { get; set; }
		public bool TI { get; set; }
		public bool Bet { get; set; }




		public void TrackUpdate(string occupied, string isolation)
		{

			if (occupied == "1") Occupied = true;

			else Occupied = false;



			if (isolation == "0")
			{
				Eng = false;
				TI = false;
				Bet = false;
			}
			if (isolation == "1")
			{
				Eng = true;
				TI = false;
				Bet = false;
			}
			if (isolation == "2")
			{
				Eng = false;
				TI = true;
				Bet = false;
			}
			if (isolation == "3")
			{
				Eng = true;
				TI = true;
				Bet = false;
			}
			if (isolation == "4")
			{
				Eng = true;
				TI = false;
				Bet = true;
			}
			if (isolation == "5")
			{
				Eng = false;
				TI = false;
				Bet = true;
			}


		}

		public void TrackAssignIso(String data)
		{


		}
	} 
}
