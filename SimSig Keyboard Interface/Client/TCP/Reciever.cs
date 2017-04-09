using System;
using System.Net.Sockets;
using System.Diagnostics;
using System.Threading;
using System.Text;

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
                while (true)
                    {
                    var buffer = new byte[1024];

                    int bytesRead;
                    // Decoder is useful in properly handling multi-byte character encodings - it will only emit "complete" characters, so we're not going to
                    // mangle multi-byte characters by accident. Do not use something like StreamReader - it would work for our exact scenario, but it breaks down
                    // on more complicated streams.

                    var charBuffer = new char[1024];

                    string msg = "";

                    // Get back on the GUI thread - we need to modify the tbxLog control, which can only be done from the GUI thread.
                    while ((bytesRead = _stream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        var charsRead = Encoding.ASCII.GetChars(buffer, 0, bytesRead, charBuffer, 0);

                        msg += new string(charBuffer, 0, charsRead));
                    }

                }
            }

            private NetworkStream _stream;
            private Thread _thread;
        }
    }





}