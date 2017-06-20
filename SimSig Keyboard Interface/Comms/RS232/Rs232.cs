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
	public sealed partial class Receiver : IDisposable
	{
		private Receiver _receiver;
		public void SendData(string data)
		{
			if (MainMenu.ComConnected)
				_sender.SendData(data);
		}

		public event EventHandler<MsgEventArgs> ComDataReceived;

		public Receiver() { }


		private void OnDataReceived(object sender, MsgEventArgs e)
		{
			var handler = ComDataReceived;
			if (handler != null) ComDataReceived?.Invoke(this, e);		//ReRaise Event
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}

		public void Connect()
		{
			SerialPort ComPort = new SerialPort();

			ComPort.BaudRate = Settings.Default.comBaudRate;
			ComPort.PortName = Settings.Default.comPortName;
			ComPort.DataBits = Settings.Default.comDataBits;

			ComPort.Open();


			_receiver = new Receiver(_stream);


		}
	}
}
