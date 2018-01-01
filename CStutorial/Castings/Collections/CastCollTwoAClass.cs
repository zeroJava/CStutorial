using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Castings.Collections
{
    public class CastCollTwoAClass : ICastCollTwo
    {
        private List<ICastCollOne> _castCollectionOneList;
        public IList<ICastCollOne> CastCollectionOneList
        {
            get
            {
                return _castCollectionOneList;
            }
            set
            {
                _castCollectionOneList = value as List<ICastCollOne>;
                //throw new NotImplementedException();
            }
        }
    }
}
