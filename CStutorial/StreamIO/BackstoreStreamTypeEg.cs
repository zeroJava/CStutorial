using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CStutorial.StreamIO
{
	internal static class BackstoreStreamTypeEg
	{
		public static void FileStreamExample()
		{
			/*
			 * The FileStream is a back-store stream that deals with reading and 
			 * writing data to and from the hard-drive.
			 * */

			/*
			 * You can create a FileStream object, either using one of the classes
			 * static methods: OpenRead, OpenWrite and Create; or using the 
			 * FileStream constructor. The constructor allows you to configure the
			 * object.
			 * */

			// AppDomain.CurrentDomain.BaseDirectory gives the location of base
			// directory where the exe is stored.
			var filepath = @"..\..\..\CStutorial\StreamIO\StreamTest.txt";
			using (var fileStream = new FileStream(filepath,
				FileMode.OpenOrCreate,
				FileAccess.ReadWrite,
				FileShare.ReadWrite,
				4096,
				true))
			{
				/*
				 * A FileStream constructor with just the path and filemode creates
				 * an object that is by default a read-write stream i.e. FileAccess
				 * .ReadWrite.
				 * */

				/*
				 * FileShare: allows us the define much access other streams have
				 * to the file we're using. I believe the flag allows multiple
				 * stream access.
				 * */

				var data = new byte[1000];
				fileStream.Read(data, 0, 10); 
				// bare-bone function provice backstore stream.

				/* 
				 * Filestream is automatically Flushed and Closed via using
				 * statment.
				 * 
				 * When a FileStream is used with a decorator stream or an adapter
				 * stream; closing the decorator or adapter also closes the
				 * back-store stream.
				 * 
				 * Once you pass the FileStream object to a decorator or adapter,
				 * the ownership/responsibility of the Flush() is passed on to the
				 * adapter, thus calling filestream.Flush will not flush.
				 * */

				/* 
				 * The Flush() function is used to move data from the buffer to the
				 * hard drive.
				 * Without invoking this, it will stay in memory.
				 * */
			}
		}

		public static void MemoryStreamExample()
		{
			/*
			 * MemoryStream is backstore stream were the data is talking to the
			 * memory instead of the hard-drive, which FileStream does.
			 * 
			 * It's basically a wrapper for an byte array, we're we copy the data
			 * from one stream to memory using the CopyTo(MemoryStream).
			 * */

			/*
			 * Because the MemoryStream like the FileStream is a seekable, which
			 * allows us to seek and position index in the stream; it kind off
			 * serves as an intermidate stream for non-seekable stream, i.e.
			 * we can copy the data from the non-seekable stream and place in the
			 * memory stream, and then maniplate the data.
			 * */

			/*
			 * They main advantage of a MemoryStream over an byte array is that
			 * the stream grows dynamically, were as the byte array is static.
			 * 
			 * Plus the MemoryStream can be placed inside a StreamAdapter like
			 * StreamWrite and StreamReader for text inside of raw byte data.
			 * */

			var filepath = @"..\..\..\CStutorial\StreamIO\StreamTest.txt";
			string data = File.ReadAllText(filepath);
			byte[] buffer;
			using (var memoryStream = new MemoryStream())
			using (var writer = new StreamWriter(memoryStream))
			{
				memoryStream.Seek(0, SeekOrigin.Begin);
				writer.Write(data);
				writer.WriteLine("MemoryStream: " + new Random().Next(0, 255));
				writer.Flush();
				memoryStream.Seek(0, SeekOrigin.Begin);
				buffer = memoryStream.ToArray();
			}
			File.WriteAllText(filepath, Encoding.UTF8.GetString(buffer));
			Console.WriteLine("Done");
		}

		public static void PipeStreamExample(string[] args)
		{
			/*
			 * PipeStream is a backstore class were data used to talk to other
			 * processes in the pipeline, thus allowing inter-process
			 * communication.
			 * 
			 * There are two types of PipeStream: named and anonymous pipe stream.
			 * 
			 * In C#, the PipeStream is an abstract class, with each PipeStream
			 * type having two classes assocaited with it: a client and server
			 * class.
			 * 
			 * Named: NamedPipeServerStream and NamedPipeClientStream
			 * Anonymous: AnonymousPipeServerStream and AnonymousPipeClientStream
			 */

			var action = 0 == 1 ? new Action<string[]>(NamedPipeClientStreamEg) :
				new Action<string[]>(AnonymousPipeClientStreamEg);
			action.Invoke(args);
		}

		private static void NamedPipeClientStreamEg(string[] args)
		{
			/*
			 * This section is split into two parts, the client and server.
			 * check the Server project, to see example of the server side of the
			 * example.
			 * */

			/*
			 * NamedPipe stream allows two processes to communicate with each
			 * other using the pipe (window pipe protocol) which share the name. 
			 * */

			/*
			 * By default NamedPipe is bidirectional, so you may have to configure
			 * it to prevent both the server and client sending messages at the
			 * same time.
			 * */
			try
			{
				using (var namedClientPipe = new
					NamedPipeClientStream("BackStoreNamedExample"))
				{
					/*
					 * Both the server and client have a connection method. which
					 * force the application to pause an wait for a handshake,
					 * before talking to each other.
					 * 
					 * NamedPipeClient has Connect;
					 * NamedPipeServer has WaitForConnection;
					 * */

					namedClientPipe.Connect();
					var writer = new StreamWriter(namedClientPipe);
					while (true)
					{
						Thread.Sleep(1000);
						var number = new Random().Next(5000);
						var timestamp = DateTime.Now;
						var message = string.Format("{0} - S: {1}", number,
							timestamp);
						Console.WriteLine(message);
						writer.WriteLine(message);
						writer.Flush(); // stream adapters will need to call flush
						//namedClientPipe.WriteByte(100);
					}
				}
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception);
			}
		}

		private static void AnonymousPipeClientStreamEg(string[] args)
		{
			/*
			 * Check the server side of this example similar to NamedPipeServer.
			 * */

			/*
			 * AnonymousPipe is similar to NamedPipe, which allows two processes
			 * to communicate with each other, with difference being that
			 * 
			 * NamedPipes are bidirectional and AnonymousPipe are unidirectional,
			 * were the server sends a request to the client, and it seems like
			 * the client process is a dependent process.
			 * */

			/*
			 * NamedPipe works by looking for a process with the same matching the
			 * assigned name, were as the AnonPipe uses the ID (PID) to find the
			 * process.
			 * */

			try
			{
				var outId = args[0];
				var inId = args[1];
				Console.WriteLine(outId);
				Console.WriteLine(inId);
				using (var inPipe = new AnonymousPipeClientStream(PipeDirection.In, inId))
				using (var outPipe = new AnonymousPipeClientStream(PipeDirection.Out, outId))
				{
					for (int i = 0; i < 1000; i++)
					{
						Console.WriteLine("R: " + inPipe.ReadByte());
						var number = new Random().Next(0, 150);
						Console.WriteLine("S: " + number);
						inPipe.WriteByte((byte)number);
					}
				}
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception);
			}
		}
	}
}