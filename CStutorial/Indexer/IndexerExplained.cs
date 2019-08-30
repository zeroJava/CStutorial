using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Indexer
{
	public class DummyClassIn
	{
		public string Name { get; set; }
	}

	/*
	 * Indexer is a function in C# that allows the user to access an
	 * internal collection within the class.
	 * It looks and behaves like an array.
	 * 
	 * */

	/*
	 * When the indexer is compiled, the compiler converts internally
	 * into two method called get_Item() and set_Item(int index, string value).
	 * */

	public class IndexerExplained
	{
		private DummyClassIn[] _items;

		public DummyClassIn this[int index]
		{
			get
			{
				if (_items == null)
				{
					throw new ApplicationException("Internal collection is null");
				}
				if (index >= _items.Length)
				{
					throw new ApplicationException("Out of range");
				}
				return _items[index];
			}
			set
			{
				if (_items == null)
				{
					throw new ApplicationException("Internal collection is null");
				}
				if (index >= _items.Length)
				{
					throw new ApplicationException("Out of range");
				}
				_items[index] = value;
			}
		}
	}

	/* this above is an example of custom indexer.
     * With the indexer, we modify the 'this' operator, and we define it to bring data from an array.
     * This allows our object to retreive data directly
     * e.g.
     * 
     * IndexerEg index = new IndexerEg();
     * System.Console.WriteLine(index[1]);
     * index[1] = "earth";
	 */


	/* Note::
	 * It's basically a function that microsoft added to make retrievel
	 * of items from a framework generic collection easier, i.e. replace
	 * getIndex(1) with[1], but they made it available to language wide.
	 * 
	 * Most cases, developers won't even create their own custom indexer.
	 * */
}
