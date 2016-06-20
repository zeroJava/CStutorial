using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Interfaces
{
    class IterfaceExampleClass : IExample1, IExample2
    {
        /* The method are being explictly inherited from the interface, meaning, for the method name and dot (.) is the name of the interface that it came from.
         * 
         * The done to prevent a situation where you inherited from muliple interface, and some them may have method with the same name, and to prevent conflict, we
         * inherit it explictly. 
         * */
        void IExample2.Method1()
        {
            throw new NotImplementedException();
        }

        void IExample1.Method1()
        {
            throw new NotImplementedException();
        }

        void IExample2.Method2()
        {
            throw new NotImplementedException();
        }

        void IExample1.Method2()
        {
            throw new NotImplementedException();
        }
    }
}
