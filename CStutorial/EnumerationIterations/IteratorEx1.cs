using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.EnumerationIterations
{
	/*
	 * Please read enumerator.
	 * */

	public class IteratorEx1
	{
		/*
		 * An iterator is a method, property or indexer,
		 * which contains a yield statement. 
		 * */
		
		/*
		 * using yield marks the method as an iterator,
		 * which returns a ienumrable object.
		 * 
		 * Behind the scene, when yield is used, c# create
		 * a hidden ienumerable class.
		 * */

		/* An itertor method goes through a collection,
		 * and then behind the scene constructs and
		 * return an ienumerable object, which is only
		 * possible using he yield statement.
		 * */

		/*
		 * An iterator must return either an IEnumerable
		 * or IEnumerator.
		 * */

		public void ExampleExecute()
		{
			foreach (int number in IteratorExample1())
			{
				Console.WriteLine(number);
			}
		}

		private IEnumerable<int> IteratorExample1()
		{
			/*
			 * Adding yield to make the method into an iterator.
			 * */

			/*
			 * Iterators, when compiled, is converted to a
			 * private class that implements both the
			 * IEnumerable and IEnumerator.
			 * */

			yield return 1;
			yield return 2;
			yield return 3;
			yield return 4;
			yield return 5;
		}

		private static System.Collections.Generic.IEnumerable<int> MakeIterator()
		{
			Console.WriteLine("Inside make iterator");
			Console.WriteLine("1");
			yield return 1;

			Console.WriteLine("2");
			yield return 2;

			Console.WriteLine("4");
			yield return 4;

			Console.WriteLine("8");
			yield return 8;

			Console.WriteLine("16");
			yield return 16;

			Console.WriteLine("32");
			yield return 32;
		}

		private IEnumerable<int> IteratorExample2()
		{
			/*
			 * Adding yield to make the method into an iterator.
			 * */

			for (int index = 0; index < 10; index++)
			{
				if (index == 5)
				{
					yield break;
				}
				yield return index;
			}

			/*
			 * yields can not be placed inside a try, catch
			 * or finally block.
			 * 
			 * The only time it is possible to place a yield
			 * inside a try block, is when the try block is
			 * followed by the finally block.
			 * */
		}
	}
}