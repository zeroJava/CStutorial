using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CStutorial.Extensionmethod;
using CStutorial.Statics;

namespace CStutorial
{
	class Program
	{
		static void Main(string[] args)
		{
			// http://www.dotnetperls.com/collections

			//CStutorial.Basics.MathematicalOperators.DisplayFunctionalities();

			// ------------------------------------------ pass by reference happing here
			/*int number = 5;
            int number2;
            CStutorial.Methods.PassbyReferenceParameters _passByRef = new Methods.PassbyReferenceParameters();
            _passByRef.ExecuteRef(ref number); // we have to use the keyword ref when invoking a method whose parameter has the ref keyword. 
            _passByRef.ExecuteOut(out number2);
            Console.WriteLine(number.ToString());
            Console.WriteLine(number2.ToString());*/

			// -------------------------------------------- | Parameter arrays method (varargs) | ---

			// Methods.ParamaterArraysMethod.ListAllNames("John", "Mike", "MeHe", "Donkey");

			// -------------------------------------------- | Indexer | ---

			/*CStutorial.Indexer.IndexerEg index = new Indexer.IndexerEg();
            index.Adddata();
            System.Console.WriteLine(index[1]);
            index[1] = "earth";
            System.Console.WriteLine(index[1]);*/

			// -------------------------------------------- | Partial | ---

			/*CStutorial.Partialclass.Partialeg partial1 = new Partialclass.Partialeg();
            partial1.Name = "sigmund";
            partial1.Address = "Asg"; // These two properties have been written in different locations
            partial1.FirstLine();
            partial1.SecondLine(); // These two methods have been written in different locations */

			/*CStutorial.Structs.Structeg stre = new Structs.Structeg();
            stre.Id = 0582;*/

			//CStutorial.Abstracts.Animal cat = new CStutorial.Abstracts.Cat("Kitty", "Hello kitty");

			/*CStutorial.Inheritance.Class2 _class2 = new Inheritance.Class2("John", 25);
            _class2.Display(); */

			/*CStutorial.Switches.Switchclass switchclass = new Switches.Switchclass();
            switchclass.Value = 2;
            switchclass.ListOfEverything();*/

			/*string str = "displat";
            str.Display();*/ // Extension method being used here

			/*CStutorial.Delatges.DisplayData _display = new CStutorial.Delatges.DisplayData(Delatges.Delegateclass1.Method3);
            _display("Jonathane Smyth");

            CStutorial.Delatges.Delegateclass2 _delegate = new Delatges.Delegateclass2();
            _delegate.Execute(); */ // delegates being used here

			// ------------------------------------------------------- Collections

			//Arrays.Arraysexample arrys = new Arrays.Arraysexample();
			//List.Listexample list = new CStutorial.List.Listexample();
			//Set.Setexample _set = new Set.Setexample();
			//Dictionarys.Dictionaryexample _dictionary = new Dictionarys.Dictionaryexample();

			// ----------------------- solid principle -------------------------

			/*CStutorial.Solid.SingleResponsibility.User user1 = new Solid.SingleResponsibility.User(1, "JOHN SMITH", "LOWLAND");
            CStutorial.Solid.SingleResponsibility.Dispalyclass.Print(user1);
            CStutorial.Solid.SingleResponsibility.Dispalyclass.Print(new Solid.SingleResponsibility.User(2, "FRANK LOW", "HIGHLAND"));*/

			/*CStutorial.Solid.OpenClosed.Car car = new Solid.OpenClosed.Car();
            CStutorial.Solid.OpenClosed.Motorcycle motorcycle = new Solid.OpenClosed.Motorcycle();
            CStutorial.Solid.OpenClosed.Truck truck = new Solid.OpenClosed.Truck();
            System.Console.WriteLine(CStutorial.Solid.OpenClosed.AutomobileValidator.CheckIfAutomobile(car));
            System.Console.WriteLine(CStutorial.Solid.OpenClosed.AutomobileValidator.CheckIfAutomobile(motorcycle));
            System.Console.WriteLine(CStutorial.Solid.OpenClosed.AutomobileValidator.CheckIfAutomobile(truck));*/

			/*CStutorial.Solid.LiskovSubsitute.CarViolation supercarViolate = new Solid.LiskovSubsitute.SportsCarViolated(8, "sports");
            supercarViolate.SetEnginePower();
            System.Console.WriteLine(supercarViolate.GetEngineSize() + " " + supercarViolate.GetWheelType() + "\n GetEnginePower " + supercarViolate.GetEnginePower()); // look at Getenginepower in SportsCarViolated

            CStutorial.Solid.LiskovSubsitute.CarLSP superLSP = new Solid.LiskovSubsitute.SportsCarLSP(8, "sport");
            superLSP.SetEnginePower();
            System.Console.WriteLine(superLSP.GetEngineSize() + " " + superLSP.GetWheelType() + "\n GetEnginePower " + superLSP.GetEnginePower());*/ // look at GetEnginePower SportsCarLSP

			/*CStutorial.Solid.DependencyInversion.ICar super = new Solid.DependencyInversion.Supercar();
            CStutorial.Solid.DependencyInversion.ICar saloon = new Solid.DependencyInversion.Saloon();
            CStutorial.Solid.DependencyInversion.Validator.Validate(super);
            CStutorial.Solid.DependencyInversion.Validator.Validate(saloon);*/

			// --------------------------- | Inheritance methods | -------------------------------

			/*Inheritance.Methods.BaseClass _object1 = new Inheritance.Methods.SubClassTwo();
            _object1.MethodTwo();

            Inheritance.Methods.BaseClass _obhect2 = new Inheritance.Methods.SubClassOne();
            _obhect2.MethodOne(); // this object will use base class data type, and the methodone prevent late-binding.

            Inheritance.Methods.SubClassOne _object3 = new Inheritance.Methods.SubClassOne();
            _object3.MethodOne();*/

			//Inheritance.InheritClass1 class1 = new Inheritance.InheritClass2("abstract method 2");
			//Inheritance.InheritClass2 class2 = new Inheritance.InheritClass2("method 2");
			//StaticRuntimeOverloading.OvaLoad(class1);
			//StaticRuntimeOverloading.OvaLoad(class2);

			// ------------------------------- | Task master | -----------------------------------

			//System.Console.WriteLine(CStutorial.TaskMaster.Anagram.AreStringsAnagram("hello", "olhel"));
			//System.Console.WriteLine(CStutorial.TaskMaster.Anagram.IndexValueR2("abbccddddcccdda"));

			//CStutorial.Event.EventsExample1 _event1 = new Event.EventsExample1();
			//_event1.Display(); // This will trow an error

			/*CStutorial.Event.EventExample2 _event2 = new Event.EventExample2();
			_event2.Execute();*/

			// ----------------------------- | Func and Action | --------------------------------

			/*CStutorial.FuncsNActions.ActionExampleTwo _actionExaple2 = new FuncsNActions.ActionExampleTwo();
			_actionExaple2.Execute();*/

			// ----------------------------- | Generics methods | --------------------------------

			//CStutorial.Generics.GenericMethods<string>.Display("Hello");
			//CStutorial.Generics.GenericMethods<int>.Display(1);
			//CStutorial.Generics.GenericMethods<string>.DisplayData<int>(10000);
			//CStutorial.Generics.GenericMethods<string>.DisplayData<Arrays.Arraysexample>(new Arrays.Arraysexample());
			//CStutorial.Generics.GenericMethods<string>.DisplatGenricOfCertainType<Inheritance.Class1>(new Inheritance.Class1());

			// ----------------------------- | Generics | -----------------------------------------

			/*CStutorial.Generics.GenericClass<string> _gen1 = new Generics.GenericClass<string>();
			_gen1.Property1 = "Hello";
			_gen1.Property2 = "Yo";
			_gen1.Display();

			CStutorial.Generics.GenericClass<int> _gen2 = new Generics.GenericClass<int>();
			_gen2.Property1 = 1; // generic are type safe
			_gen2.Property2 = 2;
			_gen2.Display();

			CStutorial.Generics.GenericMethods<string>.Display("Hello");
			CStutorial.Generics.GenericMethods<int>.Display(54);

			CStutorial.Generics.GenericMethods<string>.DisplayData<string>("Sawg 74"); // it ingore the type parameter at the class name
			CStutorial.Generics.GenericMethods<string>.DisplayData("Sawg");
			CStutorial.Generics.GenericMethods<string>.DisplayData<int>(12345); // it ingore the type parameter at the class name
			CStutorial.Generics.GenericMethods<string>.DisplayData(732); // generics can automatically assign the data type of type parameter of the argument, by cheching the method argument
			*/

			// -------------------------------- | Generic Interface | -------------------------------- 

			/*CStutorial.Generics.GenericInterfaceClass _genericInterface = new Generics.GenericInterfaceClass();
			_genericInterface.GenericMethod2<string>("hello");
			_genericInterface.GenericMethod2<int>(5);*/

			// ------------------------------- | Polymorphism | ------------------------------

			//CStutorial.Polymorphisms.PolClass4 _polclass4 = new Polymorphisms.PolClass4();

			/*Castings.Collections.CastCollDemo demoll = new Castings.Collections.CastCollDemo();
			demoll.Execute();*/

			// ------------------------------ | Yield | ---------------------------------------

			//Yield.YieldEx.ExecuteYieldTest();

			// ------------------------------ | I/O Stream | ----------------------------------

			//StreamIO.BackstoreStreamTypeEg.PipeStreamExample(args);
			//StreamIO.DecoratorStreamTypeEg.BufferStreamExample();
			StreamIO.AdapterStreamTypeEg.TextAdapterExample();

			System.Console.ReadKey();
		}
	}
}