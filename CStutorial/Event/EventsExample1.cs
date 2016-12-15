using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Event
{
    public delegate void EventExample1EventHandler();
    public delegate void EventExample1EventHandler2(object source, ExampleHnadlerArgs reciever);

    public class EventsExample1
    {
        public event EventExample1EventHandler OEventHandler;
        public event EventExample1EventHandler2 OEventHandler2;

        public void Display()
        {
            System.Console.WriteLine("The event will be handled in different ways");
            OEventHandler();
            /* The event here acts like a place holder, telling the compiler that this
             * event here is a place-holder and I expect who ever uses this class and 
             * the Display() function will have to define the function of this method
             * (event-handler)
             * */

            /* It is vital that event is given a method (ActionDelg) to subscribe to, before
             * this display function is used, becuase it throw an NullReferenceException
             * if not subscribed. 
             * */

            OEventHandler2(this, new ExampleHnadlerArgs("Hello world, and hello everybody"));
        }
    }
}
