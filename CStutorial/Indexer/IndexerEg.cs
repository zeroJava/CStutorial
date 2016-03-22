using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Indexer
{
    class IndexerEg
    {
        public string[] array = new string[5];
        public string this[int index]
        {
            get
            {
                return array[index];
            }

            set
            {
                array[index] = value;
            }
        }

        /* this above is an example of indexer.
         * With the indexer, we modify the 'this' operator, and we define it to bring data from an array.
         * This allows our object to retreive data directly
         * e.g.
         * 
         * IndexerEg index = new IndexerEg();
         * System.Console.WriteLine(index[1]);
         * index[1] = "earth";
        */

        public void Adddata()
        {
            array[0] = "hello";
            array[1] = "world";
            array[2] = "and";
            array[3] = "hello";
            array[4] = "everybody";
        }
    }
}
