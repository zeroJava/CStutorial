using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Basics
{
    class ExpressionNOperators
    {
		private void ExpressionsEx()
		{
			/* Expression is just a line of value from literals or variable that
			 * create a new value, i.e. assigning a to variable with a value is
			 * an expression.
			 * 
			 * E.g.
			 * int x = 10; // is an expression.
			 * int y = x; // is an expression.
			 * 
			 * */

			/*
			 * Expression are also formed with one or more operators, which are
			 * built-in functions that perform an operation (action) and returns
			 * a new value.
			 * 
			 * E.g.
			 * int x = 5;
			 * int y = 5 + x; // '+' is a built in operator that adds two operands.
			 * 
			 * */
		}

		public static void AssignementExpression()
		{
			/*
			 * Assignment expressions is the function of expression you have already
			 * seen and used when assigning a variable with a value;
			 * 
			 * e.g.
			 * int x = 10;
			 * 
			 * In the line of code above, we're assigning the variable x the value
			 * of 10, but the function that is doin all the hardwork is the '='
			 * sign; that whole line is a assigment expression.
			 * The '=' is the assignemnt operator.
			 * */

			/*
			 * Compound assignment operators are are just shortcut in c#.
			 * e.g.
			 * x *= 2;
			 * */

			/*
			 * Left-associative.
			 * 
			 * In most cases, expressions are left-associative operators, meaning the
			 * order in get the value is from left to right.
			 * E.g.
			 * int x = 8 + 8 +1;
			 * 
			 * 
			 * Right-associative.
			 * 
			 * In situations like lambda, null-coalescing and conditional operator (?:),
			 * were they are evaluated from right to left.
			 * 
			 * E.g.
			 * bool x = 5 == 5 ? true : false;
			 * */
		}

		public static void NullOperators()
		{
			/*
			 * In c# there are operators that are used for checking null, these are know
			 * as null-operators.
			 * C# has two null-operator know as: null-coalescing and null-conditional.
			 * */

			/*
			 * Null-coalescing operator uses the ?? keyword determine if the variable
			 * is null.
			 * */
			string nstring = null;
			string nullCoalescing = nstring ?? "Default null coalescing value";
			/*
			 * Using ??, the compiler checks if the operand on the left side of the ?? is
			 * null; if it is, then the compiler uses the default value specified in the
			 * right side of ??.
			 * But if it does have a value, then it uses the operand on the left side.
			 * */

			string nc2 = nstring ?? "Default null coalescing value";
			/* is similar to */
			string nc3 = nstring == null ? "Default null coalescing value" : nstring;


			/*
			 * Null-conditional operator also know as an Elvis operator uses the ?. keyword
			 * to determine if the variable is null.
			 * */
			int? nElvis = null;
			string elvistValy = nElvis?.ToString();
			/*
			 * Using ?., the compiler checks if the operand on the left side of the ?. is
			 * null; if it is null, then the compiler leaves and returns a null.
			 * But if it does have a value, then it executes operand on the right side of the
			 * '?.' operator.
			 * */

			string elvisValy2 = nElvis?.ToString();
			/* is similat to */
			string elvisvaly3 = nElvis == null ? null : nElvis.ToString();
		}

		public static void DisplayFunctionalities()
        {
            System.Console.WriteLine("+: 10 + 100 = " + (10 + 100) );
            System.Console.WriteLine("-: 500 - 50 = " + (500 - 50) );
            System.Console.WriteLine("*: 1000 * 10 = " + (1000 * 10) );
            System.Console.WriteLine("/: 500 / 5 = " + (500 / 5) );
            System.Console.WriteLine("remainder of : 98 % 3 is " + (98 % 3));

            System.Console.WriteLine("");

            int nubmer = 100;
            System.Console.WriteLine("number++ : " + nubmer++);
            System.Console.WriteLine("number : " + nubmer);
            System.Console.WriteLine("++number : " + ++nubmer);

            System.Console.WriteLine("");

            int nubmer2 = 10;
            System.Console.WriteLine("number-- : " + nubmer2--);
            System.Console.WriteLine("number : " + nubmer2);
            System.Console.WriteLine("--number : " + --nubmer2);
        }

		public static void ConditionalOperator()
		{
			int rValOne = GetRandonValue(10, 20);
			int rValTwo = GetRandonValue(10, 20);

			/*
			 * The AND conditional operator outputs a true if both inputs are true.
			 * */
			Console.WriteLine($"AND operator: {rValOne == rValTwo && true}");

			/*
			 * The OR conditional operator outputs a true if one of the inputs is true.
			 * */
			Console.WriteLine($"OR operator: {rValOne == rValTwo || true}");
		}

		private static int GetRandonValue(int minvalue, int maxvalue)
		{
			int rValOne = new Random().Next(minvalue, maxvalue);
			System.Threading.Thread.Sleep(1000);
			return rValOne;
		}

		public static void BitwiseOperator()
		{
			/*
			 * The bitwise operator is used to compare the individual bit in the integer
			 * type variable.
			 * */

			int vOne = 10000;
			int vTwo = 15000;

			Console.WriteLine($"r1: {vOne} = {Convert.ToString(vOne, 2)}");
			Console.WriteLine($"r2: {vTwo} = {Convert.ToString(vTwo, 2)}");

			var result1 = vOne & vTwo;
			Console.WriteLine($"\nBitwise AND operator -");
			Console.WriteLine($"rt: {result1} = {Convert.ToString(result1, 2)}");

			var result2 = vOne | vTwo;
			Console.WriteLine($"\nBitwise OR operator -");
			Console.WriteLine($"rt: {result2} = {Convert.ToString(result2, 2)}");

			var result3 = vOne ^ vTwo;
			Console.WriteLine($"\nBitwise XOR operator -");
			Console.WriteLine($"rt: {result3} = {Convert.ToString(result3, 2)}");

			uint x = 0b_1101_1111;

			Console.WriteLine($"\nx: {x} = {Convert.ToString(x, 2)}");

			var result4 = x << 2;
			Console.WriteLine($"\nBitwise left shift operator -");
			Console.WriteLine($"rt: {result4} = {Convert.ToString(result4, 2)}");

			var result5 = x >> 2;
			Console.WriteLine($"\nBitwise right shift operator -");
			Console.WriteLine($"rt: {result5} = {Convert.ToString(result5, 2)}");
		}
    }
}