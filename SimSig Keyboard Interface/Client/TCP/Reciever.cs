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


	}


}

