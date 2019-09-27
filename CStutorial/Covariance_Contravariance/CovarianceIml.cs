using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Covariance_Contravariance
{
    public class CovarianceIml<TCovariance> : ICovariaceGeneric<TCovariance>
    {
        public void GetCovarianceExampleObject()
        {
            Console.WriteLine("Covariance");
        }
    }
}
