using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CStutorial.Generics;
using CStutorial.Inheritance;
using CStutorial.Interfaces;

namespace CStutorial.Covariance_Contravariance
{
    public class Covariance
    {
        public void ConvarianceExample()
        {
            /*
             * Covariance in generic means that a base data-type
             * with base type-parameter can hold child data-type
             * with a child type-parameter.
             * 
             * I.e.
             * Basically covariance just means that, after marking
             * the type-parameter with the 'out' keyword, the
             * compiler will check if the data-type of the variable
             * is base data-type, and also check if the generic
             * type-parameter is also the base type-parameter of the
             * values generic.
             * 
             * E.g.
             * IEnumrable<IExample1> covariance1 = new List<InterfaceExampleClass>();
             * IEnumrable is the base of List.
             * IExample1 is the base of InterfaceExampleClass.
             * 
             * */
            ICovariaceGeneric<IExample1> covariance1 = new CovarianceIml<InterfaceExampleClass>();

            //covariance1.GetCovarianceExampleObject(new IStandardGenIml<IExample2>());
            //IStandardGen<IExample2> example1 = new IStandardGenIml<IExample2>();
            //covariance1.GetCovarianceExampleObject(example1);
        }

        /*
         * Covariance and contravariance means convertable
         * by implict reference conversion (Albahari). 
         * */
    }
}