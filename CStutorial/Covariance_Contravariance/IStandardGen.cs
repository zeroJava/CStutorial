using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Covariance_Contravariance
{
    public interface IStandardGen<TCon>
    {
        TCon GetObject();
    }
}
