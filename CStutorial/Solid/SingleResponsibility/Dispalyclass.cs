using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Solid.SingleResponsibility
{
    class Dispalyclass
    {
        public static void Print(User user)
        {
            System.Console.WriteLine(user.ID + " " + user.Name + " " + user.Address);
        }

        /* This class has one responsibilty, which is to print data.
         * This class aligns with single responsibilty princle, because it is doing but printing data.
        */
    }
}
