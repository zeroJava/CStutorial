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
         * Contravariance is the opposite of covariance,
         * which convert a base data-type with a base
         * type-parameter to a subclass data-type with a
         * sublclass generic type-parameter.
         * */

        /*
         * You enable contravariance by maring the generic
         * type-parameter with the 'in' keyword.
         * */
        void GetContra<TCon>(IStandardGen<TCon> standardGen);
    }
}
