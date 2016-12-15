using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.FuncsNActions
{
    public class ActionExampleTwo
    {
        public ActionExampleTwo()
        {
            //
        }

        public void Execute()
        {
            ActionExampleOne act1 = new ActionExampleOne();
            act1.ActionDelg += Display;
            act1.Execute();
        }

        private void Display()
        {
            System.Console.WriteLine("We are in the ActionExampleTwo.");
        }
    }
}
