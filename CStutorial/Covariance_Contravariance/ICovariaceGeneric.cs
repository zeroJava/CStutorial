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
    public interface ICovariaceGeneric<out TCovariance>
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

        /*
         * By default, dotnet framework does not enable cov-
         * ariance and contravariance, so we have to able in
         * explicting in the code by notifying the compiler.
         * 
         * To make custom generic types as covariant: 
         * - Either by marking the generic type parameter in
         *   the interface with the 'out' keyword.
         * 
         * */
        void GetCovarianceExampleObject<TCov>(IStandardGen<TCov> covariance);
    }
}
