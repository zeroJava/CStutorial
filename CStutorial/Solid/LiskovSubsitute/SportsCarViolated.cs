using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Solid.LiskovSubsitute
{
    class SportsCarViolated : CarViolation
    {
        public SportsCarViolated(int enginesize, string wheeltype)
        {
            _EngineSize = enginesize;
            _wheelType = wheeltype;
        }

        public void SetWheelType(string type)
        {
            _wheelType = type;
        }

        public void SetEngineSize(int engineSize)
        {
            _EngineSize = engineSize;
        }

        public void SetEnginePower()
        {
            _EnginePower = GetEngineSize() * 100;
        }

        public int GetEnginePower()
        {
            return _EnginePower;
        }
    }
}
