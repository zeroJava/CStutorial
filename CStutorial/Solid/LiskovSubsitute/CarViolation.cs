using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Solid.LiskovSubsitute
{
    class CarViolation
    {
        protected int _EngineSize { get; set; }
        protected string _wheelType { get; set; }
        protected int _EnginePower { get; set; }

        public void SetEngineSize(int engineSize)
        {
            this._EngineSize = engineSize;
        }

        public void SetWheelType(string type)
        {
            this._wheelType = type;
        }

        public int GetEngineSize()
        {
            return _EngineSize;
        }

        public string GetWheelType()
        {
            return _wheelType;
        }

        public void SetEnginePower()
        {
            _EnginePower = _EngineSize * 10;
        }

        public int GetEnginePower()
        {
            return _EnginePower;
        }
    }
}
