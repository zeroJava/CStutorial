using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Generics
{
    public class GenericClass<T>
    {
        /* Generic allows us to use type parameter which act a placeholder, 
         * which gives us the option to add any data type we want when we 
         * use it.
         * 
         * By adding a type-argument, we start to define the type of data
         * generics can handle.
         * */

        /*
         * GenericClass<T> is referred as an open-type.
         * GenericClass<int> is referred as a close-type.
         * At runtime all generic type instances become closed.
         * */
        public T Property1 { get; set; }
        public T Property2 { get; set; }

        public void Display()
        {
            System.Console.WriteLine("Value of prop1 " + Property1 + " and prop2 " + Property2);
        }
    }
}
