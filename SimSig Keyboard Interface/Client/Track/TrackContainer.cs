using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimSig_Keyboard_Interface.Client.Track
{
	public class TrackContainer
	{

		public static BindingList<Tracks> TrackList = new BindingList<Tracks>();


		private static Tracks _trackDataUpdate = new Tracks();


		public void AddTrackXml(string hId, string tId)
		{
			if (TrackList.SingleOrDefault(t => t.HexId == hId) == null)
				TrackList.Add(new Tracks {HexId = hId, TrackId = tId});
			else
				TrackList.Single(s => s.HexId == hId).TrackId = tId;


		}
		



	}
}
