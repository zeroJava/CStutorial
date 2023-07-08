using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CStutorial.MultiThreads
{
	internal static class LockingEg
	{
		private static string currentThread = string.Empty;
		private static readonly object exclusiveLock = new object();

		/*
		 * Locking is when the CLR prevent multiple thread from accessing the
		 * shared resource at the same time. Once a share resource is in use,
		 * the CLR will prevent another threads from accessing the resource the
		 * thread has finished using it.
		 * */

		public static void ExecuteThreadOne()
		{
			RunExclusiveEgOne("T1");
			RunExclusiveEgOne("T2");
			RunExclusiveEgOne("T3");
		}

		private static void RunExclusiveEgOne(string name)
		{
			Thread t = new Thread(() =>
			{
				for (int i = 0; i < 10; i++)
				{
					/*
					 * The simplest way to attain an exlusive lock is through the
					 * lock() statement.
					 * 
					 * When the lock statement is executed, the runtime will prevent
					 * any threads from accessing the exclusiveLock variable and any
					 * of the shared resources inside the lock body.
					 * */

					/*
					 * When a thread executes a section of the code that is locked
					 * via the lock() statement, the runtime will put it into a
					 * waiting list, which then will get its turn when the current
					 * locked thread finishes executing the locked section.
					 * 
					 * The lock() waiting list a first-in-first-out
					 * */

					/*
					 * lock() statement is a simpler way of writing Monitor.Enter
					 * and Monitor.Exit. Check notes.
					 * */

					Console.WriteLine($"{name} is entering the lock");
					lock (exclusiveLock)
					{
						currentThread = name;
						Console.WriteLine(name);
						Thread.Sleep(2000);
					}
				}
			});
			t.Start();
		}
	}
}