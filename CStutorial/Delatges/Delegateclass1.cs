using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Delatges
{
    public delegate void DisplayData(string message);

    class Delegateclass1
    {
        public void Meth1(string name)
        {
            System.Console.WriteLine(name + " Hello from the otherside side");
        }

        public void Meth2(string name)
        {
            System.Console.WriteLine(name + " Hello from the otherside 2");
        } // this method will used to demonstrate delegate with instant objects and its methods

        public static void Method1(string message)
        {
            System.Console.WriteLine(message + " Display method 1");
        }

        public static void Method2(string name)
        {
            System.Console.WriteLine(name + " Hello from method 2");
        }

        public static void Method3(string name)
        {
            Delegateclass2.Runtime(Method2, name);
            /* Method3 will be used as part of a delegate, which in turn will call another delegate.
             * Delegateclass2 will indirectly call the method2 method in Delegateclass 1 from Delegateclass2 using a delegate 
             * */
        }

        /* What is delegate?
         * 
         * A delegate is a feature in c# that allows us to point (reference ) to a method in another class.
         * Basically, it allows us to call a method in-directly. 
         * So in the dictionary the word deleate means representive of a group or some entity.
         * Like the defination in the dictionary, the delegate keyword allows us to create representive pointing to the desired method.
         * 
         */

        /* How is does if know
         * When we the delegate, we have asscoiate with the method that we to point to
         * e.g
         * Delegation _del = new Delegation(Class.Diplay);
         * _del("Display this meaage");
         * */
    }
}
