using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Methods
{
    class PassbyReferenceParameters
    {
        public void ExecuteRef(ref int number)
        {
            number = number * 10;
            /* Using the ref keyword, we can now pass an argument as a refernce and not a value
            */
        }

        public void ExecuteOut(out int number)
        {
            number = 5;
        }

        /* ref and out are used to pass argument as reference and not as value.
         * The differnce between ref and out is that, ref arguments have to be intialised before, where as it out arguments are optional
         * http://www.dotnet-tricks.com/Tutorial/csharp/K0Hb060414-Difference-between-ref-and-out-parameters.html
         */
    }
}
