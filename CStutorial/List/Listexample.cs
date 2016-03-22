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
                System.Console.WriteLine(_list[i]);
            }
        }

        private void MakeList()
        {
            _list = new List<string>();
            _list.Add("Hello");
            _list.Add("Food");
            _list.Add("Water");
            _list.Add("Energy");
            _list.Add("Please");
            _list.Add("Bye");
        }
    }
}
