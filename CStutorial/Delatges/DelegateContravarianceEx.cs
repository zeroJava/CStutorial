using CStutorial.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Delatges
{
	public delegate void DelContravarianceEx(string paramOne);
	public delegate void DelContravarianceExTwo(InterfaceExampleClass interfaceExample);

	/*
	 * Delegates also have the contravariance ability,
	 * meaning that a method with base data-type para-
	 * meters can be assigned to a delegate with sub-
	 * class parameters.
	 * */

	/*
	 * E.g.
	 * DelContravarianceExTwo contravarianceExTwo = DelegateExampleTwo;
	 * */

	public class DelegateContravarianceEx
	{
		private void ExecuteExample()
		{
			/*
			 * The code below demonstrates contravariance
			 * with delegates.
			 * 
			 * We see delegates with specific data-types
			 * accepting methods are whose parameters
			 * are replaced with generic data-type belong
			 * to the type heirachy.
			 * */

			DelContravarianceEx contravarianceEx1 = DelegateExample;
			DelContravarianceExTwo contravarianceExTwo = DelegateExampleTwo;
		}

		private void DelegateExample(object paramOne)
		{
			Console.WriteLine("Example DelegateExample.");
		}

		private void DelegateExampleTwo(IExample1 interfaceExample)
		{
			Console.WriteLine("Example DelegateExampleTwo.");
		}
	}
}