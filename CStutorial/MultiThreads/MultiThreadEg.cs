using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CStutorial.MultiThreads
{
	internal static class MultiThreadEg
	{
		/* 
		 * In computers science, a thread is a small unit of execution that is
		 * part of a bigger process; i.e. it's a small task inside a larger
		 * process.
		 * */

		/* 
		 * Each process gets access to certain part of the memory resource that 
		 * the OS allocates to the process. A thread can only access the memory
		 * resource that is available to the process the thread belongs to.
		 * */

		/*
		 * Multithreading is done differently on single core compared to a
		 * multicore processor.
		 * 
		 * In a single-core processor, the OS splits the execution stream into
		 * small execution time slices, which inturn simulates a thread.
		 * 
		 * In a multi-core processor, each core takes a thread and is executed in
		 * parallel.
		 * */

		public static void ExecuteThreadOne()
		{
			Console.WriteLine("Main thread started");

			Action<string> tBody = (name) =>
			{
				Console.WriteLine($"{name} started");
				/*
				 * Each thread is assigned its own memory stack, which contains
				 * all the variables created inside the threads delegate, e.g.
				 * the c vatiable inside the loop, will stored in the threads
				 * memory stack.
				 * 
				 * Because each thread will have its own memory stack, this means
				 * that the variable c will appear in multiple memory stacks.
				 * */
				for (int c = 0; c < 999999999; c++)
				{
					if (c % 10000000 == 0)
					{
						Console.Write("-");
					}
				}
				Console.WriteLine($"{name} finised");
			};

			Thread t1 = new Thread(() => { tBody("T1"); });
			Thread t2 = new Thread(() => { tBody("T2"); });

			t1.Start();
			t2.Start();

			Console.WriteLine("Main thread finished");
		}
	}
}