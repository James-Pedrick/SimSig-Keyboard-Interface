using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace SimSig_Keyboard_Interface.DataProcess.Slots
{
	public class SlotContainer
	{
		public BindingList<Slots> SlotList = new BindingList<Slots>();

		private Slots _slotDataUpdate = new Slots();


		public void AddSlotXml(string hId, string sNum)
		{
			if (SlotList.SingleOrDefault(s => s.HexId == hId) == null)
				SlotList.Add(new Slots {HexId = hId, Number = sNum});
			else
				SlotList.Single(s => s.HexId == hId).Number = sNum;
		}




	}
}
