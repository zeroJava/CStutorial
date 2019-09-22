using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CStutorial.Generics;
using CStutorial.Inheritance;

namespace CStutorial.Covariance_Contravariance
{
    public class Covariance
    {
        public void ConvarianceExample()
        {
            /*
             * Convariance in generic means that a data-type
             * with type-parameter with base can convert to
             * a data-type of the same data type but with a
             * subclass type-parameter.
             * */

            IGenericInterface<InheritClass2> eg1 = new GenericInterfaceClass2<InheritClass2>();
            IGenericInterface<InheritClass1> converianceEg1 = eg1;
        }

        /*
         * Covariance and contravariance means convertable
         * by implict reference conversion (Albahari). 
         * */
    }
}