using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Delatges
{
    public delegate void DisplayData(string message);

    class Delegateclass1
    {
        public void Method1(string message)
        {
            System.Console.WriteLine(message + " Display method 1");
        }

        public void Method2(string message)
        {
            System.Console.WriteLine(message + " Hello from method 2");
        }
    }
}
