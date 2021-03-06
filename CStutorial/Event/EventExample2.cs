﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Event
{
    class EventExample2
    {
        EventsExample1 _example1 = new EventsExample1();

        public void Execute()
        {
            _example1.OEventHandler += OnHandler; // Subscribing the handler
            _example1.OEventHandler2 += OnhandlerTwo; //
            _example1.Display();
        }

        private void OnHandler()
        {
            System.Console.WriteLine("Inside the onnhandler method in EventExample2");
        }

        private void OnhandlerTwo(object source, ExampleHnadlerArgs receiver)
        {
            System.Console.WriteLine("Inside the onnhandlerTwo method in EventExample2. " + receiver.Message);
        }
    }
}
