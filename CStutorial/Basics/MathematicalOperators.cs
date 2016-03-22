using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Basics
{
    class MathematicalOperators
    {
        public static void DisplayFunctionalities()
        {
            System.Console.WriteLine("+: 10 + 100 = " + (10 + 100) );
            System.Console.WriteLine("-: 500 - 50 = " + (500 - 50) );
            System.Console.WriteLine("*: 1000 * 10 = " + (1000 * 10) );
            System.Console.WriteLine("/: 500 / 5 = " + (500 / 5) );
            System.Console.WriteLine("remainder of : 98 % 3 is " + (98 % 3));

            System.Console.WriteLine("");

            int nubmer = 100;
            System.Console.WriteLine("number++ : " + nubmer++);
            System.Console.WriteLine("number : " + nubmer);
            System.Console.WriteLine("++number : " + ++nubmer);

            System.Console.WriteLine("");

            int nubmer2 = 10;
            System.Console.WriteLine("number-- : " + nubmer2--);
            System.Console.WriteLine("number : " + nubmer2);
            System.Console.WriteLine("--number : " + --nubmer2);
        }
    }
}
