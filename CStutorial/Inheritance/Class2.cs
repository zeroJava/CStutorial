using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Inheritance
{
	public class Class2 : Class1
	{
		/*
		 * A class can inherit non-private members from another
		 * class, which is know as inheritance.
		 * 
		 * Inheritance allows us to access and get members (i.e.
		 * variables and functions) from one class (ClassA), copy
		 * some of the functions (overwrite) into another class
		 * (ClassB), and change the behaviour to suit the needs of
		 * ClassB.
		 * 
		 * With inheritance, we create a parent-child relationship
		 * between the tewo classes, with parent (base) being the
		 * class we're inheriting from, and the child (subclass)
		 * being the class that is inheriting.
		 * */

		/*
		 * If the parent class does not have default constructor
		 * i.e. parameterless constructor either added manually or
		 * by the compiler, the compiler will throw compiler error
		 * saying that it cannot find a match that takes zero
		 * arguments. This means that user must explictly call one
		 * of the contructors from the parent class using the base
		 * statement.
		 * */

		public Class2(string name)
		{
			/*
			 * When this constructor is called, it also automatica-
			 * lly calls the default parameterless constructor in
			 * the parent class.
			 * 
			 * If there isn't any default parameterless constructor
			 * in the parent class, then the compiler throws a
			 * compiler error, and thus we have to excplictly call
			 * one of the constructors from the parent class using
			 * the base statement.
			 * */
		}

		// base class is the equivalent to super() or super in java
		public Class2(string Name, int Age) : base(Name, Age) // 
		{
			/*
			 * When the parent
			 * */
			base.Address = "154 Welling street";
		}

		public override void Display()
		{
			System.Console.WriteLine("Hello in class 2");
		}
	}
}
