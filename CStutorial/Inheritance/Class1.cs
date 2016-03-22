using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Inheritance
{
    class Class1
    {
        public virtual string Name { get; set; }
        public virtual int Age { get; set; }
        public virtual string Address { get; set; }

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
