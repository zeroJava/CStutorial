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
	 * same method signature, which it executes when the
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

			DelegateExampleOne deMultiOne = new DelegateExampleOne(MulitCastOne);
			deMultiOne += MulitCastTwo;
			deMultiOne += null; // create new object with no refrence.

			/*
			 * Adding is done by subscribing (+=), whereas
			 * removing is done by unsubscribing (-=).
			 * */

			/*
			 * The delegate below will work, and not throw an
			 * null expection.
			 * I will explain why.
			 * */

			/*
			 * Delegates are immutable, meaning the objects
			 * data can not be changed one an instance has
			 * been created.
			 * 
			 * Becuase delegates are immutable, when we the
			 * '+=' next to a delegate variable, the '+='
			 * is actually creating another delegate object.
			 * */

			DelegateExampleOne deMultiTwo = null;
			deMultiTwo += MulitCastOne;

			/*
			 * When method from an instance variable (object)
			 * is assigned to a delegate, the delegate holds
			 * a reference to the method, but also a reference
			 * of the object.
			 * */
		}

		public void MethodExampleTwo()
		{
			/*
			 * Delegates support generics.
			 * */

			/*
			 * C# has a predefine delegates type, with delegate
			 * method signatures the support upto 16 generic 
			 * parameters.
			 * 
			 * The predefined generic delegates are 'action' and
			 * 'func'.
			 * 
			 * 'action' delegate only accepts methods that are
			 * void.
			 * 
			 * 'func' delegate only accepts methods that return
			 * a value. 
			 * 
			 * The func delegates last generic type-parameter is
			 * the return type the func delegate expects from the
			 * methods will assign to.
			 * */

			Action<int> actionOne = DelActionOne;
			Func<int, string> funcOne = DelFuncOne;
		}

		private void MulitCastOne(int paramOne, string paramTwo)
		{
			Console.WriteLine("Multi Cast One.");
		}

		private void MulitCastTwo(int paramOne, string paramTwo)
		{
			Console.WriteLine("Multi Cat Two.");
		}

		private void DelActionOne(int number)
		{
			Console.WriteLine(number);
		}

		private string DelFuncOne(int number)
		{
			return string.Empty;
		}
	}
}
