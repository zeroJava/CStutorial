using CStutorial.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Covariance_Contravariance
{
    public class IStandardGenIml<TCon> : IStandardGen<TCon> where TCon : IExample1
    {
        public TCon GetObject()
        {
            return default(TCon);
        }
    }
}
