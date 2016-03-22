using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Partialclass
{
    partial class Partialeg
    {
        /* Partial class are class that can be slipt it and written in many different files, but still be viwed as one single class.
         * This means that we can have a class, whose defintion (properties and methods) can be written in different location (files).
         * Classes that are partial are NOT viewed as two or more differenct classes with the same name, but one one whole whose definition is written in different places,
         * and coming together when we compile it.
         */

        public string Name { get; set; }
        public int Age { get; set; }

        public void FirstLine()
        {
            System.Console.WriteLine("hello... is it me you looking for?");
        }
    }
}
