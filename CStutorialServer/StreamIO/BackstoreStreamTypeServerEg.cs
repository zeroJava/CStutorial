using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorialServer.StreamIO
{
	internal class BackstoreStreamTypeServerEg
	{
		public static void NamedPipeStreamServerExample()
		{
			//NamedPipeServerStreamEg();
			AnonymousPipeServerStreamEg();
		}

		private static void NamedPipeServerStreamEg()
		{
			try
			{
				using var namedServerPipe = 
					new NamedPipeServerStream("BackStoreNamedExample");
				var reader = new StreamReader(namedServerPipe);
				namedServerPipe.WaitForConnection();
				while (true)
				{
					var result = reader.ReadLine();
					var timestamp = DateTime.Now;
					//var result = namedServerPipe.ReadByte();
					Console.WriteLine(result + " R: " + timestamp);
				}
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception);
			}
		}

		private static void AnonymousPipeServerStreamEg()
		{
			var inherit = HandleInheritability.Inheritable;

			using (var outPipe =	new AnonymousPipeServerStream(PipeDirection.Out, inherit))
			using (var inPipe = new AnonymousPipeServerStream(PipeDirection.In, inherit))
			{
				AnonymousPipe(outPipe, inPipe);
			}
		}

		private static void AnonymousPipe(AnonymousPipeServerStream outPipe,
			AnonymousPipeServerStream inPipe)
		{
			var clientExePath = @"..\..\..\..\CStutorial\bin\Debug\CStutorial.exe";
			var path = Path.GetFullPath(clientExePath);
			try
			{
				var outId = outPipe.GetClientHandleAsString();
				var inId = inPipe.GetClientHandleAsString();

				var command = string.Format("{0} {1}", outId, inId);
				var startInfo = new ProcessStartInfo(clientExePath, command);
				startInfo.UseShellExecute = false;
				Process? process = Process.Start(startInfo);

				outPipe.DisposeLocalCopyOfClientHandle();
				inPipe.DisposeLocalCopyOfClientHandle();

				for (int i = 0; i < 1000; i++)
				{
					var v = (byte)new Random().Next(0, 150);
					Console.WriteLine(v);
					outPipe.WriteByte(v);
				}

				process?.WaitForExit();
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception);
			}
		}
	}
}