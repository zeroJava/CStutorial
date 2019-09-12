using CStutorial.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Statics
{
	public static class StaticRuntimeOverloading
	{
		public static void OvaLoad(InheritClass1 inclass1)
		{
			Console.WriteLine("OvaLoad Base");
			inclass1.Display();
		}

		public static void OvaLoad(InheritClass2 inclass2)
		{
			Console.WriteLine("OvaLoad Subclass 2");
			inclass2.Display();
		}
	}
}
