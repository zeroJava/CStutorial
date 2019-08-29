using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Variables
{
    class Variables
    {
        public int _number;
        public readonly int _Constant = 321; // readonly is used for variables and sealed is used for class and methods.
											 // readonly and seal are the equivalent to javas final 

		/*
		 * C# has feature called properties, which is mixture of variable (field)
		 * and function, i.e. it looks like a field, but contains expression that
		 * does something.
		 * */
		private int _propNumber;
		public int PropNumber
		{
			get
			{
				return _propNumber;
			}
			internal set
			{
				_propNumber = value;
			}
		}
		/*
		 * When properties are compiled, the comipiler actually converts it internally
		 * into accessor and mutator method, i.e. properties become getter and setter
		 * methods similar to the ones in java.
		 * 
		 * E.g.
		 * int PropNumber { get; set; }
		 * 
		 * Compiled into
		 * 
		 * int get_PropNumber();
		 * void set_PropNumber(int value)
		 * 
		 * */
    }
}
