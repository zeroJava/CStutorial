using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.List
{
    class Listexample
    {
        private IList<string> _list;

        public Listexample()
        {
            MakeList();

            for(int i = 0; i <_list.Count; i++)
            {
                System.Console.WriteLine(_list[i] + " " + _list.Count);
            }

            RemoveitemByName();

            for (int i = 0; i < _list.Count; i++)
            {
                System.Console.WriteLine(_list[i] + " " + _list.Count);
            }

            RemoveItemByIndexNumber();
        }

        private void MakeList()
        {
            _list = new List<string>();
            _list.Add("Hello");
            _list.Add("Food");
            _list.Add("Bye");
            _list.Add("Water");
            _list.Add("Bye");
            _list.Add("Energy");
            _list.Add("Please");
            _list.Add("GHT");
            _list.Add("Bye");
        }

        public void RemoveitemByName()
        {
            _list.Remove("Bye");
            // this will only remove the first item it finds with the value of "bye";
        }

        public void RemoveItemByIndexNumber()
        {
            _list.RemoveAt(1);
        }
    }
}
