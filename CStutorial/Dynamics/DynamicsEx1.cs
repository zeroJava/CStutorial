using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Dynamics
{
    public class DynamicsEx1
    {
        /*
         * C# is a statically typed language, meaning
         * that the type of the variable is know by the
         * compiler at compile-time.
         * 
         * Also, once the variable has been assigned a
         * type, it cannot changed.
         * 
         * */

        /*
         * Static-type.
         * 
         * As mentioned, due to the fact that C# is
         * a statically typed programming language,
         * the compiler analyses the code, looking
         * for a match, and when can't find a method
         * that belongs to the type, then the compi-
         * ler will throw an error.
         * */

        public void ExecuteDynamicExample()
        {
            /*
             * In C#, we have a function that tells the
             * compiler to ignore all members for this
             * variable, and wait until run-time to bind.
             * 
             * This is know a Dynamic-Binding, which is
             * activated by using the dynamic keyword.
             * */

            dynamic dynamic1 = new InnerDynamicEx1();
            int number = dynamic1.GetMeANumber();
            try
            {
                /*
                 * Dynamic-Binding allows the compiler to
                 * ignore the member assigned to the var-
                 * iable, and waits for the binding to
                 * happen at run-time.
                 * */
                string str = dynamic1.GetMeAString();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error when using dynamic.");
            }
        }

        protected class InnerDynamicEx1
        {
            public int GetNumber { get; set; } = 10;

            public int GetMeANumber()
            {
                return 5 * 5;
            }
        }

        // https://android.jlelse.eu/magic-lies-here-statically-typed-vs-dynamically-typed-languages-d151c7f95e2b
    }
}