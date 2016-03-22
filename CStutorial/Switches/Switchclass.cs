using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Switches
{
    class Switchclass
    {
        public int Value { get; set; }

        public void ListOfEverything()
        {
            switch(this.Value)
            {
                case 1:
                    System.Console.WriteLine("You are number 1");
                    break;
                case 2:
                    System.Console.WriteLine("You are number 2");
                    break;
                case 3:
                    System.Console.WriteLine("You are number 3");
                    break;
                case 4:
                    System.Console.WriteLine("Okay, this getting boring");
                    break;
                case 5:
                    System.Console.WriteLine("Still?");
                    break;
                case 6:
                    System.Console.WriteLine("Dude");
                    break;
                case 7:
                    System.Console.WriteLine("Realy");
                    break;
                default:
                    System.Console.WriteLine("Error");
                    break;
            }
        }
    }
}
