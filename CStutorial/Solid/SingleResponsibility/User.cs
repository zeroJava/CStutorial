using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Solid.SingleResponsibility
{
    class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public User(int ID, string Name, string Address)
        {
            this.ID = ID;
            this.Name = Name;
            this.Address = Address;
        }

        /* To keep in place with the single responsibilty principle, we made our class do one thing, that is hold data of users. 
         * This class only has one purpose, that is to hold data of users.
         * This is basically single responsibilty principle, which is to make a class that is tasked to one thing. 
        */

        // Adding a method to print the data of the user will violate the single resposibilty principle, so we created
        // a class whose sole puropse is print data.
    }
}
