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
using SimSig_Keyboard_Interface.User_Interface.MainDisplays;

namespace SimSig_Keyboard_Interface.Comms.RS232
{
	public sealed partial class SerialClient : IDisposable
	{
		private Receiver _receiver;
        private SerialPort _comPort;

		public void SendData(string data)
		{
            if (MainMenu.ComConnected)
                _comPort.WriteLine(data);
		}

		public event EventHandler<MsgEventArgs> DataReceived;

		public SerialClient()
        {

        }
        
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
			_comPort = new SerialPort();

			_comPort.BaudRate = Settings.Default.comBaudRate;
			_comPort.PortName = Settings.Default.comPortName;
			_comPort.DataBits = Settings.Default.comDataBits;

			try
			{
				_comPort.Open();
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}

			_receiver = new Receiver(_comPort);
            _receiver.DataReceived += OnDataReceived;

		}

        public void Disconnect()
        {
            _receiver.Close();
            _comPort.Close();
        }
	}
}
