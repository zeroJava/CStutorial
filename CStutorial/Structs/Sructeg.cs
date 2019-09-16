using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Structs
{
    public struct Structeg
    {
        /* struct are like class, but with a massive differnce:
         * a struct is value type, where as a class is a refer-
         * ence type.
         */
        
        /*
         * Struct are used in situation where data is small, and
         * the values are primitive.
         */

        /*
         * There are few conditions that seperates a class from a
         * struct:
         *
         * 1) structs don't support inheritance, i.e. a struct (or
         * class) cannot inherit from members from another struct,
         * this is because structs are implictly (automaticall
         * behind the code) sealed.
         *
         * Even though all structs inherit from object class, it
         * Can Not inherit from any other class.
         *
         * 2) A struct cannot have a parameterless constructor,
         * because compiler adds a hidden one automatically, which
         * will be overwritten if we added a new one, which will
         * throw a compiler error.
         *
         * Also, in our constructor, we have explictly initialise
         * all memebers, because structs don't have field
         * initialiser.
         *
         * 3) structs don't have field initialisers, as opposed to
         * classes which do; this means that fields are forced to
         * be initialised in the constructor.
         *
         * 4) structs don't support finialisers.
         *
         * 5) structs don't support virtual or protected members. 
         * */
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

/* Struct behave like value (primitive) data types,
 * meaning they are immutable.
 * Basically, structs to me are just data holders, they
 * don't do nothing special except hold data.
 * */
