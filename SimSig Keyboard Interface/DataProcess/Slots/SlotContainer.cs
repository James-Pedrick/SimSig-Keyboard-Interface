using System.ComponentModel;
using System.Linq;

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
