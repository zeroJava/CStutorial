using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Delatges
{
    class Delegateclass2
    {
        public delegate void DelegationM(string name);

        public static void Runtime(DelegationM del, string name)
        {
            /* DelegationM del is a delegate.
             * But also in this method, DelegationM del also acts like a parameter whose arguments will be a method 
             * */

            del(name);
            // check method3, to see it being used
        }

        public void Execute()
        {
            CStutorial.Delatges.Delegateclass1 _object = new Delegateclass1();
            CStutorial.Delatges.DisplayData _dis1 = _object.Meth1;
            CStutorial.Delatges.DisplayData _dis2 = _object.Meth2;
            _dis1("Johnatheeen");
            _dis2("Brannn");
        }

        /* The runtime method demonstrates how we use delegates when dealing with methods that are static.
         * The execute method demonstrated how we use delegates when dealing with methods that are NOT static. 
         * */
    }
}
