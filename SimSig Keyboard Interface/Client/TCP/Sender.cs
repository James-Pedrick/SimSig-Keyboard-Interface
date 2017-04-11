using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace SimSig_Keyboard_Interface.Client.TCP
{
    public sealed partial class TcpClient
    {
        private sealed class Sender
        {
            internal void SendData(string toWrite)
            {
	            byte[] data = Encoding.ASCII.GetBytes(toWrite);
				
				_stream.WriteAsync(data, 0, data.Length);
                // transition the data to the thread and send it...
            }

            internal Sender(NetworkStream stream)
            {
                _stream = stream;
                _thread = new Thread(Run);
                _thread.Start();
            }

            private void Run()
            {

            }

            private NetworkStream _stream;
            private Thread _thread;
        }
    }






}