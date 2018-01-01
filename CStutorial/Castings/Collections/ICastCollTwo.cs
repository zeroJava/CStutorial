using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Castings.Collections
{
    public interface ICastCollTwo
    {
        IList<ICastCollOne> CastCollectionOneList { get; set; }
    }
}
