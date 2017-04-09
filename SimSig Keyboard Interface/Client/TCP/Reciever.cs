using System;
using System.Net.Sockets;
using System.Diagnostics;
using System.Threading;

namespace SimSig_Keyboard_Interface.Client.TCP
{
    public sealed partial class TCP_Client
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
                // main thread loop for receiving data...
            }

            private NetworkStream _stream;
            private Thread _thread;
        }
    }





}