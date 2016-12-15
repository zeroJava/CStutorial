using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.FuncsNActions
{
    public class ActionExampleOne
    {
        public event Action ActionDelg; 

        public ActionExampleOne()
        {
            //
        }

        public void Execute()
        {
            System.Console.WriteLine("We are in the ActionExampleOne class, and we are going to execute an Action delegate.");
            ActionDelg();
        }
    }
}
