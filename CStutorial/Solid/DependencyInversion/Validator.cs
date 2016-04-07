using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Solid.DependencyInversion
{
    class Validator
    {
        public static void Validate(ICar car)
        {
            System.Console.WriteLine("Validating");
            car.Model();
            car.Make();
        }
    }
}
