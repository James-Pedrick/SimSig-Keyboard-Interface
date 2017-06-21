using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using SimSig_Keyboard_Interface.Comms.TCP;
using SimSig_Keyboard_Interface.User_Interface;
using SimSig_Keyboard_Interface.Properties;

namespace SimSig_Keyboard_Interface.Comms.RS232
{
	public sealed partial class SerialClient : IDisposable
	{
		private Receiver _receiver;
        private SerialPort ComPort;

		public void SendData(string data)
		{
            if (MainMenu.SerialConnected)
                ComPort.WriteLine(data);
		}

		public event EventHandler<MsgEventArgs> DataReceived;

		public SerialClient() { }


		private void OnDataReceived(object sender, MsgEventArgs e)
		{
			var handler = DataReceived;
			if (handler != null) DataReceived?.Invoke(this, e);		//ReRaise Event
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}

		public void Connect()
		{
			ComPort = new SerialPort();

			ComPort.BaudRate = Settings.Default.comBaudRate;
			ComPort.PortName = Settings.Default.comPortName;
			ComPort.DataBits = Settings.Default.comDataBits;

			try
			{
				ComPort.Open();
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}

			_receiver = new Receiver(ComPort);


		}

        public void Disconnect()
        {
            _receiver.Close();
            ComPort.Close();
        }
	}
}
