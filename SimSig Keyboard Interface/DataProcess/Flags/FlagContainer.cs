using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

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


	}
}
