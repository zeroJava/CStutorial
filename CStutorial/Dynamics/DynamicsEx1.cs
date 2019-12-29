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
         * compiler at compile-time, and that once the
         * variable has been assigned a type, it cannot
         * changed.
         * 
         * */

        public void ExecuteDynamicExample()
        {
            /*
             * As mentioned, due to the fact that C# is
             * a statically typed programming language,
             * the compiler analyses the code, and when
             * there's something that does not make se-
             * nce to the compiler, it will throw an
             * compiler error.
             * */

            /*
             * In C#, we have a function that tells the
             * compiler to ignore this variable and all
             * the properties and function until run-
             * time.
             * 
             * This is know a Dynamic-Binding.
             * */

            dynamic dynamic1 = new InnerDynamicEx1();
            int number = dynamic1.GetMeANumber();
            try
            {
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