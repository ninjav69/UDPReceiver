using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UDPReceiver
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			UdpClient client = new UdpClient (10000);
			var endpoint = new IPEndPoint(IPAddress.Any, 11000); 
			var data = client.Receive(ref endpoint); // listen on port 11000

			Console.WriteLine("receive data from " + endpoint.ToString());
			Console.WriteLine ("Data: " + Encoding.ASCII.GetString(data));
		}
	}
}
