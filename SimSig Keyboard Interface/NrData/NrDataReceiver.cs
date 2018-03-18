using System;
using Apache.NMS;

using System.Text.RegularExpressions;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace SimSig_Keyboard_Interface.NrData
{
	public sealed class NrDataReceiver
	{

		public sealed class MsgEventArgs : EventArgs
		{
			public string Msg  { get; set; }
		}


		public string NrPassword;


		public void NrReceiverMain(string NrPassword)
		{
			IConnectionFactory factory = new NMSConnectionFactory(new Uri("stomp:tcp://datafeeds.networkrail.co.uk:61618"));

			IConnection connection = factory.CreateConnection("ben@benwoodward.me.uk", "5qY#n7BV&g6$3lp0hrL#");
			ISession session = connection.CreateSession();

			IDestination destination = session.GetDestination("topic://" + "TD_ALL_SIG_AREA");
			IMessageConsumer consumer = session.CreateConsumer(destination);

			connection.Start();
			consumer.Listener += OnMessage;


			Console.WriteLine("Consumer started, waiting for messages... (Press ENTER to stop.)");

			Console.ReadLine();
			connection.Close();
		}

		private void OnMessage(IMessage message)
		{
			try
			{
				ITextMessage msg = (ITextMessage)message;
				message.Acknowledge();


			//	Console.WriteLine(msg.Text);

				NrDataProcess.DataProcess(msg.Text);



			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				Console.WriteLine("---");
				Console.WriteLine(ex.InnerException);
				Console.WriteLine("---");
				if (ex.InnerException != null) Console.WriteLine(ex.InnerException.Message);
			}

		}



	}
}
