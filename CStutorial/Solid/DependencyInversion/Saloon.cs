using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Solid.DependencyInversion
{
    class Saloon : ICar
    {
        public void EngineSize()
        {
            System.Console.WriteLine("Something is happening here in saloon");
        }

        public void Make()
        {
            System.Console.WriteLine("Something is happening here in saloon");
        }

        public void Model()
        {
            System.Console.WriteLine("Something is happening here in saloon ");
        }
    }
}
