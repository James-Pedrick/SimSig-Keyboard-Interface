using System;
using System.IO.Ports;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using SimSig_Keyboard_Interface.Comms.TCP;

namespace SimSig_Keyboard_Interface.Comms.RS232
{
	public sealed partial class Receiver
	{
		internal event EventHandler<MsgEventArgs> ComDataReceived;

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
			try
			{



			}
		}



	}
}
