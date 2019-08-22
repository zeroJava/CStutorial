using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Methods
{
    class PassbyReferenceParameters
    {
		/* Some method have parameters, which are variables that part of the method signature
		 * used for holding arguments.
		 * */
		public void ExecuteStandardFunc(int number)
		{
			/* The default approach used by c# when passing in an argument is pass-by-value,
			 * which means that the compiler creates a copy of the arguments value, which is
			 * then placed inside a new storage location, which is then used by the method.
			 * */

			 /* The number variable now has a copy, so if we make any changes to number inside
			  * the method, the original variable outside the method will not be affected, but
			  * this only applies to value-type variable.
			  * 
			  * With reference types, any changes to the properties of the object inside the
			  * method will change, and affect the object outside the method.
			  * This is because the compiler pass-by-value copies the reference and not the
			  * object, so now there's two refernces pointing to the object, and one of them is
			  * number parameter.
			  * 
			  * e.g.
			  * Function (ClassO obj)
			  * {
			  *		obj.Prop1 = 5; // will affect variable outside method;
			  *		obj = new ClassO(); // will NOT affect orginal variable outside method.
			  * }
			  */
			number = number + 6; 
			Console.WriteLine(number);
		}

		
		/* 
		 * I.e.
		 * When a method/function is called (executed), the variables/value in the arguments
		 * that is inputted will be copied and stored in the parameters, which is another
		 * storage location in the .
		 * */
		 /*  
		  * E.g. pass-by-value
		  * 
		  * object.ExecuteStandardFunc(5) // passed in 5, which the compiler is copying the value
		  * into the parameter: number.
			* 
			* +-----------+------------------------+
			* | comp_proc | value                  |
			* +-----------+------------------------+
			* | argument  | 5                      |
			* | number    | cpy_arg_val (argument) | // compiler copies the value from the arguemnt into 
			* |           |                        | // new storage location call number (our parameter). 
			* +-----------+------------------------+
		    * */


		public void ExecuteRef(ref int number)
        {
			/* By default all arguments in C# is pass-by-value, but the using the ref modifier
			 * (keyword) we can now change it to pass-by-reference.
			 * */

			/* When executing method with ref modifiers, you have first create a variable outside
			 * the method initialised with a default value, and also mark that parameter with ref
			 * keyword when passing it as an argument.
			 * */

			/*
			 * E.g.
			 * int x = 5;
			 * ExecuteRef(ref x);
			 * */
			number = number * 10;
            /* Using the ref keyword, we can now pass an argument as a refernce and not a value
            */
        }

		/*
		 * With pass-by-value, the compiler copies the VALUE and then places it inside a storage
		 * location (memory space), i.e. the parameter becomes another slot in the memory.
		 * 
		 * Pass-by-reference actually takes the storage location of the original variable, and
		 * doesn't create another storage location, instead creates an alias which has the
		 * same storage location as the original variable (AlBahari).
		 *  */

		/*
		 * E.g. pass-by-value
		 * 
		 * void FuncPBV(int f1)
		 * {
		 * }
		 * 
		 * main()
		 * {
		 *		int x = 10;
		 *		FuncPBV(x);
		 * }
		 * 
		 * +----------+-------+
		 * | Mem_name | Loc   |
		 * +----------+-------+
		 * | x        | 10    |
		 * +----------+-------+
		 * | f1       | 10    | // creates new location, and copies the 'x' variables value of 10.
		 * +----------+-------+
		 * 
		 * */

		/*
		 * E.g. pass-by-reference
		 * 
		 * void FuncPBR(ref int f1)
		 * {
		 * }
		 * 
		 * main()
		 * {
		 *		int x = 10;
		 *		FuncPBR(ref x);
		 * }
		 * 
		 * +----------+-------+
		 * | Mem_name | Loc   |
		 * +----------+-------+
		 * | x        |       |
		 * +----------+ 10    +
		 * | f1       |       | // creates an aliea, shares the same location as the 'x' variable.
		 * +----------+-------+
		 * 
		 * */

		public void ExecuteOut(out int number)
        {
			/* By default all arguments in C# is pass-by-value, but the using the out modifier
			 * (keyword) we can now change it to pass-by-reference.
			 * */

			/* When executing method with out modifiers, you have mark the parameter with out
			 * keyword when passing it as an argument, and then initialise the parameter ASAP
			 * inside the method.
			 * 
			 * Difference between ref and out is that when using out, varaibles don't need to
			 * be initialised outside the method.
			 * */

			/*
			 * E.g.
			 * int x;
			 * ExecuteRef(out x);
			 * */
			number = 5;
        }

        /* ref and out are used to pass argument as reference and not as value.
         * The differnce between ref and out is that, ref arguments have to be
		 * intialised before, where as it out arguments are optional
         * http://www.dotnet-tricks.com/Tutorial/csharp/K0Hb060414-Difference-between-ref-and-out-parameters.html
         */
    }
}
