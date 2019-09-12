using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Inheritance
{
	public class InheritClass3 : InheritClass2
	{
		/*
		 * If the parent class does not have default constructor
		 * i.e. parameterless constructor either added manually or
		 * by the compiler, the compiler will throw compiler error
		 * saying that it cannot find a match that takes zero
		 * arguments. This means that user must explictly call one
		 * of the contructors from the parent class using the base
		 * statement.
		 * */

		public InheritClass3() : base("")
		{
			/*
			 * If there isn't any default parameterless constructor
			 * in the parent class, then the compiler throws a
			 * compiler error, and thus we have to excplictly call
			 * one of the constructors from the parent class.
			 * 
			 * But if parent class does have a parameterless constr-
			 * uctor, then it is auto-matically called by the compiler.
			 * */
		}

		public override void Display()
		{
			Console.WriteLine("Inside class three.");
		}
	}
}
