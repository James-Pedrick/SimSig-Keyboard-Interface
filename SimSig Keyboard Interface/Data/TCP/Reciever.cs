using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace SimSig_Keyboard_Interface.Data.TCP
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
                    var buffer = new byte[2048];

                    int bytesRead;

                    var charBuffer = new char[2048];

                
					
                    while ((bytesRead = _stream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        var charsRead = Encoding.ASCII.GetChars(buffer, 0, bytesRead, charBuffer, 0);

                        string msg = new string(charBuffer, 0, charsRead);
						
                        MsgEventArgs m = new MsgEventArgs() { Msg = msg };
                        OnDataReceived(this,m);

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

