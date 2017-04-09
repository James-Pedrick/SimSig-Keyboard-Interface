using System;
using System.Diagnostics;
using System.Net.Sockets;

namespace SimSig_Keyboard_Interface.Client.TCP
{
    public sealed partial class TCP_Client : IDisposable
    {
        // Called by producers to send data over the socket.
        public void SendData(string  data)
        {
            _sender.SendData(data);
        }

        // Consumers register to receive data.
        public event EventHandler<DataReceivedEventArgs> DataReceived;

        public TCP_Client()
        {
           
        }

        private void OnDataReceived(object sender, DataReceivedEventArgs e)
        {
            var handler = DataReceived;
            if (handler != null) DataReceived(this, e);  // re-raise event
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Connect(string ipAddress, int port, string nick, string simulation, string simVersion, string loaderVersion)
        {
            _client = new TcpClient();

            System.Console.WriteLine("Connecting ...");
            _client.Connect(ipAddress, port);
            System.Console.WriteLine("Connected");


            _stream = _client.GetStream();

            _receiver = new Receiver(_stream);
            _sender = new Sender(_stream);

            _receiver.DataReceived += OnDataReceived;

            SendData("iA"+nick+"C"+simVersion+"/"+loaderVersion+"/"+simulation+"|");
        }


        private TcpClient _client;
        private NetworkStream _stream;
        private Receiver _receiver;
        private Sender _sender;
    }






}