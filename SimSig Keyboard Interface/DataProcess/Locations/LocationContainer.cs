using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimSig_Keyboard_Interface.DataProcess.Locations
{
	public class LocationContainer
	{

		public readonly BindingList<Locations> LocationList = new BindingList<Locations>();



		public void AddTiploc(string tiploc, string stnCode, string locName)
		{
			if (LocationList.SingleOrDefault(z => z.Tiploc == tiploc) == null)
				LocationList.Add(new Locations {Tiploc = tiploc, StnCode = stnCode, LocName = locName});
			


		}

	}
}
