using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* This whole file is the the source code, which will be
 * compiled into an exe, which is our assembly/binary.
 * 
 * Depending on the project type, an assembly can either be
 * an application (.exe) or a library(dll).
 * 
 * If the project contains a main method, then the compiler
 * compiles the source code as an application.
 * If it can't find a main method, then the compiler compiles
 * the source code a library.
 * 
 * The compiler used by c# is the c# compiler: csc.exe
 * */

/* The main method is the entry point of c#.
 *  */
namespace CStutorial.Basics
{
    public class BasicsStuff
    {
        /* In c# there two categories for data-types: primitive
         * and custom.
         * 
         * A primitive type are just your basic standard built-in
         * type provided by the c# languages.
         * These data-type are the int, char, float string etc;
         * basically any data-type that is a key word.
         * 
         * A custom type is basically your own class, which you
         * created using primitive data-types.
         * */

        /* These variables.
         * 
         * What are variables?
         * As Joseph Albahari said, "a variable represents a storage 
         * location that has a modifiable value". 
         * What he means is that a variable is an instruction to the 
         * compiler telling it to create a storage space in the memory, 
         * which will be used to hold certain values, and that the name 
         * of the storage location is the we give it.
         * */

        private int _numberOne = 10;
        private string _word = "Hello world";


        /* A literal just means that the values have been hard coded
         * into the source code.
         * */
        private int _numberLiteral = 5; // 5 is a literal, because we put in number 5;
        private string wordLiteral = "Literal";

        public string Name { get; set; }
        public int Number { get; set; }
        public object Universal { get; set; } // object data-type is a primitive data type equivalent of Object class in java.
        public bool State { get; set; }

        public BasicsStuff(int number)
        {
            this.Number = number;
        }

        /* total and number are local variables and parameters, an thus will
         * be allocated to the stack.
         * */

        public void Adding(int number)
        {
            int total = this.Number + number;
            Console.WriteLine("Adding the number: " + number + " with " + this.Number + " would equal: " + total);
        }

        public void Value_of_object()
        {
            System.Console.WriteLine("Value of object variable: Universal is " + Universal);
        }
    }
}
