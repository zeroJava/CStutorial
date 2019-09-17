using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Interfaces
{
    public class IterfaceExampleClass : IExample1, IExample3
    {
        /* 
         * The method are being explictly inherited from the interface, 
         * meaning, for the method name and dot (.) is the name of the
         * interface that it came from.
         * 
         * The done to prevent a situation where you inherited from
         * muliple interface, and some them may have method with the same
         * name, and to prevent conflict, we inherit it explictly. 
         * */
        void IExample3.Method1()
        {
            throw new NotImplementedException();
        }

        void IExample1.Method1()
        {
            /*
             * Explictly implemented interfaces cannot be marked virtual
             * or overridden.
             * */
            throw new NotImplementedException();
        }

        public virtual void Method2()
        {
            /*
             * When a method is inherited from the interface, the compiler
             * implictly (automatically) marks the inherited method a sealed.
             * 
             * This means that class inheriting from this class, will not
             * inherit this method, and thus will not be able to overwrite the
             * definition.
             * 
             * To enable override, we have to mark the inherited method as
             * virtual or abstract.
             * */
            Console.WriteLine("Virual added to remove seal");
        }
    }
}
