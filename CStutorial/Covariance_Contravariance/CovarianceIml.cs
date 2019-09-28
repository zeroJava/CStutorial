using CStutorial.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Covariance_Contravariance
{
    public class CovarianceIml<TCovariance> : ICovariaceGeneric<TCovariance>
    {
        /*
         * To make an generic type-parameter in an interface
         * covariance, we have to mark the type-parameter in
         * the interface (defintion/file) with the 'out'
         * keyword.
         * */

        public void GetCovarianceExampleObject<TCov>(IStandardGen<TCov> cov)
        {
            Console.WriteLine("Covariance");
        }
    }
}
