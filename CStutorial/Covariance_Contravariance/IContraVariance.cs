using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Covariance_Contravariance
{
    public interface IContraVariance<in TContra>
    {
        /*
         * Contravariance is the opposite of covariance, which
         * convert a parent type-parameter to a sub- class
         * data-type with a sublclass generic type-parameter.
         * 
         * I.e.
         * Basically covariance just means that, after marking
         * the interfaces type-parameter with the 'in' keyword,
         * the compiler will check if the check if the generic
         * type-parameter is the child type-parameter of the
         * values generic.
         * 
         * E.g.
         * CovarianceAndContravarianceImpl<IExample1> covariance1 = new CovarianceAndContravarianceImpl<IExample1>();
         * IContraVariance<InterfaceExampleClass> contraVariance1 = covariance1;
         * 
         * InterfaceExampleClass is the child of IExample1.
         * */

        /*
         * You enable contravariance by maring the generic
         * type-parameter with the 'in' keyword.
         * */
        void GetContraVarianceObject<TCon>(IStandardGen<TCon> standardGen);
    }
}
