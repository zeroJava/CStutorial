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
		 * In computers science, a thread small unit of execution that is part of a
		 * bigger process; i.e. it's a small task inside a larger process.
		 * */

		/* 
		 * Each process gets access to certain part of the memory resource that the OS
		 * allocates to the process. A thread can only access the memory resource that is
		 * available to the process the thread belongs to.
		 * */

		public static void ExecuteThreadOne()
		{
			Console.WriteLine("Main thread started");

			Action<string> tBody = (name) =>
			{
				Console.WriteLine($"{name} started");
				for (int c = 0; c < 100000; c++)
				{
					if (c % 10000 == 0)
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