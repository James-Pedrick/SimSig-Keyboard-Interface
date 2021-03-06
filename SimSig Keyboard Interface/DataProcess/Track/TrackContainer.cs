﻿using System.ComponentModel;
using System.Linq;

namespace SimSig_Keyboard_Interface.DataProcess.Track
{
	public class TrackContainer
	{

		public BindingList<Tracks> TrackList = new BindingList<Tracks>();


		private static Tracks _trackDataUpdate = new Tracks();


		public void AddTrackXml(string hId, string tId)
		{
			if (TrackList.SingleOrDefault(t => t.HexId == hId) == null)
				TrackList.Add(new Tracks {HexId = hId, TrackId = tId});
			else
				TrackList.Single(s => s.HexId == hId).TrackId = tId;


		}

		public void AddTrackTcp(string data)
		{
			string hId = data.Substring(0,4);
			string occipied = data.Substring(4, 1);
			string isolations = data.Substring(5, 1);


			if (TrackList.SingleOrDefault(t => t.HexId == hId) == null)
				TrackList.Add(new Tracks {HexId = hId});



			TrackList.Single(t => t.HexId == hId).TrackUpdate(occipied,isolations);




		}



	}
}
