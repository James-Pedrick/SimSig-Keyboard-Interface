using System.ComponentModel;
using System.Linq;

namespace SimSig_Keyboard_Interface.DataProcess.Flags
{
	public class FlagContainer
	{
		public BindingList<Flags> FlagList = new BindingList<Flags>();


		public void AddFlagXml(string hId, string flagId)
		{
			if (FlagList.SingleOrDefault(f => f.HexId == hId) == null)
				FlagList.Add(new Flags {HexId = hId, FlagId = flagId});
			else
				FlagList.Single(f => f.HexId == hId).FlagId = flagId;
		}

		public void AddFlagTcp(string data)
		{
			var hId = data.Substring(0, 4);

			var flagState = data.Substring(4, 2);


			if(FlagList.SingleOrDefault(f => f.HexId == hId) == null)
				FlagList.Add(new Flags{HexId = hId});

			if (flagState == "00") FlagList.Single(f => f.HexId == hId).FlagActive = false;
			if (flagState == "01") FlagList.Single(f => f.HexId == hId).FlagActive = true;


		}




	}
}
