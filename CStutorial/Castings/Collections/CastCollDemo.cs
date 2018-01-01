using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Castings.Collections
{
    public class CastCollDemo
    {
        public void Execute()
        {
            CastCollTwoBClass castCollTwoB = new CastCollTwoBClass();
            castCollTwoB.CastCollectionOneList.Add(new CastCollOneBClass());
            castCollTwoB.CastCollectionOneList.Add(new CastCollOneAClass());
            System.Console.WriteLine("Size : " + castCollTwoB.CastCollectionOneList.Count);

            castCollTwoB.CastCollectionOneList = new ObservableCollection<ICastCollOne>();
            System.Console.WriteLine("Size : " + castCollTwoB.CastCollectionOneList.Count);
        }
    }
}
