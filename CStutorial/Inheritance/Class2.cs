using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Inheritance
{
    class Class2 : Class1
    {
        // base class is the equivalent to super() or super in java
        public Class2(string Name, int Age) : base(Name, Age) // 
        {
            base.Address = "154 Welling street";
        }

        public override void Display()
        {
            System.Console.WriteLine("Hello in class 2");
        }
    }
}
