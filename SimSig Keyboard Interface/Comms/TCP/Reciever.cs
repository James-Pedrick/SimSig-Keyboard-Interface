using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace SimSig_Keyboard_Interface.Comms.TCP
{
    public sealed partial class TcpClient
    {
        private sealed class Receiver
        {
            internal event EventHandler<MsgEventArgs> DataReceived;

			internal Receiver(NetworkStream stream)
			{
				_stream = stream;
				var thread = new Thread(Run);
				thread.Start();
			}

            private void Run()
            {
                try
                {
                    var buffer = new byte[30];

                    int bytesRead;

                    var charBuffer = new char[30];

                    string temp = "";
					
                    while ((bytesRead = _stream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        var charsRead = Encoding.ASCII.GetChars(buffer, 0, bytesRead, charBuffer, 0);

                        string msg = new string(charBuffer, 0, charsRead);
                        if (temp != "")
                        {
                            msg = temp + msg;
                            temp = "";
                        }
                        
                        string[] receivedStrings = msg.Split('|');
                        if (charBuffer[charsRead - 1] != '|')
                        {
                            temp = receivedStrings[receivedStrings.Length - 1];
                            receivedStrings[receivedStrings.Length - 1] = null;
                        }
                        foreach (string element in receivedStrings)
                        {
                            
                            if (element != null)
                            {
                                MsgEventArgs m = new MsgEventArgs() { Msg = element };
                                OnDataReceived(this, m);

                            }
                        }

                        Thread.Sleep(20);
                    }
					
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            private void OnDataReceived(object sender, MsgEventArgs e)
            {
                var handler = DataReceived;
				
                if (handler != null)  DataReceived?.Invoke(this, e); // re-raise event

				
                
            }
            private NetworkStream _stream;
        }


	}


}

