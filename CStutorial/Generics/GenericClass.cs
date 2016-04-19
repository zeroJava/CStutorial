using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Generics
{
    class GenericClass<T>
    {
        public T Property1 { get; set; }
        public T Property2 { get; set; }

        public void Display()
        {
            System.Console.WriteLine("Value of prop1 " + Property1 + " and prop2 " + Property2);
        }

        /* generic allows us to use type parameter which act a placeholder, which gives us the option to add any data type we want when we use it. 
         * */
    }
}
