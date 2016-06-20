using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Interfaces
{
    /* An interface is file whichs holds the names of methods, which are undefined and waiting for class to inherit them and give it a defination.
     * */

    interface IExample1
    {
        void Method1();
        void Method2();
        /* These method are defined, because the purpose of the interface is just to be place holder to hold names of method.
         * The method will force the class that inherits them, to give it a defination (a body { functions }) 
         * */
    }
}
