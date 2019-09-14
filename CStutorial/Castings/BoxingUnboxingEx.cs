using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Castings
{
	public class BoxingUnboxingEx
	{
		public void Boxing()
		{
			/*
			 * Boxing is the act of converting a value-type
			 * instance to a reference-type instance (Alba-
			 * hari).
			 * 
			 * Basically it's similar to downcasting; the
			 * difference is that boxing creates another
			 * instance when converting value-types instant
			 * to object instant, were as downcasting just
			 * creates a reference.
			 * 
			 * It can only box value-types that are object
			 * class or interface (more info); this is be-
			 * cause object is the base class for all class. 
			 * 
			 * */

			/*
			 * How it works.
			 * When we're boxing, the compiler copies the
			 * value of the value-type, creates a new ob-
			 * ject instance, and then copies the value
			 * into it.
			 * */

			int number = 10;
			object numberBoxed = number;
			// boxing to done implictly, the compiler doesn't
			// need any help.
		}

		public void Unboxing()
		{
			/*
			 * If boxing is converting a value-type instance
			 * to a reference-type instance, then 'Unboxing'
			 * is the reverse the process, which is convert-
			 * ing the reference-type instance back to a
			 * value-type instance, i.e. returning the value
			 * back to it original state.
			 * 
			 * Normally unboxing happen after boxing, i.e.
			 * you're unboxing a value that has boxed earlier
			 * in the code.
			 * */

			/*
			 * Unboxing is done explictly, i.e. we have to
			 * tell the compiler that we're converting the
			 * value from the reference-type to a value-type.
			 * 
			 * E.g.
			 * int numberUnboxed = (int)numberBoxed;
			 * // (int) is explictly telling them to convert to
			 * */

			/*
			 * How it works.
			 * When unboxing the compiler get the value from
			 * the reference-type (object) instance, and copies
			 * it into a new value-type instance.
			 * */

			int number = 10;
			object numberBoxed = number;
			int numberUnboxed = (int)numberBoxed;
		}
	}
}
