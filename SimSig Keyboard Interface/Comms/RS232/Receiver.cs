using System;
using System.IO.Ports;
using System.Threading;
using SimSig_Keyboard_Interface.Comms.TCP;

namespace SimSig_Keyboard_Interface.Comms.RS232
{
	public sealed partial class SerialClient
	{
        private sealed class Receiver
        {
            internal event EventHandler<MsgEventArgs> DataReceived;

            private SerialPort _stream;
            private Thread thread;


            internal Receiver(SerialPort stream)
            {
                _stream = stream;

                thread = new Thread(Run);
                thread.Start();
            }

            private void Run()
            {
                bool running = true;

                while (running)
                {
                    try
                    {
                        string message = _stream.ReadTo("|");
                        MsgEventArgs m = new MsgEventArgs() { Msg = message };
                        OnDataReceived(this, m);
                    }
                    catch (TimeoutException)
                    {

                    }
                    catch (ThreadInterruptedException)
                    {
                        running = false;
                    }
                    catch (ThreadAbortException)
                    {
                        running = false;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }

            }

            private void OnDataReceived(object sender, MsgEventArgs e)
            {
                var handler = DataReceived;

                if (handler != null) DataReceived?.Invoke(this, e); // re-raise event

            }

            public void Close()
            {
                thread.Interrupt();
                if (thread.Join(TimeSpan.FromSeconds(5)))
                {
                    Console.WriteLine(@"Closing correctly");
                }
                else
                {
                    thread.Abort();
                    Console.WriteLine(@"Force Closed");
                }
            }
        }
	}
}
