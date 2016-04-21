using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Dictionarys
{
    class Dictionaryexample
    {
        private IDictionary<int, string> _dictionary = new Dictionary<int, string>();

        public Dictionaryexample()
        {
            HowItemsAreAdded();
            HowToGetValue();
            HowItemsAReRemoved(3);
        }

        public void HowItemsAreAdded()
        {
            _dictionary.Add(1, "Smyth");
            _dictionary.Add(2, "Wilson");
            _dictionary.Add(3, "Test");
            _dictionary.Add(4, "Turbo");
        }

        public void HowItemsAReRemoved(int key)
        {
            _dictionary.Remove(key);
        }

        public void HowToGetValue()
        {
            System.Console.WriteLine("The value of item is " + _dictionary[1]);
            // this hhow we get value of an item
        }
    }
}
