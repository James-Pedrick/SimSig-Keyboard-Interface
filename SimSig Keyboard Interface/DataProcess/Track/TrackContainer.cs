using System;
using System.ComponentModel;
using System.Linq;

namespace SimSig_Keyboard_Interface.DataProcess.Track
{
	public class TrackContainer
	{

		public BindingList<Tracks> TrackList = new BindingList<Tracks>();
		public BindingList<Ulcs> UlcList = new BindingList<Ulcs>();
		public BindingList<Overlaps>OverlapList = new BindingList<Overlaps>();

		private static Tracks _trackDataUpdate = new Tracks();


		public void AddTrackXml(string hId, string tId)
		{
			if (TrackList.SingleOrDefault(t => t.HexId == hId) == null)
				TrackList.Add(new Tracks { HexId = hId, TrackId = tId });
			else
				TrackList.Single(s => s.HexId == hId).TrackId = tId;


		}

		public void AddTrackTcp(string data)
		{
			string hId = data.Substring(0, 4);
			string occipied = data.Substring(4, 1);
			string isolations = data.Substring(5, 1);


			if (TrackList.SingleOrDefault(t => t.HexId == hId) == null)
				TrackList.Add(new Tracks { HexId = hId });



			TrackList.Single(t => t.HexId == hId).TrackUpdate(occipied, isolations);
		}

		public void AddUlcXml(string hid, string ulc, string ends)
		{
			if (UlcList.SingleOrDefault(u => u.HexId == hid) == null)
				UlcList.Add(new Ulcs { HexId = hid, Ulc = ulc, Ends = ends });
			else
				UlcList.Single(u => u.HexId == hid).Ulc = ulc;
		}

		public void AddUlcTcp(string data)
		{
			string hId = data.Substring(0,4);
			string overLap = data.Substring(4, 4);
			string subSet = data.Substring(4, data.Length - 4);

			string overlapName = OverlapLookup(overLap);

			bool isOverlap = overlapName != null;



			if (UlcList.SingleOrDefault(u => u.HexId == data.Substring(0,4)) == null)
				UlcList.Add(new Ulcs { HexId = hId });

			UlcList.Single(u => u.HexId == hId).UlcUpdate(hId, subSet, isOverlap, overlapName);
			

				
		}

		public void AddOverlapXml(string hid, string overlapName)
		{
			if (OverlapList.SingleOrDefault(u => u.HexId == hid) == null)
				OverlapList.Add(new Overlaps { HexId = hid, Name = overlapName});
			else
				OverlapList.Single(u => u.HexId == hid).Name = overlapName;

		}

		private string OverlapLookup(string hid)
		{

			if (OverlapList.SingleOrDefault(t => t.HexId == hid) != null)
			{
				var z = OverlapList.Single(t => t.HexId == hid);
				return z.Name;
			}

			return null;
			
		}

	}
}
