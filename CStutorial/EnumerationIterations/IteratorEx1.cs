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

	/*
	 * This link shows how the compiler compiles the
	 * yield blocks to code.
	 * 
	 * https://csharpindepth.com/articles/IteratorBlockImplementation
	 */

	public class IteratorEx1
	{
		/*
		 * An iterator is a method, property or
		 * indexer, which contains a yield
		 * statement. 
		 * */
		
		/*
		 * using yield marks the method as an
		 * iterator, which returns a ienumrable
		 * object.
		 * 
		 * Behind the scene, when yield is used,
		 * c# create a hidden ienumerable class.
		 * */

		/* An itertor means something that will
		 * let you traverse through the collection
		 * of items.
		 * */

		/*
		 * An iterator must return either an
		 * IEnumerable or IEnumerator.
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
			 * Adding yield to make the method into an
			 * iterator.
			 * */

			/*
			 * Iterators, when compiled, is converted
			 * to a private class that implements both
			 * the IEnumerable and IEnumerator.
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

			/*
			 * Note
			 *
			 * When execute an iterator, the method does
			 * NOT create collection, and return the
			 * whole collection.
			 * 
			 * Instead, create a state machine, which
			 * repeatlty goes into the method and returns
			 * a value.
			 * */

			/*
			 * Iterator is used by forach loops, so for
			 * every iteration, the compiler comes into
			 * this method, and then perform a any operation
			 * until reaches a yield statement.
			 * */

			/*
			 * When it reaches a yield statement, the
			 * compiler saves location of the yield
			 * statement location, and leaved the method
			 * with the value.
			 * */

			/*
			 * During the next iteration, the compiler
			 * being from the where it left of during
			 * the previous iteration.
			 * */
			

			// During the first iteration, the copiler
			// will execute this.
			Console.WriteLine("1");
			yield return 1;

			// Once we reach the yield statement, the
			// compiler will save the position, and
			// return the value 1.

			// When the foreach executes a next cycle
			// the compiler will start from the line
			// writeline(2). 
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

			// Also when using the yield return statment,
			// we cannot use the normal return statement
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