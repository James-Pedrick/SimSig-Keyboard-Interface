using System.ComponentModel;
using System.Linq;

namespace SimSig_Keyboard_Interface.DataProcess.Calls
{
	public class CallContainer
	{
		public BindingList<Calls> CallList = new BindingList<Calls>();



		private static Calls _calls = new Calls();


		public void NewIncomingCall(string data)
		{
			string[] responses = data.Split('$');

			responses[0] = null;


			string[] message = data.Split('\\');



			CallList.Add(new Calls {
				CallNumber = message[0].Substring(2),
				CallActive = true,
				CallerName = message[1],
				CallerMessage = message[2],
				CallTime = message[3],
				CallResponses = responses,

				
			});
		}

		public void EndIncomingCall(string data)
		{
			string[] message = data.Split('\\');

			string callNumber = message[0];

			callNumber = callNumber.Substring(2);


			if (CallList.SingleOrDefault(p => p.CallNumber == callNumber) != null)
				CallList.Remove(CallList.Single(c => c.CallNumber == callNumber));
		}



	}
}
