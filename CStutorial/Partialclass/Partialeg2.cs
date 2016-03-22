using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Partialclass
{
    partial class Partialeg
    {
        public string Address { get; set; }

        public void SecondLine()
        {
            System.Console.WriteLine("I could see it your eye; I could see it in your...");
        }
    }
}
