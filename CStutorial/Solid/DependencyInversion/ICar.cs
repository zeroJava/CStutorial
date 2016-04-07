using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Solid.DependencyInversion
{
    interface ICar
    {
        void Make();
        void Model();
        void EngineSize();
    }
}
