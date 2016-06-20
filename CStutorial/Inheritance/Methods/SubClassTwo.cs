using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Inheritance.Methods
{
    class SubClassTwo : SubClassOne
    {
        public void MethodTwo()
        {
            System.Console.WriteLine("This is methodTwo in subclassTwo that has not been overitten");
        }
    }
}
