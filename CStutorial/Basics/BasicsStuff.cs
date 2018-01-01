using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* This whole file is the the source code, which will be
 * compiled into an exe, which is our assembly/binary
 * */
namespace CStutorial.Basics
{
    public class BasicsStuff
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public object Universal { get; set; } // object data-type is a primitive data type equivalent of Object class in java.
        public bool State { get; set; }

        public BasicsStuff(int number)
        {
            this.Number = number;
        }

        public void Adding(int number)
        {
            int total = this.Number + number;
            Console.WriteLine("Adding the number: " + number + " with " + this.Number + " would equal: " + total);
        }

        public void Value_of_object()
        {
            System.Console.WriteLine("Value of object variable: Universal is " + Universal);
        }
    }
}
