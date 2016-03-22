using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Flowcontrols
{
    public class IfelseStatements
    {
        public string Name { get; set; }
        public int Number { get; set; }
        
        public IfelseStatements(string _name, int _number)
        {
            this.Name = _name;
            this.Number = _number;
        }

        public void CheckIfMatch(string _name, int _number)
        {
            if(this.Name.Equals(_name) && this.Number == _number)
            {
                System.Console.WriteLine("The name and number matches");
            }
            else
            {
                if (this.Name.Equals(_name))
                {
                    System.Console.WriteLine("Name is the same");
                }
                else if (this.Number == _number)
                {
                    System.Console.WriteLine("Number is the same");
                }
                else
                {
                    System.Console.WriteLine("The name and number does not match");
                }
            }
        }

        public bool Equals(IfelseStatements _obj)
        {
            return (_obj.Name.Equals(Name) && _obj.Number == Number);
        }
    }
}
