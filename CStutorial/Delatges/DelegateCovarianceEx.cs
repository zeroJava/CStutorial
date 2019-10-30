using CStutorial.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Delatges
{
	public delegate IExample1 DelCovarianceEx(string paramOne);
	public delegate void DelCovarianceExTwo(IExample1 example);

	/*
	 * 
	 * Delegates also have the covariance ability, meaning
	 * that a method with subclass data-type parameters
	 * can be assigned to a delegate with base class para-
	 * meters.
	 * */

	public class DelegateCovarianceEx
	{
		private void ExecuteExample()
		{
			/*
			 * The code below demonstrates covariance with
			 * delegates.
			 * 
			 * We see delegates with base data-types accep-
			 * ting methods are whose parameters are
			 * assigned with specific data-type belong to the
			 * type heirachy.
			 * */

			DelCovarianceEx contravarianceEx1 = DelegateExample;

			//DelCovarianceExTwo contravarianceExTwo = DelegateExampleTwo;
			/*
			 * This wont work with.
			 * */
		}

		private InterfaceExampleClass DelegateExample(object paramOne)
		{
			return new InterfaceExampleClass();
		}

		private void DelegateExampleTwo(InterfaceExampleClass interfaceExample)
		{
			Console.WriteLine("Example DelegateExampleTwo.");
		}
	}
}