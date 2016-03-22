using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Structs
{
    struct Structeg
    {
        /* struct are like class, but with a massive differnce: a struct is value type, where as a class is a reference type
         * Struct are used in situation where data is small, and the values are primitive.
         * Struct behave like value (primitive) data types, meaning they are immutable.
         * Basically, structs to me are just data holders, they don't do nothing special except hold data.
         */
        public readonly int Id;
        public readonly bool State;
        public readonly int Demension;

        public Structeg(int Id, bool State, int Demension)
        {
            this.Id = Id;
            this.State = State;
            this.Demension = Demension;
        }
    }
}
