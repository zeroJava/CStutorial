using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Polymorphisms
{
    public class PolClass3 : PolClass2
    {
        public PolClass3() : base()
        {
            System.Console.WriteLine(" ---------- | Polclass3 | ---------- ");
            PolMethod1();
        }

        public override void PolMethod1()
        {
            System.Console.WriteLine("PolMethod1: ::PolClass3:: ::Overrieded:: ::Stack::");
        }
    }
}
