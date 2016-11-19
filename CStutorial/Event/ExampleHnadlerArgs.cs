using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Event
{
    public class ExampleHnadlerArgs : EventArgs
    {
        public string Message { get; set; }

        public ExampleHnadlerArgs(string message)
        {
            Message = message;
        }
    }
}
