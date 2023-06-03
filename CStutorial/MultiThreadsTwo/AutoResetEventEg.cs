using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CStutorial.MultiThreadsTwo
{
	internal class AutoResetEventEg
	{
		/* 
		 * AutoResetEvent is a signaling function from C#, which allows the
		 * application to partcular thread until it receives a notifaction from
		 * another thread telling it to unblock.
		 * 
		 * AutoResetEvent behaves like a turnstile, i.e. it let's one person go
		 * through the turnstile one at a time. The same applies to multiple
		 * threads blocking via WaitOne(), and calling the Set() function will
		 * only unblock one thread.
		 * 
		 * */

		/*
		 * Difference between ManualResetEvent and AutoResetEvent, is that the
		 * WaitOne() in AutoResetEvent will automatically invoke the Reset()
		 * internally once Set() is called. Whereas the with ManualResetEvent,
		 * the Reset() will need to be invoked manually once Set() is called.
		 * */

		public void ExecuteExample()
		{
			AutoResetEvent autoResetEvent = new AutoResetEvent(false);

			for (int i = 0; i < 5; i++) 
			{
				int num = i + 1;
				Task.Run(() => 
				{
					Console.WriteLine($"Task {num} running...");
					/*
					 * Here we use the WaitOne() to block the thread.
					 * Once Set() is called, WaitOne() will automatically
					 * invoke the Reset().
					 * */
					autoResetEvent.WaitOne();
					Console.WriteLine($"Task {num} closing...");
				});
			}

			while (true)
			{
				string input = Console.ReadLine();
				if (input == "quit")
				{
					autoResetEvent.Close();
					break;
				}
				if (input == "set")
				{
					/*
					 * Here we use the Set() to unblock a single thread.
					 * */
					autoResetEvent.Set();
				}
			}

			Console.WriteLine("Finished");
		}

		public int GetWorkingThreads()
		{
			int maxThreads;
			int completionPortThreads;
			ThreadPool.GetMaxThreads(out maxThreads, out completionPortThreads);

			int availableThreads;
			ThreadPool.GetAvailableThreads(out availableThreads, out completionPortThreads);

			return maxThreads - availableThreads;
		}
	}
}