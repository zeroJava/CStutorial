using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Polymorphisms
{
    public class PolClass2 : PolClass1
    {
        public PolClass2() : base("::Connecting to PolClass1::")
        {
            System.Console.WriteLine(" ---------- | Polclass2 | ---------- ");
            PolMethod1();
        }

        public override void PolMethod1()
        {
            System.Console.WriteLine("PolMethod1: ::PolClass2:: ::Overrieded::.");
        }

        public new int PolMethod2()
        {
            return 10;
        }

        public override int PolMethod3()
        {
            return 10;
        }

        public void Pol2Method()
        {
            System.Console.WriteLine("Pol2Method:");
        }
    }
}
