using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Set
{
    class Setexample
    {
        private ISet<string> _sets = new HashSet<string>();

        public Setexample()
        {
            HowItemsAreAdded();

            foreach(string str in _sets)
            {
                System.Console.WriteLine(str + " " + _sets.Count);
            }

            HowItemsAreRemoved();

            foreach(string str in _sets)
            {
                System.Console.WriteLine(str + " " + _sets.Count);
            }
        }

        public void HowItemsAreAdded()
        {
            _sets.Add("Johnatheen");
            _sets.Add("Brannigeen");
            _sets.Add("Federlan");
            _sets.Add("Brannigeen"); // this won't get added, because it is a duplicate and goes against the purpose of sets
            _sets.Add("Nome");
            _sets.Add("Planton");
        }

        public void HowItemsAreRemoved()
        {
            bool state = _sets.Remove("Nome");
            System.Console.WriteLine("item removed " + state);
        }
    }
}
