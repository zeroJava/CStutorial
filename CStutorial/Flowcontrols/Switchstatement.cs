using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Flowcontrols
{
    class Switchstatement
    {
        public string Fruit { get; set; }

        public void CheckinRepo()
        {
            switch(Fruit.ToLower())
            {
                case "apple":
                    System.Console.WriteLine("Apple is in repo");
                    break;
                case "pear":
                    System.Console.WriteLine("Pear is in repo");
                    break;
                case "banana":
                    System.Console.WriteLine("Banana is in repo");
                    break;
                default:
                    System.Console.WriteLine("Could not find a match");
                    break;
            }
        }
    }
}
