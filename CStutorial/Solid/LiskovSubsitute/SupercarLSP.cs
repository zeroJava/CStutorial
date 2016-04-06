using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Solid.LiskovSubsitute
{
    class SportsCarLSP : CarLSP
    {
        public SportsCarLSP(int enginesize, string wheeltype)
        {
            _EngineSize = enginesize;
            _wheelType = wheeltype;
        }

        public override void SetWheelType(string type)
        {
            _wheelType = type;
        }

        public override void SetEngineSize(int engineSize)
        {
            _EngineSize = engineSize;
        }

        public override void SetEnginePower()
        {
            _EnginePower = GetEngineSize() * 100;
        }

        public override int GetEnginePower()
        {
            return _EnginePower;
        }
    }
}
