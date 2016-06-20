using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Inheritance.Methods
{
    class BaseClass
    {
        public virtual int ID { get; set; }
        
        public void MethodOne()
        {
            System.Console.WriteLine("This is method one, the non-virtual method in the base class");
        }

        /* For a method from the base class to have to ability to be overridden in the sub-class, it has to to be marked with keyword virtual.
         * By assigning the keyword virtual, we are saying that this method can be overriden in the sub-class.
         */
        public virtual void MethodTwo()
        {
            System.Console.WriteLine("This is method two, the virtual method in the base class");
        }
    }
}
