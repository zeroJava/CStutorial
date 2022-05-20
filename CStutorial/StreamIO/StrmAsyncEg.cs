using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace CStutorial.StreamIO
{
	internal class StrmAsyncEg
	{
		private readonly CancellationTokenSource cancellationTokenSource;
		private readonly CancellationToken cancellationToken;
		private readonly System.Timers.Timer timer;

		public StrmAsyncEg()
		{
			cancellationTokenSource = new CancellationTokenSource();
			cancellationToken = cancellationTokenSource.Token;
			timer = new System.Timers.Timer(60000 * 5);
			timer.Elapsed += Timer_Elapsed;
		}

		private void Timer_Elapsed(object sender,
			System.Timers.ElapsedEventArgs e)
		{
			cancellationTokenSource.Cancel();
			Console.WriteLine("Cancellation requested");
		}

		public void Test()
		{
			//Task writeTask = Task.Run(() => WriteProcessAsync());
			Console.WriteLine("WriteTask started");
			//Task readTask = Task.Run(() => ReadProcessAsync());
			Console.WriteLine("ReadTask started");
			Task readWriteTask = Task.Run(() => ReadWriteAsync());
			Console.WriteLine("ReadWriteTask started");
			timer.Start();
		}

		private async Task WriteProcessAsync()
		{
			while (!cancellationToken.IsCancellationRequested)
			{
				Random random = new Random();
				string text = $"{DateTime.Now}, {random.Next(1000, 9999)}";
				await WriteAsync(text).ContinueWith(t =>
				{
					if (t.Exception != null)
					{
						Console.WriteLine($"Error encountered when writing to file.\n"
							+ $"{t.Exception.Message}");
					}
				});
			}
		}

		private Task WriteAsync(string text)
		{
			Console.WriteLine($"Writing to file: {text}");
			return Task.Run(() =>
			{
				var path = @"..\..\..\CStutorial\StreamIO\StreamTest.txt";
				using (var fileStream = new FileStream(path, FileMode.OpenOrCreate,
					FileAccess.ReadWrite,
					FileShare.ReadWrite,
					bufferSize: 4096,
					useAsync: true))
				{
					using (var writer = new StreamWriter(fileStream))
					{
						fileStream.Seek(0, SeekOrigin.End);
						writer.WriteLine(text);
					}
				}
			});
		}

		private async Task ReadProcessAsync()
		{
			while (!cancellationToken.IsCancellationRequested)
			{
				await ReadAsync().ContinueWith(t =>
				{
					if (t.Exception != null)
					{
						Console.WriteLine($"Error encountered when reading from file.\n"
							+ $"{t.Exception.Message}");
					}
				});
			}
		}

		private Task ReadAsync()
		{
			return Task.Run(() =>
			{
				var path = @"..\..\..\CStutorial\StreamIO\StreamTest.txt";
				using (var fileStream = new FileStream(path, FileMode.OpenOrCreate,
					FileAccess.ReadWrite,
					FileShare.ReadWrite,
					bufferSize: 4096,
					useAsync: true))
				{
					using (var reader = new StreamReader(fileStream))
					{
						while (!reader.EndOfStream && 
							!cancellationToken.IsCancellationRequested)
						{
							Console.WriteLine($"Reading from file: " +
								$"{reader.ReadLine()}");
						}
					}
				}
			});
		}

		private Task ReadWriteAsync()
		{
			return Task.Run(() =>
			{
				var path = @"..\..\..\CStutorial\StreamIO\StreamTest.txt";
				using (var fileStream = new FileStream(path, FileMode.OpenOrCreate,
					FileAccess.ReadWrite,
					FileShare.ReadWrite,
					bufferSize: 4096,
					useAsync: true))
				{
					var texts = new List<string>();
					var reader = new StreamReader(fileStream);
					while (!reader.EndOfStream && 
						!cancellationToken.IsCancellationRequested)
					{
						texts.Add(reader.ReadLine());
					}
					var writer = new StreamWriter(fileStream);
					foreach (var text in texts)
					{
						writer.WriteLine(text + " Modified");
					}
					/*
					 * fileStream.Flush(true); will not work, because the 
					 * responsibility is passed on to the adapter.
					 * https://stackoverflow.com/a/13043848
					 * */
					writer.Flush(); // will work

				}
			});
		}
	}
}