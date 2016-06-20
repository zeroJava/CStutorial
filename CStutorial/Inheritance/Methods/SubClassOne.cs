using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Inheritance.Methods
{
    class SubClassOne : BaseClass
    {
        /* The 'new' keyword hide the method from the base class in our sub-class. So in the eye of the compiler, it sees a brand new and independent method
         * in the sub-class that happens to have the same name as the method in the base class.
         * 
         * So when ever we invoke this method, it will call this one and not the base class version.
         * 
         * p.s. Using the 'new' prevents late-binding (polyorphism), and instead uses static-binding.
         * */
        public new void MethodOne()
        {
            System.Console.WriteLine("This is method one, the non -virtual method with 'new' in subclass one");
        }

        /* To override a method from the base class, we must mark the method with the keyword 'override'.
         * What this is doing is changing the definition of the virtual method from our base class in the sub-class.
         * 
         * Using the 'override' method allows the compiler to use the OOP feature late-binding (polymorphism), and in-turn complimenting polymorphism.
         * */
        public override void MethodTwo()
        {
            System.Console.WriteLine("This is method two, the overidden method in subclass one");
        }
    }
}
