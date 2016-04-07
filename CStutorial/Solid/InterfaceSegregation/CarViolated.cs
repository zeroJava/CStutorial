using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Solid.InterfaceSegregation
{
    interface CarViolated
    {
        void EngineSize(int size);
        void CarColour(string Colour);
        void OperatingSystem(string version);
        void NavigationSystem(string satnav);

        /* This is violating the Interface segregation principle becuase I put all my methods into one interface.
        */
    }
}
