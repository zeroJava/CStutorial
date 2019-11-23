using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.EnumerationIterations
{
	public class EnumerationEx1
	{
		/*
		 * Enumerating is the action of going through
		 * a collection of elements (values).
		 * 
		 * An enumerator is an object that contains the
		 * definition on how traverse through the
		 * collection in a forward/decending motion.
		 * 
		 * */

		/* 
		 * It's because of enumerators that collection
		 * can loop through an foreach loop.
		 * */

		/*
		 * An emunerator is an object of a class that
		 * implements the Collection.IEnumerator and
		 * Collection.Generic.IEnumertor<T>.
		 * 
		 * */

		/*
		 * Most of the time, the enumerator is done
		 * for us, so you don't how create one
		 * yourself, '.net' has already has done that
		 * for you.
		 * 
		 * */

		public void EnumeratorExampleExecute()
		{
			/*
			 * As mentioned before, the foreach needs an
			 * an enumerator, for it to loop the collection.
			 * 
			 * Foreach is consumer of a enumerator, meaning
			 * if uses it to work.
			 * 
			 * The code below demonstrates how the compiler
			 * writes the foreach loop behined the scenes
			 * when compiled.
			 * */

			// This foreach loop will...
			List<int> list = new List<int> { 1, 2, 3, 4, 5 };
			foreach (int number in list)
			{
				Console.WriteLine(number);
			}

			// Get converted to something this, when compiled.

			IEnumerator<int> enumerator = list.GetEnumerator();
			while (enumerator.MoveNext())
			{
				int number = enumerator.Current;
				Console.WriteLine(number);
			}
		}
	}
}
