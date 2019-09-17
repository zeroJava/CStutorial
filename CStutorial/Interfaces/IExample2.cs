using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Interfaces
{
    // Look at IExample1

    public interface IExample2 : IExample1
    {
        /*
         * Interfaces can inherit from another interface,
         * but you won't be able to overrite the method,
         * firstly because the method does not appear in
         * the child interface, and secondly, it's still
         * an iterface, som you won't be able to define
         * the method. 
         */

        int Number { get; set; }
    }
}
