using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CStutorial.MultiThreads
{
	internal static class BlockingEg
	{
		/*
		 * Blocking is when a thread is paused and the processor stop processing
		 * the remainder of the thread until at certain condition is met for it
		 * to resume processing.
		 * */

		/*
		 * I/O bound: operations that take requires time to finish until it can
		 * move on.
		 * 
		 * Compute bound: a CPU intensive operation
		 * */

		public static void ExecuteThreadOne()
		{
			Console.WriteLine("Main thread started");
			
			int sharedCounter = 0;
			
			Action<string, string> tBody = (name, symbol) =>
			{
				Console.WriteLine($"{name} started");

				/*
				 * Any variables created within the delegates body is stored in the
				 * threads memory stack, i.e. each thread will have it's own copy
				 * of the c variable below. 
				 * 
				 * This is know as a local state.
				 * */

				/*
				 * The above variable is stored normally on a single memory stack,
				 * and is referenced by both thread.
				 * 
				 * This is a shared state.
				 * 
				 * The local variable captured by lambda expression, the compiler
				 * converts them to fields during compile time so they can be 
				 * shared. Look at notes appendix one.
				 * 
				 * */

				for (int c = 0; c < 200; c++)
				{
					if (c % 10 == 0)
					{
						Console.WriteLine($"{symbol}{sharedCounter}{symbol}");
						Thread.Sleep(1000);
					}
					sharedCounter++;
				}
				Console.WriteLine($"{name} finised");
			};

			Thread t1 = new Thread(() => { tBody("T1", "-"); });
			Thread t2 = new Thread(() => { tBody("T2", "+"); });

			t1.Start();
			t2.Start();

			t1.Join();
			t2.Join();

			Console.WriteLine("Main thread finished");
		}
	}
}