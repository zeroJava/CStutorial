using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Generics
{
    public class GenericInterfaceClass : IGenericInterface<string>
    {
        public void GenericMethod(string parameter1)
        {
            /* The paramater has been automatically changed form
             * type-parameter to string, becuase define the
             * data-type of type-parameter as string when inheriting.
             * */
            System.Console.WriteLine("GenericMethod: " + parameter1.GetType());
        }

        public void GenericMethod2<S>(S parametr1)
        {
            /* This generic method inherited from the interface
             * still has the type-parameter, because the type-parameter
             * is connected to the method head, and not to the interface.
             * */
            System.Console.WriteLine("GenericMethod2: " + parametr1.GetType());
        }
    }

    public class GenericInterfaceClass2<T> : IGenericInterface<T>
    {
        public void GenericMethod(T parameter1)
        {
            /* The paramater has been automatically changed form
             * type-parameter to string, becuase define the
             * data-type of type-parameter as string when inheriting.
             * */
            System.Console.WriteLine("GenericMethod: " + parameter1.GetType());
        }

        public void GenericMethod2<S>(S parametr1)
        {
            /* This generic method inherited from the interface
             * still has the type-parameter, because the type-parameter
             * is connected to the method head, and not to the interface.
             * */
            System.Console.WriteLine("GenericMethod2: " + parametr1.GetType());
        }
    }
}
