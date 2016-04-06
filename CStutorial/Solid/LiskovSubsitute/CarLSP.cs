using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Solid.LiskovSubsitute
{
    class CarLSP
    {
        protected int _EngineSize { get; set; }
        protected string _wheelType { get; set; }
        protected int _EnginePower { get; set; }

        public virtual void SetEngineSize(int engineSize)
        {
            this._EngineSize = engineSize;
        }

        public virtual void SetWheelType(string type)
        {
            this._wheelType = type;
        }

        public virtual int GetEngineSize()
        {
            return _EngineSize;
        }

        public virtual string GetWheelType()
        {
            return _wheelType;
        }

        public virtual void SetEnginePower()
        {
            _EnginePower = _EngineSize * 10;
        }

        public virtual int GetEnginePower()
        {
            return _EnginePower;
        }
    }
}
