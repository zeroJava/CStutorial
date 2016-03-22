using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Solid.OpenClosed
{
    class AutomobileValidator
    {
        public static bool CheckIfAutomobile(Automobile automobile)
        {
            return automobile.AutocmobileCertifcate();
        }

        /* This open close principle in action
         * here we have created a method that future proof, meaning that we don't have to come in and change the function everytime 
         * new automobile type machine is made.
        */

        /* A method sitution that would violate open closed princple would be to have a tight couple (class specific) method 
         * e.g. 
         * checkIdautoMobile(Car car) { }
         * 
         * This would mean that every time a new type of automobile appears, we will have to modify the class.
         * e.g.
         * checkIdautoMobile(Truck tr) { }
         * checkIdautoMobile(Motorcycle mc) { }
         */
    }
}
