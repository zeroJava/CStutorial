using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Arrays
{
    class Arraysexample
    {
		/* An array is a linear data structure, which allows multiple variables to be placed inside a
		 * single variable, which the compiler/OS stores as a continous block of memory (Al Bahari, c# 7.0).
		 * E.g. int[] ar = new int[5] { 0, 2, 5, 3, 2}; // stored in memory
		 * +-------+---+
		 * | ar[0] | 0 |
		 * | ar[0] | 2 |
		 * | ar[0] | 5 |
		 * | ar[0] | 3 |
		 * | ar[0] | 2 |
		 * +-------+---+
		 * */

		/* Arrays are of fixed size, meaning that once they're iniitialised, the size of the array cannot be
		 * changed, but the varaible can be overridden with a new array.
		 * 
		 * e.g.
		 * int arr = new int[5];
		 * arr.add(); // compiler error no function exist.
		 * arr = new int[6]; // This is legal.
		 * 
		 * The square bracket denotes the size of the array, I.e int arr = new int[5] means that this array will
		 * be able to hold 5 varaibles.
		 * */

		/* All arrays inherit from the System.Array class.
		 * */

		/* This is an Array.*/
		private string[] _OneDimensionalArray;

		/* This is an multidimensional array.
		 * In C#, multidimensional arrays come in two forms: Rectangular and Jagged.
		 * This is how a rectangular multidimensional array looks like: int[,] marr = new int[5,5];
		 * This is how a jagged multodimensional array looks like: int[][] marr = new int[5][5];
		 */
        private string[,] _TwoDimensionlRectangularArrays;
		private string[][] _TwoDimensionalJagggedArrays;

        public Arraysexample()
        {
            OneDimenssionalArray();
            TwoDimensionalArray();

            for(int i = 0; i < _OneDimensionalArray.Length; i++)
            {
                System.Console.WriteLine(_OneDimensionalArray[i]);
            }

            for(int q = 0; q < _TwoDimensionlRectangularArrays.GetLength(0); q++)
            {
                for(int w = 0; w < _TwoDimensionlRectangularArrays.GetLength(1); w++)
                {
                    System.Console.WriteLine(_TwoDimensionlRectangularArrays[q,w]);
                }
            }
        }

        private void OneDimenssionalArray()
        {
            _OneDimensionalArray = new string[5]; // This the 5 element high.

			/* When arrays are created useing the new keyword (function), the elements are automatically populated witg the
			 * types default value, e.g. 0 for value-type/primitive numbers, false for bool, '\x0000' for char, and null for
			 * all reference types.
			 * */

			/* Default values
			 * +----------------------+-------+
			 * | Reference type       | null  |
			 * | All numeric and enum | 0     |
			 * | char                 | '\0'  |
			 * | bool type            | false |
			 * +----------------------+-------+
			 * */

			_OneDimensionalArray[0] = "Hello";
            _OneDimensionalArray[1] = "World";
            _OneDimensionalArray[2] = "And";
            _OneDimensionalArray[3] = "Hello";
            _OneDimensionalArray[4] = "Everybody";
        }

        private void TwoDimensionalArray()
        {
            _TwoDimensionlRectangularArrays = new string[5,5];

            _TwoDimensionlRectangularArrays[0, 0] = "Herny one";
            _TwoDimensionlRectangularArrays[0, 1] = "Herny two";
            _TwoDimensionlRectangularArrays[0, 2] = "Herny three";
            _TwoDimensionlRectangularArrays[0, 3] = "Herny four";
            _TwoDimensionlRectangularArrays[0, 4] = "Herny five";

            _TwoDimensionlRectangularArrays[1, 0] = "Tensison one";
            _TwoDimensionlRectangularArrays[1, 1] = "Tensison two";
            _TwoDimensionlRectangularArrays[1, 2] = "Tensison three";
            _TwoDimensionlRectangularArrays[1, 3] = "Tensison four";
            _TwoDimensionlRectangularArrays[1, 4] = "Tensison five";

            _TwoDimensionlRectangularArrays[2, 0] = "Mark one";
            _TwoDimensionlRectangularArrays[2, 1] = "Mark two";
            _TwoDimensionlRectangularArrays[2, 2] = "Mark three";
            _TwoDimensionlRectangularArrays[2, 3] = "Mark four";
            _TwoDimensionlRectangularArrays[2, 4] = "Mark five";

            _TwoDimensionlRectangularArrays[3, 0] = "Phil one";
            _TwoDimensionlRectangularArrays[3, 1] = "Phil two";
            _TwoDimensionlRectangularArrays[3, 2] = "Phil three";
            _TwoDimensionlRectangularArrays[3, 3] = "Phil four";
            _TwoDimensionlRectangularArrays[3, 4] = "Phil five";

            _TwoDimensionlRectangularArrays[4, 0] = "Layland one";
            _TwoDimensionlRectangularArrays[4, 1] = "Layland two";
            _TwoDimensionlRectangularArrays[4, 2] = "Layland three";
            _TwoDimensionlRectangularArrays[4, 3] = "Layland four";
            _TwoDimensionlRectangularArrays[4, 4] = "Layland five";
        }
    }
}

/* Al Bahari C# 7.0: C# in a nutshell, Al Bahari.
 * */