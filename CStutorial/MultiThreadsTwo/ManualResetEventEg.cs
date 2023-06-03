using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CStutorial.MultiThreadsTwo
{
	internal class ManualResetEventEg
	{
		private readonly object lockobject = new object();

		/* 
		 * ManualResetEvent is a signaling function from C#, which allows the
		 * application to partcular thread until it receives a notifaction from
		 * another thread telling it to unblock.
		 * 
		 * ManualResetEvent behaves like a gate, i.e. once open, a number of
		 * people can go through the gate all at the same time. The same applies
		 * to multiple threads blocking via WaitOne(), and calling the Set()
		 * function will unblock all the threads at once.
		 * 
		 * */

		/*
		 * 
		 * If the Reset() is not invoked after calling the Set(), then the 
		 * WaitOne will not block the thread; inorder for the WaitOne to work,
		 * we have invoke Reset() when using ManualResetEvent.
		 * */

		/*
		 * Difference between ManualResetEvent and AutoResetEvent, is that the
		 * WaitOne() in AutoResetEvent will automatically invoke the Reset()
		 * internally once Set() is called. Whereas the with ManualResetEvent,
		 * the Reset() will need to be invoked manually once Set() is called.
		 * */

		public void ExecuteExample()
		{
			ManualResetEvent manualResetEvent = new ManualResetEvent(false);
			int counter = 0;

			for (int i = 0; i < 20; i++)
			{
				int num = i + 1;
				Task.Run(() =>
				{
					Console.WriteLine($"Task {num} running...");
					lock (lockobject)
					{
						counter++;
					}
					/*
					* Here we use the WaitOne() to block the thread.
					* */
					manualResetEvent.WaitOne();
					lock (lockobject)
					{
						counter--;
						if (counter % 5 == 0)
						{
							/*
							 * The Reset() to reset the WaitEventHandle.
							 * If don't invoke the Reset(), then the WaitOne() 
							 * after the following line will not block the thread.
							 * */
							manualResetEvent.Reset();
							manualResetEvent.WaitOne();
						}
					}
					Console.WriteLine($"Task {num} closing...");
				});
			}

			while (true)
			{
				string input = Console.ReadLine();
				if (input == "quit")
				{
					manualResetEvent.Close();
					break;
				}
				if (input == "set")
				{
					/*
					 * Here we use the Set() to unblock a single thread.
					 * */
					manualResetEvent.Set();
				}
			}

			Console.WriteLine("Finished");
		}
	}
}
