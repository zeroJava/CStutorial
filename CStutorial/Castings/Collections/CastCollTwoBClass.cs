using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Castings.Collections
{
    public class CastCollTwoBClass : ICastCollTwo
    {
        private ObservableCollection<ICastCollOne> _castCollectionOneObservableCollection = new ObservableCollection<ICastCollOne>();
        public IList<ICastCollOne> CastCollectionOneList
        {
            get
            {
                return _castCollectionOneObservableCollection;
            }
            set
            {
                _castCollectionOneObservableCollection = value as ObservableCollection<ICastCollOne>;
            }
        }

        private IList<ICastCollOne> _castCollectionOneList = new List<ICastCollOne>();
        public ObservableCollection<ICastCollOne> CastCollectionOneList2
        {
            get
            {
                return _castCollectionOneList as ObservableCollection<ICastCollOne>;
            }
            set
            {
                _castCollectionOneList = value;
            }
        }
    }
}
