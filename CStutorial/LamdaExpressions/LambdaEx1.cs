using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.LamdaExpressions
{
	public class LambdaEx1
	{
		/*
		 * A lamda is an expression is an unnamed method
		 * written in place of a delegate instance (AlBahari).
		 * 
		 * In other words, lambda is a block of exression
		 * that gets converted into a are just anonymous
		 * methods that is placed it to a delegate paremeter.
		 * 
		 * */

		/*
		 * When a lambda expression is written, the compiler
		 * converts it to either a delegate of expression.
		 * */

		public void Example()
		{
			/*
			 * Lambdas are structured as the following
			 * 
			 * (parameters) => expression
			 * 
			 * example below.
			 * 
			 * */

			Func<int, int> lambdaExpOne = x => 12 * 5;

			/*
			 * => means that this statement is going to a
			 * lambd expression.
			 * */

			/*
			 * The 'x' in the expression above represents
			 * the parameter, and the expressions after
			 * the => represents the body.
			 * 
			 * In other words, each lambda variable is an
			 * arugemnt, which represents a parameter from
			 * the delegate. 
			 * 
			 * Below demonstrates two parameters.
			 * */

			Func<int, int, string> lambdExpTwo = (x, y) => 12.ToString();

			/*
			 * When we have a delegate with two pararmeter,
			 * we have to put the lambd arguments inside the
			 * parentheses.
			 * */

			/*
			 * Normally the compiler will figure out the
			 * type of the lambda variable based on the
			 * delegate parameter.
			 * 
			 * It becomes difficult when dealing with
			 * generics. 
			 * 
			 * To resolve this, we have explictly specify
			 * the data type with the lambda variables.
			 * 
			 * Example below.
			 * */

			GenericMehodAction((int x, int y) => GenericMethodTest(x, y));

			/*
			 * Lambda expressions can access the variabes
			 * outside the lambda expression, but with the
			 * method scope.
			 * 
			 * This ability to accessing the variable from
			 * outside the expression is know as 'captured
			 * variable'.
			 * 
			 * The lambda expression that uses the variable
			 * is know a 'capture'.
			 * 
			 * */

			int number = 1;
			Func<int, int> multiply = x => number * x;
			number = 4;
			// The value of the captured variable is determined
			// at runtime when the delegate is invoked.
			Console.WriteLine(multiply(10));

			/*
			 * The lambda expression uses the value of the
			 * local variable (captured variable) at the
			 * time when the delegate is invoked, and NOT
			 * when the variable is capture and assigned to
			 * the lambda expression.
			 * 
			 * */

			/*
			 * Captured variables can have their lifespan
			 * increased, when the function holding the local
			 * variable returns a delegate instance.
			 * 
			 * Because local variables are always placed in
			 * the stack. So, when a local variable is cap-
			 * tured...
			 * 
			 * I think it moves the captured variable to the
			 * head.
			 * http://mustoverride.com/local_functions/
			 * 
			 * Or creates object with captured variables value
			 * as the value of one its member, i.e. hoise the
			 * captured variable into a hidden class (AlBahari).
			 * */

			/*
			 * As mention before, the lambda expression uses
			 * the value of the local variable (captured 
			 * variable) at the time when the delegate is
			 * invoked.
			 * 
			 * This applies to loops as well, meaning that if
			 * we a loop that is create a lambda expression,
			 * which is capturing the local variable of the
			 * loop, and then adding it to list of of
			 * delegates.
			 * 
			 * When we iterate through that list of delegates,
			 * and execute each one, the all show the same
			 * value for all the captured variables in the
			 * lambda expression.
			 * 
			 * This is because, c# treats the loops variable
			 * as a variable that has been created outside the
			 * loop. So when the lambd is invoked it gets the
			 * latest value of the variable, which the last
			 * iteration.
			 * */

			Func<int, int>[] funcArray = new Func<int, int>[3];
			for (int index = 0; index < funcArray.Length; index++)
			{
				funcArray[index] = x => index;
			}
			foreach (Func<int, int> val in funcArray)
			{
				Console.WriteLine(val.Invoke(1));
			}
		}

		private void GenericMehodAction<T, U>(Action<T, U> delegateIns)
		{
			//
		}

		private void GenericMethodTest<T, U>(T paramOne, U paramTwo)
		{
			//
		}
	}
}
// Joseph AlBahari and Ben AlBahari, C# 7.0 in a nutshell. 