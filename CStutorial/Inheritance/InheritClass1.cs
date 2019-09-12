using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Inheritance
{
    public class InheritClass1
    {
		private int _defaultV;
		private int _number = 5;

		/*
		 * Field initialiser is always execute before the constructor
		 * is executed, initialising it with literal or defualt values,
		 * i.e. before the compiler lands on the constructor, it
		 * initialises the variables in the class.
		 * */

		/*
		 * Because fields are initialised first, the question is, in in-
		 * heritance, what is the order of initialisation.
		 * 
		 * When we create a new object, the field initialisation of the
		 * object (i.e the subclass) is initialised first, then the base
		 * keyword is called, before the base constructor is executed,
		 * the base classs field are initialised.
		 * 
		 * E.g.
		 * 
		 * class BaseClass
		 * {
		 *		virtual int number { get; set; } = 5; // -3-
		 *		
		 *		BaseClass() // automatic constructor
		 *		{
		 *			// -4-
		 *		}
		 * }
		 * 
		 * class SubclassOne : BaseClass
		 * {
		 *		override int number { get; set } = 10; // -1-
		 *		SubclassOne(int x)
		 *		{
		 *			// base() automatically base constructor called // -2-
		 *			// rest of the operations executed -5-
		 *		}
		 * }
		 * 
		 * */

		public virtual string Name { get; set; } = "Inheritance1";
		public virtual string Address { get; set; } = "Address in inheritance 1";
		public virtual int Age { get; set; } = 10;

		static InheritClass1()
		{
			/*
			 * A static constructor is basically a constructor that is used to
			 * initialise all static fields in the class.
			 * 
			 * A class can have only have one static constructor, and it needs
			 * to be parameterless.
			 * */
		}

        public InheritClass1()
        {
            System.Console.WriteLine("Inside the Class1() constructor with no");
            System.Console.WriteLine(Name + " " + Age + " " + Address);
            Display();
        }

        public InheritClass1(string name) : this() // invoking the constructor above
        {
            this.Name = name;
        }

        public InheritClass1(string Name, int Age) : this(Name)
        {
            this.Age = Age;
        }

		~InheritClass1()	// Finalizer
		{
			/*
			 * A finalizer is method that is executed during the compilers garbage
			 * collection process, which the compiler cleans up unnecessary and
			 * unreferenced objects.
			 * 
			 * The finalizer is an optional function, which we add to release
			 * connected events and obects.
			 * 
			 * Unlike normal functions, the finalizer cannot be called in the code,
			 * it's only called ny the garbage collector.
			 * */

			/*
			 * To define a finalizer, we use a special syntax: '~', which we use
			 * with a function with the same name as the class.
			 * 
			 * E.g.
			 * ~Class()		// Define finalizer
			 * {
			 *		//  Do Not have empty finalizer.
			 * }
			 * 
			 * When the garbage collector is running, and see that this class has
			 * a garbage collector, the compiler will put into a finalizer queue,
			 * and then execute first-in-first-out process.
			 * 
			 * */

			/*
			 * '~' syntax is actually a synthetic sugar, which actually overrides
			 * the 'finalize()' function from the 'Object' class.
			 * 
			 * E.g.
			 * 
			 * ~Class()
			 * {
			 *		x = null;
			 * }
			 * 
			 * the compiler converts it to the statement below.
			 * 
			 * protected override void finalize()
			 * {
			 *		x = null;
			 *		base.Finalize();
			 * }
			 * 
			 * */
			Age = 0;
		}

        public virtual void Display()
        {
            System.Console.WriteLine("Yo wagi in class 1");
        }
    }
}
