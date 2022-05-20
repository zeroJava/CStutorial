using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.StreamIO
{
	internal static class DecoratorStreamTypeEg
	{
		/*
		 * A decorator stream is an additional optional layer on top of the
		 * backstore stream, which modifies the stream from the back-store, i.e.
		 * CrytoStream transforms the data to a crypto data, or BufferedStream
		 * becomes a middleman where data is changed via a buffered region in
		 * memory.
		 * */

		public static void BufferStreamExample()
		{
			/*
			 * BufferedStream provides a layer over the backstore-stream, which
			 * mitigates the need for the application to talk to the hardware
			 * continuously
			 * */

			var filepath = @"..\..\..\CStutorial\StreamIO\StreamTest.txt";

			File.WriteAllBytes(filepath, GetData(1000000));

			using (var fileStream = new FileStream(filepath,
				FileMode.OpenOrCreate,
				FileAccess.ReadWrite,
				FileShare.ReadWrite,
				4096,
				true))
			using (var bufferedStream = new BufferedStream(fileStream, 20000))
			{
				/*
				 * With a buffered stream, the framework put certain amount of
				 * bytes into the buffer (memory), and it waits until the buffer
				 * threshold has been reached, which it then forces the
				 * BufferedStream to talk to the FileStream again, and refresh the
				 * buffer.
				 * 
				 * In our case the buffer size has been set to 20KB.
				 * */
				while (bufferedStream.Position != 1000000)
				{
					/*
					 * Everytime we use buffered.ReadByte(), we're getting a byte
					 * from the buffer.
					 * 
					 * Once the buffer is emptied, calling the ReadByte() will force
					 * the buffered stream to refresh, and then will get our byte
					 * value.
					 * */
					bufferedStream.ReadByte();

					/*
					 * Because buffered stream talks to the backstore stream, and
					 * copies a certain amount of bytes to the memory, the position
					 * property from FileStream and BufferedStream will be
					 * different.
					 * */
					var value = string.Format("F:{0}, B:{1}", fileStream.Position,
						bufferedStream.Position);
					Console.WriteLine(value);
				}
			}
		}

		private static byte[] GetData(int max)
		{
			var random = new Random();
			var array = new byte[max];
			for (int i = 0; i < max; i++)
			{
				array[i] = (byte)random.Next(255);
			}
			return array;
		}
	}
}