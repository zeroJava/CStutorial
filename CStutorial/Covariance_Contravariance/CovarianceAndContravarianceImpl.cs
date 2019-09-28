using CStutorial.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Covariance_Contravariance
{
    /*
     * Note::
     * Classes can implement both a Convariance and
     * Contravariance.
     * */
    public class CovarianceAndContravarianceImpl<TVriance> : ICovariance<TVriance>, IContraVariance<TVriance>
    {
        /*
         * To make an generic type-parameter in an interface
         * covariance, we have to mark the type-parameter in
         * the interface (defintion/file) with the 'out'
         * keyword.
         * */

        public void GetCovarianceObject<TCov>(IStandardGen<TCov> cov)
        {
            Console.WriteLine("Covariance");
        }

        /*
         * To make an generic type-parameter in an interface
         * contravariance, we have to mark the type-parameter
         * in the interface (defintion/file) with the 'in'
         * keyword.
         * */

        public void GetContraVarianceObject<TCon>(IStandardGen<TCon> standardGen)
        {
            Console.WriteLine("Contravariance");
        }
    }
}
