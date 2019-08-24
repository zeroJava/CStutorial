using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Switches
{
    class Switchclass
    {
        public int Value { get; set; }

        public void ListOfEverything()
        {
            switch(this.Value)
            {
                case 1:
                    System.Console.WriteLine("You are number 1");
                    break;
                case 2:
                    System.Console.WriteLine("You are number 2");
                    break;
                case 3:
                    System.Console.WriteLine("You are number 3");
                    break;
                case 4:
                    System.Console.WriteLine("Okay, this getting boring");
                    break;
                case 5:
                    System.Console.WriteLine("Still?");
                    break;
                case 6:
                    System.Console.WriteLine("Dude");
                    break;
                case 7:
                    System.Console.WriteLine("Realy");
                    break;
                default:
                    System.Console.WriteLine("Error");
                    break;
            }
        }

		public void ListOfEverythingType(object value)
		{
			/*
			 * From c# 7, you can switch using data types.
			 * */
			switch (value)
			{
				case int intValue when intValue == 5:
					/*
					 * You can also add an predicate to refine the condition.
					 * Note, specific condition using the when keyword must come before the
					 * generic condition, i.e. case with just the type;
					 * if place after a general type case, it will throw an compiler error.
					 * */
					Console.WriteLine("You're an int with the value of 5.");
					break;
				case int intValue when intValue == 15:
					Console.WriteLine("You are an int with the value if 15.");
					break;
				case int intValue:
					Console.WriteLine("You are an int value.");
					break;
				case string stringValue1 when stringValue1 == "Hello":
				case string stringValue2 when stringValue2 == "Hola":
				case string stringValue3 when stringValue3 == "Hello world":
					Console.WriteLine("Can be any string value, but not stringValue1, stringValue2 or stringValue3.");
					break;
				case bool boolValue:
					Console.WriteLine("You are a bool value.");
					break;
				default:
					System.Console.WriteLine("Error");
					break;
			}
		}
	}
}
