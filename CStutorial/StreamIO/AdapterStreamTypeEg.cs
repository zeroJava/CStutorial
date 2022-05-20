using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.StreamIO
{
	internal static class AdapterStreamTypeEg
	{
		/*
		 * The backstore or decorator stream deal only in bytes, to read or write
		 * in a certain type i.e. text, xml or sql, you have to pass the stream 
		 * into a stream-adapter.
		 * */

		public static void TextAdapterExample()
		{
			/*
			 * TextAdapter is one of the many stream adapters, which is actually a
			 * abstract type for the StreamReader/Writer and StringReader/Writer.
			 * */

			var path = @"..\..\..\CStutorial\StreamIO\StreamTest.txt";

			/*
			 * File.OpenText returns StreamReader, which is TextAdapter, which in
			 * is a stream-adapter.
			 * */
			using (var textAdapter = File.OpenText(path))
			{
				Console.WriteLine(textAdapter.ReadToEnd());
			}

			/*
			 * Here we're a using two stream-adapter to wrap around our backstore-
			 * stream: FileStream, and then read the from the file and the write
			 * to our file.
			 * */
			using (var filestream = new FileStream(path, FileMode.OpenOrCreate,
				FileAccess.ReadWrite,
				FileShare.ReadWrite,
				4096,
				true))
			{
				var streamReader = new StreamReader(filestream);
				var streamWriter = new StreamWriter(filestream);
				var content = streamReader.ReadToEnd();
				content += "Hello";
				streamWriter.WriteLine(content);
				streamWriter.Flush();

				/*
				 * There are four ways of closing an adapter:
				 * 1 - Close the adapter only
				 * 2 - Close the adapter and then the stream
				 * 3 - Flush the adapter and then close the stream (writer)
				 * 4 - Close the stream (reader).
				 * 
				 * 1 and 2 are actually the same, when the close in the adapter
				 * is called, it also calls the close function in our stream.
				 * 
				 * 3 and 4, the adapter may not be disposed, and thus stream isn't
				 * closed. With 3 we flsuh everything from the buffer, and then
				 * close the backstore stream. 4, we just close the stream. 
				 * */
			}
		}
	}
}