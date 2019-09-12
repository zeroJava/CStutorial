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
            System.Console.WriteLine("This method is using generic by having the"
                +" type parameter in the class name section. The value " + value);

            /* Generics are place holders, which occupy the data-type slot,
             * and wait for the developer to give them a data-type when
             * the class or function is used.
             * 
             * The T is the place holder, whose data-type will be defined later on
             * when we use the GenericMethods class.
             * 
             * e.g.
             * GenericMethods<int> example = new GenericMethod<int>();
             * */
        }

        public static void DisplayData<D>(D value)
        {
            System.Console.WriteLine("This method is using generic by having the"
                + " type parameter in the method name section. The value " + value);

            /* Here we have a generic method where the tye-parameter is attached to
             * the method name.
             * Here we tell the compiler that the data-type of the type-parameter
             * will be defined, when we call the method.
             * 
             * e.g
             * GenericMethods<string>.DisplayData<int>(5);
             * */
        }

        public static void DisplatGenricOfCertainType<X>(X value) where X : CStutorial.Inheritance.InheritClass1
        {
            System.Console.WriteLine("This generic method has a constraint put on"
                + " our type-parameter, saying the type-parameter must be an"
                 + "Arrayexample or a descendent of Arrayexample" + value.Address); // the value here will display the reference

            /* This generic method put a constraint on our type-parameter, say
             * that the only type of data the generic method can use is either
             * a instance of class1 or instance of a subclass of claas1
             * */
        }
    }
}
