using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Inheritance
{
    class Class1
    {
		private int _defaultV;
		private int _number = 5;

		/*
		 * Field initialiser is always execute before the constructor
		 * is executed, initialising it with literal or defualt values,
		 * i.e. before the compiler lands on the constructor, it
		 * initialises the variables in the class.
		 * */

        public virtual string Name { get; set; }
        public virtual int Age { get; set; }
        public virtual string Address { get; set; }

		static Class1()
		{
			/*
			 * A static constructor is basically a constructure that is used to
			 * initialise all static fields in the class.
			 * 
			 * A class can have only have one static constructor, and it needs to
			 * be parameterless.
			 * */
		}

        public Class1()
        {
            System.Console.WriteLine("Inside the Class1() constructor with no");
            System.Console.WriteLine(Name + " " + Age + " " + Address);
            Display();
        }

        public Class1(string name) : this() // invoking the constructor above
        {
            this.Name = name;
        }

        public Class1(string Name, int Age) : this(Name)
        {
            this.Age = Age;
        }

        public virtual void Display()
        {
            System.Console.WriteLine("Yo wagi in class 1");
        }
    }
}
