using CStutorial.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Castings
{
	/*
	 * When casting an object from one type to another
	 * type, the comiler is doing a reference conversion
	 * up or down the class heirachy know as upcasting
	 * and downcasting.
	 * */

	/*
	 * Note::
	 * Upcasting is done automatically by the compiler
	 * e.g. when assigning sublcass value to variable
	 * or arguments in a method parameter that is a base
	 * class type.
	 * 
	 * Downcasting is something developer has manually
	 * specific to the compiler to cast from the base
	 * to the subclass type.
	 * */

	public class Asclasseg
	{
		public Asclasseg()
		{
			/* 
			 * Upcasting.
			 * Upcasting is when we assign a variable with base
			 * type the value (another variable) of the subclass
			 * type, which implictly (automatically) converts the
			 * value (of sublclass type) to base class type, then
			 * assigns it to the base class variable.
			 *  
			 * E.g
			 * Subclass s1 = new Subclass();
			 * Baseclass b1 = s1; // implictly upcast.
			 * */

			/* Even with the upcasting, the upcasted variable will
			 * create a new reference that point to the Sublcass
			 * object, thus it will use the subclass versions of
			 * the class members (variables and methods).
			 * */

			InheritClass2 c2Obj = new InheritClass2("Upcasting");
			InheritClass1 c1Obj = c2Obj; // implict upcast

			/*
			 * Downcasting
			 * Downcasting is when we assign a variable with subcl-
			 * ass type the value (another variable) of the base
			 * class type, which explictly converts the value (of
			 * base class type) to the subclass type, then assigns
			 * it to the subclass variable.
			 * 
			 * E.g
			 * Subclass s1 = new Subclass();
			 * Baseclass b1 = s1; // implictly upcast.
			 * Sublcass s2 = (Basclass)b1; // explict downcast.
			 * */

			InheritClass2 c2 = new InheritClass2("Upcasting");
			InheritClass1 c1 = c2; // implicit upcast
			InheritClass2 c3 = (InheritClass2)c1; // explicit downcast
			// See here, we have tell the compiler explicitly to
			// convert c1 and return a subclass type.
		}

		// string _string = A as B;
		// 'as' keyword can be used to cast
	}
}
