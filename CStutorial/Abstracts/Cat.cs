using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Abstracts
{
    class Cat : Animal
    {
        public Cat(string name, string species) : base(name)
        {
            base.Food = "cat food";
        }

        public override void Display()
        {
            Console.WriteLine("hello, this is a cat");
        }

        public override string Movement()
        {
            return "cat speed is 15 mph";
        }
    }
}
