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
    public class CovarianceAndContavarianceEx
    {
        /*
         * Covariance and contravariance means convertable
         * by implict reference conversion (Albahari). 
         * */

        public void ConvarianceExample()
        {
            /*
             * Covariance in generic means that a data-type (interface
             * or class) with a base type-parameter can hold data-type
             * (base or subclass) with a child type-parameter.
             * 
             * I.e.
             * Basically covariance just means that, after marking the
             * iterfaces type-parameter with the 'out' keyword, the
             * compiler will check if the data-type of the variable is
             * parent data-type of the value, and also check if the generic
             * type-parameter is also the parent type-parameter of the
             * values generic.
             * 
             * E.g.
             * IEnumrable<IExample1> covariance1 = new List<InterfaceExampleClass>();
             * IEnumrable is the base of List.
             * IExample1 is the base of InterfaceExampleClass.
             * 
             * */

            ICovariance<IExample1> covariance1 = new CovarianceAndContravarianceImpl<InterfaceExampleClass>();
        }

        public void ContravarianceExample()
        {
            /*
             * Contravariance is the opposite of covariance, which co-
             * nvert a parent type-parameter to a sub- class data-type
             * with a sublclass generic type-parameter.
             * 
             * I.e.
             * Basically covariance just means that, after marking the
             * interfaces type-parameter with the 'in' keyword, the co-
             * mpiler will check if the check if the generic type-par-
             * ameter is the child type-parameter of the values generic.
             * 
             * */

            CovarianceAndContravarianceImpl<IExample1> covariance1 = new CovarianceAndContravarianceImpl<IExample1>();
            IContraVariance<InterfaceExampleClass> contraVariance1 = covariance1;
        }

        public void WithoutVarianceExample()
        {
            // IStandardGen<IExample1> standardGen = new IStandardGenIml<IExample2>();
            // The above will throw an error. 
        }
    }
}