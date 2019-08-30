using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Statics
{
	/*
	 * The static modifier makes the members of a class i.e. fields,
	 * properties and functions static, meaning that the members
	 * have only one copy that can only be accessed via the class,
	 * and not an instance (object) of the class.
	 * */

	/* Marking a class static mean that this class can only hold static
	 * members.
	 * */
	public static class StaticEnglained
	{
		public static int Number = 5; 
		/*
		 * Static field initialiser is always run before the static constructor,
		 * similar to a normal constructor; the same applies if there is no
		 * static constructor, but it will only initialise everything when a
		 * member is called or earlier (depending on runtime).
		 * */

		/*
		 * Static fields initialiser initialises the fields in the order they
		 * come in.
		 * */

		static StaticEnglained()
		{
			/*
			 * A static constructor is basically a constructure that is used to
			 * initialise all static fields in the class.
			 * 
			 * A class can have only have one static constructor, and it needs to
			 * be parameterless.
			 * */

			/*
			 * Static constructors are only invoked once, which is when anything
			 * referencing the class is invoked i.e. creating an object or calling
			 * an static member will automatically execute the static constructor,
			 * and after that, it never execute again.
			 * */
		}
	}
}
