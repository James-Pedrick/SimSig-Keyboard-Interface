using System;

namespace SimSig_Keyboard_Interface.DataProcess.Track
{
	public class Tracks
	{
		public string HexId { get; set; }
		public string TrackId { get; set; }
		public bool Occupied { get; set; }
		public bool Eng { get; set; }
		public bool Ti { get; set; }
		public bool Bet { get; set; }




		public void TrackUpdate(string occupied, string isolation)
		{

			if (occupied == "1") Occupied = true;

			else Occupied = false;



			if (isolation == "0")
			{
				Eng = false;
				Ti = false;
				Bet = false;
			}
			if (isolation == "1")
			{
				Eng = true;
				Ti = false;
				Bet = false;
			}
			if (isolation == "2")
			{
				Eng = false;
				Ti = true;
				Bet = false;
			}
			if (isolation == "3")
			{
				Eng = true;
				Ti = true;
				Bet = false;
			}
			if (isolation == "4")
			{
				Eng = true;
				Ti = false;
				Bet = true;
			}
			if (isolation == "5")
			{
				Eng = false;
				Ti = false;
				Bet = true;
			}


		}

		public void TrackAssignIso(String data)
		{


		}
	} 
}
