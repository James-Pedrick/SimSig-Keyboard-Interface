using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimSig_Keyboard_Interface.Client.Calls
{
	class CallContainer
	{
		public static BindingList<Calls> CallList = new BindingList<Calls>();



		private static Calls _calls = new Calls();


		public void NewIncomingCall(string data)
		{
			string[] responses = data.Split('$');
			string[] message = data.Split('\\');

			CallList.Add(new Calls {
				CallNumber = message[0].Substring(2),
				CallActive = true,
				CallerName = message[1],
				CallerMessage = message[2],
				CallTime = message[3],
				CallResponses = responses

			});
		}

		public void EndIncomingCall(string data)
		{
			string[] message = data.Split('\\');

			string callNumber = message[0];

			callNumber = callNumber.Substring(2);


			if (CallList.SingleOrDefault(p => p.CallNumber == callNumber) == null)
				CallList.Add(new Calls { CallNumber = callNumber });

			CallList.Single(p => p.CallNumber == callNumber).CallActive = false;

		}





	}
}
