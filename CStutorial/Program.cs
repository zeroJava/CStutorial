using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CStutorial.Extensionmethod;

namespace CStutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            /*CStutorial.Basics.BasicsStuff obj = new Basics.BasicsStuff(5);
            obj.Adding(100);
            obj.Universal = true;
            obj.Value_of_object();
            obj.Universal = "String";
            obj.Value_of_object();
            obj.Universal = 1;
            obj.Value_of_object();*/

            /*CStutorial.Flowcontrols.IfelseStatements ifstatment = new Flowcontrols.IfelseStatements("Hnery", 25);
            ifstatment.CheckIfMatch("Gwady", 25);
            CStutorial.Flowcontrols.IfelseStatements statment2 = new Flowcontrols.IfelseStatements("Jane", 24);
            System.Console.WriteLine(ifstatment.Equals(statment2));*/

            /*CStutorial.Flowcontrols.Switchstatement statement = new Flowcontrols.Switchstatement();
            statement.Fruit = "Apple";
            statement.CheckinRepo();*/

            //CStutorial.Basics.MathematicalOperators.DisplayFunctionalities();

            //Arrays.Arraysexample arrys = new Arrays.Arraysexample();

            //List.Listexample list = new CStutorial.List.Listexample();

            /*int number = 5;
            int number2;
            CStutorial.Methods.PassbyReferenceParameters _passByRef = new Methods.PassbyReferenceParameters();
            _passByRef.ExecuteRef(ref number); // we have to use the keyword ref when invoking a method whose parameter has the ref keyword. 
            _passByRef.ExecuteOut(out number2);
            Console.WriteLine(number.ToString());
            Console.WriteLine(number2.ToString());*/

            /*CStutorial.Indexer.IndexerEg index = new Indexer.IndexerEg();
            index.Adddata();
            System.Console.WriteLine(index[1]);
            index[1] = "earth";
            System.Console.WriteLine(index[1]);*/

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

            System.Console.ReadKey();
        }
    }
}
