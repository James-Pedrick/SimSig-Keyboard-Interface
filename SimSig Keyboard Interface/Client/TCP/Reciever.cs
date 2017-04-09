using System;
using System.Net.Sockets;
using System.Diagnostics;
using System.Threading;
using System.Text;

namespace SimSig_Keyboard_Interface.Client.TCP
{
    public sealed partial class TcpClient
    {
        private sealed class Receiver
        {
            internal event EventHandler<MsgEventArgs> DataReceived;

			internal Receiver(NetworkStream stream)
			{
				_stream = stream;
				_thread = new Thread(Run);
				_thread.Start();
			}

            private void Run()
            {
                try
                {
                    var buffer = new byte[2048];

                    int bytesRead;

                    var charBuffer = new char[2048];

                    string msg = "";

                   
                    while ((bytesRead = _stream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        var charsRead = Encoding.ASCII.GetChars(buffer, 0, bytesRead, charBuffer, 0);

                        msg = new string(charBuffer, 0, charsRead);

						Console.WriteLine(msg);
                        MsgEventArgs m = new MsgEventArgs() { Msg = msg };
                        OnDataReceived(this,m);

                        Thread.Sleep(20);

                    }
					
                }
                catch
                {
                    throw;
                }
            }
            private void OnDataReceived(object sender, MsgEventArgs e)
            {
                var handler = DataReceived;
                if (handler != null) DataReceived(this, e);  // re-raise event
            }
            private NetworkStream _stream;
            private Thread _thread;
        }

		private static void ReceivedUpdate(string msg)
		{


			string[] receivedStrings = msg.Split('|');


			foreach (string elementString in receivedStrings)
			{
				Console.WriteLine(elementString);

				string element = elementString;

				if (elementString.StartsWith("sB"))
				{
					element = element.Substring(2, 8);
					Berths.Berths.DataUpdate(element);
				}
				

				//			if (element.StartsWith("sB")) { element = element.Substring(2, 8); TDs.Td(element); }							//Berth
				//			if (element.StartsWith("sP")) { element = element.Substring(2, 8); Points.Point_Update_Received(element); }		//Points
				//			if (element.StartsWith("pM")) { Phone.New_Call(element); }														//Phone Call Start
				//			if (element.StartsWith("pO")) { Phone.End_Call(element);}														//Phone Call End
				//			if (element.StartsWith("mA") && !element.StartsWith("mA13"))													//Client Message
				//			if (element.StartsWith("iCB")) { string berthId = element.Substring(3, 4); string berthDescr = element.Substring(11, 4); TDs.Td(berthId + berthDescr);}							//Berth Connection
				//			if (element.StartsWith("iCP")) { string pointId = element.Substring(3, 4); string pointState = element.Substring(11, 3); Points.Point_Update_Received(pointId, pointState);}	//Point Connection

			}

		}

	}


}

