using CStutorial.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Covariance_Contravariance
{
    /* 
     * Marking the generic type-parameter in an interf-
     * ace with the 'out' keyword, makes it a covariance.
     * 
     * Btw Interface, delegates and arrays allow covar-
     * iance; you can't do it with classes.
     * */
    public interface ICovariance<out TCovariance>
    {
        /*
         * Covariance in generic means that a data-type (interface
         * or class) with a base type-parameter can hold data-type
         * (base or subclass) with a child type-parameter.
         * 
         * I.e.
         * Basically covariance just means that, after marking the
         * interfaces type-parameter with the 'out' keyword, the
         * compiler will check if the data-type of the variable is
         * parent data-type of the value, and it will also check if
         * the generic type-parameter is also the parent type-para-
         * meter of the values generic.
         * 
         * E.g.
         * IEnumrable<IExample1> covariance1 = new List<InterfaceExampleClass>();
         * IEnumrable is the base of List.
         * IExample1 is the base of InterfaceExampleClass.
         * 
         * */

        /*
         * By default, dotnet framework does not enable covariance
         * and contravariance, so we have to able in explicting in
         * the code by notifying the compiler.
         * 
         * This was because of type-safety.
         * 
         * To make custom generic types as covariant: 
         * - Either by marking the generic type parameter in the
         *   interface with the 'out' keyword.
         * 
         * */

        /*
         * Covariance only works with types that are references,
         * and not value types.
         * i.e. we can't do something like this IEnum<int>.
         * */
        void GetCovarianceObject<TCov>(IStandardGen<TCov> covariance);
    }
}
