using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Methods
{
    class ParamaterArraysMethod
    {
        /* Parameter array are the equivelent of java's varargs.
         * 
         * Using the 'params' in our method signature as part of our paramater with string[], we are giving our method the ability to hold multiple arguments
         * in our method, even though there is only one paramtere.
         * 
         * e.g.
         * Doing this void ListAllNames(params string[] names) {}
         * 
         * Allows us to this this when invoking it Methods.ParamaterArraysMethod.ListAllNames("John", "Mike", "MeHe", "Donkey");
         * // See our one parameter can hold multiple string arguments.
         */

        public static void ListAllNames(params string[] names)
        {
            foreach(string name in names)
            {
                System.Console.WriteLine(name);
            }
        }

        // http://www.dotnetperls.com/method
    }
}
