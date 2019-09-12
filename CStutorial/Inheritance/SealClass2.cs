using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Inheritance
{
	public sealed class SealClass2 : SealClass1
	{
		/*
		 * When we mark a method or class with the sealed
		 * keyword, we tell the compiler that this is the
		 * final version of this class or method, i.e. the
		 * class cannot be inherited or the method cannot
		 * be overridden.
		 * */

		/*
		 * 'sealed' on method (only overridden), means this
		 * is the last version of the display function in the
		 * inheritance tree.
		 * */
		public sealed override void Display()
		{
			base.Display();
		}
	}
}
