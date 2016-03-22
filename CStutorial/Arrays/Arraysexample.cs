using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Arrays
{
    class Arraysexample
    {
        private string[] _OneDimensionalArray;
        private string[,] _TwoDimensionlArrays;

        public Arraysexample()
        {
            OneDimenssionalArray();
            TwoDimensionalArray();

            for(int i = 0; i < _OneDimensionalArray.Length; i++)
            {
                System.Console.WriteLine(_OneDimensionalArray[i]);
            }

            for(int q = 0; q < _TwoDimensionlArrays.GetLength(0); q++)
            {
                for(int w = 0; w < _TwoDimensionlArrays.GetLength(1); w++)
                {
                    System.Console.WriteLine(_TwoDimensionlArrays[q,w]);
                }
            }
        }

        private void OneDimenssionalArray()
        {
            _OneDimensionalArray = new string[5];
            _OneDimensionalArray[0] = "Hello";
            _OneDimensionalArray[1] = "World";
            _OneDimensionalArray[2] = "And";
            _OneDimensionalArray[3] = "Hello";
            _OneDimensionalArray[4] = "Everybody";
        }

        private void TwoDimensionalArray()
        {
            _TwoDimensionlArrays = new string[5,5];

            _TwoDimensionlArrays[0, 0] = "Herny one";
            _TwoDimensionlArrays[0, 1] = "Herny two";
            _TwoDimensionlArrays[0, 2] = "Herny three";
            _TwoDimensionlArrays[0, 3] = "Herny four";
            _TwoDimensionlArrays[0, 4] = "Herny five";

            _TwoDimensionlArrays[1, 0] = "Tensison one";
            _TwoDimensionlArrays[1, 1] = "Tensison two";
            _TwoDimensionlArrays[1, 2] = "Tensison three";
            _TwoDimensionlArrays[1, 3] = "Tensison four";
            _TwoDimensionlArrays[1, 4] = "Tensison five";

            _TwoDimensionlArrays[2, 0] = "Mark one";
            _TwoDimensionlArrays[2, 1] = "Mark two";
            _TwoDimensionlArrays[2, 2] = "Mark three";
            _TwoDimensionlArrays[2, 3] = "Mark four";
            _TwoDimensionlArrays[2, 4] = "Mark five";

            _TwoDimensionlArrays[3, 0] = "Phil one";
            _TwoDimensionlArrays[3, 1] = "Phil two";
            _TwoDimensionlArrays[3, 2] = "Phil three";
            _TwoDimensionlArrays[3, 3] = "Phil four";
            _TwoDimensionlArrays[3, 4] = "Phil five";

            _TwoDimensionlArrays[4, 0] = "Layland one";
            _TwoDimensionlArrays[4, 1] = "Layland two";
            _TwoDimensionlArrays[4, 2] = "Layland three";
            _TwoDimensionlArrays[4, 3] = "Layland four";
            _TwoDimensionlArrays[4, 4] = "Layland five";
        }
    }
}
