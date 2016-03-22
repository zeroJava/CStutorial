using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Extensionmethod
{
    public static class ExtensionmethodClass
    {
        public static void Display(this string name)
        {
            System.Console.WriteLine("hello " + name);
        }
    }

    /* Entension method is feature is c# that allows us to add methods existing class without the need of modifying the said class. 
     * So with extension methods, we can make a method in one class and attach to another class, and make the method behave as it is part of the latter class.
     * By making an extension method, we can now use the Display method above with any string classes
     * e.g.
     * string name = "John";
     * name.Display();
     * output :: hello John
     */

    /* Rule of extension methods
     * It must be a static method.
     * The class must be a static class.
     * the this keyword must be used as the first parameter in the extension method, so we can attach it to the class we want
     * when using the extension method, you must import the class e.g using cstutoial.extensionmethod
    */
}
