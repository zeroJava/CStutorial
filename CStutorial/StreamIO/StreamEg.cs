using System;
using System.IO;

namespace CStutorial.StreamIO
{
	internal class StreamEg
	{
		/*
		 * A stream is a sequence of bytes such as a file, an I/O device or an
		 * inter-process communication.
		 * 
		 * The purpose of a stream is provide the basic functionality of writing,
		 * reading and seeking.
		 * 
		 * Seeking is looking for position in a stream.
		 * */

		/*
		 * Backstore
		 * Backstore is the lowest level in the stream heirachy below the stream
		 * class. It is at level were we see c# stream classes deal physically
		 * with either the hard-drive, memory or network.
		 * 
		 * At a backstore level, data is dealt in bytes.
		 * */

		/*
		 * Decorator
		 * The decorator stream is level above the backstore. It's purpose is to
		 * provide a optionl layer were data is trasformed i.e. encryption.
		 * e.g. Gzip and crytostream
		 * */

		/*
		 * Adapter
		 * The stream adapters are wrapper classes that wrap the stream into high
		 * -level data constructs such as text, xml or binary.
		 * */

		public void Write()
		{
			/*
			 * Filestream is back store class, meaning that this is the class that
			 * talks to the hard-drive, and reads, writes and seeks the data.
			 * 
			 * With Filestream, the class deals with the data in bytes.
			 * */

			/*
			 * Streamwriter is an adapter, were the class behaves as a wrapper to
			 * the filestream.
			 * 
			 * Because filestream deals with a data in bytes, the streamwriter 
			 * allows the propgrammer to write data as text.
			 * */

			var path = @"..\..\..\CStutorial\StreamIO\Test.txt";
			using (var fileStream = new FileStream(path, FileMode.OpenOrCreate,
				FileAccess.Write,
				FileShare.Write,
				4096,
				true))
			{
				/*
				 * You can use stream-writer without the filestream, and just
				 * provide the file path.
				 * 
				 * But using dependency injection, we can specify the stream, and
				 * it also gives us the freedom to configure the internal stream,
				 * instead of just relying on the default setting if done by path. 
				 * */
				using (var writer = new StreamWriter(fileStream))
				{
					fileStream.Seek(0, SeekOrigin.End);
					writer.WriteLine(new Random().Next(0, 255));
				}
			}
		}

		public void Read()
		{
			var path = @"..\..\..\CStutorial\StreamIO\Test.txt";
			using (var fileStream = new FileStream(path, FileMode.OpenOrCreate,
				FileAccess.Write,
				FileShare.Write,
				4096,
				true))
			{
				/*
				 * After a stream done, it is important close it. If a stream is
				 * used with in decorator stream, closing the decorator stream also
				 * clsoes the connexted stream.
				 * 
				 * Some streams have internal bufferes that stores before trying,
				 * the flush() function forces the stream to write the remaining
				 * data to disk.
				 * 
				 * the using statement autmatically deal with this, i.e. Flush();
				 * Close();
				 * */

				/*
				 * FileStream,Read(bytes[] data, ...) returns the number of bytes
				 * it read.
				 * */

				using (var reader = new StreamReader(fileStream))
				{
					while (!reader.EndOfStream)
					{
						Console.WriteLine(reader.ReadLine());
					}
				}
			}
		}
	}
}

// https://www.bestprog.net/en/2020/11/20/c-stream-concept-stream-architecture-in-c-basic-storage-streams-streams-with-decorators-adapters-streams/