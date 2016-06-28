using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Event
{
    public delegate void EventExample1EventHandler();

    class EventsExample1
    {
        public event EventExample1EventHandler OEventHandler;

        public void Display()
        {
            System.Console.WriteLine("The event will be handled in different ways");
            OEventHandler();
        }
    }
}
