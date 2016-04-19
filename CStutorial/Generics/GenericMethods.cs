using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Generics
{
    class GenericMethods<T>
    {
        public static void Display(T value)
        {
            System.Console.WriteLine("This using generic method with having the type parameter in the class name section. The value " + value);
        }

        public static void DisplayData<D>(D value)
        {
            System.Console.WriteLine("This using generic method with having the type parameter in the method name section. The value " + value);
        }
    }
}
