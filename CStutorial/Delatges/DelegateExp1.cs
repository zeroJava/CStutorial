using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Delatges
{
	public delegate void DelegateExampleOne(int paramOne, string paramTwo);

	/*
	 * 'delegate' is a type (data-type) that allows methods
	 * to be referenced by a delegate objects.
	 * 
	 * In others words, a delegate is basically just a pla-
	 * ceholder that holds the location of a method with the
	 * same method signature, which it texecutes when the
	 * delegate objects calls the invoke function.
	 * 
	 * E.g.
	 * 
	 * TransformerDelegate tg = new TransformerDelegate(MethodOne);
	 * tg.Invoke(5);
	 * tg(5); // same a above.
	 * */

	/*
	 * The delegate variable is assigned a method during run
	 * time, i.e. when the method is created an placed into 
	 * memory.
	 * */

	public class DelegateExp1
	{
		public void MethodExample()
		{
			// Below creates deletegate objects;
			DelegateExampleOne deOne = new DelegateExampleOne(MulitCastOne);
			DelegateExampleOne deTwo = MulitCastOne; // Imlictly creates an object

			// executing object to call the reference method.
			deOne.Invoke(1, "One");
			deTwo(2, "Two");

			// Multicast delgates
			/*
			 * A delegate variable (object) can have multiple
			 * methods assigned to it, which mean that the de-
			 * legate object can hold reference to multple
			 * methods.
			 * 
			 * This means that, once we invoke the delegate
			 * object, it will called all the methods in its
			 * method-inventory (collection) sequentialy in
			 * the order they've been added.
			 * */

			/*
			 * Adding is done by subscribing (+=), whereas
			 * removing is done by unsubscribing (-=).
			 * */
			DelegateExampleOne deMultiOne = new DelegateExampleOne(MulitCastOne);
			deMultiOne += MulitCastTwo;
		}

		private void MulitCastOne(int paramOne, string paramTwo)
		{
			//
		}

		public void MulitCastTwo(int paramOne, string paramTwo)
		{

		}
	}
}
