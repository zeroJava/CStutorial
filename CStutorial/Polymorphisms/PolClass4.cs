using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Polymorphisms
{
    public class PolClass4 : PolClass3
    {
        public PolClass4() : base()
        {
            System.Console.WriteLine(" ---------- | Polclass4 | ---------- ");
            PolMethod1();
        }

        public override void PolMethod1()
        {
            System.Console.WriteLine("PolMethod1: ::PolClass3:: ::Overrieded:: ::Heirachy::");
        }
    }
}
