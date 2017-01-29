using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Generics
{
    interface IGenericInterface<T>
    {
        /* Generics in iterface tell the compiler that data-type of the
         * type-parameter will be given when a class inherits the interface,
         * and thus all the properities that are oegged with a type-parameter
         * will have and actual data-type.
         * 
         * e.g.
         * class : IGenericInterface<string>
         * 
         * */

        void GenericMethod(T parameter1);
        /* This compiler will for the child class to inherit this method,
         * and with automatically (if done in ide) change it from generic
         * to and an actual data-type.
         * 
         * e.g. in sub class
         * string: GenericMethod(T parameter1) -- appear --> GenericMethod(string paramater1)
         * int: GenericMethod(T parameter1) -- appear --> GenericMethod(int paramater1)
         * */

        void GenericMethod2<S>(S parametr1);
    }
}
