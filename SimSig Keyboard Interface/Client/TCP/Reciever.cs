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
            internal event EventHandler<DataReceivedEventArgs> DataReceived;

            internal Receiver(NetworkStream stream)
            {
                _stream = stream;
                _thread = new Thread(Run);
                _thread.Start();
            }

            private void Run()
            {
                while (true)
                    {
                    var buffer = new byte[1024];

                    int bytesRead;

                    var charBuffer = new char[1024];

                    string msg = "";

                    // Get back on the GUI thread - we need to modify the tbxLog control, which can only be done from the GUI thread.
                    while ((bytesRead = _stream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        var charsRead = Encoding.ASCII.GetChars(buffer, 0, bytesRead, charBuffer, 0);

                        msg += new string(charBuffer, 0, charsRead);



						Console.WriteLine(msg);
	                    msg = "";
                    }
                    Console.WriteLine(msg);
                    Thread.Sleep(1);
					
                }
            }

            private NetworkStream _stream;
            private Thread _thread;
        }

	    private void ReceivedUpdate(string msg)
	    {

		    
	    }


    }





}