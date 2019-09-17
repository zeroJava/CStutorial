using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Interfaces
{
    /* 
     * An interface is file whichs holds the names of methods
     * and properties, which are undefined and waiting for
     * class to inherit them and give it a definition, i.e. we
     * overrwrite the method in our class.
     * */

    public interface IExample1
    {
        // Interface do note hold variables.

        int Number { get; set; }

        void Method1();
        void Method2();
        /* 
         * These method are defined, because the purpose of the
         * interface is just to be place holder to hold names of
         * method and properties.
         *
         * The method will force the class that inherits them,
         * to give it a defination (a body { functions }) 
         * */

        /*
         * Interface members are always public, because the
         * compiler automatically assigns the public keyword
         * behind the scene.
         */
    }
}
