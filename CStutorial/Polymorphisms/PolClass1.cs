using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Polymorphisms
{
    public class PolClass1
    {
        public PolClass1()
        {
            System.Console.WriteLine("Inside polClass1 constructor.");
        }

        public PolClass1(string word)
        {
            System.Console.WriteLine("Inside polClass1 second constructor " + word + ".");
            PolMethod1();
            System.Console.WriteLine("PolMethod2: " + PolMethod2());
            System.Console.WriteLine("PolMethod3: " + PolMethod3());
        }

        public virtual void PolMethod1()
        {
            System.Console.WriteLine("PolMethod1: PolClass1.");
        }

        public int PolMethod2()
        {
            return 0;
        }

        public virtual int PolMethod3()
        {
            return 0;
        }
    }
}
