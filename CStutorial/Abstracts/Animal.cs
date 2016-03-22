using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Abstracts
{
    abstract class Animal
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public string Food { get; set; }

        public Animal()
        {
            Display();
            System.Console.WriteLine(Movement());
        }

        public Animal(string Name) : this()
        {
            this.Name = Name;
        }

        public Animal(string Name, string Species)
        {
            this.Name = Name;
            this.Species = Species;
        }

        public abstract void Display();
        public abstract string Movement();
    }
}
