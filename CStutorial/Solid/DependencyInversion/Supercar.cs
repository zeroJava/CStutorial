using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Solid.DependencyInversion
{
    class Supercar : ICar
    {
        public void EngineSize()
        {
            System.Console.WriteLine("Something is happening here in supercar");
        }

        public void Make()
        {
            System.Console.WriteLine("Something is happening here in supercar  ");
        }

        public void Model()
        {
            System.Console.WriteLine("Something is happening here in supercar  ");
        }
    }
}
