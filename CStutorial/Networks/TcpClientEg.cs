using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Networks
{
	internal class TcpClientEg
	{
		public void Run()
		{
			while (true)
			{
				Console.WriteLine(">>>");
				using (var tcpClient = new TcpClient("", 51111)) // enter ip
				using (var networkstream = tcpClient.GetStream())
				{
					string input = Console.ReadLine();
					if (input == "exit")
					{
						break;
					}
					var binaryWriter = new BinaryWriter(networkstream);
					binaryWriter.Write(input);
					binaryWriter.Flush();
				}
			}
		}
	}
}